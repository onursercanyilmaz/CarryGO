using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarryGO.userControls
{
    public partial class ucAbout : UserControl
    {
        public ucAbout()
        {
            InitializeComponent();
        }

        private void ucAbout_Load(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.ScrollBarsEnabled = true;
                webBrowser1.Navigate(new Uri("https://sites.google.com/view/onursercanyilmaz"));
            }
            catch (Exception)
            {
                label3.Text = "Please check your internet connection!";          
            }
            

        }
    }
}
