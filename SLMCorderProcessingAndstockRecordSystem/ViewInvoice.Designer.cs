namespace WindowsFormsApplication1
{
    partial class ViewInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInvoice));
            this.lblInvoice = new System.Windows.Forms.Label();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pldgOrderDetail = new System.Windows.Forms.Panel();
            this.dgInvoice = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.plSalesOrderTitle = new System.Windows.Forms.Panel();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lblCity = new MaterialSkin.Controls.MaterialLabel();
            this.lblPostcode = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDataAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDataDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSalesOrderNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataPostcode = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataCity = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataContactNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataContactName = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataDealerName = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataDealerNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblConNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblConNam = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeaNam = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeaNo = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pldgOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            this.plSalesOrderTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(13, 8);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(140, 40);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Invoice # ";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(35, 478);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(146, 39);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pldgOrderDetail
            // 
            this.pldgOrderDetail.Controls.Add(this.dgInvoice);
            this.pldgOrderDetail.Location = new System.Drawing.Point(34, 210);
            this.pldgOrderDetail.Name = "pldgOrderDetail";
            this.pldgOrderDetail.Size = new System.Drawing.Size(822, 247);
            this.pldgOrderDetail.TabIndex = 40;
            this.pldgOrderDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.PldgOrderDetail_Paint);
            // 
            // dgInvoice
            // 
            this.dgInvoice.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgInvoice.AllowUserToAddRows = false;
            this.dgInvoice.AllowUserToDeleteRows = false;
            this.dgInvoice.AllowUserToResizeColumns = false;
            this.dgInvoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgInvoice.ColumnHeadersHeight = 40;
            this.dgInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgInvoice.DoubleBuffered = true;
            this.dgInvoice.Enabled = false;
            this.dgInvoice.EnableHeadersVisualStyles = false;
            this.dgInvoice.GridColor = System.Drawing.Color.White;
            this.dgInvoice.HeaderBgColor = System.Drawing.Color.White;
            this.dgInvoice.HeaderForeColor = System.Drawing.Color.Black;
            this.dgInvoice.Location = new System.Drawing.Point(3, 3);
            this.dgInvoice.MultiSelect = false;
            this.dgInvoice.Name = "dgInvoice";
            this.dgInvoice.ReadOnly = true;
            this.dgInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgInvoice.RowHeadersVisible = false;
            this.dgInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgInvoice.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgInvoice.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgInvoice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInvoice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgInvoice.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgInvoice.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgInvoice.RowTemplate.DividerHeight = 1;
            this.dgInvoice.RowTemplate.Height = 30;
            this.dgInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInvoice.Size = new System.Drawing.Size(816, 240);
            this.dgInvoice.TabIndex = 6;
            // 
            // plSalesOrderTitle
            // 
            this.plSalesOrderTitle.BackColor = System.Drawing.Color.White;
            this.plSalesOrderTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSalesOrderTitle.Controls.Add(this.lblInvoice);
            this.plSalesOrderTitle.Location = new System.Drawing.Point(9, 10);
            this.plSalesOrderTitle.Name = "plSalesOrderTitle";
            this.plSalesOrderTitle.Size = new System.Drawing.Size(895, 56);
            this.plSalesOrderTitle.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(448, 93);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(112, 19);
            this.lblAddress.TabIndex = 36;
            this.lblAddress.Text = "Street Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Depth = 0;
            this.lblCity.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCity.Location = new System.Drawing.Point(484, 33);
            this.lblCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 19);
            this.lblCity.TabIndex = 35;
            this.lblCity.Text = "City:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Depth = 0;
            this.lblPostcode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPostcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPostcode.Location = new System.Drawing.Point(449, 63);
            this.lblPostcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(77, 19);
            this.lblPostcode.TabIndex = 34;
            this.lblPostcode.Text = "Postcode:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.lblDataAddress);
            this.panel2.Controls.Add(this.lblDataDate);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.lblSalesOrderNo);
            this.panel2.Controls.Add(this.lblDataPostcode);
            this.panel2.Controls.Add(this.lblDataCity);
            this.panel2.Controls.Add(this.lblDataEmail);
            this.panel2.Controls.Add(this.lblDataContactNo);
            this.panel2.Controls.Add(this.lblDataContactName);
            this.panel2.Controls.Add(this.lblDataDealerName);
            this.panel2.Controls.Add(this.lblDataDealerNo);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.pldgOrderDetail);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblCity);
            this.panel2.Controls.Add(this.lblPostcode);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblConNo);
            this.panel2.Controls.Add(this.lblConNam);
            this.panel2.Controls.Add(this.lblDeaNam);
            this.panel2.Controls.Add(this.lblDeaNo);
            this.panel2.Location = new System.Drawing.Point(7, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 541);
            this.panel2.TabIndex = 1;
            // 
            // lblDataAddress
            // 
            this.lblDataAddress.Depth = 0;
            this.lblDataAddress.Hint = "";
            this.lblDataAddress.Location = new System.Drawing.Point(568, 93);
            this.lblDataAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataAddress.Name = "lblDataAddress";
            this.lblDataAddress.PasswordChar = '\0';
            this.lblDataAddress.SelectedText = "";
            this.lblDataAddress.SelectionLength = 0;
            this.lblDataAddress.SelectionStart = 0;
            this.lblDataAddress.Size = new System.Drawing.Size(269, 23);
            this.lblDataAddress.TabIndex = 53;
            this.lblDataAddress.Text = "lblDataAddress";
            this.lblDataAddress.UseSystemPasswordChar = false;
            // 
            // lblDataDate
            // 
            this.lblDataDate.AutoSize = true;
            this.lblDataDate.Depth = 0;
            this.lblDataDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataDate.Location = new System.Drawing.Point(554, 121);
            this.lblDataDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataDate.Name = "lblDataDate";
            this.lblDataDate.Size = new System.Drawing.Size(87, 19);
            this.lblDataDate.TabIndex = 52;
            this.lblDataDate.Text = "lblDataDate";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(452, 121);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 19);
            this.materialLabel1.TabIndex = 51;
            this.materialLabel1.Text = "pickup Date: ";
            // 
            // lblSalesOrderNo
            // 
            this.lblSalesOrderNo.AutoSize = true;
            this.lblSalesOrderNo.Depth = 0;
            this.lblSalesOrderNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSalesOrderNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalesOrderNo.Location = new System.Drawing.Point(449, 152);
            this.lblSalesOrderNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalesOrderNo.Name = "lblSalesOrderNo";
            this.lblSalesOrderNo.Size = new System.Drawing.Size(99, 19);
            this.lblSalesOrderNo.TabIndex = 50;
            this.lblSalesOrderNo.Text = "Sales Order #";
            // 
            // lblDataPostcode
            // 
            this.lblDataPostcode.AutoSize = true;
            this.lblDataPostcode.Depth = 0;
            this.lblDataPostcode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataPostcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataPostcode.Location = new System.Drawing.Point(536, 64);
            this.lblDataPostcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataPostcode.Name = "lblDataPostcode";
            this.lblDataPostcode.Size = new System.Drawing.Size(120, 19);
            this.lblDataPostcode.TabIndex = 48;
            this.lblDataPostcode.Text = "lblDataPostcode";
            // 
            // lblDataCity
            // 
            this.lblDataCity.AutoSize = true;
            this.lblDataCity.Depth = 0;
            this.lblDataCity.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataCity.Location = new System.Drawing.Point(538, 33);
            this.lblDataCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataCity.Name = "lblDataCity";
            this.lblDataCity.Size = new System.Drawing.Size(82, 19);
            this.lblDataCity.TabIndex = 47;
            this.lblDataCity.Text = "lblDataCity";
            // 
            // lblDataEmail
            // 
            this.lblDataEmail.AutoSize = true;
            this.lblDataEmail.Depth = 0;
            this.lblDataEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataEmail.Location = new System.Drawing.Point(149, 159);
            this.lblDataEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataEmail.Name = "lblDataEmail";
            this.lblDataEmail.Size = new System.Drawing.Size(94, 19);
            this.lblDataEmail.TabIndex = 46;
            this.lblDataEmail.Text = "lblDataEmail";
            // 
            // lblDataContactNo
            // 
            this.lblDataContactNo.AutoSize = true;
            this.lblDataContactNo.Depth = 0;
            this.lblDataContactNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataContactNo.Location = new System.Drawing.Point(156, 128);
            this.lblDataContactNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataContactNo.Name = "lblDataContactNo";
            this.lblDataContactNo.Size = new System.Drawing.Size(129, 19);
            this.lblDataContactNo.TabIndex = 45;
            this.lblDataContactNo.Text = "lblDataContactNo";
            // 
            // lblDataContactName
            // 
            this.lblDataContactName.AutoSize = true;
            this.lblDataContactName.Depth = 0;
            this.lblDataContactName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataContactName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataContactName.Location = new System.Drawing.Point(143, 95);
            this.lblDataContactName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataContactName.Name = "lblDataContactName";
            this.lblDataContactName.Size = new System.Drawing.Size(149, 19);
            this.lblDataContactName.TabIndex = 44;
            this.lblDataContactName.Text = "lblDataContactName";
            // 
            // lblDataDealerName
            // 
            this.lblDataDealerName.AutoSize = true;
            this.lblDataDealerName.Depth = 0;
            this.lblDataDealerName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataDealerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataDealerName.Location = new System.Drawing.Point(133, 62);
            this.lblDataDealerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataDealerName.Name = "lblDataDealerName";
            this.lblDataDealerName.Size = new System.Drawing.Size(139, 19);
            this.lblDataDealerName.TabIndex = 43;
            this.lblDataDealerName.Text = "lblDataDealerName";
            // 
            // lblDataDealerNo
            // 
            this.lblDataDealerNo.AutoSize = true;
            this.lblDataDealerNo.Depth = 0;
            this.lblDataDealerNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataDealerNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataDealerNo.Location = new System.Drawing.Point(146, 29);
            this.lblDataDealerNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataDealerNo.Name = "lblDataDealerNo";
            this.lblDataDealerNo.Size = new System.Drawing.Size(119, 19);
            this.lblDataDealerNo.TabIndex = 42;
            this.lblDataDealerNo.Text = "lblDataDealerNo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(31, 159);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 19);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblConNo
            // 
            this.lblConNo.AutoSize = true;
            this.lblConNo.Depth = 0;
            this.lblConNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConNo.Location = new System.Drawing.Point(30, 128);
            this.lblConNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(120, 19);
            this.lblConNo.TabIndex = 27;
            this.lblConNo.Text = "Contact number:";
            // 
            // lblConNam
            // 
            this.lblConNam.AutoSize = true;
            this.lblConNam.Depth = 0;
            this.lblConNam.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConNam.Location = new System.Drawing.Point(30, 95);
            this.lblConNam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConNam.Name = "lblConNam";
            this.lblConNam.Size = new System.Drawing.Size(107, 19);
            this.lblConNam.TabIndex = 26;
            this.lblConNam.Text = "Contact name:";
            // 
            // lblDeaNam
            // 
            this.lblDeaNam.AutoSize = true;
            this.lblDeaNam.Depth = 0;
            this.lblDeaNam.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDeaNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeaNam.Location = new System.Drawing.Point(30, 62);
            this.lblDeaNam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeaNam.Name = "lblDeaNam";
            this.lblDeaNam.Size = new System.Drawing.Size(97, 19);
            this.lblDeaNam.TabIndex = 25;
            this.lblDeaNam.Text = "Dealer name:";
            // 
            // lblDeaNo
            // 
            this.lblDeaNo.AutoSize = true;
            this.lblDeaNo.Depth = 0;
            this.lblDeaNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDeaNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeaNo.Location = new System.Drawing.Point(30, 29);
            this.lblDeaNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeaNo.Name = "lblDeaNo";
            this.lblDeaNo.Size = new System.Drawing.Size(110, 19);
            this.lblDeaNo.TabIndex = 24;
            this.lblDeaNo.Text = "Dealer number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.plSalesOrderTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 641);
            this.panel1.TabIndex = 1;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Depth = 0;
            this.btnPrint.Location = new System.Drawing.Point(737, 478);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Primary = true;
            this.btnPrint.Size = new System.Drawing.Size(116, 39);
            this.btnPrint.TabIndex = 54;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 705);
            this.Controls.Add(this.panel1);
            this.Name = "ViewInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewInvoice";
            this.Load += new System.EventHandler(this.ViewInvoice_Load);
            this.Shown += new System.EventHandler(this.ViewInvoice_Shown);
            this.pldgOrderDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            this.plSalesOrderTitle.ResumeLayout(false);
            this.plSalesOrderTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInvoice;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private System.Windows.Forms.Panel pldgOrderDetail;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgInvoice;
        private System.Windows.Forms.Panel plSalesOrderTitle;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lblCity;
        private MaterialSkin.Controls.MaterialLabel lblPostcode;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblConNo;
        private MaterialSkin.Controls.MaterialLabel lblConNam;
        private MaterialSkin.Controls.MaterialLabel lblDeaNam;
        private MaterialSkin.Controls.MaterialLabel lblDeaNo;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblDataPostcode;
        private MaterialSkin.Controls.MaterialLabel lblDataCity;
        private MaterialSkin.Controls.MaterialLabel lblDataEmail;
        private MaterialSkin.Controls.MaterialLabel lblDataContactNo;
        private MaterialSkin.Controls.MaterialLabel lblDataContactName;
        private MaterialSkin.Controls.MaterialLabel lblDataDealerName;
        private MaterialSkin.Controls.MaterialLabel lblDataDealerNo;
        private MaterialSkin.Controls.MaterialLabel lblSalesOrderNo;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblDataAddress;
        private MaterialSkin.Controls.MaterialLabel lblDataDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MaterialSkin.Controls.MaterialRaisedButton btnPrint;
    }
}