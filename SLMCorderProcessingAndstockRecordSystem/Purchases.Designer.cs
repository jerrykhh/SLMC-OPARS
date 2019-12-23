namespace WindowsFormsApplication1
{
    partial class Purchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchases));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DpFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.plFilFrom = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DpTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.plFilTo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.plPurchases = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalEntr = new MaterialSkin.Controls.MaterialLabel();
            this.pldgPurchases = new System.Windows.Forms.Panel();
            this.dgPurchases = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.plPurchasesTitle = new System.Windows.Forms.Panel();
            this.lblPurchases = new System.Windows.Forms.Label();
            this.plFilFrom.SuspendLayout();
            this.plFilTo.SuspendLayout();
            this.plPurchases.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pldgPurchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchases)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.plPurchasesTitle.SuspendLayout();
            this.SuspendLayout();
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
            this.DpFrom.Value = new System.DateTime(2019, 6, 5, 0, 0, 0, 0);
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
            this.DpTo.Value = new System.DateTime(2019, 6, 5, 0, 0, 0, 0);
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
            // plPurchases
            // 
            this.plPurchases.Controls.Add(this.panel2);
            this.plPurchases.Controls.Add(this.panel1);
            this.plPurchases.Controls.Add(this.plPurchasesTitle);
            this.plPurchases.Location = new System.Drawing.Point(4, 1);
            this.plPurchases.Name = "plPurchases";
            this.plPurchases.Size = new System.Drawing.Size(1175, 718);
            this.plPurchases.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalEntr);
            this.panel2.Controls.Add(this.pldgPurchases);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(3, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 434);
            this.panel2.TabIndex = 2;
            // 
            // lblTotalEntr
            // 
            this.lblTotalEntr.AutoSize = true;
            this.lblTotalEntr.Depth = 0;
            this.lblTotalEntr.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalEntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalEntr.Location = new System.Drawing.Point(19, 406);
            this.lblTotalEntr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalEntr.Name = "lblTotalEntr";
            this.lblTotalEntr.Size = new System.Drawing.Size(117, 19);
            this.lblTotalEntr.TabIndex = 12;
            this.lblTotalEntr.Text = "Showing Entries";
            // 
            // pldgPurchases
            // 
            this.pldgPurchases.Controls.Add(this.dgPurchases);
            this.pldgPurchases.Location = new System.Drawing.Point(20, 74);
            this.pldgPurchases.Name = "pldgPurchases";
            this.pldgPurchases.Size = new System.Drawing.Size(1119, 329);
            this.pldgPurchases.TabIndex = 7;
            this.pldgPurchases.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgPurchases_Paint);
            // 
            // dgPurchases
            // 
            this.dgPurchases.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgPurchases.AllowUserToAddRows = false;
            this.dgPurchases.AllowUserToDeleteRows = false;
            this.dgPurchases.AllowUserToResizeColumns = false;
            this.dgPurchases.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgPurchases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPurchases.BackgroundColor = System.Drawing.Color.White;
            this.dgPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPurchases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPurchases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPurchases.ColumnHeadersHeight = 40;
            this.dgPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgPurchases.DoubleBuffered = true;
            this.dgPurchases.EnableHeadersVisualStyles = false;
            this.dgPurchases.GridColor = System.Drawing.Color.White;
            this.dgPurchases.HeaderBgColor = System.Drawing.Color.White;
            this.dgPurchases.HeaderForeColor = System.Drawing.Color.Black;
            this.dgPurchases.Location = new System.Drawing.Point(3, 1);
            this.dgPurchases.MultiSelect = false;
            this.dgPurchases.Name = "dgPurchases";
            this.dgPurchases.ReadOnly = true;
            this.dgPurchases.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPurchases.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPurchases.RowHeadersVisible = false;
            this.dgPurchases.RowHeadersWidth = 51;
            this.dgPurchases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgPurchases.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgPurchases.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgPurchases.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPurchases.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgPurchases.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgPurchases.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPurchases.RowTemplate.DividerHeight = 1;
            this.dgPurchases.RowTemplate.Height = 30;
            this.dgPurchases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPurchases.Size = new System.Drawing.Size(1113, 325);
            this.dgPurchases.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(805, 25);
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
            this.panel1.Controls.Add(this.panel5);
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
            // panel5
            // 
            this.panel5.Controls.Add(this.Clear);
            this.panel5.Location = new System.Drawing.Point(154, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 39);
            this.panel5.TabIndex = 8;
            // 
            // Clear
            // 
            this.Clear.Activecolor = System.Drawing.Color.Black;
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear.BorderRadius = 0;
            this.Clear.ButtonText = "Clear";
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.DisabledColor = System.Drawing.Color.Gray;
            this.Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Iconcolor = System.Drawing.Color.Transparent;
            this.Clear.Iconimage = null;
            this.Clear.Iconimage_right = null;
            this.Clear.Iconimage_right_Selected = null;
            this.Clear.Iconimage_Selected = null;
            this.Clear.IconMarginLeft = 0;
            this.Clear.IconMarginRight = 0;
            this.Clear.IconRightVisible = true;
            this.Clear.IconRightZoom = 0D;
            this.Clear.IconVisible = true;
            this.Clear.IconZoom = 90D;
            this.Clear.IsTab = false;
            this.Clear.Location = new System.Drawing.Point(0, 0);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Clear.OnHovercolor = System.Drawing.Color.Black;
            this.Clear.OnHoverTextColor = System.Drawing.Color.White;
            this.Clear.selected = false;
            this.Clear.Size = new System.Drawing.Size(89, 39);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Clear.Textcolor = System.Drawing.Color.White;
            this.Clear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
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
            // plPurchasesTitle
            // 
            this.plPurchasesTitle.BackColor = System.Drawing.Color.White;
            this.plPurchasesTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plPurchasesTitle.Controls.Add(this.lblPurchases);
            this.plPurchasesTitle.Location = new System.Drawing.Point(3, 7);
            this.plPurchasesTitle.Name = "plPurchasesTitle";
            this.plPurchasesTitle.Size = new System.Drawing.Size(1164, 71);
            this.plPurchasesTitle.TabIndex = 0;
            // 
            // lblPurchases
            // 
            this.lblPurchases.AutoSize = true;
            this.lblPurchases.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchases.Location = new System.Drawing.Point(18, 10);
            this.lblPurchases.Name = "lblPurchases";
            this.lblPurchases.Size = new System.Drawing.Size(185, 50);
            this.lblPurchases.TabIndex = 0;
            this.lblPurchases.Text = "Purchases";
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 722);
            this.Controls.Add(this.plPurchases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchases";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.Purchases_Load);
            this.Shown += new System.EventHandler(this.Purchases_Shown);
            this.plFilFrom.ResumeLayout(false);
            this.plFilTo.ResumeLayout(false);
            this.plPurchases.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pldgPurchases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchases)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.plPurchasesTitle.ResumeLayout(false);
            this.plPurchasesTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDatepicker DpFrom;
        private Bunifu.Framework.UI.BunifuGradientPanel plFilFrom;
        private Bunifu.Framework.UI.BunifuDatepicker DpTo;
        private Bunifu.Framework.UI.BunifuGradientPanel plFilTo;
        private System.Windows.Forms.Panel plPurchases;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lblTotalEntr;
        private System.Windows.Forms.Panel pldgPurchases;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgPurchases;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel plPurchasesTitle;
        private System.Windows.Forms.Label lblPurchases;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton Clear;
    }
}