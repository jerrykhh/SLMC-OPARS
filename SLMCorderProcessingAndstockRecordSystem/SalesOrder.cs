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
using Bunifu;
using BunifuAnimatorNS;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class SalesOrder : Form
    {
        private Orders createOrder;
        private ViewOrder viewOrder;
        private ViewOrder editOrder;
        private Logic.Controller.Controller objControlller;
        private string orderID;
        private int index = -1;
        string userID;
        private bool userPrem;

        public SalesOrder()
        {
            InitializeComponent();
            objControlller = new Logic.Controller.Controller();
        }

        public SalesOrder(string username, bool userPrem, string userID)
        {
            InitializeComponent();
            objControlller = new Logic.Controller.Controller();
            this.userPrem = userPrem;
            this.userID = userID;
            if (userPrem)
            {
                adminPerm();
            }
        }

        public void adminPerm()
        {

            btnEditOrder.Visible = true;
            btnDelOrder.Visible = true;
        }


        private void SalesOrder_Load(object sender, EventArgs e)
        {
            SalesOrderDataLoad();
        }

        private void SalesOrderDataLoad()
        {
            dgSalesOrder.DataSource = objControlller.getSalesOrderAllData();
        }


        private void plFilFrom_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
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

        private void plFilTo_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void SalesOrder_Shown(object sender, EventArgs e)
        {
            dgSalesOrder.ClearSelection();
            lblTotalEntr.Text = "Showing " + dgSalesOrder.RowCount.ToString() + " Enteries";
        }

        private void pldgSalesOrder_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            createOrder = new Orders(userID);
            createOrder.ShowDialog();
            if (createOrder.formClose)
                SalesOrderDataLoad();


        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                viewOrder = new ViewOrder(userID, orderID, userPrem);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select Order");
                return;
            }

            viewOrder.ShowDialog();

        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                editOrder = new ViewOrder(userID, orderID, userPrem, true);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select Order");
                return;
            }
            editOrder.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string formDate = DpFrom.Value.Date.ToString("yyyy-MM-dd");
            string toDate = DpTo.Value.Date.ToString("yyyy-MM-dd");


            if (ddStatus.SelectedIndex == -1)
                dgSalesOrder.DataSource = objControlller.DateAroundFilter(formDate, toDate);
            else
            {
                string status = ddStatus.Text.ToString();
                Debug.WriteLine(ddStatus.Text.ToString());
                dgSalesOrder.DataSource = objControlller.DateStatusFilterSalOrd(formDate, toDate, status);
            }
        }



        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            DialogResult mesBox = MessageBox.Show("Do you want to delete #" + orderID + " ?", "Cancel Order", MessageBoxButtons.YesNo);
            switch (mesBox)
            {
                case DialogResult.Yes:
                    if (objControlller.deleteRecord(orderID))
                        SalesOrderDataLoad();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void dgSalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgSalesOrder.Rows[index];
                orderID = selectRow.Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgSalesOrder.DataSource = objControlller.getSalesOrderAllData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
                SalesOrderDataLoad();
            else
                dgSalesOrder.DataSource = objControlller.searchOrder(txtSearch.Text.Trim());
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                objControlller.updateOrderHold(orderID);
                objControlller.LogupdateOrderHold(userID, orderID);
                SalesOrderDataLoad();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select Order");
                return;
            }
        }
    }
}
