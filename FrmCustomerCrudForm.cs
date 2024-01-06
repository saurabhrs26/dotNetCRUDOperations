using ConnectedArchitectureCRUD.Dal;
using ConnectedArchitectureCRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedArchitectureCRUD
{
    public partial class FrmCustomerCrudForm : Form
    {
        public FrmCustomerCrudForm()
        {
            InitializeComponent();
        }
        CustomerDal customerDal = new CustomerDal();
        int index = 0;
        List<Customer> customerList;

        private void label3_Click(object sender, EventArgs e)
        {
          customerList=customerDal.GetAllCustomers();
            Navigate(index);
        }
        private void Navigate(int currentIndex)
        {
            if(customerList.Count > 0)
            {
                customer_id_txt.Text = customerList[currentIndex].Id.ToString();
                customer_name_txt.Text = customerList[currentIndex].Name;
                customer_city_txt.Text = customerList[currentIndex].City;
                customer_phnno_txt.Text = customerList[currentIndex].PhoneNo.ToString();
                
            }
        }

       /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        private void morePreviousBtn_Click(object sender, EventArgs e)
        {
            index = 0;
            Navigate(index);


        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {

            if (index < customerList.Count - 1)
            {
                index++;
                Navigate(index);
            }
        }

        private void moreForwardBtn_Click(object sender, EventArgs e)
        {
            index = customerList.Count - 1;
            Navigate(index);
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Navigate(index);
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            customer_id_txt.Text = string.Empty;
            customer_name_txt.Text = string.Empty;
            customer_city_txt.Text = string.Empty;
            customer_phnno_txt.Text = string.Empty;
            customer_id_txt.Focus();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Id = int.Parse(customer_id_txt.Text),
                Name = customer_name_txt.Text,
                City = customer_city_txt.Text,
                PhoneNo = int.Parse(customer_phnno_txt.Text)
            };
            int result=customerDal.InsertCustomer(customer);
            if (result > 0)
            {
                customerList=customerDal.GetAllCustomers(); 
            }
           
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer()
            {
                Id = int.Parse(customer_id_txt.Text),
                Name = customer_name_txt.Text,
                City = customer_city_txt.Text,
                PhoneNo = int.Parse(customer_phnno_txt.Text)
            };
            int result = customerDal.UpdateCustomer(customer);
            if (result > 0)
            {
                customerList = customerDal.GetAllCustomers();
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Id = int.Parse(customer_id_txt.Text),
                Name = customer_name_txt.Text,
                City = customer_city_txt.Text,
                PhoneNo = int.Parse(customer_phnno_txt.Text)
            };
            int result=customerDal.DeleteCustomer(customer);
            if (result > 0) {
                customerList = customerDal.GetAllCustomers();
            }

        }
    }
    
}
