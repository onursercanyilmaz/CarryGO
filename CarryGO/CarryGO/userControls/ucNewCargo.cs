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
using CarryGO.Forms;
using CarryGO.userControls;


namespace CarryGO.userControls
{
    public partial class ucNewCargo : UserControl
    {
        Cargo cargo = new Cargo();
        Bill bill = new Bill();
        Customer customer = new Customer();
        private bool buttonWasClicked = false;

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

                //Add Cargo
                //int TransactionID, int BillingID, int CustomerID, int EnquiryID

                object transaction_id = TransactionComboBox.SelectedValue;
                int billing_id = int.Parse(BillingIDBox.Text.Trim());
                int customer_id = int.Parse(ReceiverID.Text.ToString());
                string enquiry_id = EnquiryBox.Text;
                string sender_name = SenderBox.Text.Trim();

                cargo.AddCargo(transaction_id,billing_id,customer_id,enquiry_id,sender_name);
                dataCargo.Refresh();
                
                errorLabel.Text = "✔️ Cargo successfully added";
                
            }
            catch (Exception ex )
            {
               // errorLabel.Text = "❌ Cargo couldn't added!";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                buttonWasClicked = false;
                cargo.ViewCargo(dataCargo);
                dataCargo.Columns[11].Visible = false;
            }
            catch (Exception)
            {

                errorLabel.Text = "Cargo details couldn't load!";
            }
            
        }

        private void btnSeeOldCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                buttonWasClicked = true;
                customer.View(dataCargo);
               
            }
            catch (Exception)
            {
                errorLabel.Text = "Customers couldn't load!";
            }
            

        }

        private void dataCargo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (buttonWasClicked == true)
                {
                    //Customer
                    ReceiverID.Text = dataCargo.CurrentRow.Cells[0].Value.ToString();
                    ReceiverName.Text = dataCargo.CurrentRow.Cells[1].Value.ToString();
                    ReceiverLastName.Text = dataCargo.CurrentRow.Cells[2].Value.ToString();
                    AddressBox.Text = dataCargo.CurrentRow.Cells[4].Value.ToString();

                }
                else 
                { //Cargo
                    CargoIDBox.Text = dataCargo.CurrentRow.Cells[0].Value.ToString();
                    ReceiverID.Text = dataCargo.CurrentRow.Cells[1].Value.ToString();
                    ReceiverName.Text = dataCargo.CurrentRow.Cells[2].Value.ToString();
                    ReceiverLastName.Text = dataCargo.CurrentRow.Cells[3].Value.ToString();
                    SenderBox.Text = dataCargo.CurrentRow.Cells[4].Value.ToString();
                    AddressBox.Text = dataCargo.CurrentRow.Cells[5].Value.ToString();
                    PriceBox.Text = dataCargo.CurrentRow.Cells[8].Value.ToString();
                    EnquiryBox.Text = dataCargo.CurrentRow.Cells[6].Value.ToString();
                   // BillingIDBox.Text = dataCargo.CurrentRow.Cells[10].Value.ToString();
                    emailBox.Text = dataCargo.CurrentRow.Cells[11].Value.ToString();
                    PaymentComboBox.SelectedValue = dataCargo.CurrentRow.Cells[9].Value.ToString();
                    TransactionComboBox.SelectedValue = dataCargo.CurrentRow.Cells[7].Value.ToString();
                }
            }
            catch (Exception)
            {
                errorLabel.Text = "";
            }
            
            
        }

        private void btnBill_Click(object sender, EventArgs e)
        {

            

            try
            {

                object payment_id = PaymentComboBox.SelectedValue;
                int customer_id = int.Parse(ReceiverID.Text.ToString());
                int price = int.Parse(PriceBox.Text);



                bill.AddBill(payment_id, customer_id, price);
                errorLabel.Text = "✔️ Bill successfully created!";
                bill.ReadBillID(dataCargo);
            }
            catch (Exception )
            {
              errorLabel.Text = "❌ Bill couldn't created!";
               // MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int cargo_id = int.Parse(CargoIDBox.Text.ToString());
                object transaction_id = TransactionComboBox.SelectedValue;
                int billing_id = int.Parse(BillingIDBox.Text.Trim());
                int customer_id = int.Parse(ReceiverID.Text);
                string enquiry_id = EnquiryBox.Text.ToString();
                string sender_name = SenderBox.Text.Trim();

                cargo.UpdateCargo(cargo_id,transaction_id,billing_id,customer_id,enquiry_id,sender_name);

                errorLabel.Text = "✔️ Cargo successfully updated!";
            }
            catch (Exception)
            {
                errorLabel.Text = "❌ Cargo couldn't updated! \n Check the bill";
               
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int cargo_id = int.Parse(CargoIDBox.Text.ToString());
                int bill_id = int.Parse(BillingIDBox.Text.ToString());

                cargo.DeleteCargo(cargo_id);
                bill.DeleteBill(bill_id);
                cargo.ViewCargo(dataCargo);
                errorLabel.Text = "✔️ Cargo successfully deleted!";

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
               // errorLabel.Text = "❌ Cargo couldn't deleted!";
               
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(dataCargo.Width, dataCargo.Height);
                dataCargo.DrawToBitmap(img, new Rectangle(0,0, dataCargo.Width, dataCargo.Height));
                e.Graphics.DrawImage(img, 0, 0);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Reference from
            //https://raw.githubusercontent.com/vijaythapa333/DGVPrinter/master/DGVPrinter.cs
           
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = "Cargo Details";
            printer.PageNumbers = true;
            printer.Footer = "CarryGO INC. All Rights Reserved 2021";
            dataCargo.Columns[0].Visible = false;
            dataCargo.Columns[1].Visible = false;
            dataCargo.Columns[7].Visible = false;
            dataCargo.Columns[10].Visible = false;
            printer.PrintDataGridView(dataCargo);

            dataCargo.Columns[0].Visible = true;
            dataCargo.Columns[1].Visible = true;
            dataCargo.Columns[7].Visible = true;
            dataCargo.Columns[10].Visible = true;

            errorLabel.Text = "✔️ Printed successfully!";

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            sendMail sendem = new sendMail(emailBox.Text, ReceiverName.Text, EnquiryBox.Text,PriceBox.Text );
            sendem.StartPosition = FormStartPosition.CenterParent;
            sendem.ShowDialog();

        }

        private void btnReCode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            EnquiryBox.Text = rand.Next(1000000, 9999999).ToString();
        }
    }
}
