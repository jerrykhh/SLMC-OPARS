using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Despatch : Form
    {
        private OrderReturn orderReturn;
        private AddDespatch addDespatch;
        private ViewInvoice printDespatch;
        private bool userPrem = false;
        private Logic.Controller.Controller objController;
        private string userID;
        private int index=-1;
        private string deliveryID;
        private string invoiceID;
        public Despatch(string userID, bool userPrem)
        {
            InitializeComponent();
            this.userPrem = userPrem;
            this.userID = userID;
            objController = new Logic.Controller.Controller();
        }

        private void Despatch_Load(object sender, EventArgs e)
        {
            DespatchLoad();
        }
        private void DespatchLoad()
        {
            dgDelivery.DataSource = objController.getDespatch();
        }

        private void pldgDespatch_Paint(object sender, PaintEventArgs e)
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

        private void plFilFrom_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void plFilTo_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void btnOrderReturn_Click(object sender, EventArgs e)
        {
            orderReturn = new OrderReturn(userID);
            orderReturn.ShowDialog();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            addDespatch = new AddDespatch(userID);
            addDespatch.ShowDialog();
            if (addDespatch.formClose)
                DespatchLoad();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgDelivery.DataSource = objController.searchDespatch(txtSearch.Text.Trim());
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            string formDate = DpFrom.Value.Date.ToString("yyyy-MM-dd");
            string toDate = DpTo.Value.Date.ToString("yyyy-MM-dd");
            dgDelivery.DataSource = objController.DateFilterDepatch(formDate, toDate);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DespatchLoad();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                printDespatch = new ViewInvoice(invoiceID, true);
                printDespatch.ShowDialog();
            }
            catch(IndexOutOfRangeException) {
                MessageBox.Show("Pleaes Select the Order");
            }
        }

   

        private void Despatch_Shown(object sender, EventArgs e)
        {
            dgDelivery.ClearSelection();
        }

        private void dgDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgDelivery.Rows[index];
                invoiceID = selectRow.Cells[2].Value.ToString();
            }
            catch
            {
            }
        }
    }
}
