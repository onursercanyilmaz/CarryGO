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
using System.Text.RegularExpressions;

namespace CarryGO.Classes
{
    public static class  databaseHelper
    {

        //For Select
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)

         {
            try
            {
                //string connect = ConfigurationManager.AppSettings["connectString"];
                string connect = databaseHelper.ReadConfigParameter("connectString");
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
                // string connect = ConfigurationManager.AppSettings["connectString"];
                string connect = databaseHelper.ReadConfigParameter("connectString");
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
                //string connect = ConfigurationManager.AppSettings["connectString"];
                string connect = databaseHelper.ReadConfigParameter("connectString");
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

        //-------------DB------------------------
        public static void CreateDatabase(string query, string connectionString)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection.State == ConnectionState.Open)
                {
                    List<string> commandStrings = Regex.Split(query, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase)
                        .ToList();

                    foreach (string sql in commandStrings)
                    {
                        if (!string.IsNullOrWhiteSpace(sql))
                        {
                            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Create DB Error: " + ex.Message);
            }


        }
        //-------------------------------------

        public static string ReadConfigParameter(string key)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                return config.AppSettings.Settings[key].Value;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void  WriteConfigParameter(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                 config.AppSettings.Settings[key].Value = value;

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
