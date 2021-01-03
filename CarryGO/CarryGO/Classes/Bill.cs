using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarryGO.Classes
{
    class Bill
    {


        int bill_id;
        object payment_id;
        int customer_id;
        int price;

        public object PaymentID { get => payment_id; set => payment_id = value; }
        public int CustomerID { get => customer_id; set => customer_id = value; }
        public int Price { get => price; set => price = value; }
        public int BillID { get => bill_id; set => bill_id = value; }

        public void AddBill(object PaymentID, int CustomerID, int Price)
        {
            //Bill 
            try
            {
                string query = "INSERT INTO Billing(PaymentID,CustomerID,Price) VALUES (@PaymentID,@CustomerID,@Price)";
                SqlParameter[] parameters = new SqlParameter[3];

                parameters[0] = new SqlParameter("PaymentID", PaymentID);
                parameters[1] = new SqlParameter("CustomerID", CustomerID);
                parameters[2] = new SqlParameter("Price", Price);

                databaseHelper.ExecuteNonQuery(query, parameters);
                
                
                //SqlCommand cmd = new SqlCommand(query, sqlcon);
                //cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
                //cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                //cmd.Parameters.AddWithValue("@Price", Price);


                //sqlcon.Open();
                //cmd.ExecuteNonQuery();

                //sqlcon.Close();



            }
            catch (Exception ex)
            {
                throw new Exception("Adding Bill Error: " + ex.Message);
            }
          
        }

        public void ReadBillID(DataGridView dgv)
        {
            //Bill 
            try
            {
                //string query = "SELECT TOP(1) BillingID FROM Billing ORDER BY 1 DESC";
                string query = "SELECT MAX(BillingID) AS BillingID FROM Billing";

                databaseHelper.ExecuteQuerys(query,dgv);
        

               


            }
            catch (Exception ex)
            {
                throw new Exception("Adding Bill Error: " + ex.Message);
            }

     
        }


        public void DeleteBill(int BillID)
        {
            try
            {
                string query = "DELETE FROM Billing WHERE BillingID = @BillingID";

                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("BillingID", BillID);

                databaseHelper.ExecuteNonQuery(query,parameters);
            }
            catch (Exception ex)
            {

                throw new Exception("Deleting Bill Error: " + ex.Message);
            }

        }
    }
}
