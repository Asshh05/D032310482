namespace D032310482
{
    partial class FormStock
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
            this.LabelStock = new System.Windows.Forms.Label();
            this.LabelAuthorIDStock = new System.Windows.Forms.Label();
            this.LabelISBNStock = new System.Windows.Forms.Label();
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.LabelDateRecorded = new System.Windows.Forms.Label();
            this.textBoxStockID = new System.Windows.Forms.TextBox();
            this.comboBoxAuthorIDStock = new System.Windows.Forms.ComboBox();
            this.comboBoxISBNStock = new System.Windows.Forms.ComboBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxDateRecorded = new System.Windows.Forms.TextBox();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
            this.buttonDeleteStock = new System.Windows.Forms.Button();
            this.admiralBookstoreDataSet = new D032310482.AdmiralBookstoreDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new D032310482.AdmiralBookstoreDataSetTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new D032310482.AdmiralBookstoreDataSetTableAdapters.TableAdapterManager();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecordedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelStock
            // 
            this.LabelStock.AutoSize = true;
            this.LabelStock.Location = new System.Drawing.Point(330, 200);
            this.LabelStock.Name = "LabelStock";
            this.LabelStock.Size = new System.Drawing.Size(54, 16);
            this.LabelStock.TabIndex = 0;
            this.LabelStock.Text = "StockID";
            // 
            // LabelAuthorIDStock
            // 
            this.LabelAuthorIDStock.AutoSize = true;
            this.LabelAuthorIDStock.Location = new System.Drawing.Point(330, 228);
            this.LabelAuthorIDStock.Name = "LabelAuthorIDStock";
            this.LabelAuthorIDStock.Size = new System.Drawing.Size(58, 16);
            this.LabelAuthorIDStock.TabIndex = 1;
            this.LabelAuthorIDStock.Text = "AuthorID";
            // 
            // LabelISBNStock
            // 
            this.LabelISBNStock.AutoSize = true;
            this.LabelISBNStock.Location = new System.Drawing.Point(330, 260);
            this.LabelISBNStock.Name = "LabelISBNStock";
            this.LabelISBNStock.Size = new System.Drawing.Size(56, 16);
            this.LabelISBNStock.TabIndex = 2;
            this.LabelISBNStock.Text = "ISBN-13";
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.AutoSize = true;
            this.LabelQuantity.Location = new System.Drawing.Point(330, 295);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(105, 16);
            this.LabelQuantity.TabIndex = 3;
            this.LabelQuantity.Text = "Quantity In Stock";
            // 
            // LabelDateRecorded
            // 
            this.LabelDateRecorded.AutoSize = true;
            this.LabelDateRecorded.Location = new System.Drawing.Point(333, 332);
            this.LabelDateRecorded.Name = "LabelDateRecorded";
            this.LabelDateRecorded.Size = new System.Drawing.Size(100, 16);
            this.LabelDateRecorded.TabIndex = 4;
            this.LabelDateRecorded.Text = "Date Recorded";
            // 
            // textBoxStockID
            // 
            this.textBoxStockID.Location = new System.Drawing.Point(470, 194);
            this.textBoxStockID.Name = "textBoxStockID";
            this.textBoxStockID.Size = new System.Drawing.Size(100, 22);
            this.textBoxStockID.TabIndex = 5;
            // 
            // comboBoxAuthorIDStock
            // 
            this.comboBoxAuthorIDStock.FormattingEnabled = true;
            this.comboBoxAuthorIDStock.Location = new System.Drawing.Point(470, 225);
            this.comboBoxAuthorIDStock.Name = "comboBoxAuthorIDStock";
            this.comboBoxAuthorIDStock.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAuthorIDStock.TabIndex = 6;
            // 
            // comboBoxISBNStock
            // 
            this.comboBoxISBNStock.FormattingEnabled = true;
            this.comboBoxISBNStock.Location = new System.Drawing.Point(470, 260);
            this.comboBoxISBNStock.Name = "comboBoxISBNStock";
            this.comboBoxISBNStock.Size = new System.Drawing.Size(121, 24);
            this.comboBoxISBNStock.TabIndex = 7;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(470, 295);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuantity.TabIndex = 8;
            // 
            // textBoxDateRecorded
            // 
            this.textBoxDateRecorded.Location = new System.Drawing.Point(470, 332);
            this.textBoxDateRecorded.Name = "textBoxDateRecorded";
            this.textBoxDateRecorded.Size = new System.Drawing.Size(100, 22);
            this.textBoxDateRecorded.TabIndex = 9;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AutoGenerateColumns = false;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.authorIDDataGridViewTextBoxColumn,
            this.iSBN13DataGridViewTextBoxColumn,
            this.quantityInStockDataGridViewTextBoxColumn,
            this.dateRecordedDataGridViewTextBoxColumn});
            this.dataGridViewStock.DataSource = this.stockBindingSource;
            this.dataGridViewStock.Location = new System.Drawing.Point(125, 22);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowHeadersWidth = 51;
            this.dataGridViewStock.RowTemplate.Height = 24;
            this.dataGridViewStock.Size = new System.Drawing.Size(679, 150);
            this.dataGridViewStock.TabIndex = 10;
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddStock.Location = new System.Drawing.Point(204, 376);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStock.TabIndex = 11;
            this.buttonAddStock.Text = "Add";
            this.buttonAddStock.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateStock
            // 
            this.buttonUpdateStock.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdateStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateStock.Location = new System.Drawing.Point(348, 377);
            this.buttonUpdateStock.Name = "buttonUpdateStock";
            this.buttonUpdateStock.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateStock.TabIndex = 12;
            this.buttonUpdateStock.Text = "Update";
            this.buttonUpdateStock.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteStock
            // 
            this.buttonDeleteStock.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteStock.Location = new System.Drawing.Point(497, 376);
            this.buttonDeleteStock.Name = "buttonDeleteStock";
            this.buttonDeleteStock.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteStock.TabIndex = 13;
            this.buttonDeleteStock.Text = "Delete";
            this.buttonDeleteStock.UseVisualStyleBackColor = false;
            this.buttonDeleteStock.Click += new System.EventHandler(this.buttonDeleteStock_Click);
            // 
            // admiralBookstoreDataSet
            // 
            this.admiralBookstoreDataSet.DataSetName = "AdmiralBookstoreDataSet";
            this.admiralBookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.admiralBookstoreDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.UpdateOrder = D032310482.AdmiralBookstoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            this.iSBN13DataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            this.quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            this.quantityInStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateRecordedDataGridViewTextBoxColumn
            // 
            this.dateRecordedDataGridViewTextBoxColumn.DataPropertyName = "DateRecorded";
            this.dateRecordedDataGridViewTextBoxColumn.HeaderText = "DateRecorded";
            this.dateRecordedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateRecordedDataGridViewTextBoxColumn.Name = "dateRecordedDataGridViewTextBoxColumn";
            this.dateRecordedDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.buttonDeleteStock);
            this.Controls.Add(this.buttonUpdateStock);
            this.Controls.Add(this.buttonAddStock);
            this.Controls.Add(this.dataGridViewStock);
            this.Controls.Add(this.textBoxDateRecorded);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.comboBoxISBNStock);
            this.Controls.Add(this.comboBoxAuthorIDStock);
            this.Controls.Add(this.textBoxStockID);
            this.Controls.Add(this.LabelDateRecorded);
            this.Controls.Add(this.LabelQuantity);
            this.Controls.Add(this.LabelISBNStock);
            this.Controls.Add(this.LabelAuthorIDStock);
            this.Controls.Add(this.LabelStock);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.Load += new System.EventHandler(this.FormStock_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelStock;
        private System.Windows.Forms.Label LabelAuthorIDStock;
        private System.Windows.Forms.Label LabelISBNStock;
        private System.Windows.Forms.Label LabelQuantity;
        private System.Windows.Forms.Label LabelDateRecorded;
        private System.Windows.Forms.TextBox textBoxStockID;
        private System.Windows.Forms.ComboBox comboBoxAuthorIDStock;
        private System.Windows.Forms.ComboBox comboBoxISBNStock;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxDateRecorded;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.Button buttonUpdateStock;
        private System.Windows.Forms.Button buttonDeleteStock;
        private AdmiralBookstoreDataSet admiralBookstoreDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private AdmiralBookstoreDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private AdmiralBookstoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecordedDataGridViewTextBoxColumn;
    }
}