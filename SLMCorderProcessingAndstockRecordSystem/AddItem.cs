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
    public partial class AddItem : MaterialForm
    {
        public bool formClose = false;
        private Controller objController;
        private string userID;
        public AddItem(string userID)
        {
            InitializeComponent();
            objController = new Controller();
            Closing += new CancelEventHandler(AddItem_Closing);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
            this.userID = userID;
        }
        private void AddItem_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            formClose = true;
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            cbCategroy.DataSource = objController.getItemCategory();
            cbCategroy.DisplayMember = "itemCategory";

        }

        private void PlBlackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (objController.insertItem(userID, txtName.Text.Trim(), txtPurchase.Text.Trim(), txtWareHouse.Text.Trim(), txtInStock.Text.Trim(), txtHold.Text.Trim(), txtDescription.Text.Trim(), txtStatus.Text.Trim(), cbCategroy.GetItemText(this.cbCategroy.SelectedItem), txtSalesPrice.Text.Trim(), txtReorder.Text.Trim(), txtDanger.Text.Trim(), txtAuto.Text.Trim(), txtDemand.Text.Trim()))
            {

                txtAuto.Text = "";
                txtDanger.Text = "";
                txtName.Text = "";
                txtDemand.Text = "";
                txtDescription.Text = "";
                txtHold.Text = "";
                txtInStock.Text = "";
                txtPurchase.Text = "";
                txtReorder.Text = "";
                txtSalesPrice.Text = "";
                txtStatus.SelectedItem = null;
                txtWareHouse.Text = "";
                cbCategroy.SelectedItem = null;
            }

        }
    }
}
