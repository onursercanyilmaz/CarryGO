using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CarryGO.Classes
{
    class Bill
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\onursercanyilmaz\Documents\GitHub\CarryGO\CarryGO\CarryGO\CarryGODB.mdf;Integrated Security=True;Connect Timeout=30");


        object payment_id;
        int customer_id;
        int price;

        public object PaymentID { get => payment_id; set => payment_id = value; }
        public int CustomerID { get => customer_id; set => customer_id = value; }
        public int Price { get => price; set => price = value; }

        public void AddBill(object PaymentID, int CustomerID, int Price)
        {
            //Bill 
            try
            {
                string query = "INSERT INTO Cargo(PaymentID,CustomerID,Price) VALUES (@PaymentID,@CustomerID,@Price)";
                databaseHelper.ExecuteQuery(query);
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@Price", Price);


                sqlcon.Open();
                cmd.ExecuteNonQuery();

                sqlcon.Close();



            }
            catch (Exception ex)
            {
                throw new Exception("Adding Bill Error: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
