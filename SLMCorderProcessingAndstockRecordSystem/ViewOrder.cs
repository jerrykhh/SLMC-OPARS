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
using System.Diagnostics;

namespace WindowsFormsApplication1
{

    public partial class ViewOrder : MaterialForm
    {
        SalesOrder main = new SalesOrder();
        private bool modeSta;
        private string orderID, userID;
        private Logic.Controller.Controller objController;
        private DataTable dt = new DataTable();
        private bool perrmission;
        public ViewOrder()
        {
            InitializeComponent();
            modeSta = false;
            orderID = "";
            perrmission = false;
            objController = new Logic.Controller.Controller();
        }
        public ViewOrder(string userID, string orderID, Boolean perrmission)
        {
            InitializeComponent();
            checkModestatus(modeSta);
            objController = new Logic.Controller.Controller();
            this.perrmission = perrmission;
            this.orderID = orderID;
            modeSta = false;
            this.userID = userID;
        }
        public ViewOrder(string userID, string orderID, Boolean perrmission, Boolean editmode)
        {
            this.perrmission = perrmission;
            this.orderID = orderID;
            this.userID = userID;
            modeSta = editmode;
            InitializeComponent();
            checkModestatus(modeSta);
            objController = new Logic.Controller.Controller();

        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
            dt = objController.orderDetail(orderID);
            lblSalesOrder.Text += orderID;
            InfLoading();
            Permission();
        }
        public void InfLoading()
        {
            dt = objController.orderDetail(orderID);
            txtDealerNumber.Text = dt.Rows[0]["dealerID"].ToString();
            txtDealerName.Text = dt.Rows[0]["companyName"].ToString();
            txtContactName.Text = dt.Rows[0]["contactFirName"].ToString() + " " + dt.Rows[0]["contactLasName"].ToString();
            txtContactNumber.Text = dt.Rows[0]["contactNo"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtPostcode.Text = dt.Rows[0]["postcode"].ToString();
            txtCity.Text = dt.Rows[0]["city"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            dgOrderDetial.DataSource = objController.orderItemDetail(orderID);
            txtStatus.Text = objController.orderStatus(orderID);
        }
        public void setmodeSta(bool Mode)
        {
            modeSta = Mode;
        }
        private void pldgOrderDetail_Paint(object sender, PaintEventArgs e)
        {
            main.plColorChage(Pens.Gray, e);
        }
        public void Permission()
        {
            if (!perrmission)
            {
                btnEditmode.Visible = false;
                btnSave.Visible = false;
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void checkModestatus(bool mode)
        {
            if (modeSta)
            {
                btnEditmode.Text = "View Mode";
                txtAddress.Enabled = true;
                txtCity.Enabled = true;
                txtContactName.Enabled = true;
                txtContactNumber.Enabled = true;
                txtDealerName.Enabled = true;
                txtEmail.Enabled = true;
                txtPostcode.Enabled = true;
                btnSave.Visible = true;
                modeSta = false;
                txtStatus.Enabled = true;
                dgOrderDetial.ReadOnly = false;
                dgOrderDetial.AllowUserToAddRows = true;
                dgOrderDetial.AllowUserToDeleteRows = true;
                dgOrderDetial.ReadOnly = false;
            }
            else
            {
                btnEditmode.Text = "Edit Mode";
                txtAddress.Enabled = false;
                txtCity.Enabled = false;
                txtContactName.Enabled = false;
                txtContactNumber.Enabled = false;
                txtDealerName.Enabled = false;
                txtDealerNumber.Enabled = false;
                txtEmail.Enabled = false;
                txtPostcode.Enabled = false;
                btnSave.Visible = false;
                modeSta = true;
                txtStatus.Enabled = false;
                dgOrderDetial.AllowUserToDeleteRows = false;
                dgOrderDetial.AllowUserToAddRows = false;
                dgOrderDetial.ReadOnly = true;
            }
        }

        private void btnEditmode_Click(object sender, EventArgs e)
        {
            checkModestatus(modeSta);
        }
        public void customerMode()
        {
            btnEditmode.Visible = false;
            btnSave.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objController.updateDealer(txtDealerNumber.Text.Trim(), txtDealerName.Text.Trim(), txtContactName.Text.Trim(), txtContactNumber.Text.Trim(), txtEmail.Text.Trim(), txtPostcode.Text.Trim(), txtCity.Text.Trim(), txtAddress.Text.Trim(), txtStatus.Text.Trim(), orderID);
            objController.orderDelete(orderID);
            for (int i = 0; i < dgOrderDetial.Rows.Count - 1; i++)
            {
                objController.insertOrder(orderID, dgOrderDetial.Rows[i].Cells[0].Value.ToString(), dgOrderDetial.Rows[i].Cells[2].Value.ToString(), dgOrderDetial.Rows[i].Cells[3].Value.ToString());
            }
            objController.LogorderUpdate(userID, orderID);
            InfLoading();
            MessageBox.Show("Data Save");

        }

        private void dgOrderDetial_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgOrderDetial.SelectedRows)
            {
                dgOrderDetial.Rows.RemoveAt(item.Index);
            }
        }
    }
}
