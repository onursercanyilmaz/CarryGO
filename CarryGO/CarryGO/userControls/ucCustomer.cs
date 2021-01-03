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
    public partial class ucCustomer : UserControl
    {
        Customer customer = new Customer();
        public ucCustomer()
        {
            InitializeComponent();
        }

        private bool ValidateEmail(string email)
        {
            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(email);
                return emailAddress.Address == email;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ucCustomer_Load(object sender, EventArgs e)
        {
            this.genderTableAdapter.Fill(this.carryGODBDataSet2.Gender);
            this.customerTableAdapter.Fill(this.carryGODBDataSet2.Customer);
            customer.View(dataCustomer);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string name = CustomerNameBox.Text.Trim();
                string lastname = CustomerLastNameBox.Text.Trim();
                object gender = GenderComboBox.SelectedValue;
                string mail = MailBox.Text.Trim();
                long phone = long.Parse(PhoneBox.Text.Trim());
                string address = AddressBox.Text.Trim();
                int pass = 0;

                customer.Add(name, lastname, gender, mail, pass, address, phone);
                errorLabel.Text = "✔️ Customer successfully added!";
                customer.View(dataCustomer);
            }
            catch (Exception )
            {

                errorLabel.Text = "❌ Adding Customer Error!";
                //MessageBox.Show(ex.Message);
            }
            


        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                customer.View(dataCustomer);
                errorLabel.Text = "";
            }
            catch (Exception)
            {
                errorLabel.Text = "❌ Customer data view error!";
            }
            
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Text = " ";
                int id = int.Parse(dataCustomer.CurrentRow.Cells[0].Value.ToString());
                customer.Delete(id);
                customer.View(dataCustomer);

                errorLabel.Text = "✔️ Customer Successfully Deleted!";
               
            }
            catch (Exception )
            {

                errorLabel.Text = "❌ Customer Couldn't Deleted!";

            }

        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IDBox.Text.ToString());
                string name = CustomerNameBox.Text.Trim();
                string lastname = CustomerLastNameBox.Text.Trim();
                object gender = GenderComboBox.SelectedValue;
                string email = MailBox.Text.Trim();
                int password = 0;
                string address = AddressBox.Text.Trim();
                long phone = long.Parse(PhoneBox.Text.Trim().ToString());
                


                if (!ValidateEmail(email))
                {
                    errorLabel.Text = "Please enter correct e-mail!";
                    MailBox.Focus();
                    errorLabel.ForeColor = Color.Red;
                    return;
                }

                customer.Update(id, name, lastname, gender, email, password, address, phone);
                customer.View(dataCustomer);
                errorLabel.Text = "✔️ Customer successfully updated";
                
            }
            catch (Exception )
            {

                errorLabel.Text = "❌ Customer coulnd't updated!";
            }
        }

        private void dataCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            //fill the texbox and combobox with Customer table data
            IDBox.Text = dataCustomer.CurrentRow.Cells[0].Value.ToString();
            CustomerNameBox.Text = dataCustomer.CurrentRow.Cells[1].Value.ToString();
            CustomerLastNameBox.Text = dataCustomer.CurrentRow.Cells[2].Value.ToString();
            PhoneBox.Text = dataCustomer.CurrentRow.Cells[3].Value.ToString();
            AddressBox.Text = dataCustomer.CurrentRow.Cells[4].Value.ToString();
            MailBox.Text = dataCustomer.CurrentRow.Cells[5].Value.ToString();
            GenderComboBox.SelectedValue = dataCustomer.CurrentRow.Cells[6].Value.ToString();
           
        }

        private void btnSearchbyName_Click(object sender, EventArgs e)
        {

            try
            {
                errorLabel.Text = " ";
                string name = CustomerNameBox.Text.Trim();
                customer.SearchByName(name,dataCustomer);

                if(dataCustomer.Rows.Count>0)
                    errorLabel.Text = "✔️ Customer successfully found!";
                else
                    errorLabel.Text = "❌ Customer coulnd't found!";

            }
            catch (Exception)
            {
                errorLabel.Text = "❌ Customer coulnd't found!";

            }

        }
    }
}
