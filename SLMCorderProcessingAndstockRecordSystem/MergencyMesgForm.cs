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
using Logic.Controller;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class MergencyMesgForm : MaterialForm
    {
        private string userID;
        private string mesID;
        private Controller objController;
        private Boolean whichcon;
        public bool formClose = false;

        public MergencyMesgForm(string userID, string mesID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
            objController = new Controller();
            Closing += new CancelEventHandler(MergencyMesgForm_Closing);
            this.userID = userID;
            this.mesID = mesID;
            Debug.WriteLine(mesID);
            whichcon = false;
        }


        public MergencyMesgForm(string userID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
            objController = new Controller();
            Closing += new CancelEventHandler(MergencyMesgForm_Closing);
            this.userID = userID;
            mesID = null;
            whichcon = true;
        }
        private void MergencyMesgForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            formClose = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) && string.IsNullOrEmpty(txtmergDes.Text))
            {
                this.Close();
            }
            else
            {
                DialogResult mesBox = MessageBox.Show("Do you want to cancel ?", "Cancel Message", MessageBoxButtons.YesNo);
                switch (mesBox)
                {
                    case DialogResult.Yes:
                        this.Close();
                        break;
                    case DialogResult.No:
                        break;
                }
            }


        }

        private void btnMesSubmit_Click(object sender, EventArgs e)
        {
            Debug.Write(whichcon);
            if (whichcon == true)
            {
                Debug.Write("TEST POINT2");
                if (objController.insertMessage(txtTitle.Text.Trim(), txtmergDes.Text, userID))
                {
                    objController.LoginsertMessage(userID);

                    MessageBox.Show("Add Message Sucessfully");
                    txtmergDes.Text = "";
                    txtTitle.Text = "";
                }
                else
                {
                    MessageBox.Show("Cannot add message, please try again");
                }



            }
            else
            {

                if (objController.updateMessage(txtTitle.Text.Trim(), txtmergDes.Text, userID, mesID))
                {
                    Debug.Write("TEST POINT1");
                    objController.LogupdateMessage(userID);

                    MessageBox.Show("Edit Message Sucessfully");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot edit message, please try again");
                }

            }
        }

        private void MergencyMesgForm_Load(object sender, EventArgs e)
        {
            if (!whichcon)
            {
                DataTable result = objController.getMMForm(mesID);
                txtmergDes.Text = result.Rows[0]["mergDes"].ToString();
                txtTitle.Text = result.Rows[0]["Title"].ToString();
            }
            if (string.IsNullOrEmpty(userID))
            {
                btnMesSubmit.Visible = false;
                txtmergDes.ReadOnly = true;
                txtTitle.Enabled = false;
            }
        }

        private void btnMesSubmit_Click_1(object sender, EventArgs e)
        {
            Debug.Write(whichcon);
            if (whichcon == true)
            {
                Debug.Write("TEST POINT2");
                if (objController.insertMessage(txtTitle.Text.Trim(), txtmergDes.Text, userID))
                {
                    objController.LoginsertMessage(userID);

                    MessageBox.Show("Add Message Sucessfully");
                    txtmergDes.Text = "";
                    txtTitle.Text = "";
                }
                else
                {
                    MessageBox.Show("Cannot add message, please try again");
                }



            }
            else
            {

                if (objController.updateMessage(txtTitle.Text.Trim(), txtmergDes.Text, userID, mesID))
                {
                    Debug.Write("TEST POINT1");
                    objController.LogupdateMessage(userID);

                    MessageBox.Show("Edit Message Sucessfully");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot edit message, please try again");
                }

            }
        }

        private void MergencyMesgForm_Load_1(object sender, EventArgs e)
        {
            if (!whichcon)
            {
                DataTable result = objController.getMMForm(mesID);
                txtmergDes.Text = result.Rows[0]["mergDes"].ToString();
                txtTitle.Text = result.Rows[0]["Title"].ToString();
            }
            if (string.IsNullOrEmpty(userID))
            {
                btnMesSubmit.Visible = false;
                txtmergDes.ReadOnly = true;
                txtTitle.Enabled = false;
            }
        }
    }
}
