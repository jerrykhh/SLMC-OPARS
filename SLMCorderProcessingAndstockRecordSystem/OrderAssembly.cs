using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OrderAssembly : Form
    {

        private SalesOrder main;
        private Assembly assembly;
        private bool userPrem;
        private ViewOrder viewOrder;
        private Logic.Controller.Controller objControlller;
        private string orderID;
        private string userID;
        private int index = -1;
        private OrderReturn orderReturn;

        public OrderAssembly(bool userPrem, string userID)
        {
            this.userPrem = userPrem;
            this.userID = userID;
            InitializeComponent();
            main = new SalesOrder();
            objControlller = new Logic.Controller.Controller();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {

            try
            {
                if (index == -1)
                    throw new IndexOutOfRangeException();
                assembly = new Assembly(orderID, userID, true);

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Select Message");
                return;
            }
            assembly.ShowDialog();

        }

        private void plFilTo_Paint(object sender, PaintEventArgs e)
        {
            main.plColorChage(Pens.Gray, e);
        }

        private void plFilFrom_Paint(object sender, PaintEventArgs e)
        {
            main.plColorChage(Pens.Gray, e);
        }

        private void plStatus_Paint(object sender, PaintEventArgs e)
        {
            main.plColorChage(Pens.Gray, e);
        }

        private void pldgOrderAssembly_Paint(object sender, PaintEventArgs e)
        {
            main.plColorChage(Pens.Gray, e);
        }

        private void btnOrderAssembly_Click(object sender, EventArgs e)
        {
            try
            {
                if (index <= -1)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    assembly = new Assembly(orderID, userID, false);
                    assembly.ShowDialog();
                    if(assembly.formClose)
                        dgOrderAssembly.DataSource = objControlller.getSalesOrderAllData();

                }

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Please select the order");
            }

        }

        /* if (objController.deleteRecordInv(invoiceID))
            {
                objController.LogdeleteRecordInv(userID, invoiceID);
                InvoiceLoad();
    }
            else
            {
                MessageBox.Show("Delete Invoice " + invoiceID + " Fail");
            }   */

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            DialogResult mesBox = MessageBox.Show("Do you want to delete " + orderID + " ?", "Delete Item", MessageBoxButtons.YesNo);
            switch (mesBox)
            {
                case DialogResult.Yes:
                    if (objControlller.deleteMessage(orderID))
                        dgOrderAssembly.DataSource = objControlller.Mermessage();
                    break;
                case DialogResult.No:
                    break;
            }
        }


        private void BtnFilter_Click_1(object sender, EventArgs e)
        {
            string formDate = DpFrom.Value.Date.ToString("yyyy-MM-dd");
            string toDate = DpTo.Value.Date.ToString("yyyy-MM-dd");

            if (ddStatus.SelectedIndex == -1)
            { //ddStatus attribute not inside table yet
                dgOrderAssembly.DataSource = objControlller.DateAroundFilterOrderAssembly(formDate, toDate);

            }
            else
            {
                string status = ddStatus.Text;
                dgOrderAssembly.DataSource = objControlller.DateStatusFilterOrderAssembly(formDate, toDate, status);
            }
        }

        private void OrderAssembly_Load(object sender, EventArgs e)
        {
            dgOrderAssembly.DataSource = objControlller.getSalesOrderAllData();
            if (!userPrem)
            {
                plCreateOrder.Visible = false;
                btnExpand.Visible = false;
                btnOrderReturn.Visible = false;
            }
        }

        private void DgOrderAssembly_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgOrderAssembly.Rows[index];
                orderID = selectRow.Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            string textExport = "";
            int countRows = dgOrderAssembly.RowCount;
            int countCells = dgOrderAssembly.Rows[0].Cells.Count;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = path + "\\orderAssembly.csv";

            for (int row_index = 0; row_index < dgOrderAssembly.RowCount; row_index++)
            {
                Debug.WriteLine(row_index);
                for (int cell_index = 0; cell_index < countCells; cell_index++)
                {
                    Debug.WriteLine(cell_index);

                    textExport = textExport + dgOrderAssembly.Rows[row_index].Cells[cell_index].Value.ToString() + ", ";
                    Debug.WriteLine(textExport);
                }
                textExport += "\r\n";
            }
            System.IO.File.WriteAllText(filepath, textExport);
            objControlller.LogABC(userID);
            MessageBox.Show("Your orderAssembly form being exported on desktop");
        }

        private void btnOrderReturn_Click(object sender, EventArgs e)
        {

            orderReturn = new OrderReturn(userID);
            orderReturn.ShowDialog();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgOrderAssembly.DataSource = objControlller.getSalesOrderAllData();
        }
    }
}
