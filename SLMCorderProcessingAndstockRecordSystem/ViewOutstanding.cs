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

namespace WindowsFormsApplication1
{
    public partial class ViewOutstanding : MaterialForm
    {
        private string outStandindID;
        private Logic.Controller.Controller objController;
        private DataTable result;
        SalesOrder main = new SalesOrder();
        public ViewOutstanding()
        {
            InitializeComponent();
            objController = new Logic.Controller.Controller();
        }
        public ViewOutstanding(string outsID)
        {
            InitializeComponent();
            outStandindID = outsID;
            objController = new Logic.Controller.Controller();
            result = new DataTable();
        }

        private void ViewOutstanding_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
            result = objController.getOutStanding(outStandindID);
            lblOutstanding.Text += outStandindID;
            lblDataAddress.Text = result.Rows[0]["Address"].ToString();
            lblDataCity.Text = result.Rows[0]["City"].ToString();
            lblDataContactName.Text = result.Rows[0]["contactFirName"].ToString() + " " + result.Rows[0]["contactLasName"].ToString();
            lblDataContactNo.Text = result.Rows[0]["contactNo"].ToString();
            lblDataDealerName.Text = result.Rows[0]["companyName"].ToString();
            lblDataDealerNo.Text = result.Rows[0]["dealerID"].ToString();
            lblDataEmail.Text = result.Rows[0]["email"].ToString();
            lblDataPostcode.Text = result.Rows[0]["postcode"].ToString();
            lblSalesOrderNo.Text += result.Rows[0]["orderID"].ToString();
            lblDataDate.Text = result.Rows[0]["OutstandingDate"].ToString();
            dgOutstanding.Rows.Add(result.Rows[0]["itemID"].ToString(), result.Rows[0]["itemName"].ToString(), result.Rows[0]["followUp"].ToString(), result.Rows[0]["salesPrice"].ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pldgOrderDetail_Paint(object sender, PaintEventArgs e)
        {
            main.plColorChage(Pens.LightGray, e);
        }
    }
}
