using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using Logic.Controller;

namespace WindowsFormsApplication1
{
    public partial class AddUser : MaterialForm
    {
        private Controller objController;
        public bool formClose = false;
        private string userID;
        public AddUser(string userID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            Closing += new CancelEventHandler(AddUser_Closing);
            objController = new Controller();
            this.userID = userID;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            cbDept.DataSource = objController.getDept();
            cbDept.DisplayMember = "DeptName";

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            if (objController.insertUser(txtUsername.Text.Trim(), txtPassword.Text.Trim(), txtPwdAgain.Text.Trim(), cbDept.GetItemText(this.cbDept.SelectedItem), txtTitle.Text.Trim()))
            {
                objController.LoginsertUser(userID, txtUsername.Text.Trim(), txtTitle.Text.Trim());
                MessageBox.Show("User Created");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtPwdAgain.Text = "";
                txtTitle.Text = "";
            }
            else
            {
                MessageBox.Show("Confirm Password Wrong");
                txtPassword.Text = "";
                txtPwdAgain.Text = "";
            }
        }
        private void AddUser_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            formClose = true;
        }
    }
}
