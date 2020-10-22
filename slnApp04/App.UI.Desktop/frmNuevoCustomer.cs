using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.Desktop
{
    public partial class frmNuevoCustomer : Form
    {
        public Customer customer { get; set; }
        public frmNuevoCustomer()
        {
            InitializeComponent();
        }

        private bool IsEdit()
        {
            if (this.customer != null)
            {
                return true;
            }
            return false;
        }

        public void MostrarDatos()
        {
            if (this.IsEdit())
            {
                tbFirstName.Text = this.customer.FirstName;
                tbLastName.Text = this.customer.LastName;
                tbCompany.Text = this.customer.Company;
                tbAddress.Text = this.customer.Address;
                tbCity.Text = this.customer.City;
                tbState.Text = this.customer.State;
                tbCountry.Text = this.customer.Country;
                tbPostalCode.Text = this.customer.PostalCode;
                tbPhone.Text = this.customer.Phone;
                tbFax.Text = this.customer.Fax;
                tbEmail.Text = this.customer.Email;
            }
        }

        private void frmNuevoCustomer_Load(object sender, EventArgs e)
        {
            this.MostrarDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.FirstName = tbFirstName.Text;
            customer.LastName = tbLastName.Text;
            customer.Company = tbCompany.Text;
            customer.Address = tbAddress.Text;
            customer.City = tbCity.Text;
            customer.State = tbState.Text;
            customer.Country = tbCountry.Text;
            customer.PostalCode = tbPostalCode.Text;
            customer.Phone = tbPhone.Text;
            customer.Fax = tbFax.Text;
            customer.Email = tbEmail.Text;

            var da = new CustomerDA();

            if (this.IsEdit())
            {
                customer.CustomerId = this.customer.CustomerId;
                da.Update(customer);
            }
            else
            {
                da.Insert(customer);
            }

            this.Close();
        }
    }
}
