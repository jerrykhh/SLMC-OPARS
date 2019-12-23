namespace WindowsFormsApplication1
{
    partial class Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.lblNoOfItems = new System.Windows.Forms.Label();
            this.lblTotalEntr = new MaterialSkin.Controls.MaterialLabel();
            this.pldgItem = new System.Windows.Forms.Panel();
            this.dgItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.plCreateOrder = new System.Windows.Forms.Panel();
            this.btnAddItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plSalesOrderTitle = new System.Windows.Forms.Panel();
            this.lblItems = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDataCostVal = new System.Windows.Forms.Label();
            this.lblCostVal = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDataQty = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDataNoOfItem = new System.Windows.Forms.Label();
            this.plSalesOrder = new System.Windows.Forms.Panel();
            this.pldgItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            this.plCreateOrder.SuspendLayout();
            this.plSalesOrderTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.plSalesOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoOfItems
            // 
            this.lblNoOfItems.AutoSize = true;
            this.lblNoOfItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNoOfItems.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfItems.Location = new System.Drawing.Point(0, 90);
            this.lblNoOfItems.Name = "lblNoOfItems";
            this.lblNoOfItems.Size = new System.Drawing.Size(177, 30);
            this.lblNoOfItems.TabIndex = 2;
            this.lblNoOfItems.Text = "Number of Items";
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
            // pldgItem
            // 
            this.pldgItem.Controls.Add(this.dgItem);
            this.pldgItem.Location = new System.Drawing.Point(20, 70);
            this.pldgItem.Name = "pldgItem";
            this.pldgItem.Size = new System.Drawing.Size(1119, 332);
            this.pldgItem.TabIndex = 7;
            this.pldgItem.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgItem_Paint);
            // 
            // dgItem
            // 
            this.dgItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.AllowUserToDeleteRows = false;
            this.dgItem.AllowUserToResizeColumns = false;
            this.dgItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItem.BackgroundColor = System.Drawing.Color.White;
            this.dgItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgItem.ColumnHeadersHeight = 40;
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgItem.DoubleBuffered = true;
            this.dgItem.EnableHeadersVisualStyles = false;
            this.dgItem.GridColor = System.Drawing.Color.White;
            this.dgItem.HeaderBgColor = System.Drawing.Color.White;
            this.dgItem.HeaderForeColor = System.Drawing.Color.Black;
            this.dgItem.Location = new System.Drawing.Point(3, 1);
            this.dgItem.MultiSelect = false;
            this.dgItem.Name = "dgItem";
            this.dgItem.ReadOnly = true;
            this.dgItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.RowHeadersWidth = 51;
            this.dgItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgItem.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgItem.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgItem.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgItem.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgItem.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgItem.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgItem.RowTemplate.DividerHeight = 1;
            this.dgItem.RowTemplate.Height = 30;
            this.dgItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItem.Size = new System.Drawing.Size(1113, 327);
            this.dgItem.TabIndex = 6;
            this.dgItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgItem_CellClick);
            // 
            // plCreateOrder
            // 
            this.plCreateOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plCreateOrder.Controls.Add(this.btnAddItem);
            this.plCreateOrder.Location = new System.Drawing.Point(782, 13);
            this.plCreateOrder.Name = "plCreateOrder";
            this.plCreateOrder.Size = new System.Drawing.Size(313, 38);
            this.plCreateOrder.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Activecolor = System.Drawing.Color.Black;
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddItem.BorderRadius = 0;
            this.btnAddItem.ButtonText = "+   Add New Item";
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddItem.Iconimage = null;
            this.btnAddItem.Iconimage_right = null;
            this.btnAddItem.Iconimage_right_Selected = null;
            this.btnAddItem.Iconimage_Selected = null;
            this.btnAddItem.IconMarginLeft = 0;
            this.btnAddItem.IconMarginRight = 0;
            this.btnAddItem.IconRightVisible = true;
            this.btnAddItem.IconRightZoom = 0D;
            this.btnAddItem.IconVisible = true;
            this.btnAddItem.IconZoom = 90D;
            this.btnAddItem.IsTab = false;
            this.btnAddItem.Location = new System.Drawing.Point(-1, -1);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddItem.OnHovercolor = System.Drawing.Color.Black;
            this.btnAddItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddItem.selected = false;
            this.btnAddItem.Size = new System.Drawing.Size(313, 38);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "+   Add New Item";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddItem.Textcolor = System.Drawing.Color.White;
            this.btnAddItem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // plSalesOrderTitle
            // 
            this.plSalesOrderTitle.BackColor = System.Drawing.Color.White;
            this.plSalesOrderTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSalesOrderTitle.Controls.Add(this.plCreateOrder);
            this.plSalesOrderTitle.Controls.Add(this.lblItems);
            this.plSalesOrderTitle.Location = new System.Drawing.Point(3, 3);
            this.plSalesOrderTitle.Name = "plSalesOrderTitle";
            this.plSalesOrderTitle.Size = new System.Drawing.Size(1164, 71);
            this.plSalesOrderTitle.TabIndex = 0;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(18, 6);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(112, 50);
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "Items";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(779, 18);
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
            this.panel2.Controls.Add(this.btnEditOrder);
            this.panel2.Controls.Add(this.pldgItem);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(3, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 448);
            this.panel2.TabIndex = 2;
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelOrder.BorderRadius = 0;
            this.btnDelOrder.ButtonText = "Delete Item";
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
            this.btnDelOrder.Location = new System.Drawing.Point(178, 17);
            this.btnDelOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDelOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelOrder.selected = false;
            this.btnDelOrder.Size = new System.Drawing.Size(136, 36);
            this.btnDelOrder.TabIndex = 11;
            this.btnDelOrder.Text = "Delete Item";
            this.btnDelOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelOrder.Textcolor = System.Drawing.Color.White;
            this.btnDelOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOrder.Click += new System.EventHandler(this.BtnDelOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Activecolor = System.Drawing.Color.Black;
            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditOrder.BorderRadius = 0;
            this.btnEditOrder.ButtonText = "Edit Item";
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
            this.btnEditOrder.Location = new System.Drawing.Point(27, 17);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditOrder.OnHovercolor = System.Drawing.Color.Black;
            this.btnEditOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditOrder.selected = false;
            this.btnEditOrder.Size = new System.Drawing.Size(123, 36);
            this.btnEditOrder.TabIndex = 10;
            this.btnEditOrder.Text = "Edit Item";
            this.btnEditOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditOrder.Textcolor = System.Drawing.Color.White;
            this.btnEditOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 150);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblDataCostVal);
            this.panel6.Controls.Add(this.lblCostVal);
            this.panel6.Location = new System.Drawing.Point(728, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(388, 121);
            this.panel6.TabIndex = 7;
            // 
            // lblDataCostVal
            // 
            this.lblDataCostVal.AutoSize = true;
            this.lblDataCostVal.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCostVal.Location = new System.Drawing.Point(-4, 46);
            this.lblDataCostVal.Name = "lblDataCostVal";
            this.lblDataCostVal.Size = new System.Drawing.Size(261, 50);
            this.lblDataCostVal.TabIndex = 2;
            this.lblDataCostVal.Text = "lblDataCostVal";
            this.lblDataCostVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCostVal
            // 
            this.lblCostVal.AutoSize = true;
            this.lblCostVal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCostVal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostVal.Location = new System.Drawing.Point(0, 91);
            this.lblCostVal.Name = "lblCostVal";
            this.lblCostVal.Size = new System.Drawing.Size(284, 30);
            this.lblCostVal.TabIndex = 2;
            this.lblCostVal.Text = "Cost Value of Stock on Hand";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblDataQty);
            this.panel5.Controls.Add(this.lblQty);
            this.panel5.Location = new System.Drawing.Point(403, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(286, 120);
            this.panel5.TabIndex = 6;
            // 
            // lblDataQty
            // 
            this.lblDataQty.AutoSize = true;
            this.lblDataQty.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataQty.Location = new System.Drawing.Point(-4, 45);
            this.lblDataQty.Name = "lblDataQty";
            this.lblDataQty.Size = new System.Drawing.Size(198, 50);
            this.lblDataQty.TabIndex = 2;
            this.lblDataQty.Text = "lblDataQty";
            this.lblDataQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(0, 90);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(96, 30);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Quantity";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblDataNoOfItem);
            this.panel4.Controls.Add(this.lblNoOfItems);
            this.panel4.Location = new System.Drawing.Point(48, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 120);
            this.panel4.TabIndex = 5;
            // 
            // lblDataNoOfItem
            // 
            this.lblDataNoOfItem.AutoSize = true;
            this.lblDataNoOfItem.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNoOfItem.Location = new System.Drawing.Point(-5, 44);
            this.lblDataNoOfItem.Name = "lblDataNoOfItem";
            this.lblDataNoOfItem.Size = new System.Drawing.Size(303, 50);
            this.lblDataNoOfItem.TabIndex = 2;
            this.lblDataNoOfItem.Text = "lblDataNoOfItem";
            this.lblDataNoOfItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plSalesOrder
            // 
            this.plSalesOrder.Controls.Add(this.panel2);
            this.plSalesOrder.Controls.Add(this.panel1);
            this.plSalesOrder.Controls.Add(this.plSalesOrderTitle);
            this.plSalesOrder.Location = new System.Drawing.Point(1, 3);
            this.plSalesOrder.Name = "plSalesOrder";
            this.plSalesOrder.Size = new System.Drawing.Size(1175, 704);
            this.plSalesOrder.TabIndex = 1;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 708);
            this.Controls.Add(this.plSalesOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.Shown += new System.EventHandler(this.Item_Shown);
            this.pldgItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            this.plCreateOrder.ResumeLayout(false);
            this.plSalesOrderTitle.ResumeLayout(false);
            this.plSalesOrderTitle.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.plSalesOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNoOfItems;
        private MaterialSkin.Controls.MaterialLabel lblTotalEntr;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditOrder;
        private System.Windows.Forms.Panel pldgItem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgItem;
        private System.Windows.Forms.Panel plCreateOrder;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddItem;
        private System.Windows.Forms.Panel plSalesOrderTitle;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel plSalesOrder;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDataCostVal;
        private System.Windows.Forms.Label lblCostVal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDataQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblDataNoOfItem;
    }
}