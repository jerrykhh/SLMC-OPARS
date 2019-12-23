using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using Logic.Controller;
using MaterialSkin.Controls;
using MaterialSkin;

namespace WindowsFormsApplication1
{
    public partial class Login : MaterialForm
    {
        private nav mainPage;
        Controller objControlller;
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            objControlller = new Controller();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            picPassword.Visible = true;
            picAccount.Visible = true;
        }

        private void txtAccount_Click(object sender, EventArgs e)
        {
            picPassword.Visible = true;
            picAccount.Visible = false;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            picAccount.Visible = true;
            picPassword.Visible = false;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if (objControlller.verityUser(txtAccount.Text.Trim(), txtPassword.Text.Trim()))
            {
                objControlller.LogverityUser(objControlller.getUserID(txtAccount.Text.Trim()));
                mainPage = new nav(txtAccount.Text.Trim(), objControlller.getPermission(txtAccount.Text.Trim()), objControlller.getUserID(txtAccount.Text.Trim()));
                mainPage.ShowDialog();
                this.Close();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys keyPressed = (Keys)msg.WParam.ToInt32();
            switch (keyPressed)
            {
                case Keys.Enter:
                case Keys.Tab:
                    Control ctrl = this.GetNextControl(this.ActiveControl, true);
                    while (ctrl is TextBox == false)
                    {
                        ctrl = this.GetNextControl(ctrl, true);
                    }
                    ctrl.Focus();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
