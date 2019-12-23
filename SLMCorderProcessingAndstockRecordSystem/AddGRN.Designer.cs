namespace WindowsFormsApplication1
{
    partial class AddGRN
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
            this.lblPurchaseID = new MaterialSkin.Controls.MaterialLabel();
            this.txtPurchaseID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblItemID = new MaterialSkin.Controls.MaterialLabel();
            this.txtItemID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblrecQty = new MaterialSkin.Controls.MaterialLabel();
            this.txtRecQty = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLocation = new MaterialSkin.Controls.MaterialLabel();
            this.txtLocation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblRecDate = new MaterialSkin.Controls.MaterialLabel();
            this.dateRecDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPurchaseID
            // 
            this.lblPurchaseID.AutoSize = true;
            this.lblPurchaseID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPurchaseID.Depth = 0;
            this.lblPurchaseID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPurchaseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPurchaseID.Location = new System.Drawing.Point(51, 112);
            this.lblPurchaseID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPurchaseID.Name = "lblPurchaseID";
            this.lblPurchaseID.Size = new System.Drawing.Size(110, 24);
            this.lblPurchaseID.TabIndex = 0;
            this.lblPurchaseID.Text = "Purchase ID";
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPurchaseID.Depth = 0;
            this.txtPurchaseID.Hint = "";
            this.txtPurchaseID.Location = new System.Drawing.Point(235, 112);
            this.txtPurchaseID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPurchaseID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.PasswordChar = '\0';
            this.txtPurchaseID.SelectedText = "";
            this.txtPurchaseID.SelectionLength = 0;
            this.txtPurchaseID.SelectionStart = 0;
            this.txtPurchaseID.Size = new System.Drawing.Size(205, 28);
            this.txtPurchaseID.TabIndex = 1;
            this.txtPurchaseID.UseSystemPasswordChar = false;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblItemID.Depth = 0;
            this.lblItemID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblItemID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemID.Location = new System.Drawing.Point(51, 169);
            this.lblItemID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(70, 24);
            this.lblItemID.TabIndex = 2;
            this.lblItemID.Text = "Item ID";
            // 
            // txtItemID
            // 
            this.txtItemID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtItemID.Depth = 0;
            this.txtItemID.Hint = "";
            this.txtItemID.Location = new System.Drawing.Point(235, 169);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.PasswordChar = '\0';
            this.txtItemID.SelectedText = "";
            this.txtItemID.SelectionLength = 0;
            this.txtItemID.SelectionStart = 0;
            this.txtItemID.Size = new System.Drawing.Size(205, 28);
            this.txtItemID.TabIndex = 3;
            this.txtItemID.UseSystemPasswordChar = false;
            // 
            // lblrecQty
            // 
            this.lblrecQty.AutoSize = true;
            this.lblrecQty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblrecQty.Depth = 0;
            this.lblrecQty.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblrecQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblrecQty.Location = new System.Drawing.Point(51, 224);
            this.lblrecQty.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblrecQty.Name = "lblrecQty";
            this.lblrecQty.Size = new System.Drawing.Size(120, 24);
            this.lblrecQty.TabIndex = 8;
            this.lblrecQty.Text = "Received Qty";
            // 
            // txtRecQty
            // 
            this.txtRecQty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRecQty.Depth = 0;
            this.txtRecQty.Hint = "";
            this.txtRecQty.Location = new System.Drawing.Point(235, 224);
            this.txtRecQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecQty.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRecQty.Name = "txtRecQty";
            this.txtRecQty.PasswordChar = '\0';
            this.txtRecQty.SelectedText = "";
            this.txtRecQty.SelectionLength = 0;
            this.txtRecQty.SelectionStart = 0;
            this.txtRecQty.Size = new System.Drawing.Size(205, 28);
            this.txtRecQty.TabIndex = 9;
            this.txtRecQty.UseSystemPasswordChar = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLocation.Depth = 0;
            this.lblLocation.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLocation.Location = new System.Drawing.Point(51, 285);
            this.lblLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 24);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLocation.Depth = 0;
            this.txtLocation.Hint = "";
            this.txtLocation.Location = new System.Drawing.Point(235, 285);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.Size = new System.Drawing.Size(205, 28);
            this.txtLocation.TabIndex = 11;
            this.txtLocation.UseSystemPasswordChar = false;
            // 
            // lblRecDate
            // 
            this.lblRecDate.AutoSize = true;
            this.lblRecDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecDate.Depth = 0;
            this.lblRecDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRecDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRecDate.Location = new System.Drawing.Point(52, 341);
            this.lblRecDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRecDate.Name = "lblRecDate";
            this.lblRecDate.Size = new System.Drawing.Size(85, 24);
            this.lblRecDate.TabIndex = 12;
            this.lblRecDate.Text = "Rec Date";
            // 
            // dateRecDate
            // 
            this.dateRecDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateRecDate.BorderRadius = 0;
            this.dateRecDate.ForeColor = System.Drawing.Color.White;
            this.dateRecDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateRecDate.FormatCustom = null;
            this.dateRecDate.Location = new System.Drawing.Point(56, 369);
            this.dateRecDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateRecDate.Name = "dateRecDate";
            this.dateRecDate.Size = new System.Drawing.Size(384, 41);
            this.dateRecDate.TabIndex = 13;
            this.dateRecDate.Value = new System.DateTime(2019, 6, 5, 0, 0, 0, 0);
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(277, 552);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(133, 46);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(81, 552);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(135, 46);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(155, 414);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(182, 28);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "Missing Input Value";
            this.lblError.Visible = false;
            // 
            // AddGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 658);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateRecDate);
            this.Controls.Add(this.lblRecDate);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtRecQty);
            this.Controls.Add(this.lblrecQty);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.txtPurchaseID);
            this.Controls.Add(this.lblPurchaseID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddGRN";
            this.Text = "AddGRN";
            this.Load += new System.EventHandler(this.AddGRN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblPurchaseID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPurchaseID;
        private MaterialSkin.Controls.MaterialLabel lblItemID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemID;
        private MaterialSkin.Controls.MaterialLabel lblrecQty;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRecQty;
        private MaterialSkin.Controls.MaterialLabel lblLocation;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocation;
        private MaterialSkin.Controls.MaterialLabel lblRecDate;
        private Bunifu.Framework.UI.BunifuDatepicker dateRecDate;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.Label lblError;
    }
}