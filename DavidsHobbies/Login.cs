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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean valid = false;
                int username = Convert.ToInt32(txtUsername.Text);
                string password = txtPassword.Text;

                TeamOneDataSet dataSet = new TeamOneDataSet();
                loginEmployeesTableAdapter.Fill(dataSet.Employees);       

                var emps = from emp in dataSet.Employees
                           select emp;


                foreach (var emp in emps)
                {
                    if (emp.Employee_Id == username)
                        if (emp.Employee_Password == password)
                            valid = true;
                }

                if (valid)
                {
                    this.Hide();
                    Portal form = new Portal();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
