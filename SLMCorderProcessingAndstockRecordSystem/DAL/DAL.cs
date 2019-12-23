using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


using System.Security.Cryptography;
using System.Data;
using System.Diagnostics;

namespace DataAccess.DAL
{
    class DAL
    {
        public MySqlConnection ServerConnect()
        {
            string dbHost = "localhost";
            string dbUser = "root";
            string dbPass = "";
            string dbName = "classicmodels";
            string dbSsl = "none";
            string connStr = "Server=" + dbHost + ";Uid=" + dbUser + ";Pwd=" + dbPass + ";Database=" + dbName + ";SslMode=" + dbSsl + ";allow zero datetime = true; Convert Zero Datetime=True ";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect the Database");
                        break;
                    case 1045:
                        Console.WriteLine("User or Password is Wrong");
                        break;
                }
            }
            return conn;
        }

        public void insertTest()
        {
            string sql = "INSERT INTO productlines VALUES('TEST','TEST',null,null)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.ExecuteNonQuery();
            ServerConnect().Close();
        }

        public DataTable getSalesOrder()
        {
            string sql = "SELECT * FROM SalesOrder";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getItem()
        {
            string sql = "SELECT itemID, itemName, itemCategory, purPrice, salesPrice, wareHouse,demand, quantityInStock, Hold, Description, status FROM item";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getReportItem()
        {
            string sql = "SELECT itemID, itemName, itemCategory, salesPrice, wareHouse, quantityInStock, demand, Hold, reorderLevel, dangerlevel, autoPur FROM item ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable DataFilterReportItem(string cat)
        {
            string sql = "SELECT itemID, itemName, itemCategory, wareHouse, salesPrice, quantityInStock, demand, Hold, reorderLevel, dangerlevel, autoPur FROM item WHERE itemCategory=@cat";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@cat", cat);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getReportItem(string keyword)
        {
            string sql = "SELECT itemID, itemName, itemCategory, salesPrice, wareHouse, quantityInStock, demand, Hold, reorderLevel, dangerlevel, autoPur FROM item WHERE itemID LIKE @keyword OR itemName LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", "%"+keyword+"%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }


        public DataTable getOrderDetail(string orderID)
        {
            string sql = "SELECT * FROM SalesOrder, dealer WHERE SalesOrder.dealerID=dealer.dealerID AND orderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public String getPassword(string userName)
        {
            string sql = "SELECT userPassword FROM user WHERE userName=@name";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@name", userName);
            Object pwd = cmd.ExecuteScalar();//MySqlDataReader for one line result
            ServerConnect().Close();
            return pwd.ToString();

        }

        public String getTitle(string userName)
        {
            string sql = "SELECT title FROM user WHERE userName=@name";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@name", userName);
            Object title = cmd.ExecuteScalar();//MySqlDataReader for one line result
            ServerConnect().Close();
            return title.ToString();
        }
        public String getTitleUseID(string userID)
        {
            string sql = "SELECT title FROM user WHERE userID=@name";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@name", userID);
            Object title = cmd.ExecuteScalar();//MySqlDataReader for one line result
            ServerConnect().Close();
            return title.ToString();
        }

        public DataTable getDateFilterSalOrd(string sDate, string eDate)
        {
            string sql = "SELECT * FROM SalesOrder WHERE orderDate BETWEEN @sDate AND @eDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@sDate", sDate);
            cmd.Parameters.AddWithValue("@eDate", eDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getDateFIlterInv(string sDate, string eDate)
        {
            string sql = "SELECT * FROM invoice WHERE pickupDate BETWEEN @sDate AND @eDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@sDate", sDate);
            cmd.Parameters.AddWithValue("@eDate", eDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getDateStaFilterSalOrd(string sDate, string eDate, string statue)
        {
            string sql = "SELECT * FROM SalesOrder WHERE (orderDate BETWEEN @sDate AND @eDate) AND status=@status";
            Debug.WriteLine(statue);
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@sDate", sDate);
            cmd.Parameters.AddWithValue("@eDate", eDate);
            cmd.Parameters.AddWithValue("@status", statue);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable DateFilterOutstand(string sDate, string eDate)
        {
            string sql = "SELECT * FROM Outstanding WHERE (OutstandingDate BETWEEN @sDate AND @eDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@sDate", sDate);
            cmd.Parameters.AddWithValue("@eDate", eDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public bool deleteSalesOrder(String orderID)
        {
            try
            {
                string sql = "UPDATE salesOrder SET status='Cancel' WHERE orderID=@orderID ";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool deleteItem(string itemID)
        {
            try
            {
                string sql = "DELETE FROM item WHERE itemID=@id";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@id", itemID);
                cmd.ExecuteNonQuery();
                ServerConnect().Close();
                return true;
            }
            catch { return false; }

        }

        public bool deleteInvoice(string invoiceID)
        {
            try
            {
                string sql = "DELETE FROM invoice WHERE invoiceID=@id";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@id", invoiceID);
                int numRow = cmd.ExecuteNonQuery();
                if (numRow > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public DataTable getInvoiceDetail(string invoiceID)
        {
            string sql = "SELECT * FROM invoice, dealer WHERE invoice.dealerID=dealer.dealerID AND invoiceID=@id";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@id", invoiceID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;

        }
        public DataTable getOrderItemDetail(string orderID)
        {
            string sql = "SELECT orderitem.itemID, item.itemName, orderitem.qtyOrdered, orderitem.salePrice FROM orderitem, item WHERE orderitem.itemID=item.itemID AND orderItem.orderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public String getOrderStatus(string orderID)
        {
            string sql = "SELECT status FROM SalesOrder WHERE orderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            Object status = cmd.ExecuteScalar();//MySqlDataReader for one line result
            ServerConnect().Close();
            return status.ToString();
        }

        public bool insertOrder(String orderID, String itemID, String qtyOrdered, String salePrice)
        {
            try
            {
                string sql = "INSERT INTO orderItem VALUES(@orderID, @itemID, @qty, @salePrice)";
                MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
                cmod.Parameters.AddWithValue("@qty", qtyOrdered);
                cmod.Parameters.AddWithValue("@orderID", orderID);
                cmod.Parameters.AddWithValue("@salePrice", salePrice);
                cmod.Parameters.AddWithValue("@itemID", itemID);
                if (cmod.ExecuteNonQuery() > 0)
                    return true;
            }
            catch { return false; }
            return false;

        }
        public bool insertItem(string itemID, string itemName, string purPrice, string wareHouse, string quantityInStock, string Hold, string Description, string status, string itemCategory, string salesPrice, string reorderLevel, string dangerlevel, string autoPur, string demand)
        {
            try
            {
                string sql = "INSERT INTO Item VALUES(@itemID,@itemName,@purPrice,@wareHouse,@quantityInStock,@demand,@Hold,@Description,@Status,@itemCategory,@salesPrice,@reorderLevel,@dangerlevel,@autoPur)";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@itemID", itemID);
                cmd.Parameters.AddWithValue("@itemName", itemName);
                cmd.Parameters.AddWithValue("@purPrice", purPrice);
                cmd.Parameters.AddWithValue("@wareHouse", wareHouse);
                cmd.Parameters.AddWithValue("@quantityInStock", quantityInStock);
                cmd.Parameters.AddWithValue("@demand", demand);
                cmd.Parameters.AddWithValue("@Hold", Hold);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@itemCategory", itemCategory);
                cmd.Parameters.AddWithValue("@salesPrice", salesPrice);
                cmd.Parameters.AddWithValue("@reorderLevel", reorderLevel);
                cmd.Parameters.AddWithValue("@dangerlevel", dangerlevel);
                cmd.Parameters.AddWithValue("@autoPur", autoPur);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch { return false; }
            return false;

        }

        public String getItemID(char cat)
        {
            string sql = "SELECT MAX(itemID) FROM item WHERE LEFT(itemID,1)=@cat";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@cat", cat);
            Object itemIDPart = cmd.ExecuteScalar();
            return itemIDPart.ToString();
        }
        public void orderDelete(string orderID)
        {
            string sql = "DELETE FROM orderItem WHERE orderID=@orderItemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderItemID", orderID);
            cmd.ExecuteNonQuery();
        }

        public bool updateDealer(String dealerID, String dealerName, String contactFirName, String contactLasName, String contactNumber, String Email, String city, String postcode, String Address)
        {
            try
            {
                string sql = "UPDATE dealer SET companyName=@dealerName, contactFirName=@contactFirName, contactLasName=@contactLasName, contactNo=@contactNo, email=@email, postcode=@postcode, city=@city, Address=@Address WHERE dealerID=@dealerID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@dealerID", dealerID);
                cmd.Parameters.AddWithValue("@dealerName", dealerName);
                cmd.Parameters.AddWithValue("@contactFirName", contactFirName);
                cmd.Parameters.AddWithValue("@contactLasName", contactLasName);
                cmd.Parameters.AddWithValue("@contactNo", contactNumber);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@postcode", postcode);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@Address", Address);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch { return false; }
            return false;
        }
        public void updateOrderStatus(String status, String orderID)
        {
            string sql = "UPDATE SalesOrder Set status=@status WHERE orderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.ExecuteNonQuery();
        }
        public bool updateItem(string itemID, string itemName, string purPrice, string wareHouse, string quantityInStock, string Hold, string Description, string status, string itemCategory, string salesPrice, string reorderLevel, string dangerlevel, string autoPur, string demand)
        {
            string sql = "UPDATE item SET itemID=@itemID, itemName=@itemName, purPrice=@purPrice, wareHouse=@wareHouse, quantityInStock=@quantityInStock, Hold=@Hold, Description=@Description, status=@status, itemCategory=@itemCategory, salesPrice=@salesPrice, reorderLevel=@reorderLEvel, dangerlevel=@dangerlevel, autoPur=@autoPur, demand=@demand WHERE itemID=@itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@itemID", itemID);
            cmd.Parameters.AddWithValue("@itemName", itemName);
            cmd.Parameters.AddWithValue("@purPrice", purPrice);
            cmd.Parameters.AddWithValue("@wareHouse", wareHouse);
            cmd.Parameters.AddWithValue("@quantityInStock", quantityInStock);
            cmd.Parameters.AddWithValue("@demand", demand);
            cmd.Parameters.AddWithValue("@Hold", Hold);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@itemCategory", itemCategory);
            cmd.Parameters.AddWithValue("@salesPrice", salesPrice);
            cmd.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            cmd.Parameters.AddWithValue("@dangerlevel", dangerlevel);
            cmd.Parameters.AddWithValue("@autoPur", autoPur);
            if (cmd.ExecuteNonQuery() > 0)
                return true;

            return false;
        }
        public DataTable getSearchOrder(string keywd)
        {
            string sql = "SELECT * FROM SalesOrder WHERE orderID LIKE @keywd OR orderHold LIKE @keywd OR dealerID LIKE @keywd ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keywd", "%" + keywd + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getSearchItem(string keyword)
        {
            string sql = "SELECT itemID, itemName, itemCategory, purPrice, salesPrice, wareHouse, demand, quantityInStock, Hold, Description, status FROM item WHERE itemCategory LIKE @keyword OR itemID LIKE @keyword OR itemName LIKE @keyword OR status LIKE @keyword OR itemID LIKE @keyd OR itemName LIKE @keyd OR status LIKE @keyd OR itemCategory LIKE @keyd  ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            cmd.Parameters.AddWithValue("@keyd", "%" + char.ToUpper(keyword[0]) + keyword.Substring(1) + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getSearchInvoice(string keyword)
        {
            string sql = "SELECT * FROM Invoice WHERE invoiceID LIKE @keywd OR orderID LIKE @keywd";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keywd", "%" + keyword + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getOutStanding()
        {
            string sql = "SELECT outstandingID, orderID, Outstanding.itemID, itemName, followUp, status, OutstandingDate FROM Outstanding, item WHERE Outstanding.itemID=item.itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adat.Fill(dt);
            return dt;
        }

        public DataTable getSearchOutStanding(string keyword)
        {
            string sql = "SELECT outstandingID, orderID, Outstanding.itemID, itemName, followUp, status, OutstandingDate FROM Outstanding, item WHERE (OutstandingID LIKE @keywd OR orderID LIKE @keywd OR item.itemID LIKE @keywd OR item.status LIKE @keywd) AND ( Outstanding.itemID=item.itemID)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keywd", "%" + keyword + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public bool deleteOutRecord(string id)
        {
            try
            {
                string sql = "DELETE FROM Outstanding WHERE outstandingID=@id";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@id", id);
                int numberOfRecords = cmd.ExecuteNonQuery();
                if (numberOfRecords > 0)
                    return true;
            }
            catch
            {
                return false;
            }

            return false;

        }
        public DataTable getOutStandingOrder(string id)
        {
            string sql = "SELECT dealer.*, Outstanding.*, item.itemName, item.salesPrice FROM Outstanding, dealer, item WHERE outstandingID=@id AND Outstanding.dealerID=dealer.dealerID AND item.itemID=Outstanding.itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getInvoice()
        {
            string sql = "SELECT * FROM invoice";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;

        }
        public DataTable getItemCategory()
        {
            String sql = "SELECT DISTINCT itemCategory FROM item";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getInvOrderItemDetail(string orderID)
        {
            string sql = "SELECT item.itemID, itemName, actualQty, qtyOrdered FROM orderitem, item WHERE orderID=@id AND orderitem.itemID=item.itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@id", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getItemDetail(string itemID)
        {

            string sql = "SELECT * FROM item WHERE itemID=@id";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@id", itemID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getPurchases()
        {
            string sql = "SELECT * FROM Purchase";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;

        }

        public DataTable searchPurchases(string keyword)
        {
            string sql = "SELECT * FROM Purchase WHERE purchaseID LIKE @id";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@id", "%" + keyword + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable DateFilterPur(String sDate, string eDate)
        {
            string sql = "SELECT * FROM Purchase WHERE purDate BETWEEN @sDate AND @eDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@sDate", sDate);
            cmd.Parameters.AddWithValue("@eDate", eDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getSearchDespatch(string keyword)
        {
            string sql = "SELECT * FROM delivery WHERE deliveryID LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable DateFilterDepatch(String sDate, string eDate)
        {
            string sql = "SELECT * FROM delivery WHERE deliveryDate BETWEEN @sDate AND @eDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@sDate", sDate);
            cmd.Parameters.AddWithValue("@eDate", eDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getDespatch()
        {
            string sql = "SELECT * FROM delivery";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getGRN()
        {
            string sql = "SELECT grnID, itemID, recQty, save, recDate, purchaseID FROM grn";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable DateFilterGRN(string startDate, string endDate)
        {
            string sql = "SELECT * FROM grn WHERE recDate BETWEEN @sDate AND @eDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@sDate", startDate);
            cmd.Parameters.AddWithValue("@eDate", endDate);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable searchGRN(string keyword)
        {
            string sql = "SELECT * FROM grn WHERE itemID=@keyword OR grnID=@keyword OR save=@keyword OR recDate=@keyword OR grnID=@keyd OR save=@keyd OR recDate=@keyd OR itemID=@keyd";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            cmd.Parameters.AddWithValue("@keyd", "%" + char.ToUpper(keyword[0]) + keyword.Substring(1) + "%");
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public string getGRNID()
        {
            string sql = "SELECT MAX(grnID) FROM grn";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object grnID = cmd.ExecuteScalar();
            return grnID.ToString();
        }
        public DataTable getDupGRNID()
        {
            string sql = "SELECT purchaseID, itemID FROM grn";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public bool insertGRN(string grnID, string recQty, string Loca, string date, string itemID, string purID)
        {

            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO grn VALUES(@grnID, @recQty, @save, @recDate, @itemID, @purchaseID)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@grnID", grnID);
            cmd.Parameters.AddWithValue("@recQty", recQty);
            cmd.Parameters.AddWithValue("@save", Loca);
            cmd.Parameters.AddWithValue("@recDate", theDate);
            cmd.Parameters.AddWithValue("@itemID", itemID);
            cmd.Parameters.AddWithValue("@purchaseID", purID);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }

        public void AddStock(string itemID, int qty)
        {
            string sql = "UPDATE item SET quantityInStock=quantityInStock+ @qty WHERE itemID=@itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@itemID", itemID);
            cmd.ExecuteNonQuery();
        }
        public void ReduceStock(string itemID, int qty)
        {
            string sql = "UPDATE item SET quantityInStock=quantityInStock- @qty WHERE itemID=@itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@itemID", itemID);
            cmd.ExecuteNonQuery();
        }
        public bool deleteGRNRecord(String grnID)
        {
            try
            {
                string sql = "DELETE FROM grn WHERE grnID=@grnID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@grnID", grnID);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch { return false; }
            return false;
        }
        public DataTable getOrderReturn()
        {
            string sql = "SELECT orderreturn.orderID, orderreturn.itemID, item.itemName, orderreturn. itemQty FROM orderreturn, item where orderreturn.itemId=item.itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public bool insertOrderReturn(string orderID, string itemID, string qty)
        {
            string sql = "INSERT INTO orderReturn VALUES(@orderID, @itemID, @qty)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@itemID", itemID);
            cmd.Parameters.AddWithValue("@qty", qty);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;

        }
        public DataTable getOrderReturn(string orderID)
        {
            string sql = "SELECT * FROM orderitem where orderID =@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchOrderReturn(string keyword)
        {
            string sql = "SELECT * orderreturn.orderID, orderreturn.itemID, item.itemName, orderreturn.itemQty FROM orderreturn, item where orderreturn.itemId=item.itemID AND orderreturn.orderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", "%" + keyword + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getUserInf()
        {
            string sql = "SELECT userID, userName, userPassword, department.deptName, title FROM user, department WHERE user.deptNo=department.deptNo";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getUserLog()
        {
            string sql = "SELECT logID, userID, activeDes, loggingcat.activeType, logTime FROM logging, loggingcat WHERE logging.activeTypeID=loggingcat.activeTypeID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable DataFilterUserInf(string username, string dept)
        {
            string sql = "SELECT userID, userName, userPassword, department.deptName, title FROM user, department WHERE user.deptNo=department.deptNo AND userID=@userName OR userName=@userName AND department.deptName=@dept";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@dept", dept);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable DataFilterUserInf(string username)
        {
            string sql = "SELECT userID, userName, userPassword, department.deptName, title FROM user, department WHERE user.deptNo=department.deptNo AND userID=@userName OR userName=@userName";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@username", username);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable DataFilterUserInf(string dept, int i)
        {
            string sql = "SELECT userID, userName, userPassword, department.deptName, title FROM user, department WHERE user.deptNo=department.deptNo AND department.deptName=@dept";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@dept", dept);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable DataFilterUserLog(string username, string dept)
        {
            string sql = "SELECT logID, user.userID, activeDes, loggingcat.activeType, logTime FROM logging, loggingcat, user, department WHERE logging.activeTypeID=loggingcat.activeTypeID AND logging.userID= user.userID AND user.userID=@username OR user.userName=@username AND user.deptNo=department.deptNo AND department.deptName=@dept";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@dept", dept);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable DataFilterUserLog(string username)
        {
            string sql = "SELECT logID, user.userID, activeDes, loggingcat.activeType, logTime FROM logging, loggingcat, user WHERE logging.activeTypeID=loggingcat.activeTypeID AND logging.userID= user.userID And user.userID=@username";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@username", username);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable DataFilterUserLog(string dept, int i)
        {
            string sql = "SELECT logID, user.userID, activeDes, loggingcat.activeType, logTime FROM logging, loggingcat, user, department WHERE logging.activeTypeID=loggingcat.activeTypeID AND logging.userID= user.userID AND user.deptNo=department.deptNo AND department.deptName=@dept";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@dept", dept);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchUserInf(string keyword)
        {
            string sql = "SELECT userID, userName, userPassword, deptName, title FROM (SELECT userID, userName, userPassword, department.deptName, title FROM user, department WHERE user.deptNo=department.deptNo) AS tb WHERE userID LIKE @keyword OR userName LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getUserInf(string userID)
        {
            string sql = "SELECT user.*, department.deptName FROM user, department WHERE user.deptNo=department.deptNo AND user.userID=@keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", userID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public bool updateUserInf(string userID, string userName, string userPassword, string deptID, string title)
        {
            try
            {
                string sql = "UPDATE user SET userID=@userID, userName=@userName userPasswrod=@userPwd, deptID=@deptID, title=@title";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("userName", userName);
                cmd.Parameters.AddWithValue("@userPwd", userPassword);
                cmd.Parameters.AddWithValue("@deptID", deptID);
                cmd.Parameters.AddWithValue("@title", title);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    return true;
            }
            catch { return false; }
            return false;
        }
        public DataTable searchUserLog(string keyword)
        {
            string sql = "SELECT logID, userID, activeDes, activeType, logTime FROM(SELECT logID, user.userID, activeDes, loggingcat.activeType, logTime FROM logging, loggingcat, user WHERE logging.activeTypeID=loggingcat.activeTypeID AND user.userID=logging.userID) AS tb WHERE logID LIKE @keyword OR userID LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getDept()
        {
            string sql = "SELECT DISTINCT deptName FROM department";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public string getDeptID(string dept)
        {
            Debug.WriteLine(dept);
            string sql = "SELECT deptNo FROM department WHERE deptName=@dept";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@dept", dept);
            Object deptNo = cmd.ExecuteScalar();
            return deptNo.ToString();
        }
        public bool insertUser(string userID, string username, string pwd, string deptID, string title)
        {
            try
            {
                string sql = "INSERT INTO user VALUES(@userID, @username, @pwd, @deptID, @title)";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@deptID", deptID);
                cmd.Parameters.AddWithValue("@title", title);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch { return false; }
            return false;
        }
        public string getUserID()
        {
            string sql = "SELECT MAX(RIGHT(userID,3)) FROM user";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object userID = cmd.ExecuteScalar();
            return userID.ToString();
        }
        public bool deleteUser(string userID)
        {
            try
            {
                string sql = "DELETE FROM user WHERE userID=@userID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@userID", userID);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {
                return false;
            }
            return false;
        }
        public string getUserID(string userName)
        {
            string sql = "SELECT userID FROM user WHERE userName=@userName";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@userName", userName);
            Object userID = cmd.ExecuteScalar();
            return userID.ToString();
        }
        public DataTable getItemIDAndItemName()
        {
            string sql = "SELECT itemID, itemName FROM item";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public string searchDealerID(string keyword)
        {
            try
            {
                string sql = "SELECT dealerID FROM dealer WHERE dealerID=@keyword";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@keyword", keyword);
                Object dealer = cmd.ExecuteScalar();
                return dealer.ToString();
            }
            catch { return null; }

        }
        public DataTable searchDealerDetail(string dealerID)
        {
            string sql = "SELECT * FROM dealer WHERE dealerID=@dealerID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@dealerID", dealerID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public string searchItemIDOrder(string keyword)
        {
            try
            {
                string sql = "SELECT itemID FROM item WHERE itemID=@keyword";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@keyword", keyword);
                Object dealer = cmd.ExecuteScalar();
                return dealer.ToString();
            }
            catch { return null; }
        }

        public string searchItemNameOrder(string keyword)
        {
            try
            {
                string sql = "SELECT itemName FROM item WHERE itemName=@keyword";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@keyword", keyword);
                Object dealer = cmd.ExecuteScalar();
                return dealer.ToString();
            }
            catch { return null; }
        }
        public bool insertSalesOrder(string orderID, bool orderHold, string description, string status, string dealerID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO SalesOrder VALUES(@orderID, @orderHold, @description, @status, @dealerID, @orderDate)";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@orderID", orderID);
            cmod.Parameters.AddWithValue("@orderHold", orderHold);
            cmod.Parameters.AddWithValue("@description", description);
            cmod.Parameters.AddWithValue("@status", status);
            cmod.Parameters.AddWithValue("@dealerID", dealerID);
            cmod.Parameters.AddWithValue("@orderDate", theDate);

            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public string getDealerID()
        {
            string sql = "SELECT MAX(dealerID) FROM Dealer";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object dealer = cmd.ExecuteScalar();
            return dealer.ToString();
        }
        public string getOrderID()
        {
            string sql = "SELECT MAX(RIGHT(orderID,8)) FROM salesorder";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object dealer = cmd.ExecuteScalar();
            return dealer.ToString();
        }
        public bool addDealer(string dealerID, string dealerName, string FirName, string LasName, string contactNp, string Email, string city, string postcode, string Address)
        {
            string sql = "INSERT INTO dealer VALUES(@dealerID, @dealerName, @FirName, @LasName, @contactNo, @Email, @city, @postcode, @Address)";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@dealerID", dealerID);
            cmod.Parameters.AddWithValue("@dealerName", dealerName);
            cmod.Parameters.AddWithValue("@FirName", FirName);
            cmod.Parameters.AddWithValue("@LasName", LasName);
            cmod.Parameters.AddWithValue("@contactNo", contactNp);
            cmod.Parameters.AddWithValue("@Email", Email);
            cmod.Parameters.AddWithValue("@city", city);
            cmod.Parameters.AddWithValue("@postcode", postcode);
            cmod.Parameters.AddWithValue("@Address", Address);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool insertOrderItem(string orderID, string itemID, int qty, string orderQty, string salePrice)
        {
            string sql = "INSERT INTO orderItem VALUES(@orderID,@itemID,@qty,@orderQty,@salePrice)";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@orderID", orderID);
            cmod.Parameters.AddWithValue("@itemID", itemID);
            cmod.Parameters.AddWithValue("@qty", qty);
            cmod.Parameters.AddWithValue("@orderQty", orderQty);
            cmod.Parameters.AddWithValue("@salePrice", salePrice);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool updateOrderItemDemond(string itemID, int Qty)
        {
            string sql = "UPDATE item SET demand=demand+@Qty WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@itemID", itemID);
            cmod.Parameters.AddWithValue("@Qty", Qty);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool updateOrderItemHold(string itemID, int Qty)
        {
            string sql = "UPDATE item SET Hold=Hold+@Qty WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@itemID", itemID);
            cmod.Parameters.AddWithValue("@Qty", Qty);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool updateReduceOrderItemHold(string itemID, int Qty)
        {
            string sql = "UPDATE item SET Hold=Hold-@Qty WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@itemID", itemID);
            cmod.Parameters.AddWithValue("@Qty", Qty);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool updateIncOrderItemHold(string itemID, int Qty)
        {
            string sql = "UPDATE item SET Hold=Hold+@Qty WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@itemID", itemID);
            cmod.Parameters.AddWithValue("@Qty", Qty);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool updateReduceOrderItemDemond(string itemID, int Qty)
        {
            string sql = "UPDATE item SET demand=demand-@Qty WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@itemID", itemID);
            cmod.Parameters.AddWithValue("@Qty", Qty);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }


        public DataTable searchOrderItemDetail(string keyword)
        {
            string sql = "SELECT * FROM item WHERE itemID=@keyword OR itemName=@keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@keyword", keyword);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }





        //Codeing Start
        public DataTable getOrderItemDetailforAsb(string orderID)
        {
            string sql = "SELECT orderitem.itemID, itemName, wareHouse, quantityInStock,  qtyOrdered FROM item, orderitem WHERE item.itemID=orderitem.itemID AND orderitem.orderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable searchOrderEachItemDetail(string orderID)
        {
            Debug.WriteLine("Pres " + orderID);
            string sql = "SELECT itemID FROM orderitem WHERE orderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getOrderEachItemDetail(string itemID, string orderID)
        {
            string sql = "SELECT item.itemID, actualQty, qtyOrdered, item.itemName FROM item, orderitem WHERE item.itemID=orderitem.itemID AND orderID=@orderID AND item.itemID=@itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@itemID", itemID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public string getOutStandingID()
        {
            string sql = "SELECT MAX(RIGHT(outstandingID,6)) FROM outstanding";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object dealer = cmd.ExecuteScalar();
            return dealer.ToString();
        }
        public bool insertOutstanding(string outstID, string orderID, string itemID, string follow, string dealerID)
        {
            string sql = "INSERT INTO Outstanding VALUES(@outstID,@orderID,@itemID,@follow,@date,@dealerId)";
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@outstID", outstID);
            cmod.Parameters.AddWithValue("@orderID", orderID);
            cmod.Parameters.AddWithValue("@itemID", itemID);
            cmod.Parameters.AddWithValue("@follow", follow);
            cmod.Parameters.AddWithValue("@dealerID", dealerID);
            cmod.Parameters.AddWithValue("@date", theDate);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool updateItemInStock(string itemID, string qty)
        {
            string sql = "UPDATE item SET demand=demand-@qty WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@qty", qty);
            cmod.Parameters.AddWithValue("@itemID", itemID);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public string getItemInStoc(string itemID)
        {
            string sql = "SELECT quantityInStock FROM item WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@itemID", itemID);
            Object inST = cmod.ExecuteScalar();//MySqlDataReader for one line result
            return inST.ToString();
        }
        public string getItemReorderLev(string itemID)
        {
            string sql = "SELECT reorderLevel FROM item WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@itemID", itemID);
            Object inST = cmod.ExecuteScalar();//MySqlDataReader for one line result
            return inST.ToString();

        }
        public string getPurchasesID()
        {
            string sql = "SELECT MAX(RIGHT(PurchaseID,6)) FROM Purchase";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            Object inST = cmod.ExecuteScalar();//MySqlDataReader for one line result
            ServerConnect().Close();
            return inST.ToString();
        }
        public bool insertPurchase(string purID, string itemID, string orderQty, string status)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO Purchase VALUES(@purID, @itemID, @orderQty, @status, @date)";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@purID", purID);
            cmod.Parameters.AddWithValue("@itemID", itemID);
            cmod.Parameters.AddWithValue("@orderQty", orderQty);
            cmod.Parameters.AddWithValue("@status", status);
            cmod.Parameters.AddWithValue("@date", theDate);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public string getDealerIDForAssm(string orderID)
        {
            string sql = "SELECT dealerID FROM salesOrder WHERE orderID=@orderID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@orderID", orderID);
            Object inST = cmod.ExecuteScalar();//MySqlDataReader for one line result
            ServerConnect().Close();
            return inST.ToString();
        }
        public string getItemAutoPur(string itemID)
        {
            string sql = "SELECT autoPur FROM item WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@itemID", itemID);
            Object inST = cmod.ExecuteScalar();//MySqlDataReader for one line result
            ServerConnect().Close();
            return inST.ToString();

        }
        public string getInvoiceID()
        {
            string sql = "SELECT MAX((RIGHT(invoiceID,8))) FROM invoice";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            Object inST = cmod.ExecuteScalar();//MySqlDataReader for one line result
            ServerConnect().Close();
            return inST.ToString();
        }
        public bool insetInvoice(string invoiceID, string orderID, string dealerID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO Invoice VALUES(@invoiceID,@orderID,@dealerID,@date)";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@invoiceID", invoiceID);
            cmod.Parameters.AddWithValue("@orderID", orderID);
            cmod.Parameters.AddWithValue("@dealerID", dealerID);
            cmod.Parameters.AddWithValue("@date", theDate);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool updateOrderItem(string orderID, string itemID, string Qty)
        {
            string sql = "UPDATE orderitem SET actualQty=@Qty WHERE orderID=@orderID AND itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@orderID", orderID);
            cmod.Parameters.AddWithValue("@itemID", itemID);
            cmod.Parameters.AddWithValue("@Qty", Qty);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;

        }


        public string searchPurchasesItem(string itemID)
        {
            string sql = "SELECT COUNT(itemID) FROM purchase WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@itemID", itemID);
            Object inST = cmod.ExecuteScalar();//MySqlDataReader for one line result
            return inST.ToString();
        }
        public bool setDefualtInStock(string itemID)
        {
            string sql = "UPDATE item SET quantityInStock=0 WHERE itemID=@itemID";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            cmod.Parameters.AddWithValue("@itemID", itemID);
            if (cmod.ExecuteNonQuery() > 0)
                return true;
            return false;
        }



        public bool updateMessage(string mesID)
        {
            string sql = "UPDATE MergMessages SET merStatus = !merStatus";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable Mermessage()
        {
            string sql = "SELECT * FROM mergmessages";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public bool deleteMessage(string mesID)
        {
            try
            {
                string sql = "DELETE FROM mergmessages WHERE mesID=@mesID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                cmd.Parameters.AddWithValue("@mesID", mesID);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {
                return false;
            }
            return false;
        }

        public DataTable getSearchMergMessage(string keyword)
        {
            string sql = "SELECT * FROM MergMessages WHERE mesID LIKE @keyword OR userID LIKE @keyword";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public bool deleteOrderAssembly(string orderID)
        {
            try
            {
                string sql = "DELETE FROM OrderAssembly WHERE orderID=@orderID";
                MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {
                return false;
            }
            return false;
        }


        public DataTable getDateAroundFilterOrderAssembly(string sDate, string eDate)
        {
            string sql = "SELECT * FROM salesOrder WHERE orderDate BETWEEN @sDate AND @eDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@sDate", sDate);
            cmd.Parameters.AddWithValue("@eDate", eDate);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }



        public DataTable getDateStatusFilterOrderAssembly(string sDate, string eDate, string statue)
        {
            string sql = "SELECT * FROM salesOrder WHERE (orderDate BETWEEN @sDate AND @eDate) AND status=@status";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@sDate", sDate);
            cmd.Parameters.AddWithValue("@eDate", eDate);
            cmd.Parameters.AddWithValue("@status", statue);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }


        public String getPurchaseOrderedQty(string purID)
        {
            string sql = "SELECT orderQty FROM purchase WHERE PurchaseID=@purID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@purID", purID);
            object orderQty = cmd.ExecuteScalar();//MySqlDataReader for one line result
            return orderQty.ToString();
        }
        public bool updatePurchaseOrder(string purID, string status)
        {
            string sql = "UPDATE purchase SET status=@status WHERE PurchaseID=@purID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@purID", purID);
            cmd.Parameters.AddWithValue("@status", status);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;

        }
        public bool updateItemStatus(string itemID, string status)
        {
            string sql = "UPDATE item SET status=@status WHERE itemID=@itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@itemID", itemID);
            cmd.Parameters.AddWithValue("@status", status);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public string getItemReorderlevel(string itemID)
        {
            string sql = "SELECT reorderLevel FROM item WHERE itemID=@itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@itemID", itemID);
            Object reorderLevel = cmd.ExecuteScalar();//MySqlDataReader for one line result
            return reorderLevel.ToString();
        }

        public string getItemDanger(string itemID)
        {
            string sql = "SELECT dangerlevel FROM item WHERE itemID=@itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@itemID", itemID);
            Object dangerlevel = cmd.ExecuteScalar();//MySqlDataReader for one line result
            return dangerlevel.ToString();
        }
        public bool updateOrderHold(string orderID)
        {
            string sql = "UPDATE salesorder SET orderHold=!orderHold WHERE orderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public DataTable getDespatch(string orderID)
        {
            string sql = "SELECT * FROM delivery WHERE orderID like @orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getDespatch(string orderID, string deliveryID, string invoiceID)
        {
            string sql = "SELECT * FROM delivery WHERE orderID=@orderID AND deliveryID=@deliveryID AND invoiceID=@invoiceID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

         public DataTable getItemOnHandA()
        {
            string sql = "SELECT o.orderID, orderDate as orderDateA, SUM(qtyOrdered) as SUMA FROM salesorder s, orderitem o  WHERE (o.orderID=s.orderID) AND DATE(orderDate) > (NOW() - INTERVAL 7 DAY) AND left(itemiD,1)='A' GROUP BY orderDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getItemOnHandB()
        {
            string sql = "SELECT o.orderID, orderDate as orderDateB, SUM(qtyOrdered) as SUMB FROM salesorder s, orderitem o  WHERE (o.orderID=s.orderID) AND DATE(orderDate) > (NOW() - INTERVAL 7 DAY) AND left(itemiD,1)='B' GROUP BY orderDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getItemOnHandC()
        {
            string sql = "SELECT o.orderID, orderDate as orderDateC, SUM(qtyOrdered) as SUMC FROM salesorder s, orderitem o  WHERE (o.orderID=s.orderID) AND DATE(orderDate) > (NOW() - INTERVAL 7 DAY) AND left(itemiD,1)='C' GROUP BY orderDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getItemOnHandD()
        {
            string sql = "SELECT o.orderID, orderDate as orderDateD, SUM(qtyOrdered) as SUMD FROM salesorder s, orderitem o  WHERE (o.orderID=s.orderID) AND DATE(orderDate) > (NOW() - INTERVAL 7 DAY) AND left(itemiD,1)='D' GROUP BY orderDate";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public bool LogPrintStockReportCSV(string logID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " Print the Stock Record Report CSV";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 2, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool LogPrintSalesOfficeReportPDF(string logID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " Print the Sales Office Report PDF";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 2, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool LogPrintSalesOfficeReportCSV(string logID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " Print the Sales Office Report CSV";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 2, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public DataTable getDashVal()
        {
            string sql = "SELECT qtyOrdered, salePrice FROM orderitem";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;

        }
        public DataTable getTotalNoOfOrders()
        {
            string sql = "SELECT COUNT(orderID) FROM salesorder ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        public DataTable getTotalQtyOrdered()
        {
            string sql = "SELECT SUM(qtyOrdered) as SUM FROM orderitem ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

       public string getInvoice(string orderID)
        {
            Debug.WriteLine(orderID);
            string sql = "SELECT invoiceID FROM invoice WHERE orderID =@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            Object id = cmd.ExecuteScalar();//MySqlDataReader for one line result
            return id.ToString();


        }
        public bool insertDelivery(string deliveryID, string deliveryDate, string orderID)
        {
            string invoiceID = getInvoice(orderID);
            string sql = "INSERT INTO delivery VALUES(@deliveryID, @deliveryDate, @invoiceID, @orderID)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@deliveryID", deliveryID);
            cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
            cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }
        
        public DataTable getDelivery(string orderID)
        {
            string sql = "SELECT deliveryID, invoiceID FROM delivery WHERE orderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;

        }


        public string getCountInvoice()
        {
            string sql = "SELECT COUNT(invoiceID) FROM invoice";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            Object countInvoice = cmod.ExecuteScalar();//MySqlDataReader for one line result
            ServerConnect().Close();
            return countInvoice.ToString();

        }










        //LOGGING

        public string getNewLogID()
        {
            string sql = "SELECT MAX(RIGHT(logID,7)) FROM logging";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            Object logID = cmod.ExecuteScalar();//MySqlDataReader for one line result
            ServerConnect().Close();
            return logID.ToString();
        }
        public bool LogcreateSalesOrder(string logID, string userID, string orderID)
        {

            string Descp = "CREATE ORDER #" + orderID;
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 1, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public bool LogInputItem(string logID, string userID, string orderID, string itemID)
        {
            string Descp = "#" + userID + " Put #" + itemID + " to #" + orderID;
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 2, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;

        }

        public bool LogOutputItem(string logID, string userID, string itemID, string qty)
        {
            string Descp = "#" + userID + " Put " + qty + "qty #" + itemID + " to Instock ";
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 2, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public bool LogInsertGRN(string logID, string userID, string PurID, string itemID, string qty)
        {

            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " CREATE GRN (#" + PurID + ") item#" + itemID + " Received " + qty + "qty";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 1, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool LogdeleteGRNRecord(string logID, string userID, string grnID)
        {

            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " DELETE GRN#" + grnID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 3, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LoginsertItem(string logID, string userID, string itemID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " CREATE item#" + itemID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 1, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LogdeleteItemRecord(string logID, string userID, string itemID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " DELETE item#" + itemID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 3, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LogupdateItem(string logID, string userID, string itemID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " UPDATE item#" + itemID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 2, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LoginsertUser(string logID, string userID, string userName, string title)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " CREATE " + title + " (#" + userID + ")";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 1, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LogupdateUserInf(string logID, string contrUserID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + contrUserID + " UPDATE user#" + userID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 2, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", contrUserID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LogdeleteRecordInv(string logID, string userID, string invoiceID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " DELETE invoice#" + invoiceID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 3, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LogverityUser(string logID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " Login ";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 4, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LoginsertOrderReturn(string logID, string userID, string orderID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " CREATE Return Order#" + orderID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 1, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LoginsertOrderReturn(string logID, string userID, string orderID, string itemID, string qty)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " CREATE Return item#" + itemID + " " + qty + "qty " + "in Order#" + orderID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 1, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LogdeleteUser(string logID, string contrUserID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + contrUserID + " DELETE user#" + userID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 1, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", contrUserID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LogorderUpdate(string logID, string userID, string orderID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " UPDATE order#" + orderID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 2, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool Loglogout(string logID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " Logout";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 5, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public bool LogupdateOrderHold(string logID, string userID, string orderID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " UPDATE order#"+orderID+" STATUS";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 5, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool LogABC(string logID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " Expand Excel";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 6, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool LoginsertMessage(string logID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " Add Message";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 1, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }


        public bool LogupdateMessage(string logID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " Edit Message";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 2, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable getReportCount()
        {
            string sql = "SELECT item.itemID, MAX(orderitem.qtyOrdered) FROM item, orderitem WHERE orderitem.itemID = item.itemID GROUP BY item.itemID ORDER BY MAX(orderitem.qtyOrdered) DESC";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getSalesReport()
        {
            string sql = "SELECT item.itemID, orderitem.qtyOrdered, orderitem.salePrice, purPrice FROM item, orderitem WHERE orderitem.itemID = item.itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable DataFilterReportSalesCatItem(string itemID ,string cat)
        {
            string sql = "SELECT item.itemID, orderitem.qtyOrdered, orderitem.salePrice, purPrice FROM item, orderitem WHERE orderitem.itemID = item.itemID AND itemCategory=@itemCategory AND item.itemID = @itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@itemCategory", cat);
            cmd.Parameters.AddWithValue("@itemID", itemID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }
        

        
        public DataTable getSalesReportItem()
        {
            string sql = "SELECT itemID FROM item";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable DataFilterReportSalesItem(string item)
        {
            string sql = "SELECT item.itemID,  orderitem.qtyOrdered, orderitem.salePrice, purPrice FROM item, orderitem WHERE orderitem.itemID = item.itemID AND item.itemID=@itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@itemID", item);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable DataFilterReportSalesCat(string cal)
        {
            string sql = "SELECT item.itemID, orderitem.qtyOrdered, orderitem.salePrice, purPrice FROM item, orderitem WHERE orderitem.itemID = item.itemID AND itemCategory=@itemCategory";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@itemCategory", cal);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }



        public bool LogPrintStockReport(string logID, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " Print the Stock Record Report";
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 2, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool checkInv(string orderID)
        {
            string sql = "SELECT * FROM invoice WHERE orderID=@orderID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@orderID", orderID);
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            if (dataTable !=null)
                return true;
            else
                return false;

        }

        public string getDeliveryID()
        {
            string sql = "SELECT MAX(RIGHT(deliveryID,8)) FROM delivery";
            MySqlCommand cmod = new MySqlCommand(sql, ServerConnect());
            Object DeliveryID = cmod.ExecuteScalar();//MySqlDataReader for one line result

            if (DeliveryID == null) {
                string ID = "0";
                return ID.ToString();
            } else
                return DeliveryID.ToString();
        }



        public string getMMFormID()
        {
            string sql = "SELECT MAX(RIGHT(mesID,4)) FROM mergmessages";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            Object mmFormID = cmd.ExecuteScalar();
            return mmFormID.ToString();
        }

        public bool insertMessage(string mmID, string title, string desp, string userID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "INSERT INTO mergmessages VALUES(@mmID, @title, @desp, @userID, 1, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@mmID", mmID);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@desp", desp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool updateMessage(string title, string mergDes, string userID, string mmID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            Debug.WriteLine(mmID);
            Debug.WriteLine(title);
            Debug.WriteLine(mergDes);
            Debug.WriteLine(userID);

            string sql = "UPDATE mergmessages SET Title=@title, mergDes=@mergDes, mergDT=@theDate WHERE mesID=@mmID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@mergDes", mergDes);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@mmID", mmID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public DataTable getMMForm(String mesID)
        {
            string sql = "SELECT * FROM mergmessages WHERE mesID=@mesID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@mesID", mesID);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

       

       

        //UPDATE tableNAME SET Status=!status WHERE mesID=@mesID;

        public bool updateComplete(String orderID, String itemID, String itemQty)
        {
            string sql = "UPDATE item Set quantityInStock=quantityInStock+@quantityInStock WHERE itemID=@itemID; DELETE FROM orderreturn WHERE orderID=@orderID and itemID=@itemID";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@quantityInStock", itemQty);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@itemID", itemID);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;


        }

        public DataTable findMMFDIS()
        {
            string sql = "SELECT mesID, merStatus FROM mergmessages WHERE merStatus=1 ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }

        public DataTable getMMForm()
        {
            string sql = "SELECT mesID, Title, mergDes FROM mergmessages WHERE merStatus=1 ";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            MySqlDataAdapter adat = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adat.Fill(dataTable);
            return dataTable;
        }


        public bool LoginsertDelivery(string logID,string userID, string deliveryID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " CREATE the Delivery #" + deliveryID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 1, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;
        }

        public bool LogdeleteRecord(string logID, string userID, string orderID)
        {
            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd HH:mm:ss");
            string Descp = "#" + userID + " Delete the SalesOrder Record" + "#" + orderID;
            string sql = "INSERT INTO logging VALUES(@logID, @Descp, @userID, 3, @theDate)";
            MySqlCommand cmd = new MySqlCommand(sql, ServerConnect());
            cmd.Parameters.AddWithValue("@logID", logID);
            cmd.Parameters.AddWithValue("@Descp", Descp);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@theDate", theDate);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            return false;

        }


    }


}






