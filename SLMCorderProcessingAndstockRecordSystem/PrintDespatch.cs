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
    public partial class PrintDespatch : MaterialForm
    {
        public bool formClose;
        private string orderID;
        private string deliveryID;
        private string invoiceID;
        private Controller objController;

        public PrintDespatch(string orderID, string deliveryID, string invoiceID)
        {
            InitializeComponent();
            objController = new Controller();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            Closing += new CancelEventHandler(PrintDespatch_Closing);
        }

        private void PrintDespatch_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            formClose = true;
        }

        private void PrintDespatch_Load(object sender, EventArgs e)
        {
            DataTable result = objController.getDespatch(orderID, deliveryID, invoiceID);
            txtOrderID.Text = result.Rows[0]["orderID"].ToString();
            txtDeliveryID.Text = result.Rows[0]["deliveryID"].ToString();
            txtDeliveryDate.Text = result.Rows[0]["deliveryDate"].ToString();
            DataTable result2 = objController.invoiceDetail(invoiceID);
            txtInvoiceID.Text = result.Rows[0]["invoiceID"].ToString();
            txtDealerID.Text = result.Rows[0]["dealerID"].ToString();
            txtPickUpDate.Text = result.Rows[0]["pickupDate"].ToString();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print Successful!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
