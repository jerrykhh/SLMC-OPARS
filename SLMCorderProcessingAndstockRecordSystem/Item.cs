using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Item : Form
    {
        private AddItem addItem;
        private EditItem editItem;
        private bool userPrem;
        private Logic.Controller.Controller objController;
        private string itemID;
        private string userID;
        private int index = -1;
        public Item(string userID, bool userPrem)
        {
            InitializeComponent();
            this.userPrem = userPrem;
            this.userID = userID;
            objController = new Logic.Controller.Controller();
            if (objController.getTitleUseID(userID) == "Store Manager")
            {
                btnAddItem.Visible = true;
                plCreateOrder.Visible = true;
            }
        }
        private void Item_Load(object sender, EventArgs e)
        {
            itemLoad();
            if (!userPrem)
            {
                btnDelOrder.Visible = false;
                btnEditOrder.Visible = false;
                btnAddItem.Visible = false;
                plCreateOrder.Visible = false;
            }
            else
            {
                btnAddItem.Visible = true;
                btnAddItem.Visible = true;
                plCreateOrder.Visible = true;
                plCreateOrder.Visible = true;
            }

        }
        private void itemLoad()
        {
            dgItem.DataSource = objController.getItem();
            itemAnaLoad();
        }
        private void itemAnaLoad()
        {
            lblDataNoOfItem.Text = dgItem.RowCount.ToString();
            string[] ItemAnal = objController.getItemAnal(dgItem);
            lblDataQty.Text = ItemAnal[0];
            lblDataCostVal.Text = ItemAnal[1];
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            addItem = new AddItem(userID);
            addItem.ShowDialog();
            if (addItem.formClose)
                itemLoad();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            editItem = new EditItem(userID, itemID);
            editItem.ShowDialog();
            if (editItem.formClose)
            {
                itemLoad();
                dgItem.Rows[index].Selected = true;
            }
        }

        private void pldgItem_Paint(object sender, PaintEventArgs e)
        {
            SalesOrder main = new SalesOrder();
            main.plColorChage(Pens.Gray, e);
        }

        private void BtnDelOrder_Click(object sender, EventArgs e)
        {
            DialogResult mesBox = MessageBox.Show("Do you want to delete " + itemID + " ?", "Delete Item", MessageBoxButtons.YesNo);
            switch (mesBox)
            {
                case DialogResult.Yes:
                    if (objController.deleteItemRecord(itemID))
                    {
                        objController.LogdeleteItemRecord(userID, itemID);
                        itemLoad();
                    }
                    else
                        MessageBox.Show("Delete Fail, the Item have the Order reference");
                    break;
                case DialogResult.No:
                    break;
            }


        }

        private void DgItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectRow = dgItem.Rows[index];
                itemID = selectRow.Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void Item_Shown(object sender, EventArgs e)
        {
            dgItem.ClearSelection();
            lblTotalEntr.Text = "Showing " + dgItem.RowCount.ToString() + " Enteries";
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                itemLoad();
            }
            else
            {
                dgItem.DataSource = objController.searchItem(txtSearch.Text.Trim());
                itemAnaLoad();
            }
        }
    }
}
