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
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Users : Form
    {
        private Controller objController;
        private bool tabIndex;
        private AddUser addUser;
        private int index = -1;
        private string userID, contrUserID;
        private EditPwd editPwd;


        public Users(string userID)
        {
            InitializeComponent();
            objController = new Controller();
            tabIndex = true;
            this.contrUserID = userID;

        }

        private void pldgUsers_Paint(object sender, PaintEventArgs e)
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

        private void pldgUserLogging_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void plType_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {

            if (tabIndex)
            {
                if (dpDept.SelectedIndex == -1 && txtUsername.Text != "")
                    dgUsersInf.DataSource = objController.DataFilterUserInf(txtUsername.Text.Trim());
                else if (txtUsername.Text == "" && dpDept.SelectedIndex != -1)
                    dgUsersInf.DataSource = objController.DataFilterUserInf(dpDept.GetItemText(this.dpDept.SelectedItem), 1);
                else
                    dgUsersInf.DataSource = objController.DataFilterUserInf(txtUsername.Text.Trim(), dpDept.GetItemText(this.dpDept.SelectedItem));
                lblTotalEntr.Text = "Showing " + dgUsersInf.RowCount.ToString() + " Enteries";
            }
            else
            {
                if (dpDept.SelectedIndex == -1 && txtUsername.Text != "")
                    dgUserLogging.DataSource = objController.DataFilterUserLog(txtUsername.Text.Trim());
                else if (txtUsername.Text == "" && dpDept.SelectedIndex != -1)
                    dgUserLogging.DataSource = objController.DataFilterUserLog(dpDept.GetItemText(this.dpDept.SelectedItem), 1);
                else
                    dgUserLogging.DataSource = objController.DataFilterUserLog(txtUsername.Text.Trim(), dpDept.GetItemText(this.dpDept.SelectedItem));
                lblTotalEntr2.Text = "Showing " + dgUserLogging.RowCount.ToString() + " Enteries";

            }


        }

        private void Users_Load(object sender, EventArgs e)
        {
            dpDept.DataSource = objController.getDept();
            dpDept.DisplayMember = "deptName";
            lblTotalEntr.Text = "Showing " + dgUsersInf.RowCount.ToString() + " Enteries";
            lblTotalEntr2.Text = "Showing " + dgUserLogging.RowCount.ToString() + " Enteries";
            dgUsersInf.DataSource = objController.getUserInf();
            dgUserLogging.DataSource = objController.getUserLog();
            dpDept.SelectedItem = null;
            lblTotalEntr.Text = "Showing " + dgUsersInf.RowCount.ToString() + " Enteries";
        }

        private void Tabpage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabpage.SelectedTab == tabpage.TabPages["tpUser"])
            {
                tabIndex = true;
                dgUsersInf.ClearSelection();
            }
            else
            {
                tabIndex = false;
                dgUserLogging.ClearSelection();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text == "") 
                dgUserLogging.DataSource = objController.getUserLog();
            else
                dgUserLogging.DataSource = objController.searchUserLog(txtSearch.Text.Trim());

            lblTotalEntr.Text = "Showing " + dgUsersInf.RowCount.ToString() + " Enteries";

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (tabIndex)

                dgUsersInf.DataSource = objController.getUserInf();
            else
                dgUserLogging.DataSource = objController.getUserLog();

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            addUser = new AddUser(contrUserID);
            addUser.ShowDialog();
            if (addUser.formClose)
            {
                dgUsersInf.DataSource = objController.getUserInf();
                dgUsersInf.ClearSelection();
                dgUserLogging.DataSource = objController.getUserLog();
                dgUserLogging.ClearSelection();
            }
        }

        private void DgUsersInf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgUsersInf.Rows[index];
                userID = selectRow.Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void TxtSearchUserInf_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchUserInf.Text == "")
                dgUsersInf.DataSource = objController.getUserInf();
            else
                dgUsersInf.DataSource = objController.searchUserInf(txtSearchUserInf.Text.Trim());
        }

        private void BtnDelUser_Click(object sender, EventArgs e)
        {

            DialogResult mesBox = MessageBox.Show("Do you want to delete " + userID + " ?", "Delete User", MessageBoxButtons.YesNo);
            switch (mesBox)
            {
                case DialogResult.Yes:
                    if (objController.deleteUser(userID))
                    {
                        objController.LogdeleteUser(contrUserID, userID);
                        dgUsersInf.DataSource = objController.getUserInf();
                    }
                    else
                        MessageBox.Show("Delete Failed");
                    break;
                case DialogResult.No:
                    break;
            }

        }

        private void TxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                dgUserLogging.DataSource = objController.getUserLog();
            else
                dgUserLogging.DataSource = objController.searchUserLog(txtSearch.Text.Trim());
        }

        private void Users_Shown(object sender, EventArgs e)
        {
            dgUsersInf.ClearSelection();
            dgUserLogging.ClearSelection();

        }

        private void BtnEditPwd_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Please Select One User");
            }
            else
            {
                editPwd = new EditPwd(contrUserID, userID);
                editPwd.ShowDialog();
                if (editPwd.formClose)
                {
                    dgUsersInf.DataSource = objController.getUserInf();
                    dgUsersInf.ClearSelection();
                }


            }
        }
    }
}
