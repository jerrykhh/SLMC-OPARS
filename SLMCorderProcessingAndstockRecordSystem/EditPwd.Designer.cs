namespace WindowsFormsApplication1
{
    partial class EditPwd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.ComboBox();
            this.txtPwdAgain = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnReg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtPwdAgain);
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.cbDept);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 386);
            this.panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(40, 202);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 21);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.FormattingEnabled = true;
            this.txtTitle.Items.AddRange(new object[] {
            "Sales",
            "Sales Manager",
            "Storeman",
            "Store Manager",
            "Despatch Staff",
            "Despatch Manager",
            "Good Inwards Clerk",
            "Good Inwards Manager",
            "Administrator"});
            this.txtTitle.Location = new System.Drawing.Point(38, 227);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(188, 28);
            this.txtTitle.TabIndex = 8;
            // 
            // txtPwdAgain
            // 
            this.txtPwdAgain.Depth = 0;
            this.txtPwdAgain.Hint = "Confirm Password";
            this.txtPwdAgain.Location = new System.Drawing.Point(38, 120);
            this.txtPwdAgain.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPwdAgain.Name = "txtPwdAgain";
            this.txtPwdAgain.PasswordChar = '\0';
            this.txtPwdAgain.SelectedText = "";
            this.txtPwdAgain.SelectionLength = 0;
            this.txtPwdAgain.SelectionStart = 0;
            this.txtPwdAgain.Size = new System.Drawing.Size(188, 23);
            this.txtPwdAgain.TabIndex = 5;
            this.txtPwdAgain.UseSystemPasswordChar = true;
            // 
            // btnReg
            // 
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.Depth = 0;
            this.btnReg.Location = new System.Drawing.Point(50, 286);
            this.btnReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReg.Name = "btnReg";
            this.btnReg.Primary = true;
            this.btnReg.Size = new System.Drawing.Size(164, 32);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Update ";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // cbDept
            // 
            this.cbDept.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(38, 160);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(188, 28);
            this.cbDept.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "New Password";
            this.txtPassword.Location = new System.Drawing.Point(38, 82);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(188, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "Username";
            this.txtUsername.Location = new System.Drawing.Point(38, 41);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(188, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // EditPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EditPwd";
            this.Text = "Update User";
            this.Load += new System.EventHandler(this.EditPwd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPwdAgain;
        private MaterialSkin.Controls.MaterialRaisedButton btnReg;
        private System.Windows.Forms.ComboBox cbDept;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox txtTitle;
    }
}