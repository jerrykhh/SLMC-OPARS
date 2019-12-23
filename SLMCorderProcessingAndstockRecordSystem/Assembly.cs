using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using Logic.Controller;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Assembly : MaterialForm
    {
        private string barcode = "NOT_INITIALIZE";
        private string orderID;
        private SalesOrder main = new SalesOrder();
        private Controller objController;
        private DataTable dt;
        private const int EM_SETCUEBANNER = 0x1501;
        private string userID;
        public bool formClose = false, submit = false;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg,
               int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public Assembly(string orderID, string userID, bool viewOrder)
        {
            InitializeComponent();
            Zen.Barcode.Code128BarcodeDraw objBarcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBarcode.Image = objBarcode.Draw(barcode, 60);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            objController = new Controller();
            Closing += new CancelEventHandler(Assembly_Closing);
            this.orderID = orderID;
            this.userID = userID;
            barcode = orderID;
            setBarcode(orderID);

            if (viewOrder)
            {
                btnInput.Visible = false;
                btnSubmit.Visible = false;
                txtInput.Visible = false;
                dgAssmbly.ReadOnly = true;
            }
        }
        public void setBarcode(String code)
        {
            barcode = code;
        }

        private void Assembly_Load(object sender, EventArgs e)
        {

            dt = objController.orderDetail(orderID);
            lblDataDealerNo.Text = dt.Rows[0]["dealerID"].ToString();
            lblDataDealerName.Text = dt.Rows[0]["companyName"].ToString();
            lblDataContactName.Text = dt.Rows[0]["contactFirName"].ToString() + " " + dt.Rows[0]["contactLasName"].ToString();
            lblDataContactNo.Text = dt.Rows[0]["contactNo"].ToString();
            lblDataEmail.Text = dt.Rows[0]["email"].ToString();
            lblDataPostcode.Text = dt.Rows[0]["postcode"].ToString();
            lblDataCity.Text = dt.Rows[0]["city"].ToString();
            lblDataAddress.Text = dt.Rows[0]["Address"].ToString();
            lblSalesOrderNo.Text += " " + orderID;
            lblOrderAssembly.Text += orderID;
            SendMessage(txtInput.Handle, EM_SETCUEBANNER, 0, "Input ItemID...");
            dgInvoice.DataSource = objController.getOrderItemDetail(orderID);
            objController.itemAutoComplete(txtInput);

        }

        private void pldgOrderDetail_Paint(object sender, PaintEventArgs e)
        {
            main.plColorChage(Pens.Gray, e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            main.plColorChage(Pens.Gray, e);
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {

            if (objController.searchOrderEachItemDetail(txtInput.Text.Trim(), orderID))
            {
                for (int i = 0; i < dgInvoice.Rows.Count; i++)
                {
                    if (dgInvoice.Rows[i].Cells[0].Value.ToString() == txtInput.Text.Trim() && (int.Parse(dgInvoice.Rows[i].Cells[3].Value.ToString())) < 1)
                    {
                        MessageBox.Show(txtInput.Text.Trim() + " is Out-Of-Stock");
                        return;
                    }
                }
                DataTable result = objController.getOrderEachItemDetail(txtInput.Text.Trim(), orderID);
                objController.ReduceStock(txtInput.Text.Trim(), "1");
                objController.LogInputItem(userID, orderID, txtInput.Text.Trim());
                dgInvoice.DataSource = objController.getOrderItemDetail(orderID);
                this.dgAssmbly.Rows.Add(result.Rows[0]["itemID"].ToString(), result.Rows[0]["itemName"].ToString(), 1, result.Rows[0]["qtyOrdered"]);
                if (dgAssmbly.Rows.Count > 1)
                {
                    for (int i = 0; i < dgAssmbly.Rows.Count; i++)
                    {
                        int count = 0;
                        for (int j = 1; j < dgAssmbly.Rows.Count; j++)
                        {

                            if (i == j)
                                continue;
                            if (dgAssmbly.Rows[i].Cells[0].Value.ToString() == dgAssmbly.Rows[j].Cells[0].Value.ToString())
                            {
                                DataGridViewRow dgvDelRow = dgAssmbly.Rows[j];
                                dgAssmbly.Rows.Remove(dgvDelRow);
                                count++;
                            }

                        }
                        dgAssmbly.Rows[i].Cells[2].Value = (int.Parse(dgAssmbly.Rows[i].Cells[2].Value.ToString()) + count);
                    }
                }
                txtInput.Text = "";
            }
            else
            {
                MessageBox.Show("Item Not contain in order");
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (objController.createOrderAsswmbly(dgAssmbly, dgInvoice, orderID))
            {
                MessageBox.Show("Save");
                submit = true;
                this.Close();
            }
        }

        private void DgAssmbly_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r1 = this.dgAssmbly.CurrentRow;
            this.dgAssmbly.Rows.Remove(r1);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (dgAssmbly.Rows.Count == 0)
                this.Close();
            else
            {
                DialogResult mesBox = MessageBox.Show("Do you want to quit the " + orderID + " ?", "Cancel Assembly", MessageBoxButtons.YesNo);
                switch (mesBox)
                {
                    case DialogResult.Yes:
                        objController.cancelAssembly(dgAssmbly, userID, orderID);
                        this.Close();
                        break;
                    case DialogResult.No:
                        break;
                }
            }

        }
        private void Assembly_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgAssmbly.Rows.Count > 0 && !submit)
                objController.cancelAssembly(dgAssmbly, userID, orderID);

            formClose = true;
        }

        private void Assembly_Shown(object sender, EventArgs e)
        {
            if (dt.Rows[0]["status"].ToString() != "Processing" || dt.Rows[0]["orderHold"].ToString() == "1")
            {
                DialogResult mesBox = MessageBox.Show("order #" + orderID + " should not assembly ", "Order Assmbly", MessageBoxButtons.OK);
                switch (mesBox)
                {
                    case DialogResult.OK:
                        this.Close();
                        break;
                }
            }

        }
    }
}
