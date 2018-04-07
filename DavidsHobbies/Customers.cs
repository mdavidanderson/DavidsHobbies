using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DavidsHobbies
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

       

       

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamOneDataSet);
        }

        private void frmCustomers_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamOneDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.teamOneDataSet.Customers);
        }

       
    }
}
