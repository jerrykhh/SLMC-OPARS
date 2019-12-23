namespace WindowsFormsApplication1
{
    partial class Login
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
            this.plLogin = new System.Windows.Forms.Panel();
            this.plLoginbtn = new System.Windows.Forms.Panel();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picAccount = new System.Windows.Forms.PictureBox();
            this.txtAccount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSubmit = new MaterialSkin.Controls.MaterialFlatButton();
            this.picPasswordBlack = new System.Windows.Forms.PictureBox();
            this.picAccountBlack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIntr = new System.Windows.Forms.Label();
            this.lblSLCM = new System.Windows.Forms.Label();
            this.lblLtd = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.plLogin.SuspendLayout();
            this.plLoginbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccountBlack)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plLogin
            // 
            this.plLogin.BackColor = System.Drawing.Color.White;
            this.plLogin.Controls.Add(this.lblError);
            this.plLogin.Controls.Add(this.plLoginbtn);
            this.plLogin.Controls.Add(this.picPassword);
            this.plLogin.Controls.Add(this.picAccount);
            this.plLogin.Controls.Add(this.txtAccount);
            this.plLogin.Controls.Add(this.txtPassword);
            this.plLogin.Controls.Add(this.btnSubmit);
            this.plLogin.Controls.Add(this.picPasswordBlack);
            this.plLogin.Controls.Add(this.picAccountBlack);
            this.plLogin.Controls.Add(this.panel1);
            this.plLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.plLogin.Location = new System.Drawing.Point(25, 89);
            this.plLogin.Name = "plLogin";
            this.plLogin.Size = new System.Drawing.Size(332, 373);
            this.plLogin.TabIndex = 20;
            // 
            // plLoginbtn
            // 
            this.plLoginbtn.Controls.Add(this.btnLogin);
            this.plLoginbtn.Location = new System.Drawing.Point(49, 294);
            this.plLoginbtn.Name = "plLoginbtn";
            this.plLoginbtn.Size = new System.Drawing.Size(239, 46);
            this.plLoginbtn.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Depth = 0;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(239, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // picPassword
            // 
            this.picPassword.Image = global::WindowsFormsApplication1.Properties.Resources.password1;
            this.picPassword.Location = new System.Drawing.Point(38, 198);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(30, 33);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassword.TabIndex = 5;
            this.picPassword.TabStop = false;
            // 
            // picAccount
            // 
            this.picAccount.Image = global::WindowsFormsApplication1.Properties.Resources.account1;
            this.picAccount.Location = new System.Drawing.Point(36, 134);
            this.picAccount.Name = "picAccount";
            this.picAccount.Size = new System.Drawing.Size(30, 35);
            this.picAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAccount.TabIndex = 4;
            this.picAccount.TabStop = false;
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.White;
            this.txtAccount.Depth = 0;
            this.txtAccount.ForeColor = System.Drawing.Color.Silver;
            this.txtAccount.Hint = "Username";
            this.txtAccount.Location = new System.Drawing.Point(83, 146);
            this.txtAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.SelectedText = "";
            this.txtAccount.SelectionLength = 0;
            this.txtAccount.SelectionStart = 0;
            this.txtAccount.Size = new System.Drawing.Size(205, 23);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.UseSystemPasswordChar = false;
            this.txtAccount.Click += new System.EventHandler(this.txtAccount_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "Password";
            this.txtPassword.Location = new System.Drawing.Point(83, 210);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(205, 23);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(132, 404);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = false;
            this.btnSubmit.Size = new System.Drawing.Size(172, 36);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "materialFlatButton1";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // picPasswordBlack
            // 
            this.picPasswordBlack.Image = global::WindowsFormsApplication1.Properties.Resources.password_Black;
            this.picPasswordBlack.Location = new System.Drawing.Point(38, 198);
            this.picPasswordBlack.Name = "picPasswordBlack";
            this.picPasswordBlack.Size = new System.Drawing.Size(30, 33);
            this.picPasswordBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPasswordBlack.TabIndex = 7;
            this.picPasswordBlack.TabStop = false;
            // 
            // picAccountBlack
            // 
            this.picAccountBlack.Image = global::WindowsFormsApplication1.Properties.Resources.account_Black;
            this.picAccountBlack.Location = new System.Drawing.Point(36, 134);
            this.picAccountBlack.Name = "picAccountBlack";
            this.picAccountBlack.Size = new System.Drawing.Size(30, 35);
            this.picAccountBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAccountBlack.TabIndex = 6;
            this.picAccountBlack.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIntr);
            this.panel1.Controls.Add(this.lblSLCM);
            this.panel1.Controls.Add(this.lblLtd);
            this.panel1.Location = new System.Drawing.Point(40, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 74);
            this.panel1.TabIndex = 11;
            // 
            // lblIntr
            // 
            this.lblIntr.AutoSize = true;
            this.lblIntr.BackColor = System.Drawing.Color.Transparent;
            this.lblIntr.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIntr.Location = new System.Drawing.Point(11, 47);
            this.lblIntr.Name = "lblIntr";
            this.lblIntr.Size = new System.Drawing.Size(233, 15);
            this.lblIntr.TabIndex = 12;
            this.lblIntr.Text = "Order Processing and Stock Record System";
            // 
            // lblSLCM
            // 
            this.lblSLCM.AutoSize = true;
            this.lblSLCM.BackColor = System.Drawing.Color.Transparent;
            this.lblSLCM.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLCM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSLCM.Location = new System.Drawing.Point(43, 2);
            this.lblSLCM.Name = "lblSLCM";
            this.lblSLCM.Size = new System.Drawing.Size(114, 50);
            this.lblSLCM.TabIndex = 10;
            this.lblSLCM.Text = "SLCM";
            this.lblSLCM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLtd
            // 
            this.lblLtd.AutoSize = true;
            this.lblLtd.BackColor = System.Drawing.Color.Transparent;
            this.lblLtd.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLtd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLtd.Location = new System.Drawing.Point(151, 15);
            this.lblLtd.Name = "lblLtd";
            this.lblLtd.Size = new System.Drawing.Size(53, 32);
            this.lblLtd.TabIndex = 11;
            this.lblLtd.Text = ".Ltd";
            this.lblLtd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(50, 251);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(239, 21);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Username and Passwod is wrong";
            this.lblError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(386, 491);
            this.Controls.Add(this.plLogin);
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.plLogin.ResumeLayout(false);
            this.plLogin.PerformLayout();
            this.plLoginbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccountBlack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plLogin;
        private MaterialSkin.Controls.MaterialFlatButton btnSubmit;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAccount;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private System.Windows.Forms.PictureBox picAccount;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.PictureBox picAccountBlack;
        private System.Windows.Forms.PictureBox picPasswordBlack;
        private System.Windows.Forms.Panel plLoginbtn;
        private System.Windows.Forms.Label lblSLCM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIntr;
        private System.Windows.Forms.Label lblLtd;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private System.Windows.Forms.Label lblError;
    }
}

