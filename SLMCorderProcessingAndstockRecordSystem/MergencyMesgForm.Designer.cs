namespace WindowsFormsApplication1
{
    partial class MergencyMesgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergencyMesgForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtmergDes = new System.Windows.Forms.TextBox();
            this.btnMesSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblfont = new MaterialSkin.Controls.MaterialLabel();
            this.txtTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtmergDes);
            this.bunifuGradientPanel1.Controls.Add(this.btnMesSubmit);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancel);
            this.bunifuGradientPanel1.Controls.Add(this.lblfont);
            this.bunifuGradientPanel1.Controls.Add(this.txtTitle);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(10, 89);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(784, 569);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // txtmergDes
            // 
            this.txtmergDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmergDes.Location = new System.Drawing.Point(19, 138);
            this.txtmergDes.Multiline = true;
            this.txtmergDes.Name = "txtmergDes";
            this.txtmergDes.Size = new System.Drawing.Size(746, 342);
            this.txtmergDes.TabIndex = 28;
            // 
            // btnMesSubmit
            // 
            this.btnMesSubmit.AutoSize = true;
            this.btnMesSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesSubmit.Depth = 0;
            this.btnMesSubmit.Location = new System.Drawing.Point(658, 498);
            this.btnMesSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMesSubmit.Name = "btnMesSubmit";
            this.btnMesSubmit.Primary = true;
            this.btnMesSubmit.Size = new System.Drawing.Size(96, 35);
            this.btnMesSubmit.TabIndex = 27;
            this.btnMesSubmit.Text = "submit";
            this.btnMesSubmit.UseVisualStyleBackColor = true;
            this.btnMesSubmit.Click += new System.EventHandler(this.btnMesSubmit_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(39, 498);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(96, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblfont
            // 
            this.lblfont.AutoSize = true;
            this.lblfont.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfont.Depth = 0;
            this.lblfont.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblfont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblfont.Location = new System.Drawing.Point(15, 114);
            this.lblfont.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblfont.Name = "lblfont";
            this.lblfont.Size = new System.Drawing.Size(43, 19);
            this.lblfont.TabIndex = 23;
            this.lblfont.Text = "Font:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTitle.Depth = 0;
            this.txtTitle.Hint = "Title";
            this.txtTitle.Location = new System.Drawing.Point(19, 74);
            this.txtTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.Size = new System.Drawing.Size(746, 23);
            this.txtTitle.TabIndex = 22;
            this.txtTitle.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 613);
            this.panel1.TabIndex = 2;
            // 
            // MergencyMesgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 681);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "MergencyMesgForm";
            this.Text = "Mergency Mesg Form";
            this.Load += new System.EventHandler(this.MergencyMesgForm_Load_1);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnMesSubmit;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblfont;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtmergDes;
    }
}