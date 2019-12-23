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
    public partial class Invoice : Form
    {
        private SalesOrder salesOrder = new SalesOrder();
        private ViewInvoice viewInvoice;
        private Logic.Controller.Controller objController;
        private int index = -1;
        private string invoiceID, userID;
        private bool userPrem;
        public Invoice(string userID, bool userPrem)
        {
            InitializeComponent();
            objController = new Logic.Controller.Controller();
            this.userPrem = userPrem;
            this.userID = userID;
        }
        private void Invoice_Load(object sender, EventArgs e)
        {
            InvoiceLoad();
            if (!userPrem)
            {
                btnDelOrder.Visible = false;
            }
        }
        private void InvoiceLoad()
        {
            dgInvoice.DataSource = objController.getInvoice();
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

        private void plDestin_Paint(object sender, PaintEventArgs e)
        {
            salesOrder.plColorChage(Pens.LightGray, e);
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {

            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                viewInvoice = new ViewInvoice(invoiceID);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please Select One Invoice");
                return;
            }
            viewInvoice.ShowDialog();

        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            string formDate = DpFrom.Value.Date.ToString("yyyy-MM-dd");
            string toDate = DpTo.Value.Date.ToString("yyyy-MM-dd");
            dgInvoice.DataSource = objController.DateFilterInv(formDate, toDate);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
                InvoiceLoad();
            else
                dgInvoice.DataSource = objController.searchInvoice(txtSearch.Text.Trim());
        }

        private void DgInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgInvoice.Rows[index];
                invoiceID = selectRow.Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void BtnDelOrder_Click(object sender, EventArgs e)
        {
            if (objController.deleteRecordInv(invoiceID))
            {
                objController.LogdeleteRecordInv(userID, invoiceID);
                InvoiceLoad();
            }
            else
            {
                MessageBox.Show("Delete Invoice " + invoiceID + " Fail");
            }
        }

        private void Invoice_Shown(object sender, EventArgs e)
        {
            dgInvoice.ClearSelection();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            InvoiceLoad();
        }
    }
}
