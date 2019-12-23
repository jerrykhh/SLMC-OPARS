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
    public partial class EditItem : MaterialForm
    {
        private string itemID, userID;
        private Logic.Controller.Controller objController;
        private DataTable result;
        public bool formClose = false;
        public EditItem(string userID, String itemID)
        {
            InitializeComponent();
            objController = new Controller();
            result = new DataTable();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
            Closing += new CancelEventHandler(EditItem_Closing);
            this.itemID = itemID;
            this.userID = userID;

        }

        private void EditItem_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            formClose = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formClose = true;
            this.Close();
        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            EditLoad();
        }
        private void EditLoad()
        {
            cbCategroy.DataSource = objController.getItemCategory();
            cbCategroy.DisplayMember = "itemCategory";
            result = objController.getItemDetail(itemID);
            txtDanger.Text = result.Rows[0]["dangerlevel"].ToString();
            txtDescription.Text = result.Rows[0]["Description"].ToString();
            txtHold.Text = result.Rows[0]["Hold"].ToString();
            txtItemNo.Text = result.Rows[0]["itemID"].ToString();
            txtName.Text = result.Rows[0]["itemName"].ToString();
            txtPurchase.Text = result.Rows[0]["purPrice"].ToString();
            txtReorder.Text = result.Rows[0]["reorderLevel"].ToString();
            txtSalesPrice.Text = result.Rows[0]["salesPrice"].ToString();
            txtWareHouse.Text = result.Rows[0]["wareHouse"].ToString();
            cbCategroy.Text = result.Rows[0]["itemCategory"].ToString();
            txtInStock.Text = result.Rows[0]["quantityInStock"].ToString();
            txtAuto.Text = result.Rows[0]["autoPur"].ToString();
            txtDemand.Text = result.Rows[0]["demand"].ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ((objController.updateItem(itemID, txtName.Text.Trim(), txtPurchase.Text.Trim(), txtWareHouse.Text.Trim(), txtInStock.Text.Trim(), txtHold.Text.Trim(), txtDescription.Text.Trim(), txtStatus.Text.Trim(), cbCategroy.GetItemText(this.cbCategroy.SelectedItem), txtSalesPrice.Text.Trim(), txtReorder.Text.Trim(), txtDanger.Text.Trim(), txtAuto.Text.Trim(), txtDemand.Text.Trim())))
            {
                objController.LogupdateItem(userID, itemID);
                EditLoad();
            }
            else
                MessageBox.Show("Update Error");
        }
    }
}
