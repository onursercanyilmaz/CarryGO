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

namespace CarryGO
{
    public partial class MainPage : Form
    {
        Employee employee = new Employee();
        public MainPage()
        {
            InitializeComponent();
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;

            try
            {

                ucAnnounce uc = new ucAnnounce();
                uc.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(uc);
            }
            catch (Exception)
            {

                throw;
            }

        }

        

       private void updateBorders(string name)
        {
            try
            {
                foreach (var control in splitContainer1.Panel1.Controls)
                {
                    if (control is Button)
                    {
                        var btn = (Button)control;
                        if (btn.Name == name)
                        {
                            btn.FlatAppearance.BorderColor = Color.White;
                            btn.Text = "▶️";
                        }
                        else
                        {
                            btn.FlatAppearance.BorderColor = Color.Coral;
                            btn.Text = "";
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btnNewCargo_Click(object sender, EventArgs e)
        {

            try
            {
                updateBorders(((Button)sender).Name);
                ucNewCargo uc = new ucNewCargo();
                uc.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(uc);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnInTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                updateBorders(((Button)sender).Name);
                ucInTransaction uc = new ucInTransaction();
                uc.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(uc);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            try
            {
                updateBorders(((Button)sender).Name);
                ucDelivered uc = new ucDelivered();
                uc.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(uc);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEnquiry_Click(object sender, EventArgs e)
        {
            try
            {
                updateBorders(((Button)sender).Name);
                ucEnquiry uc = new ucEnquiry();
                uc.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(uc);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            try
            {
                updateBorders(((Button)sender).Name);
                ucAbout uc = new ucAbout();
                uc.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(uc);
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            try
            {
                updateBorders(((Button)sender).Name);
                ucAnnounce uc = new ucAnnounce();
                uc.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(uc);
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        private void MainPage_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'carryGODBDataSet.Billing' table. You can move, or remove it, as needed.
            //this.billingTableAdapter.Fill(this.carryGODBDataSet.Billing);
            //// TODO: This line of code loads data into the 'carryGODBDataSet.Payment' table. You can move, or remove it, as needed.
            //this.paymentTableAdapter.Fill(this.carryGODBDataSet.Payment);

        }

        private void billingBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
