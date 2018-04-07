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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void btnEditItems_Click(object sender, EventArgs e)
        {
            Form newForm = new frmEdit_Item();
            newForm.Show();
        }

        private void btnEditManufacturers_Click(object sender, EventArgs e)
        {
            Form newForm = new frmEdit_Manufacturer();
            newForm.Show();
        }

        private void btnEditDistributors_Click(object sender, EventArgs e)
        {
            Form newForm = new frmEdit_Distributor();
            newForm.Show();
        }

        private void btnEditShelfLocations_Click(object sender, EventArgs e)
        {
            Form newForm = new frmEdit_Shelf_Location();
            newForm.Show();
        }

        private void btnEditItemTypes_Click(object sender, EventArgs e)
        {
            Form newForm = new frmEdit_Item_Type();
            newForm.Show();
        }

        private void btnCancelInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchInv_Click(object sender, EventArgs e)
        {
            txtItemDesc.Text = null;
            txtQuantity.Text = null;
            txtRow.Text = null;
            txtSection.Text = null;
            txtShelf.Text = null;
            txtManufacturer.Text = null;
            txtDistributor.Text = null;
            txtRetailPrice.Text = null;
            txtWholePrice.Text = null;
            txtSalePrice.Text = null;
            txtItemType.Text = null;
            txtUsed.Text = "no";
            string search = "%" + txtSearchInv.Text + "%";
            if (Convert.ToString(cboSearchBy.SelectedItem) == "(None)")
                this.item_ViewTableAdapter.Fill(this.teamOneDataSet.Item_View);
            if(Convert.ToString(cboSearchBy.SelectedItem) == "Item Type")
                this.item_ViewTableAdapter.FillByType(this.teamOneDataSet.Item_View, search);
            if (Convert.ToString(cboSearchBy.SelectedItem) == "Item Description")
                this.item_ViewTableAdapter.FillByDescription(this.teamOneDataSet.Item_View, search);
            if (Convert.ToString(cboSearchBy.SelectedItem) == "Manufacturer")
                this.item_ViewTableAdapter.FillByManufacturer(this.teamOneDataSet.Item_View, search);
            if (Convert.ToString(cboSearchBy.SelectedItem) == "Distributor")
                this.item_ViewTableAdapter.FillByDistributor(this.teamOneDataSet.Item_View, search);
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamOneDataSet.Item_View' table. You can move, or remove it, as needed.
            this.item_ViewTableAdapter.Fill(this.teamOneDataSet.Item_View);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemDesc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtQuantity.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtRow.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSection.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtShelf.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtManufacturer.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtDistributor.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtRetailPrice.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtWholePrice.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtSalePrice.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtItemType.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            if (Convert.ToBoolean(dataGridView1.CurrentRow.Cells[11].Value))
                txtUsed.Text = "yes";
            else
                txtUsed.Text = "no";
        }
    }
}
