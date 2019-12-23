namespace WindowsFormsApplication1
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblTotalEntr = new MaterialSkin.Controls.MaterialLabel();
            this.pldgSalesOrder = new System.Windows.Forms.Panel();
            this.dgInvoice = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.plSalesOrderTitle = new System.Windows.Forms.Panel();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plFilTo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.plFilFrom = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.plSalesOrder = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.pldgSalesOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            this.plSalesOrderTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.plFilTo.SuspendLayout();
            this.plFilFrom.SuspendLayout();
            this.plSalesOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFilter);
            this.panel4.Location = new System.Drawing.Point(36, 118);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(89, 38);
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
            this.btnFilter.Size = new System.Drawing.Size(89, 38);
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
            this.lblTo.Location = new System.Drawing.Point(294, 48);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 21);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "TO";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(32, 48);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 21);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "FROM";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(29, 11);
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
            this.lblTotalEntr.Location = new System.Drawing.Point(19, 418);
            this.lblTotalEntr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalEntr.Name = "lblTotalEntr";
            this.lblTotalEntr.Size = new System.Drawing.Size(117, 19);
            this.lblTotalEntr.TabIndex = 12;
            this.lblTotalEntr.Text = "Showing Entries";
            // 
            // pldgSalesOrder
            // 
            this.pldgSalesOrder.Controls.Add(this.dgInvoice);
            this.pldgSalesOrder.Location = new System.Drawing.Point(20, 70);
            this.pldgSalesOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pldgSalesOrder.Name = "pldgSalesOrder";
            this.pldgSalesOrder.Size = new System.Drawing.Size(1119, 346);
            this.pldgSalesOrder.TabIndex = 7;
            this.pldgSalesOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgSalesOrder_Paint);
            // 
            // dgInvoice
            // 
            this.dgInvoice.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgInvoice.AllowUserToAddRows = false;
            this.dgInvoice.AllowUserToDeleteRows = false;
            this.dgInvoice.AllowUserToResizeColumns = false;
            this.dgInvoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgInvoice.ColumnHeadersHeight = 40;
            this.dgInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgInvoice.DoubleBuffered = true;
            this.dgInvoice.EnableHeadersVisualStyles = false;
            this.dgInvoice.GridColor = System.Drawing.Color.White;
            this.dgInvoice.HeaderBgColor = System.Drawing.Color.White;
            this.dgInvoice.HeaderForeColor = System.Drawing.Color.Black;
            this.dgInvoice.Location = new System.Drawing.Point(3, 2);
            this.dgInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgInvoice.MultiSelect = false;
            this.dgInvoice.Name = "dgInvoice";
            this.dgInvoice.ReadOnly = true;
            this.dgInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgInvoice.RowHeadersVisible = false;
            this.dgInvoice.RowHeadersWidth = 51;
            this.dgInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgInvoice.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgInvoice.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgInvoice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInvoice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgInvoice.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgInvoice.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgInvoice.RowTemplate.DividerHeight = 1;
            this.dgInvoice.RowTemplate.Height = 30;
            this.dgInvoice.RowTemplate.ReadOnly = true;
            this.dgInvoice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInvoice.Size = new System.Drawing.Size(1113, 335);
            this.dgInvoice.TabIndex = 40;
            this.dgInvoice.TabStop = false;
            this.dgInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgInvoice_CellClick);
            // 
            // plSalesOrderTitle
            // 
            this.plSalesOrderTitle.BackColor = System.Drawing.Color.White;
            this.plSalesOrderTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSalesOrderTitle.Controls.Add(this.lblInvoice);
            this.plSalesOrderTitle.Location = new System.Drawing.Point(3, 2);
            this.plSalesOrderTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plSalesOrderTitle.Name = "plSalesOrderTitle";
            this.plSalesOrderTitle.Size = new System.Drawing.Size(1164, 72);
            this.plSalesOrderTitle.TabIndex = 0;
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(18, 6);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(138, 50);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Invoice";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(779, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 43);
            this.panel3.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Hint = "Search....";
            this.txtSearch.Location = new System.Drawing.Point(68, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(246, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalEntr);
            this.panel2.Controls.Add(this.btnDelOrder);
            this.panel2.Controls.Add(this.btnViewOrder);
            this.panel2.Controls.Add(this.pldgSalesOrder);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(3, 278);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 447);
            this.panel2.TabIndex = 2;
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelOrder.BorderRadius = 0;
            this.btnDelOrder.ButtonText = "Delete Invoice";
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
            this.btnDelOrder.Location = new System.Drawing.Point(181, 17);
            this.btnDelOrder.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDelOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelOrder.selected = false;
            this.btnDelOrder.Size = new System.Drawing.Size(142, 36);
            this.btnDelOrder.TabIndex = 11;
            this.btnDelOrder.Text = "Delete Invoice";
            this.btnDelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelOrder.Textcolor = System.Drawing.Color.White;
            this.btnDelOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOrder.Click += new System.EventHandler(this.BtnDelOrder_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Activecolor = System.Drawing.Color.Black;
            this.btnViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewOrder.BorderRadius = 0;
            this.btnViewOrder.ButtonText = "View Invoice";
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
            this.btnViewOrder.Location = new System.Drawing.Point(21, 17);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewOrder.OnHovercolor = System.Drawing.Color.Black;
            this.btnViewOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewOrder.selected = false;
            this.btnViewOrder.Size = new System.Drawing.Size(135, 36);
            this.btnViewOrder.TabIndex = 9;
            this.btnViewOrder.Text = "View Invoice";
            this.btnViewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewOrder.Textcolor = System.Drawing.Color.White;
            this.btnViewOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.plFilTo);
            this.panel1.Controls.Add(this.plFilFrom);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 177);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Location = new System.Drawing.Point(161, 118);
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
            // plFilTo
            // 
            this.plFilTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plFilTo.BackgroundImage")));
            this.plFilTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plFilTo.Controls.Add(this.DpTo);
            this.plFilTo.GradientBottomLeft = System.Drawing.Color.White;
            this.plFilTo.GradientBottomRight = System.Drawing.Color.White;
            this.plFilTo.GradientTopLeft = System.Drawing.Color.White;
            this.plFilTo.GradientTopRight = System.Drawing.Color.White;
            this.plFilTo.Location = new System.Drawing.Point(295, 72);
            this.plFilTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plFilTo.Name = "plFilTo";
            this.plFilTo.Quality = 10;
            this.plFilTo.Size = new System.Drawing.Size(192, 34);
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
            this.plFilFrom.Location = new System.Drawing.Point(36, 72);
            this.plFilFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plFilFrom.Name = "plFilFrom";
            this.plFilFrom.Quality = 10;
            this.plFilFrom.Size = new System.Drawing.Size(192, 34);
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
            this.DpFrom.Location = new System.Drawing.Point(5, 2);
            this.DpFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DpFrom.Name = "DpFrom";
            this.DpFrom.Size = new System.Drawing.Size(184, 25);
            this.DpFrom.TabIndex = 0;
            this.DpFrom.Value = new System.DateTime(2019, 5, 26, 14, 7, 29, 644);
            // 
            // plSalesOrder
            // 
            this.plSalesOrder.Controls.Add(this.panel2);
            this.plSalesOrder.Controls.Add(this.panel1);
            this.plSalesOrder.Controls.Add(this.plSalesOrderTitle);
            this.plSalesOrder.Location = new System.Drawing.Point(1, 2);
            this.plSalesOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plSalesOrder.Name = "plSalesOrder";
            this.plSalesOrder.Size = new System.Drawing.Size(1175, 769);
            this.plSalesOrder.TabIndex = 1;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 737);
            this.Controls.Add(this.plSalesOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.Shown += new System.EventHandler(this.Invoice_Shown);
            this.panel4.ResumeLayout(false);
            this.pldgSalesOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            this.plSalesOrderTitle.ResumeLayout(false);
            this.plSalesOrderTitle.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.plFilTo.ResumeLayout(false);
            this.plFilFrom.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuFlatButton btnDelOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewOrder;
        private System.Windows.Forms.Panel pldgSalesOrder;
        private System.Windows.Forms.Panel plSalesOrderTitle;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plSalesOrder;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgInvoice;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
    }
}