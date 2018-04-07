namespace DavidsHobbies
{
    partial class frmEdit_Item
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
            System.Windows.Forms.Label item_CodeLabel;
            System.Windows.Forms.Label item_DescriptionLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label shelf_Location_codeLabel;
            System.Windows.Forms.Label manufacturer_CodeLabel;
            System.Windows.Forms.Label distributor_CodeLabel;
            System.Windows.Forms.Label retail_PriceLabel;
            System.Windows.Forms.Label wholesale_PriceLabel;
            System.Windows.Forms.Label sale_PriceLabel;
            System.Windows.Forms.Label type_CodeLabel;
            System.Windows.Forms.Label usedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit_Item));
            this.btnDone = new System.Windows.Forms.Button();
            this.teamOneDataSet = new DavidsHobbies.TeamOneDataSet();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.ItemTableAdapter();
            this.tableAdapterManager = new DavidsHobbies.TeamOneDataSetTableAdapters.TableAdapterManager();
            this.itemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.itemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.item_CodeTextBox = new System.Windows.Forms.TextBox();
            this.item_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.shelf_Location_codeTextBox = new System.Windows.Forms.TextBox();
            this.manufacturer_CodeTextBox = new System.Windows.Forms.TextBox();
            this.distributor_CodeTextBox = new System.Windows.Forms.TextBox();
            this.retail_PriceTextBox = new System.Windows.Forms.TextBox();
            this.wholesale_PriceTextBox = new System.Windows.Forms.TextBox();
            this.sale_PriceTextBox = new System.Windows.Forms.TextBox();
            this.type_CodeTextBox = new System.Windows.Forms.TextBox();
            this.cboRow = new System.Windows.Forms.ComboBox();
            this.rowViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboManufacturer = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboDistributor = new System.Windows.Forms.ComboBox();
            this.distributorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboType = new System.Windows.Forms.ComboBox();
            this.itemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.ManufacturerTableAdapter();
            this.distributorTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.DistributorTableAdapter();
            this.item_TypeTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.Item_TypeTableAdapter();
            this.cboSection = new System.Windows.Forms.ComboBox();
            this.sectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboShelf = new System.Windows.Forms.ComboBox();
            this.shelfViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.row_ViewTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.Row_ViewTableAdapter();
            this.section_ViewTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.Section_ViewTableAdapter();
            this.shelf_ViewTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.Shelf_ViewTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shelfbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelfTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.ShelfTableAdapter();
            this.usedCheckBox = new System.Windows.Forms.CheckBox();
            item_CodeLabel = new System.Windows.Forms.Label();
            item_DescriptionLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            shelf_Location_codeLabel = new System.Windows.Forms.Label();
            manufacturer_CodeLabel = new System.Windows.Forms.Label();
            distributor_CodeLabel = new System.Windows.Forms.Label();
            retail_PriceLabel = new System.Windows.Forms.Label();
            wholesale_PriceLabel = new System.Windows.Forms.Label();
            sale_PriceLabel = new System.Windows.Forms.Label();
            type_CodeLabel = new System.Windows.Forms.Label();
            usedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingNavigator)).BeginInit();
            this.itemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // item_CodeLabel
            // 
            item_CodeLabel.AutoSize = true;
            item_CodeLabel.Location = new System.Drawing.Point(30, 45);
            item_CodeLabel.Name = "item_CodeLabel";
            item_CodeLabel.Size = new System.Drawing.Size(58, 13);
            item_CodeLabel.TabIndex = 24;
            item_CodeLabel.Text = "Item Code:";
            // 
            // item_DescriptionLabel
            // 
            item_DescriptionLabel.AutoSize = true;
            item_DescriptionLabel.Location = new System.Drawing.Point(30, 71);
            item_DescriptionLabel.Name = "item_DescriptionLabel";
            item_DescriptionLabel.Size = new System.Drawing.Size(86, 13);
            item_DescriptionLabel.TabIndex = 26;
            item_DescriptionLabel.Text = "Item Description:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(30, 97);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 28;
            quantityLabel.Text = "Quantity:";
            // 
            // shelf_Location_codeLabel
            // 
            shelf_Location_codeLabel.AutoSize = true;
            shelf_Location_codeLabel.Location = new System.Drawing.Point(30, 123);
            shelf_Location_codeLabel.Name = "shelf_Location_codeLabel";
            shelf_Location_codeLabel.Size = new System.Drawing.Size(105, 13);
            shelf_Location_codeLabel.TabIndex = 30;
            shelf_Location_codeLabel.Text = "Shelf Location code:";
            // 
            // manufacturer_CodeLabel
            // 
            manufacturer_CodeLabel.AutoSize = true;
            manufacturer_CodeLabel.Location = new System.Drawing.Point(30, 206);
            manufacturer_CodeLabel.Name = "manufacturer_CodeLabel";
            manufacturer_CodeLabel.Size = new System.Drawing.Size(101, 13);
            manufacturer_CodeLabel.TabIndex = 32;
            manufacturer_CodeLabel.Text = "Manufacturer Code:";
            // 
            // distributor_CodeLabel
            // 
            distributor_CodeLabel.AutoSize = true;
            distributor_CodeLabel.Location = new System.Drawing.Point(30, 232);
            distributor_CodeLabel.Name = "distributor_CodeLabel";
            distributor_CodeLabel.Size = new System.Drawing.Size(85, 13);
            distributor_CodeLabel.TabIndex = 34;
            distributor_CodeLabel.Text = "Distributor Code:";
            // 
            // retail_PriceLabel
            // 
            retail_PriceLabel.AutoSize = true;
            retail_PriceLabel.Location = new System.Drawing.Point(30, 258);
            retail_PriceLabel.Name = "retail_PriceLabel";
            retail_PriceLabel.Size = new System.Drawing.Size(64, 13);
            retail_PriceLabel.TabIndex = 36;
            retail_PriceLabel.Text = "Retail Price:";
            // 
            // wholesale_PriceLabel
            // 
            wholesale_PriceLabel.AutoSize = true;
            wholesale_PriceLabel.Location = new System.Drawing.Point(30, 284);
            wholesale_PriceLabel.Name = "wholesale_PriceLabel";
            wholesale_PriceLabel.Size = new System.Drawing.Size(87, 13);
            wholesale_PriceLabel.TabIndex = 38;
            wholesale_PriceLabel.Text = "Wholesale Price:";
            // 
            // sale_PriceLabel
            // 
            sale_PriceLabel.AutoSize = true;
            sale_PriceLabel.Location = new System.Drawing.Point(30, 310);
            sale_PriceLabel.Name = "sale_PriceLabel";
            sale_PriceLabel.Size = new System.Drawing.Size(58, 13);
            sale_PriceLabel.TabIndex = 40;
            sale_PriceLabel.Text = "Sale Price:";
            // 
            // type_CodeLabel
            // 
            type_CodeLabel.AutoSize = true;
            type_CodeLabel.Location = new System.Drawing.Point(30, 336);
            type_CodeLabel.Name = "type_CodeLabel";
            type_CodeLabel.Size = new System.Drawing.Size(62, 13);
            type_CodeLabel.TabIndex = 42;
            type_CodeLabel.Text = "Type Code:";
            // 
            // usedLabel
            // 
            usedLabel.AutoSize = true;
            usedLabel.Location = new System.Drawing.Point(30, 363);
            usedLabel.Name = "usedLabel";
            usedLabel.Size = new System.Drawing.Size(35, 13);
            usedLabel.TabIndex = 47;
            usedLabel.Text = "Used:";
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(280, 392);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // teamOneDataSet
            // 
            this.teamOneDataSet.DataSetName = "TeamOneDataSet";
            this.teamOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.teamOneDataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DistributorTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.InsuranceTypeTableAdapter = null;
            this.tableAdapterManager.Item_TypeTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.JobsTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.SalaryTypeTableAdapter = null;
            this.tableAdapterManager.ShelfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DavidsHobbies.TeamOneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemBindingNavigator
            // 
            this.itemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemBindingNavigator.BindingSource = this.itemBindingSource;
            this.itemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itemBindingNavigatorSaveItem});
            this.itemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemBindingNavigator.Name = "itemBindingNavigator";
            this.itemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemBindingNavigator.Size = new System.Drawing.Size(375, 25);
            this.itemBindingNavigator.TabIndex = 24;
            this.itemBindingNavigator.Text = "bindingNavigator1";
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
            // itemBindingNavigatorSaveItem
            // 
            this.itemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemBindingNavigatorSaveItem.Image")));
            this.itemBindingNavigatorSaveItem.Name = "itemBindingNavigatorSaveItem";
            this.itemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itemBindingNavigatorSaveItem.Text = "Save Data";
            this.itemBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemBindingNavigatorSaveItem_Click_1);
            // 
            // item_CodeTextBox
            // 
            this.item_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Item_Code", true));
            this.item_CodeTextBox.Location = new System.Drawing.Point(141, 42);
            this.item_CodeTextBox.Name = "item_CodeTextBox";
            this.item_CodeTextBox.ReadOnly = true;
            this.item_CodeTextBox.Size = new System.Drawing.Size(191, 20);
            this.item_CodeTextBox.TabIndex = 25;
            // 
            // item_DescriptionTextBox
            // 
            this.item_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Item_Description", true));
            this.item_DescriptionTextBox.Location = new System.Drawing.Point(141, 68);
            this.item_DescriptionTextBox.Name = "item_DescriptionTextBox";
            this.item_DescriptionTextBox.Size = new System.Drawing.Size(191, 20);
            this.item_DescriptionTextBox.TabIndex = 0;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(141, 94);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(191, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // shelf_Location_codeTextBox
            // 
            this.shelf_Location_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Shelf_Location_code", true));
            this.shelf_Location_codeTextBox.Location = new System.Drawing.Point(280, 120);
            this.shelf_Location_codeTextBox.Name = "shelf_Location_codeTextBox";
            this.shelf_Location_codeTextBox.ReadOnly = true;
            this.shelf_Location_codeTextBox.Size = new System.Drawing.Size(52, 20);
            this.shelf_Location_codeTextBox.TabIndex = 2;
            // 
            // manufacturer_CodeTextBox
            // 
            this.manufacturer_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Manufacturer_Code", true));
            this.manufacturer_CodeTextBox.Location = new System.Drawing.Point(280, 203);
            this.manufacturer_CodeTextBox.Name = "manufacturer_CodeTextBox";
            this.manufacturer_CodeTextBox.ReadOnly = true;
            this.manufacturer_CodeTextBox.Size = new System.Drawing.Size(52, 20);
            this.manufacturer_CodeTextBox.TabIndex = 3;
            // 
            // distributor_CodeTextBox
            // 
            this.distributor_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Distributor_Code", true));
            this.distributor_CodeTextBox.Location = new System.Drawing.Point(280, 229);
            this.distributor_CodeTextBox.Name = "distributor_CodeTextBox";
            this.distributor_CodeTextBox.ReadOnly = true;
            this.distributor_CodeTextBox.Size = new System.Drawing.Size(52, 20);
            this.distributor_CodeTextBox.TabIndex = 4;
            // 
            // retail_PriceTextBox
            // 
            this.retail_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Retail_Price", true));
            this.retail_PriceTextBox.Location = new System.Drawing.Point(141, 255);
            this.retail_PriceTextBox.Name = "retail_PriceTextBox";
            this.retail_PriceTextBox.Size = new System.Drawing.Size(191, 20);
            this.retail_PriceTextBox.TabIndex = 7;
            // 
            // wholesale_PriceTextBox
            // 
            this.wholesale_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Wholesale_Price", true));
            this.wholesale_PriceTextBox.Location = new System.Drawing.Point(141, 281);
            this.wholesale_PriceTextBox.Name = "wholesale_PriceTextBox";
            this.wholesale_PriceTextBox.Size = new System.Drawing.Size(191, 20);
            this.wholesale_PriceTextBox.TabIndex = 8;
            // 
            // sale_PriceTextBox
            // 
            this.sale_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Sale_Price", true));
            this.sale_PriceTextBox.Location = new System.Drawing.Point(141, 307);
            this.sale_PriceTextBox.Name = "sale_PriceTextBox";
            this.sale_PriceTextBox.Size = new System.Drawing.Size(191, 20);
            this.sale_PriceTextBox.TabIndex = 9;
            // 
            // type_CodeTextBox
            // 
            this.type_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Type_Code", true));
            this.type_CodeTextBox.Location = new System.Drawing.Point(280, 333);
            this.type_CodeTextBox.Name = "type_CodeTextBox";
            this.type_CodeTextBox.ReadOnly = true;
            this.type_CodeTextBox.Size = new System.Drawing.Size(52, 20);
            this.type_CodeTextBox.TabIndex = 8;
            // 
            // cboRow
            // 
            this.cboRow.DataSource = this.rowViewBindingSource;
            this.cboRow.DisplayMember = "Row";
            this.cboRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRow.FormattingEnabled = true;
            this.cboRow.Location = new System.Drawing.Point(202, 119);
            this.cboRow.Name = "cboRow";
            this.cboRow.Size = new System.Drawing.Size(72, 21);
            this.cboRow.TabIndex = 2;
            this.cboRow.SelectedIndexChanged += new System.EventHandler(this.cboRow_SelectedIndexChanged);
            // 
            // rowViewBindingSource
            // 
            this.rowViewBindingSource.DataMember = "Row View";
            this.rowViewBindingSource.DataSource = this.teamOneDataSet;
            // 
            // cboManufacturer
            // 
            this.cboManufacturer.DataSource = this.manufacturerBindingSource;
            this.cboManufacturer.DisplayMember = "Manufacturer_Name";
            this.cboManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManufacturer.FormattingEnabled = true;
            this.cboManufacturer.Location = new System.Drawing.Point(141, 202);
            this.cboManufacturer.Name = "cboManufacturer";
            this.cboManufacturer.Size = new System.Drawing.Size(133, 21);
            this.cboManufacturer.TabIndex = 5;
            this.cboManufacturer.SelectedIndexChanged += new System.EventHandler(this.cboManufacturer_SelectedIndexChanged);
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.teamOneDataSet;
            // 
            // cboDistributor
            // 
            this.cboDistributor.DataSource = this.distributorBindingSource;
            this.cboDistributor.DisplayMember = "Distributor_Name";
            this.cboDistributor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistributor.FormattingEnabled = true;
            this.cboDistributor.Location = new System.Drawing.Point(141, 228);
            this.cboDistributor.Name = "cboDistributor";
            this.cboDistributor.Size = new System.Drawing.Size(133, 21);
            this.cboDistributor.TabIndex = 6;
            this.cboDistributor.SelectedIndexChanged += new System.EventHandler(this.cboDistributor_SelectedIndexChanged);
            // 
            // distributorBindingSource
            // 
            this.distributorBindingSource.DataMember = "Distributor";
            this.distributorBindingSource.DataSource = this.teamOneDataSet;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(141, 332);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(133, 21);
            this.cboType.TabIndex = 10;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // itemTypeBindingSource
            // 
            this.itemTypeBindingSource.DataMember = "Item_Type";
            this.itemTypeBindingSource.DataSource = this.teamOneDataSet;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // distributorTableAdapter
            // 
            this.distributorTableAdapter.ClearBeforeFill = true;
            // 
            // item_TypeTableAdapter
            // 
            this.item_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // cboSection
            // 
            this.cboSection.DataSource = this.sectionViewBindingSource;
            this.cboSection.DisplayMember = "Section";
            this.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSection.FormattingEnabled = true;
            this.cboSection.Location = new System.Drawing.Point(202, 147);
            this.cboSection.Name = "cboSection";
            this.cboSection.Size = new System.Drawing.Size(72, 21);
            this.cboSection.TabIndex = 3;
            this.cboSection.SelectedIndexChanged += new System.EventHandler(this.cboSection_SelectedIndexChanged);
            // 
            // sectionViewBindingSource
            // 
            this.sectionViewBindingSource.DataMember = "Section View";
            this.sectionViewBindingSource.DataSource = this.teamOneDataSet;
            // 
            // cboShelf
            // 
            this.cboShelf.DataSource = this.shelfViewBindingSource;
            this.cboShelf.DisplayMember = "Shelf";
            this.cboShelf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShelf.FormattingEnabled = true;
            this.cboShelf.Location = new System.Drawing.Point(202, 175);
            this.cboShelf.Name = "cboShelf";
            this.cboShelf.Size = new System.Drawing.Size(72, 21);
            this.cboShelf.TabIndex = 4;
            this.cboShelf.SelectedIndexChanged += new System.EventHandler(this.cboShelf_SelectedIndexChanged);
            // 
            // shelfViewBindingSource
            // 
            this.shelfViewBindingSource.DataMember = "Shelf View";
            this.shelfViewBindingSource.DataSource = this.teamOneDataSet;
            // 
            // row_ViewTableAdapter
            // 
            this.row_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // section_ViewTableAdapter
            // 
            this.section_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // shelf_ViewTableAdapter
            // 
            this.shelf_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Shelf";
            // 
            // shelfbindingSource
            // 
            this.shelfbindingSource.DataMember = "Shelf";
            this.shelfbindingSource.DataSource = this.teamOneDataSet;
            // 
            // shelfTableAdapter
            // 
            this.shelfTableAdapter.ClearBeforeFill = true;
            // 
            // usedCheckBox
            // 
            this.usedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.itemBindingSource, "Used", true));
            this.usedCheckBox.Location = new System.Drawing.Point(141, 358);
            this.usedCheckBox.Name = "usedCheckBox";
            this.usedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.usedCheckBox.TabIndex = 48;
            this.usedCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmEdit_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(375, 435);
            this.Controls.Add(usedLabel);
            this.Controls.Add(this.usedCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboShelf);
            this.Controls.Add(this.cboSection);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboDistributor);
            this.Controls.Add(this.cboManufacturer);
            this.Controls.Add(this.cboRow);
            this.Controls.Add(item_CodeLabel);
            this.Controls.Add(this.item_CodeTextBox);
            this.Controls.Add(item_DescriptionLabel);
            this.Controls.Add(this.item_DescriptionTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(shelf_Location_codeLabel);
            this.Controls.Add(this.shelf_Location_codeTextBox);
            this.Controls.Add(manufacturer_CodeLabel);
            this.Controls.Add(this.manufacturer_CodeTextBox);
            this.Controls.Add(distributor_CodeLabel);
            this.Controls.Add(this.distributor_CodeTextBox);
            this.Controls.Add(retail_PriceLabel);
            this.Controls.Add(this.retail_PriceTextBox);
            this.Controls.Add(wholesale_PriceLabel);
            this.Controls.Add(this.wholesale_PriceTextBox);
            this.Controls.Add(sale_PriceLabel);
            this.Controls.Add(this.sale_PriceTextBox);
            this.Controls.Add(type_CodeLabel);
            this.Controls.Add(this.type_CodeTextBox);
            this.Controls.Add(this.itemBindingNavigator);
            this.Controls.Add(this.btnDone);
            this.Name = "frmEdit_Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.frmEdit_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingNavigator)).EndInit();
            this.itemBindingNavigator.ResumeLayout(false);
            this.itemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private TeamOneDataSet teamOneDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private TeamOneDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private TeamOneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator itemBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton itemBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox item_CodeTextBox;
        private System.Windows.Forms.TextBox item_DescriptionTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox shelf_Location_codeTextBox;
        private System.Windows.Forms.TextBox manufacturer_CodeTextBox;
        private System.Windows.Forms.TextBox distributor_CodeTextBox;
        private System.Windows.Forms.TextBox retail_PriceTextBox;
        private System.Windows.Forms.TextBox wholesale_PriceTextBox;
        private System.Windows.Forms.TextBox sale_PriceTextBox;
        private System.Windows.Forms.TextBox type_CodeTextBox;
        private System.Windows.Forms.ComboBox cboRow;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.ComboBox cboDistributor;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private TeamOneDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource distributorBindingSource;
        private TeamOneDataSetTableAdapters.DistributorTableAdapter distributorTableAdapter;
        private System.Windows.Forms.BindingSource itemTypeBindingSource;
        private TeamOneDataSetTableAdapters.Item_TypeTableAdapter item_TypeTableAdapter;
        private System.Windows.Forms.ComboBox cboSection;
        private System.Windows.Forms.ComboBox cboShelf;
        private System.Windows.Forms.BindingSource rowViewBindingSource;
        private TeamOneDataSetTableAdapters.Row_ViewTableAdapter row_ViewTableAdapter;
        private System.Windows.Forms.BindingSource sectionViewBindingSource;
        private TeamOneDataSetTableAdapters.Section_ViewTableAdapter section_ViewTableAdapter;
        private System.Windows.Forms.BindingSource shelfViewBindingSource;
        private TeamOneDataSetTableAdapters.Shelf_ViewTableAdapter shelf_ViewTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource shelfbindingSource;
        private TeamOneDataSetTableAdapters.ShelfTableAdapter shelfTableAdapter;
        private System.Windows.Forms.CheckBox usedCheckBox;
    }
}