namespace WindowsFormsApplication1
{
    partial class GRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRN));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plSalesOrder = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTotalEntr = new MaterialSkin.Controls.MaterialLabel();
            this.pldgGRN = new System.Windows.Forms.Panel();
            this.dgGRN = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.plGRMTitle = new System.Windows.Forms.Panel();
            this.plCreateOrder = new System.Windows.Forms.Panel();
            this.btnAddGRN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblGRN = new System.Windows.Forms.Label();
            this.plSalesOrder.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pldgGRN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGRN)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.plGRMTitle.SuspendLayout();
            this.plCreateOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // plSalesOrder
            // 
            this.plSalesOrder.Controls.Add(this.panel2);
            this.plSalesOrder.Controls.Add(this.panel1);
            this.plSalesOrder.Controls.Add(this.plGRMTitle);
            this.plSalesOrder.Location = new System.Drawing.Point(3, 1);
            this.plSalesOrder.Name = "plSalesOrder";
            this.plSalesOrder.Size = new System.Drawing.Size(1175, 730);
            this.plSalesOrder.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.lblTotalEntr);
            this.panel2.Controls.Add(this.pldgGRN);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(3, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 443);
            this.panel2.TabIndex = 2;
            // 
            // btnDel
            // 
            this.btnDel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.BorderRadius = 0;
            this.btnDel.ButtonText = "Delete GRN";
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.DisabledColor = System.Drawing.Color.Gray;
            this.btnDel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDel.Iconimage")));
            this.btnDel.Iconimage_right = null;
            this.btnDel.Iconimage_right_Selected = null;
            this.btnDel.Iconimage_Selected = null;
            this.btnDel.IconMarginLeft = 0;
            this.btnDel.IconMarginRight = 0;
            this.btnDel.IconRightVisible = true;
            this.btnDel.IconRightZoom = 0D;
            this.btnDel.IconVisible = true;
            this.btnDel.IconZoom = 90D;
            this.btnDel.IsTab = false;
            this.btnDel.Location = new System.Drawing.Point(41, 26);
            this.btnDel.Name = "btnDel";
            this.btnDel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDel.selected = false;
            this.btnDel.Size = new System.Drawing.Size(136, 36);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Delete GRN";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDel.Textcolor = System.Drawing.Color.White;
            this.btnDel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // lblTotalEntr
            // 
            this.lblTotalEntr.AutoSize = true;
            this.lblTotalEntr.Depth = 0;
            this.lblTotalEntr.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalEntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalEntr.Location = new System.Drawing.Point(19, 417);
            this.lblTotalEntr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalEntr.Name = "lblTotalEntr";
            this.lblTotalEntr.Size = new System.Drawing.Size(117, 19);
            this.lblTotalEntr.TabIndex = 12;
            this.lblTotalEntr.Text = "Showing Entries";
            // 
            // pldgGRN
            // 
            this.pldgGRN.Controls.Add(this.dgGRN);
            this.pldgGRN.Location = new System.Drawing.Point(20, 74);
            this.pldgGRN.Name = "pldgGRN";
            this.pldgGRN.Size = new System.Drawing.Size(1119, 331);
            this.pldgGRN.TabIndex = 7;
            this.pldgGRN.Paint += new System.Windows.Forms.PaintEventHandler(this.PldgGRN_Paint);
            // 
            // dgGRN
            // 
            this.dgGRN.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgGRN.AllowUserToAddRows = false;
            this.dgGRN.AllowUserToDeleteRows = false;
            this.dgGRN.AllowUserToResizeColumns = false;
            this.dgGRN.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgGRN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgGRN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGRN.BackgroundColor = System.Drawing.Color.White;
            this.dgGRN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgGRN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgGRN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGRN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgGRN.ColumnHeadersHeight = 40;
            this.dgGRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgGRN.DoubleBuffered = true;
            this.dgGRN.EnableHeadersVisualStyles = false;
            this.dgGRN.GridColor = System.Drawing.Color.White;
            this.dgGRN.HeaderBgColor = System.Drawing.Color.White;
            this.dgGRN.HeaderForeColor = System.Drawing.Color.Black;
            this.dgGRN.Location = new System.Drawing.Point(3, 1);
            this.dgGRN.MultiSelect = false;
            this.dgGRN.Name = "dgGRN";
            this.dgGRN.ReadOnly = true;
            this.dgGRN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGRN.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgGRN.RowHeadersVisible = false;
            this.dgGRN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgGRN.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgGRN.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgGRN.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgGRN.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgGRN.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgGRN.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgGRN.RowTemplate.DividerHeight = 1;
            this.dgGRN.RowTemplate.Height = 30;
            this.dgGRN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgGRN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgGRN.Size = new System.Drawing.Size(1113, 321);
            this.dgGRN.TabIndex = 6;
            this.dgGRN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgGRN_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(803, 26);
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
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuGradientPanel2);
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 177);
            this.panel1.TabIndex = 1;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.DpFrom);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(36, 76);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(192, 33);
            this.bunifuGradientPanel2.TabIndex = 12;
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
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.DpTo);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(299, 76);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(192, 33);
            this.bunifuGradientPanel1.TabIndex = 11;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Location = new System.Drawing.Point(153, 121);
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
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
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
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
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
            // plGRMTitle
            // 
            this.plGRMTitle.BackColor = System.Drawing.Color.White;
            this.plGRMTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plGRMTitle.Controls.Add(this.plCreateOrder);
            this.plGRMTitle.Controls.Add(this.lblGRN);
            this.plGRMTitle.Location = new System.Drawing.Point(3, 7);
            this.plGRMTitle.Name = "plGRMTitle";
            this.plGRMTitle.Size = new System.Drawing.Size(1164, 71);
            this.plGRMTitle.TabIndex = 0;
            // 
            // plCreateOrder
            // 
            this.plCreateOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plCreateOrder.Controls.Add(this.btnAddGRN);
            this.plCreateOrder.Location = new System.Drawing.Point(782, 17);
            this.plCreateOrder.Name = "plCreateOrder";
            this.plCreateOrder.Size = new System.Drawing.Size(313, 38);
            this.plCreateOrder.TabIndex = 1;
            // 
            // btnAddGRN
            // 
            this.btnAddGRN.Activecolor = System.Drawing.Color.Black;
            this.btnAddGRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddGRN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGRN.BorderRadius = 0;
            this.btnAddGRN.ButtonText = "+   Add GRN";
            this.btnAddGRN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGRN.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddGRN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGRN.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddGRN.Iconimage = null;
            this.btnAddGRN.Iconimage_right = null;
            this.btnAddGRN.Iconimage_right_Selected = null;
            this.btnAddGRN.Iconimage_Selected = null;
            this.btnAddGRN.IconMarginLeft = 0;
            this.btnAddGRN.IconMarginRight = 0;
            this.btnAddGRN.IconRightVisible = true;
            this.btnAddGRN.IconRightZoom = 0D;
            this.btnAddGRN.IconVisible = true;
            this.btnAddGRN.IconZoom = 90D;
            this.btnAddGRN.IsTab = false;
            this.btnAddGRN.Location = new System.Drawing.Point(-1, -1);
            this.btnAddGRN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddGRN.Name = "btnAddGRN";
            this.btnAddGRN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddGRN.OnHovercolor = System.Drawing.Color.Black;
            this.btnAddGRN.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddGRN.selected = false;
            this.btnAddGRN.Size = new System.Drawing.Size(313, 38);
            this.btnAddGRN.TabIndex = 1;
            this.btnAddGRN.Text = "+   Add GRN";
            this.btnAddGRN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddGRN.Textcolor = System.Drawing.Color.White;
            this.btnAddGRN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGRN.Click += new System.EventHandler(this.BtnAddGRN_Click);
            // 
            // lblGRN
            // 
            this.lblGRN.AutoSize = true;
            this.lblGRN.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRN.Location = new System.Drawing.Point(18, 10);
            this.lblGRN.Name = "lblGRN";
            this.lblGRN.Size = new System.Drawing.Size(359, 50);
            this.lblGRN.TabIndex = 0;
            this.lblGRN.Text = "Good Received Note";
            // 
            // GRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 734);
            this.Controls.Add(this.plSalesOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GRN";
            this.Text = "GRN";
            this.Load += new System.EventHandler(this.GRN_Load);
            this.plSalesOrder.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pldgGRN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGRN)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.plGRMTitle.ResumeLayout(false);
            this.plGRMTitle.PerformLayout();
            this.plCreateOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plSalesOrder;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lblTotalEntr;
        private System.Windows.Forms.Panel pldgGRN;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgGRN;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel plGRMTitle;
        private System.Windows.Forms.Panel plCreateOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddGRN;
        private System.Windows.Forms.Label lblGRN;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private Bunifu.Framework.UI.BunifuFlatButton btnDel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuDatepicker DpFrom;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuDatepicker DpTo;
    }
}