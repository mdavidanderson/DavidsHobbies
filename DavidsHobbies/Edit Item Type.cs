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
    public partial class frmEdit_Item_Type : Form
    {
        public frmEdit_Item_Type()
        {
            InitializeComponent();
            Load += new EventHandler(frmEdit_Item_Type_Load);
        }

        private void item_TypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.item_TypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamOneDataSet);

        }

        private void frmEdit_Item_Type_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamOneDataSet.Item_Type' table. You can move, or remove it, as needed.
            this.item_TypeTableAdapter.Fill(this.teamOneDataSet.Item_Type);

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
