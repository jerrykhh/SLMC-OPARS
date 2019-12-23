namespace WindowsFormsApplication1
{
    partial class Orders
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkItemVal = new System.Windows.Forms.Label();
            this.chFormat = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chItem = new System.Windows.Forms.Label();
            this.chDelivery = new System.Windows.Forms.Label();
            this.chContactNo = new System.Windows.Forms.Label();
            this.chConactName = new System.Windows.Forms.Label();
            this.chDealerName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGrandTotal = new MaterialSkin.Controls.MaterialLabel();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.txtPostcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContactNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContactName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDealerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDealerNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.cbHold = new MaterialSkin.Controls.MaterialCheckBox();
            this.pldgSalesOrder = new System.Windows.Forms.Panel();
            this.dgOrder = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeliveryDeti = new MaterialSkin.Controls.MaterialLabel();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lblCity = new MaterialSkin.Controls.MaterialLabel();
            this.lblConNo = new MaterialSkin.Controls.MaterialLabel();
            this.lblPostcode = new MaterialSkin.Controls.MaterialLabel();
            this.lblAdd = new MaterialSkin.Controls.MaterialLabel();
            this.lblConNam = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeaNam = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeaNo = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStandardForm = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pldgSalesOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkItemVal);
            this.panel2.Controls.Add(this.chFormat);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.chItem);
            this.panel2.Controls.Add(this.chDelivery);
            this.panel2.Controls.Add(this.chContactNo);
            this.panel2.Controls.Add(this.chConactName);
            this.panel2.Controls.Add(this.chDealerName);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cbCity);
            this.panel2.Controls.Add(this.txtPostcode);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtContactNumber);
            this.panel2.Controls.Add(this.txtContactName);
            this.panel2.Controls.Add(this.txtDealerName);
            this.panel2.Controls.Add(this.txtDealerNumber);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Controls.Add(this.cbHold);
            this.panel2.Controls.Add(this.pldgSalesOrder);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblDeliveryDeti);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblCity);
            this.panel2.Controls.Add(this.lblConNo);
            this.panel2.Controls.Add(this.lblPostcode);
            this.panel2.Controls.Add(this.lblAdd);
            this.panel2.Controls.Add(this.lblConNam);
            this.panel2.Controls.Add(this.lblDeaNam);
            this.panel2.Controls.Add(this.lblDeaNo);
            this.panel2.Location = new System.Drawing.Point(10, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 853);
            this.panel2.TabIndex = 2;
            this.panel2.TabStop = true;
            // 
            // checkItemVal
            // 
            this.checkItemVal.AutoSize = true;
            this.checkItemVal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkItemVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkItemVal.Location = new System.Drawing.Point(267, 799);
            this.checkItemVal.Name = "checkItemVal";
            this.checkItemVal.Size = new System.Drawing.Size(146, 20);
            this.checkItemVal.TabIndex = 38;
            this.checkItemVal.Text = "Item should not be 0";
            this.checkItemVal.Visible = false;
            // 
            // chFormat
            // 
            this.chFormat.AutoSize = true;
            this.chFormat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chFormat.Location = new System.Drawing.Point(530, 91);
            this.chFormat.Name = "chFormat";
            this.chFormat.Size = new System.Drawing.Size(209, 20);
            this.chFormat.TabIndex = 37;
            this.chFormat.Text = "Format \"FirstName LastName\"";
            this.chFormat.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(131, 349);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 23);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // chItem
            // 
            this.chItem.AutoSize = true;
            this.chItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chItem.Location = new System.Drawing.Point(267, 799);
            this.chItem.Name = "chItem";
            this.chItem.Size = new System.Drawing.Size(125, 20);
            this.chItem.TabIndex = 35;
            this.chItem.Text = "Missing Add Item";
            this.chItem.Visible = false;
            // 
            // chDelivery
            // 
            this.chDelivery.AutoSize = true;
            this.chDelivery.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chDelivery.Location = new System.Drawing.Point(165, 202);
            this.chDelivery.Name = "chDelivery";
            this.chDelivery.Size = new System.Drawing.Size(167, 20);
            this.chDelivery.TabIndex = 34;
            this.chDelivery.Text = "Missing Delivery Detials";
            this.chDelivery.Visible = false;
            // 
            // chContactNo
            // 
            this.chContactNo.AutoSize = true;
            this.chContactNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chContactNo.Location = new System.Drawing.Point(343, 120);
            this.chContactNo.Name = "chContactNo";
            this.chContactNo.Size = new System.Drawing.Size(134, 20);
            this.chContactNo.TabIndex = 32;
            this.chContactNo.Text = "Missing ContactNo";
            this.chContactNo.Visible = false;
            // 
            // chConactName
            // 
            this.chConactName.AutoSize = true;
            this.chConactName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chConactName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chConactName.Location = new System.Drawing.Point(538, 88);
            this.chConactName.Name = "chConactName";
            this.chConactName.Size = new System.Drawing.Size(149, 20);
            this.chConactName.TabIndex = 31;
            this.chConactName.Text = "Missing ConactName";
            this.chConactName.Visible = false;
            // 
            // chDealerName
            // 
            this.chDealerName.AutoSize = true;
            this.chDealerName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chDealerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chDealerName.Location = new System.Drawing.Point(538, 60);
            this.chDealerName.Name = "chDealerName";
            this.chDealerName.Size = new System.Drawing.Size(147, 20);
            this.chDealerName.TabIndex = 30;
            this.chDealerName.Text = "Missing DealerName";
            this.chDealerName.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblGrandTotal);
            this.panel3.Location = new System.Drawing.Point(476, 641);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 30);
            this.panel3.TabIndex = 29;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Depth = 0;
            this.lblGrandTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGrandTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(125, 0);
            this.lblGrandTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(111, 19);
            this.lblGrandTotal.TabIndex = 18;
            this.lblGrandTotal.Text = "Grand Total: $0";
            // 
            // cbCity
            // 
            this.cbCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Baotou",
            "Beijing",
            "Changchun",
            "Changsha",
            "Changzhou",
            "Chengdu",
            "\tChongqing",
            "Dalian",
            "Dongguan",
            "Foshan",
            "Fuzhou",
            "Guangzhou",
            "Guiyang",
            "\tHangzhou",
            "Harbin",
            "Hefei",
            "Huizhou",
            "Jinan",
            "Kunming",
            "Lanzhou",
            "Liuzhou",
            "Luoyang",
            "Nanjing",
            "Nantong",
            "Qingdao",
            "Shanghai",
            "Shantou",
            "Shaoxing",
            "Shenyang",
            "Shijiazhuang",
            "Suzhou",
            "Tangshan",
            "Tianjin",
            "Wenzhou",
            "Xuzhou",
            "Zhengzhou",
            "Zhongshan",
            "Zibo"});
            this.cbCity.Location = new System.Drawing.Point(217, 263);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 23);
            this.cbCity.TabIndex = 27;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Depth = 0;
            this.txtPostcode.Hint = "Postcode*";
            this.txtPostcode.Location = new System.Drawing.Point(217, 296);
            this.txtPostcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.PasswordChar = '\0';
            this.txtPostcode.SelectedText = "";
            this.txtPostcode.SelectionLength = 0;
            this.txtPostcode.SelectionStart = 0;
            this.txtPostcode.Size = new System.Drawing.Size(91, 23);
            this.txtPostcode.TabIndex = 26;
            this.txtPostcode.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Depth = 0;
            this.txtAddress.Hint = "Street Address*";
            this.txtAddress.Location = new System.Drawing.Point(217, 234);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(375, 23);
            this.txtAddress.TabIndex = 24;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Email Address";
            this.txtEmail.Location = new System.Drawing.Point(169, 151);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(270, 23);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Depth = 0;
            this.txtContactNumber.Hint = "Contact Number*";
            this.txtContactNumber.Location = new System.Drawing.Point(168, 120);
            this.txtContactNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.PasswordChar = '\0';
            this.txtContactNumber.SelectedText = "";
            this.txtContactNumber.SelectionLength = 0;
            this.txtContactNumber.SelectionStart = 0;
            this.txtContactNumber.Size = new System.Drawing.Size(169, 23);
            this.txtContactNumber.TabIndex = 22;
            this.txtContactNumber.UseSystemPasswordChar = false;
            // 
            // txtContactName
            // 
            this.txtContactName.Depth = 0;
            this.txtContactName.Hint = "Contact Name*";
            this.txtContactName.Location = new System.Drawing.Point(168, 90);
            this.txtContactName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.PasswordChar = '\0';
            this.txtContactName.SelectedText = "";
            this.txtContactName.SelectionLength = 0;
            this.txtContactName.SelectionStart = 0;
            this.txtContactName.Size = new System.Drawing.Size(345, 23);
            this.txtContactName.TabIndex = 21;
            this.txtContactName.UseSystemPasswordChar = false;
            // 
            // txtDealerName
            // 
            this.txtDealerName.Depth = 0;
            this.txtDealerName.Hint = "Dealer Name*";
            this.txtDealerName.Location = new System.Drawing.Point(168, 57);
            this.txtDealerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.PasswordChar = '\0';
            this.txtDealerName.SelectedText = "";
            this.txtDealerName.SelectionLength = 0;
            this.txtDealerName.SelectionStart = 0;
            this.txtDealerName.Size = new System.Drawing.Size(345, 23);
            this.txtDealerName.TabIndex = 20;
            this.txtDealerName.UseSystemPasswordChar = false;
            // 
            // txtDealerNumber
            // 
            this.txtDealerNumber.Depth = 0;
            this.txtDealerNumber.Hint = "Dealer No.";
            this.txtDealerNumber.Location = new System.Drawing.Point(168, 20);
            this.txtDealerNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDealerNumber.Name = "txtDealerNumber";
            this.txtDealerNumber.PasswordChar = '\0';
            this.txtDealerNumber.SelectedText = "";
            this.txtDealerNumber.SelectionLength = 0;
            this.txtDealerNumber.SelectionStart = 0;
            this.txtDealerNumber.Size = new System.Drawing.Size(210, 23);
            this.txtDealerNumber.TabIndex = 19;
            this.txtDealerNumber.TabStop = false;
            this.txtDealerNumber.UseSystemPasswordChar = false;
            this.txtDealerNumber.TextChanged += new System.EventHandler(this.TxtDealerNumber_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(200, 793);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(61, 32);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Location = new System.Drawing.Point(38, 793);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(140, 32);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Depth = 0;
            this.txtDescription.Hint = "";
            this.txtDescription.Location = new System.Drawing.Point(130, 739);
            this.txtDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.Size = new System.Drawing.Size(582, 23);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Location = new System.Drawing.Point(34, 739);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 19);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // cbHold
            // 
            this.cbHold.AutoSize = true;
            this.cbHold.Depth = 0;
            this.cbHold.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbHold.Location = new System.Drawing.Point(36, 692);
            this.cbHold.Margin = new System.Windows.Forms.Padding(0);
            this.cbHold.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbHold.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbHold.Name = "cbHold";
            this.cbHold.Ripple = true;
            this.cbHold.Size = new System.Drawing.Size(96, 30);
            this.cbHold.TabIndex = 13;
            this.cbHold.Text = "Hold Order";
            this.cbHold.UseVisualStyleBackColor = true;
            // 
            // pldgSalesOrder
            // 
            this.pldgSalesOrder.Controls.Add(this.dgOrder);
            this.pldgSalesOrder.Location = new System.Drawing.Point(28, 388);
            this.pldgSalesOrder.Name = "pldgSalesOrder";
            this.pldgSalesOrder.Size = new System.Drawing.Size(684, 247);
            this.pldgSalesOrder.TabIndex = 12;
            this.pldgSalesOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgSalesOrder_Paint);
            // 
            // dgOrder
            // 
            this.dgOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgOrder.AllowUserToAddRows = false;
            this.dgOrder.AllowUserToDeleteRows = false;
            this.dgOrder.AllowUserToResizeColumns = false;
            this.dgOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrder.ColumnHeadersHeight = 40;
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.OrderQty,
            this.salesPrice});
            this.dgOrder.DoubleBuffered = true;
            this.dgOrder.EnableHeadersVisualStyles = false;
            this.dgOrder.GridColor = System.Drawing.Color.White;
            this.dgOrder.HeaderBgColor = System.Drawing.Color.White;
            this.dgOrder.HeaderForeColor = System.Drawing.Color.Black;
            this.dgOrder.Location = new System.Drawing.Point(3, 3);
            this.dgOrder.MultiSelect = false;
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgOrder.RowHeadersVisible = false;
            this.dgOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOrder.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrder.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgOrder.RowTemplate.DividerHeight = 1;
            this.dgOrder.RowTemplate.Height = 30;
            this.dgOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrder.Size = new System.Drawing.Size(678, 241);
            this.dgOrder.TabIndex = 6;
            this.dgOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrder_CellDoubleClick);
            this.dgOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrder_CellValueChanged);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // OrderQty
            // 
            this.OrderQty.HeaderText = "OrderQty";
            this.OrderQty.Name = "OrderQty";
            // 
            // salesPrice
            // 
            this.salesPrice.HeaderText = "salesPrice";
            this.salesPrice.Name = "salesPrice";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(44, 153);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 19);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblDeliveryDeti
            // 
            this.lblDeliveryDeti.AutoSize = true;
            this.lblDeliveryDeti.Depth = 0;
            this.lblDeliveryDeti.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDeliveryDeti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeliveryDeti.Location = new System.Drawing.Point(43, 203);
            this.lblDeliveryDeti.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeliveryDeti.Name = "lblDeliveryDeti";
            this.lblDeliveryDeti.Size = new System.Drawing.Size(113, 19);
            this.lblDeliveryDeti.TabIndex = 10;
            this.lblDeliveryDeti.Text = "Delivery Detials";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(92, 237);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(112, 19);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Street Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Depth = 0;
            this.lblCity.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCity.Location = new System.Drawing.Point(164, 267);
            this.lblCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 19);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City:";
            // 
            // lblConNo
            // 
            this.lblConNo.AutoSize = true;
            this.lblConNo.Depth = 0;
            this.lblConNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConNo.Location = new System.Drawing.Point(43, 122);
            this.lblConNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.Size = new System.Drawing.Size(120, 19);
            this.lblConNo.TabIndex = 7;
            this.lblConNo.Text = "Contact number:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Depth = 0;
            this.lblPostcode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPostcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPostcode.Location = new System.Drawing.Point(127, 296);
            this.lblPostcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(77, 19);
            this.lblPostcode.TabIndex = 5;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Depth = 0;
            this.lblAdd.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdd.Location = new System.Drawing.Point(44, 352);
            this.lblAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(73, 19);
            this.lblAdd.TabIndex = 3;
            this.lblAdd.Text = "Add item:";
            // 
            // lblConNam
            // 
            this.lblConNam.AutoSize = true;
            this.lblConNam.Depth = 0;
            this.lblConNam.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConNam.Location = new System.Drawing.Point(43, 89);
            this.lblConNam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConNam.Name = "lblConNam";
            this.lblConNam.Size = new System.Drawing.Size(107, 19);
            this.lblConNam.TabIndex = 2;
            this.lblConNam.Text = "Contact name:";
            // 
            // lblDeaNam
            // 
            this.lblDeaNam.AutoSize = true;
            this.lblDeaNam.Depth = 0;
            this.lblDeaNam.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDeaNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeaNam.Location = new System.Drawing.Point(43, 56);
            this.lblDeaNam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeaNam.Name = "lblDeaNam";
            this.lblDeaNam.Size = new System.Drawing.Size(97, 19);
            this.lblDeaNam.TabIndex = 1;
            this.lblDeaNam.Text = "Dealer name:";
            // 
            // lblDeaNo
            // 
            this.lblDeaNo.AutoSize = true;
            this.lblDeaNo.Depth = 0;
            this.lblDeaNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDeaNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDeaNo.Location = new System.Drawing.Point(43, 23);
            this.lblDeaNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeaNo.Name = "lblDeaNo";
            this.lblDeaNo.Size = new System.Drawing.Size(110, 19);
            this.lblDeaNo.TabIndex = 0;
            this.lblDeaNo.Text = "Dealer number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.lblStandardForm);
            this.panel1.Location = new System.Drawing.Point(1, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 926);
            this.panel1.TabIndex = 3;
            // 
            // lblStandardForm
            // 
            this.lblStandardForm.AutoSize = true;
            this.lblStandardForm.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandardForm.Location = new System.Drawing.Point(11, 12);
            this.lblStandardForm.Name = "lblStandardForm";
            this.lblStandardForm.Size = new System.Drawing.Size(229, 45);
            this.lblStandardForm.TabIndex = 1;
            this.lblStandardForm.Text = "Standard Form";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 991);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Orders";
            this.Text = "Create Order";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pldgSalesOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel lblGrandTotal;
        private System.Windows.Forms.ComboBox cbCity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPostcode;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContactNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContactName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDealerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDealerNumber;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescription;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialCheckBox cbHold;
        private System.Windows.Forms.Panel pldgSalesOrder;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgOrder;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblDeliveryDeti;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lblCity;
        private MaterialSkin.Controls.MaterialLabel lblConNo;
        private MaterialSkin.Controls.MaterialLabel lblPostcode;
        private MaterialSkin.Controls.MaterialLabel lblAdd;
        private MaterialSkin.Controls.MaterialLabel lblConNam;
        private MaterialSkin.Controls.MaterialLabel lblDeaNam;
        private MaterialSkin.Controls.MaterialLabel lblDeaNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStandardForm;
        private System.Windows.Forms.Label chItem;
        private System.Windows.Forms.Label chDelivery;
        private System.Windows.Forms.Label chContactNo;
        private System.Windows.Forms.Label chConactName;
        private System.Windows.Forms.Label chDealerName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPrice;
        private System.Windows.Forms.Label chFormat;
        private System.Windows.Forms.Label checkItemVal;
    }
}