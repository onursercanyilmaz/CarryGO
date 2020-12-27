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
       


        public void AddCargo() 
        { }
        public void DeleteCargo()
        { }
        public void UpdateCargo()
        { }
        public void SearchCargo() 
        { }
        public void ViewCargo(DataGridView dgv)
        {
            string query = "SELECT co.CustomerID AS ReceiverID, cr.CustomerName +' '+ cr.CustomerLastName AS Receiver, co.Sender, cr.CustomerAddress AS ReceiverAddress,co.EnquiryID ,tn.TransactionName AS TransactionStatus, pt.PaymentName,bg.BillingID FROM Cargo AS co "+ 
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


        
    }
}
