using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Controller;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class nav : Form
    {
        private Dashboard dashboard;
        private SalesOrder salesOrder;
        private Invoice invoice;
        private Outstanding outstanding;
        private Item item;
        private OrderAssembly orderAssembly;
        private Purchases purchases;
        private Despatch despatch;
        private Users users;
        private StockRecordReport stockReport;
        private SalesOfficeReport salesReport;
        private Admin admin;
        private int formWidth;
        private Controller objControlller;
        private GRN grn;
        private string userName;
        private bool userPrem;
        private string title;
        private string userID;
        
        public nav(string username, bool userPrem, string userID)
        {
            InitializeComponent();
            objControlller = new Controller();
            lblUsername.Text = username;
            userName = username;
            this.userPrem = userPrem;
            this.userID = userID;
            title = objControlller.getTitle(username);
        }

        
        private void nav_Load(object sender, EventArgs e)
        {
            try
            {
                formWidth = this.Width;
                this.Width = formWidth - plNav.Width + 3;
                dashboard = new Dashboard();
                navigation(dashboard);
                setSubTitleLoca("Dashboard");

                if (!userPrem)
                {
                    if (title.Substring(0, 5) == "Sales")
                    {
                        btnAdmin.Visible = false;
                        btnPurchases.Visible = false;
                        btnGRN.Visible = false;
                        btnDespatch.Visible = false;
                        btnUsers.Visible = false;
                        btnOrderAssembly.Visible = false;
                        btnAdmin.Visible = false;
                        btnUsers.Visible = false;
                        btnStockReport.Visible = false;
                        btSalesOfficeReport.Visible = false;
                        Debug.WriteLine(title);
                        Debug.WriteLine(title.ToString());
                        if (title.ToString() == "Sales Manager")
                        {
                            userPrem = true;
                            btnAdmin.Visible = true;
                            btnUsers.Visible = true;
                            btSalesOfficeReport.Visible = true;

                        }
                    }
                    else if (title.Substring(0, 5) == "Store")
                    {
                        btnAdmin.Visible = false;
                        btnSalesOrders.Visible = false;
                        btnPurchases.Visible = false;
                        btnGRN.Visible = false;
                        btnDespatch.Visible = false;
                        btnUsers.Visible = false;
                        btSalesOfficeReport.Visible = false;
                        btnStockReport.Visible = false;
                        btnOutstanding.Visible = false;
                        btnInvoices.Visible = false;
                        btnSalesOrders.Enabled = false;
                        if (title.ToString() == "Store Manager")
                        {
                            userPrem = true;
                            btnSalesOrders.Visible = false;
                            btnOutstanding.Visible = false;
                            btnPurchases.Visible = true;
                            btnInvoices.Visible = false;
                            btnGRN.Visible = false;
                            btnDespatch.Visible = false;
                            btnStockReport.Visible = true;
                            btSalesOfficeReport.Visible = false;
                            btnAdmin.Visible = true;
                            btnUsers.Visible = true;

                        }

                    }
                    else if (title.Substring(0, 8) == "Despatch")
                    {
                        btnAdmin.Visible = false;
                        btnPurchases.Visible = false;
                        btnGRN.Visible = false;
                        btnUsers.Visible = false;
                        btSalesOfficeReport.Visible = false;
                        btnStockReport.Visible = false;
                        btnOutstanding.Visible = false;
                        btnSalesOrders.Enabled = false;
                        btnItems.Visible = false;
                        btnOrderAssembly.Visible = false;
                        if (title == "Despatch Manager")
                        {
                            userPrem = true;
                            btnAdmin.Visible = true;
                            btnUsers.Visible = true;
                        }

                    }
                    else if (title.Substring(0, 4) == "Good")
                    {
                        btnAdmin.Visible = false;
                        btnSalesOrders.Visible = false;
                        btnUsers.Visible = false;
                        btSalesOfficeReport.Visible = false;
                        btnStockReport.Visible = false;
                        btnOutstanding.Visible = false;
                        btnInvoices.Visible = false;
                        btnItems.Visible = false;
                        btnDespatch.Visible = false;
                        btnOrderAssembly.Visible = false;
                        if (title == "Good Inwards Manager")
                        {
                            userPrem = true;
                            btnAdmin.Visible = true;
                            btnUsers.Visible = true;
                        }
                    }
                    else if (title == "Administrator") { userPrem = true; return; }
                    else
                    {
                        btnAdmin.Visible = false;
                        btnSalesOrders.Visible = false;
                        btnOutstanding.Visible = false;
                        btnInvoices.Visible = false;
                        btnItems.Visible = false;
                        btnOrderAssembly.Visible = false;
                        btnDespatch.Visible = false;
                        btnPurchases.Visible = false;
                        btnGRN.Visible = false;
                        btSalesOfficeReport.Visible = false;
                        btnStockReport.Visible = false;
                        lblUsername.Text = "Error";
                    }
                }
            }
            catch { }

        }

        void navigation(Form form)
        {
            form.TopLevel = false;
            form.Size = plMain.Size;
            plMain.Controls.Clear();
            plMain.Controls.Add(form);
            form.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (plNav.Visible)
            {
                hidNav.HideSync(plNav);
                this.Width = formWidth - plNav.Width + 3;

            }
            else
            {
                showNav.ShowSync(plNav);
                this.Width = formWidth;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            objControlller.Loglogout(userID);
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            navigation(dashboard);
            setSubTitleLoca("Dashboard");
        }

        private void btnSalesOrders_Click(object sender, EventArgs e)
        {
            try
            {
                salesOrder = new SalesOrder(userName, userPrem, userID);
                navigation(salesOrder);
                setSubTitleLoca("Sales Order");
            }
            catch { }
        }



        private void btnStockReport_Click(object sender, EventArgs e)
        {
            try
            {
                stockReport = new StockRecordReport(userID);
                navigation(stockReport);
                setSubTitleLoca("Report");
            }
            catch { }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                users = new Users(userID);
                navigation(users);
                setSubTitleLoca("Users");
            }
            catch { }
        }

        private void btnDespatch_Click(object sender, EventArgs e)
        {
            try
            {
                despatch = new Despatch(userID, userPrem);
                navigation(despatch);
                setSubTitleLoca("Despatch");
            }
            catch { }
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            try
            {
                purchases = new Purchases();
                navigation(purchases);
                setSubTitleLoca("Purchases");
            }
            catch { }
        }

        private void btnOrderAssembly_Click(object sender, EventArgs e)
        {
            try
            {
                orderAssembly = new OrderAssembly(userPrem, userID);
                navigation(orderAssembly);
                setSubTitleLoca("Order Assembly");
            }
            catch { }
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            try
            {
                item = new Item(userID, userPrem);
                navigation(item);
                setSubTitleLoca("Items");
            }
            catch { }
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            try
            {
                invoice = new Invoice(userID, userPrem);
                navigation(invoice);
                setSubTitleLoca("Sales  >  Invoices");
            }
            catch { }
        }

        private void btnOutstanding_Click(object sender, EventArgs e)
        {
            try
            {
                outstanding = new Outstanding(userName, userPrem);
                navigation(outstanding);
                setSubTitleLoca("Sales Order  >  Outstanding");
            }
            catch { }
        }

        public void setSubTitleLoca(string loc)
        {
            lblFormLoc.Text = loc;
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            try
            {
                admin = new Admin(userID);
                navigation(admin);
                setSubTitleLoca("Administrator");
            }
            catch { }
        }

        private void btSalesOfficeReport_Click(object sender, EventArgs e)
        {
            try
            {
                salesReport = new SalesOfficeReport(userID);
                navigation(salesReport);
                setSubTitleLoca("Sales Order Office Report");
            }
            catch { }
        }

        private void BtnGRN_Click(object sender, EventArgs e)
        {
            try
            {
                grn = new GRN(userID, userPrem);
                navigation(grn);
                setSubTitleLoca("Purchases > Good Received Note");
            }
            catch { }
        }
    
    }
}
