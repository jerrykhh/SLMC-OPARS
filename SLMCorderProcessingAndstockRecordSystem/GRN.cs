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

namespace WindowsFormsApplication1
{
    public partial class GRN : Form
    {
        private Controller objController;
        private AddGRN addGRN;
        private int index = -1;
        private string grnID, userID;
        private bool userPrem;
        public GRN(string userID, bool userPrem)
        {
            InitializeComponent();
            objController = new Controller();
            this.userID = userID;
            this.userPrem = userPrem;
            
        }



        private void PldgGRN_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.LightGray,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 1,
            e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        private void GRN_Load(object sender, EventArgs e)
        {
            GRNLoading();
            if (!userPrem)
                btnDel.Visible = false;
        }
        private void GRNLoading()
        {
            dgGRN.DataSource = objController.getGRN();
            lblTotalEntr.Text = "Showing " + dgGRN.RowCount.ToString() + " Enteries";
            
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            string formDate = DpFrom.Value.Date.ToString("yyyy-MM-dd");
            string toDate = DpTo.Value.Date.ToString("yyyy-MM-dd");
            dgGRN.DataSource = objController.DateFilterGRN(formDate, toDate);
            lblTotalEntr.Text = "Showing " + dgGRN.RowCount.ToString() + " Enteries";

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                GRNLoading();
            }
            else
            {
                dgGRN.DataSource = objController.searchGRN(txtSearch.Text.Trim());
                lblTotalEntr.Text = "Showing " + dgGRN.RowCount.ToString() + " Enteries";
            }

        }

        private void BtnAddGRN_Click(object sender, EventArgs e)
        {
            addGRN = new AddGRN(userID);
            addGRN.ShowDialog();
            if (addGRN.formClose)
                GRNLoading();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            GRNLoading();
        }

        private void DgGRN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgGRN.Rows[index];
                grnID = selectRow.Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void GRN_Shown(object sender, EventArgs e)
        {
            dgGRN.ClearSelection();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DialogResult mesBox = MessageBox.Show("Do you want to delete GRN#" + grnID, "Delete GRN", MessageBoxButtons.YesNo);
            switch (mesBox)
            {
                case DialogResult.Yes:
                    if (objController.deleteGRNRecord(grnID))
                    {
                        GRNLoading();
                        objController.LogdeleteGRNRecord(userID, grnID);
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
