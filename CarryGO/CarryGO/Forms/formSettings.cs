using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarryGO.Classes;

namespace CarryGO.Forms
{
    public partial class formSettings : Form
    {
        public formSettings()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = dialog.SelectedPath;
            }
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            try
            {
                string server = serverBox.Text.Trim();
                string database = dbBox.Text.Trim();
                string dbUserID = idBox.Text.Trim();
                string dbpassword = passBox.Text.Trim();
                string dbpath = pathBox.Text.Trim();

                string conString = $@"Data Source={server};Database={database};Trusted_Connection=True";

                if(!checkBox1.Checked)
                {
                    string userdetails = $"User Id={dbUserID}; Password={dbpassword};";
                    conString = conString.Replace("Trusted_Connection=True",userdetails);
                }

                databaseHelper.WriteConfigParameter("server", server);
                databaseHelper.WriteConfigParameter("database",database);
                databaseHelper.WriteConfigParameter("dbuserid",dbUserID);
                databaseHelper.WriteConfigParameter("dbpassword",dbpassword);
                databaseHelper.WriteConfigParameter("dbpath",dbpath);
                databaseHelper.WriteConfigParameter("connectString",conString);

                string scriptPath = databaseHelper.ReadConfigParameter("dbscript");

                if(!File.Exists(scriptPath))
                {
                    throw new Exception("DB couldn't found!");
                }

                string sqlScript = File.ReadAllText(scriptPath);

                sqlScript = sqlScript.Replace("[dbName]",database);
                sqlScript = sqlScript.Replace("{primaryDbFile}", dbpath +"\\"+ database);
                sqlScript = sqlScript.Replace("{logDbFile}", dbpath + "\\" + database);
           
               

                string ConStringmaster = $@"Data Source={server};Database=master;Trusted_Connection=True";

                if (!checkBox1.Checked)
                {
                    string userdetails = $"User Id={dbUserID}; Password={dbpassword};";
                    ConStringmaster = ConStringmaster.Replace("Trusted_Connection=True", userdetails);
                }

                databaseHelper.CreateDatabase(sqlScript,ConStringmaster);
                databaseHelper.WriteConfigParameter("isDBReady", "1");

                errorLabel.Text = "Configuration completed successfully!";

                if (errorLabel.Text == "Configuration completed successfully!")
                {
                    MessageBox.Show("Create an account to login.");
                    AddEmployeePage log = new AddEmployeePage();
                    this.Hide();
                    log.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                errorLabel.Text = "Be sure to complete all DB information!";
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                idBox.ReadOnly = true;
                passBox.ReadOnly = true;
            }
            else
            {
                idBox.ReadOnly = false;
                passBox.ReadOnly = false;
            }
        }
    }
}
