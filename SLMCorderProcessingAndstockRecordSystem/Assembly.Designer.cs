namespace WindowsFormsApplication1
{
    partial class Assembly
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgAssmbly = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.btnInput = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblSalesOrderNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataPostcode = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataCity = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataContactNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataContactName = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataDealerName = new MaterialSkin.Controls.MaterialLabel();
            this.lblDataDealerNo = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pldgOrderDetail = new System.Windows.Forms.Panel();
            this.dgInvoice = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lblCity = new MaterialSkin.Controls.MaterialLabel();
            this.lblPostcode = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblConNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblConNam = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeaNam = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeaNo = new MaterialSkin.Controls.MaterialLabel();
            this.plSalesOrderTitle = new System.Windows.Forms.Panel();
            this.lblOrderAssembly = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAssmbly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.pldgOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            this.plSalesOrderTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 996);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtInput);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.picBarcode);
            this.panel2.Controls.Add(this.btnInput);
            this.panel2.Controls.Add(this.lblSalesOrderNo);
            this.panel2.Controls.Add(this.lblDataAddress);
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
            this.panel2.Location = new System.Drawing.Point(3, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 837);
            this.panel2.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(70, 246);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(215, 25);
            this.txtInput.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgAssmbly);
            this.panel3.Location = new System.Drawing.Point(34, 539);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 193);
            this.panel3.TabIndex = 41;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dgAssmbly
            // 
            this.dgAssmbly.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgAssmbly.AllowUserToAddRows = false;
            this.dgAssmbly.AllowUserToDeleteRows = false;
            this.dgAssmbly.AllowUserToResizeColumns = false;
            this.dgAssmbly.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgAssmbly.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAssmbly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAssmbly.BackgroundColor = System.Drawing.Color.White;
            this.dgAssmbly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAssmbly.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgAssmbly.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAssmbly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgAssmbly.ColumnHeadersHeight = 40;
            this.dgAssmbly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgAssmbly.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.actualQty,
            this.qtyOrdered});
            this.dgAssmbly.DoubleBuffered = true;
            this.dgAssmbly.EnableHeadersVisualStyles = false;
            this.dgAssmbly.GridColor = System.Drawing.Color.White;
            this.dgAssmbly.HeaderBgColor = System.Drawing.Color.White;
            this.dgAssmbly.HeaderForeColor = System.Drawing.Color.Black;
            this.dgAssmbly.Location = new System.Drawing.Point(3, 2);
            this.dgAssmbly.MultiSelect = false;
            this.dgAssmbly.Name = "dgAssmbly";
            this.dgAssmbly.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAssmbly.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAssmbly.RowHeadersVisible = false;
            this.dgAssmbly.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgAssmbly.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgAssmbly.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgAssmbly.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgAssmbly.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgAssmbly.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgAssmbly.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgAssmbly.RowTemplate.DividerHeight = 1;
            this.dgAssmbly.RowTemplate.Height = 30;
            this.dgAssmbly.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgAssmbly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAssmbly.Size = new System.Drawing.Size(816, 188);
            this.dgAssmbly.TabIndex = 6;
            this.dgAssmbly.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAssmbly_CellDoubleClick);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // actualQty
            // 
            this.actualQty.HeaderText = "actualQty";
            this.actualQty.Name = "actualQty";
            // 
            // qtyOrdered
            // 
            this.qtyOrdered.HeaderText = "qtyOrdered";
            this.qtyOrdered.Name = "qtyOrdered";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Location = new System.Drawing.Point(199, 767);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(86, 40);
            this.btnSubmit.TabIndex = 54;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // picBarcode
            // 
            this.picBarcode.Location = new System.Drawing.Point(488, 159);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(258, 119);
            this.picBarcode.TabIndex = 53;
            this.picBarcode.TabStop = false;
            // 
            // btnInput
            // 
            this.btnInput.Depth = 0;
            this.btnInput.Location = new System.Drawing.Point(299, 238);
            this.btnInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInput.Name = "btnInput";
            this.btnInput.Primary = true;
            this.btnInput.Size = new System.Drawing.Size(108, 40);
            this.btnInput.TabIndex = 52;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // lblSalesOrderNo
            // 
            this.lblSalesOrderNo.AutoSize = true;
            this.lblSalesOrderNo.Depth = 0;
            this.lblSalesOrderNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSalesOrderNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalesOrderNo.Location = new System.Drawing.Point(449, 120);
            this.lblSalesOrderNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalesOrderNo.Name = "lblSalesOrderNo";
            this.lblSalesOrderNo.Size = new System.Drawing.Size(99, 19);
            this.lblSalesOrderNo.TabIndex = 50;
            this.lblSalesOrderNo.Text = "Sales Order #";
            // 
            // lblDataAddress
            // 
            this.lblDataAddress.AutoSize = true;
            this.lblDataAddress.Depth = 0;
            this.lblDataAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataAddress.Location = new System.Drawing.Point(567, 93);
            this.lblDataAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataAddress.Name = "lblDataAddress";
            this.lblDataAddress.Size = new System.Drawing.Size(111, 19);
            this.lblDataAddress.TabIndex = 49;
            this.lblDataAddress.Text = "lblDataAddress";
            // 
            // lblDataPostcode
            // 
            this.lblDataPostcode.AutoSize = true;
            this.lblDataPostcode.Depth = 0;
            this.lblDataPostcode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDataPostcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataPostcode.Location = new System.Drawing.Point(536, 63);
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
            this.lblDataCity.Location = new System.Drawing.Point(538, 32);
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
            this.lblDataEmail.Location = new System.Drawing.Point(149, 151);
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
            this.lblDataContactNo.Location = new System.Drawing.Point(156, 120);
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
            this.lblDataContactName.Location = new System.Drawing.Point(143, 87);
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
            this.lblDataDealerName.Location = new System.Drawing.Point(133, 54);
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
            this.lblDataDealerNo.Location = new System.Drawing.Point(146, 21);
            this.lblDataDealerNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataDealerNo.Name = "lblDataDealerNo";
            this.lblDataDealerNo.Size = new System.Drawing.Size(119, 19);
            this.lblDataDealerNo.TabIndex = 42;
            this.lblDataDealerNo.Text = "lblDataDealerNo";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(35, 768);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(146, 39);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pldgOrderDetail
            // 
            this.pldgOrderDetail.Controls.Add(this.dgInvoice);
            this.pldgOrderDetail.Location = new System.Drawing.Point(34, 300);
            this.pldgOrderDetail.Name = "pldgOrderDetail";
            this.pldgOrderDetail.Size = new System.Drawing.Size(822, 196);
            this.pldgOrderDetail.TabIndex = 40;
            this.pldgOrderDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgOrderDetail_Paint);
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
            this.dgInvoice.Location = new System.Drawing.Point(3, 2);
            this.dgInvoice.MultiSelect = false;
            this.dgInvoice.Name = "dgInvoice";
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
            this.dgInvoice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInvoice.Size = new System.Drawing.Size(816, 189);
            this.dgInvoice.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(448, 92);
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
            this.lblCity.Location = new System.Drawing.Point(484, 32);
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
            this.lblPostcode.Location = new System.Drawing.Point(449, 62);
            this.lblPostcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(77, 19);
            this.lblPostcode.TabIndex = 34;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(31, 151);
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
            this.lblConNo.Location = new System.Drawing.Point(30, 120);
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
            this.lblConNam.Location = new System.Drawing.Point(30, 87);
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
            this.lblDeaNam.Location = new System.Drawing.Point(30, 54);
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
            this.lblDeaNo.Location = new System.Drawing.Point(30, 21);
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
            this.plSalesOrderTitle.Controls.Add(this.lblOrderAssembly);
            this.plSalesOrderTitle.Location = new System.Drawing.Point(3, 75);
            this.plSalesOrderTitle.Name = "plSalesOrderTitle";
            this.plSalesOrderTitle.Size = new System.Drawing.Size(904, 56);
            this.plSalesOrderTitle.TabIndex = 0;
            // 
            // lblOrderAssembly
            // 
            this.lblOrderAssembly.AutoSize = true;
            this.lblOrderAssembly.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderAssembly.Location = new System.Drawing.Point(13, 8);
            this.lblOrderAssembly.Name = "lblOrderAssembly";
            this.lblOrderAssembly.Size = new System.Drawing.Size(188, 40);
            this.lblOrderAssembly.TabIndex = 0;
            this.lblOrderAssembly.Text = "Sales Order #";
            // 
            // Assembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 980);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plSalesOrderTitle);
            this.Controls.Add(this.panel1);
            this.Name = "Assembly";
            this.Text = "Order Assembly";
            this.Load += new System.EventHandler(this.Assembly_Load);
            this.Shown += new System.EventHandler(this.Assembly_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAssmbly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.pldgOrderDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            this.plSalesOrderTitle.ResumeLayout(false);
            this.plSalesOrderTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBarcode;
        private MaterialSkin.Controls.MaterialRaisedButton btnInput;
        private MaterialSkin.Controls.MaterialLabel lblSalesOrderNo;
        private MaterialSkin.Controls.MaterialLabel lblDataAddress;
        private MaterialSkin.Controls.MaterialLabel lblDataPostcode;
        private MaterialSkin.Controls.MaterialLabel lblDataCity;
        private MaterialSkin.Controls.MaterialLabel lblDataEmail;
        private MaterialSkin.Controls.MaterialLabel lblDataContactNo;
        private MaterialSkin.Controls.MaterialLabel lblDataContactName;
        private MaterialSkin.Controls.MaterialLabel lblDataDealerName;
        private MaterialSkin.Controls.MaterialLabel lblDataDealerNo;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private System.Windows.Forms.Panel pldgOrderDetail;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgInvoice;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lblCity;
        private MaterialSkin.Controls.MaterialLabel lblPostcode;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblConNo;
        private MaterialSkin.Controls.MaterialLabel lblConNam;
        private MaterialSkin.Controls.MaterialLabel lblDeaNam;
        private MaterialSkin.Controls.MaterialLabel lblDeaNo;
        private System.Windows.Forms.Panel plSalesOrderTitle;
        private System.Windows.Forms.Label lblOrderAssembly;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgAssmbly;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyOrdered;
    }
}