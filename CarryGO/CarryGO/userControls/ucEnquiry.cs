using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarryGO.Classes;

namespace CarryGO.userControls
{
    public partial class ucEnquiry : UserControl
    {
        Cargo cargo = new Cargo();
        public ucEnquiry()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(EnquiryBox.Text.Trim());
                cargo.SearchByEnquiry(id, dataCargo);
                errorLabel.Text = "✔️ Cargo successfully found!";

                if(dataCargo.Rows.Count <= 1)
                    errorLabel.Text = "❌ Cargo couldn't found!";
            }
            catch (Exception ex)
            {
                errorLabel.Text = "❌ Cargo couldn't found!";
            }
           
        }
    }
}
