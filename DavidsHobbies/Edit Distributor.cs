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
    public partial class frmEdit_Distributor : Form
    {
        public frmEdit_Distributor()
        {
            InitializeComponent();
            Load += new EventHandler(frmEdit_Distributor_Load);
        }

        private void distributorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.distributorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamOneDataSet);

        }

        private void frmEdit_Distributor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamOneDataSet.Distributor' table. You can move, or remove it, as needed.
            this.distributorTableAdapter.Fill(this.teamOneDataSet.Distributor);

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
