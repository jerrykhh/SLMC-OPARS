namespace WindowsFormsApplication1
{
    partial class SalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plSalesOrder = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHold = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTotalEntr = new MaterialSkin.Controls.MaterialLabel();
            this.btnDelOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pldgSalesOrder = new System.Windows.Forms.Panel();
            this.dgSalesOrder = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTo = new System.Windows.Forms.Label();
            this.plFilTo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.plFilFrom = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.plSalesOrderTitle = new System.Windows.Forms.Panel();
            this.plCreateOrder = new System.Windows.Forms.Panel();
            this.btnCreateOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.plSalesOrder.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pldgSalesOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesOrder)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.plFilTo.SuspendLayout();
            this.plFilFrom.SuspendLayout();
            this.plSalesOrderTitle.SuspendLayout();
            this.plCreateOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // plSalesOrder
            // 
            this.plSalesOrder.Controls.Add(this.panel2);
            this.plSalesOrder.Controls.Add(this.panel1);
            this.plSalesOrder.Controls.Add(this.plSalesOrderTitle);
            this.plSalesOrder.Location = new System.Drawing.Point(1, 1);
            this.plSalesOrder.Name = "plSalesOrder";
            this.plSalesOrder.Size = new System.Drawing.Size(1175, 728);
            this.plSalesOrder.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnHold);
            this.panel2.Controls.Add(this.lblTotalEntr);
            this.panel2.Controls.Add(this.btnDelOrder);
            this.panel2.Controls.Add(this.btnEditOrder);
            this.panel2.Controls.Add(this.btnViewOrder);
            this.panel2.Controls.Add(this.pldgSalesOrder);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(3, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 442);
            this.panel2.TabIndex = 2;
            // 
            // btnHold
            // 
            this.btnHold.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHold.BackColor = System.Drawing.Color.Gray;
            this.btnHold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHold.BorderRadius = 0;
            this.btnHold.ButtonText = "Hold";
            this.btnHold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHold.DisabledColor = System.Drawing.Color.Gray;
            this.btnHold.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHold.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHold.Iconimage")));
            this.btnHold.Iconimage_right = null;
            this.btnHold.Iconimage_right_Selected = null;
            this.btnHold.Iconimage_Selected = null;
            this.btnHold.IconMarginLeft = 0;
            this.btnHold.IconMarginRight = 0;
            this.btnHold.IconRightVisible = true;
            this.btnHold.IconRightZoom = 0D;
            this.btnHold.IconVisible = true;
            this.btnHold.IconZoom = 90D;
            this.btnHold.IsTab = false;
            this.btnHold.Location = new System.Drawing.Point(169, 21);
            this.btnHold.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHold.Name = "btnHold";
            this.btnHold.Normalcolor = System.Drawing.Color.Gray;
            this.btnHold.OnHovercolor = System.Drawing.Color.Gray;
            this.btnHold.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHold.selected = false;
            this.btnHold.Size = new System.Drawing.Size(81, 36);
            this.btnHold.TabIndex = 13;
            this.btnHold.Text = "Hold";
            this.btnHold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHold.Textcolor = System.Drawing.Color.White;
            this.btnHold.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // lblTotalEntr
            // 
            this.lblTotalEntr.AutoSize = true;
            this.lblTotalEntr.Depth = 0;
            this.lblTotalEntr.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalEntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalEntr.Location = new System.Drawing.Point(16, 408);
            this.lblTotalEntr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalEntr.Name = "lblTotalEntr";
            this.lblTotalEntr.Size = new System.Drawing.Size(117, 19);
            this.lblTotalEntr.TabIndex = 12;
            this.lblTotalEntr.Text = "Showing Entries";
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelOrder.BorderRadius = 0;
            this.btnDelOrder.ButtonText = "Cancel Order";
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
            this.btnDelOrder.Location = new System.Drawing.Point(426, 21);
            this.btnDelOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDelOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelOrder.selected = false;
            this.btnDelOrder.Size = new System.Drawing.Size(136, 36);
            this.btnDelOrder.TabIndex = 11;
            this.btnDelOrder.Text = "Cancel Order";
            this.btnDelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelOrder.Textcolor = System.Drawing.Color.White;
            this.btnDelOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOrder.Visible = false;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Activecolor = System.Drawing.Color.Black;
            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditOrder.BorderRadius = 0;
            this.btnEditOrder.ButtonText = "Edit Order";
            this.btnEditOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditOrder.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditOrder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditOrder.Iconimage")));
            this.btnEditOrder.Iconimage_right = null;
            this.btnEditOrder.Iconimage_right_Selected = null;
            this.btnEditOrder.Iconimage_Selected = null;
            this.btnEditOrder.IconMarginLeft = 0;
            this.btnEditOrder.IconMarginRight = 0;
            this.btnEditOrder.IconRightVisible = true;
            this.btnEditOrder.IconRightZoom = 0D;
            this.btnEditOrder.IconVisible = true;
            this.btnEditOrder.IconZoom = 90D;
            this.btnEditOrder.IsTab = false;
            this.btnEditOrder.Location = new System.Drawing.Point(275, 21);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditOrder.OnHovercolor = System.Drawing.Color.Black;
            this.btnEditOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditOrder.selected = false;
            this.btnEditOrder.Size = new System.Drawing.Size(123, 36);
            this.btnEditOrder.TabIndex = 10;
            this.btnEditOrder.Text = "Edit Order";
            this.btnEditOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditOrder.Textcolor = System.Drawing.Color.White;
            this.btnEditOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrder.Visible = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
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
            this.btnViewOrder.Location = new System.Drawing.Point(21, 21);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewOrder.OnHovercolor = System.Drawing.Color.Black;
            this.btnViewOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewOrder.selected = false;
            this.btnViewOrder.Size = new System.Drawing.Size(123, 36);
            this.btnViewOrder.TabIndex = 9;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewOrder.Textcolor = System.Drawing.Color.White;
            this.btnViewOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // pldgSalesOrder
            // 
            this.pldgSalesOrder.Controls.Add(this.dgSalesOrder);
            this.pldgSalesOrder.Location = new System.Drawing.Point(20, 74);
            this.pldgSalesOrder.Name = "pldgSalesOrder";
            this.pldgSalesOrder.Size = new System.Drawing.Size(1119, 319);
            this.pldgSalesOrder.TabIndex = 7;
            this.pldgSalesOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgSalesOrder_Paint);
            // 
            // dgSalesOrder
            // 
            this.dgSalesOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgSalesOrder.AllowUserToAddRows = false;
            this.dgSalesOrder.AllowUserToDeleteRows = false;
            this.dgSalesOrder.AllowUserToResizeColumns = false;
            this.dgSalesOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSalesOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSalesOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSalesOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgSalesOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSalesOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgSalesOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalesOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSalesOrder.ColumnHeadersHeight = 40;
            this.dgSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgSalesOrder.DoubleBuffered = true;
            this.dgSalesOrder.EnableHeadersVisualStyles = false;
            this.dgSalesOrder.GridColor = System.Drawing.Color.White;
            this.dgSalesOrder.HeaderBgColor = System.Drawing.Color.White;
            this.dgSalesOrder.HeaderForeColor = System.Drawing.Color.Black;
            this.dgSalesOrder.Location = new System.Drawing.Point(3, 1);
            this.dgSalesOrder.MultiSelect = false;
            this.dgSalesOrder.Name = "dgSalesOrder";
            this.dgSalesOrder.ReadOnly = true;
            this.dgSalesOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSalesOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSalesOrder.RowHeadersVisible = false;
            this.dgSalesOrder.RowHeadersWidth = 51;
            this.dgSalesOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgSalesOrder.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgSalesOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgSalesOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSalesOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgSalesOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgSalesOrder.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgSalesOrder.RowTemplate.DividerHeight = 1;
            this.dgSalesOrder.RowTemplate.Height = 30;
            this.dgSalesOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgSalesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSalesOrder.Size = new System.Drawing.Size(1113, 315);
            this.dgSalesOrder.TabIndex = 6;
            this.dgSalesOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSalesOrder_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(779, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 43);
            this.panel3.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.plFilTo);
            this.panel1.Controls.Add(this.plFilFrom);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 177);
            this.panel1.TabIndex = 1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.ddStatus);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(548, 76);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(192, 33);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // ddStatus
            // 
            this.ddStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Items.AddRange(new object[] {
            "Processing",
            "Packaged",
            "Shipping",
            "Shipped",
            "Outstanding",
            "Cancel"});
            this.ddStatus.Location = new System.Drawing.Point(0, 0);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(192, 29);
            this.ddStatus.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Location = new System.Drawing.Point(149, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 39);
            this.panel5.TabIndex = 8;
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatus.Location = new System.Drawing.Point(544, 50);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 21);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFilter);
            this.panel4.Location = new System.Drawing.Point(36, 121);
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
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(294, 52);
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
            this.plFilTo.Location = new System.Drawing.Point(295, 76);
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
            this.DpTo.Location = new System.Drawing.Point(5, 4);
            this.DpTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DpTo.Name = "DpTo";
            this.DpTo.Size = new System.Drawing.Size(184, 25);
            this.DpTo.TabIndex = 0;
            this.DpTo.Value = new System.DateTime(2019, 5, 31, 0, 0, 0, 0);
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
            this.plFilFrom.Location = new System.Drawing.Point(36, 76);
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
            this.DpFrom.Location = new System.Drawing.Point(5, 4);
            this.DpFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DpFrom.Name = "DpFrom";
            this.DpFrom.Size = new System.Drawing.Size(184, 25);
            this.DpFrom.TabIndex = 0;
            this.DpFrom.Value = new System.DateTime(2019, 5, 31, 0, 0, 0, 0);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(32, 52);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 21);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "FROM";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(29, 15);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(76, 37);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter";
            // 
            // plSalesOrderTitle
            // 
            this.plSalesOrderTitle.BackColor = System.Drawing.Color.White;
            this.plSalesOrderTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSalesOrderTitle.Controls.Add(this.plCreateOrder);
            this.plSalesOrderTitle.Controls.Add(this.lblSalesOrder);
            this.plSalesOrderTitle.Location = new System.Drawing.Point(3, 7);
            this.plSalesOrderTitle.Name = "plSalesOrderTitle";
            this.plSalesOrderTitle.Size = new System.Drawing.Size(1164, 71);
            this.plSalesOrderTitle.TabIndex = 0;
            // 
            // plCreateOrder
            // 
            this.plCreateOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plCreateOrder.Controls.Add(this.btnCreateOrder);
            this.plCreateOrder.Location = new System.Drawing.Point(782, 17);
            this.plCreateOrder.Name = "plCreateOrder";
            this.plCreateOrder.Size = new System.Drawing.Size(313, 38);
            this.plCreateOrder.TabIndex = 1;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Activecolor = System.Drawing.Color.Black;
            this.btnCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateOrder.BorderRadius = 0;
            this.btnCreateOrder.ButtonText = "+   Create Sales Order";
            this.btnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateOrder.DisabledColor = System.Drawing.Color.Gray;
            this.btnCreateOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCreateOrder.Iconimage = null;
            this.btnCreateOrder.Iconimage_right = null;
            this.btnCreateOrder.Iconimage_right_Selected = null;
            this.btnCreateOrder.Iconimage_Selected = null;
            this.btnCreateOrder.IconMarginLeft = 0;
            this.btnCreateOrder.IconMarginRight = 0;
            this.btnCreateOrder.IconRightVisible = true;
            this.btnCreateOrder.IconRightZoom = 0D;
            this.btnCreateOrder.IconVisible = true;
            this.btnCreateOrder.IconZoom = 90D;
            this.btnCreateOrder.IsTab = false;
            this.btnCreateOrder.Location = new System.Drawing.Point(-1, -1);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateOrder.OnHovercolor = System.Drawing.Color.Black;
            this.btnCreateOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCreateOrder.selected = false;
            this.btnCreateOrder.Size = new System.Drawing.Size(313, 38);
            this.btnCreateOrder.TabIndex = 1;
            this.btnCreateOrder.Text = "+   Create Sales Order";
            this.btnCreateOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateOrder.Textcolor = System.Drawing.Color.White;
            this.btnCreateOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrder.Location = new System.Drawing.Point(18, 10);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(210, 50);
            this.lblSalesOrder.TabIndex = 0;
            this.lblSalesOrder.Text = "Sales Order";
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1177, 733);
            this.Controls.Add(this.plSalesOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesOrder";
            this.Text = "Sales Order";
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            this.Shown += new System.EventHandler(this.SalesOrder_Shown);
            this.plSalesOrder.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pldgSalesOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSalesOrder)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.plFilTo.ResumeLayout(false);
            this.plFilFrom.ResumeLayout(false);
            this.plSalesOrderTitle.ResumeLayout(false);
            this.plSalesOrderTitle.PerformLayout();
            this.plCreateOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plSalesOrder;
        private System.Windows.Forms.Panel plSalesOrderTitle;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.Panel plCreateOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnCreateOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFilter;
        private Bunifu.Framework.UI.BunifuGradientPanel plFilFrom;
        private Bunifu.Framework.UI.BunifuDatepicker DpFrom;
        private System.Windows.Forms.Label lblTo;
        private Bunifu.Framework.UI.BunifuGradientPanel plFilTo;
        private Bunifu.Framework.UI.BunifuDatepicker DpTo;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private System.Windows.Forms.Panel pldgSalesOrder;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgSalesOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditOrder;
        private MaterialSkin.Controls.MaterialLabel lblTotalEntr;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ComboBox ddStatus;
        private Bunifu.Framework.UI.BunifuFlatButton btnHold;
    }
}