using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Controller;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Diagnostics;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Orders : MaterialForm
    {
        SalesOrder main = new SalesOrder();
        private readonly MaterialSkinManager materialSkinManager;
        private Controller objController = new Controller();
        private string userID;
        public bool formClose;

        public Orders(string userID)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
            Closing += new CancelEventHandler(Order_Closing);
            formClose = false;
            this.userID = userID;
        }
        private void Order_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            formClose = true;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pldgSalesOrder_Paint(object sender, PaintEventArgs e)
        {
            main.plColorChage(Pens.Gray, e);
        }
        private void clear()
        {
            txtAddress.Text = "";
            txtContactName.Text = "";
            txtContactNumber.Text = "";
            txtDealerName.Text = "";
            txtDealerNumber.Text = "";
            txtDescription.Text = "";
            txtEmail.Text = "";
            txtPostcode.Text = "";
            txtSearch.Text = "";
            dgOrder.Rows.Clear();
            cbHold.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtDealerName.Text == "")
                chDealerName.Visible = true;
            else
                chDealerName.Visible = false;
            if (txtContactName.Text == "")
                chConactName.Visible = true;
            else
            {
                chConactName.Visible = false;
                if (!txtContactName.Text.Contains(" "))
                    chFormat.Visible = true;
                else
                    chFormat.Visible = false;

            }
            if (txtContactNumber.Text == "")
                chContactNo.Visible = true;
            else
                chContactNo.Visible = false;
            if (txtAddress.Text == "" || cbCity.Text == "" || txtPostcode.Text == "")
                chDelivery.Visible = true;
            else
                chDelivery.Visible = false;
            if (dgOrder.RowCount == 0)
                chItem.Visible = true;
            else
                chItem.Visible = false;

            ArrayList checkList = new ArrayList();
            for (int i = 0; i < dgOrder.Rows.Count; i++)
            {
                if (int.Parse(dgOrder.Rows[i].Cells[2].Value.ToString()) > 0)
                    checkList.Add(true);
                else
                    checkList.Add(false);
            }
            if (checkList.Contains(false))
                checkItemVal.Visible = true;
            else
                checkItemVal.Visible = false;


            if (chDealerName.Visible == false && chConactName.Visible == false && chDelivery.Visible == false && chItem.Visible == false && chFormat.Visible == false && !checkList.Contains(false))
            {
                bool hold = false;
                if (cbHold.Checked)
                    hold = true;
                string orderID;
                orderID = objController.createSalesOrder(txtDealerNumber.Text.Trim(), txtDealerName.Text.Trim(), txtContactName.Text.Trim(), txtContactNumber.Text.Trim(), txtEmail.Text.Trim(), txtAddress.Text.Trim(), cbCity.Text.Trim(), txtPostcode.Text.Trim(), dgOrder, hold, txtDescription.Text.Trim());
                objController.LogcreateSalesOrder(userID, orderID);
                clear();
            }


        }

        private void TxtDealerNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtDealerNumber.Text == "")
            {
                txtDealerName.Text = "";
                txtContactNumber.Text = "";
                txtContactName.Text = "";
                txtEmail.Text = "";
            }
            else if (objController.searchDealerID(txtDealerNumber.Text.Trim()))
            {
                DataTable result = objController.searchDealerDetail(txtDealerNumber.Text.Trim());
                txtDealerName.Text = result.Rows[0]["companyName"].ToString();
                txtContactNumber.Text = result.Rows[0]["contactNo"].ToString();
                txtContactName.Text = result.Rows[0]["contactLasName"].ToString() + " " + result.Rows[0]["contactLasName"].ToString();
                txtEmail.Text = result.Rows[0]["email"].ToString();
                txtAddress.Text = result.Rows[0]["Address"].ToString();
                txtPostcode.Text = result.Rows[0]["postcode"].ToString();
                cbCity.Text = result.Rows[0]["city"].ToString();
            }
            else
            {
                txtDealerName.Text = "";
                txtContactNumber.Text = "";
                txtContactName.Text = "";
                txtEmail.Text = "";
                txtAddress.Text = "";
                txtPostcode.Text = "";
                cbCity.Text = "";

            }

        }

        private void Orders_Load(object sender, EventArgs e)
        {
            objController.itemAutoComplete(txtSearch);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (objController.getItem(txtSearch.Text.Trim()))
            {
                for (int i = 0; i < dgOrder.Rows.Count; i++)
                {
                    if (dgOrder.Rows[i].Cells[0].Value.ToString() == txtSearch.Text.Trim() || dgOrder.Rows[i].Cells[1].Value.ToString() == txtSearch.Text.Trim())
                    {
                        txtSearch.Text = "";
                        MessageBox.Show("item is Added");
                        return;
                    }
                    if (int.Parse(dgOrder.Rows[i].Cells[2].Value.ToString()) == 0)
                    {
                        txtSearch.Text = "";
                        MessageBox.Show("itemQty not be 0");
                        return;
                    }
                }
                DataTable result = objController.searchOrderItemDetail(txtSearch.Text.Trim());
                this.dgOrder.Rows.Add(result.Rows[0]["itemID"].ToString(), result.Rows[0]["itemName"].ToString(), 0, result.Rows[0]["salesPrice"]);
                txtSearch.Text = "";
            }
        }

        private void DgOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            lblGrandTotal.Text = lblGrandTotal.Text.Substring(0, 12) + objController.dgCalutoritemTotalAmount(dgOrder);
        }

        private void DgOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r1 = this.dgOrder.CurrentRow;
            this.dgOrder.Rows.Remove(r1);
            lblGrandTotal.Text = lblGrandTotal.Text.Substring(0, 12) + objController.dgCalutoritemTotalAmount(dgOrder);

        }
    }
}
