namespace WindowsFormsApplication1
{
    partial class AddItem
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
            this.lblInstock = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.txtDanger = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDanger = new MaterialSkin.Controls.MaterialLabel();
            this.txtSalesPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSalesPrice = new MaterialSkin.Controls.MaterialLabel();
            this.txtInStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lnlInStock = new MaterialSkin.Controls.MaterialLabel();
            this.btnSubmit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbCategroy = new System.Windows.Forms.ComboBox();
            this.txtWareHouse = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtHold = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPurchase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtReorder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblReorder = new MaterialSkin.Controls.MaterialLabel();
            this.lblPurchase = new MaterialSkin.Controls.MaterialLabel();
            this.lblHold = new MaterialSkin.Controls.MaterialLabel();
            this.lblWareHouse = new MaterialSkin.Controls.MaterialLabel();
            this.lblCategroy = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.plMain = new System.Windows.Forms.Panel();
            this.txtDemand = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDemand = new MaterialSkin.Controls.MaterialLabel();
            this.txtAuto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAuto = new MaterialSkin.Controls.MaterialLabel();
            this.plBlackground = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.plMain.SuspendLayout();
            this.plBlackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstock
            // 
            this.lblInstock.AutoSize = true;
            this.lblInstock.Depth = 0;
            this.lblInstock.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInstock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInstock.Location = new System.Drawing.Point(79, 439);
            this.lblInstock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstock.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInstock.Name = "lblInstock";
            this.lblInstock.Size = new System.Drawing.Size(67, 24);
            this.lblInstock.TabIndex = 52;
            this.lblInstock.Text = "status:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(232, 571);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(281, 90);
            this.txtDescription.TabIndex = 51;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Location = new System.Drawing.Point(77, 571);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(111, 24);
            this.lblDescription.TabIndex = 50;
            this.lblDescription.Text = "Description:";
            // 
            // txtDanger
            // 
            this.txtDanger.Depth = 0;
            this.txtDanger.Hint = "";
            this.txtDanger.Location = new System.Drawing.Point(233, 394);
            this.txtDanger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDanger.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDanger.Name = "txtDanger";
            this.txtDanger.PasswordChar = '\0';
            this.txtDanger.SelectedText = "";
            this.txtDanger.SelectionLength = 0;
            this.txtDanger.SelectionStart = 0;
            this.txtDanger.Size = new System.Drawing.Size(280, 28);
            this.txtDanger.TabIndex = 49;
            this.txtDanger.TabStop = false;
            this.txtDanger.UseSystemPasswordChar = false;
            // 
            // lblDanger
            // 
            this.lblDanger.AutoSize = true;
            this.lblDanger.Depth = 0;
            this.lblDanger.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDanger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDanger.Location = new System.Drawing.Point(79, 399);
            this.lblDanger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanger.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDanger.Name = "lblDanger";
            this.lblDanger.Size = new System.Drawing.Size(74, 24);
            this.lblDanger.TabIndex = 48;
            this.lblDanger.Text = "Danger:";
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Depth = 0;
            this.txtSalesPrice.Hint = "";
            this.txtSalesPrice.Location = new System.Drawing.Point(233, 269);
            this.txtSalesPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalesPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.PasswordChar = '\0';
            this.txtSalesPrice.SelectedText = "";
            this.txtSalesPrice.SelectionLength = 0;
            this.txtSalesPrice.SelectionStart = 0;
            this.txtSalesPrice.Size = new System.Drawing.Size(280, 28);
            this.txtSalesPrice.TabIndex = 47;
            this.txtSalesPrice.TabStop = false;
            this.txtSalesPrice.UseSystemPasswordChar = false;
            // 
            // lblSalesPrice
            // 
            this.lblSalesPrice.AutoSize = true;
            this.lblSalesPrice.Depth = 0;
            this.lblSalesPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSalesPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalesPrice.Location = new System.Drawing.Point(77, 274);
            this.lblSalesPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalesPrice.Name = "lblSalesPrice";
            this.lblSalesPrice.Size = new System.Drawing.Size(138, 24);
            this.lblSalesPrice.TabIndex = 46;
            this.lblSalesPrice.Text = "Sales Price($): ";
            // 
            // txtInStock
            // 
            this.txtInStock.Depth = 0;
            this.txtInStock.Hint = "";
            this.txtInStock.Location = new System.Drawing.Point(231, 195);
            this.txtInStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.PasswordChar = '\0';
            this.txtInStock.SelectedText = "";
            this.txtInStock.SelectionLength = 0;
            this.txtInStock.SelectionStart = 0;
            this.txtInStock.Size = new System.Drawing.Size(280, 28);
            this.txtInStock.TabIndex = 45;
            this.txtInStock.TabStop = false;
            this.txtInStock.UseSystemPasswordChar = false;
            // 
            // lnlInStock
            // 
            this.lnlInStock.AutoSize = true;
            this.lnlInStock.Depth = 0;
            this.lnlInStock.Font = new System.Drawing.Font("Roboto", 11F);
            this.lnlInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnlInStock.Location = new System.Drawing.Point(77, 195);
            this.lnlInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnlInStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.lnlInStock.Name = "lnlInStock";
            this.lnlInStock.Size = new System.Drawing.Size(83, 24);
            this.lnlInStock.TabIndex = 44;
            this.lnlInStock.Text = "In Stock:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Location = new System.Drawing.Point(84, 698);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Primary = true;
            this.btnSubmit.Size = new System.Drawing.Size(195, 49);
            this.btnSubmit.TabIndex = 42;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // cbCategroy
            // 
            this.cbCategroy.FormattingEnabled = true;
            this.cbCategroy.Location = new System.Drawing.Point(233, 111);
            this.cbCategroy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategroy.Name = "cbCategroy";
            this.cbCategroy.Size = new System.Drawing.Size(160, 23);
            this.cbCategroy.TabIndex = 40;
            // 
            // txtWareHouse
            // 
            this.txtWareHouse.Depth = 0;
            this.txtWareHouse.Hint = "";
            this.txtWareHouse.Location = new System.Drawing.Point(231, 152);
            this.txtWareHouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWareHouse.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtWareHouse.Name = "txtWareHouse";
            this.txtWareHouse.PasswordChar = '\0';
            this.txtWareHouse.SelectedText = "";
            this.txtWareHouse.SelectionLength = 0;
            this.txtWareHouse.SelectionStart = 0;
            this.txtWareHouse.Size = new System.Drawing.Size(280, 28);
            this.txtWareHouse.TabIndex = 38;
            this.txtWareHouse.TabStop = false;
            this.txtWareHouse.UseSystemPasswordChar = false;
            // 
            // txtHold
            // 
            this.txtHold.Depth = 0;
            this.txtHold.Hint = "";
            this.txtHold.Location = new System.Drawing.Point(232, 230);
            this.txtHold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHold.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHold.Name = "txtHold";
            this.txtHold.PasswordChar = '\0';
            this.txtHold.SelectedText = "";
            this.txtHold.SelectionLength = 0;
            this.txtHold.SelectionStart = 0;
            this.txtHold.Size = new System.Drawing.Size(280, 28);
            this.txtHold.TabIndex = 37;
            this.txtHold.TabStop = false;
            this.txtHold.UseSystemPasswordChar = false;
            // 
            // txtPurchase
            // 
            this.txtPurchase.Depth = 0;
            this.txtPurchase.Hint = "";
            this.txtPurchase.Location = new System.Drawing.Point(233, 311);
            this.txtPurchase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPurchase.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.PasswordChar = '\0';
            this.txtPurchase.SelectedText = "";
            this.txtPurchase.SelectionLength = 0;
            this.txtPurchase.SelectionStart = 0;
            this.txtPurchase.Size = new System.Drawing.Size(280, 28);
            this.txtPurchase.TabIndex = 36;
            this.txtPurchase.TabStop = false;
            this.txtPurchase.UseSystemPasswordChar = false;
            // 
            // txtReorder
            // 
            this.txtReorder.Depth = 0;
            this.txtReorder.Hint = "";
            this.txtReorder.Location = new System.Drawing.Point(232, 351);
            this.txtReorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReorder.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.PasswordChar = '\0';
            this.txtReorder.SelectedText = "";
            this.txtReorder.SelectionLength = 0;
            this.txtReorder.SelectionStart = 0;
            this.txtReorder.Size = new System.Drawing.Size(280, 28);
            this.txtReorder.TabIndex = 35;
            this.txtReorder.TabStop = false;
            this.txtReorder.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(232, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(280, 28);
            this.txtName.TabIndex = 34;
            this.txtName.TabStop = false;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // lblReorder
            // 
            this.lblReorder.AutoSize = true;
            this.lblReorder.Depth = 0;
            this.lblReorder.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblReorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReorder.Location = new System.Drawing.Point(77, 356);
            this.lblReorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReorder.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(91, 24);
            this.lblReorder.TabIndex = 32;
            this.lblReorder.Text = "Re-order: ";
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Depth = 0;
            this.lblPurchase.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPurchase.Location = new System.Drawing.Point(77, 314);
            this.lblPurchase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchase.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(122, 24);
            this.lblPurchase.TabIndex = 31;
            this.lblPurchase.Text = "Purchase($): ";
            // 
            // lblHold
            // 
            this.lblHold.AutoSize = true;
            this.lblHold.Depth = 0;
            this.lblHold.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHold.Location = new System.Drawing.Point(79, 235);
            this.lblHold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHold.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHold.Name = "lblHold";
            this.lblHold.Size = new System.Drawing.Size(61, 24);
            this.lblHold.TabIndex = 30;
            this.lblHold.Text = "Hold: ";
            // 
            // lblWareHouse
            // 
            this.lblWareHouse.AutoSize = true;
            this.lblWareHouse.Depth = 0;
            this.lblWareHouse.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblWareHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWareHouse.Location = new System.Drawing.Point(76, 152);
            this.lblWareHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWareHouse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWareHouse.Name = "lblWareHouse";
            this.lblWareHouse.Size = new System.Drawing.Size(114, 24);
            this.lblWareHouse.TabIndex = 29;
            this.lblWareHouse.Text = "Warehouse: ";
            // 
            // lblCategroy
            // 
            this.lblCategroy.AutoSize = true;
            this.lblCategroy.Depth = 0;
            this.lblCategroy.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategroy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategroy.Location = new System.Drawing.Point(77, 111);
            this.lblCategroy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategroy.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategroy.Name = "lblCategroy";
            this.lblCategroy.Size = new System.Drawing.Size(95, 24);
            this.lblCategroy.TabIndex = 28;
            this.lblCategroy.Text = "Categroy: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(77, 58);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 24);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Item Name: ";
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.White;
            this.plMain.Controls.Add(this.txtStatus);
            this.plMain.Controls.Add(this.txtDemand);
            this.plMain.Controls.Add(this.lblDemand);
            this.plMain.Controls.Add(this.txtAuto);
            this.plMain.Controls.Add(this.lblAuto);
            this.plMain.Controls.Add(this.lblInstock);
            this.plMain.Controls.Add(this.txtDescription);
            this.plMain.Controls.Add(this.lblDescription);
            this.plMain.Controls.Add(this.txtDanger);
            this.plMain.Controls.Add(this.lblDanger);
            this.plMain.Controls.Add(this.txtSalesPrice);
            this.plMain.Controls.Add(this.lblSalesPrice);
            this.plMain.Controls.Add(this.txtInStock);
            this.plMain.Controls.Add(this.lnlInStock);
            this.plMain.Controls.Add(this.btnSubmit);
            this.plMain.Controls.Add(this.cbCategroy);
            this.plMain.Controls.Add(this.txtWareHouse);
            this.plMain.Controls.Add(this.txtHold);
            this.plMain.Controls.Add(this.txtPurchase);
            this.plMain.Controls.Add(this.txtReorder);
            this.plMain.Controls.Add(this.txtName);
            this.plMain.Controls.Add(this.lblReorder);
            this.plMain.Controls.Add(this.lblPurchase);
            this.plMain.Controls.Add(this.lblHold);
            this.plMain.Controls.Add(this.lblWareHouse);
            this.plMain.Controls.Add(this.lblCategroy);
            this.plMain.Controls.Add(this.lblName);
            this.plMain.Location = new System.Drawing.Point(9, 9);
            this.plMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(597, 786);
            this.plMain.TabIndex = 0;
            // 
            // txtDemand
            // 
            this.txtDemand.Depth = 0;
            this.txtDemand.Hint = "";
            this.txtDemand.Location = new System.Drawing.Point(231, 518);
            this.txtDemand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDemand.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDemand.Name = "txtDemand";
            this.txtDemand.PasswordChar = '\0';
            this.txtDemand.SelectedText = "";
            this.txtDemand.SelectionLength = 0;
            this.txtDemand.SelectionStart = 0;
            this.txtDemand.Size = new System.Drawing.Size(280, 28);
            this.txtDemand.TabIndex = 57;
            this.txtDemand.TabStop = false;
            this.txtDemand.UseSystemPasswordChar = false;
            // 
            // lblDemand
            // 
            this.lblDemand.AutoSize = true;
            this.lblDemand.Depth = 0;
            this.lblDemand.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDemand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDemand.Location = new System.Drawing.Point(76, 522);
            this.lblDemand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDemand.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDemand.Name = "lblDemand";
            this.lblDemand.Size = new System.Drawing.Size(85, 24);
            this.lblDemand.TabIndex = 56;
            this.lblDemand.Text = "Demand:";
            // 
            // txtAuto
            // 
            this.txtAuto.Depth = 0;
            this.txtAuto.Hint = "";
            this.txtAuto.Location = new System.Drawing.Point(232, 475);
            this.txtAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.PasswordChar = '\0';
            this.txtAuto.SelectedText = "";
            this.txtAuto.SelectionLength = 0;
            this.txtAuto.SelectionStart = 0;
            this.txtAuto.Size = new System.Drawing.Size(280, 28);
            this.txtAuto.TabIndex = 55;
            this.txtAuto.TabStop = false;
            this.txtAuto.UseSystemPasswordChar = false;
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Depth = 0;
            this.lblAuto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAuto.Location = new System.Drawing.Point(77, 480);
            this.lblAuto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(120, 24);
            this.lblAuto.TabIndex = 54;
            this.lblAuto.Text = "AutoReorder:";
            // 
            // plBlackground
            // 
            this.plBlackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.plBlackground.Controls.Add(this.plMain);
            this.plBlackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBlackground.Location = new System.Drawing.Point(0, 80);
            this.plBlackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plBlackground.Name = "plBlackground";
            this.plBlackground.Size = new System.Drawing.Size(623, 810);
            this.plBlackground.TabIndex = 2;
            this.plBlackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PlBlackground_Paint);
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Available",
            "Re-order",
            "Danger",
            "Out-Of-Stock"});
            this.txtStatus.Location = new System.Drawing.Point(231, 439);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 23);
            this.txtStatus.TabIndex = 58;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 890);
            this.Controls.Add(this.plBlackground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.plMain.ResumeLayout(false);
            this.plMain.PerformLayout();
            this.plBlackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblInstock;
        private System.Windows.Forms.TextBox txtDescription;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDanger;
        private MaterialSkin.Controls.MaterialLabel lblDanger;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSalesPrice;
        private MaterialSkin.Controls.MaterialLabel lblSalesPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtInStock;
        private MaterialSkin.Controls.MaterialLabel lnlInStock;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmit;
        private System.Windows.Forms.ComboBox cbCategroy;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtWareHouse;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHold;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPurchase;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtReorder;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialLabel lblReorder;
        private MaterialSkin.Controls.MaterialLabel lblPurchase;
        private MaterialSkin.Controls.MaterialLabel lblHold;
        private MaterialSkin.Controls.MaterialLabel lblWareHouse;
        private MaterialSkin.Controls.MaterialLabel lblCategroy;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel plBlackground;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAuto;
        private MaterialSkin.Controls.MaterialLabel lblAuto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDemand;
        private MaterialSkin.Controls.MaterialLabel lblDemand;
        private System.Windows.Forms.ComboBox txtStatus;
    }
}