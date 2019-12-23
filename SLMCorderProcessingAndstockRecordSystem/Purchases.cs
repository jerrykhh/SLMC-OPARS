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
    public partial class Purchases : Form
    {
        private Logic.Controller.Controller objController;
        public Purchases()
        {
            InitializeComponent();
            objController = new Logic.Controller.Controller();
        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            PurchasesLoad();
        }
        private void PurchasesLoad()
        {
            dgPurchases.DataSource = objController.getPurchases();
            lblTotalEntr.Text = "Showing " + dgPurchases.RowCount.ToString() + " Enteries";
        }

        private void pldgPurchases_Paint(object sender, PaintEventArgs e)
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

        private void plType_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
                PurchasesLoad();
            else
                dgPurchases.DataSource = objController.searchPurchases(txtSearch.Text.Trim());
            lblTotalEntr.Text = "Showing " + dgPurchases.RowCount.ToString() + " Enteries";
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            string formDate = DpFrom.Value.Date.ToString("yyyy-MM-dd");
            string toDate = DpTo.Value.Date.ToString("yyyy-MM-dd");
            dgPurchases.DataSource = objController.DateFilterPur(formDate, toDate);
        }

        private void Purchases_Shown(object sender, EventArgs e)
        {
            dgPurchases.ClearSelection();
            lblTotalEntr.Text = "Showing " + dgPurchases.RowCount.ToString() + " Enteries";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PurchasesLoad();
        }
    }
}
