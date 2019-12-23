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
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;



namespace WindowsFormsApplication1
{
    public partial class Dashboard : Form
    {
        private Controller objController = new Controller();
        public Dashboard()
        {
            InitializeComponent();
            ChartLoad();
            totalNoOfOrders();
            totalQtyOrdered();
        }
        void ChartLoad()
        {
            DataTable roleA = new DataTable();
            DataTable roleB = new DataTable();
            DataTable roleC = new DataTable();
            DataTable dt = new DataTable();
            DataTable roleD = objController.getItemOnHandD();
            roleA = objController.getItemOnHandA();
            roleB = objController.getItemOnHandB();
            roleC = objController.getItemOnHandC();
               DataTable dtClonedA = roleA.Clone();
               dtClonedA.Columns[1].DataType = typeof(String);
               foreach (DataRow row in roleA.Rows)
               {
                   dtClonedA.ImportRow(row);
               }
            DataTable dtClonedB = roleB.Clone();
            dtClonedB.Columns[1].DataType = typeof(String);
            foreach (DataRow row in roleB.Rows)
            {
                dtClonedB.ImportRow(row);
            }
            DataTable dtClonedC = roleC.Clone();
            dtClonedC.Columns[1].DataType = typeof(String);
            foreach (DataRow row in roleC.Rows)
            {
                dtClonedC.ImportRow(row);
            }
            DataTable dtClonedD = roleD.Clone();
            dtClonedD.Columns[1].DataType = typeof(String);
            foreach (DataRow row in roleD.Rows)
            {
                dtClonedD.ImportRow(row);
            }

            dt.Merge(dtClonedA);
            dt.Merge(dtClonedB);
            dt.Merge(dtClonedC);
            dt.Merge(dtClonedD);
            chart1.Series.Add("A-Sheet Metal");
               chart1.Series["A-Sheet Metal"].ChartType = SeriesChartType.Line;
               chart1.Series["A-Sheet Metal"].Color = Color.Black;
               chart1.Series["A-Sheet Metal"].XValueType = ChartValueType.DateTime;
               chart1.Series["A-Sheet Metal"].XValueMember = "orderDateA";
               chart1.Series["A-Sheet Metal"].YValueMembers = "SUMA";


               chart1.Series.Add("B-Major Asssemblies");
               chart1.Series["B-Major Asssemblies"].ChartType = SeriesChartType.Line;
               chart1.Series["B-Major Asssemblies"].Color = Color.Blue;
               chart1.Series["B-Major Asssemblies"].XValueMember = "orderDateB";
               chart1.Series["B-Major Asssemblies"].YValueMembers = "SUMB";

              
               chart1.Series.Add("C-Light Components");
               chart1.Series["C-Light Components"].ChartType = SeriesChartType.Line;
            chart1.Series["C-Light Components"].Color = Color.Brown;
               chart1.Series["C-Light Components"].XValueMember = "orderDateC";
               chart1.Series["C-Light Components"].YValueMembers = "SUMC";
               chart1.Series.Add("D-Accessories");
               chart1.Series["D-Accessories"].ChartType = SeriesChartType.Line;
               chart1.Series["D-Accessories"].Color = Color.Red;
               chart1.Series["D-Accessories"].XValueMember = "orderDateD";
               chart1.Series["D-Accessories"].YValueMembers = "SUMD";
            chart1.DataSource = dt;

            chart1.DataBind();
        }

        void totalNoOfOrders()
        {
            txtTotalNoOfOrders.Text = objController.getDashVal();
        }

        void totalQtyOrdered()
        {
            DataTable qtyDes = objController.getTotalQtyOrdered();
            txtTotalQtyOrdered.Text = qtyDes.Rows[0]["SUM"].ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (objController.findMMFDIS())
            {
                DataTable result = objController.getMMForm();

                lblMes2.Text = result.Rows[0][1].ToString();
                txtMes3.Text = result.Rows[0][2].ToString();
            }
        }
    }

}
