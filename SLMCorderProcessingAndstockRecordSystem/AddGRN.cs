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
using MaterialSkin.Controls;
using MaterialSkin;

namespace WindowsFormsApplication1
{
    public partial class AddGRN : MaterialForm
    {
        public bool formClose;
        private Controller objController;
        private string userID;
        public AddGRN(string userID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            Closing += new CancelEventHandler(AddGRN_Closing);
            objController = new Controller();
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            formClose = false;
            this.userID = userID;
            dateRecDate.Value = DateTime.Now;
        }
        private void AddGRN_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            formClose = true;
        }
        private void AddGRN_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text == "" || txtLocation.Text == "" || txtPurchaseID.Text == "" || txtRecQty.Text == "")
            {
                lblError.Visible = true;
            }
            else
            {
                try
                {
                    if (objController.insertGRN(txtPurchaseID.Text.Trim(), txtItemID.Text.Trim(), txtRecQty.Text.Trim(), txtLocation.Text.Trim(), dateRecDate.Value.Date.ToString()))
                    {

                        objController.Addstock(txtItemID.Text.Trim(), txtRecQty.Text.Trim());
                        objController.LogInsertGRN(userID, txtPurchaseID.Text.Trim(), txtItemID.Text.Trim(), txtRecQty.Text.Trim());
                        MessageBox.Show("Good Recevied Note Saved");
                        txtBoxClear();
                    }
                    else
                    {
                        MessageBox.Show("Purchases Recevied");
                    }
                }
                catch
                {
                    MessageBox.Show("Purchases Error");
                }
            }
        }
        private void txtBoxClear()
        {
            txtItemID.Text = "";
            txtLocation.Text = "";
            txtPurchaseID.Text = "";
            txtRecQty.Text = "";
            dateRecDate.Value = DateTime.Now;
        }
    }
}
