namespace WindowsFormsApplication1
{
    partial class Outstanding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Outstanding));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTo = new System.Windows.Forms.Label();
            this.plFilTo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.plFilFrom = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblTotalEntr = new MaterialSkin.Controls.MaterialLabel();
            this.pldgSalesOrder = new System.Windows.Forms.Panel();
            this.dgOutstanding = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.plSalesOrderTitle = new System.Windows.Forms.Panel();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.plData = new System.Windows.Forms.Panel();
            this.btnDelOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plFIlter = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plSalesOrder = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.plFilTo.SuspendLayout();
            this.plFilFrom.SuspendLayout();
            this.pldgSalesOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutstanding)).BeginInit();
            this.plSalesOrderTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plData.SuspendLayout();
            this.plFIlter.SuspendLayout();
            this.panel5.SuspendLayout();
            this.plSalesOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFilter);
            this.panel4.Location = new System.Drawing.Point(34, 118);
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
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(292, 49);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 21);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "TO";
            // 
            // plFilTo
            // 
            this.plFilTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plFilTo.BackgroundImage")));
            this.plFilTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plFilTo.Controls.Add(this.DpTo);
            this.plFilTo.GradientBottomLeft = System.Drawing.Color.White;
            this.plFilTo.GradientBottomRight = System.Drawing.Color.White;
            this.plFilTo.GradientTopLeft = System.Drawing.Color.White;
            this.plFilTo.GradientTopRight = System.Drawing.Color.White;
            this.plFilTo.Location = new System.Drawing.Point(293, 73);
            this.plFilTo.Name = "plFilTo";
            this.plFilTo.Quality = 10;
            this.plFilTo.Size = new System.Drawing.Size(192, 33);
            this.plFilTo.TabIndex = 5;
            this.plFilTo.Paint += new System.Windows.Forms.PaintEventHandler(this.plFilTo_Paint);
            // 
            // DpTo
            // 
            this.DpTo.BackColor = System.Drawing.Color.White;
            this.DpTo.BorderRadius = 0;
            this.DpTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DpTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DpTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DpTo.FormatCustom = null;
            this.DpTo.Location = new System.Drawing.Point(3, 5);
            this.DpTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DpTo.Name = "DpTo";
            this.DpTo.Size = new System.Drawing.Size(184, 25);
            this.DpTo.TabIndex = 0;
            this.DpTo.Value = new System.DateTime(2019, 5, 26, 14, 7, 29, 644);
            // 
            // plFilFrom
            // 
            this.plFilFrom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plFilFrom.BackgroundImage")));
            this.plFilFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plFilFrom.Controls.Add(this.DpFrom);
            this.plFilFrom.GradientBottomLeft = System.Drawing.Color.White;
            this.plFilFrom.GradientBottomRight = System.Drawing.Color.White;
            this.plFilFrom.GradientTopLeft = System.Drawing.Color.White;
            this.plFilFrom.GradientTopRight = System.Drawing.Color.White;
            this.plFilFrom.Location = new System.Drawing.Point(34, 73);
            this.plFilFrom.Name = "plFilFrom";
            this.plFilFrom.Quality = 10;
            this.plFilFrom.Size = new System.Drawing.Size(192, 33);
            this.plFilFrom.TabIndex = 4;
            this.plFilFrom.Paint += new System.Windows.Forms.PaintEventHandler(this.plFilFrom_Paint);
            // 
            // DpFrom
            // 
            this.DpFrom.BackColor = System.Drawing.Color.White;
            this.DpFrom.BorderRadius = 0;
            this.DpFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DpFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DpFrom.FormatCustom = null;
            this.DpFrom.Location = new System.Drawing.Point(3, 5);
            this.DpFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DpFrom.Name = "DpFrom";
            this.DpFrom.Size = new System.Drawing.Size(184, 25);
            this.DpFrom.TabIndex = 0;
            this.DpFrom.Value = new System.DateTime(2019, 5, 29, 0, 0, 0, 0);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(30, 49);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 21);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "FROM";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(27, 12);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(76, 37);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter";
            // 
            // lblTotalEntr
            // 
            this.lblTotalEntr.AutoSize = true;
            this.lblTotalEntr.Depth = 0;
            this.lblTotalEntr.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalEntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalEntr.Location = new System.Drawing.Point(15, 421);
            this.lblTotalEntr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalEntr.Name = "lblTotalEntr";
            this.lblTotalEntr.Size = new System.Drawing.Size(117, 19);
            this.lblTotalEntr.TabIndex = 12;
            this.lblTotalEntr.Text = "Showing Entries";
            // 
            // pldgSalesOrder
            // 
            this.pldgSalesOrder.Controls.Add(this.dgOutstanding);
            this.pldgSalesOrder.Location = new System.Drawing.Point(18, 71);
            this.pldgSalesOrder.Name = "pldgSalesOrder";
            this.pldgSalesOrder.Size = new System.Drawing.Size(1122, 347);
            this.pldgSalesOrder.TabIndex = 7;
            this.pldgSalesOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgSalesOrder_Paint);
            // 
            // dgOutstanding
            // 
            this.dgOutstanding.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgOutstanding.AllowUserToAddRows = false;
            this.dgOutstanding.AllowUserToDeleteRows = false;
            this.dgOutstanding.AllowUserToResizeColumns = false;
            this.dgOutstanding.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOutstanding.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOutstanding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOutstanding.BackgroundColor = System.Drawing.Color.White;
            this.dgOutstanding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOutstanding.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgOutstanding.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOutstanding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgOutstanding.ColumnHeadersHeight = 40;
            this.dgOutstanding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgOutstanding.DoubleBuffered = true;
            this.dgOutstanding.EnableHeadersVisualStyles = false;
            this.dgOutstanding.GridColor = System.Drawing.Color.White;
            this.dgOutstanding.HeaderBgColor = System.Drawing.Color.White;
            this.dgOutstanding.HeaderForeColor = System.Drawing.Color.Black;
            this.dgOutstanding.Location = new System.Drawing.Point(1, 3);
            this.dgOutstanding.MultiSelect = false;
            this.dgOutstanding.Name = "dgOutstanding";
            this.dgOutstanding.ReadOnly = true;
            this.dgOutstanding.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOutstanding.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgOutstanding.RowHeadersVisible = false;
            this.dgOutstanding.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOutstanding.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgOutstanding.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgOutstanding.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgOutstanding.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgOutstanding.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOutstanding.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgOutstanding.RowTemplate.DividerHeight = 1;
            this.dgOutstanding.RowTemplate.Height = 30;
            this.dgOutstanding.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgOutstanding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOutstanding.Size = new System.Drawing.Size(1118, 341);
            this.dgOutstanding.TabIndex = 0;
            this.dgOutstanding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOutstanding_CellClick);
            // 
            // plSalesOrderTitle
            // 
            this.plSalesOrderTitle.BackColor = System.Drawing.Color.White;
            this.plSalesOrderTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSalesOrderTitle.Controls.Add(this.lblSalesOrder);
            this.plSalesOrderTitle.Location = new System.Drawing.Point(1, 4);
            this.plSalesOrderTitle.Name = "plSalesOrderTitle";
            this.plSalesOrderTitle.Size = new System.Drawing.Size(1163, 71);
            this.plSalesOrderTitle.TabIndex = 0;
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrder.Location = new System.Drawing.Point(16, 7);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(227, 50);
            this.lblSalesOrder.TabIndex = 0;
            this.lblSalesOrder.Text = "Outstanding";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(786, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 43);
            this.panel3.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Hint = "Search....";
            this.txtSearch.Location = new System.Drawing.Point(63, 9);
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
            // plData
            // 
            this.plData.BackColor = System.Drawing.Color.White;
            this.plData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plData.Controls.Add(this.btnDelOrder);
            this.plData.Controls.Add(this.lblTotalEntr);
            this.plData.Controls.Add(this.btnViewOrder);
            this.plData.Controls.Add(this.pldgSalesOrder);
            this.plData.Controls.Add(this.panel3);
            this.plData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plData.Location = new System.Drawing.Point(1, 280);
            this.plData.Name = "plData";
            this.plData.Size = new System.Drawing.Size(1163, 461);
            this.plData.TabIndex = 2;
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelOrder.BorderRadius = 0;
            this.btnDelOrder.ButtonText = "Delete Order";
            this.btnDelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelOrder.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelOrder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelOrder.Iconimage")));
            this.btnDelOrder.Iconimage_right = null;
            this.btnDelOrder.Iconimage_right_Selected = null;
            this.btnDelOrder.Iconimage_Selected = null;
            this.btnDelOrder.IconMarginLeft = 0;
            this.btnDelOrder.IconMarginRight = 0;
            this.btnDelOrder.IconRightVisible = true;
            this.btnDelOrder.IconRightZoom = 0D;
            this.btnDelOrder.IconVisible = true;
            this.btnDelOrder.IconZoom = 90D;
            this.btnDelOrder.IsTab = false;
            this.btnDelOrder.Location = new System.Drawing.Point(169, 15);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDelOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelOrder.selected = false;
            this.btnDelOrder.Size = new System.Drawing.Size(136, 36);
            this.btnDelOrder.TabIndex = 13;
            this.btnDelOrder.Text = "Delete Order";
            this.btnDelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelOrder.Textcolor = System.Drawing.Color.White;
            this.btnDelOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Activecolor = System.Drawing.Color.Black;
            this.btnViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewOrder.BorderRadius = 0;
            this.btnViewOrder.ButtonText = "View Order";
            this.btnViewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewOrder.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewOrder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViewOrder.Iconimage")));
            this.btnViewOrder.Iconimage_right = null;
            this.btnViewOrder.Iconimage_right_Selected = null;
            this.btnViewOrder.Iconimage_Selected = null;
            this.btnViewOrder.IconMarginLeft = 0;
            this.btnViewOrder.IconMarginRight = 0;
            this.btnViewOrder.IconRightVisible = true;
            this.btnViewOrder.IconRightZoom = 0D;
            this.btnViewOrder.IconVisible = true;
            this.btnViewOrder.IconZoom = 90D;
            this.btnViewOrder.IsTab = false;
            this.btnViewOrder.Location = new System.Drawing.Point(21, 15);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewOrder.OnHovercolor = System.Drawing.Color.Black;
            this.btnViewOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewOrder.selected = false;
            this.btnViewOrder.Size = new System.Drawing.Size(123, 36);
            this.btnViewOrder.TabIndex = 12;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewOrder.Textcolor = System.Drawing.Color.White;
            this.btnViewOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // plFIlter
            // 
            this.plFIlter.BackColor = System.Drawing.Color.White;
            this.plFIlter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plFIlter.Controls.Add(this.panel5);
            this.plFIlter.Controls.Add(this.panel4);
            this.plFIlter.Controls.Add(this.lblTo);
            this.plFIlter.Controls.Add(this.plFilTo);
            this.plFIlter.Controls.Add(this.plFilFrom);
            this.plFIlter.Controls.Add(this.lblFrom);
            this.plFIlter.Controls.Add(this.lblFilter);
            this.plFIlter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plFIlter.Location = new System.Drawing.Point(1, 87);
            this.plFIlter.Name = "plFIlter";
            this.plFIlter.Size = new System.Drawing.Size(1163, 177);
            this.plFIlter.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Location = new System.Drawing.Point(154, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 39);
            this.panel5.TabIndex = 9;
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
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // plSalesOrder
            // 
            this.plSalesOrder.Controls.Add(this.plData);
            this.plSalesOrder.Controls.Add(this.plFIlter);
            this.plSalesOrder.Controls.Add(this.plSalesOrderTitle);
            this.plSalesOrder.Location = new System.Drawing.Point(2, 4);
            this.plSalesOrder.Name = "plSalesOrder";
            this.plSalesOrder.Size = new System.Drawing.Size(1173, 747);
            this.plSalesOrder.TabIndex = 1;
            // 
            // Outstanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 748);
            this.Controls.Add(this.plSalesOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Outstanding";
            this.Text = "Outstanding";
            this.Load += new System.EventHandler(this.Outstanding_Load);
            this.Shown += new System.EventHandler(this.Outstanding_Shown);
            this.panel4.ResumeLayout(false);
            this.plFilTo.ResumeLayout(false);
            this.plFilFrom.ResumeLayout(false);
            this.pldgSalesOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOutstanding)).EndInit();
            this.plSalesOrderTitle.ResumeLayout(false);
            this.plSalesOrderTitle.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.plData.ResumeLayout(false);
            this.plData.PerformLayout();
            this.plFIlter.ResumeLayout(false);
            this.plFIlter.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.plSalesOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private System.Windows.Forms.Label lblTo;
        private Bunifu.Framework.UI.BunifuGradientPanel plFilTo;
        private Bunifu.Framework.UI.BunifuDatepicker DpTo;
        private Bunifu.Framework.UI.BunifuGradientPanel plFilFrom;
        private Bunifu.Framework.UI.BunifuDatepicker DpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFilter;
        private MaterialSkin.Controls.MaterialLabel lblTotalEntr;
        private System.Windows.Forms.Panel pldgSalesOrder;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgOutstanding;
        private System.Windows.Forms.Panel plSalesOrderTitle;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.Panel plData;
        private System.Windows.Forms.Panel plFIlter;
        private System.Windows.Forms.Panel plSalesOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewOrder;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
    }
}