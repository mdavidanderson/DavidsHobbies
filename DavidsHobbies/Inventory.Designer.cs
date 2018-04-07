namespace DavidsHobbies
{
    partial class frmInventory
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
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchInv = new System.Windows.Forms.TextBox();
            this.btnSearchInv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wholesalePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Used = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamOneDataSet = new DavidsHobbies.TeamOneDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditManufacturers = new System.Windows.Forms.Button();
            this.btnEditDistributors = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtShelf = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.txtWholePrice = new System.Windows.Forms.TextBox();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtDistributor = new System.Windows.Forms.TextBox();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnEditItems = new System.Windows.Forms.Button();
            this.btnCancelInv = new System.Windows.Forms.Button();
            this.btnEditShelfLocations = new System.Windows.Forms.Button();
            this.btnEditItemTypes = new System.Windows.Forms.Button();
            this.item_ViewTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.Item_ViewTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUsed = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "(None)",
            "Item Description",
            "Manufacturer",
            "Distributor",
            "Item Type"});
            this.cboSearchBy.Location = new System.Drawing.Point(33, 35);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(247, 21);
            this.cboSearchBy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by...";
            // 
            // txtSearchInv
            // 
            this.txtSearchInv.Location = new System.Drawing.Point(286, 35);
            this.txtSearchInv.Name = "txtSearchInv";
            this.txtSearchInv.Size = new System.Drawing.Size(431, 20);
            this.txtSearchInv.TabIndex = 1;
            // 
            // btnSearchInv
            // 
            this.btnSearchInv.Location = new System.Drawing.Point(723, 33);
            this.btnSearchInv.Name = "btnSearchInv";
            this.btnSearchInv.Size = new System.Drawing.Size(75, 23);
            this.btnSearchInv.TabIndex = 2;
            this.btnSearchInv.Text = "Search";
            this.btnSearchInv.UseVisualStyleBackColor = true;
            this.btnSearchInv.Click += new System.EventHandler(this.btnSearchInv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.rowDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.manufacturerNameDataGridViewTextBoxColumn,
            this.distributorNameDataGridViewTextBoxColumn,
            this.retailPriceDataGridViewTextBoxColumn,
            this.wholesalePriceDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.typeDescriptionDataGridViewTextBoxColumn,
            this.Used});
            this.dataGridView1.DataSource = this.itemViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(765, 130);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Item_Description";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item_Description";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowDataGridViewTextBoxColumn
            // 
            this.rowDataGridViewTextBoxColumn.DataPropertyName = "Row";
            this.rowDataGridViewTextBoxColumn.HeaderText = "Row";
            this.rowDataGridViewTextBoxColumn.Name = "rowDataGridViewTextBoxColumn";
            this.rowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "Shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "Shelf";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            this.shelfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerNameDataGridViewTextBoxColumn
            // 
            this.manufacturerNameDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer_Name";
            this.manufacturerNameDataGridViewTextBoxColumn.HeaderText = "Manufacturer_Name";
            this.manufacturerNameDataGridViewTextBoxColumn.Name = "manufacturerNameDataGridViewTextBoxColumn";
            this.manufacturerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distributorNameDataGridViewTextBoxColumn
            // 
            this.distributorNameDataGridViewTextBoxColumn.DataPropertyName = "Distributor_Name";
            this.distributorNameDataGridViewTextBoxColumn.HeaderText = "Distributor_Name";
            this.distributorNameDataGridViewTextBoxColumn.Name = "distributorNameDataGridViewTextBoxColumn";
            this.distributorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // retailPriceDataGridViewTextBoxColumn
            // 
            this.retailPriceDataGridViewTextBoxColumn.DataPropertyName = "Retail_Price";
            this.retailPriceDataGridViewTextBoxColumn.HeaderText = "Retail_Price";
            this.retailPriceDataGridViewTextBoxColumn.Name = "retailPriceDataGridViewTextBoxColumn";
            this.retailPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wholesalePriceDataGridViewTextBoxColumn
            // 
            this.wholesalePriceDataGridViewTextBoxColumn.DataPropertyName = "Wholesale_Price";
            this.wholesalePriceDataGridViewTextBoxColumn.HeaderText = "Wholesale_Price";
            this.wholesalePriceDataGridViewTextBoxColumn.Name = "wholesalePriceDataGridViewTextBoxColumn";
            this.wholesalePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "Sale_Price";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "Sale_Price";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDescriptionDataGridViewTextBoxColumn
            // 
            this.typeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Type_Description";
            this.typeDescriptionDataGridViewTextBoxColumn.HeaderText = "Type_Description";
            this.typeDescriptionDataGridViewTextBoxColumn.Name = "typeDescriptionDataGridViewTextBoxColumn";
            this.typeDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Used
            // 
            this.Used.DataPropertyName = "Used";
            this.Used.HeaderText = "Used";
            this.Used.Name = "Used";
            this.Used.ReadOnly = true;
            // 
            // itemViewBindingSource
            // 
            this.itemViewBindingSource.DataMember = "Item View";
            this.itemViewBindingSource.DataSource = this.teamOneDataSet;
            // 
            // teamOneDataSet
            // 
            this.teamOneDataSet.DataSetName = "TeamOneDataSet";
            this.teamOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Retail Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wholesale Price:";
            // 
            // btnEditManufacturers
            // 
            this.btnEditManufacturers.Location = new System.Drawing.Point(622, 283);
            this.btnEditManufacturers.Name = "btnEditManufacturers";
            this.btnEditManufacturers.Size = new System.Drawing.Size(171, 23);
            this.btnEditManufacturers.TabIndex = 4;
            this.btnEditManufacturers.Text = "Edit Manufacturers";
            this.btnEditManufacturers.UseVisualStyleBackColor = true;
            this.btnEditManufacturers.Click += new System.EventHandler(this.btnEditManufacturers_Click);
            // 
            // btnEditDistributors
            // 
            this.btnEditDistributors.Location = new System.Drawing.Point(622, 312);
            this.btnEditDistributors.Name = "btnEditDistributors";
            this.btnEditDistributors.Size = new System.Drawing.Size(171, 23);
            this.btnEditDistributors.TabIndex = 5;
            this.btnEditDistributors.Text = "Edit Distributors";
            this.btnEditDistributors.UseVisualStyleBackColor = true;
            this.btnEditDistributors.Click += new System.EventHandler(this.btnEditDistributors_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sale Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Manufacturer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Distributor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtShelf);
            this.groupBox1.Controls.Add(this.txtSection);
            this.groupBox1.Controls.Add(this.txtRow);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(436, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 103);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // txtShelf
            // 
            this.txtShelf.Location = new System.Drawing.Point(71, 71);
            this.txtShelf.Name = "txtShelf";
            this.txtShelf.ReadOnly = true;
            this.txtShelf.Size = new System.Drawing.Size(79, 20);
            this.txtShelf.TabIndex = 25;
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(71, 44);
            this.txtSection.Name = "txtSection";
            this.txtSection.ReadOnly = true;
            this.txtSection.Size = new System.Drawing.Size(79, 20);
            this.txtSection.TabIndex = 25;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(71, 18);
            this.txtRow.Name = "txtRow";
            this.txtRow.ReadOnly = true;
            this.txtRow.Size = new System.Drawing.Size(79, 20);
            this.txtRow.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Shelf:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Section:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Row:";
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(144, 254);
            this.txtItemDesc.Multiline = true;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.ReadOnly = true;
            this.txtItemDesc.Size = new System.Drawing.Size(441, 50);
            this.txtItemDesc.TabIndex = 16;
            // 
            // txtWholePrice
            // 
            this.txtWholePrice.Location = new System.Drawing.Point(144, 310);
            this.txtWholePrice.Name = "txtWholePrice";
            this.txtWholePrice.ReadOnly = true;
            this.txtWholePrice.Size = new System.Drawing.Size(264, 20);
            this.txtWholePrice.TabIndex = 17;
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Location = new System.Drawing.Point(144, 336);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.ReadOnly = true;
            this.txtRetailPrice.Size = new System.Drawing.Size(264, 20);
            this.txtRetailPrice.TabIndex = 18;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(144, 362);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.ReadOnly = true;
            this.txtSalePrice.Size = new System.Drawing.Size(264, 20);
            this.txtSalePrice.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Item Type:";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(144, 414);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(264, 20);
            this.txtManufacturer.TabIndex = 21;
            // 
            // txtDistributor
            // 
            this.txtDistributor.Location = new System.Drawing.Point(144, 441);
            this.txtDistributor.Name = "txtDistributor";
            this.txtDistributor.ReadOnly = true;
            this.txtDistributor.Size = new System.Drawing.Size(264, 20);
            this.txtDistributor.TabIndex = 22;
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(144, 388);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.ReadOnly = true;
            this.txtItemType.Size = new System.Drawing.Size(264, 20);
            this.txtItemType.TabIndex = 23;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(506, 310);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(79, 20);
            this.txtQuantity.TabIndex = 24;
            // 
            // btnEditItems
            // 
            this.btnEditItems.Location = new System.Drawing.Point(622, 254);
            this.btnEditItems.Name = "btnEditItems";
            this.btnEditItems.Size = new System.Drawing.Size(171, 23);
            this.btnEditItems.TabIndex = 3;
            this.btnEditItems.Text = "Edit Items";
            this.btnEditItems.UseVisualStyleBackColor = true;
            this.btnEditItems.Click += new System.EventHandler(this.btnEditItems_Click);
            // 
            // btnCancelInv
            // 
            this.btnCancelInv.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelInv.Location = new System.Drawing.Point(622, 433);
            this.btnCancelInv.Name = "btnCancelInv";
            this.btnCancelInv.Size = new System.Drawing.Size(171, 23);
            this.btnCancelInv.TabIndex = 8;
            this.btnCancelInv.Text = "Cancel";
            this.btnCancelInv.UseVisualStyleBackColor = true;
            this.btnCancelInv.Click += new System.EventHandler(this.btnCancelInv_Click);
            // 
            // btnEditShelfLocations
            // 
            this.btnEditShelfLocations.Location = new System.Drawing.Point(622, 341);
            this.btnEditShelfLocations.Name = "btnEditShelfLocations";
            this.btnEditShelfLocations.Size = new System.Drawing.Size(171, 23);
            this.btnEditShelfLocations.TabIndex = 6;
            this.btnEditShelfLocations.Text = "Edit Shelf Locations";
            this.btnEditShelfLocations.UseVisualStyleBackColor = true;
            this.btnEditShelfLocations.Click += new System.EventHandler(this.btnEditShelfLocations_Click);
            // 
            // btnEditItemTypes
            // 
            this.btnEditItemTypes.Location = new System.Drawing.Point(622, 371);
            this.btnEditItemTypes.Name = "btnEditItemTypes";
            this.btnEditItemTypes.Size = new System.Drawing.Size(171, 23);
            this.btnEditItemTypes.TabIndex = 7;
            this.btnEditItemTypes.Text = "Edit Item Types";
            this.btnEditItemTypes.UseVisualStyleBackColor = true;
            this.btnEditItemTypes.Click += new System.EventHandler(this.btnEditItemTypes_Click);
            // 
            // item_ViewTableAdapter
            // 
            this.item_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(442, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Used?";
            // 
            // txtUsed
            // 
            this.txtUsed.Location = new System.Drawing.Point(506, 336);
            this.txtUsed.Name = "txtUsed";
            this.txtUsed.ReadOnly = true;
            this.txtUsed.Size = new System.Drawing.Size(79, 20);
            this.txtUsed.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(503, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Select an Item_Description from the table above to view the details in the boxes " +
                "below:";
            // 
            // frmInventory
            // 
            this.AcceptButton = this.btnSearchInv;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelInv;
            this.ClientSize = new System.Drawing.Size(828, 488);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtUsed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnEditItemTypes);
            this.Controls.Add(this.btnEditShelfLocations);
            this.Controls.Add(this.btnCancelInv);
            this.Controls.Add(this.btnEditItems);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.txtDistributor);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.txtWholePrice);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditDistributors);
            this.Controls.Add(this.btnEditManufacturers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchInv);
            this.Controls.Add(this.txtSearchInv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSearchBy);
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchInv;
        private System.Windows.Forms.Button btnSearchInv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditManufacturers;
        private System.Windows.Forms.Button btnEditDistributors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShelf;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.TextBox txtWholePrice;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtDistributor;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnEditItems;
        private System.Windows.Forms.Button btnCancelInv;
        private System.Windows.Forms.Button btnEditShelfLocations;
        private System.Windows.Forms.Button btnEditItemTypes;
        private TeamOneDataSet teamOneDataSet;
        private System.Windows.Forms.BindingSource itemViewBindingSource;
        private TeamOneDataSetTableAdapters.Item_ViewTableAdapter item_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn newDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wholesalePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Used;
        private System.Windows.Forms.Label label14;
    }
}