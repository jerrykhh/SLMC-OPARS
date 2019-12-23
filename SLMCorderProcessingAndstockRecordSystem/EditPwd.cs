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
    public partial class EditPwd : MaterialForm
    {
        private Controller objController;
        public bool formClose = false;
        private string userID, contrUserID;
        public EditPwd(string contrUserID, string userID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            Closing += new CancelEventHandler(EditPwd_Closing);
            objController = new Controller();
            this.userID = userID;
            this.contrUserID = contrUserID;
        }

        private void EditPwd_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            formClose = true;
        }

        private void EditPwd_Load(object sender, EventArgs e)
        {
            DataTable result = objController.getUserInf(userID);
            txtUsername.Text = result.Rows[0]["userName"].ToString();
            txtTitle.Text = result.Rows[0]["title"].ToString();
            cbDept.Text = result.Rows[0]["deptName"].ToString();
            txtPassword.Text = result.Rows[0]["userPassword"].ToString();
            txtPwdAgain.Text = result.Rows[0]["userPassword"].ToString();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            if (objController.updateUserInf(userID, txtUsername.Text.Trim(), txtPassword.Text.Trim(), txtPwdAgain.Text.Trim(), cbDept.GetItemText(this.cbDept.SelectedItem), txtTitle.Text.Trim()))
            {
                objController.LogupdateUserInf(contrUserID, userID);
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Please input same password");
            }
        }
    }
}
