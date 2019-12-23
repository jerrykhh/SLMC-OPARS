namespace WindowsFormsApplication1
{
    partial class Despatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Despatch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plDespatchTitle = new System.Windows.Forms.Panel();
            this.btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDespatch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTo = new System.Windows.Forms.Label();
            this.plFilTo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.plFilFrom = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSearch = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOrderReturn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pldgDespatch = new System.Windows.Forms.Panel();
            this.dgDelivery = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.plDespatchTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.plFilTo.SuspendLayout();
            this.plFilFrom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pldgDespatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // plDespatchTitle
            // 
            this.plDespatchTitle.BackColor = System.Drawing.Color.White;
            this.plDespatchTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plDespatchTitle.Controls.Add(this.btn);
            this.plDespatchTitle.Controls.Add(this.lblDespatch);
            this.plDespatchTitle.Location = new System.Drawing.Point(10, 10);
            this.plDespatchTitle.Name = "plDespatchTitle";
            this.plDespatchTitle.Size = new System.Drawing.Size(1155, 57);
            this.plDespatchTitle.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Activecolor = System.Drawing.Color.Black;
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn.BorderRadius = 0;
            this.btn.ButtonText = "+   Add Despatch";
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.DisabledColor = System.Drawing.Color.Gray;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Iconcolor = System.Drawing.Color.Transparent;
            this.btn.Iconimage = null;
            this.btn.Iconimage_right = null;
            this.btn.Iconimage_right_Selected = null;
            this.btn.Iconimage_Selected = null;
            this.btn.IconMarginLeft = 0;
            this.btn.IconMarginRight = 0;
            this.btn.IconRightVisible = true;
            this.btn.IconRightZoom = 0D;
            this.btn.IconVisible = true;
            this.btn.IconZoom = 90D;
            this.btn.IsTab = false;
            this.btn.Location = new System.Drawing.Point(818, 8);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn.Name = "btn";
            this.btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn.OnHovercolor = System.Drawing.Color.Black;
            this.btn.OnHoverTextColor = System.Drawing.Color.White;
            this.btn.selected = false;
            this.btn.Size = new System.Drawing.Size(313, 38);
            this.btn.TabIndex = 1;
            this.btn.Text = "+   Add Despatch";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn.Textcolor = System.Drawing.Color.White;
            this.btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // lblDespatch
            // 
            this.lblDespatch.AutoSize = true;
            this.lblDespatch.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespatch.Location = new System.Drawing.Point(15, 2);
            this.lblDespatch.Name = "lblDespatch";
            this.lblDespatch.Size = new System.Drawing.Size(175, 50);
            this.lblDespatch.TabIndex = 0;
            this.lblDespatch.Text = "Despatch";
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
            this.panel1.Location = new System.Drawing.Point(10, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 176);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Location = new System.Drawing.Point(153, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 39);
            this.panel5.TabIndex = 11;
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
            this.DpFrom.Value = new System.DateTime(2019, 5, 26, 14, 7, 29, 644);
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
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "Order ID";
            this.txtSearch.Location = new System.Drawing.Point(901, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(221, 23);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Depth = 0;
            this.lblSearch.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearch.Location = new System.Drawing.Point(846, 34);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 19);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnOrderReturn);
            this.panel2.Controls.Add(this.pldgDespatch);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(10, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 454);
            this.panel2.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.Black;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 0;
            this.btnPrint.ButtonText = "Print";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 90D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(188, 21);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(96, 36);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnOrderReturn
            // 
            this.btnOrderReturn.Activecolor = System.Drawing.Color.Black;
            this.btnOrderReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrderReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrderReturn.BorderRadius = 0;
            this.btnOrderReturn.ButtonText = "Order Return";
            this.btnOrderReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderReturn.DisabledColor = System.Drawing.Color.Gray;
            this.btnOrderReturn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOrderReturn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOrderReturn.Iconimage")));
            this.btnOrderReturn.Iconimage_right = null;
            this.btnOrderReturn.Iconimage_right_Selected = null;
            this.btnOrderReturn.Iconimage_Selected = null;
            this.btnOrderReturn.IconMarginLeft = 0;
            this.btnOrderReturn.IconMarginRight = 0;
            this.btnOrderReturn.IconRightVisible = true;
            this.btnOrderReturn.IconRightZoom = 0D;
            this.btnOrderReturn.IconVisible = true;
            this.btnOrderReturn.IconZoom = 90D;
            this.btnOrderReturn.IsTab = false;
            this.btnOrderReturn.Location = new System.Drawing.Point(21, 21);
            this.btnOrderReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderReturn.Name = "btnOrderReturn";
            this.btnOrderReturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrderReturn.OnHovercolor = System.Drawing.Color.Black;
            this.btnOrderReturn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrderReturn.selected = false;
            this.btnOrderReturn.Size = new System.Drawing.Size(140, 36);
            this.btnOrderReturn.TabIndex = 9;
            this.btnOrderReturn.Text = "Order Return";
            this.btnOrderReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderReturn.Textcolor = System.Drawing.Color.White;
            this.btnOrderReturn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderReturn.Click += new System.EventHandler(this.btnOrderReturn_Click);
            // 
            // pldgDespatch
            // 
            this.pldgDespatch.Controls.Add(this.dgDelivery);
            this.pldgDespatch.Location = new System.Drawing.Point(17, 74);
            this.pldgDespatch.Name = "pldgDespatch";
            this.pldgDespatch.Size = new System.Drawing.Size(1119, 344);
            this.pldgDespatch.TabIndex = 7;
            this.pldgDespatch.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgDespatch_Paint);
            // 
            // dgDelivery
            // 
            this.dgDelivery.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgDelivery.AllowUserToAddRows = false;
            this.dgDelivery.AllowUserToDeleteRows = false;
            this.dgDelivery.AllowUserToResizeColumns = false;
            this.dgDelivery.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgDelivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDelivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDelivery.BackgroundColor = System.Drawing.Color.White;
            this.dgDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDelivery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDelivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDelivery.ColumnHeadersHeight = 40;
            this.dgDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDelivery.DoubleBuffered = true;
            this.dgDelivery.EnableHeadersVisualStyles = false;
            this.dgDelivery.GridColor = System.Drawing.Color.White;
            this.dgDelivery.HeaderBgColor = System.Drawing.Color.White;
            this.dgDelivery.HeaderForeColor = System.Drawing.Color.Black;
            this.dgDelivery.Location = new System.Drawing.Point(1, 3);
            this.dgDelivery.MultiSelect = false;
            this.dgDelivery.Name = "dgDelivery";
            this.dgDelivery.ReadOnly = true;
            this.dgDelivery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDelivery.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDelivery.RowHeadersVisible = false;
            this.dgDelivery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgDelivery.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgDelivery.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgDelivery.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDelivery.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDelivery.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgDelivery.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDelivery.RowTemplate.DividerHeight = 1;
            this.dgDelivery.RowTemplate.Height = 30;
            this.dgDelivery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDelivery.Size = new System.Drawing.Size(1113, 336);
            this.dgDelivery.TabIndex = 6;
            this.dgDelivery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDelivery_CellClick);
            // 
            // Despatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 735);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plDespatchTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Despatch";
            this.Text = "Despatch";
            this.Load += new System.EventHandler(this.Despatch_Load);
            this.Shown += new System.EventHandler(this.Despatch_Shown);
            this.plDespatchTitle.ResumeLayout(false);
            this.plDespatchTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.plFilTo.ResumeLayout(false);
            this.plFilFrom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pldgDespatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plDespatchTitle;
        private Bunifu.Framework.UI.BunifuFlatButton btn;
        private System.Windows.Forms.Label lblDespatch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private System.Windows.Forms.Label lblTo;
        private Bunifu.Framework.UI.BunifuGradientPanel plFilTo;
        private Bunifu.Framework.UI.BunifuDatepicker DpTo;
        private Bunifu.Framework.UI.BunifuGradientPanel plFilFrom;
        private Bunifu.Framework.UI.BunifuDatepicker DpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFilter;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialLabel lblSearch;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrderReturn;
        private System.Windows.Forms.Panel pldgDespatch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgDelivery;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
    }
}