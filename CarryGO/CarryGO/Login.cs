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

namespace CarryGO
{
    
    public partial class Login : Form
    {
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
    }
}
