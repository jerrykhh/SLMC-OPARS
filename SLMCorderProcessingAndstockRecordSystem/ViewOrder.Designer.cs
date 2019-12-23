namespace WindowsFormsApplication1
{
    partial class ViewOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pldgOrderDetail = new System.Windows.Forms.Panel();
            this.dgOrderDetial = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtCity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPostcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lblCity = new MaterialSkin.Controls.MaterialLabel();
            this.lblPostcode = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContactNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContactName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDealerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDealerNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblConNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblConNam = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeaNam = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeaNo = new MaterialSkin.Controls.MaterialLabel();
            this.plSalesOrderTitle = new System.Windows.Forms.Panel();
            this.btnEditmode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pldgOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetial)).BeginInit();
            this.plSalesOrderTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.plSalesOrderTitle);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 639);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.pldgOrderDetail);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.txtPostcode);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblCity);
            this.panel2.Controls.Add(this.lblPostcode);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtContactNumber);
            this.panel2.Controls.Add(this.txtContactName);
            this.panel2.Controls.Add(this.txtDealerName);
            this.panel2.Controls.Add(this.txtDealerNumber);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblConNo);
            this.panel2.Controls.Add(this.lblConNam);
            this.panel2.Controls.Add(this.lblDeaNam);
            this.panel2.Controls.Add(this.lblDeaNo);
            this.panel2.Location = new System.Drawing.Point(10, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 541);
            this.panel2.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Depth = 0;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(463, 140);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 19);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "Status:";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(38, 484);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(146, 39);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(190, 484);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(59, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pldgOrderDetail
            // 
            this.pldgOrderDetail.Controls.Add(this.dgOrderDetial);
            this.pldgOrderDetail.Location = new System.Drawing.Point(37, 216);
            this.pldgOrderDetail.Name = "pldgOrderDetail";
            this.pldgOrderDetail.Size = new System.Drawing.Size(822, 247);
            this.pldgOrderDetail.TabIndex = 40;
            this.pldgOrderDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgOrderDetail_Paint);
            // 
            // dgOrderDetial
            // 
            this.dgOrderDetial.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgOrderDetial.AllowUserToResizeColumns = false;
            this.dgOrderDetial.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrderDetial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrderDetial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrderDetial.BackgroundColor = System.Drawing.Color.White;
            this.dgOrderDetial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOrderDetial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgOrderDetial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderDetial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrderDetial.ColumnHeadersHeight = 40;
            this.dgOrderDetial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgOrderDetial.DoubleBuffered = true;
            this.dgOrderDetial.EnableHeadersVisualStyles = false;
            this.dgOrderDetial.GridColor = System.Drawing.Color.White;
            this.dgOrderDetial.HeaderBgColor = System.Drawing.Color.White;
            this.dgOrderDetial.HeaderForeColor = System.Drawing.Color.Black;
            this.dgOrderDetial.Location = new System.Drawing.Point(3, 3);
            this.dgOrderDetial.MultiSelect = false;
            this.dgOrderDetial.Name = "dgOrderDetial";
            this.dgOrderDetial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrderDetial.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgOrderDetial.RowHeadersVisible = false;
            this.dgOrderDetial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOrderDetial.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgOrderDetial.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgOrderDetial.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgOrderDetial.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgOrderDetial.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrderDetial.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgOrderDetial.RowTemplate.DividerHeight = 1;
            this.dgOrderDetial.RowTemplate.Height = 30;
            this.dgOrderDetial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgOrderDetial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrderDetial.Size = new System.Drawing.Size(816, 241);
            this.dgOrderDetial.TabIndex = 44;
            this.dgOrderDetial.DoubleClick += new System.EventHandler(this.dgOrderDetial_DoubleClick);
            // 
            // txtCity
            // 
            this.txtCity.Depth = 0;
            this.txtCity.Enabled = false;
            this.txtCity.Hint = "";
            this.txtCity.Location = new System.Drawing.Point(535, 47);
            this.txtCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.SelectedText = "";
            this.txtCity.SelectionLength = 0;
            this.txtCity.SelectionStart = 0;
            this.txtCity.Size = new System.Drawing.Size(91, 23);
            this.txtCity.TabIndex = 39;
            this.txtCity.UseSystemPasswordChar = false;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Depth = 0;
            this.txtPostcode.Enabled = false;
            this.txtPostcode.Hint = "";
            this.txtPostcode.Location = new System.Drawing.Point(535, 76);
            this.txtPostcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.PasswordChar = '\0';
            this.txtPostcode.SelectedText = "";
            this.txtPostcode.SelectionLength = 0;
            this.txtPostcode.SelectionStart = 0;
            this.txtPostcode.Size = new System.Drawing.Size(91, 23);
            this.txtPostcode.TabIndex = 38;
            this.txtPostcode.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Depth = 0;
            this.txtAddress.Enabled = false;
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(576, 103);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(283, 23);
            this.txtAddress.TabIndex = 37;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(451, 106);
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
            this.lblCity.Location = new System.Drawing.Point(487, 46);
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
            this.lblPostcode.Location = new System.Drawing.Point(452, 76);
            this.lblPostcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(77, 19);
            this.lblPostcode.TabIndex = 34;
            this.lblPostcode.Text = "Postcode:";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Enabled = false;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(159, 163);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(209, 23);
            this.txtEmail.TabIndex = 33;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Depth = 0;
            this.txtContactNumber.Enabled = false;
            this.txtContactNumber.Hint = "";
            this.txtContactNumber.Location = new System.Drawing.Point(159, 132);
            this.txtContactNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.PasswordChar = '\0';
            this.txtContactNumber.SelectedText = "";
            this.txtContactNumber.SelectionLength = 0;
            this.txtContactNumber.SelectionStart = 0;
            this.txtContactNumber.Size = new System.Drawing.Size(169, 23);
            this.txtContactNumber.TabIndex = 32;
            this.txtContactNumber.UseSystemPasswordChar = false;
            // 
            // txtContactName
            // 
            this.txtContactName.Depth = 0;
            this.txtContactName.Enabled = false;
            this.txtContactName.Hint = "";
            this.txtContactName.Location = new System.Drawing.Point(159, 103);
            this.txtContactName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.PasswordChar = '\0';
            this.txtContactName.SelectedText = "";
            this.txtContactName.SelectionLength = 0;
            this.txtContactName.SelectionStart = 0;
            this.txtContactName.Size = new System.Drawing.Size(210, 23);
            this.txtContactName.TabIndex = 31;
            this.txtContactName.UseSystemPasswordChar = false;
            // 
            // txtDealerName
            // 
            this.txtDealerName.Depth = 0;
            this.txtDealerName.Enabled = false;
            this.txtDealerName.Hint = "";
            this.txtDealerName.Location = new System.Drawing.Point(158, 69);
            this.txtDealerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.PasswordChar = '\0';
            this.txtDealerName.SelectedText = "";
            this.txtDealerName.SelectionLength = 0;
            this.txtDealerName.SelectionStart = 0;
            this.txtDealerName.Size = new System.Drawing.Size(210, 23);
            this.txtDealerName.TabIndex = 30;
            this.txtDealerName.UseSystemPasswordChar = false;
            // 
            // txtDealerNumber
            // 
            this.txtDealerNumber.Depth = 0;
            this.txtDealerNumber.Enabled = false;
            this.txtDealerNumber.Hint = "";
            this.txtDealerNumber.Location = new System.Drawing.Point(158, 32);
            this.txtDealerNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDealerNumber.Name = "txtDealerNumber";
            this.txtDealerNumber.PasswordChar = '\0';
            this.txtDealerNumber.SelectedText = "";
            this.txtDealerNumber.SelectionLength = 0;
            this.txtDealerNumber.SelectionStart = 0;
            this.txtDealerNumber.Size = new System.Drawing.Size(210, 23);
            this.txtDealerNumber.TabIndex = 29;
            this.txtDealerNumber.TabStop = false;
            this.txtDealerNumber.UseSystemPasswordChar = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(34, 165);
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
            this.lblConNo.Location = new System.Drawing.Point(33, 134);
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
            this.lblConNam.Location = new System.Drawing.Point(33, 101);
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
            this.lblDeaNam.Location = new System.Drawing.Point(33, 68);
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
            this.lblDeaNo.Location = new System.Drawing.Point(33, 35);
            this.lblDeaNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeaNo.Name = "lblDeaNo";
            this.lblDeaNo.Size = new System.Drawing.Size(110, 19);
            this.lblDeaNo.TabIndex = 24;
            this.lblDeaNo.Text = "Dealer number:";
            // 
            // plSalesOrderTitle
            // 
            this.plSalesOrderTitle.BackColor = System.Drawing.Color.White;
            this.plSalesOrderTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSalesOrderTitle.Controls.Add(this.btnEditmode);
            this.plSalesOrderTitle.Controls.Add(this.lblSalesOrder);
            this.plSalesOrderTitle.Location = new System.Drawing.Point(10, 16);
            this.plSalesOrderTitle.Name = "plSalesOrderTitle";
            this.plSalesOrderTitle.Size = new System.Drawing.Size(895, 56);
            this.plSalesOrderTitle.TabIndex = 0;
            // 
            // btnEditmode
            // 
            this.btnEditmode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditmode.Depth = 0;
            this.btnEditmode.Location = new System.Drawing.Point(751, 8);
            this.btnEditmode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditmode.Name = "btnEditmode";
            this.btnEditmode.Primary = true;
            this.btnEditmode.Size = new System.Drawing.Size(119, 39);
            this.btnEditmode.TabIndex = 1;
            this.btnEditmode.Text = "Edit Mode";
            this.btnEditmode.UseVisualStyleBackColor = true;
            this.btnEditmode.Click += new System.EventHandler(this.btnEditmode_Click);
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrder.Location = new System.Drawing.Point(16, 6);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(188, 40);
            this.lblSalesOrder.TabIndex = 0;
            this.lblSalesOrder.Text = "Sales Order #";
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Location = new System.Drawing.Point(525, 139);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(200, 20);
            this.txtStatus.TabIndex = 44;
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 705);
            this.Controls.Add(this.panel1);
            this.Name = "ViewOrder";
            this.Text = "ViewOrder";
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pldgOrderDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetial)).EndInit();
            this.plSalesOrderTitle.ResumeLayout(false);
            this.plSalesOrderTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plSalesOrderTitle;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPostcode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lblCity;
        private MaterialSkin.Controls.MaterialLabel lblPostcode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContactNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContactName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDealerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDealerNumber;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblConNo;
        private MaterialSkin.Controls.MaterialLabel lblConNam;
        private MaterialSkin.Controls.MaterialLabel lblDeaNam;
        private MaterialSkin.Controls.MaterialLabel lblDeaNo;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.Panel pldgOrderDetail;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditmode;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgOrderDetial;
        private System.Windows.Forms.ComboBox txtStatus;
    }
}