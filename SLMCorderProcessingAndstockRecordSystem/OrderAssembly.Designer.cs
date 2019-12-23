namespace WindowsFormsApplication1
{
    partial class OrderAssembly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderAssembly));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblTotalEntr = new MaterialSkin.Controls.MaterialLabel();
            this.pldgOrderAssembly = new System.Windows.Forms.Panel();
            this.dgOrderAssembly = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.plCreateOrder = new System.Windows.Forms.Panel();
            this.btnExpand = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plOrderAssemblyTitle = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOrderAssembly = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblOrderAssembly = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrderReturn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.plFilTo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.plFilFrom = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.plSalesOrder = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.pldgOrderAssembly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderAssembly)).BeginInit();
            this.plCreateOrder.SuspendLayout();
            this.plOrderAssemblyTitle.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.plFilTo.SuspendLayout();
            this.plFilFrom.SuspendLayout();
            this.plSalesOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFilter);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btnFilter
            // 
            this.btnFilter.Activecolor = System.Drawing.Color.Black;
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnFilter, "btnFilter");
            this.btnFilter.BorderRadius = 0;
            this.btnFilter.ButtonText = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilter.OnHovercolor = System.Drawing.Color.Black;
            this.btnFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilter.selected = false;
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.Textcolor = System.Drawing.Color.White;
            this.btnFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click_1);
            // 
            // lblFrom
            // 
            resources.ApplyResources(this.lblFrom, "lblFrom");
            this.lblFrom.Name = "lblFrom";
            // 
            // lblFilter
            // 
            resources.ApplyResources(this.lblFilter, "lblFilter");
            this.lblFilter.Name = "lblFilter";
            // 
            // lblTotalEntr
            // 
            resources.ApplyResources(this.lblTotalEntr, "lblTotalEntr");
            this.lblTotalEntr.Depth = 0;
            this.lblTotalEntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalEntr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalEntr.Name = "lblTotalEntr";
            // 
            // pldgOrderAssembly
            // 
            this.pldgOrderAssembly.Controls.Add(this.dgOrderAssembly);
            resources.ApplyResources(this.pldgOrderAssembly, "pldgOrderAssembly");
            this.pldgOrderAssembly.Name = "pldgOrderAssembly";
            this.pldgOrderAssembly.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgOrderAssembly_Paint);
            // 
            // dgOrderAssembly
            // 
            this.dgOrderAssembly.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgOrderAssembly.AllowUserToAddRows = false;
            this.dgOrderAssembly.AllowUserToDeleteRows = false;
            this.dgOrderAssembly.AllowUserToResizeColumns = false;
            this.dgOrderAssembly.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrderAssembly.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrderAssembly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrderAssembly.BackgroundColor = System.Drawing.Color.White;
            this.dgOrderAssembly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOrderAssembly.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgOrderAssembly.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderAssembly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgOrderAssembly, "dgOrderAssembly");
            this.dgOrderAssembly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgOrderAssembly.DoubleBuffered = true;
            this.dgOrderAssembly.EnableHeadersVisualStyles = false;
            this.dgOrderAssembly.GridColor = System.Drawing.Color.White;
            this.dgOrderAssembly.HeaderBgColor = System.Drawing.Color.White;
            this.dgOrderAssembly.HeaderForeColor = System.Drawing.Color.Black;
            this.dgOrderAssembly.MultiSelect = false;
            this.dgOrderAssembly.Name = "dgOrderAssembly";
            this.dgOrderAssembly.ReadOnly = true;
            this.dgOrderAssembly.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderAssembly.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgOrderAssembly.RowHeadersVisible = false;
            this.dgOrderAssembly.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOrderAssembly.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgOrderAssembly.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgOrderAssembly.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgOrderAssembly.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgOrderAssembly.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrderAssembly.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgOrderAssembly.RowTemplate.DividerHeight = 1;
            this.dgOrderAssembly.RowTemplate.Height = 30;
            this.dgOrderAssembly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderAssembly.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrderAssembly_CellClick);
            // 
            // plCreateOrder
            // 
            this.plCreateOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plCreateOrder.Controls.Add(this.btnExpand);
            resources.ApplyResources(this.plCreateOrder, "plCreateOrder");
            this.plCreateOrder.Name = "plCreateOrder";
            // 
            // btnExpand
            // 
            this.btnExpand.Activecolor = System.Drawing.Color.Black;
            this.btnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnExpand, "btnExpand");
            this.btnExpand.BorderRadius = 0;
            this.btnExpand.ButtonText = "Expand Excel";
            this.btnExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpand.DisabledColor = System.Drawing.Color.Gray;
            this.btnExpand.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExpand.Iconimage = null;
            this.btnExpand.Iconimage_right = null;
            this.btnExpand.Iconimage_right_Selected = null;
            this.btnExpand.Iconimage_Selected = null;
            this.btnExpand.IconMarginLeft = 0;
            this.btnExpand.IconMarginRight = 0;
            this.btnExpand.IconRightVisible = true;
            this.btnExpand.IconRightZoom = 0D;
            this.btnExpand.IconVisible = true;
            this.btnExpand.IconZoom = 90D;
            this.btnExpand.IsTab = false;
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExpand.OnHovercolor = System.Drawing.Color.Black;
            this.btnExpand.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExpand.selected = false;
            this.btnExpand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExpand.Textcolor = System.Drawing.Color.White;
            this.btnExpand.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // plOrderAssemblyTitle
            // 
            this.plOrderAssemblyTitle.BackColor = System.Drawing.Color.White;
            this.plOrderAssemblyTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plOrderAssemblyTitle.Controls.Add(this.panel5);
            this.plOrderAssemblyTitle.Controls.Add(this.plCreateOrder);
            this.plOrderAssemblyTitle.Controls.Add(this.lblOrderAssembly);
            resources.ApplyResources(this.plOrderAssemblyTitle, "plOrderAssemblyTitle");
            this.plOrderAssemblyTitle.Name = "plOrderAssemblyTitle";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnOrderAssembly);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // btnOrderAssembly
            // 
            this.btnOrderAssembly.Activecolor = System.Drawing.Color.Black;
            this.btnOrderAssembly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnOrderAssembly, "btnOrderAssembly");
            this.btnOrderAssembly.BorderRadius = 0;
            this.btnOrderAssembly.ButtonText = "+  Order Assembly";
            this.btnOrderAssembly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderAssembly.DisabledColor = System.Drawing.Color.Gray;
            this.btnOrderAssembly.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOrderAssembly.Iconimage = null;
            this.btnOrderAssembly.Iconimage_right = null;
            this.btnOrderAssembly.Iconimage_right_Selected = null;
            this.btnOrderAssembly.Iconimage_Selected = null;
            this.btnOrderAssembly.IconMarginLeft = 0;
            this.btnOrderAssembly.IconMarginRight = 0;
            this.btnOrderAssembly.IconRightVisible = true;
            this.btnOrderAssembly.IconRightZoom = 0D;
            this.btnOrderAssembly.IconVisible = true;
            this.btnOrderAssembly.IconZoom = 90D;
            this.btnOrderAssembly.IsTab = false;
            this.btnOrderAssembly.Name = "btnOrderAssembly";
            this.btnOrderAssembly.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrderAssembly.OnHovercolor = System.Drawing.Color.Black;
            this.btnOrderAssembly.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrderAssembly.selected = false;
            this.btnOrderAssembly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrderAssembly.Textcolor = System.Drawing.Color.White;
            this.btnOrderAssembly.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAssembly.Click += new System.EventHandler(this.btnOrderAssembly_Click);
            // 
            // lblOrderAssembly
            // 
            resources.ApplyResources(this.lblOrderAssembly, "lblOrderAssembly");
            this.lblOrderAssembly.Name = "lblOrderAssembly";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Hint = "Search....";
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnOrderReturn);
            this.panel2.Controls.Add(this.lblTotalEntr);
            this.panel2.Controls.Add(this.btnViewOrder);
            this.panel2.Controls.Add(this.pldgOrderAssembly);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnOrderReturn
            // 
            this.btnOrderReturn.Activecolor = System.Drawing.Color.Black;
            this.btnOrderReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnOrderReturn, "btnOrderReturn");
            this.btnOrderReturn.BorderRadius = 0;
            this.btnOrderReturn.ButtonText = "Return";
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
            this.btnOrderReturn.Name = "btnOrderReturn";
            this.btnOrderReturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrderReturn.OnHovercolor = System.Drawing.Color.Black;
            this.btnOrderReturn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrderReturn.selected = false;
            this.btnOrderReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrderReturn.Textcolor = System.Drawing.Color.White;
            this.btnOrderReturn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderReturn.Click += new System.EventHandler(this.btnOrderReturn_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Activecolor = System.Drawing.Color.Black;
            this.btnViewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnViewOrder, "btnViewOrder");
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
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewOrder.OnHovercolor = System.Drawing.Color.Black;
            this.btnViewOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewOrder.selected = false;
            this.btnViewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewOrder.Textcolor = System.Drawing.Color.White;
            this.btnViewOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.plFilTo);
            this.panel1.Controls.Add(this.plFilFrom);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClear);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.Black;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.OnHovercolor = System.Drawing.Color.Black;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // bunifuGradientPanel1
            // 
            resources.ApplyResources(this.bunifuGradientPanel1, "bunifuGradientPanel1");
            this.bunifuGradientPanel1.Controls.Add(this.ddStatus);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            // 
            // ddStatus
            // 
            resources.ApplyResources(this.ddStatus, "ddStatus");
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Items.AddRange(new object[] {
            resources.GetString("ddStatus.Items"),
            resources.GetString("ddStatus.Items1"),
            resources.GetString("ddStatus.Items2"),
            resources.GetString("ddStatus.Items3"),
            resources.GetString("ddStatus.Items4"),
            resources.GetString("ddStatus.Items5")});
            this.ddStatus.Name = "ddStatus";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblTo
            // 
            resources.ApplyResources(this.lblTo, "lblTo");
            this.lblTo.Name = "lblTo";
            // 
            // plFilTo
            // 
            resources.ApplyResources(this.plFilTo, "plFilTo");
            this.plFilTo.Controls.Add(this.DpTo);
            this.plFilTo.GradientBottomLeft = System.Drawing.Color.White;
            this.plFilTo.GradientBottomRight = System.Drawing.Color.White;
            this.plFilTo.GradientTopLeft = System.Drawing.Color.White;
            this.plFilTo.GradientTopRight = System.Drawing.Color.White;
            this.plFilTo.Name = "plFilTo";
            this.plFilTo.Quality = 10;
            this.plFilTo.Paint += new System.Windows.Forms.PaintEventHandler(this.plFilTo_Paint);
            // 
            // DpTo
            // 
            this.DpTo.BackColor = System.Drawing.Color.White;
            this.DpTo.BorderRadius = 0;
            resources.ApplyResources(this.DpTo, "DpTo");
            this.DpTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DpTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DpTo.FormatCustom = null;
            this.DpTo.Name = "DpTo";
            this.DpTo.Value = new System.DateTime(2019, 5, 26, 14, 7, 29, 644);
            // 
            // plFilFrom
            // 
            resources.ApplyResources(this.plFilFrom, "plFilFrom");
            this.plFilFrom.Controls.Add(this.DpFrom);
            this.plFilFrom.GradientBottomLeft = System.Drawing.Color.White;
            this.plFilFrom.GradientBottomRight = System.Drawing.Color.White;
            this.plFilFrom.GradientTopLeft = System.Drawing.Color.White;
            this.plFilFrom.GradientTopRight = System.Drawing.Color.White;
            this.plFilFrom.Name = "plFilFrom";
            this.plFilFrom.Quality = 10;
            this.plFilFrom.Paint += new System.Windows.Forms.PaintEventHandler(this.plFilFrom_Paint);
            // 
            // DpFrom
            // 
            this.DpFrom.BackColor = System.Drawing.Color.White;
            this.DpFrom.BorderRadius = 0;
            resources.ApplyResources(this.DpFrom, "DpFrom");
            this.DpFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DpFrom.FormatCustom = null;
            this.DpFrom.Name = "DpFrom";
            this.DpFrom.Value = new System.DateTime(2019, 5, 26, 14, 7, 29, 644);
            // 
            // plSalesOrder
            // 
            this.plSalesOrder.Controls.Add(this.panel2);
            this.plSalesOrder.Controls.Add(this.panel1);
            this.plSalesOrder.Controls.Add(this.plOrderAssemblyTitle);
            resources.ApplyResources(this.plSalesOrder, "plSalesOrder");
            this.plSalesOrder.Name = "plSalesOrder";
            // 
            // OrderAssembly
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plSalesOrder);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderAssembly";
            this.Load += new System.EventHandler(this.OrderAssembly_Load);
            this.panel4.ResumeLayout(false);
            this.pldgOrderAssembly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderAssembly)).EndInit();
            this.plCreateOrder.ResumeLayout(false);
            this.plOrderAssemblyTitle.ResumeLayout(false);
            this.plOrderAssemblyTitle.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.plFilTo.ResumeLayout(false);
            this.plFilFrom.ResumeLayout(false);
            this.plSalesOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private Bunifu.Framework.UI.BunifuGradientPanel plFilFrom;
        private Bunifu.Framework.UI.BunifuDatepicker DpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFilter;
        private MaterialSkin.Controls.MaterialLabel lblTotalEntr;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewOrder;
        private System.Windows.Forms.Panel pldgOrderAssembly;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgOrderAssembly;
        private System.Windows.Forms.Panel plCreateOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnExpand;
        private System.Windows.Forms.Panel plOrderAssemblyTitle;
        private System.Windows.Forms.Label lblOrderAssembly;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plSalesOrder;
        private System.Windows.Forms.Label lblTo;
        private Bunifu.Framework.UI.BunifuGradientPanel plFilTo;
        private Bunifu.Framework.UI.BunifuDatepicker DpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrderAssembly;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrderReturn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ComboBox ddStatus;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
    }
}