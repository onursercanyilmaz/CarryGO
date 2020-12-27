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
    public partial class ucNewCargo : UserControl
    {
        Cargo cargo = new Cargo();
        
        public ucNewCargo()
        {
            InitializeComponent();
            

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ucNewCargo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carryGODBDataSet.Billing' table. You can move, or remove it, as needed.
            this.billingTableAdapter.Fill(this.carryGODBDataSet2.Billing);
            // TODO: This line of code loads data into the 'carryGODBDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.carryGODBDataSet2.Payment);

            this.transactionsTableAdapter.Fill(this.carryGODBDataSet2.Transactions);
            // TODO: This line of code loads data into the 'carryGODBDataSet.Payment' table. You can move, or remove it, as needed.
            this.cargoTableAdapter.Fill(this.carryGODBDataSet2.Cargo);

        
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                cargo.ViewCargo(dataCargo);
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
