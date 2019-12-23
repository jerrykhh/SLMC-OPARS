using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Controller;
using DGVPrinterHelper;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class StockRecordReport : Form
    {
        Controller objController;
        private string userID;
        public StockRecordReport(string userID)
        {
            this.userID = userID;
            InitializeComponent();
            objController = new Controller();
        }

        private void pldgStockRcordReport_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }
        public void plColorChage(Pen Color, PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(Color,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 1,
            e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        private void plCategory_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgStockReport.DataSource = objController.DataFilterReportItem(dpCategory.selectedValue.ToString());
            StockReportLoad();

        }

        private void StockRecordReport_Load(object sender, EventArgs e)
        {
            defaultLoad();


        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                defaultLoad();
            }
            else
            {
                dgStockReport.DataSource = objController.getReportItem(txtSearch.Text);
                StockReportLoad();
            }
        }
        private void defaultLoad()
        {
            dgStockReport.DataSource = objController.getReportItem();
            StockReportLoad();
        }
        private void StockReportLoad()
        {
            string[] getReportVal = objController.getReportAnal(dgStockReport);
            storeVal(getReportVal);
        }
        private void storeVal(string[] getReportVal)
        {
            lblDataItems.Text = getReportVal[0];
            lblDataStockHand.Text = getReportVal[1];
            lblDataCostVal.Text = getReportVal[2];
            lblTotalEntr.Text = "Showing " + dgStockReport.RowCount.ToString() + " Enteries";
            lblDataItems.Font = new Font("Roboto", 20, FontStyle.Regular);
            lblDataStockHand.Font = new Font("Roboto", 20, FontStyle.Regular);
            lblDataCostVal.Font = new Font("Roboto", 20, FontStyle.Regular);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            defaultLoad();
        }

        private void btnDownloadCSV_Click(object sender, EventArgs e)
        {
            string textExport = "";
            int countRows = dgStockReport.RowCount;
            int countCells = dgStockReport.Rows[0].Cells.Count;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = path + "\\StockRecordReport.csv";

            for (int row_index = 0; row_index < dgStockReport.RowCount; row_index++)
            {
                for (int cell_index = 0; cell_index < countCells; cell_index++)
                {
                    textExport = textExport + dgStockReport.Rows[row_index].Cells[cell_index].Value.ToString() + ", ";
                }
                textExport += "\r\n";
            }
            System.IO.File.WriteAllText(filepath, textExport);
            MessageBox.Show("Your Stock Record Report form being exported on desktop");
            objController.LogPrintStockReportCSV(userID);

        }


        private void btnDownloadPDF_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "SLCM .Ltd Order Processing And Stock Record System";
            printer.SubTitle = "Stock Record Report in " + string.Format("Date: {0}",DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "End Of Page";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgStockReport);
            objController.LogPrintStockReport(userID);
      /*    Graphics graphics = this.CreateGraphics();
            bmp = new Bitmap(1390, 920, graphics);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();*/
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         /*   e.Graphics.DrawImage(bmp, 0, 0);*/
        }
    }
}
