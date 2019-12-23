using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Controller;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class OrderReturn : MaterialForm
    {
        private Controller objController;
        private string userID;
        private int index = -1;
        private string orderID, itemID, itemQty;
        public OrderReturn(string userID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
            objController = new Controller();
            this.userID = userID;
        }

        private void pldgOrderReturn_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }
        private void orderReturnLoad()
        {
            dgOrderReturn.DataSource = objController.getOrderReturn();
        }

        public void plColorChage(Pen Color, PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(Color,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 1,
            e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        private void OrderReturn_Load(object sender, EventArgs e)
        {
            orderReturnLoad();
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemID.Text.Trim() == "" && txtQty.Text.Trim() == "")
                {
                    objController.insertOrderReturn(txtInput.Text.Trim());
                    objController.LoginsertOrderReturn(userID, txtInput.Text.Trim());
                    orderReturnLoad();
                }
                else if (txtItemID.Text == "" || txtQty.Text == "")
                {
                    MessageBox.Show("Please Input the itemID Or item Qty");
                }
                else
                {
                    objController.insertOrderReturn(txtInput.Text.Trim(), txtItemID.Text.Trim(), txtQty.Text.Trim());
                    objController.LoginsertOrderReturn(userID, txtInput.Text.Trim(), txtItemID.Text.Trim(), txtQty.Text.Trim());
                    orderReturnLoad();
                }
            }
            catch
            {
                MessageBox.Show("Please input another order!");
            }

        }

        private void TxtInput_Enter(object sender, EventArgs e)
        {
            try
            {
                objController.insertOrderReturn(txtInput.Text.Trim());
                objController.LoginsertOrderReturn(userID, txtInput.Text.Trim());
                orderReturnLoad();
            }
            catch
            {
                MessageBox.Show("Can't input the same ID.");
            }

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgOrderReturn.DataSource = objController.searchOrderReturn(txtSearch.Text.Trim());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (index > -1)
            {

                if (objController.updateComplete(orderID, itemID, itemQty))
                {
                    MessageBox.Show("Saved");
                    txtInput.Text = "";
                    txtItemID.Text = "";
                    txtQty.Text = "";
                    dgOrderReturn.DataSource = objController.getOrderReturn();
                    //dateRecDate.Value = DateTime.Now; 
                }
                else
                {
                    MessageBox.Show("Input Wrong");
                }
            }
        }

        private void dgOrderReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgOrderReturn.Rows[index];
                orderID = selectRow.Cells[0].Value.ToString();
                itemID = selectRow.Cells[1].Value.ToString();
                itemQty = selectRow.Cells[3].Value.ToString();
            }
            catch
            {
            }
        }
    }
}
