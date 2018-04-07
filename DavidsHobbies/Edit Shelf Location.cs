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
    public partial class frmEdit_Shelf_Location : Form
    {
        public frmEdit_Shelf_Location()
        {
            InitializeComponent();
            Load += new EventHandler(frmEdit_Shelf_Location_Load);
        }

        private void shelfBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shelfBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamOneDataSet);

        }

        private void frmEdit_Shelf_Location_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamOneDataSet.Shelf' table. You can move, or remove it, as needed.
            this.shelfTableAdapter.Fill(this.teamOneDataSet.Shelf);

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult button = 
                MessageBox.Show("Have you saved your changes?", "Saved?", MessageBoxButtons.YesNo);
            if(button == DialogResult.Yes)
                this.Close();
        }
    }
}
