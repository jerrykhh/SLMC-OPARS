namespace WindowsFormsApplication1
{
    partial class SalesOfficeReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOfficeReport));
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbSalesReport = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pldgSalesReport = new System.Windows.Forms.Panel();
            this.dgSalesOfficeReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.plCategory = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dpCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblDataProfit = new MaterialSkin.Controls.MaterialLabel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblDataCostVal = new MaterialSkin.Controls.MaterialLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDataSalesVol = new MaterialSkin.Controls.MaterialLabel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDataInvoice = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plItem = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dpItem = new System.Windows.Forms.ComboBox();
            this.lblItem = new MaterialSkin.Controls.MaterialLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.plSalesOfficeReport = new System.Windows.Forms.Panel();
            this.btnDownloadPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDownloadCSV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblSalesOfficeReport = new System.Windows.Forms.Label();
            this.plSalesReport = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalesReport)).BeginInit();
            this.panel3.SuspendLayout();
            this.pldgSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesOfficeReport)).BeginInit();
            this.plCategory.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.plItem.SuspendLayout();
            this.panel4.SuspendLayout();
            this.plSalesOfficeReport.SuspendLayout();
            this.plSalesReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.White;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(880, 53);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(46, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Profit";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(389, 52);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(102, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Sales Volume";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.White;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(648, 52);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(83, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Cost Value";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(145, 52);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "No. of invoices";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.barChart);
            this.panel5.Controls.Add(this.pbSalesReport);
            this.panel5.Controls.Add(this.materialLabel1);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(4, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1164, 188);
            this.panel5.TabIndex = 12;
            // 
            // barChart
            // 
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(288, 35);
            this.barChart.Name = "barChart";
            this.barChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Item";
            series1.YValuesPerPoint = 4;
            this.barChart.Series.Add(series1);
            this.barChart.Size = new System.Drawing.Size(613, 148);
            this.barChart.TabIndex = 6;
            this.barChart.Text = "chart1";
            // 
            // pbSalesReport
            // 
            this.pbSalesReport.Location = new System.Drawing.Point(288, 35);
            this.pbSalesReport.Name = "pbSalesReport";
            this.pbSalesReport.Size = new System.Drawing.Size(613, 148);
            this.pbSalesReport.TabIndex = 5;
            this.pbSalesReport.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(491, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(180, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Sales report (Best 5 item)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pldgSalesReport);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(3, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1164, 170);
            this.panel3.TabIndex = 11;
            // 
            // pldgSalesReport
            // 
            this.pldgSalesReport.Controls.Add(this.dgSalesOfficeReport);
            this.pldgSalesReport.Location = new System.Drawing.Point(25, 22);
            this.pldgSalesReport.Name = "pldgSalesReport";
            this.pldgSalesReport.Size = new System.Drawing.Size(1119, 130);
            this.pldgSalesReport.TabIndex = 8;
            this.pldgSalesReport.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgSalesReport_Paint);
            // 
            // dgSalesOfficeReport
            // 
            this.dgSalesOfficeReport.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgSalesOfficeReport.AllowUserToAddRows = false;
            this.dgSalesOfficeReport.AllowUserToDeleteRows = false;
            this.dgSalesOfficeReport.AllowUserToResizeColumns = false;
            this.dgSalesOfficeReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSalesOfficeReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSalesOfficeReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSalesOfficeReport.BackgroundColor = System.Drawing.Color.White;
            this.dgSalesOfficeReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSalesOfficeReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgSalesOfficeReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalesOfficeReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSalesOfficeReport.ColumnHeadersHeight = 40;
            this.dgSalesOfficeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgSalesOfficeReport.DoubleBuffered = true;
            this.dgSalesOfficeReport.EnableHeadersVisualStyles = false;
            this.dgSalesOfficeReport.GridColor = System.Drawing.Color.White;
            this.dgSalesOfficeReport.HeaderBgColor = System.Drawing.Color.White;
            this.dgSalesOfficeReport.HeaderForeColor = System.Drawing.Color.Black;
            this.dgSalesOfficeReport.Location = new System.Drawing.Point(4, 3);
            this.dgSalesOfficeReport.MultiSelect = false;
            this.dgSalesOfficeReport.Name = "dgSalesOfficeReport";
            this.dgSalesOfficeReport.ReadOnly = true;
            this.dgSalesOfficeReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalesOfficeReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSalesOfficeReport.RowHeadersVisible = false;
            this.dgSalesOfficeReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgSalesOfficeReport.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgSalesOfficeReport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgSalesOfficeReport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSalesOfficeReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgSalesOfficeReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSalesOfficeReport.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgSalesOfficeReport.RowTemplate.DividerHeight = 1;
            this.dgSalesOfficeReport.RowTemplate.Height = 30;
            this.dgSalesOfficeReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgSalesOfficeReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSalesOfficeReport.Size = new System.Drawing.Size(1113, 124);
            this.dgSalesOfficeReport.TabIndex = 6;
            // 
            // plCategory
            // 
            this.plCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plCategory.BackgroundImage")));
            this.plCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plCategory.Controls.Add(this.dpCategory);
            this.plCategory.GradientBottomLeft = System.Drawing.Color.White;
            this.plCategory.GradientBottomRight = System.Drawing.Color.White;
            this.plCategory.GradientTopLeft = System.Drawing.Color.White;
            this.plCategory.GradientTopRight = System.Drawing.Color.White;
            this.plCategory.Location = new System.Drawing.Point(267, 67);
            this.plCategory.Name = "plCategory";
            this.plCategory.Quality = 10;
            this.plCategory.Size = new System.Drawing.Size(192, 33);
            this.plCategory.TabIndex = 6;
            this.plCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.plCategory_Paint);
            // 
            // dpCategory
            // 
            this.dpCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpCategory.FormattingEnabled = true;
            this.dpCategory.Location = new System.Drawing.Point(0, 4);
            this.dpCategory.Name = "dpCategory";
            this.dpCategory.Size = new System.Drawing.Size(186, 29);
            this.dpCategory.TabIndex = 32;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Depth = 0;
            this.lblCategory.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategory.Location = new System.Drawing.Point(263, 45);
            this.lblCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 19);
            this.lblCategory.TabIndex = 28;
            this.lblCategory.Text = "Category";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.materialLabel6);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(4, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 85);
            this.panel2.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.lblDataProfit);
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.panel11.Location = new System.Drawing.Point(878, 13);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(147, 37);
            this.panel11.TabIndex = 15;
            // 
            // lblDataProfit
            // 
            this.lblDataProfit.AutoSize = true;
            this.lblDataProfit.BackColor = System.Drawing.Color.White;
            this.lblDataProfit.Depth = 0;
            this.lblDataProfit.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataProfit.Location = new System.Drawing.Point(3, 7);
            this.lblDataProfit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataProfit.Name = "lblDataProfit";
            this.lblDataProfit.Size = new System.Drawing.Size(116, 19);
            this.lblDataProfit.TabIndex = 3;
            this.lblDataProfit.Text = "materialLabel10";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.lblDataCostVal);
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.panel10.Location = new System.Drawing.Point(647, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(176, 37);
            this.panel10.TabIndex = 14;
            // 
            // lblDataCostVal
            // 
            this.lblDataCostVal.AutoSize = true;
            this.lblDataCostVal.BackColor = System.Drawing.Color.White;
            this.lblDataCostVal.Depth = 0;
            this.lblDataCostVal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataCostVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataCostVal.Location = new System.Drawing.Point(3, 7);
            this.lblDataCostVal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataCostVal.Name = "lblDataCostVal";
            this.lblDataCostVal.Size = new System.Drawing.Size(108, 19);
            this.lblDataCostVal.TabIndex = 3;
            this.lblDataCostVal.Text = "materialLabel9";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.lblDataSalesVol);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.panel6.Location = new System.Drawing.Point(387, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(176, 37);
            this.panel6.TabIndex = 12;
            // 
            // lblDataSalesVol
            // 
            this.lblDataSalesVol.AutoSize = true;
            this.lblDataSalesVol.BackColor = System.Drawing.Color.White;
            this.lblDataSalesVol.Depth = 0;
            this.lblDataSalesVol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataSalesVol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataSalesVol.Location = new System.Drawing.Point(3, 7);
            this.lblDataSalesVol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataSalesVol.Name = "lblDataSalesVol";
            this.lblDataSalesVol.Size = new System.Drawing.Size(108, 19);
            this.lblDataSalesVol.TabIndex = 3;
            this.lblDataSalesVol.Text = "materialLabel7";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.lblDataInvoice);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.panel8.Location = new System.Drawing.Point(143, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(190, 37);
            this.panel8.TabIndex = 11;
            // 
            // lblDataInvoice
            // 
            this.lblDataInvoice.AutoSize = true;
            this.lblDataInvoice.BackColor = System.Drawing.Color.White;
            this.lblDataInvoice.Depth = 0;
            this.lblDataInvoice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataInvoice.Location = new System.Drawing.Point(3, 7);
            this.lblDataInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataInvoice.Name = "lblDataInvoice";
            this.lblDataInvoice.Size = new System.Drawing.Size(94, 19);
            this.lblDataInvoice.TabIndex = 3;
            this.lblDataInvoice.Text = "lblDataItems";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.plItem);
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Controls.Add(this.plCategory);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(4, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 120);
            this.panel1.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnClear);
            this.panel9.Location = new System.Drawing.Point(639, 62);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(89, 39);
            this.panel9.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.Black;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = null;
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 90D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.OnHovercolor = System.Drawing.Color.Black;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(89, 39);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // plItem
            // 
            this.plItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plItem.BackgroundImage")));
            this.plItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plItem.Controls.Add(this.dpItem);
            this.plItem.GradientBottomLeft = System.Drawing.Color.White;
            this.plItem.GradientBottomRight = System.Drawing.Color.White;
            this.plItem.GradientTopLeft = System.Drawing.Color.White;
            this.plItem.GradientTopRight = System.Drawing.Color.White;
            this.plItem.Location = new System.Drawing.Point(37, 67);
            this.plItem.Name = "plItem";
            this.plItem.Quality = 10;
            this.plItem.Size = new System.Drawing.Size(192, 33);
            this.plItem.TabIndex = 29;
            this.plItem.Paint += new System.Windows.Forms.PaintEventHandler(this.plItem_Paint);
            // 
            // dpItem
            // 
            this.dpItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpItem.FormattingEnabled = true;
            this.dpItem.Location = new System.Drawing.Point(3, 4);
            this.dpItem.Name = "dpItem";
            this.dpItem.Size = new System.Drawing.Size(186, 29);
            this.dpItem.TabIndex = 31;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Depth = 0;
            this.lblItem.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItem.Location = new System.Drawing.Point(33, 45);
            this.lblItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(39, 19);
            this.lblItem.TabIndex = 30;
            this.lblItem.Text = "Item";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFilter);
            this.panel4.Location = new System.Drawing.Point(525, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(89, 39);
            this.panel4.TabIndex = 7;
            // 
            // btnFilter
            // 
            this.btnFilter.Activecolor = System.Drawing.Color.Black;
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.BorderRadius = 0;
            this.btnFilter.ButtonText = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFilter.Iconimage = null;
            this.btnFilter.Iconimage_right = null;
            this.btnFilter.Iconimage_right_Selected = null;
            this.btnFilter.Iconimage_Selected = null;
            this.btnFilter.IconMarginLeft = 0;
            this.btnFilter.IconMarginRight = 0;
            this.btnFilter.IconRightVisible = true;
            this.btnFilter.IconRightZoom = 0D;
            this.btnFilter.IconVisible = true;
            this.btnFilter.IconZoom = 90D;
            this.btnFilter.IsTab = false;
            this.btnFilter.Location = new System.Drawing.Point(0, 0);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilter.OnHovercolor = System.Drawing.Color.Black;
            this.btnFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilter.selected = false;
            this.btnFilter.Size = new System.Drawing.Size(89, 39);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.Textcolor = System.Drawing.Color.White;
            this.btnFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(30, 13);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(76, 37);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter";
            // 
            // plSalesOfficeReport
            // 
            this.plSalesOfficeReport.BackColor = System.Drawing.Color.White;
            this.plSalesOfficeReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSalesOfficeReport.Controls.Add(this.btnDownloadPDF);
            this.plSalesOfficeReport.Controls.Add(this.btnDownloadCSV);
            this.plSalesOfficeReport.Controls.Add(this.lblSalesOfficeReport);
            this.plSalesOfficeReport.Location = new System.Drawing.Point(4, 5);
            this.plSalesOfficeReport.Name = "plSalesOfficeReport";
            this.plSalesOfficeReport.Size = new System.Drawing.Size(1164, 71);
            this.plSalesOfficeReport.TabIndex = 0;
            // 
            // btnDownloadPDF
            // 
            this.btnDownloadPDF.Activecolor = System.Drawing.Color.Black;
            this.btnDownloadPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownloadPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownloadPDF.BorderRadius = 0;
            this.btnDownloadPDF.ButtonText = "Download PDF";
            this.btnDownloadPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadPDF.DisabledColor = System.Drawing.Color.Gray;
            this.btnDownloadPDF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadPDF.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDownloadPDF.Iconimage = null;
            this.btnDownloadPDF.Iconimage_right = null;
            this.btnDownloadPDF.Iconimage_right_Selected = null;
            this.btnDownloadPDF.Iconimage_Selected = null;
            this.btnDownloadPDF.IconMarginLeft = 0;
            this.btnDownloadPDF.IconMarginRight = 0;
            this.btnDownloadPDF.IconRightVisible = true;
            this.btnDownloadPDF.IconRightZoom = 0D;
            this.btnDownloadPDF.IconVisible = true;
            this.btnDownloadPDF.IconZoom = 90D;
            this.btnDownloadPDF.IsTab = false;
            this.btnDownloadPDF.Location = new System.Drawing.Point(933, 13);
            this.btnDownloadPDF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownloadPDF.Name = "btnDownloadPDF";
            this.btnDownloadPDF.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownloadPDF.OnHovercolor = System.Drawing.Color.Black;
            this.btnDownloadPDF.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDownloadPDF.selected = false;
            this.btnDownloadPDF.Size = new System.Drawing.Size(212, 45);
            this.btnDownloadPDF.TabIndex = 56;
            this.btnDownloadPDF.Text = "Download PDF";
            this.btnDownloadPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDownloadPDF.Textcolor = System.Drawing.Color.White;
            this.btnDownloadPDF.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadPDF.Click += new System.EventHandler(this.btnDownloadPDF_Click);
            // 
            // btnDownloadCSV
            // 
            this.btnDownloadCSV.Activecolor = System.Drawing.Color.Black;
            this.btnDownloadCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownloadCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownloadCSV.BorderRadius = 0;
            this.btnDownloadCSV.ButtonText = "Download CSV";
            this.btnDownloadCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadCSV.DisabledColor = System.Drawing.Color.Gray;
            this.btnDownloadCSV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadCSV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDownloadCSV.Iconimage = null;
            this.btnDownloadCSV.Iconimage_right = null;
            this.btnDownloadCSV.Iconimage_right_Selected = null;
            this.btnDownloadCSV.Iconimage_Selected = null;
            this.btnDownloadCSV.IconMarginLeft = 0;
            this.btnDownloadCSV.IconMarginRight = 0;
            this.btnDownloadCSV.IconRightVisible = true;
            this.btnDownloadCSV.IconRightZoom = 0D;
            this.btnDownloadCSV.IconVisible = true;
            this.btnDownloadCSV.IconZoom = 90D;
            this.btnDownloadCSV.IsTab = false;
            this.btnDownloadCSV.Location = new System.Drawing.Point(702, 13);
            this.btnDownloadCSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownloadCSV.Name = "btnDownloadCSV";
            this.btnDownloadCSV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownloadCSV.OnHovercolor = System.Drawing.Color.Black;
            this.btnDownloadCSV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDownloadCSV.selected = false;
            this.btnDownloadCSV.Size = new System.Drawing.Size(212, 45);
            this.btnDownloadCSV.TabIndex = 55;
            this.btnDownloadCSV.Text = "Download CSV";
            this.btnDownloadCSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDownloadCSV.Textcolor = System.Drawing.Color.White;
            this.btnDownloadCSV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadCSV.Click += new System.EventHandler(this.btnDownloadCSV_Click);
            // 
            // lblSalesOfficeReport
            // 
            this.lblSalesOfficeReport.AutoSize = true;
            this.lblSalesOfficeReport.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOfficeReport.Location = new System.Drawing.Point(19, 8);
            this.lblSalesOfficeReport.Name = "lblSalesOfficeReport";
            this.lblSalesOfficeReport.Size = new System.Drawing.Size(332, 50);
            this.lblSalesOfficeReport.TabIndex = 0;
            this.lblSalesOfficeReport.Text = "Sales Office Report";
            // 
            // plSalesReport
            // 
            this.plSalesReport.Controls.Add(this.panel3);
            this.plSalesReport.Controls.Add(this.panel5);
            this.plSalesReport.Controls.Add(this.panel2);
            this.plSalesReport.Controls.Add(this.panel1);
            this.plSalesReport.Controls.Add(this.plSalesOfficeReport);
            this.plSalesReport.Location = new System.Drawing.Point(1, 1);
            this.plSalesReport.Name = "plSalesReport";
            this.plSalesReport.Size = new System.Drawing.Size(1175, 673);
            this.plSalesReport.TabIndex = 3;
            // 
            // SalesOfficeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 669);
            this.Controls.Add(this.plSalesReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesOfficeReport";
            this.Text = "SalesOfficeReport";
            this.Load += new System.EventHandler(this.SalesOfficeReport_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalesReport)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pldgSalesReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesOfficeReport)).EndInit();
            this.plCategory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.plItem.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.plSalesOfficeReport.ResumeLayout(false);
            this.plSalesOfficeReport.PerformLayout();
            this.plSalesReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbSalesReport;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pldgSalesReport;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgSalesOfficeReport;
        private Bunifu.Framework.UI.BunifuGradientPanel plCategory;
        private MaterialSkin.Controls.MaterialLabel lblCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel plItem;
        private MaterialSkin.Controls.MaterialLabel lblItem;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel plSalesOfficeReport;
        private Bunifu.Framework.UI.BunifuFlatButton btnDownloadPDF;
        private Bunifu.Framework.UI.BunifuFlatButton btnDownloadCSV;
        private System.Windows.Forms.Label lblSalesOfficeReport;
        private System.Windows.Forms.Panel plSalesReport;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private System.Windows.Forms.Panel panel10;
        private MaterialSkin.Controls.MaterialLabel lblDataCostVal;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialLabel lblDataSalesVol;
        private System.Windows.Forms.Panel panel8;
        private MaterialSkin.Controls.MaterialLabel lblDataInvoice;
        private System.Windows.Forms.Panel panel11;
        private MaterialSkin.Controls.MaterialLabel lblDataProfit;
        private System.Windows.Forms.ComboBox dpCategory;
        private System.Windows.Forms.ComboBox dpItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
    }
}