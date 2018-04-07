namespace DavidsHobbies
{
    partial class frmEdit_Manufacturer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label manufacturer_CodeLabel;
            System.Windows.Forms.Label manufacturer_NameLabel;
            System.Windows.Forms.Label street_AddressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label telephone_NumberLabel;
            System.Windows.Forms.Label contact_NameLabel;
            System.Windows.Forms.Label contact_Telephone_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit_Manufacturer));
            this.teamOneDataSet = new DavidsHobbies.TeamOneDataSet();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.ManufacturerTableAdapter();
            this.tableAdapterManager = new DavidsHobbies.TeamOneDataSetTableAdapters.TableAdapterManager();
            this.manufacturerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.manufacturerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.manufacturer_CodeTextBox = new System.Windows.Forms.TextBox();
            this.manufacturer_NameTextBox = new System.Windows.Forms.TextBox();
            this.street_AddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.telephone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.contact_NameTextBox = new System.Windows.Forms.TextBox();
            this.contact_Telephone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            manufacturer_CodeLabel = new System.Windows.Forms.Label();
            manufacturer_NameLabel = new System.Windows.Forms.Label();
            street_AddressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            telephone_NumberLabel = new System.Windows.Forms.Label();
            contact_NameLabel = new System.Windows.Forms.Label();
            contact_Telephone_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingNavigator)).BeginInit();
            this.manufacturerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // manufacturer_CodeLabel
            // 
            manufacturer_CodeLabel.AutoSize = true;
            manufacturer_CodeLabel.Location = new System.Drawing.Point(31, 45);
            manufacturer_CodeLabel.Name = "manufacturer_CodeLabel";
            manufacturer_CodeLabel.Size = new System.Drawing.Size(101, 13);
            manufacturer_CodeLabel.TabIndex = 1;
            manufacturer_CodeLabel.Text = "Manufacturer Code:";
            // 
            // manufacturer_NameLabel
            // 
            manufacturer_NameLabel.AutoSize = true;
            manufacturer_NameLabel.Location = new System.Drawing.Point(31, 71);
            manufacturer_NameLabel.Name = "manufacturer_NameLabel";
            manufacturer_NameLabel.Size = new System.Drawing.Size(104, 13);
            manufacturer_NameLabel.TabIndex = 3;
            manufacturer_NameLabel.Text = "Manufacturer Name:";
            // 
            // street_AddressLabel
            // 
            street_AddressLabel.AutoSize = true;
            street_AddressLabel.Location = new System.Drawing.Point(31, 97);
            street_AddressLabel.Name = "street_AddressLabel";
            street_AddressLabel.Size = new System.Drawing.Size(79, 13);
            street_AddressLabel.TabIndex = 5;
            street_AddressLabel.Text = "Street Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(31, 123);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(31, 149);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(31, 175);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(25, 13);
            zipLabel.TabIndex = 11;
            zipLabel.Text = "Zip:";
            // 
            // telephone_NumberLabel
            // 
            telephone_NumberLabel.AutoSize = true;
            telephone_NumberLabel.Location = new System.Drawing.Point(31, 201);
            telephone_NumberLabel.Name = "telephone_NumberLabel";
            telephone_NumberLabel.Size = new System.Drawing.Size(101, 13);
            telephone_NumberLabel.TabIndex = 13;
            telephone_NumberLabel.Text = "Telephone Number:";
            // 
            // contact_NameLabel
            // 
            contact_NameLabel.AutoSize = true;
            contact_NameLabel.Location = new System.Drawing.Point(31, 227);
            contact_NameLabel.Name = "contact_NameLabel";
            contact_NameLabel.Size = new System.Drawing.Size(78, 13);
            contact_NameLabel.TabIndex = 15;
            contact_NameLabel.Text = "Contact Name:";
            // 
            // contact_Telephone_NumberLabel
            // 
            contact_Telephone_NumberLabel.AutoSize = true;
            contact_Telephone_NumberLabel.Location = new System.Drawing.Point(31, 253);
            contact_Telephone_NumberLabel.Name = "contact_Telephone_NumberLabel";
            contact_Telephone_NumberLabel.Size = new System.Drawing.Size(141, 13);
            contact_Telephone_NumberLabel.TabIndex = 17;
            contact_Telephone_NumberLabel.Text = "Contact Telephone Number:";
            // 
            // teamOneDataSet
            // 
            this.teamOneDataSet.DataSetName = "TeamOneDataSet";
            this.teamOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.teamOneDataSet;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DistributorTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.InsuranceTypeTableAdapter = null;
            this.tableAdapterManager.Item_TypeTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.JobsTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = this.manufacturerTableAdapter;
            this.tableAdapterManager.SalaryTypeTableAdapter = null;
            this.tableAdapterManager.ShelfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DavidsHobbies.TeamOneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // manufacturerBindingNavigator
            // 
            this.manufacturerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.manufacturerBindingNavigator.BindingSource = this.manufacturerBindingSource;
            this.manufacturerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.manufacturerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.manufacturerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.manufacturerBindingNavigatorSaveItem});
            this.manufacturerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.manufacturerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.manufacturerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.manufacturerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.manufacturerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.manufacturerBindingNavigator.Name = "manufacturerBindingNavigator";
            this.manufacturerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.manufacturerBindingNavigator.Size = new System.Drawing.Size(304, 25);
            this.manufacturerBindingNavigator.TabIndex = 0;
            this.manufacturerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // manufacturerBindingNavigatorSaveItem
            // 
            this.manufacturerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manufacturerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("manufacturerBindingNavigatorSaveItem.Image")));
            this.manufacturerBindingNavigatorSaveItem.Name = "manufacturerBindingNavigatorSaveItem";
            this.manufacturerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.manufacturerBindingNavigatorSaveItem.Text = "Save Data";
            this.manufacturerBindingNavigatorSaveItem.Click += new System.EventHandler(this.manufacturerBindingNavigatorSaveItem_Click);
            // 
            // manufacturer_CodeTextBox
            // 
            this.manufacturer_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Manufacturer_Code", true));
            this.manufacturer_CodeTextBox.Location = new System.Drawing.Point(178, 42);
            this.manufacturer_CodeTextBox.Name = "manufacturer_CodeTextBox";
            this.manufacturer_CodeTextBox.ReadOnly = true;
            this.manufacturer_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturer_CodeTextBox.TabIndex = 2;
            // 
            // manufacturer_NameTextBox
            // 
            this.manufacturer_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Manufacturer_Name", true));
            this.manufacturer_NameTextBox.Location = new System.Drawing.Point(178, 68);
            this.manufacturer_NameTextBox.Name = "manufacturer_NameTextBox";
            this.manufacturer_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturer_NameTextBox.TabIndex = 0;
            // 
            // street_AddressTextBox
            // 
            this.street_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Street_Address", true));
            this.street_AddressTextBox.Location = new System.Drawing.Point(178, 94);
            this.street_AddressTextBox.Name = "street_AddressTextBox";
            this.street_AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.street_AddressTextBox.TabIndex = 1;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(178, 120);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 2;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(178, 146);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 3;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(178, 172);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 4;
            // 
            // telephone_NumberTextBox
            // 
            this.telephone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Telephone_Number", true));
            this.telephone_NumberTextBox.Location = new System.Drawing.Point(178, 198);
            this.telephone_NumberTextBox.Name = "telephone_NumberTextBox";
            this.telephone_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.telephone_NumberTextBox.TabIndex = 5;
            // 
            // contact_NameTextBox
            // 
            this.contact_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Contact_Name", true));
            this.contact_NameTextBox.Location = new System.Drawing.Point(178, 224);
            this.contact_NameTextBox.Name = "contact_NameTextBox";
            this.contact_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.contact_NameTextBox.TabIndex = 6;
            // 
            // contact_Telephone_NumberTextBox
            // 
            this.contact_Telephone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "Contact_Telephone_Number", true));
            this.contact_Telephone_NumberTextBox.Location = new System.Drawing.Point(178, 250);
            this.contact_Telephone_NumberTextBox.Name = "contact_Telephone_NumberTextBox";
            this.contact_Telephone_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.contact_Telephone_NumberTextBox.TabIndex = 7;
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(203, 290);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmEdit_Manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(304, 325);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(manufacturer_CodeLabel);
            this.Controls.Add(this.manufacturer_CodeTextBox);
            this.Controls.Add(manufacturer_NameLabel);
            this.Controls.Add(this.manufacturer_NameTextBox);
            this.Controls.Add(street_AddressLabel);
            this.Controls.Add(this.street_AddressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(telephone_NumberLabel);
            this.Controls.Add(this.telephone_NumberTextBox);
            this.Controls.Add(contact_NameLabel);
            this.Controls.Add(this.contact_NameTextBox);
            this.Controls.Add(contact_Telephone_NumberLabel);
            this.Controls.Add(this.contact_Telephone_NumberTextBox);
            this.Controls.Add(this.manufacturerBindingNavigator);
            this.Name = "frmEdit_Manufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Manufacturer";
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingNavigator)).EndInit();
            this.manufacturerBindingNavigator.ResumeLayout(false);
            this.manufacturerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeamOneDataSet teamOneDataSet;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private TeamOneDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private TeamOneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator manufacturerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton manufacturerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox manufacturer_CodeTextBox;
        private System.Windows.Forms.TextBox manufacturer_NameTextBox;
        private System.Windows.Forms.TextBox street_AddressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox telephone_NumberTextBox;
        private System.Windows.Forms.TextBox contact_NameTextBox;
        private System.Windows.Forms.TextBox contact_Telephone_NumberTextBox;
        private System.Windows.Forms.Button btnDone;
    }
}