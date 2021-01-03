using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarryGO.Classes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO.Packaging;
using System.Windows.Forms;

namespace CarryGO.Classes
{
    public static class  databaseHelper
    {

        //For Select
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)

         {
            try
            {
                string connect = ConfigurationManager.AppSettings["connectString"];
                SqlConnection sqlcon = new SqlConnection(connect);
                sqlcon.Open();

                if (sqlcon.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(query, sqlcon);

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    DataTable dtb = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dtb);

                    return dtb;

                }
                else
                    return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Error : " + ex.Message );
            }
          
         }


        public static DataTable ExecuteQuerys(string query, DataGridView dgv ,SqlParameter[] parameters = null)

        {
            try
            {
                string connect = ConfigurationManager.AppSettings["connectString"];
                SqlConnection sqlcon = new SqlConnection(connect);
                sqlcon.Open();

                if (sqlcon.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(query, sqlcon);

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    DataTable dtb = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dtb);
                    dgv.DataSource = dtb;

                    return dtb;

                }
                else
                    return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Error : " + ex.Message);
            }
            
        }
          



        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                string connect = ConfigurationManager.AppSettings["connectString"];
                SqlConnection sqlcon = new SqlConnection(connect);
                sqlcon.Open();

                if (sqlcon.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand(query, sqlcon);

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Error: "+ex.Message);
            }
           

        }

       

    }
}
