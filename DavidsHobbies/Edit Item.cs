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
    public partial class frmEdit_Item : Form
    {
        public frmEdit_Item()
        {
            InitializeComponent();
            Load += new EventHandler(frmEdit_Item_Load);
        }

        private int selectedRow;
        private int selectedSection;
        private int selectedShelf;

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamOneDataSet);

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult button =
                MessageBox.Show("Have you saved your changes?", "Saved?", MessageBoxButtons.YesNo);
            if (button == DialogResult.Yes)
                this.Close();
        }

        private void frmEdit_Item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamOneDataSet.Shelf' table. You can move, or remove it, as needed.
            this.shelfTableAdapter.Fill(this.teamOneDataSet.Shelf);
            // TODO: This line of code loads data into the 'teamOneDataSet.Shelf_View' table. You can move, or remove it, as needed.
            this.shelf_ViewTableAdapter.Fill(this.teamOneDataSet.Shelf_View);
            // TODO: This line of code loads data into the 'teamOneDataSet.Section_View' table. You can move, or remove it, as needed.
            this.section_ViewTableAdapter.Fill(this.teamOneDataSet.Section_View);
            // TODO: This line of code loads data into the 'teamOneDataSet.Row_View' table. You can move, or remove it, as needed.
            this.row_ViewTableAdapter.Fill(this.teamOneDataSet.Row_View);
            // TODO: This line of code loads data into the 'teamOneDataSet.Item_Type' table. You can move, or remove it, as needed.
            this.item_TypeTableAdapter.Fill(this.teamOneDataSet.Item_Type);
            // TODO: This line of code loads data into the 'teamOneDataSet.Distributor' table. You can move, or remove it, as needed.
            this.distributorTableAdapter.Fill(this.teamOneDataSet.Distributor);
            // TODO: This line of code loads data into the 'teamOneDataSet.Manufacturer' table. You can move, or remove it, as needed.
            this.manufacturerTableAdapter.Fill(this.teamOneDataSet.Manufacturer);
            // TODO: This line of code loads data into the 'teamOneDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.teamOneDataSet.Item);
            cboRow.DisplayMember = "Row";
            cboRow.ValueMember = "Row";
            cboRow.DataSource = teamOneDataSet.Tables["Row View"].DefaultView;
            cboRow.Text = Convert.ToString(this.shelfTableAdapter.GetRow
                (Convert.ToInt32(shelf_Location_codeTextBox.Text)));
            selectedRow = Convert.ToInt32(this.shelfTableAdapter.GetRow
                (Convert.ToInt32(shelf_Location_codeTextBox.Text)));
            cboSection.DisplayMember = "Section";
            cboSection.ValueMember = "Section";
            cboSection.DataSource = teamOneDataSet.Tables["Section View"].DefaultView;
            cboSection.Text = Convert.ToString(this.shelfTableAdapter.GetSection
                (Convert.ToInt32(shelf_Location_codeTextBox.Text)));
            selectedSection = Convert.ToInt32(this.shelfTableAdapter.GetSection
                (Convert.ToInt32(shelf_Location_codeTextBox.Text)));
            cboShelf.DisplayMember = "Shelf";
            cboShelf.ValueMember = "Shelf";
            cboShelf.DataSource = teamOneDataSet.Tables["Shelf View"].DefaultView;
            cboShelf.Text = Convert.ToString(this.shelfTableAdapter.GetShelf
                (Convert.ToInt32(shelf_Location_codeTextBox.Text)));
            selectedShelf = Convert.ToInt32(this.shelfTableAdapter.GetShelf
                (Convert.ToInt32(shelf_Location_codeTextBox.Text)));
            cboManufacturer.DisplayMember = "Manufacturer_Name";
            cboManufacturer.ValueMember = "Manufacturer_Code";
            cboManufacturer.DataSource = teamOneDataSet.Tables["Manufacturer"].DefaultView;
            cboManufacturer.Text = this.manufacturerTableAdapter.GetManufacturerName
                (Convert.ToInt32(manufacturer_CodeTextBox.Text));
            cboDistributor.DisplayMember = "Distributor_Name";
            cboDistributor.ValueMember = "Distributor_Code";
            cboDistributor.DataSource = teamOneDataSet.Tables["Distributor"].DefaultView;
            cboDistributor.Text = this.distributorTableAdapter.GetDistributorName
                (Convert.ToInt32(distributor_CodeTextBox.Text));
            cboType.DisplayMember = "Type_Description";
            cboType.ValueMember = "Type_Code";
            cboType.DataSource = teamOneDataSet.Tables["Item_Type"].DefaultView;
            cboType.Text = this.item_TypeTableAdapter.GetTypeDescription
                (Convert.ToInt32(type_CodeTextBox.Text));
        }

        private void itemBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamOneDataSet);

        }

        private void cboRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRow = Convert.ToInt32(cboRow.SelectedValue);
            if (selectedRow != 0 && selectedSection != 0 && selectedShelf != 0)
            {   
                Int32 code = Convert.ToInt32(shelfTableAdapter.GetShelfLocationCode
                    (selectedRow, selectedSection, selectedShelf));
                shelf_Location_codeTextBox.Text = Convert.ToString(code);
            }
        }

        private void cboSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSection = Convert.ToInt32(cboSection.SelectedValue);
            if (selectedRow != 0 && selectedSection != 0 && selectedShelf != 0)
            {
                string code = Convert.ToString(shelfTableAdapter.GetShelfLocationCode
                    (selectedRow, selectedSection, selectedShelf));
                shelf_Location_codeTextBox.Text = code;
            }
        }

        private void cboShelf_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShelf = Convert.ToInt32(cboShelf.SelectedValue);
            if (selectedRow != 0 && selectedSection != 0 && selectedShelf != 0)
            {
                string code = Convert.ToString(shelfTableAdapter.GetShelfLocationCode
                    (selectedRow, selectedSection, selectedShelf));
                shelf_Location_codeTextBox.Text = code;
            }
        }

        private void cboManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            manufacturer_CodeTextBox.Text = Convert.ToString(cboManufacturer.SelectedValue);
        }

        private void cboDistributor_SelectedIndexChanged(object sender, EventArgs e)
        {
            distributor_CodeTextBox.Text = Convert.ToString(cboDistributor.SelectedValue);
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            type_CodeTextBox.Text = Convert.ToString(cboType.SelectedValue);
        }
    }
}
