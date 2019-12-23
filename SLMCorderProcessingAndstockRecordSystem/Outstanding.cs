using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Outstanding : Form
    {
        private SalesOrder salesOrder = new SalesOrder();
        private ViewOutstanding viewOutstanding;
        private Logic.Controller.Controller objController;
        private string userName;
        private bool userperm;
        private int index;
        private string outStandingID;
        public Outstanding()
        {
            InitializeComponent();
            objController = new Logic.Controller.Controller();
            index = -1;
        }
        public Outstanding(string userName, bool userPerm)
        {
            InitializeComponent();
            objController = new Logic.Controller.Controller();
            this.userName = userName;
            this.userperm = userPerm;
            index = -1;

        }


        private void Outstanding_Load(object sender, EventArgs e)
        {
            dgOutstandingLoad();
            lblTotalEntr.Text = "Showing " + dgOutstanding.RowCount.ToString() + " Enteries";
        }

        private void dgOutstandingLoad()
        {
            dgOutstanding.DataSource = objController.getOutStanding();
            lblTotalEntr.Text = "Showing " + dgOutstanding.RowCount.ToString() + " Enteries";
        }

        private void plFilTo_Paint(object sender, PaintEventArgs e)
        {
            salesOrder.plColorChage(Pens.LightGray, e);
        }

        private void plFilFrom_Paint(object sender, PaintEventArgs e)
        {
            salesOrder.plColorChage(Pens.LightGray, e);
        }

        private void pldgSalesOrder_Paint(object sender, PaintEventArgs e)
        {
            salesOrder.plColorChage(Pens.LightGray, e);
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                viewOutstanding = new ViewOutstanding(outStandingID);
            }
            catch
            {
                MessageBox.Show("Select Order");
                return;
            }
            viewOutstanding.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
                dgOutstandingLoad();
            else
                dgOutstanding.DataSource = objController.searchOutStanding(txtSearch.Text.Trim());
            lblTotalEntr.Text = "Showing " + dgOutstanding.RowCount.ToString() + " Enteries";
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            DialogResult mesBox = MessageBox.Show("Do you want to delete " + outStandingID + " ?", "Delete Outstanding Order", MessageBoxButtons.YesNo);
            switch (mesBox)
            {
                case DialogResult.Yes:
                    if (objController.deleteOutRecord(outStandingID))
                        dgOutstandingLoad();
                    lblTotalEntr.Text = "Showing " + dgOutstanding.RowCount.ToString() + " Enteries";
                    break;
                case DialogResult.No:
                    break;
            }

        }

        private void dgOutstanding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgOutstanding.Rows[index];
                outStandingID = selectRow.Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            string formDate = DpFrom.Value.Date.ToString("yyyy-MM-dd");
            string toDate = DpTo.Value.Date.ToString("yyyy-MM-dd");
            dgOutstanding.DataSource = objController.DateFilterOutstand(formDate, toDate);
            lblTotalEntr.Text = "Showing " + dgOutstanding.RowCount.ToString() + " Enteries";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            dgOutstandingLoad();
        }

        private void Outstanding_Shown(object sender, EventArgs e)
        {
            dgOutstanding.ClearSelection();
            lblTotalEntr.Text = "Showing " + dgOutstanding.RowCount.ToString() + " Enteries";
        }
    }
}
