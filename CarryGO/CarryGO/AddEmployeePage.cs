using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarryGO
{
    public partial class AddEmployeePage : Form
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployeePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carryGODBDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.carryGODBDataSet.Department);
            // TODO: This line of code loads data into the 'carryGODBDataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.carryGODBDataSet.Gender);

        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpPage helpPage = new HelpPage();
            helpPage.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
