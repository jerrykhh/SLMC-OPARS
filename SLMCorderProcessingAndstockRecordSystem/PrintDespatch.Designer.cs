namespace WindowsFormsApplication1
{
    partial class PrintDespatch
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
            this.lblIntr = new System.Windows.Forms.Label();
            this.lblSLCM = new System.Windows.Forms.Label();
            this.lblLtd = new System.Windows.Forms.Label();
            this.lblDespatchInstruction = new MaterialSkin.Controls.MaterialLabel();
            this.lblOrderID = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeliveryID = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeliveryDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblInvoiceID = new MaterialSkin.Controls.MaterialLabel();
            this.lblPickUpDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblDealerID = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtOrderID = new MaterialSkin.Controls.MaterialLabel();
            this.txtDealerID = new MaterialSkin.Controls.MaterialLabel();
            this.txtInvoiceID = new MaterialSkin.Controls.MaterialLabel();
            this.txtPickUpDate = new MaterialSkin.Controls.MaterialLabel();
            this.txtDeliveryID = new MaterialSkin.Controls.MaterialLabel();
            this.txtDeliveryDate = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntr
            // 
            this.lblIntr.AutoSize = true;
            this.lblIntr.BackColor = System.Drawing.Color.Transparent;
            this.lblIntr.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIntr.Location = new System.Drawing.Point(743, 177);
            this.lblIntr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntr.Name = "lblIntr";
            this.lblIntr.Size = new System.Drawing.Size(292, 20);
            this.lblIntr.TabIndex = 15;
            this.lblIntr.Text = "Order Processing and Stock Record System";
            // 
            // lblSLCM
            // 
            this.lblSLCM.AutoSize = true;
            this.lblSLCM.BackColor = System.Drawing.Color.Transparent;
            this.lblSLCM.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLCM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSLCM.Location = new System.Drawing.Point(785, 119);
            this.lblSLCM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSLCM.Name = "lblSLCM";
            this.lblSLCM.Size = new System.Drawing.Size(143, 62);
            this.lblSLCM.TabIndex = 13;
            this.lblSLCM.Text = "SLCM";
            this.lblSLCM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLtd
            // 
            this.lblLtd.AutoSize = true;
            this.lblLtd.BackColor = System.Drawing.Color.Transparent;
            this.lblLtd.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLtd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLtd.Location = new System.Drawing.Point(929, 135);
            this.lblLtd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLtd.Name = "lblLtd";
            this.lblLtd.Size = new System.Drawing.Size(67, 41);
            this.lblLtd.TabIndex = 14;
            this.lblLtd.Text = ".Ltd";
            this.lblLtd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDespatchInstruction
            // 
            this.lblDespatchInstruction.AutoSize = true;
            this.lblDespatchInstruction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDespatchInstruction.Depth = 0;
            this.lblDespatchInstruction.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespatchInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDespatchInstruction.Location = new System.Drawing.Point(61, 161);
            this.lblDespatchInstruction.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDespatchInstruction.Name = "lblDespatchInstruction";
            this.lblDespatchInstruction.Size = new System.Drawing.Size(332, 42);
            this.lblDespatchInstruction.TabIndex = 16;
            this.lblDespatchInstruction.Text = "Despatch Instruction";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrderID.Depth = 0;
            this.lblOrderID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrderID.Location = new System.Drawing.Point(64, 241);
            this.lblOrderID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(83, 24);
            this.lblOrderID.TabIndex = 17;
            this.lblOrderID.Text = "OrderID: ";
            // 
            // lblDeliveryID
            // 
            this.lblDeliveryID.AutoSize = true;
            this.lblDeliveryID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeliveryID.Depth = 0;
            this.lblDeliveryID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDeliveryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeliveryID.Location = new System.Drawing.Point(64, 404);
            this.lblDeliveryID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeliveryID.Name = "lblDeliveryID";
            this.lblDeliveryID.Size = new System.Drawing.Size(103, 24);
            this.lblDeliveryID.TabIndex = 18;
            this.lblDeliveryID.Text = "DeliveryID: ";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeliveryDate.Depth = 0;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDeliveryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeliveryDate.Location = new System.Drawing.Point(505, 407);
            this.lblDeliveryDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(119, 24);
            this.lblDeliveryDate.TabIndex = 19;
            this.lblDeliveryDate.Text = "DeliveryDate:";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInvoiceID.Depth = 0;
            this.lblInvoiceID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInvoiceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvoiceID.Location = new System.Drawing.Point(64, 321);
            this.lblInvoiceID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(92, 24);
            this.lblInvoiceID.TabIndex = 20;
            this.lblInvoiceID.Text = "InvoiceID:";
            // 
            // lblPickUpDate
            // 
            this.lblPickUpDate.AutoSize = true;
            this.lblPickUpDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPickUpDate.Depth = 0;
            this.lblPickUpDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPickUpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPickUpDate.Location = new System.Drawing.Point(505, 324);
            this.lblPickUpDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPickUpDate.Name = "lblPickUpDate";
            this.lblPickUpDate.Size = new System.Drawing.Size(113, 24);
            this.lblPickUpDate.TabIndex = 21;
            this.lblPickUpDate.Text = "PickUpDate:";
            // 
            // lblDealerID
            // 
            this.lblDealerID.AutoSize = true;
            this.lblDealerID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDealerID.Depth = 0;
            this.lblDealerID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDealerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDealerID.Location = new System.Drawing.Point(505, 244);
            this.lblDealerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDealerID.Name = "lblDealerID";
            this.lblDealerID.Size = new System.Drawing.Size(90, 24);
            this.lblDealerID.TabIndex = 22;
            this.lblDealerID.Text = "DealerID: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 577);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.txtDeliveryDate);
            this.panel2.Controls.Add(this.txtDeliveryID);
            this.panel2.Controls.Add(this.txtPickUpDate);
            this.panel2.Controls.Add(this.txtInvoiceID);
            this.panel2.Controls.Add(this.txtDealerID);
            this.panel2.Controls.Add(this.txtOrderID);
            this.panel2.Location = new System.Drawing.Point(11, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 455);
            this.panel2.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Depth = 0;
            this.btnPrint.Location = new System.Drawing.Point(765, 509);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Primary = true;
            this.btnPrint.Size = new System.Drawing.Size(104, 36);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(930, 509);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(104, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.AutoSize = true;
            this.txtOrderID.Depth = 0;
            this.txtOrderID.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOrderID.Location = new System.Drawing.Point(167, 156);
            this.txtOrderID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(94, 24);
            this.txtOrderID.TabIndex = 0;
            this.txtOrderID.Text = "txtOrderID";
            // 
            // txtDealerID
            // 
            this.txtDealerID.AutoSize = true;
            this.txtDealerID.Depth = 0;
            this.txtDealerID.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtDealerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDealerID.Location = new System.Drawing.Point(626, 159);
            this.txtDealerID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDealerID.Name = "txtDealerID";
            this.txtDealerID.Size = new System.Drawing.Size(101, 24);
            this.txtDealerID.TabIndex = 1;
            this.txtDealerID.Text = "txtDealerID";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.AutoSize = true;
            this.txtInvoiceID.Depth = 0;
            this.txtInvoiceID.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtInvoiceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtInvoiceID.Location = new System.Drawing.Point(167, 236);
            this.txtInvoiceID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(108, 24);
            this.txtInvoiceID.TabIndex = 2;
            this.txtInvoiceID.Text = "txtInvoiceID";
            // 
            // txtPickUpDate
            // 
            this.txtPickUpDate.AutoSize = true;
            this.txtPickUpDate.Depth = 0;
            this.txtPickUpDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtPickUpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPickUpDate.Location = new System.Drawing.Point(626, 239);
            this.txtPickUpDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPickUpDate.Name = "txtPickUpDate";
            this.txtPickUpDate.Size = new System.Drawing.Size(129, 24);
            this.txtPickUpDate.TabIndex = 3;
            this.txtPickUpDate.Text = "txtPickUpDate";
            // 
            // txtDeliveryID
            // 
            this.txtDeliveryID.AutoSize = true;
            this.txtDeliveryID.Depth = 0;
            this.txtDeliveryID.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtDeliveryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDeliveryID.Location = new System.Drawing.Point(167, 319);
            this.txtDeliveryID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDeliveryID.Name = "txtDeliveryID";
            this.txtDeliveryID.Size = new System.Drawing.Size(114, 24);
            this.txtDeliveryID.TabIndex = 4;
            this.txtDeliveryID.Text = "txtDeliveryID";
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.AutoSize = true;
            this.txtDeliveryDate.Depth = 0;
            this.txtDeliveryDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtDeliveryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDeliveryDate.Location = new System.Drawing.Point(626, 322);
            this.txtDeliveryDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(135, 24);
            this.txtDeliveryDate.TabIndex = 5;
            this.txtDeliveryDate.Text = "txtDeliveryDate";
            // 
            // PrintDespatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 640);
            this.Controls.Add(this.lblDealerID);
            this.Controls.Add(this.lblPickUpDate);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblDeliveryID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblDespatchInstruction);
            this.Controls.Add(this.lblIntr);
            this.Controls.Add(this.lblSLCM);
            this.Controls.Add(this.lblLtd);
            this.Controls.Add(this.panel1);
            this.Name = "PrintDespatch";
            this.Text = "PrintDespatch";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntr;
        private System.Windows.Forms.Label lblSLCM;
        private System.Windows.Forms.Label lblLtd;
        private MaterialSkin.Controls.MaterialLabel lblDespatchInstruction;
        private MaterialSkin.Controls.MaterialLabel lblOrderID;
        private MaterialSkin.Controls.MaterialLabel lblDeliveryID;
        private MaterialSkin.Controls.MaterialLabel lblDeliveryDate;
        private MaterialSkin.Controls.MaterialLabel lblInvoiceID;
        private MaterialSkin.Controls.MaterialLabel lblPickUpDate;
        private MaterialSkin.Controls.MaterialLabel lblDealerID;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnPrint;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel txtDeliveryDate;
        private MaterialSkin.Controls.MaterialLabel txtDeliveryID;
        private MaterialSkin.Controls.MaterialLabel txtPickUpDate;
        private MaterialSkin.Controls.MaterialLabel txtInvoiceID;
        private MaterialSkin.Controls.MaterialLabel txtDealerID;
        private MaterialSkin.Controls.MaterialLabel txtOrderID;
    }
}