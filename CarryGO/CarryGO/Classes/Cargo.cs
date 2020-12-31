using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CarryGO.Classes
{
    class Cargo
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\onursercanyilmaz\Documents\GitHub\CarryGO\CarryGO\CarryGO\CarryGODB.mdf;Integrated Security=True;Connect Timeout=30");
       
        int cargo_id;
        object transaction_id;
        int billing_id;
        int customer_id;
        int enquiry_id;
        string sender_name;

        public int CargoID { get => cargo_id; set => cargo_id = value; }
        public object TransactionID { get => transaction_id; set => transaction_id = value; }
        public int BillingID { get => billing_id; set => billing_id = value; }
        public int CustomerID { get => customer_id; set => customer_id = value; }
        public int EnquiryID { get => enquiry_id; set => enquiry_id = value; }
        public string SenderName { get => sender_name; set => sender_name = value; }

        public void AddCargo(object TransactionID, int BillingID, int CustomerID, string EnquiryID) 
        {
            //Comboboxta girilen TransactionID
            //AddBilling adlı fonksiyonun ardından AddCargo çalışacak.
            //Add butonu hem AddBilling hem AddCargo fonksiyonunu içerecek
            //EnquiryID için textbox readonly olacak ve oraya random atama yapılacak, Add butonu ile
            try
            {
                string query = "INSERT INTO Cargo(TransactionID,BillingID,CustomerID,EnquiryID) VALUES (@TransactionID,@BillingID,@CustomerID,@EnquiryID)";
                databaseHelper.ExecuteQuery(query);
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@TransactionID", TransactionID);
                cmd.Parameters.AddWithValue("@BillingID", BillingID);
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@EnquiryID", EnquiryID);
              
                sqlcon.Open();
                cmd.ExecuteNonQuery();

                sqlcon.Close();



            }
            catch (Exception ex)
            {
                throw new Exception("Adding Cargo Error: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }

        }
        public void DeleteCargo()
        { }
        public void UpdateCargo()
        { }
        public void SearchCargo() 
        { }
        public void ViewCargo(DataGridView dgv)
        {
            string query = "SELECT co.CustomerID AS ReceiverID, cr.CustomerName +' '+ cr.CustomerLastName AS Receiver, co.Sender, cr.CustomerAddress AS ReceiverAddress,co.EnquiryID ,tn.TransactionName AS TransactionStatus,bg.Price, pt.PaymentName,bg.BillingID FROM Cargo AS co "+ 
                            "INNER JOIN Customer AS cr ON cr.CustomerID = co.CustomerID "+
                            "INNER JOIN Billing as bg ON bg.CustomerID = co.CustomerID "+
                            "INNER JOIN Transactions AS tn ON tn.TransactionID = co.TransactionID "+
                            "INNER JOIN Payment AS pt ON pt.PaymentID = bg.PaymentID";

            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            dgv.DataSource = dtb;
            sqlcon.Close();
        }


        public  void SearchByEnquiry(int EnquiryID, DataGridView dgv)
        {
            try
            {

                sqlcon.Open();


                string query = "SELECT co.CustomerID AS ReceiverID, cr.CustomerName +' '+ cr.CustomerLastName AS Receiver, co.Sender, cr.CustomerAddress AS ReceiverAddress,co.EnquiryID ,tn.TransactionName AS TransactionStatus,bg.Price,bg.BillingID FROM Cargo AS co " +
                            "INNER JOIN Customer AS cr ON cr.CustomerID = co.CustomerID " +
                            "INNER JOIN Billing as bg ON bg.CustomerID = co.CustomerID " +
                            "INNER JOIN Transactions AS tn ON tn.TransactionID = co.TransactionID " +
                            "WHERE EnquiryID = '" + EnquiryID + "' ";
                       

                //"SELECT * FROM Cargo WHERE EnquiryID = '" + EnquiryID + "'" ;
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dgv.DataSource = dtbl;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Finding Cargo Error: " + ex.Message);

            }
            finally
            {
                sqlcon.Close();
            }
        }

        public void ListDelivered(DataGridView dgv)
        {
            try
            {

                sqlcon.Open();


                string query = "SELECT co.CustomerID AS ReceiverID, cr.CustomerName +' '+ cr.CustomerLastName AS Receiver, co.Sender, cr.CustomerAddress AS ReceiverAddress,co.EnquiryID ,tn.TransactionName AS TransactionStatus,bg.Price,bg.BillingID FROM Cargo AS co " +
                            "INNER JOIN Customer AS cr ON cr.CustomerID = co.CustomerID " +
                            "INNER JOIN Billing as bg ON bg.CustomerID = co.CustomerID " +
                            "INNER JOIN Transactions AS tn ON tn.TransactionID = co.TransactionID " +
                            "WHERE co.TransactionID = 3 ";


                //"SELECT * FROM Cargo WHERE EnquiryID = '" + EnquiryID + "'" ;
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dgv.DataSource = dtbl;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Finding Cargo Error: " + ex.Message);

            }
            finally
            {
                sqlcon.Close();
            }
        }

        public void ListInTransaction(DataGridView dgv)
        {
            try
            {

                sqlcon.Open();


                string query = "SELECT co.CustomerID AS ReceiverID, cr.CustomerName +' '+ cr.CustomerLastName AS Receiver, co.Sender, cr.CustomerAddress AS ReceiverAddress,co.EnquiryID ,tn.TransactionName AS TransactionStatus,bg.Price,bg.BillingID FROM Cargo AS co " +
                            "INNER JOIN Customer AS cr ON cr.CustomerID = co.CustomerID " +
                            "INNER JOIN Billing as bg ON bg.CustomerID = co.CustomerID " +
                            "INNER JOIN Transactions AS tn ON tn.TransactionID = co.TransactionID " +
                            "WHERE co.TransactionID = 1 OR co.TransactionID = 2  ";


                //"SELECT * FROM Cargo WHERE EnquiryID = '" + EnquiryID + "'" ;
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dgv.DataSource = dtbl;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Finding Cargo Error: " + ex.Message);

            }
            finally
            {
                sqlcon.Close();
            }
        }

    }
}
