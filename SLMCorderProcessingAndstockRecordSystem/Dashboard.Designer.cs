namespace WindowsFormsApplication1
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIntr = new System.Windows.Forms.Label();
            this.lblSLCM = new System.Windows.Forms.Label();
            this.lblLtd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalQtyOrdered = new System.Windows.Forms.TextBox();
            this.txtTotalNoOfOrders = new System.Windows.Forms.TextBox();
            this.lblTotalQtyDespatched = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalRevenue = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMes3 = new System.Windows.Forms.TextBox();
            this.lblMes2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMes = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblIntr);
            this.panel1.Controls.Add(this.lblSLCM);
            this.panel1.Controls.Add(this.lblLtd);
            this.panel1.Location = new System.Drawing.Point(2, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 183);
            this.panel1.TabIndex = 37;
            // 
            // lblIntr
            // 
            this.lblIntr.AutoSize = true;
            this.lblIntr.BackColor = System.Drawing.Color.Transparent;
            this.lblIntr.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIntr.Location = new System.Drawing.Point(224, 102);
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
            this.lblSLCM.Location = new System.Drawing.Point(256, 58);
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
            this.lblLtd.Location = new System.Drawing.Point(364, 70);
            this.lblLtd.Name = "lblLtd";
            this.lblLtd.Size = new System.Drawing.Size(53, 32);
            this.lblLtd.TabIndex = 11;
            this.lblLtd.Text = ".Ltd";
            this.lblLtd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1177, 386);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.txtTotalQtyOrdered);
            this.panel2.Controls.Add(this.txtTotalNoOfOrders);
            this.panel2.Controls.Add(this.lblTotalQtyDespatched);
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Location = new System.Drawing.Point(2, 391);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 93);
            this.panel2.TabIndex = 39;
            // 
            // txtTotalQtyOrdered
            // 
            this.txtTotalQtyOrdered.Enabled = false;
            this.txtTotalQtyOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQtyOrdered.Location = new System.Drawing.Point(282, 44);
            this.txtTotalQtyOrdered.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalQtyOrdered.Name = "txtTotalQtyOrdered";
            this.txtTotalQtyOrdered.Size = new System.Drawing.Size(201, 26);
            this.txtTotalQtyOrdered.TabIndex = 52;
            // 
            // txtTotalNoOfOrders
            // 
            this.txtTotalNoOfOrders.Enabled = false;
            this.txtTotalNoOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNoOfOrders.Location = new System.Drawing.Point(31, 44);
            this.txtTotalNoOfOrders.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalNoOfOrders.Name = "txtTotalNoOfOrders";
            this.txtTotalNoOfOrders.Size = new System.Drawing.Size(201, 26);
            this.txtTotalNoOfOrders.TabIndex = 51;
            // 
            // lblTotalQtyDespatched
            // 
            this.lblTotalQtyDespatched.AutoSize = true;
            this.lblTotalQtyDespatched.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalQtyDespatched.Depth = 0;
            this.lblTotalQtyDespatched.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalQtyDespatched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalQtyDespatched.Location = new System.Drawing.Point(279, 16);
            this.lblTotalQtyDespatched.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalQtyDespatched.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalQtyDespatched.Name = "lblTotalQtyDespatched";
            this.lblTotalQtyDespatched.Size = new System.Drawing.Size(186, 19);
            this.lblTotalQtyDespatched.TabIndex = 50;
            this.lblTotalQtyDespatched.Text = "Total Quantity Despatched";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalRevenue.Depth = 0;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(32, 16);
            this.lblTotalRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRevenue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(104, 19);
            this.lblTotalRevenue.TabIndex = 49;
            this.lblTotalRevenue.Text = "Total Revenue";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.txtMes3);
            this.panel3.Controls.Add(this.lblMes2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(727, 391);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 281);
            this.panel3.TabIndex = 40;
            // 
            // txtMes3
            // 
            this.txtMes3.Enabled = false;
            this.txtMes3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes3.Location = new System.Drawing.Point(71, 135);
            this.txtMes3.Multiline = true;
            this.txtMes3.Name = "txtMes3";
            this.txtMes3.Size = new System.Drawing.Size(302, 124);
            this.txtMes3.TabIndex = 53;
            // 
            // lblMes2
            // 
            this.lblMes2.AutoSize = true;
            this.lblMes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes2.Location = new System.Drawing.Point(28, 98);
            this.lblMes2.Name = "lblMes2";
            this.lblMes2.Size = new System.Drawing.Size(63, 20);
            this.lblMes2.TabIndex = 52;
            this.lblMes2.Text = "lblMes2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblMes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(439, 73);
            this.panel4.TabIndex = 46;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(104, 28);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(231, 29);
            this.lblMes.TabIndex = 51;
            this.lblMes.Text = "The Latest Message";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(4, 5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.Size = new System.Drawing.Size(1162, 380);
            this.chart1.TabIndex = 42;
            this.chart1.Text = "chart1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 684);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIntr;
        private System.Windows.Forms.Label lblSLCM;
        private System.Windows.Forms.Label lblLtd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotalQtyOrdered;
        private System.Windows.Forms.TextBox txtTotalNoOfOrders;
        private MaterialSkin.Controls.MaterialLabel lblTotalQtyDespatched;
        private MaterialSkin.Controls.MaterialLabel lblTotalRevenue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtMes3;
        private System.Windows.Forms.Label lblMes2;
        private System.Windows.Forms.Label lblMes;
    }
}