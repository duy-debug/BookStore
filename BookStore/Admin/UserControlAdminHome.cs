using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Data;
using BookStore.DTO;

namespace BookStore.Admin
{
    public partial class UserControlAdminHome : UserControl
    {
        private readonly QlbsContext _context = new QlbsContext();
        
        public UserControlAdminHome()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var customer = _context.Customers.Select(c => new CustomerDTO
            {
                CustomerId = c.CustomerId,
                FirstName = c.FirstName,
                LastName = c.LastName,
                DateOfBirth = c.DateOfBirth,
                CustomerEmail = c.CustomerEmail,
                CustomerPhone = c.CustomerPhone,
                CustomerAddress = c.CustomerAddress
            }).ToList();
            dataGridViewCustumer.DataSource = customer;
        }
    }
}
