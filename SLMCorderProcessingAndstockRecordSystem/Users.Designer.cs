namespace WindowsFormsApplication1
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDept = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.plType = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dpDept = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.plUsers = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblUsers = new System.Windows.Forms.Label();
            this.plMainUsers = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabpage = new MaterialSkin.Controls.MaterialTabControl();
            this.tpUser = new System.Windows.Forms.TabPage();
            this.btnEditPwd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtSearchUserInf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDelUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTotalEntr = new MaterialSkin.Controls.MaterialLabel();
            this.pldgUsers = new System.Windows.Forms.Panel();
            this.dgUsersInf = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tplogging = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTotalEntr2 = new MaterialSkin.Controls.MaterialLabel();
            this.pldgUserLogging = new System.Windows.Forms.Panel();
            this.dgUserLogging = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.plType.SuspendLayout();
            this.panel4.SuspendLayout();
            this.plUsers.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plMainUsers.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabpage.SuspendLayout();
            this.tpUser.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pldgUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsersInf)).BeginInit();
            this.tplogging.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pldgUserLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserLogging)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Depth = 0;
            this.lblDept.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDept.Location = new System.Drawing.Point(263, 45);
            this.lblDept.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(87, 19);
            this.lblDept.TabIndex = 28;
            this.lblDept.Text = "Department";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.plType);
            this.panel1.Controls.Add(this.lblDept);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblFilter);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(4, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 177);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Location = new System.Drawing.Point(159, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 39);
            this.panel5.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.Black;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = null;
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 90D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.OnHovercolor = System.Drawing.Color.Black;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(89, 39);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "";
            this.txtUsername.Location = new System.Drawing.Point(37, 73);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(169, 23);
            this.txtUsername.TabIndex = 30;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsername.Location = new System.Drawing.Point(36, 45);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 19);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username/ UserID";
            // 
            // plType
            // 
            this.plType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plType.BackgroundImage")));
            this.plType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plType.Controls.Add(this.dpDept);
            this.plType.GradientBottomLeft = System.Drawing.Color.White;
            this.plType.GradientBottomRight = System.Drawing.Color.White;
            this.plType.GradientTopLeft = System.Drawing.Color.White;
            this.plType.GradientTopRight = System.Drawing.Color.White;
            this.plType.Location = new System.Drawing.Point(267, 67);
            this.plType.Name = "plType";
            this.plType.Quality = 10;
            this.plType.Size = new System.Drawing.Size(192, 29);
            this.plType.TabIndex = 6;
            this.plType.Paint += new System.Windows.Forms.PaintEventHandler(this.plType_Paint);
            // 
            // dpDept
            // 
            this.dpDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpDept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDept.FormattingEnabled = true;
            this.dpDept.Items.AddRange(new object[] {
            " "});
            this.dpDept.Location = new System.Drawing.Point(0, 0);
            this.dpDept.Name = "dpDept";
            this.dpDept.Size = new System.Drawing.Size(192, 29);
            this.dpDept.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFilter);
            this.panel4.Location = new System.Drawing.Point(37, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(89, 39);
            this.panel4.TabIndex = 7;
            // 
            // btnFilter
            // 
            this.btnFilter.Activecolor = System.Drawing.Color.Black;
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.BorderRadius = 0;
            this.btnFilter.ButtonText = "Filter";
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFilter.Iconimage = null;
            this.btnFilter.Iconimage_right = null;
            this.btnFilter.Iconimage_right_Selected = null;
            this.btnFilter.Iconimage_Selected = null;
            this.btnFilter.IconMarginLeft = 0;
            this.btnFilter.IconMarginRight = 0;
            this.btnFilter.IconRightVisible = true;
            this.btnFilter.IconRightZoom = 0D;
            this.btnFilter.IconVisible = true;
            this.btnFilter.IconZoom = 90D;
            this.btnFilter.IsTab = false;
            this.btnFilter.Location = new System.Drawing.Point(0, 0);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilter.OnHovercolor = System.Drawing.Color.Black;
            this.btnFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilter.selected = false;
            this.btnFilter.Size = new System.Drawing.Size(89, 39);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.Textcolor = System.Drawing.Color.White;
            this.btnFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(30, 13);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(76, 37);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter";
            // 
            // plUsers
            // 
            this.plUsers.BackColor = System.Drawing.Color.White;
            this.plUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plUsers.Controls.Add(this.panel3);
            this.plUsers.Controls.Add(this.lblUsers);
            this.plUsers.Location = new System.Drawing.Point(4, 5);
            this.plUsers.Name = "plUsers";
            this.plUsers.Size = new System.Drawing.Size(1164, 71);
            this.plUsers.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddUser);
            this.panel3.Location = new System.Drawing.Point(924, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 39);
            this.panel3.TabIndex = 8;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Activecolor = System.Drawing.Color.Black;
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.BorderRadius = 0;
            this.btnAddUser.ButtonText = "Add User";
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddUser.Iconimage = null;
            this.btnAddUser.Iconimage_right = null;
            this.btnAddUser.Iconimage_right_Selected = null;
            this.btnAddUser.Iconimage_Selected = null;
            this.btnAddUser.IconMarginLeft = 0;
            this.btnAddUser.IconMarginRight = 0;
            this.btnAddUser.IconRightVisible = true;
            this.btnAddUser.IconRightZoom = 0D;
            this.btnAddUser.IconVisible = true;
            this.btnAddUser.IconZoom = 90D;
            this.btnAddUser.IsTab = false;
            this.btnAddUser.Location = new System.Drawing.Point(0, 0);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.OnHovercolor = System.Drawing.Color.Black;
            this.btnAddUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddUser.selected = false;
            this.btnAddUser.Size = new System.Drawing.Size(208, 39);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.Textcolor = System.Drawing.Color.White;
            this.btnAddUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(19, 8);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(111, 50);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "Users";
            // 
            // plMainUsers
            // 
            this.plMainUsers.Controls.Add(this.panel2);
            this.plMainUsers.Controls.Add(this.panel1);
            this.plMainUsers.Controls.Add(this.plUsers);
            this.plMainUsers.Location = new System.Drawing.Point(2, 5);
            this.plMainUsers.Name = "plMainUsers";
            this.plMainUsers.Size = new System.Drawing.Size(1175, 668);
            this.plMainUsers.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabpage);
            this.panel2.Controls.Add(this.materialTabSelector1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(4, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 384);
            this.panel2.TabIndex = 2;
            // 
            // tabpage
            // 
            this.tabpage.Controls.Add(this.tpUser);
            this.tabpage.Controls.Add(this.tplogging);
            this.tabpage.Depth = 0;
            this.tabpage.Location = new System.Drawing.Point(8, 72);
            this.tabpage.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabpage.Name = "tabpage";
            this.tabpage.SelectedIndex = 0;
            this.tabpage.Size = new System.Drawing.Size(1153, 390);
            this.tabpage.TabIndex = 14;
            this.tabpage.SelectedIndexChanged += new System.EventHandler(this.Tabpage_SelectedIndexChanged);
            // 
            // tpUser
            // 
            this.tpUser.Controls.Add(this.btnEditPwd);
            this.tpUser.Controls.Add(this.panel7);
            this.tpUser.Controls.Add(this.btnDelUser);
            this.tpUser.Controls.Add(this.lblTotalEntr);
            this.tpUser.Controls.Add(this.pldgUsers);
            this.tpUser.Location = new System.Drawing.Point(4, 22);
            this.tpUser.Name = "tpUser";
            this.tpUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpUser.Size = new System.Drawing.Size(1145, 364);
            this.tpUser.TabIndex = 0;
            this.tpUser.Text = "User Information";
            this.tpUser.UseVisualStyleBackColor = true;
            // 
            // btnEditPwd
            // 
            this.btnEditPwd.Activecolor = System.Drawing.Color.Black;
            this.btnEditPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditPwd.BorderRadius = 0;
            this.btnEditPwd.ButtonText = "Edit Password";
            this.btnEditPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPwd.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditPwd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditPwd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditPwd.Iconimage")));
            this.btnEditPwd.Iconimage_right = null;
            this.btnEditPwd.Iconimage_right_Selected = null;
            this.btnEditPwd.Iconimage_Selected = null;
            this.btnEditPwd.IconMarginLeft = 0;
            this.btnEditPwd.IconMarginRight = 0;
            this.btnEditPwd.IconRightVisible = false;
            this.btnEditPwd.IconRightZoom = 0D;
            this.btnEditPwd.IconVisible = false;
            this.btnEditPwd.IconZoom = 90D;
            this.btnEditPwd.IsTab = false;
            this.btnEditPwd.Location = new System.Drawing.Point(196, 19);
            this.btnEditPwd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditPwd.Name = "btnEditPwd";
            this.btnEditPwd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditPwd.OnHovercolor = System.Drawing.Color.Black;
            this.btnEditPwd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditPwd.selected = false;
            this.btnEditPwd.Size = new System.Drawing.Size(163, 36);
            this.btnEditPwd.TabIndex = 11;
            this.btnEditPwd.Text = "Edit Password";
            this.btnEditPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditPwd.Textcolor = System.Drawing.Color.White;
            this.btnEditPwd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPwd.Click += new System.EventHandler(this.BtnEditPwd_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.txtSearchUserInf);
            this.panel7.Location = new System.Drawing.Point(851, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(269, 32);
            this.panel7.TabIndex = 33;
            // 
            // txtSearchUserInf
            // 
            this.txtSearchUserInf.Depth = 0;
            this.txtSearchUserInf.Hint = "Search";
            this.txtSearchUserInf.Location = new System.Drawing.Point(3, 3);
            this.txtSearchUserInf.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchUserInf.Name = "txtSearchUserInf";
            this.txtSearchUserInf.PasswordChar = '\0';
            this.txtSearchUserInf.SelectedText = "";
            this.txtSearchUserInf.SelectionLength = 0;
            this.txtSearchUserInf.SelectionStart = 0;
            this.txtSearchUserInf.Size = new System.Drawing.Size(263, 23);
            this.txtSearchUserInf.TabIndex = 0;
            this.txtSearchUserInf.UseSystemPasswordChar = false;
            this.txtSearchUserInf.TextChanged += new System.EventHandler(this.TxtSearchUserInf_TextChanged);
            // 
            // btnDelUser
            // 
            this.btnDelUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelUser.BorderRadius = 0;
            this.btnDelUser.ButtonText = "Delete User";
            this.btnDelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelUser.Iconimage")));
            this.btnDelUser.Iconimage_right = null;
            this.btnDelUser.Iconimage_right_Selected = null;
            this.btnDelUser.Iconimage_Selected = null;
            this.btnDelUser.IconMarginLeft = 0;
            this.btnDelUser.IconMarginRight = 0;
            this.btnDelUser.IconRightVisible = false;
            this.btnDelUser.IconRightZoom = 0D;
            this.btnDelUser.IconVisible = false;
            this.btnDelUser.IconZoom = 90D;
            this.btnDelUser.IsTab = false;
            this.btnDelUser.Location = new System.Drawing.Point(27, 19);
            this.btnDelUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.btnDelUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDelUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelUser.selected = false;
            this.btnDelUser.Size = new System.Drawing.Size(163, 36);
            this.btnDelUser.TabIndex = 32;
            this.btnDelUser.Text = "Delete User";
            this.btnDelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelUser.Textcolor = System.Drawing.Color.White;
            this.btnDelUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelUser.Click += new System.EventHandler(this.BtnDelUser_Click);
            // 
            // lblTotalEntr
            // 
            this.lblTotalEntr.AutoSize = true;
            this.lblTotalEntr.Depth = 0;
            this.lblTotalEntr.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalEntr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalEntr.Location = new System.Drawing.Point(21, 289);
            this.lblTotalEntr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalEntr.Name = "lblTotalEntr";
            this.lblTotalEntr.Size = new System.Drawing.Size(117, 19);
            this.lblTotalEntr.TabIndex = 12;
            this.lblTotalEntr.Text = "Showing Entries";
            // 
            // pldgUsers
            // 
            this.pldgUsers.Controls.Add(this.dgUsersInf);
            this.pldgUsers.Location = new System.Drawing.Point(17, 68);
            this.pldgUsers.Name = "pldgUsers";
            this.pldgUsers.Size = new System.Drawing.Size(1105, 218);
            this.pldgUsers.TabIndex = 7;
            this.pldgUsers.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgUsers_Paint);
            // 
            // dgUsersInf
            // 
            this.dgUsersInf.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgUsersInf.AllowUserToAddRows = false;
            this.dgUsersInf.AllowUserToDeleteRows = false;
            this.dgUsersInf.AllowUserToResizeColumns = false;
            this.dgUsersInf.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgUsersInf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUsersInf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsersInf.BackgroundColor = System.Drawing.Color.White;
            this.dgUsersInf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUsersInf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgUsersInf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsersInf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgUsersInf.ColumnHeadersHeight = 40;
            this.dgUsersInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgUsersInf.DoubleBuffered = true;
            this.dgUsersInf.EnableHeadersVisualStyles = false;
            this.dgUsersInf.GridColor = System.Drawing.Color.White;
            this.dgUsersInf.HeaderBgColor = System.Drawing.Color.White;
            this.dgUsersInf.HeaderForeColor = System.Drawing.Color.Black;
            this.dgUsersInf.Location = new System.Drawing.Point(4, 3);
            this.dgUsersInf.MultiSelect = false;
            this.dgUsersInf.Name = "dgUsersInf";
            this.dgUsersInf.ReadOnly = true;
            this.dgUsersInf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsersInf.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgUsersInf.RowHeadersVisible = false;
            this.dgUsersInf.RowHeadersWidth = 51;
            this.dgUsersInf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgUsersInf.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUsersInf.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgUsersInf.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgUsersInf.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgUsersInf.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgUsersInf.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgUsersInf.RowTemplate.DividerHeight = 1;
            this.dgUsersInf.RowTemplate.Height = 30;
            this.dgUsersInf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgUsersInf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsersInf.Size = new System.Drawing.Size(1096, 212);
            this.dgUsersInf.TabIndex = 6;
            this.dgUsersInf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgUsersInf_CellClick);
            // 
            // tplogging
            // 
            this.tplogging.Controls.Add(this.panel6);
            this.tplogging.Controls.Add(this.lblTotalEntr2);
            this.tplogging.Controls.Add(this.pldgUserLogging);
            this.tplogging.Location = new System.Drawing.Point(4, 22);
            this.tplogging.Name = "tplogging";
            this.tplogging.Padding = new System.Windows.Forms.Padding(3);
            this.tplogging.Size = new System.Drawing.Size(1145, 364);
            this.tplogging.TabIndex = 1;
            this.tplogging.Text = "LoggingAvtivity";
            this.tplogging.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.txtSearch);
            this.panel6.Location = new System.Drawing.Point(854, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(269, 32);
            this.panel6.TabIndex = 32;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "Search";
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(263, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged_1);
            // 
            // lblTotalEntr2
            // 
            this.lblTotalEntr2.AutoSize = true;
            this.lblTotalEntr2.Depth = 0;
            this.lblTotalEntr2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalEntr2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalEntr2.Location = new System.Drawing.Point(21, 316);
            this.lblTotalEntr2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalEntr2.Name = "lblTotalEntr2";
            this.lblTotalEntr2.Size = new System.Drawing.Size(117, 19);
            this.lblTotalEntr2.TabIndex = 31;
            this.lblTotalEntr2.Text = "Showing Entries";
            // 
            // pldgUserLogging
            // 
            this.pldgUserLogging.Controls.Add(this.dgUserLogging);
            this.pldgUserLogging.Location = new System.Drawing.Point(17, 47);
            this.pldgUserLogging.Name = "pldgUserLogging";
            this.pldgUserLogging.Size = new System.Drawing.Size(1106, 232);
            this.pldgUserLogging.TabIndex = 31;
            this.pldgUserLogging.Paint += new System.Windows.Forms.PaintEventHandler(this.pldgUserLogging_Paint);
            // 
            // dgUserLogging
            // 
            this.dgUserLogging.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dgUserLogging.AllowUserToAddRows = false;
            this.dgUserLogging.AllowUserToDeleteRows = false;
            this.dgUserLogging.AllowUserToResizeColumns = false;
            this.dgUserLogging.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgUserLogging.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgUserLogging.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUserLogging.BackgroundColor = System.Drawing.Color.White;
            this.dgUserLogging.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUserLogging.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgUserLogging.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUserLogging.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgUserLogging.ColumnHeadersHeight = 40;
            this.dgUserLogging.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgUserLogging.DoubleBuffered = true;
            this.dgUserLogging.EnableHeadersVisualStyles = false;
            this.dgUserLogging.GridColor = System.Drawing.Color.White;
            this.dgUserLogging.HeaderBgColor = System.Drawing.Color.White;
            this.dgUserLogging.HeaderForeColor = System.Drawing.Color.Black;
            this.dgUserLogging.Location = new System.Drawing.Point(3, 3);
            this.dgUserLogging.MultiSelect = false;
            this.dgUserLogging.Name = "dgUserLogging";
            this.dgUserLogging.ReadOnly = true;
            this.dgUserLogging.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUserLogging.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgUserLogging.RowHeadersVisible = false;
            this.dgUserLogging.RowHeadersWidth = 51;
            this.dgUserLogging.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgUserLogging.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUserLogging.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgUserLogging.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgUserLogging.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgUserLogging.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgUserLogging.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgUserLogging.RowTemplate.DividerHeight = 1;
            this.dgUserLogging.RowTemplate.Height = 30;
            this.dgUserLogging.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgUserLogging.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUserLogging.Size = new System.Drawing.Size(1100, 222);
            this.dgUserLogging.TabIndex = 6;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabpage;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1162, 68);
            this.materialTabSelector1.TabIndex = 13;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 676);
            this.Controls.Add(this.plMainUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.Shown += new System.EventHandler(this.Users_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.plType.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.plUsers.ResumeLayout(false);
            this.plUsers.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.plMainUsers.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabpage.ResumeLayout(false);
            this.tpUser.ResumeLayout(false);
            this.tpUser.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.pldgUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsersInf)).EndInit();
            this.tplogging.ResumeLayout(false);
            this.tplogging.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pldgUserLogging.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserLogging)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel plType;
        private MaterialSkin.Controls.MaterialLabel lblDept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel plUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Panel plMainUsers;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialTabControl tabpage;
        private System.Windows.Forms.TabPage tpUser;
        private MaterialSkin.Controls.MaterialLabel lblTotalEntr;
        private System.Windows.Forms.Panel pldgUsers;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgUsersInf;
        private System.Windows.Forms.TabPage tplogging;
        private MaterialSkin.Controls.MaterialLabel lblTotalEntr2;
        private System.Windows.Forms.Panel pldgUserLogging;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgUserLogging;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddUser;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private System.Windows.Forms.ComboBox dpDept;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.Panel panel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchUserInf;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditPwd;
    }
}