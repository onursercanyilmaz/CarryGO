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
    public partial class ucDelivered : UserControl
    {
        Cargo cargo = new Cargo();
        public ucDelivered()
        {
            InitializeComponent();
        }

        private void ucDelivered_Load(object sender, EventArgs e)
        {
            try
            {
                cargo.ListDelivered(dataDelivered);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
