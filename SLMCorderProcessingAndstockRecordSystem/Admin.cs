using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Admin : Form
    {
        private MergencyMesgForm mergencyMesgForm;
        private Logic.Controller.Controller objController;
        private MergencyMesgForm ViewMessage;
        private MergencyMesgForm EditMessage;
        private MergencyMesgForm AnnouceMessage;
        private int index = -1;
        private String mesID;
        private String userID;

        public Admin(string userID)
        {
            InitializeComponent();
            objController = new Logic.Controller.Controller();
            this.userID = userID;
        }

        private void btnAddnewmessage_Click(object sender, EventArgs e)
        {
            mergencyMesgForm = new MergencyMesgForm(userID);
            mergencyMesgForm.ShowDialog();
            if (mergencyMesgForm.formClose)
            {
                dgMergMessage.DataSource = objController.Mermessage();
            }
        }



        private void pldgMM_Paint(object sender, PaintEventArgs e)
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

        private void btnViewMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                ViewMessage = new MergencyMesgForm(null, mesID);
                Debug.WriteLine(mesID);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select Message");
                return;
            }
            ViewMessage.ShowDialog();
        }

        private void btnEditMessage_Click(object sender, EventArgs e)
        {

            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                EditMessage = new MergencyMesgForm(userID, mesID);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select Message");
                return;
            }
            EditMessage.ShowDialog();
        }

        private void btnAnnouceMessage_Click(object sender, EventArgs e)
        {

        }

        private void dgSalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgMergMessage.Rows[index];
                mesID = selectRow.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }




        private void btnDelMessage_Click(object sender, EventArgs e)
        {

            DialogResult mesBox = MessageBox.Show("Do you want to delete " + mesID + " ?", "Delete Item", MessageBoxButtons.YesNo);
            switch (mesBox)
            {
                case DialogResult.Yes:
                    if (objController.deleteMessage(mesID))
                        dgMergMessage.DataSource = objController.Mermessage();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
                dgMergMessage.DataSource = objController.Mermessage();
            else
                dgMergMessage.DataSource = objController.searchMergMessage(txtSearch.Text.Trim());
        }

        private void Admin_Load_1(object sender, EventArgs e)
        {
            dgMergMessage.DataSource = objController.Mermessage();
        }

        private void DgMergMessage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgMergMessage.Rows[index];
                mesID = selectRow.Cells[0].Value.ToString();
            }
            catch
            {
            }
        }


        private void Admin_Shown(object sender, EventArgs e)
        {
            dgMergMessage.ClearSelection();
        }

        private void btnViewMessage_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                ViewMessage = new MergencyMesgForm(null, mesID);
                Debug.WriteLine(mesID);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select Message");
                return;
            }
            ViewMessage.ShowDialog();
        }

        private void btnEditMessage_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                EditMessage = new MergencyMesgForm(userID, mesID);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select Message");
                return;
            }
            EditMessage.ShowDialog();
        }

        private void Admin_Shown_1(object sender, EventArgs e)
        {
            dgMergMessage.ClearSelection();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
                dgMergMessage.DataSource = objController.Mermessage();
            else
                dgMergMessage.DataSource = objController.searchMergMessage(txtSearch.Text.Trim());

        }

        private void btnDelMessage_Click_1(object sender, EventArgs e)
        {
            DialogResult mesBox = MessageBox.Show("Do you want to delete " + mesID + " ?", "Delete Item", MessageBoxButtons.YesNo);
            switch (mesBox)
            {
                case DialogResult.Yes:
                    Debug.WriteLine(mesID);
                    if (objController.deleteMessage(mesID))
                    {

                        dgMergMessage.DataSource = objController.Mermessage();
                        objController.LoginsertMessage(userID);
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
