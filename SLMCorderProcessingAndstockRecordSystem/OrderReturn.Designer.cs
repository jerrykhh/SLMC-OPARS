namespace WindowsFormsApplication1
{
    partial class OrderReturn
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
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pldgOrderReturn = new System.Windows.Forms.Panel();
            this.dgOrderReturn = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtQty = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnInput = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnComplete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pldgOrderReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReturn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(940, 585);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(124, 44);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pldgOrderReturn
            // 
            this.pldgOrderReturn.Controls.Add(this.dgOrderReturn);
            this.pldgOrderReturn.Location = new System.Drawing.Point(12, 85);
            this.pldgOrderReturn.Name = "pldgOrderReturn";
            this.pldgOrderReturn.Size = new System.Drawing.Size(1062, 362);
            this.pldgOrderReturn.TabIndex = 11;
            this.pldgOrderReturn.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgOrderReturn_Paint);
            // 
            // dgOrderReturn
            // 
            this.dgOrderReturn.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgOrderReturn.AllowUserToAddRows = false;
            this.dgOrderReturn.AllowUserToDeleteRows = false;
            this.dgOrderReturn.AllowUserToResizeColumns = false;
            this.dgOrderReturn.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrderReturn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrderReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrderReturn.BackgroundColor = System.Drawing.Color.White;
            this.dgOrderReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOrderReturn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgOrderReturn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrderReturn.ColumnHeadersHeight = 40;
            this.dgOrderReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgOrderReturn.DoubleBuffered = true;
            this.dgOrderReturn.EnableHeadersVisualStyles = false;
            this.dgOrderReturn.GridColor = System.Drawing.Color.White;
            this.dgOrderReturn.HeaderBgColor = System.Drawing.Color.White;
            this.dgOrderReturn.HeaderForeColor = System.Drawing.Color.Black;
            this.dgOrderReturn.Location = new System.Drawing.Point(3, 3);
            this.dgOrderReturn.MultiSelect = false;
            this.dgOrderReturn.Name = "dgOrderReturn";
            this.dgOrderReturn.ReadOnly = true;
            this.dgOrderReturn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderReturn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgOrderReturn.RowHeadersVisible = false;
            this.dgOrderReturn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOrderReturn.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgOrderReturn.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgOrderReturn.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgOrderReturn.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgOrderReturn.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrderReturn.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgOrderReturn.RowTemplate.DividerHeight = 1;
            this.dgOrderReturn.RowTemplate.Height = 30;
            this.dgOrderReturn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgOrderReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderReturn.Size = new System.Drawing.Size(1056, 355);
            this.dgOrderReturn.TabIndex = 6;
            this.dgOrderReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderReturn_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.txtItemID);
            this.panel1.Controls.Add(this.btnInput);
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.pldgOrderReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 571);
            this.panel1.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(882, 38);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(172, 23);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Depth = 0;
            this.txtQty.Hint = "Qty";
            this.txtQty.Location = new System.Drawing.Point(400, 38);
            this.txtQty.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.Size = new System.Drawing.Size(91, 23);
            this.txtQty.TabIndex = 15;
            this.txtQty.UseSystemPasswordChar = false;
            // 
            // txtItemID
            // 
            this.txtItemID.Depth = 0;
            this.txtItemID.Hint = "itemID";
            this.txtItemID.Location = new System.Drawing.Point(254, 38);
            this.txtItemID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.PasswordChar = '\0';
            this.txtItemID.SelectedText = "";
            this.txtItemID.SelectionLength = 0;
            this.txtItemID.SelectionStart = 0;
            this.txtItemID.Size = new System.Drawing.Size(130, 23);
            this.txtItemID.TabIndex = 14;
            this.txtItemID.UseSystemPasswordChar = false;
            // 
            // btnInput
            // 
            this.btnInput.Depth = 0;
            this.btnInput.Location = new System.Drawing.Point(523, 18);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInput.Name = "btnInput";
            this.btnInput.Primary = true;
            this.btnInput.Size = new System.Drawing.Size(124, 44);
            this.btnInput.TabIndex = 13;
            this.btnInput.Text = "INPUT";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Depth = 0;
            this.txtInput.Hint = "OrderID";
            this.txtInput.Location = new System.Drawing.Point(24, 38);
            this.txtInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.SelectedText = "";
            this.txtInput.SelectionLength = 0;
            this.txtInput.SelectionStart = 0;
            this.txtInput.Size = new System.Drawing.Size(206, 23);
            this.txtInput.TabIndex = 12;
            this.txtInput.UseSystemPasswordChar = false;
            this.txtInput.Enter += new System.EventHandler(this.TxtInput_Enter);
            // 
            // btnComplete
            // 
            this.btnComplete.Depth = 0;
            this.btnComplete.Location = new System.Drawing.Point(773, 515);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Primary = true;
            this.btnComplete.Size = new System.Drawing.Size(124, 44);
            this.btnComplete.TabIndex = 18;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // OrderReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 641);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Name = "OrderReturn";
            this.Text = "Order Return";
            this.Load += new System.EventHandler(this.OrderReturn_Load);
            this.pldgOrderReturn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderReturn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
        private System.Windows.Forms.Panel pldgOrderReturn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgOrderReturn;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQty;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialRaisedButton btnComplete;
    }
}