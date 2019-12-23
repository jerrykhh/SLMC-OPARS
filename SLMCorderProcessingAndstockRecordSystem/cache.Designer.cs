namespace WindowsFormsApplication1
{
    partial class cache
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cache));
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pldgSalesOrder = new System.Windows.Forms.Panel();
            this.dgStockReport = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblCategory = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.plStockRecordReport = new System.Windows.Forms.Panel();
            this.btnDownloadPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDownloadCSV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblStockRecordReport = new System.Windows.Forms.Label();
            this.plSalesOrder = new System.Windows.Forms.Panel();
            this.lblCostValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalUnit = new MaterialSkin.Controls.MaterialLabel();
            this.lblItems = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataStockHand = new MaterialSkin.Controls.MaterialLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDataTotalUnit = new MaterialSkin.Controls.MaterialLabel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDataItems = new MaterialSkin.Controls.MaterialLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSearch = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalEntr = new MaterialSkin.Controls.MaterialLabel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockReport)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.plStockRecordReport.SuspendLayout();
            this.plSalesOrder.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalEntr);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.dgStockReport);
            this.panel3.Controls.Add(this.pldgSalesOrder);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(3, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1164, 465);
            this.panel3.TabIndex = 11;
            // 
            // pldgSalesOrder
            // 
            this.pldgSalesOrder.Location = new System.Drawing.Point(23, 98);
            this.pldgSalesOrder.Name = "pldgSalesOrder";
            this.pldgSalesOrder.Size = new System.Drawing.Size(1119, 315);
            this.pldgSalesOrder.TabIndex = 8;
            // 
            // dgStockReport
            // 
            this.dgStockReport.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgStockReport.AllowUserToAddRows = false;
            this.dgStockReport.AllowUserToDeleteRows = false;
            this.dgStockReport.AllowUserToResizeColumns = false;
            this.dgStockReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgStockReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgStockReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStockReport.BackgroundColor = System.Drawing.Color.White;
            this.dgStockReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgStockReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgStockReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStockReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgStockReport.ColumnHeadersHeight = 40;
            this.dgStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgStockReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Test,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgStockReport.DoubleBuffered = true;
            this.dgStockReport.EnableHeadersVisualStyles = false;
            this.dgStockReport.GridColor = System.Drawing.Color.White;
            this.dgStockReport.HeaderBgColor = System.Drawing.Color.White;
            this.dgStockReport.HeaderForeColor = System.Drawing.Color.Black;
            this.dgStockReport.Location = new System.Drawing.Point(26, 101);
            this.dgStockReport.MultiSelect = false;
            this.dgStockReport.Name = "dgStockReport";
            this.dgStockReport.ReadOnly = true;
            this.dgStockReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStockReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.dgStockReport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgStockReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStockReport.Size = new System.Drawing.Size(1113, 309);
            this.dgStockReport.TabIndex = 6;
            // 
            // Test
            // 
            this.Test.HeaderText = "Test1";
            this.Test.Name = "Test";
            this.Test.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dpCategory
            // 
            this.dpCategory.BackColor = System.Drawing.Color.Transparent;
            this.dpCategory.BorderRadius = 3;
            this.dpCategory.ForeColor = System.Drawing.Color.Black;
            this.dpCategory.Items = new string[0];
            this.dpCategory.Location = new System.Drawing.Point(3, 3);
            this.dpCategory.Name = "dpCategory";
            this.dpCategory.NomalColor = System.Drawing.Color.White;
            this.dpCategory.onHoverColor = System.Drawing.Color.White;
            this.dpCategory.selectedIndex = -1;
            this.dpCategory.Size = new System.Drawing.Size(187, 27);
            this.dpCategory.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dpCategory);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(41, 72);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(192, 33);
            this.bunifuGradientPanel1.TabIndex = 6;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(4, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 120);
            this.panel1.TabIndex = 1;
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
            // plSalesOrder
            // 
            this.plSalesOrder.Controls.Add(this.panel3);
            this.plSalesOrder.Controls.Add(this.panel2);
            this.plSalesOrder.Controls.Add(this.panel1);
            this.plSalesOrder.Controls.Add(this.plStockRecordReport);
            this.plSalesOrder.Location = new System.Drawing.Point(1, 1);
            this.plSalesOrder.Name = "plSalesOrder";
            this.plSalesOrder.Size = new System.Drawing.Size(1175, 781);
            this.plSalesOrder.TabIndex = 3;
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
            this.lblDataStockHand.Size = new System.Drawing.Size(130, 19);
            this.lblDataStockHand.TabIndex = 3;
            this.lblDataStockHand.Text = "lblDataStockHand";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.lblDataStockHand);
            this.panel6.Location = new System.Drawing.Point(821, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 37);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.lblDataTotalUnit);
            this.panel7.Location = new System.Drawing.Point(459, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(211, 37);
            this.panel7.TabIndex = 9;
            // 
            // lblDataTotalUnit
            // 
            this.lblDataTotalUnit.AutoSize = true;
            this.lblDataTotalUnit.BackColor = System.Drawing.Color.White;
            this.lblDataTotalUnit.Depth = 0;
            this.lblDataTotalUnit.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataTotalUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataTotalUnit.Location = new System.Drawing.Point(3, 7);
            this.lblDataTotalUnit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataTotalUnit.Name = "lblDataTotalUnit";
            this.lblDataTotalUnit.Size = new System.Drawing.Size(118, 19);
            this.lblDataTotalUnit.TabIndex = 3;
            this.lblDataTotalUnit.Text = "lblDataTotalUnit";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.lblDataItems);
            this.panel8.Location = new System.Drawing.Point(105, 12);
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
            // panel5
            // 
            this.panel5.Controls.Add(this.lblSearch);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Location = new System.Drawing.Point(822, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(317, 43);
            this.panel5.TabIndex = 9;
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
            // lblTotalEntr
            // 
            this.lblTotalEntr.AutoSize = true;
            this.lblTotalEntr.Depth = 0;
            this.lblTotalEntr.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalEntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalEntr.Location = new System.Drawing.Point(25, 426);
            this.lblTotalEntr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalEntr.Name = "lblTotalEntr";
            this.lblTotalEntr.Size = new System.Drawing.Size(117, 19);
            this.lblTotalEntr.TabIndex = 29;
            this.lblTotalEntr.Text = "Showing Entries";
            // 
            // cache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 782);
            this.Controls.Add(this.plSalesOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cache";
            this.Text = "cache";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStockReport)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.plStockRecordReport.ResumeLayout(false);
            this.plStockRecordReport.PerformLayout();
            this.plSalesOrder.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pldgSalesOrder;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgStockReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuDropdown dpCategory;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private MaterialSkin.Controls.MaterialLabel lblCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel plStockRecordReport;
        private Bunifu.Framework.UI.BunifuFlatButton btnDownloadPDF;
        private Bunifu.Framework.UI.BunifuFlatButton btnDownloadCSV;
        private System.Windows.Forms.Label lblStockRecordReport;
        private System.Windows.Forms.Panel plSalesOrder;
        private MaterialSkin.Controls.MaterialLabel lblCostValue;
        private MaterialSkin.Controls.MaterialLabel lblTotalUnit;
        private MaterialSkin.Controls.MaterialLabel lblItems;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialLabel lblDataStockHand;
        private System.Windows.Forms.Panel panel8;
        private MaterialSkin.Controls.MaterialLabel lblDataItems;
        private System.Windows.Forms.Panel panel7;
        private MaterialSkin.Controls.MaterialLabel lblDataTotalUnit;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialLabel lblSearch;
        private MaterialSkin.Controls.MaterialLabel lblTotalEntr;
    }
}