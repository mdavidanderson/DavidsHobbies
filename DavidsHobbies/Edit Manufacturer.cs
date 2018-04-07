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
    public partial class frmEdit_Manufacturer : Form
    {
        public frmEdit_Manufacturer()
        {
            InitializeComponent();
            Load += new EventHandler(frmEdit_Manufacturer_Load);
        }

        private void manufacturerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamOneDataSet);

        }

        private void frmEdit_Manufacturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamOneDataSet.Manufacturer' table. You can move, or remove it, as needed.
            this.manufacturerTableAdapter.Fill(this.teamOneDataSet.Manufacturer);

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult button =
                MessageBox.Show("Have you saved your changes?", "Saved?", MessageBoxButtons.YesNo);
            if (button == DialogResult.Yes)
                this.Close();
        }
    }
}
