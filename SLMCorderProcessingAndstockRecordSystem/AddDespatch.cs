using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using Logic.Controller;
using MaterialSkin.Controls;
using MaterialSkin;

namespace WindowsFormsApplication1
{
    public partial class AddDespatch : MaterialForm
    {
        public bool formClose;
        private string userID;
        private Controller objController;
        public AddDespatch(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            objController = new Controller();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            Closing += new CancelEventHandler(AddDespatch_Closing);
        }

        private void AddDespatch_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            formClose = true;
        }



        private void AddDespatch_Load(object sender, EventArgs e)
        {
            //// DataTable result = objController.getDespatch(orderID);
            /////  txtOrderID.Text = result.Rows[0]["orderID"].ToString();
            ////  txtDeliveryID.Text = result.Rows[0]["deliveryID"].ToString();
            ///  txtInvoiceID.Text = result.Rows[0]["invoiceID"].ToString();
            dateRecDate.Value = DateTime.Now.Date;
            //  dateRecDate.Value = result.Rows[0]["deliveryDate"].();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable result = objController.insertDelivery(txtOrderID.Text.Trim(), dateRecDate.Value.Date.ToString());

                if (result.Rows.Count > 0)
                {
                    
                    txtOrderID.Text = "";
                    txtDeliveryID.Text = result.Rows[0][0].ToString();
                    txtInvoiceID.Text = result.Rows[0][1].ToString();
                    objController.LoginsertDelivery(userID, txtDeliveryID.Text);
                    //dateRecDate.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Input Wrong");
                }
            }
            catch
            {
                MessageBox.Show("Order Not Invoice");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
