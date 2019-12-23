namespace WindowsFormsApplication1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddnewmessage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelMessage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditMessage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnViewMessage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plSalesOrderTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pldgMM = new System.Windows.Forms.Panel();
            this.dgMergMessage = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.plSalesOrderTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pldgMM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMergMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddnewmessage
            // 
            this.btnAddnewmessage.Activecolor = System.Drawing.Color.Black;
            this.btnAddnewmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddnewmessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddnewmessage.BorderRadius = 0;
            this.btnAddnewmessage.ButtonText = "+  Add New Message";
            this.btnAddnewmessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddnewmessage.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddnewmessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewmessage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddnewmessage.Iconimage = null;
            this.btnAddnewmessage.Iconimage_right = null;
            this.btnAddnewmessage.Iconimage_right_Selected = null;
            this.btnAddnewmessage.Iconimage_Selected = null;
            this.btnAddnewmessage.IconMarginLeft = 0;
            this.btnAddnewmessage.IconMarginRight = 0;
            this.btnAddnewmessage.IconRightVisible = true;
            this.btnAddnewmessage.IconRightZoom = 0D;
            this.btnAddnewmessage.IconVisible = true;
            this.btnAddnewmessage.IconZoom = 90D;
            this.btnAddnewmessage.IsTab = false;
            this.btnAddnewmessage.Location = new System.Drawing.Point(855, 18);
            this.btnAddnewmessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddnewmessage.Name = "btnAddnewmessage";
            this.btnAddnewmessage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddnewmessage.OnHovercolor = System.Drawing.Color.Black;
            this.btnAddnewmessage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddnewmessage.selected = false;
            this.btnAddnewmessage.Size = new System.Drawing.Size(291, 38);
            this.btnAddnewmessage.TabIndex = 52;
            this.btnAddnewmessage.Text = "+  Add New Message";
            this.btnAddnewmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddnewmessage.Textcolor = System.Drawing.Color.White;
            this.btnAddnewmessage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewmessage.Click += new System.EventHandler(this.btnAddnewmessage_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Hint = "Search....";
            this.txtSearch.Location = new System.Drawing.Point(896, 83);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(243, 23);
            this.txtSearch.TabIndex = 50;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.White;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(835, 83);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(55, 19);
            this.materialLabel7.TabIndex = 44;
            this.materialLabel7.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mergency Message";
            // 
            // btnDelMessage
            // 
            this.btnDelMessage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelMessage.BorderRadius = 0;
            this.btnDelMessage.ButtonText = "Delete Message";
            this.btnDelMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelMessage.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelMessage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelMessage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelMessage.Iconimage")));
            this.btnDelMessage.Iconimage_right = null;
            this.btnDelMessage.Iconimage_right_Selected = null;
            this.btnDelMessage.Iconimage_Selected = null;
            this.btnDelMessage.IconMarginLeft = 0;
            this.btnDelMessage.IconMarginRight = 0;
            this.btnDelMessage.IconRightVisible = true;
            this.btnDelMessage.IconRightZoom = 0D;
            this.btnDelMessage.IconVisible = true;
            this.btnDelMessage.IconZoom = 90D;
            this.btnDelMessage.IsTab = false;
            this.btnDelMessage.Location = new System.Drawing.Point(368, 50);
            this.btnDelMessage.Name = "btnDelMessage";
            this.btnDelMessage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelMessage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDelMessage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelMessage.selected = false;
            this.btnDelMessage.Size = new System.Drawing.Size(155, 36);
            this.btnDelMessage.TabIndex = 62;
            this.btnDelMessage.Text = "Delete Message";
            this.btnDelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelMessage.Textcolor = System.Drawing.Color.White;
            this.btnDelMessage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelMessage.Click += new System.EventHandler(this.btnDelMessage_Click_1);
            // 
            // btnEditMessage
            // 
            this.btnEditMessage.Activecolor = System.Drawing.Color.Black;
            this.btnEditMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditMessage.BorderRadius = 0;
            this.btnEditMessage.ButtonText = "Edit Message";
            this.btnEditMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMessage.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditMessage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditMessage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditMessage.Iconimage")));
            this.btnEditMessage.Iconimage_right = null;
            this.btnEditMessage.Iconimage_right_Selected = null;
            this.btnEditMessage.Iconimage_Selected = null;
            this.btnEditMessage.IconMarginLeft = 0;
            this.btnEditMessage.IconMarginRight = 0;
            this.btnEditMessage.IconRightVisible = true;
            this.btnEditMessage.IconRightZoom = 0D;
            this.btnEditMessage.IconVisible = true;
            this.btnEditMessage.IconZoom = 90D;
            this.btnEditMessage.IsTab = false;
            this.btnEditMessage.Location = new System.Drawing.Point(200, 50);
            this.btnEditMessage.Name = "btnEditMessage";
            this.btnEditMessage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditMessage.OnHovercolor = System.Drawing.Color.Black;
            this.btnEditMessage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditMessage.selected = false;
            this.btnEditMessage.Size = new System.Drawing.Size(145, 36);
            this.btnEditMessage.TabIndex = 61;
            this.btnEditMessage.Text = "Edit Message";
            this.btnEditMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditMessage.Textcolor = System.Drawing.Color.White;
            this.btnEditMessage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMessage.Click += new System.EventHandler(this.btnEditMessage_Click_1);
            // 
            // btnViewMessage
            // 
            this.btnViewMessage.Activecolor = System.Drawing.Color.Black;
            this.btnViewMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewMessage.BorderRadius = 0;
            this.btnViewMessage.ButtonText = "ViewMessage";
            this.btnViewMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMessage.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewMessage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewMessage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnViewMessage.Iconimage")));
            this.btnViewMessage.Iconimage_right = null;
            this.btnViewMessage.Iconimage_right_Selected = null;
            this.btnViewMessage.Iconimage_Selected = null;
            this.btnViewMessage.IconMarginLeft = 0;
            this.btnViewMessage.IconMarginRight = 0;
            this.btnViewMessage.IconRightVisible = true;
            this.btnViewMessage.IconRightZoom = 0D;
            this.btnViewMessage.IconVisible = true;
            this.btnViewMessage.IconZoom = 90D;
            this.btnViewMessage.IsTab = false;
            this.btnViewMessage.Location = new System.Drawing.Point(34, 50);
            this.btnViewMessage.Name = "btnViewMessage";
            this.btnViewMessage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewMessage.OnHovercolor = System.Drawing.Color.Black;
            this.btnViewMessage.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewMessage.selected = false;
            this.btnViewMessage.Size = new System.Drawing.Size(140, 36);
            this.btnViewMessage.TabIndex = 60;
            this.btnViewMessage.Text = "ViewMessage";
            this.btnViewMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewMessage.Textcolor = System.Drawing.Color.White;
            this.btnViewMessage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMessage.Click += new System.EventHandler(this.btnViewMessage_Click_1);
            // 
            // plSalesOrderTitle
            // 
            this.plSalesOrderTitle.BackColor = System.Drawing.Color.White;
            this.plSalesOrderTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSalesOrderTitle.Controls.Add(this.label1);
            this.plSalesOrderTitle.Controls.Add(this.btnAddnewmessage);
            this.plSalesOrderTitle.Location = new System.Drawing.Point(4, 10);
            this.plSalesOrderTitle.Name = "plSalesOrderTitle";
            this.plSalesOrderTitle.Size = new System.Drawing.Size(1164, 71);
            this.plSalesOrderTitle.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pldgMM);
            this.panel1.Controls.Add(this.btnDelMessage);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnViewMessage);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.btnEditMessage);
            this.panel1.Location = new System.Drawing.Point(4, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 511);
            this.panel1.TabIndex = 53;
            // 
            // pldgMM
            // 
            this.pldgMM.Controls.Add(this.dgMergMessage);
            this.pldgMM.Location = new System.Drawing.Point(20, 121);
            this.pldgMM.Name = "pldgMM";
            this.pldgMM.Size = new System.Drawing.Size(1119, 364);
            this.pldgMM.TabIndex = 63;
            this.pldgMM.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgMM_Paint);
            // 
            // dgMergMessage
            // 
            this.dgMergMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgMergMessage.AllowUserToAddRows = false;
            this.dgMergMessage.AllowUserToDeleteRows = false;
            this.dgMergMessage.AllowUserToResizeColumns = false;
            this.dgMergMessage.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgMergMessage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMergMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMergMessage.BackgroundColor = System.Drawing.Color.White;
            this.dgMergMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMergMessage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgMergMessage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMergMessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgMergMessage.ColumnHeadersHeight = 40;
            this.dgMergMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMergMessage.DoubleBuffered = true;
            this.dgMergMessage.EnableHeadersVisualStyles = false;
            this.dgMergMessage.GridColor = System.Drawing.Color.White;
            this.dgMergMessage.HeaderBgColor = System.Drawing.Color.White;
            this.dgMergMessage.HeaderForeColor = System.Drawing.Color.Black;
            this.dgMergMessage.Location = new System.Drawing.Point(3, 1);
            this.dgMergMessage.MultiSelect = false;
            this.dgMergMessage.Name = "dgMergMessage";
            this.dgMergMessage.ReadOnly = true;
            this.dgMergMessage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMergMessage.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgMergMessage.RowHeadersVisible = false;
            this.dgMergMessage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgMergMessage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgMergMessage.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgMergMessage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMergMessage.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgMergMessage.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgMergMessage.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgMergMessage.RowTemplate.DividerHeight = 1;
            this.dgMergMessage.RowTemplate.Height = 30;
            this.dgMergMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgMergMessage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMergMessage.Size = new System.Drawing.Size(1113, 360);
            this.dgMergMessage.TabIndex = 6;
            this.dgMergMessage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgMergMessage_CellClick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plSalesOrderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load_1);
            this.Shown += new System.EventHandler(this.Admin_Shown_1);
            this.plSalesOrderTitle.ResumeLayout(false);
            this.plSalesOrderTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pldgMM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMergMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnAddnewmessage;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelMessage;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditMessage;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewMessage;
        private System.Windows.Forms.Panel plSalesOrderTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pldgMM;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgMergMessage;
    }
}