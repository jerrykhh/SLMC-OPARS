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
using System.Collections;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class SalesOfficeReport : Form
    {
        Controller objController;
        private string userID;
        public SalesOfficeReport(string userID)
        {
            objController = new Controller();
            InitializeComponent();
            this.userID = userID;
        }

        private void pldgSalesReport_Paint(object sender, PaintEventArgs e)
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

        private void plItem_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void plCategory_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void plType_Paint(object sender, PaintEventArgs e)
        {
            plColorChage(Pens.LightGray, e);
        }

        private void SalesOfficeReport_Load(object sender, EventArgs e)
        {
            lblDataInvoice.Text = objController.getCountInvoice();
            dpItem.DataSource = objController.getSalesReportItem();
            dpCategory.DataSource = objController.getItemCategory();
            dpItem.DisplayMember = "itemID";
            dpCategory.DisplayMember = "itemCategory";
            dpCategory.SelectedItem = null;
            dpItem.SelectedItem = null;
            DataTable result = objController.getReportCount();
            for (int i = 0; i < 5; i++) {
                barChart.Series["Item"].Points.AddXY(result.Rows[i][0].ToString(), result.Rows[i][1].ToString());
            }
            lblDataCostVal.Font = new Font("Roboto", 20, FontStyle.Regular);
            lblDataInvoice.Font = new Font("Roboto", 20, FontStyle.Regular);
            lblDataProfit.Font = new Font("Roboto", 20, FontStyle.Regular);
            lblDataSalesVol.Font = new Font("Roboto", 20, FontStyle.Regular);
            dpItem.SelectedIndex = -1;
            dpCategory.SelectedIndex = -1;
            defaultLoad();
            
            
        }

        private void defaultLoad()
        {

            dgSalesOfficeReport.DataSource = objController.getSalesReport();
            getDataGridVal();
        }
       private void getDataGridVal()
        {
           string[] reportVal = objController.getSaleReportAnal(dgSalesOfficeReport);
            DataTable dt = new DataTable();
            storeVal(reportVal, dt);
        }
        private void storeVal(string[] data, DataTable dataTable)
        {
            
            lblDataSalesVol.Text = data[0];
            lblDataCostVal.Text = data[1];
            lblDataProfit.Text = data[2];
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (dpCategory.SelectedIndex == -1 && dpItem.SelectedIndex>-1)
            {
                Debug.WriteLine(dpItem.SelectedValue.ToString());
                dgSalesOfficeReport.DataSource = objController.DataFilterReportSalesItem(dpItem.Text);
                
                getDataGridVal();
            }else if(dpItem.SelectedIndex==-1 && dpCategory.SelectedIndex > -1)
            {
                Debug.WriteLine("TESTPOINT2");
                dgSalesOfficeReport.DataSource = objController.DataFilterReportSalesCat(dpCategory.Text);
                getDataGridVal();
            }else if (dpItem.SelectedIndex > -1 && dpCategory.SelectedIndex > -1)
            {
                dgSalesOfficeReport.DataSource = objController.DataFilterReportSalesCatItem(dpItem.Text,dpCategory.Text);
            }
            
                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
             defaultLoad();
            dpCategory.Text = "";
            dpItem.Text = "";

             
        }

        private void btnDownloadCSV_Click(object sender, EventArgs e)
        {
            string textExport = "";
            int countRows = dgSalesOfficeReport.RowCount;
            int countCells = dgSalesOfficeReport.Rows[0].Cells.Count;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = path + "\\salesOfficeReport.csv";

            for (int row_index = 0; row_index < dgSalesOfficeReport.RowCount; row_index++)
            {
                for (int cell_index = 0; cell_index < countCells; cell_index++)
                {
                    textExport = textExport + dgSalesOfficeReport.Rows[row_index].Cells[cell_index].Value.ToString() + ", ";
                }
                textExport += "\r\n";
            }
            System.IO.File.WriteAllText(filepath, textExport);
            MessageBox.Show("Your Sales Office Report form being exported on desktop");
            objController.LogPrintSalesOfficeReportCSV(userID);

        }

        private void btnDownloadPDF_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "SLCM .Ltd Order Processing And Stock Record System";
            printer.SubTitle = "Sales Office Report in " + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "End Of Page";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgSalesOfficeReport);
            objController.LogPrintSalesOfficeReportPDF(userID);

        }
    }
}
