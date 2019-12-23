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
    public partial class ViewInvoice : MaterialForm
    {
        private string invoiceID;
        private Logic.Controller.Controller objController;
        private DataTable result;
        private SalesOrder main = new SalesOrder();
        private bool print;
        Bitmap bmp;
        public ViewInvoice()
        {
            InitializeComponent();
        }

        public ViewInvoice(string invoice)
        {
            InitializeComponent();
            this.invoiceID = invoice;
            print = false;

        }
        public ViewInvoice(string invoiceID, bool print)
        {
            InitializeComponent();
            this.invoiceID = invoiceID;
            this.print = print;
        }

        private void ViewInvoice_Load(object sender, EventArgs e)
        {
            objController = new Logic.Controller.Controller();
            result = new DataTable();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
            result = objController.invoiceDetail(invoiceID);
            lblInvoice.Text += invoiceID;
            lblDataAddress.Text = result.Rows[0]["Address"].ToString();
            lblDataCity.Text = result.Rows[0]["City"].ToString();
            lblDataContactName.Text = result.Rows[0]["contactFirName"].ToString() + " " + result.Rows[0]["contactLasName"].ToString();
            lblDataContactNo.Text = result.Rows[0]["contactNo"].ToString();
            lblDataDealerName.Text = result.Rows[0]["companyName"].ToString();
            lblDataDealerNo.Text = result.Rows[0]["dealerID"].ToString();
            lblDataEmail.Text = result.Rows[0]["email"].ToString();
            lblDataPostcode.Text = result.Rows[0]["postcode"].ToString();
            lblSalesOrderNo.Text += result.Rows[0]["orderID"].ToString();
            lblDataDate.Text = result.Rows[0]["pickupDate"].ToString();
            dgInvoice.DataSource = objController.getOrderItem(result.Rows[0]["orderID"].ToString());
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PldgOrderDetail_Paint(object sender, PaintEventArgs e)
        {
            main.plColorChage(Pens.LightGray, e);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

             e.Graphics.DrawImage(bmp, 0, 0);

        }

        private void ViewInvoice_Shown(object sender, EventArgs e)
        {
            if (print)
            {
                btnPrint.Visible = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, graphics);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X+35, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
