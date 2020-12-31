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
using CarryGO.userControls;


namespace CarryGO.userControls
{
    public partial class ucNewCargo : UserControl
    {
        Cargo cargo = new Cargo();
        Bill bill = new Bill();
        Customer customer = new Customer();
        
        public ucNewCargo()
        {
            InitializeComponent();
            Random rand = new Random();
            EnquiryBox.Text = rand.Next(1000000, 9999999).ToString();

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


      

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                //Add Bill
                //...
                object payment_id = PaymentComboBox.SelectedValue;
                //int customer_id;
                int price = int.Parse(PriceBox.Text);

                //Add Cargo
                //int TransactionID, int BillingID, int CustomerID, int EnquiryID

                object transaction_id = TransactionComboBox.SelectedValue;
                int billing_id = 5;
                int customer_id = 5;
               
                string enquiry_id = EnquiryBox.Text;

             
                errorLabel.Text = " ";
                //string name = FirstNameBox.Text.Trim();
                //string lastname = LastNameBox.Text.Trim();
                //object gender = GenderComboBox.SelectedValue;
                //string email = EmailBox.Text.Trim();
                //int password = int.Parse(PasswordBox.Text.Trim().ToString());
                //string address = AddressBox.Text.Trim();
                //long phone = long.Parse(PhoneBox.Text.Trim().ToString());
                //object departmentID = DepartmentComboBox.SelectedValue;


                //if (!ValidateEmail(email))
                //{
                //    errorLabel.Text = "Please enter correct e-mail!";
                //    EmailBox.Focus();
                //    errorLabel.ForeColor = Color.Red;
                //    return;
                //}

                //employee.Add(name, lastname, gender, email, password, address, phone, departmentID);
                //errorLabel.Text = "Employee successfully added";
                //errorLabel.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                errorLabel.Text = " ";
                //errorLabel.Text = "An error occured while adding a new employee";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            cargo.ViewCargo(dataCargo);
        }

        
 
        
    }
}
