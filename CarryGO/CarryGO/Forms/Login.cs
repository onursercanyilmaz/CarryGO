using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using CarryGO.Classes;
using CarryGO.Forms;

namespace CarryGO
{ 
    public partial class Login : Form
    {
        
        Employee employee = new Employee();
        public Login()
        {
            
            InitializeComponent();
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "C:/Users/onursercanyilmaz/Documents/GitHub/CarryGO/CarryGO/CarryGO/Items/welcometoCarryGo.mp3";
            wplayer.controls.play();
            
        }

        


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();     
            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpPage helpPage = new HelpPage();
            helpPage.Show();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idBox.Text.Trim().ToString());
                int password = int.Parse(passwordBox.Text.Trim().ToString());
             
                var emp = employee.Login(id, password);
                if (emp != null)
                {
                    MainPage main = new MainPage();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    errorLabel.Text = "ID or Password is incorrect.";
                    errorLabel.ForeColor = Color.Coral;
                }



              
            }
            catch (Exception)
            {

                errorLabel.Text  = "Please check you ID or Password!";
            }
           

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            int isDbReady = int.Parse(databaseHelper.ReadConfigParameter("isDBReady"));

            if(isDbReady == 0)
            {
                var result = MessageBox.Show("You need to configure your database.\n Do now?",
                    "System Config Information", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    formSettings form = new formSettings();
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog();
                }
              
            }
        }
    }

}
