namespace DavidsHobbies
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            System.Windows.Forms.Label customer_IDLabel;
            System.Windows.Forms.Label customer_FirstNameLabel;
            System.Windows.Forms.Label customer_LastNameLabel;
            System.Windows.Forms.Label customer_StreetAddressLabel;
            System.Windows.Forms.Label customer_CityLabel;
            System.Windows.Forms.Label customer_StateLabel;
            System.Windows.Forms.Label customer_ZipLabel;
            System.Windows.Forms.Label customer_BalanceLabel;
            System.Windows.Forms.Label customer_PaymentTypeLabel;
            System.Windows.Forms.Label customer_CreditCardNumberLabel;
            System.Windows.Forms.Label customer_LicenseIDNumberLabel;
            this.teamOneDataSet = new DavidsHobbies.TeamOneDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new DavidsHobbies.TeamOneDataSetTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customer_IDTextBox = new System.Windows.Forms.TextBox();
            this.customer_FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.customer_LastNameTextBox = new System.Windows.Forms.TextBox();
            this.customer_StreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.customer_CityTextBox = new System.Windows.Forms.TextBox();
            this.customer_StateTextBox = new System.Windows.Forms.TextBox();
            this.customer_ZipTextBox = new System.Windows.Forms.TextBox();
            this.customer_BalanceTextBox = new System.Windows.Forms.TextBox();
            this.customer_PaymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.customer_CreditCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.customer_LicenseIDNumberTextBox = new System.Windows.Forms.TextBox();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            customer_IDLabel = new System.Windows.Forms.Label();
            customer_FirstNameLabel = new System.Windows.Forms.Label();
            customer_LastNameLabel = new System.Windows.Forms.Label();
            customer_StreetAddressLabel = new System.Windows.Forms.Label();
            customer_CityLabel = new System.Windows.Forms.Label();
            customer_StateLabel = new System.Windows.Forms.Label();
            customer_ZipLabel = new System.Windows.Forms.Label();
            customer_BalanceLabel = new System.Windows.Forms.Label();
            customer_PaymentTypeLabel = new System.Windows.Forms.Label();
            customer_CreditCardNumberLabel = new System.Windows.Forms.Label();
            customer_LicenseIDNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teamOneDataSet
            // 
            this.teamOneDataSet.DataSetName = "TeamOneDataSet";
            this.teamOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.teamOneDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.DistributorTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.InsuranceTypeTableAdapter = null;
            this.tableAdapterManager.Item_TypeTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.JobsTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.SalaryTypeTableAdapter = null;
            this.tableAdapterManager.ShelfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DavidsHobbies.TeamOneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(868, 25);
            this.customersBindingNavigator.TabIndex = 3;
            this.customersBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
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
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click_1);
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Location = new System.Drawing.Point(21, 49);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(68, 13);
            customer_IDLabel.TabIndex = 3;
            customer_IDLabel.Text = "Customer ID:";
            // 
            // customer_IDTextBox
            // 
            this.customer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_ID", true));
            this.customer_IDTextBox.Location = new System.Drawing.Point(24, 65);
            this.customer_IDTextBox.Name = "customer_IDTextBox";
            this.customer_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_IDTextBox.TabIndex = 4;
            // 
            // customer_FirstNameLabel
            // 
            customer_FirstNameLabel.AutoSize = true;
            customer_FirstNameLabel.Location = new System.Drawing.Point(146, 49);
            customer_FirstNameLabel.Name = "customer_FirstNameLabel";
            customer_FirstNameLabel.Size = new System.Drawing.Size(107, 13);
            customer_FirstNameLabel.TabIndex = 4;
            customer_FirstNameLabel.Text = "Customer First Name:";
            // 
            // customer_FirstNameTextBox
            // 
            this.customer_FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_FirstName", true));
            this.customer_FirstNameTextBox.Location = new System.Drawing.Point(149, 65);
            this.customer_FirstNameTextBox.Name = "customer_FirstNameTextBox";
            this.customer_FirstNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.customer_FirstNameTextBox.TabIndex = 5;
            // 
            // customer_LastNameLabel
            // 
            customer_LastNameLabel.AutoSize = true;
            customer_LastNameLabel.Location = new System.Drawing.Point(354, 49);
            customer_LastNameLabel.Name = "customer_LastNameLabel";
            customer_LastNameLabel.Size = new System.Drawing.Size(108, 13);
            customer_LastNameLabel.TabIndex = 5;
            customer_LastNameLabel.Text = "Customer Last Name:";
            // 
            // customer_LastNameTextBox
            // 
            this.customer_LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_LastName", true));
            this.customer_LastNameTextBox.Location = new System.Drawing.Point(357, 65);
            this.customer_LastNameTextBox.Name = "customer_LastNameTextBox";
            this.customer_LastNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.customer_LastNameTextBox.TabIndex = 6;
            // 
            // customer_StreetAddressLabel
            // 
            customer_StreetAddressLabel.AutoSize = true;
            customer_StreetAddressLabel.Location = new System.Drawing.Point(21, 99);
            customer_StreetAddressLabel.Name = "customer_StreetAddressLabel";
            customer_StreetAddressLabel.Size = new System.Drawing.Size(126, 13);
            customer_StreetAddressLabel.TabIndex = 7;
            customer_StreetAddressLabel.Text = "Customer Street Address:";
            // 
            // customer_StreetAddressTextBox
            // 
            this.customer_StreetAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_StreetAddress", true));
            this.customer_StreetAddressTextBox.Location = new System.Drawing.Point(24, 115);
            this.customer_StreetAddressTextBox.Name = "customer_StreetAddressTextBox";
            this.customer_StreetAddressTextBox.Size = new System.Drawing.Size(322, 20);
            this.customer_StreetAddressTextBox.TabIndex = 8;
            // 
            // customer_CityLabel
            // 
            customer_CityLabel.AutoSize = true;
            customer_CityLabel.Location = new System.Drawing.Point(372, 99);
            customer_CityLabel.Name = "customer_CityLabel";
            customer_CityLabel.Size = new System.Drawing.Size(74, 13);
            customer_CityLabel.TabIndex = 9;
            customer_CityLabel.Text = "Customer City:";
            // 
            // customer_CityTextBox
            // 
            this.customer_CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_City", true));
            this.customer_CityTextBox.Location = new System.Drawing.Point(375, 115);
            this.customer_CityTextBox.Name = "customer_CityTextBox";
            this.customer_CityTextBox.Size = new System.Drawing.Size(137, 20);
            this.customer_CityTextBox.TabIndex = 10;
            // 
            // customer_StateLabel
            // 
            customer_StateLabel.AutoSize = true;
            customer_StateLabel.Location = new System.Drawing.Point(538, 99);
            customer_StateLabel.Name = "customer_StateLabel";
            customer_StateLabel.Size = new System.Drawing.Size(82, 13);
            customer_StateLabel.TabIndex = 11;
            customer_StateLabel.Text = "Customer State:";
            // 
            // customer_StateTextBox
            // 
            this.customer_StateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_State", true));
            this.customer_StateTextBox.Location = new System.Drawing.Point(541, 115);
            this.customer_StateTextBox.MaxLength = 2;
            this.customer_StateTextBox.Name = "customer_StateTextBox";
            this.customer_StateTextBox.Size = new System.Drawing.Size(38, 20);
            this.customer_StateTextBox.TabIndex = 12;
            // 
            // customer_ZipLabel
            // 
            customer_ZipLabel.AutoSize = true;
            customer_ZipLabel.Location = new System.Drawing.Point(645, 99);
            customer_ZipLabel.Name = "customer_ZipLabel";
            customer_ZipLabel.Size = new System.Drawing.Size(72, 13);
            customer_ZipLabel.TabIndex = 13;
            customer_ZipLabel.Text = "Customer Zip:";
            // 
            // customer_ZipTextBox
            // 
            this.customer_ZipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_Zip", true));
            this.customer_ZipTextBox.Location = new System.Drawing.Point(648, 115);
            this.customer_ZipTextBox.MaxLength = 10;
            this.customer_ZipTextBox.Name = "customer_ZipTextBox";
            this.customer_ZipTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_ZipTextBox.TabIndex = 14;
            // 
            // customer_BalanceLabel
            // 
            customer_BalanceLabel.AutoSize = true;
            customer_BalanceLabel.Location = new System.Drawing.Point(21, 161);
            customer_BalanceLabel.Name = "customer_BalanceLabel";
            customer_BalanceLabel.Size = new System.Drawing.Size(96, 13);
            customer_BalanceLabel.TabIndex = 15;
            customer_BalanceLabel.Text = "Customer Balance:";
            // 
            // customer_BalanceTextBox
            // 
            this.customer_BalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_Balance", true));
            this.customer_BalanceTextBox.Location = new System.Drawing.Point(24, 177);
            this.customer_BalanceTextBox.Name = "customer_BalanceTextBox";
            this.customer_BalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_BalanceTextBox.TabIndex = 16;
            // 
            // customer_PaymentTypeLabel
            // 
            customer_PaymentTypeLabel.AutoSize = true;
            customer_PaymentTypeLabel.Location = new System.Drawing.Point(148, 161);
            customer_PaymentTypeLabel.Name = "customer_PaymentTypeLabel";
            customer_PaymentTypeLabel.Size = new System.Drawing.Size(125, 13);
            customer_PaymentTypeLabel.TabIndex = 17;
            customer_PaymentTypeLabel.Text = "Customer Payment Type:";
            // 
            // customer_PaymentTypeComboBox
            // 
            this.customer_PaymentTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_PaymentType", true));
            this.customer_PaymentTypeComboBox.FormattingEnabled = true;
            this.customer_PaymentTypeComboBox.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "Discover",
            "AMEX",
            "Bill Customer"});
            this.customer_PaymentTypeComboBox.Location = new System.Drawing.Point(149, 177);
            this.customer_PaymentTypeComboBox.Name = "customer_PaymentTypeComboBox";
            this.customer_PaymentTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.customer_PaymentTypeComboBox.TabIndex = 18;
            // 
            // customer_CreditCardNumberLabel
            // 
            customer_CreditCardNumberLabel.AutoSize = true;
            customer_CreditCardNumberLabel.Location = new System.Drawing.Point(297, 161);
            customer_CreditCardNumberLabel.Name = "customer_CreditCardNumberLabel";
            customer_CreditCardNumberLabel.Size = new System.Drawing.Size(149, 13);
            customer_CreditCardNumberLabel.TabIndex = 19;
            customer_CreditCardNumberLabel.Text = "Customer Credit Card Number:";
            // 
            // customer_CreditCardNumberTextBox
            // 
            this.customer_CreditCardNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_CreditCardNumber", true));
            this.customer_CreditCardNumberTextBox.Location = new System.Drawing.Point(300, 178);
            this.customer_CreditCardNumberTextBox.Name = "customer_CreditCardNumberTextBox";
            this.customer_CreditCardNumberTextBox.Size = new System.Drawing.Size(253, 20);
            this.customer_CreditCardNumberTextBox.TabIndex = 20;
            // 
            // customer_LicenseIDNumberLabel
            // 
            customer_LicenseIDNumberLabel.AutoSize = true;
            customer_LicenseIDNumberLabel.Location = new System.Drawing.Point(586, 161);
            customer_LicenseIDNumberLabel.Name = "customer_LicenseIDNumberLabel";
            customer_LicenseIDNumberLabel.Size = new System.Drawing.Size(145, 13);
            customer_LicenseIDNumberLabel.TabIndex = 21;
            customer_LicenseIDNumberLabel.Text = "Customer License IDNumber:";
            // 
            // customer_LicenseIDNumberTextBox
            // 
            this.customer_LicenseIDNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_LicenseIDNumber", true));
            this.customer_LicenseIDNumberTextBox.Location = new System.Drawing.Point(589, 178);
            this.customer_LicenseIDNumberTextBox.Name = "customer_LicenseIDNumberTextBox";
            this.customer_LicenseIDNumberTextBox.Size = new System.Drawing.Size(193, 20);
            this.customer_LicenseIDNumberTextBox.TabIndex = 22;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(24, 221);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(821, 313);
            this.customersDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Customer_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer_FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer_FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Customer_LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer_LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Customer_StreetAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "Customer_StreetAddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Customer_City";
            this.dataGridViewTextBoxColumn5.HeaderText = "Customer_City";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Customer_State";
            this.dataGridViewTextBoxColumn6.HeaderText = "Customer_State";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Customer_Zip";
            this.dataGridViewTextBoxColumn7.HeaderText = "Customer_Zip";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Customer_Balance";
            this.dataGridViewTextBoxColumn8.HeaderText = "Customer_Balance";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Customer_PaymentType";
            this.dataGridViewTextBoxColumn9.HeaderText = "Customer_PaymentType";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Customer_CreditCardNumber";
            this.dataGridViewTextBoxColumn10.HeaderText = "Customer_CreditCardNumber";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Customer_LicenseIDNumber";
            this.dataGridViewTextBoxColumn11.HeaderText = "Customer_LicenseIDNumber";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 546);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(customer_LicenseIDNumberLabel);
            this.Controls.Add(this.customer_LicenseIDNumberTextBox);
            this.Controls.Add(customer_CreditCardNumberLabel);
            this.Controls.Add(this.customer_CreditCardNumberTextBox);
            this.Controls.Add(customer_PaymentTypeLabel);
            this.Controls.Add(this.customer_PaymentTypeComboBox);
            this.Controls.Add(customer_BalanceLabel);
            this.Controls.Add(this.customer_BalanceTextBox);
            this.Controls.Add(customer_ZipLabel);
            this.Controls.Add(this.customer_ZipTextBox);
            this.Controls.Add(customer_StateLabel);
            this.Controls.Add(this.customer_StateTextBox);
            this.Controls.Add(customer_CityLabel);
            this.Controls.Add(this.customer_CityTextBox);
            this.Controls.Add(customer_StreetAddressLabel);
            this.Controls.Add(this.customer_StreetAddressTextBox);
            this.Controls.Add(customer_LastNameLabel);
            this.Controls.Add(this.customer_LastNameTextBox);
            this.Controls.Add(customer_FirstNameLabel);
            this.Controls.Add(this.customer_FirstNameTextBox);
            this.Controls.Add(customer_IDLabel);
            this.Controls.Add(this.customer_IDTextBox);
            this.Controls.Add(this.customersBindingNavigator);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeamOneDataSet teamOneDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private TeamOneDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private TeamOneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customer_IDTextBox;
        private System.Windows.Forms.TextBox customer_FirstNameTextBox;
        private System.Windows.Forms.TextBox customer_LastNameTextBox;
        private System.Windows.Forms.TextBox customer_StreetAddressTextBox;
        private System.Windows.Forms.TextBox customer_CityTextBox;
        private System.Windows.Forms.TextBox customer_StateTextBox;
        private System.Windows.Forms.TextBox customer_ZipTextBox;
        private System.Windows.Forms.TextBox customer_BalanceTextBox;
        private System.Windows.Forms.ComboBox customer_PaymentTypeComboBox;
        private System.Windows.Forms.TextBox customer_CreditCardNumberTextBox;
        private System.Windows.Forms.TextBox customer_LicenseIDNumberTextBox;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}