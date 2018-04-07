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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DialogResult button =
               MessageBox.Show("Are all field filled?\n No Repeating ID numbers", "Required Fields?", MessageBoxButtons.YesNo);
            if (button == DialogResult.Yes)
            {
              
                this.Validate();
                this.employeesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.teamOneDataSet);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamOneDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.teamOneDataSet.Employees);

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            DialogResult button =
               MessageBox.Show("Have you saved your changes?", "Saved?", MessageBoxButtons.YesNo);
            if (button == DialogResult.Yes)
                this.Close();
        }

        private void employee_IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       

    }
}
