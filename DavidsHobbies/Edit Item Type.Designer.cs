namespace DavidsHobbies
{
    partial class frmEdit_Item_Type
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
            System.Windows.Forms.Label type_CodeLabel;
            System.Windows.Forms.Label type_DescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit_Item_Type));
            this.teamOneDataSet = new DavidsHobbies.TeamOneDataSet();
            this.item_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_TypeTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.Item_TypeTableAdapter();
            this.tableAdapterManager = new DavidsHobbies.TeamOneDataSetTableAdapters.TableAdapterManager();
            this.item_TypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.item_TypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.type_CodeTextBox = new System.Windows.Forms.TextBox();
            this.type_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            type_CodeLabel = new System.Windows.Forms.Label();
            type_DescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_TypeBindingNavigator)).BeginInit();
            this.item_TypeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // type_CodeLabel
            // 
            type_CodeLabel.AutoSize = true;
            type_CodeLabel.Location = new System.Drawing.Point(47, 46);
            type_CodeLabel.Name = "type_CodeLabel";
            type_CodeLabel.Size = new System.Drawing.Size(62, 13);
            type_CodeLabel.TabIndex = 1;
            type_CodeLabel.Text = "Type Code:";
            // 
            // type_DescriptionLabel
            // 
            type_DescriptionLabel.AutoSize = true;
            type_DescriptionLabel.Location = new System.Drawing.Point(47, 72);
            type_DescriptionLabel.Name = "type_DescriptionLabel";
            type_DescriptionLabel.Size = new System.Drawing.Size(90, 13);
            type_DescriptionLabel.TabIndex = 3;
            type_DescriptionLabel.Text = "Type Description:";
            // 
            // teamOneDataSet
            // 
            this.teamOneDataSet.DataSetName = "TeamOneDataSet";
            this.teamOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // item_TypeBindingSource
            // 
            this.item_TypeBindingSource.DataMember = "Item_Type";
            this.item_TypeBindingSource.DataSource = this.teamOneDataSet;
            // 
            // item_TypeTableAdapter
            // 
            this.item_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DistributorTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.InsuranceTypeTableAdapter = null;
            this.tableAdapterManager.Item_TypeTableAdapter = this.item_TypeTableAdapter;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.JobsTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.SalaryTypeTableAdapter = null;
            this.tableAdapterManager.ShelfTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DavidsHobbies.TeamOneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // item_TypeBindingNavigator
            // 
            this.item_TypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.item_TypeBindingNavigator.BindingSource = this.item_TypeBindingSource;
            this.item_TypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.item_TypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.item_TypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.item_TypeBindingNavigatorSaveItem});
            this.item_TypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.item_TypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.item_TypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.item_TypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.item_TypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.item_TypeBindingNavigator.Name = "item_TypeBindingNavigator";
            this.item_TypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.item_TypeBindingNavigator.Size = new System.Drawing.Size(292, 25);
            this.item_TypeBindingNavigator.TabIndex = 0;
            this.item_TypeBindingNavigator.Text = "bindingNavigator1";
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
            // item_TypeBindingNavigatorSaveItem
            // 
            this.item_TypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.item_TypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("item_TypeBindingNavigatorSaveItem.Image")));
            this.item_TypeBindingNavigatorSaveItem.Name = "item_TypeBindingNavigatorSaveItem";
            this.item_TypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.item_TypeBindingNavigatorSaveItem.Text = "Save Data";
            this.item_TypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.item_TypeBindingNavigatorSaveItem_Click);
            // 
            // type_CodeTextBox
            // 
            this.type_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.item_TypeBindingSource, "Type_Code", true));
            this.type_CodeTextBox.Location = new System.Drawing.Point(143, 43);
            this.type_CodeTextBox.Name = "type_CodeTextBox";
            this.type_CodeTextBox.ReadOnly = true;
            this.type_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.type_CodeTextBox.TabIndex = 2;
            // 
            // type_DescriptionTextBox
            // 
            this.type_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.item_TypeBindingSource, "Type_Description", true));
            this.type_DescriptionTextBox.Location = new System.Drawing.Point(143, 69);
            this.type_DescriptionTextBox.Name = "type_DescriptionTextBox";
            this.type_DescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.type_DescriptionTextBox.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(168, 101);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmEdit_Item_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(292, 136);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(type_CodeLabel);
            this.Controls.Add(this.type_CodeTextBox);
            this.Controls.Add(type_DescriptionLabel);
            this.Controls.Add(this.type_DescriptionTextBox);
            this.Controls.Add(this.item_TypeBindingNavigator);
            this.Name = "frmEdit_Item_Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Item Type";
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_TypeBindingNavigator)).EndInit();
            this.item_TypeBindingNavigator.ResumeLayout(false);
            this.item_TypeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeamOneDataSet teamOneDataSet;
        private System.Windows.Forms.BindingSource item_TypeBindingSource;
        private TeamOneDataSetTableAdapters.Item_TypeTableAdapter item_TypeTableAdapter;
        private TeamOneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator item_TypeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton item_TypeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox type_CodeTextBox;
        private System.Windows.Forms.TextBox type_DescriptionTextBox;
        private System.Windows.Forms.Button btnDone;
    }
}