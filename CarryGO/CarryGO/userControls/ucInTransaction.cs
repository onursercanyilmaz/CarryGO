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
    public partial class ucInTransaction : UserControl
    {
        Cargo cargo = new Cargo();

        public ucInTransaction()
        {
            InitializeComponent();
        }

        private void ucInTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                cargo.ListInTransaction(dataTransaction);
            }
            catch (Exception)
            {
                errorLabel.Text = "Cargo couldn't found!";
            }
            
        }
    }
}
