
namespace Учебка2
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            System.Windows.Forms.Label iD_USERLabel;
            System.Windows.Forms.Label oRDERTIMELabel;
            System.Windows.Forms.Label nUMBERLabel;
            System.Windows.Forms.Label iD_PRODUCTLabel;
            System.Windows.Forms.Label iD_EMPLOYEELabel;
            this.label1 = new System.Windows.Forms.Label();
            this.computer_ShopDataSet1 = new Учебка2.Computer_ShopDataSet1();
            this.customsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customsTableAdapter = new Учебка2.Computer_ShopDataSet1TableAdapters.CustomsTableAdapter();
            this.tableAdapterManager = new Учебка2.Computer_ShopDataSet1TableAdapters.TableAdapterManager();
            this.customsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.customsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_USERTextBox = new System.Windows.Forms.TextBox();
            this.oRDERTIMEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nUMBERTextBox = new System.Windows.Forms.TextBox();
            this.iD_PRODUCTTextBox = new System.Windows.Forms.TextBox();
            this.iD_EMPLOYEETextBox = new System.Windows.Forms.TextBox();
            iD_USERLabel = new System.Windows.Forms.Label();
            oRDERTIMELabel = new System.Windows.Forms.Label();
            nUMBERLabel = new System.Windows.Forms.Label();
            iD_PRODUCTLabel = new System.Windows.Forms.Label();
            iD_EMPLOYEELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computer_ShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customsBindingNavigator)).BeginInit();
            this.customsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заказы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computer_ShopDataSet1
            // 
            this.computer_ShopDataSet1.DataSetName = "Computer_ShopDataSet1";
            this.computer_ShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customsBindingSource
            // 
            this.customsBindingSource.DataMember = "Customs";
            this.customsBindingSource.DataSource = this.computer_ShopDataSet1;
            // 
            // customsTableAdapter
            // 
            this.customsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLSTableAdapter = null;
            this.tableAdapterManager.CATALOGSTableAdapter = null;
            this.tableAdapterManager.CustomsTableAdapter = this.customsTableAdapter;
            this.tableAdapterManager.EMPLOYEESTableAdapter = null;
            this.tableAdapterManager.ProductLineTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Учебка2.Computer_ShopDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // customsBindingNavigator
            // 
            this.customsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customsBindingNavigator.BindingSource = this.customsBindingSource;
            this.customsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customsBindingNavigatorSaveItem});
            this.customsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customsBindingNavigator.Name = "customsBindingNavigator";
            this.customsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customsBindingNavigator.Size = new System.Drawing.Size(336, 25);
            this.customsBindingNavigator.TabIndex = 3;
            this.customsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // customsBindingNavigatorSaveItem
            // 
            this.customsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customsBindingNavigatorSaveItem.Image")));
            this.customsBindingNavigatorSaveItem.Name = "customsBindingNavigatorSaveItem";
            this.customsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.customsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.customsBindingNavigatorSaveItem.Click += new System.EventHandler(this.customsBindingNavigatorSaveItem_Click);
            // 
            // iD_USERLabel
            // 
            iD_USERLabel.AutoSize = true;
            iD_USERLabel.Location = new System.Drawing.Point(22, 114);
            iD_USERLabel.Name = "iD_USERLabel";
            iD_USERLabel.Size = new System.Drawing.Size(80, 13);
            iD_USERLabel.TabIndex = 3;
            iD_USERLabel.Text = "Пользователь";
            // 
            // iD_USERTextBox
            // 
            this.iD_USERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customsBindingSource, "ID_USER", true));
            this.iD_USERTextBox.Location = new System.Drawing.Point(110, 111);
            this.iD_USERTextBox.Name = "iD_USERTextBox";
            this.iD_USERTextBox.Size = new System.Drawing.Size(198, 20);
            this.iD_USERTextBox.TabIndex = 4;
            // 
            // oRDERTIMELabel
            // 
            oRDERTIMELabel.AutoSize = true;
            oRDERTIMELabel.Location = new System.Drawing.Point(27, 141);
            oRDERTIMELabel.Name = "oRDERTIMELabel";
            oRDERTIMELabel.Size = new System.Drawing.Size(72, 13);
            oRDERTIMELabel.TabIndex = 4;
            oRDERTIMELabel.Text = "Дата заказа";
            // 
            // oRDERTIMEDateTimePicker
            // 
            this.oRDERTIMEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customsBindingSource, "ORDERTIME", true));
            this.oRDERTIMEDateTimePicker.Location = new System.Drawing.Point(108, 137);
            this.oRDERTIMEDateTimePicker.Name = "oRDERTIMEDateTimePicker";
            this.oRDERTIMEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.oRDERTIMEDateTimePicker.TabIndex = 5;
            // 
            // nUMBERLabel
            // 
            nUMBERLabel.AutoSize = true;
            nUMBERLabel.Location = new System.Drawing.Point(45, 166);
            nUMBERLabel.Name = "nUMBERLabel";
            nUMBERLabel.Size = new System.Drawing.Size(41, 13);
            nUMBERLabel.TabIndex = 6;
            nUMBERLabel.Text = "Номер";
            // 
            // nUMBERTextBox
            // 
            this.nUMBERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customsBindingSource, "NUMBER", true));
            this.nUMBERTextBox.Location = new System.Drawing.Point(108, 163);
            this.nUMBERTextBox.Name = "nUMBERTextBox";
            this.nUMBERTextBox.Size = new System.Drawing.Size(200, 20);
            this.nUMBERTextBox.TabIndex = 7;
            // 
            // iD_PRODUCTLabel
            // 
            iD_PRODUCTLabel.AutoSize = true;
            iD_PRODUCTLabel.Location = new System.Drawing.Point(48, 192);
            iD_PRODUCTLabel.Name = "iD_PRODUCTLabel";
            iD_PRODUCTLabel.Size = new System.Drawing.Size(38, 13);
            iD_PRODUCTLabel.TabIndex = 8;
            iD_PRODUCTLabel.Text = "Товар";
            // 
            // iD_PRODUCTTextBox
            // 
            this.iD_PRODUCTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customsBindingSource, "ID_PRODUCT", true));
            this.iD_PRODUCTTextBox.Location = new System.Drawing.Point(108, 189);
            this.iD_PRODUCTTextBox.Name = "iD_PRODUCTTextBox";
            this.iD_PRODUCTTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_PRODUCTTextBox.TabIndex = 9;
            // 
            // iD_EMPLOYEELabel
            // 
            iD_EMPLOYEELabel.AutoSize = true;
            iD_EMPLOYEELabel.Location = new System.Drawing.Point(29, 218);
            iD_EMPLOYEELabel.Name = "iD_EMPLOYEELabel";
            iD_EMPLOYEELabel.Size = new System.Drawing.Size(57, 13);
            iD_EMPLOYEELabel.TabIndex = 10;
            iD_EMPLOYEELabel.Text = "Продавец";
            // 
            // iD_EMPLOYEETextBox
            // 
            this.iD_EMPLOYEETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customsBindingSource, "ID_EMPLOYEE", true));
            this.iD_EMPLOYEETextBox.Location = new System.Drawing.Point(108, 215);
            this.iD_EMPLOYEETextBox.Name = "iD_EMPLOYEETextBox";
            this.iD_EMPLOYEETextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_EMPLOYEETextBox.TabIndex = 11;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 260);
            this.Controls.Add(iD_EMPLOYEELabel);
            this.Controls.Add(this.iD_EMPLOYEETextBox);
            this.Controls.Add(iD_PRODUCTLabel);
            this.Controls.Add(this.iD_PRODUCTTextBox);
            this.Controls.Add(nUMBERLabel);
            this.Controls.Add(this.nUMBERTextBox);
            this.Controls.Add(oRDERTIMELabel);
            this.Controls.Add(this.oRDERTIMEDateTimePicker);
            this.Controls.Add(iD_USERLabel);
            this.Controls.Add(this.iD_USERTextBox);
            this.Controls.Add(this.customsBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Orders";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computer_ShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customsBindingNavigator)).EndInit();
            this.customsBindingNavigator.ResumeLayout(false);
            this.customsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Computer_ShopDataSet1 computer_ShopDataSet1;
        private System.Windows.Forms.BindingSource customsBindingSource;
        private Computer_ShopDataSet1TableAdapters.CustomsTableAdapter customsTableAdapter;
        private Computer_ShopDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_USERTextBox;
        private System.Windows.Forms.DateTimePicker oRDERTIMEDateTimePicker;
        private System.Windows.Forms.TextBox nUMBERTextBox;
        private System.Windows.Forms.TextBox iD_PRODUCTTextBox;
        private System.Windows.Forms.TextBox iD_EMPLOYEETextBox;
    }
}