namespace DavidsHobbies
{
    partial class frmEdit_Shelf_Location
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
            System.Windows.Forms.Label shelf_Location_CodeLabel;
            System.Windows.Forms.Label rowLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label shelfLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit_Shelf_Location));
            this.teamOneDataSet = new DavidsHobbies.TeamOneDataSet();
            this.shelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shelfTableAdapter = new DavidsHobbies.TeamOneDataSetTableAdapters.ShelfTableAdapter();
            this.tableAdapterManager = new DavidsHobbies.TeamOneDataSetTableAdapters.TableAdapterManager();
            this.shelfBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.shelfBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.shelf_Location_CodeTextBox = new System.Windows.Forms.TextBox();
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.shelfTextBox = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            shelf_Location_CodeLabel = new System.Windows.Forms.Label();
            rowLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            shelfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingNavigator)).BeginInit();
            this.shelfBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // shelf_Location_CodeLabel
            // 
            shelf_Location_CodeLabel.AutoSize = true;
            shelf_Location_CodeLabel.Location = new System.Drawing.Point(34, 42);
            shelf_Location_CodeLabel.Name = "shelf_Location_CodeLabel";
            shelf_Location_CodeLabel.Size = new System.Drawing.Size(106, 13);
            shelf_Location_CodeLabel.TabIndex = 1;
            shelf_Location_CodeLabel.Text = "Shelf Location Code:";
            // 
            // rowLabel
            // 
            rowLabel.AutoSize = true;
            rowLabel.Location = new System.Drawing.Point(34, 68);
            rowLabel.Name = "rowLabel";
            rowLabel.Size = new System.Drawing.Size(32, 13);
            rowLabel.TabIndex = 3;
            rowLabel.Text = "Row:";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(34, 94);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(46, 13);
            sectionLabel.TabIndex = 5;
            sectionLabel.Text = "Section:";
            // 
            // shelfLabel
            // 
            shelfLabel.AutoSize = true;
            shelfLabel.Location = new System.Drawing.Point(34, 120);
            shelfLabel.Name = "shelfLabel";
            shelfLabel.Size = new System.Drawing.Size(34, 13);
            shelfLabel.TabIndex = 7;
            shelfLabel.Text = "Shelf:";
            // 
            // teamOneDataSet
            // 
            this.teamOneDataSet.DataSetName = "TeamOneDataSet";
            this.teamOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shelfBindingSource
            // 
            this.shelfBindingSource.DataMember = "Shelf";
            this.shelfBindingSource.DataSource = this.teamOneDataSet;
            // 
            // shelfTableAdapter
            // 
            this.shelfTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.SalaryTypeTableAdapter = null;
            this.tableAdapterManager.ShelfTableAdapter = this.shelfTableAdapter;
            this.tableAdapterManager.UpdateOrder = DavidsHobbies.TeamOneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shelfBindingNavigator
            // 
            this.shelfBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.shelfBindingNavigator.BindingSource = this.shelfBindingSource;
            this.shelfBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.shelfBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.shelfBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.shelfBindingNavigatorSaveItem});
            this.shelfBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shelfBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.shelfBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.shelfBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.shelfBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.shelfBindingNavigator.Name = "shelfBindingNavigator";
            this.shelfBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.shelfBindingNavigator.Size = new System.Drawing.Size(296, 25);
            this.shelfBindingNavigator.TabIndex = 0;
            this.shelfBindingNavigator.Text = "bindingNavigator1";
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
            // shelfBindingNavigatorSaveItem
            // 
            this.shelfBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shelfBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shelfBindingNavigatorSaveItem.Image")));
            this.shelfBindingNavigatorSaveItem.Name = "shelfBindingNavigatorSaveItem";
            this.shelfBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.shelfBindingNavigatorSaveItem.Text = "Save Data";
            this.shelfBindingNavigatorSaveItem.Click += new System.EventHandler(this.shelfBindingNavigatorSaveItem_Click);
            // 
            // shelf_Location_CodeTextBox
            // 
            this.shelf_Location_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shelfBindingSource, "Shelf_Location_Code", true));
            this.shelf_Location_CodeTextBox.Location = new System.Drawing.Point(146, 39);
            this.shelf_Location_CodeTextBox.Name = "shelf_Location_CodeTextBox";
            this.shelf_Location_CodeTextBox.ReadOnly = true;
            this.shelf_Location_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.shelf_Location_CodeTextBox.TabIndex = 2;
            // 
            // rowTextBox
            // 
            this.rowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shelfBindingSource, "Row", true));
            this.rowTextBox.Location = new System.Drawing.Point(146, 65);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(100, 20);
            this.rowTextBox.TabIndex = 0;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shelfBindingSource, "Section", true));
            this.sectionTextBox.Location = new System.Drawing.Point(146, 91);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionTextBox.TabIndex = 1;
            // 
            // shelfTextBox
            // 
            this.shelfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shelfBindingSource, "Shelf", true));
            this.shelfTextBox.Location = new System.Drawing.Point(146, 117);
            this.shelfTextBox.Name = "shelfTextBox";
            this.shelfTextBox.Size = new System.Drawing.Size(100, 20);
            this.shelfTextBox.TabIndex = 2;
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(171, 146);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmEdit_Shelf_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(296, 181);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(shelf_Location_CodeLabel);
            this.Controls.Add(this.shelf_Location_CodeTextBox);
            this.Controls.Add(rowLabel);
            this.Controls.Add(this.rowTextBox);
            this.Controls.Add(sectionLabel);
            this.Controls.Add(this.sectionTextBox);
            this.Controls.Add(shelfLabel);
            this.Controls.Add(this.shelfTextBox);
            this.Controls.Add(this.shelfBindingNavigator);
            this.Name = "frmEdit_Shelf_Location";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Shelf Location";
            ((System.ComponentModel.ISupportInitialize)(this.teamOneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingNavigator)).EndInit();
            this.shelfBindingNavigator.ResumeLayout(false);
            this.shelfBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeamOneDataSet teamOneDataSet;
        private System.Windows.Forms.BindingSource shelfBindingSource;
        private TeamOneDataSetTableAdapters.ShelfTableAdapter shelfTableAdapter;
        private TeamOneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator shelfBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton shelfBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox shelf_Location_CodeTextBox;
        private System.Windows.Forms.TextBox rowTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox shelfTextBox;
        private System.Windows.Forms.Button btnDone;
    }
}