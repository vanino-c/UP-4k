﻿
namespace Учебка2
{
    partial class Product_line
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_line));
            System.Windows.Forms.Label nAMELabel;
            this.computer_ShopDataSet1 = new Учебка2.Computer_ShopDataSet1();
            this.productLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productLineTableAdapter = new Учебка2.Computer_ShopDataSet1TableAdapters.ProductLineTableAdapter();
            this.tableAdapterManager = new Учебка2.Computer_ShopDataSet1TableAdapters.TableAdapterManager();
            this.productLineBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productLineBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computer_ShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLineBindingNavigator)).BeginInit();
            this.productLineBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // computer_ShopDataSet1
            // 
            this.computer_ShopDataSet1.DataSetName = "Computer_ShopDataSet1";
            this.computer_ShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productLineBindingSource
            // 
            this.productLineBindingSource.DataMember = "ProductLine";
            this.productLineBindingSource.DataSource = this.computer_ShopDataSet1;
            // 
            // productLineTableAdapter
            // 
            this.productLineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLSTableAdapter = null;
            this.tableAdapterManager.CATALOGSTableAdapter = null;
            this.tableAdapterManager.CustomsTableAdapter = null;
            this.tableAdapterManager.EMPLOYEESTableAdapter = null;
            this.tableAdapterManager.ProductLineTableAdapter = this.productLineTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Учебка2.Computer_ShopDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // productLineBindingNavigator
            // 
            this.productLineBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productLineBindingNavigator.BindingSource = this.productLineBindingSource;
            this.productLineBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productLineBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productLineBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productLineBindingNavigatorSaveItem});
            this.productLineBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productLineBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productLineBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productLineBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productLineBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productLineBindingNavigator.Name = "productLineBindingNavigator";
            this.productLineBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productLineBindingNavigator.Size = new System.Drawing.Size(326, 25);
            this.productLineBindingNavigator.TabIndex = 0;
            this.productLineBindingNavigator.Text = "bindingNavigator1";
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
            // productLineBindingNavigatorSaveItem
            // 
            this.productLineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productLineBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productLineBindingNavigatorSaveItem.Image")));
            this.productLineBindingNavigatorSaveItem.Name = "productLineBindingNavigatorSaveItem";
            this.productLineBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.productLineBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.productLineBindingNavigatorSaveItem.Click += new System.EventHandler(this.productLineBindingNavigatorSaveItem_Click);
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(27, 95);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(83, 13);
            nAMELabel.TabIndex = 1;
            nAMELabel.Text = "Наименование";
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productLineBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(116, 92);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMETextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Товарные группы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Product_line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(this.productLineBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product_line";
            this.Text = "Товарные группы";
            this.Load += new System.EventHandler(this.Product_line_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computer_ShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLineBindingNavigator)).EndInit();
            this.productLineBindingNavigator.ResumeLayout(false);
            this.productLineBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Computer_ShopDataSet1 computer_ShopDataSet1;
        private System.Windows.Forms.BindingSource productLineBindingSource;
        private Computer_ShopDataSet1TableAdapters.ProductLineTableAdapter productLineTableAdapter;
        private Computer_ShopDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productLineBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productLineBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.Label label1;
    }
}