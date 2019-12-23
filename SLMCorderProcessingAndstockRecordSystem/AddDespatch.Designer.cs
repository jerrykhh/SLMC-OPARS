namespace WindowsFormsApplication1
{
    partial class AddDespatch
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
            this.txtOrderID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblOrderID = new MaterialSkin.Controls.MaterialLabel();
            this.txtInvoiceID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblInvoiceID = new MaterialSkin.Controls.MaterialLabel();
            this.txtDeliveryID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDeliveryID = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeliveryDate = new MaterialSkin.Controls.MaterialLabel();
            this.dateRecDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOrderID.Depth = 0;
            this.txtOrderID.Hint = "Order ID";
            this.txtOrderID.Location = new System.Drawing.Point(106, 105);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.PasswordChar = '\0';
            this.txtOrderID.SelectedText = "";
            this.txtOrderID.SelectionLength = 0;
            this.txtOrderID.SelectionStart = 0;
            this.txtOrderID.Size = new System.Drawing.Size(170, 23);
            this.txtOrderID.TabIndex = 12;
            this.txtOrderID.UseSystemPasswordChar = false;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrderID.Depth = 0;
            this.lblOrderID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrderID.Location = new System.Drawing.Point(37, 105);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(45, 19);
            this.lblOrderID.TabIndex = 11;
            this.lblOrderID.Text = "Order";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInvoiceID.Depth = 0;
            this.txtInvoiceID.Enabled = false;
            this.txtInvoiceID.Hint = "Invoice ID";
            this.txtInvoiceID.Location = new System.Drawing.Point(106, 219);
            this.txtInvoiceID.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.PasswordChar = '\0';
            this.txtInvoiceID.SelectedText = "";
            this.txtInvoiceID.SelectionLength = 0;
            this.txtInvoiceID.SelectionStart = 0;
            this.txtInvoiceID.Size = new System.Drawing.Size(169, 23);
            this.txtInvoiceID.TabIndex = 10;
            this.txtInvoiceID.UseSystemPasswordChar = false;
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInvoiceID.Depth = 0;
            this.lblInvoiceID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInvoiceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvoiceID.Location = new System.Drawing.Point(38, 219);
            this.lblInvoiceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoiceID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(57, 19);
            this.lblInvoiceID.TabIndex = 9;
            this.lblInvoiceID.Text = "Invoice";
            // 
            // txtDeliveryID
            // 
            this.txtDeliveryID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDeliveryID.Depth = 0;
            this.txtDeliveryID.Enabled = false;
            this.txtDeliveryID.Hint = "Delivery ID";
            this.txtDeliveryID.Location = new System.Drawing.Point(106, 166);
            this.txtDeliveryID.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDeliveryID.Name = "txtDeliveryID";
            this.txtDeliveryID.PasswordChar = '\0';
            this.txtDeliveryID.SelectedText = "";
            this.txtDeliveryID.SelectionLength = 0;
            this.txtDeliveryID.SelectionStart = 0;
            this.txtDeliveryID.Size = new System.Drawing.Size(169, 23);
            this.txtDeliveryID.TabIndex = 8;
            this.txtDeliveryID.UseSystemPasswordChar = false;
            // 
            // lblDeliveryID
            // 
            this.lblDeliveryID.AutoSize = true;
            this.lblDeliveryID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeliveryID.Depth = 0;
            this.lblDeliveryID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDeliveryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeliveryID.Location = new System.Drawing.Point(38, 166);
            this.lblDeliveryID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeliveryID.Name = "lblDeliveryID";
            this.lblDeliveryID.Size = new System.Drawing.Size(62, 19);
            this.lblDeliveryID.TabIndex = 7;
            this.lblDeliveryID.Text = "Delivery";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeliveryDate.Depth = 0;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDeliveryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeliveryDate.Location = new System.Drawing.Point(38, 268);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(97, 19);
            this.lblDeliveryDate.TabIndex = 13;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // dateRecDate
            // 
            this.dateRecDate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dateRecDate.BorderRadius = 0;
            this.dateRecDate.ForeColor = System.Drawing.Color.White;
            this.dateRecDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateRecDate.FormatCustom = null;
            this.dateRecDate.Location = new System.Drawing.Point(40, 290);
            this.dateRecDate.Name = "dateRecDate";
            this.dateRecDate.Size = new System.Drawing.Size(236, 36);
            this.dateRecDate.TabIndex = 14;
            this.dateRecDate.Value = new System.DateTime(2019, 5, 29, 12, 5, 33, 544);
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(40, 368);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(95, 29);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(180, 368);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = true;
            this.btnExit.Size = new System.Drawing.Size(95, 29);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddDespatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 438);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateRecDate);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(this.txtDeliveryID);
            this.Controls.Add(this.lblDeliveryID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDespatch";
            this.Text = "AddDespatch";
            this.Load += new System.EventHandler(this.AddDespatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtOrderID;
        private MaterialSkin.Controls.MaterialLabel lblOrderID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtInvoiceID;
        private MaterialSkin.Controls.MaterialLabel lblInvoiceID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDeliveryID;
        private MaterialSkin.Controls.MaterialLabel lblDeliveryID;
        private MaterialSkin.Controls.MaterialLabel lblDeliveryDate;
        private Bunifu.Framework.UI.BunifuDatepicker dateRecDate;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton btnExit;
    }
}