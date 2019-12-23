namespace WindowsFormsApplication1
{
    partial class StockRecordReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockRecordReport));
            this.btnDownloadPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblStockRecordReport = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plStockReport = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalEntr = new MaterialSkin.Controls.MaterialLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSearch = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgStockReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pldgStockRcordReport = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDataItems = new MaterialSkin.Controls.MaterialLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDataStockHand = new MaterialSkin.Controls.MaterialLabel();
            this.lblCostValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalUnit = new MaterialSkin.Controls.MaterialLabel();
            this.lblItems = new MaterialSkin.Controls.MaterialLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDataCostVal = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plCategory = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dpCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblCategory = new MaterialSkin.Controls.MaterialLabel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.plStockRecordReport = new System.Windows.Forms.Panel();
            this.btnDownloadCSV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel4.SuspendLayout();
            this.plStockReport.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.plCategory.SuspendLayout();
            this.plStockRecordReport.SuspendLayout();
            this.SuspendLayout();
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
            // lblStockRecordReport
            // 
            this.lblStockRecordReport.AutoSize = true;
            this.lblStockRecordReport.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockRecordReport.Location = new System.Drawing.Point(19, 8);
            this.lblStockRecordReport.Name = "lblStockRecordReport";
            this.lblStockRecordReport.Size = new System.Drawing.Size(355, 50);
            this.lblStockRecordReport.TabIndex = 0;
            this.lblStockRecordReport.Text = "Stock Record Report";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFilter);
            this.panel4.Location = new System.Drawing.Point(253, 70);
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
            // plStockReport
            // 
            this.plStockReport.Controls.Add(this.panel3);
            this.plStockReport.Controls.Add(this.panel2);
            this.plStockReport.Controls.Add(this.panel1);
            this.plStockReport.Controls.Add(this.plStockRecordReport);
            this.plStockReport.Location = new System.Drawing.Point(1, 1);
            this.plStockReport.Name = "plStockReport";
            this.plStockReport.Size = new System.Drawing.Size(1175, 665);
            this.plStockReport.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalEntr);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.dgStockReport);
            this.panel3.Controls.Add(this.pldgStockRcordReport);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(3, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1164, 360);
            this.panel3.TabIndex = 11;
            // 
            // lblTotalEntr
            // 
            this.lblTotalEntr.AutoSize = true;
            this.lblTotalEntr.Depth = 0;
            this.lblTotalEntr.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalEntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalEntr.Location = new System.Drawing.Point(25, 334);
            this.lblTotalEntr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalEntr.Name = "lblTotalEntr";
            this.lblTotalEntr.Size = new System.Drawing.Size(117, 19);
            this.lblTotalEntr.TabIndex = 29;
            this.lblTotalEntr.Text = "Showing Entries";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblSearch);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Location = new System.Drawing.Point(822, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 43);
            this.panel5.TabIndex = 9;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Depth = 0;
            this.lblSearch.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearch.Location = new System.Drawing.Point(7, 13);
            this.lblSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 19);
            this.lblSearch.TabIndex = 44;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Hint = "Search....";
            this.txtSearch.Location = new System.Drawing.Point(68, 12);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(246, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgStockReport
            // 
            this.dgStockReport.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgStockReport.AllowUserToAddRows = false;
            this.dgStockReport.AllowUserToDeleteRows = false;
            this.dgStockReport.AllowUserToResizeColumns = false;
            this.dgStockReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgStockReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgStockReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStockReport.BackgroundColor = System.Drawing.Color.White;
            this.dgStockReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgStockReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgStockReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStockReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgStockReport.ColumnHeadersHeight = 40;
            this.dgStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgStockReport.DoubleBuffered = true;
            this.dgStockReport.EnableHeadersVisualStyles = false;
            this.dgStockReport.GridColor = System.Drawing.Color.White;
            this.dgStockReport.HeaderBgColor = System.Drawing.Color.White;
            this.dgStockReport.HeaderForeColor = System.Drawing.Color.Black;
            this.dgStockReport.Location = new System.Drawing.Point(26, 67);
            this.dgStockReport.MultiSelect = false;
            this.dgStockReport.Name = "dgStockReport";
            this.dgStockReport.ReadOnly = true;
            this.dgStockReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStockReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgStockReport.RowHeadersVisible = false;
            this.dgStockReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgStockReport.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgStockReport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgStockReport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgStockReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgStockReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgStockReport.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgStockReport.RowTemplate.DividerHeight = 1;
            this.dgStockReport.RowTemplate.Height = 30;
            this.dgStockReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgStockReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStockReport.Size = new System.Drawing.Size(1113, 261);
            this.dgStockReport.TabIndex = 6;
            // 
            // pldgStockRcordReport
            // 
            this.pldgStockRcordReport.Location = new System.Drawing.Point(23, 65);
            this.pldgStockRcordReport.Name = "pldgStockRcordReport";
            this.pldgStockRcordReport.Size = new System.Drawing.Size(1119, 266);
            this.pldgStockRcordReport.TabIndex = 8;
            this.pldgStockRcordReport.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgStockRcordReport_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.lblCostValue);
            this.panel2.Controls.Add(this.lblTotalUnit);
            this.panel2.Controls.Add(this.lblItems);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(4, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 85);
            this.panel2.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.lblDataItems);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.panel8.Location = new System.Drawing.Point(99, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(211, 37);
            this.panel8.TabIndex = 10;
            // 
            // lblDataItems
            // 
            this.lblDataItems.AutoSize = true;
            this.lblDataItems.BackColor = System.Drawing.Color.White;
            this.lblDataItems.Depth = 0;
            this.lblDataItems.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataItems.Location = new System.Drawing.Point(3, 7);
            this.lblDataItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataItems.Name = "lblDataItems";
            this.lblDataItems.Size = new System.Drawing.Size(94, 19);
            this.lblDataItems.TabIndex = 3;
            this.lblDataItems.Text = "lblDataItems";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.lblDataStockHand);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.panel7.Location = new System.Drawing.Point(452, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(211, 37);
            this.panel7.TabIndex = 9;
            // 
            // lblDataStockHand
            // 
            this.lblDataStockHand.AutoSize = true;
            this.lblDataStockHand.BackColor = System.Drawing.Color.White;
            this.lblDataStockHand.Depth = 0;
            this.lblDataStockHand.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataStockHand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataStockHand.Location = new System.Drawing.Point(3, 7);
            this.lblDataStockHand.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataStockHand.Name = "lblDataStockHand";
            this.lblDataStockHand.Size = new System.Drawing.Size(118, 19);
            this.lblDataStockHand.TabIndex = 3;
            this.lblDataStockHand.Text = "lblDataTotalUnit";
            // 
            // lblCostValue
            // 
            this.lblCostValue.AutoSize = true;
            this.lblCostValue.BackColor = System.Drawing.Color.White;
            this.lblCostValue.Depth = 0;
            this.lblCostValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCostValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCostValue.Location = new System.Drawing.Point(817, 52);
            this.lblCostValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCostValue.Name = "lblCostValue";
            this.lblCostValue.Size = new System.Drawing.Size(204, 19);
            this.lblCostValue.TabIndex = 7;
            this.lblCostValue.Text = "Cost Value of Stock on Hand";
            // 
            // lblTotalUnit
            // 
            this.lblTotalUnit.AutoSize = true;
            this.lblTotalUnit.BackColor = System.Drawing.Color.White;
            this.lblTotalUnit.Depth = 0;
            this.lblTotalUnit.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalUnit.Location = new System.Drawing.Point(455, 52);
            this.lblTotalUnit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalUnit.Name = "lblTotalUnit";
            this.lblTotalUnit.Size = new System.Drawing.Size(130, 19);
            this.lblTotalUnit.TabIndex = 6;
            this.lblTotalUnit.Text = "Total unit on hand";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.BackColor = System.Drawing.Color.White;
            this.lblItems.Depth = 0;
            this.lblItems.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItems.Location = new System.Drawing.Point(101, 52);
            this.lblItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(47, 19);
            this.lblItems.TabIndex = 5;
            this.lblItems.Text = "items";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.lblDataCostVal);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.panel6.Location = new System.Drawing.Point(814, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 37);
            this.panel6.TabIndex = 8;
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
            this.lblDataCostVal.Size = new System.Drawing.Size(130, 19);
            this.lblDataCostVal.TabIndex = 3;
            this.lblDataCostVal.Text = "lblDataStockHand";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel9);
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
            this.panel9.Location = new System.Drawing.Point(363, 70);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(89, 39);
            this.panel9.TabIndex = 8;
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
            // plCategory
            // 
            this.plCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plCategory.BackgroundImage")));
            this.plCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plCategory.Controls.Add(this.dpCategory);
            this.plCategory.GradientBottomLeft = System.Drawing.Color.White;
            this.plCategory.GradientBottomRight = System.Drawing.Color.White;
            this.plCategory.GradientTopLeft = System.Drawing.Color.White;
            this.plCategory.GradientTopRight = System.Drawing.Color.White;
            this.plCategory.Location = new System.Drawing.Point(41, 72);
            this.plCategory.Name = "plCategory";
            this.plCategory.Quality = 10;
            this.plCategory.Size = new System.Drawing.Size(192, 33);
            this.plCategory.TabIndex = 6;
            this.plCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.plCategory_Paint);
            // 
            // dpCategory
            // 
            this.dpCategory.BackColor = System.Drawing.Color.Transparent;
            this.dpCategory.BorderRadius = 3;
            this.dpCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dpCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpCategory.ForeColor = System.Drawing.Color.Black;
            this.dpCategory.Items = new string[] {
        "A - Sheet Metal",
        "B - Major Assemblies",
        "C - Light Components",
        "D - Accessories"};
            this.dpCategory.Location = new System.Drawing.Point(0, 0);
            this.dpCategory.Name = "dpCategory";
            this.dpCategory.NomalColor = System.Drawing.Color.White;
            this.dpCategory.onHoverColor = System.Drawing.Color.White;
            this.dpCategory.selectedIndex = -1;
            this.dpCategory.Size = new System.Drawing.Size(192, 33);
            this.dpCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Depth = 0;
            this.lblCategory.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategory.Location = new System.Drawing.Point(37, 50);
            this.lblCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 19);
            this.lblCategory.TabIndex = 28;
            this.lblCategory.Text = "Category";
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
            // plStockRecordReport
            // 
            this.plStockRecordReport.BackColor = System.Drawing.Color.White;
            this.plStockRecordReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plStockRecordReport.Controls.Add(this.btnDownloadPDF);
            this.plStockRecordReport.Controls.Add(this.btnDownloadCSV);
            this.plStockRecordReport.Controls.Add(this.lblStockRecordReport);
            this.plStockRecordReport.Location = new System.Drawing.Point(4, 5);
            this.plStockRecordReport.Name = "plStockRecordReport";
            this.plStockRecordReport.Size = new System.Drawing.Size(1164, 71);
            this.plStockRecordReport.TabIndex = 0;
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
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // StockRecordReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 664);
            this.Controls.Add(this.plStockReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockRecordReport";
            this.Text = "StockRecordReport";
            this.Load += new System.EventHandler(this.StockRecordReport_Load);
            this.panel4.ResumeLayout(false);
            this.plStockReport.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.plCategory.ResumeLayout(false);
            this.plStockRecordReport.ResumeLayout(false);
            this.plStockRecordReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnDownloadPDF;
        private System.Windows.Forms.Label lblStockRecordReport;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private System.Windows.Forms.Panel plStockReport;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel lblTotalEntr;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialLabel lblSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgStockReport;
        private System.Windows.Forms.Panel pldgStockRcordReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private MaterialSkin.Controls.MaterialLabel lblDataItems;
        private System.Windows.Forms.Panel panel7;
        private MaterialSkin.Controls.MaterialLabel lblDataStockHand;
        private MaterialSkin.Controls.MaterialLabel lblCostValue;
        private MaterialSkin.Controls.MaterialLabel lblTotalUnit;
        private MaterialSkin.Controls.MaterialLabel lblItems;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialLabel lblDataCostVal;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel plCategory;
        private Bunifu.Framework.UI.BunifuDropdown dpCategory;
        private MaterialSkin.Controls.MaterialLabel lblCategory;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel plStockRecordReport;
        private Bunifu.Framework.UI.BunifuFlatButton btnDownloadCSV;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}