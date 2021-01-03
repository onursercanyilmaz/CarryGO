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
        string enquiry_id;
        string sender_name;

        public int CargoID { get => cargo_id; set => cargo_id = value; }
        public object TransactionID { get => transaction_id; set => transaction_id = value; }
        public int BillingID { get => billing_id; set => billing_id = value; }
        public int CustomerID { get => customer_id; set => customer_id = value; }
        public string EnquiryID { get => enquiry_id; set => enquiry_id = value; }
        public string Sender { get => sender_name; set => sender_name = value; }

        public void AddCargo(object TransactionID, int BillingID, int CustomerID, string EnquiryID, string SenderName) 
        {
            //Comboboxta girilen TransactionID
            //AddBilling adlı fonksiyonun ardından AddCargo çalışacak.
            //Add butonu hem AddBilling hem AddCargo fonksiyonunu içerecek
            //EnquiryID için textbox readonly olacak ve oraya random atama yapılacak, Add butonu ile
            try
            {
                string query = "INSERT INTO Cargo(TransactionID,BillingID,CustomerID,EnquiryID,Sender) VALUES (@TransactionID,@BillingID,@CustomerID,@EnquiryID,@Sender)";


                SqlParameter[] parameters = new SqlParameter[5];

                parameters[0] = new SqlParameter("TransactionID", TransactionID);
                parameters[1] = new SqlParameter("BillingID", BillingID);
                parameters[2] = new SqlParameter("CustomerID", CustomerID);
                parameters[3] = new SqlParameter("EnquiryID", EnquiryID);
                parameters[4] = new SqlParameter("Sender", SenderName);

                databaseHelper.ExecuteNonQuery(query, parameters);

                //SqlCommand cmd = new SqlCommand(query, sqlcon);
                
                
                //cmd.Parameters.AddWithValue("@TransactionID", TransactionID);
                //cmd.Parameters.AddWithValue("@BillingID", BillingID);
                //cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                //cmd.Parameters.AddWithValue("@EnquiryID", EnquiryID);
              
                //sqlcon.Open();
                //cmd.ExecuteNonQuery();

                //sqlcon.Close();



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
        public void DeleteCargo(int CargoID)
        {
            try
            {
                string query = "DELETE FROM Cargo WHERE CargoID = @CargoID";

                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("CargoID", CargoID);

                databaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {

                throw new Exception("Deleting Cargo Error: " + ex.Message);
            }

        }
        public void UpdateCargo(int CargoID, object TransactionID, int BillingID, int CustomerID, string EnquiryID, string Sender)
        {
            try
            {
               
                string query = "UPDATE Cargo SET TransactionID=@TransactionID,BillingID=@BillingID,CustomerID=@CustomerID,EnquiryID=@EnquiryID,Sender=@Sender WHERE CargoID=@CargoID";
                SqlParameter[] parameters = new SqlParameter[6];

                parameters[0] = new SqlParameter("CargoID", CargoID);
                parameters[1] = new SqlParameter("TransactionID", TransactionID);
                parameters[2] = new SqlParameter("BillingID", BillingID);
                parameters[3] = new SqlParameter("CustomerID", CustomerID);
                parameters[4] = new SqlParameter("EnquiryID", EnquiryID);
                parameters[5] = new SqlParameter("Sender", Sender);

                databaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Updating Cargo Error: " + ex.Message);
            }
           
           

            
        }
        

        public void ViewCargo(DataGridView dgv)
        {
            string query = "SELECT co.CargoID, co.CustomerID AS ReceiverID, cr.CustomerName AS ReceiverName, cr.CustomerLastName AS ReceiverLastName, co.Sender, cr.CustomerAddress AS ReceiverAddress,co.EnquiryID ,tn.TransactionName AS TransactionStatus,bg.Price, pt.PaymentName, bg.BillingID, cr.CustomerEmail FROM Cargo AS co "+ 
                            "INNER JOIN Customer AS cr ON cr.CustomerID = co.CustomerID "+
                            "INNER JOIN Billing as bg ON bg.CustomerID = co.CustomerID "+
                            "INNER JOIN Transactions AS tn ON tn.TransactionID = co.TransactionID "+
                            "INNER JOIN Payment AS pt ON pt.PaymentID = bg.PaymentID";


            databaseHelper.ExecuteQuerys(query, dgv);
            //sqlcon.Open();
            //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            //DataTable dtb = new DataTable();
            //sda.Fill(dtb);

            //dgv.DataSource = dtb;

        }


        public  void SearchByEnquiry(string EnquiryID, DataGridView dgv)
        {
            try
            {


                string query = "SELECT co.CustomerID AS ReceiverID, cr.CustomerName +' '+ cr.CustomerLastName AS Receiver, co.Sender, cr.CustomerAddress AS ReceiverAddress,co.EnquiryID ,tn.TransactionName AS TransactionStatus,bg.Price,bg.BillingID FROM Cargo AS co " +
                            "INNER JOIN Customer AS cr ON cr.CustomerID = co.CustomerID " +
                            "INNER JOIN Billing as bg ON bg.CustomerID = co.CustomerID " +
                            "INNER JOIN Transactions AS tn ON tn.TransactionID = co.TransactionID " +
                            "WHERE EnquiryID = '" + EnquiryID + "' ";

                databaseHelper.ExecuteQuerys(query, dgv);
                ////"SELECT * FROM Cargo WHERE EnquiryID = '" + EnquiryID + "'" ;
                //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                //DataTable dtbl = new DataTable();
                //sda.Fill(dtbl);
                //dgv.DataSource = dtbl;
                //sqlcon.Close();
            }
            catch (Exception)
            {
                throw;

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
                databaseHelper.ExecuteQuerys(query, dgv);

                ////"SELECT * FROM Cargo WHERE EnquiryID = '" + EnquiryID + "'" ;
                //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                //DataTable dtbl = new DataTable();
                //sda.Fill(dtbl);
                //dgv.DataSource = dtbl;
                //sqlcon.Close();
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
                databaseHelper.ExecuteQuerys(query, dgv);

                ////"SELECT * FROM Cargo WHERE EnquiryID = '" + EnquiryID + "'" ;
                //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                //DataTable dtbl = new DataTable();
                //sda.Fill(dtbl);
                //dgv.DataSource = dtbl;
                //sqlcon.Close();
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
