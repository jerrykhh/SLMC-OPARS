using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using DataAccess.DAL;
using System.Data;
using System.Diagnostics;
using Bunifu.Framework.UI;
using System.Collections;

namespace Logic.Controller
{

    class Controller
    {
        DAL objDataAccess;
        public Controller()
        {
            objDataAccess = new DAL();
        }
        public void test()
        {
            objDataAccess.insertTest();
        }

        public DataTable getSalesOrderAllData()
        {
            return objDataAccess.getSalesOrder();
        }
        public DataTable getItem()
        {
            return objDataAccess.getItem();
        }

        public bool getPermission(string username)
        {
            if (objDataAccess.getTitle(username).Equals("Administrator"))
                return true;
            else
                return false;
        }

        public DataTable DateStatusFilterSalOrd(string startDate, string EndDate, string status)
        {
            return objDataAccess.getDateStaFilterSalOrd(startDate, EndDate, status);
        }
        public DataTable getInvoice()
        {
            return objDataAccess.getInvoice();
        }

        public DataTable DateFilterInv(string startDate, string EndDate)
        {
            return objDataAccess.getDateFIlterInv(startDate, EndDate);
        }
        public DataTable DateAroundFilter(string startDate, string EndDate)
        {
            return objDataAccess.getDateFilterSalOrd(startDate, EndDate);
        }
        public DataTable DateFilterOutstand(string formDate, string toDate)
        {
            return objDataAccess.DateFilterOutstand(formDate, toDate);
        }

        public bool verityUser(String username, String password)
        {
            try
            {
                password = encryptPwd(password);
                if (password == objDataAccess.getPassword(username))
                {
                    return true;
                }
            }
            catch
            { }
            return false;
        }

        private string encryptPwd(String password)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            byte[] source = Encoding.Default.GetBytes(password);
            byte[] crypto = sha256.ComputeHash(source);
            string entcyPassword = Convert.ToBase64String(crypto);
            return entcyPassword;
        }

        public bool deleteRecord(String orderID)
        {
            return objDataAccess.deleteSalesOrder(orderID);
        }
        public string[] getItemAnal(BunifuCustomDataGrid dgItem)
        {
            int qty = 0;
            float costValue = 0;
            String[] conis = new String[2];

            for (int i = 0; i < dgItem.RowCount; i++)
            {
                qty += (int)dgItem.Rows[i].Cells["quantityInStock"].Value;
                costValue += (float)((decimal)dgItem.Rows[i].Cells["salesPrice"].Value * (int)dgItem.Rows[i].Cells["quantityInStock"].Value);
            }
            conis[0] = qty.ToString();
            conis[1] = costValue.ToString("C");

            return conis;
        }

        public DataTable DataFilterReportItem(string cat)
        {
            return objDataAccess.DataFilterReportItem(cat);
        }

        public DataTable getReportItem(string keyword)
        {
            return objDataAccess.getReportItem(keyword);
        }


        public string[] getReportAnal(BunifuCustomDataGrid dgData)
        {
            string[] val = new string[3];
            int qty = 0;
            float costValue = 0;
            val[0] = dgData.Rows.Count.ToString();
            for(int i=0; i < dgData.Rows.Count; i++)
            {
                qty += (int)dgData.Rows[i].Cells["quantityInStock"].Value;
                costValue += (float)((decimal)dgData.Rows[i].Cells["salesPrice"].Value * (int)dgData.Rows[i].Cells["quantityInStock"].Value);
            }
            val[1] = qty.ToString();
            val[2] = costValue.ToString("C");
            return val;
        }

        public bool deleteItemRecord(String itemID)
        {
            return objDataAccess.deleteItem(itemID);
        }

        public bool deleteRecordInv(String invoiceID)
        {
            return objDataAccess.deleteInvoice(invoiceID);
        }
        public DataTable orderDetail(String orderID)
        {
            return objDataAccess.getOrderDetail(orderID);
        }
        public DataTable invoiceDetail(String invoceID)
        {
            return objDataAccess.getInvoiceDetail(invoceID);
        }
        public DataTable orderItemDetail(string orderId)
        {
            return objDataAccess.getOrderItemDetail(orderId);
        }
        public string orderStatus(String orderId)
        {
            return objDataAccess.getOrderStatus(orderId);
        }
        public bool insertOrder(String orderID, String itemID, String qtyOrdered, String salePrice)
        {
            return objDataAccess.insertOrder(orderID, itemID, qtyOrdered, salePrice);
        }
        public void orderDelete(String orderID)
        {
            objDataAccess.orderDelete(orderID);
        }
        public void updateDealer(String dealerID, String dealerName, String contactName, String contactNumber, String Email, String postcode, String city, String Address, String status, String orderID)
        {
            var name = contactName.Split(' ');
            objDataAccess.updateDealer(dealerID, dealerName, name[0], name[1], contactNumber, Email, city, postcode, Address);
            objDataAccess.updateOrderStatus(status, orderID);
        }
        public bool updateItem(string itemID, string itemName, string purPrice, string wareHouse, string quantityInStock, string Hold, string Description, string status, string itemCategory, string salesPrice, string reorderLevel, string dangerlevel, string autoPur, string demand)
        {
            return objDataAccess.updateItem(itemID, itemName, purPrice, wareHouse, quantityInStock, Hold, Description, status, itemCategory, salesPrice, reorderLevel, dangerlevel, autoPur, demand);
        }
        public bool insertItem(string userID, string itemName, string purPrice, string wareHouse, string quantityInStock, string Hold, string Description, string status, string itemCategory, string salesPrice, string reorderLevel, string dangerlevel, string autoPur, string demand)
        {
            string itemID = itemCategory[0] + (int.Parse(objDataAccess.getItemID(itemCategory[0]).Substring(1)) + 1).ToString("00000");

            while (!objDataAccess.insertItem(itemID, itemName, purPrice, wareHouse, quantityInStock, Hold, Description, status, itemCategory, salesPrice, reorderLevel, dangerlevel, autoPur, demand))
            {
                itemID = itemID = itemCategory[0] + (int.Parse(objDataAccess.getItemID(itemCategory[0]).Substring(1)) + 1).ToString("00000");

            }
            LoginsertItem(userID, itemID);
            return true;

        }



        public DataTable getItemDetail(string itemID)
        {
            return objDataAccess.getItemDetail(itemID);
        }

        public DataTable searchOrder(string keyword)
        {
            return objDataAccess.getSearchOrder(keyword);
        }
        public DataTable getItemCategory()
        {
            return objDataAccess.getItemCategory();
        }
        public DataTable searchItem(string keyword)
        {
            return objDataAccess.getSearchItem(keyword);
        }
        public DataTable searchInvoice(string keyword)
        {
            return objDataAccess.getSearchInvoice(keyword);
        }
        public string getTitle(string username)
        {
            return objDataAccess.getTitle(username);
        }

        public string getTitleUseID(string userID)
        {
            return objDataAccess.getTitleUseID(userID);

        }

        public DataTable getOutStanding()
        {
            return objDataAccess.getOutStanding();
        }

        public DataTable searchOutStanding(string keyword)
        {
            return objDataAccess.getSearchOutStanding(keyword);
        }
        public bool deleteOutRecord(string id)
        {
            return objDataAccess.deleteOutRecord(id);
        }
        public DataTable getOutStanding(string outsID)
        {
            return objDataAccess.getOutStandingOrder(outsID);
        }
        public DataTable getOrderItem(string orderID)
        {
            return objDataAccess.getInvOrderItemDetail(orderID);
        }
        public DataTable searchPurchases(string keyword)
        {
            return objDataAccess.searchPurchases(keyword);
        }
        public DataTable DateFilterPur(string sDate, string eDate)
        {
            return objDataAccess.DateFilterPur(sDate, eDate);
        }
        public DataTable getPurchases()
        {
            return objDataAccess.getPurchases();
        }
        public DataTable getDespatch()
        {
            return objDataAccess.getDespatch();
        }

        public DataTable getDespatch(string orderID)
        {
            return objDataAccess.getDespatch(orderID);
        }
        public DataTable getDespatch(string orderID, string deliveryID, string invoiceID)
        {
            return objDataAccess.getDespatch(orderID, deliveryID, invoiceID);
        }

        public DataTable DateFilterDepatch(string sDate, string eDate)
        {
            return objDataAccess.DateFilterDepatch(sDate, eDate);
        }
        public DataTable searchDespatch(string keyword)
        {
            return objDataAccess.getSearchDespatch(keyword);
        }
        public DataTable getGRN()
        {
            return objDataAccess.getGRN();
        }
        public DataTable DateFilterGRN(string sDate, string eDate)
        {
            return objDataAccess.DateFilterGRN(sDate, eDate);
        }
        public DataTable searchGRN(string keyword)
        {
            return objDataAccess.searchGRN(keyword);
        }
        public bool insertGRN(string purID, string itemID, string recQty, string Loca, string date)
        {
            DataTable cache = new DataTable();
            if (objDataAccess.getGRN().Rows.Count == 0)
            {
                objDataAccess.insertGRN("00001", recQty, Loca, date, itemID, purID);
            }
            else
            {
                cache = objDataAccess.getDupGRNID();
                foreach (DataRow row in cache.Rows)
                {
                    if (row["purchaseID"].ToString() == purID && row["itemID"].ToString() == itemID)
                        return false;
                }
                string grnID = (((int.Parse(objDataAccess.getGRNID())) + 1).ToString("00000"));
                while (!objDataAccess.insertGRN(grnID, recQty, Loca, date, itemID, purID))
                {
                    grnID = (((int.Parse(objDataAccess.getGRNID())) + 1).ToString("00000"));
                }
            }
            if (int.Parse(objDataAccess.getPurchaseOrderedQty(purID)) == int.Parse(recQty))
            {

                if (objDataAccess.updatePurchaseOrder(purID, "Recevied"))
                {
                    objDataAccess.updateItemStatus(itemID, "Available");
                    return true;
                }
            }
            else
            {
                if (objDataAccess.updatePurchaseOrder(purID, "Outstanding"))
                {
                    objDataAccess.updateItemStatus(itemID, "Available");
                    return true;
                }
            }
            return false;
            

        }
        public void Addstock(string itemID, string qty)
        {
            int addQty = int.Parse(qty);
            objDataAccess.AddStock(itemID, addQty);
        }
        public void ReduceStock(string itemID, string qty)
        {
            int reduceQty = int.Parse(qty);
            objDataAccess.ReduceStock(itemID, reduceQty);
        }
        public bool deleteGRNRecord(string grnID)
        {
            return objDataAccess.deleteGRNRecord(grnID);
        }
        public bool insertOrderReturn(string orderID)
        {
            DataTable cache = new DataTable();
            cache = objDataAccess.getOrderReturn(orderID);
            foreach (DataRow row in cache.Rows)
            {
                insertOrderReturn(orderID, row["itemID"].ToString(), row["actualQty"].ToString());
            }
            return true;
        }
        public bool insertOrderReturn(string orderID, string itemID, string qty)
        {
            return objDataAccess.insertOrderReturn(orderID, itemID, qty);
        }
        public DataTable getOrderReturn()
        {
            return objDataAccess.getOrderReturn();
        }
        public DataTable searchOrderReturn(string keyword)
        {
            return objDataAccess.searchOrderReturn(keyword);
        }
        public DataTable getUserInf()
        {
            return objDataAccess.getUserInf();
        }
        public DataTable getUserLog()
        {
            return objDataAccess.getUserLog();
        }

        public DataTable DataFilterUserInf(string username)
        {
            return objDataAccess.DataFilterUserInf(username);
        }
        public DataTable DataFilterUserInf(string dept, int i)
        {
            return objDataAccess.DataFilterUserInf(dept, i);
        }
        public DataTable DataFilterUserInf(string username, string dept)
        {
            return objDataAccess.DataFilterUserInf(username, dept);
        }
        public DataTable DataFilterUserLog(string username)
        {
            return objDataAccess.DataFilterUserLog(username);
        }
        public DataTable DataFilterUserLog(string username, int i)
        {
            return objDataAccess.DataFilterUserLog(username, i);
        }
        public DataTable DataFilterUserLog(string username, string dept)
        {
            return objDataAccess.DataFilterUserLog(username, dept);
        }
        public DataTable searchUserInf(string keyword)
        {
            return objDataAccess.searchUserInf(keyword);
        }
        public DataTable getUserInf(string userID)
        {
            return objDataAccess.getUserInf(userID);
        }
        public bool updateUserInf(string userID, string userName, string userPassword, string userPwd, string deptName, string title)
        {
            if (userPassword != userPwd)
                return false;
            string deptID = objDataAccess.getDeptID(deptName);
            return objDataAccess.updateUserInf(userID, userName, userPassword, deptID, title);



        }
        public DataTable searchUserLog(string keyword)
        {
            return objDataAccess.searchUserLog(keyword);
        }
        public DataTable getDept()
        {
            return objDataAccess.getDept();
        }
        public bool insertUser(string username, string pwd, string pwdAg, string dept, string title)
        {
            if (pwd != pwdAg)
                return false;
            string password = encryptPwd(pwd);
            string deptID = objDataAccess.getDeptID(dept);
            string userID = "user-" + (int.Parse(objDataAccess.getUserID()) + 1).ToString("000");
            while (!objDataAccess.insertUser(userID, username, password, deptID, title))
            {
                userID = "user-" + (int.Parse(objDataAccess.getUserID()) + 1).ToString("000");
            }
            return true;
        }

        public string getUserID(string userName)
        {
            return objDataAccess.getUserID(userName);
        }
        public void itemAutoComplete(TextBox txtsearch)
        {
            DataTable result = objDataAccess.getItemIDAndItemName();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                txtsearch.AutoCompleteCustomSource.Add(result.Rows[i]["itemID"].ToString());
                txtsearch.AutoCompleteCustomSource.Add(result.Rows[i]["itemName"].ToString());
            }
        }
        public float dgCalutoritemTotalAmount(DataGridView dg)
        {
            float sum = 0;
            try
            {
                
                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    sum += (int.Parse(dg.Rows[i].Cells[2].Value.ToString())) * (float.Parse(dg.Rows[i].Cells[3].Value.ToString()));
                }
            }
            catch
            {
                MessageBox.Show("Please input number");
                return 0;
            }
            return sum;
        }
        public DataTable searchDealerDetail(string dealerID)
        {
            return objDataAccess.searchDealerDetail(dealerID);
        }
        public bool searchDealerID(string keyword)
        {
            if (objDataAccess.searchDealerID(keyword) == keyword)
                return true;
            else
                return false;
        }
        public bool getItem(string keyword)
        {
            if (objDataAccess.searchItemIDOrder(keyword) == keyword || objDataAccess.searchItemNameOrder(keyword) == keyword)
                return true;
            else
                return false;
        }
        public string createSalesOrder(string dealerID, string dealerName, String contactName, string contactNumber, string Email, string Address, string city, string postcode, DataGridView dgOrder, bool hold, string description)
        {
            var name = contactName.Split(' ');
            if (dealerID == "" || !objDataAccess.updateDealer(dealerID, dealerName, name[0], name[1], contactNumber, Email, city, postcode, Address))
            {
                dealerID = (((int.Parse(objDataAccess.getDealerID()) + 1).ToString("0000000")));
                while (!objDataAccess.addDealer(dealerID, dealerName, name[0], name[1], contactNumber, Email, city, postcode, Address))
                {
                    dealerID = (((int.Parse(objDataAccess.getDealerID()) + 1).ToString("0000000")));
                }
            }
            string orderID = "SO-" + (int.Parse(objDataAccess.getOrderID()) + 1).ToString("00000000");
            while (!objDataAccess.insertSalesOrder(orderID, hold, description, "Processing", dealerID))
            {
                orderID = "SO-" + (int.Parse(objDataAccess.getOrderID()) + 1).ToString("00000000");
            }
            if (!hold)
            {
                for (int i = 0; i < dgOrder.Rows.Count; i++)
                {
                    objDataAccess.insertOrderItem(orderID, dgOrder.Rows[i].Cells[0].Value.ToString(), 0, dgOrder.Rows[i].Cells[2].Value.ToString(), dgOrder.Rows[i].Cells[3].Value.ToString());
                    objDataAccess.updateOrderItemDemond(dgOrder.Rows[i].Cells[0].Value.ToString(), (int.Parse(dgOrder.Rows[i].Cells[2].Value.ToString())));
                }
            }
            else
            {
                for (int i = 0; i < dgOrder.Rows.Count; i++)
                {
                    objDataAccess.insertOrderItem(orderID, dgOrder.Rows[i].Cells[0].Value.ToString(), 0, dgOrder.Rows[i].Cells[2].Value.ToString(), dgOrder.Rows[i].Cells[3].Value.ToString());
                    objDataAccess.updateOrderItemHold(dgOrder.Rows[i].Cells[0].Value.ToString(), (int.Parse(dgOrder.Rows[i].Cells[2].Value.ToString())));
                }

            }

            return orderID;
        }






        ///Coding Start
        public DataTable searchOrderItemDetail(string keyword)
        {
            return objDataAccess.searchOrderItemDetail(keyword);
        }
        public DataTable getOrderItemDetail(string orderID)
        {
            return objDataAccess.getOrderItemDetailforAsb(orderID);
        }
        public bool searchOrderEachItemDetail(string itemID, string orderID)
        {
            DataTable result = objDataAccess.searchOrderEachItemDetail(orderID);
            ArrayList checkList = new ArrayList();
            Debug.WriteLine("CONtroller result Rows" + result.Rows.Count);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                if (itemID == result.Rows[i]["itemID"].ToString())
                {
                    checkList.Add(true);
                }
            }
            if (checkList.Contains(true))
                return true;
            else
                return false;
        }
        public DataTable getOrderEachItemDetail(string itemID, string orderID)
        {
            return objDataAccess.getOrderEachItemDetail(itemID, orderID);
        }
        public void updateOrderHold(string orderID)
        {
            
            DataTable result =  objDataAccess.getOrderDetail(orderID);
            DataTable itemRs = objDataAccess.getOrderItemDetail(orderID);
            Debug.WriteLine(result.Rows[0]["orderHold"].ToString());
            
           if (result.Rows[0]["orderHold"].ToString()=="True")
            {
                for(int i =0;i< itemRs.Rows.Count; i++)
                {
                    Debug.WriteLine("TEST1");
                    objDataAccess.updateReduceOrderItemHold(itemRs.Rows[i]["itemID"].ToString(),  int.Parse(itemRs.Rows[i]["qtyOrdered"].ToString()));
                    objDataAccess.updateOrderItemDemond(itemRs.Rows[i]["itemID"].ToString(), int.Parse(itemRs.Rows[i]["qtyOrdered"].ToString()));
                }
            }
            else
            {
                for (int i = 0; i < itemRs.Rows.Count; i++)
                {
                    Debug.WriteLine("TEST2");
                    objDataAccess.updateIncOrderItemHold(itemRs.Rows[i]["itemID"].ToString(), int.Parse(itemRs.Rows[i]["qtyOrdered"].ToString()));
                    objDataAccess.updateReduceOrderItemDemond(itemRs.Rows[i]["itemID"].ToString(), int.Parse(itemRs.Rows[i]["qtyOrdered"].ToString()));
                }
            }
            objDataAccess.updateOrderHold(orderID);
        }
        public bool createOrderAsswmbly(DataGridView dgData, DataGridView dgInvoice, string orderID)
        {

            for (int i = 0; i < dgData.Rows.Count; i++)
            {
                if(int.Parse(objDataAccess.getItemInStoc(dgData.Rows[i].Cells[0].Value.ToString())) > int.Parse(objDataAccess.getItemDanger((dgData.Rows[i].Cells[0].Value.ToString()))))
                {
                    objDataAccess.updateItemStatus(dgData.Rows[i].Cells[0].Value.ToString(), "Available");
                }
                if (int.Parse(objDataAccess.getItemInStoc(dgData.Rows[i].Cells[0].Value.ToString())) <= (int.Parse(objDataAccess.getItemReorderlevel((dgData.Rows[i].Cells[0].Value.ToString())))))
                {
                    objDataAccess.updateItemStatus(dgData.Rows[i].Cells[0].Value.ToString(), "Re-order");
                }

                if (int.Parse(objDataAccess.getItemInStoc(dgData.Rows[i].Cells[0].Value.ToString())) <= (int.Parse(objDataAccess.getItemDanger((dgData.Rows[i].Cells[0].Value.ToString())))))
                {
                    objDataAccess.updateItemStatus(dgData.Rows[i].Cells[0].Value.ToString(), "Danger");
                }
                if (int.Parse(objDataAccess.getItemInStoc(dgData.Rows[i].Cells[0].Value.ToString()))==0 ){
                    objDataAccess.updateItemStatus(dgData.Rows[i].Cells[0].Value.ToString(), "Out-Of-Stock");
                }


                


                if (int.Parse(dgData.Rows[i].Cells[2].Value.ToString()) < int.Parse(dgData.Rows[i].Cells[3].Value.ToString()))
                {
                    string sum = ((int.Parse(dgData.Rows[i].Cells[3].Value.ToString()) - (int.Parse(dgData.Rows[i].Cells[2].Value.ToString())))).ToString();


                    string oustID = "OU-" + (int.Parse(objDataAccess.getOutStandingID()) + 1).ToString("000000");
                    while (!objDataAccess.insertOutstanding(oustID, orderID, dgData.Rows[i].Cells[0].Value.ToString(), sum, objDataAccess.getDealerIDForAssm(orderID)))
                    {
                        oustID = "OU-" + (int.Parse(objDataAccess.getOutStandingID()) + 1).ToString("000000");
                    }

                    if (int.Parse(objDataAccess.getItemInStoc(dgData.Rows[i].Cells[0].Value.ToString())) < 0)
                        objDataAccess.setDefualtInStock(dgData.Rows[i].Cells[0].Value.ToString());
                }
                if (int.Parse(objDataAccess.getItemInStoc(dgData.Rows[i].Cells[0].Value.ToString())) < int.Parse(objDataAccess.getItemReorderLev(dgData.Rows[i].Cells[0].Value.ToString())))
                {
                    if (int.Parse(objDataAccess.searchPurchasesItem(dgData.Rows[i].Cells[0].Value.ToString())) < 1)
                    {
                        string PurID = "PUR-" + (int.Parse(objDataAccess.getPurchasesID()) + 1).ToString("000000");
                        while (!objDataAccess.insertPurchase(PurID, dgData.Rows[i].Cells[0].Value.ToString(), objDataAccess.getItemAutoPur(dgData.Rows[i].Cells[0].Value.ToString()), "In Procurement"))
                        {
                            PurID = "PUR-" + (int.Parse(objDataAccess.getPurchasesID()) + 1).ToString("000000");
                        }
                    }
                }
                Debug.WriteLine("TESTSETESTESTESRTESTESTESTSETESTESTSETSETSETESTSET");
                objDataAccess.updateItemInStock(dgData.Rows[i].Cells[0].Value.ToString(), dgData.Rows[i].Cells[2].Value.ToString());
                objDataAccess.updateOrderItem(orderID, dgData.Rows[i].Cells[0].Value.ToString(), dgData.Rows[i].Cells[2].Value.ToString());
            }
            if (dgData.RowCount != 0)
            {
                string invoiceID = "INV-" + (int.Parse(objDataAccess.getInvoiceID()) + 1).ToString("00000000");
                while (!objDataAccess.insetInvoice(invoiceID, orderID, objDataAccess.getDealerIDForAssm(orderID)))
                {
                    invoiceID = "INV-" + (int.Parse(objDataAccess.getInvoiceID()) + 1).ToString("00000000");
                }
            }
            Debug.WriteLine(dgData.RowCount);
            Debug.WriteLine(dgInvoice.RowCount);
            if (dgData.RowCount == 0)
            {

                    Debug.WriteLine("TEST POIN0");
                    for (int j = 0; j < dgInvoice.RowCount; j++)
                    {
                            Debug.WriteLine("TEST POIN1");
                            Debug.WriteLine("TEST POIN2");
                            string oustID = "OU-" + (int.Parse(objDataAccess.getOutStandingID()) + 1).ToString("000000");
                            while (!objDataAccess.insertOutstanding(oustID, orderID, dgInvoice.Rows[j].Cells[0].Value.ToString(), dgInvoice.Rows[j].Cells[3].Value.ToString(), objDataAccess.getDealerIDForAssm(orderID)))
                            {
                                oustID = "OU-" + (int.Parse(objDataAccess.getOutStandingID()) + 1).ToString("000000");
                            }
                        }
                    
                }else if (dgData.RowCount < dgInvoice.RowCount)
            {
                Debug.WriteLine("TEST ELSE");
                for (int i=0; i < dgInvoice.RowCount; i++)
                {
                    Debug.WriteLine("TEST POIN0");
                    int count = 0;
                    for (int j = 0;  j < dgData.RowCount; j++){
                        Debug.WriteLine("TEST POIN1");
                        if(dgInvoice.Rows[i].Cells[0].Value.ToString()!= dgData.Rows[j].Cells[0].Value.ToString())
                        {
                            count++;
                        }
                        if (count == dgData.RowCount-1)
                        {
                            Debug.WriteLine("TEST POIN2");
                            string oustID = "OU-" + (int.Parse(objDataAccess.getOutStandingID()) + 1).ToString("000000");
                            while (!objDataAccess.insertOutstanding(oustID, orderID, dgData.Rows[i].Cells[0].Value.ToString(), dgData.Rows[i].Cells[3].Value.ToString(), objDataAccess.getDealerIDForAssm(orderID)))
                            {
                                oustID = "OU-" + (int.Parse(objDataAccess.getOutStandingID()) + 1).ToString("000000");
                            }
                            break;
                        }
                    }
                    
                }
            }
            int countNotMatch = 0;
            for(int i=0; i < dgData.RowCount; i++)
            {
                if (int.Parse(dgData.Rows[i].Cells[2].Value.ToString()) < int.Parse(dgData.Rows[i].Cells[3].Value.ToString()))
                    countNotMatch++;
            }
            if(countNotMatch== dgData.RowCount)
                objDataAccess.updateOrderStatus("Outstanding", orderID);
            else
                objDataAccess.updateOrderStatus("Packaged", orderID);
            return true;
        }

        public bool deleteUser(string userID)
        {
            return objDataAccess.deleteUser(userID);
        }

        public bool updateMessage(string mesID)
        {
            return objDataAccess.updateMessage(mesID);

        }

        public DataTable Mermessage()
        {
            return objDataAccess.Mermessage();
        }

        public bool deleteMessage(string mesID)
        {
            return objDataAccess.deleteMessage(mesID);
        }

        public DataTable searchMergMessage(string keyword)
        {
            return objDataAccess.getSearchMergMessage(keyword);
        }

        public bool deleteOrderAssembly(string orderID)
        {
            return objDataAccess.deleteOrderAssembly(orderID);
        }

        public DataTable DateStatusFilterOrderAssembly(string startDate, string EndDate, string status)
        {
            return objDataAccess.getDateStatusFilterOrderAssembly(startDate, EndDate, status);
        }

        public DataTable DateAroundFilterOrderAssembly(string startDate, string EndDate)
        {
            return objDataAccess.getDateAroundFilterOrderAssembly(startDate, EndDate);
        }


        public DataTable getItemOnHandA()
        {
            return objDataAccess.getItemOnHandA();
        }

        public DataTable getItemOnHandB() { 
        
            return objDataAccess.getItemOnHandB();
        }
        public string getDashVal()
        {
            float sum = 0;
            DataTable result = objDataAccess.getDashVal();
            for(int i=0; i < result.Rows.Count; i++)
            {
                Debug.WriteLine(result.Rows[i][0].ToString());
                sum += ((int.Parse(result.Rows[i][0].ToString())) * ((float.Parse(result.Rows[i][0].ToString()))));
            }
            return sum.ToString();
        }
        public DataTable getItemOnHandC()
        {
            return objDataAccess.getItemOnHandC();
        }
        public DataTable getItemOnHandD()
        {
            return objDataAccess.getItemOnHandD();
        }
        public DataTable getTotalNoOfOrders()
        {
            return objDataAccess.getTotalNoOfOrders();
        }
        public DataTable getTotalQtyOrdered()
        {
            return objDataAccess.getTotalQtyOrdered();
        }

        public string getDeliveryID()
        {
            return objDataAccess.getDeliveryID();
        }
        public DataTable insertDelivery(string orderID, string deliveryDate)
        {
            if (objDataAccess.checkInv(orderID))
            {
                Debug.WriteLine("POINT1");
                string deliveryID = "DE-" + (int.Parse(objDataAccess.getDeliveryID())+1).ToString("00000000");

                while(!objDataAccess.insertDelivery(deliveryID, deliveryDate, orderID))
                {
                    deliveryID = "DE-" + (int.Parse(objDataAccess.getDeliveryID()) + 1).ToString("00000000");
                }

                DataTable result = objDataAccess.getDelivery(orderID);
                objDataAccess.updateOrderStatus("Delivery", orderID);
                return result;
                Debug.WriteLine("POINT1");
            }
            else
            {
                Debug.WriteLine("POINT2");
                return null;
            }
            
        }
        public void cancelAssembly(DataGridView dgData, string userID, string orderID)
        {
            for (int i = 0; i < dgData.Rows.Count; i++)
            {
                objDataAccess.AddStock(dgData.Rows[i].Cells[0].Value.ToString(), int.Parse(dgData.Rows[i].Cells[2].Value.ToString()));
                string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1);

                while (!objDataAccess.LogOutputItem(logID, userID, dgData.Rows[i].Cells[0].Value.ToString(), dgData.Rows[i].Cells[2].Value.ToString()))
                {
                    logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1);
                }

            }
        }

        public void LogABC(string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            while (!objDataAccess.Loglogout(logID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }



        public string getMMFormID()
        {
            return objDataAccess.getMMFormID();
        }
        public bool insertMessage(string title, string des, string userID)
        {
            string mmFormID = "MM-" + (int.Parse(getMMFormID()) + 1).ToString("0000");
            while (!objDataAccess.insertMessage(mmFormID, title, des, userID))
            {
                mmFormID = "MM-" + (int.Parse(getMMFormID()) + 1).ToString("0000");
            }
            return true;
        }

        public DataTable getReportItem()
        {
            return objDataAccess.getReportItem();
        }

        public DataTable getSalesReport()
        {
            return objDataAccess.getSalesReport();
        }

        public DataTable getSalesReportItem()
        {
            return objDataAccess.getSalesReportItem();
        }

         public string[] getSaleReportAnal(BunifuCustomDataGrid dgData)
        {
            float salesVal = 0;
            float costVal = 0;
            string[] val = new string[4];
            for(int i=0; i < dgData.RowCount; i++)
            {
                salesVal += (float)(((int)(dgData.Rows[i].Cells["qtyOrdered"].Value)) *((decimal)(dgData.Rows[i].Cells["salePrice"].Value)));
                costVal += (float)(((int)(dgData.Rows[i].Cells["qtyOrdered"].Value)) * ((decimal)(dgData.Rows[i].Cells["purPrice"].Value)));
                //qty += (int)dgItem.Rows[i].Cells["quantityInStock"].Value;
                // costValue += (float)((decimal)dgItem.Rows[i].Cells["salesPrice"].Value * (int)dgItem.Rows[i].Cells["quantityInStock"].Value);
            }
            val[0] = salesVal.ToString();
            val[1] = costVal.ToString();
            val[2] = (salesVal - costVal).ToString();
            return val;
        }

       public DataTable getReportCount()
        {
            return objDataAccess.getReportCount();
        }

        public string getCountInvoice()
        {
            return objDataAccess.getCountInvoice();
        }

        public DataTable DataFilterReportSalesItem(string itemID)
        {
            return objDataAccess.DataFilterReportSalesItem(itemID);
        }

        public DataTable DataFilterReportSalesCat(string cal)
        {
            return objDataAccess.DataFilterReportSalesCat(cal);
        }
        public DataTable DataFilterReportSalesCatItem(string itemID, string cat)
        {
            return objDataAccess.DataFilterReportSalesCatItem(itemID, cat);
        }
    




















        public void LoginsertMessage(string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.Loglogout(logID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }


        public void LogupdateMessage(string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.Loglogout(logID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }






        public bool updateMessage(string title, string des, string userID, string mesID)
        {
            return objDataAccess.updateMessage(title, des, userID, mesID);

        }
        public DataTable getMMForm(String mesID)
        {
            return objDataAccess.getMMForm(mesID);
        }

        public void LogcreateSalesOrder(string userID, string orderID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogcreateSalesOrder(logID, userID, orderID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1);
            }
        }
        public void LogInputItem(string userID, string orderID, string itemID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogInputItem(logID, userID, orderID, itemID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LogInsertGRN(string userID, string PurID, string itemID, string RecQty)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogInsertGRN(logID, userID, PurID, itemID, RecQty))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }

        public void LogdeleteGRNRecord(string userID, string grnID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogdeleteGRNRecord(logID, userID, grnID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LoginsertItem(string userID, string itemID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LoginsertItem(logID, userID, itemID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LogdeleteItemRecord(string userID, string itemID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogdeleteItemRecord(logID, userID, itemID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LogupdateItem(string userID, string itemID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogupdateItem(logID, userID, itemID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }

        public void LoginsertUser(string userID, string userName, string title)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LoginsertUser(logID, userID, userName, title))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LogupdateUserInf(string contrUserID, string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogupdateUserInf(logID, contrUserID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LogdeleteRecordInv(string userID, string invoiceID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogdeleteRecordInv(logID, userID, invoiceID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LogverityUser(string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogverityUser(logID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LoginsertOrderReturn(string userID, string orderID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LoginsertOrderReturn(logID, userID, orderID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LoginsertOrderReturn(string userID, string orderID, string itemID, string qty)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LoginsertOrderReturn(logID, userID, orderID, itemID, qty))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LogdeleteUser(string contrUserID, string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogdeleteUser(logID, contrUserID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LogorderUpdate(string userID, string orderID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogorderUpdate(logID, userID, orderID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void Loglogout(string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.Loglogout(logID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }
        public void LogupdateOrderHold(string userID, string orderID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogupdateOrderHold(logID, userID, orderID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }

        public void LogPrintStockReport(string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogPrintStockReport(logID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }

        }

        public bool updateComplete(string orderID, string itemID, string itemQty)
        {
            return objDataAccess.updateComplete(orderID, itemID, itemQty);

        }

        public bool findMMFDIS()
        {
            DataTable result = objDataAccess.findMMFDIS();
            if (result.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getMMForm()
        {
            return objDataAccess.getMMForm();
        }
        public void LogPrintStockReportCSV(string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogPrintStockReportCSV(logID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }

        }
        public void LoginsertDelivery(string userID, string deliveryID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LoginsertDelivery(logID, userID, deliveryID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }
        }

        public void LogdeleteRecord(string userID, string orderID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogdeleteRecord(logID, userID, orderID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }

        }
        public void LogPrintSalesOfficeReportPDF(string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogPrintSalesOfficeReportPDF(logID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }

        }

        public void LogPrintSalesOfficeReportCSV(string userID)
        {
            string logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");

            while (!objDataAccess.LogPrintSalesOfficeReportCSV(logID, userID))
            {
                logID = "LOG-" + (int.Parse(objDataAccess.getNewLogID()) + 1).ToString("0000000");
            }

        }

    }
}














