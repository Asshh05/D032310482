namespace D032310482
{
    partial class FormBook
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
            this.LabelISBN = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelPublisher = new System.Windows.Forms.Label();
            this.LabelPublishDate = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxPublishDate = new System.Windows.Forms.TextBox();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonFormStockBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.admiralBookstoreDataSet = new D032310482.AdmiralBookstoreDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new D032310482.AdmiralBookstoreDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new D032310482.AdmiralBookstoreDataSetTableAdapters.TableAdapterManager();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelISBN
            // 
            this.LabelISBN.AutoSize = true;
            this.LabelISBN.Location = new System.Drawing.Point(302, 187);
            this.LabelISBN.Name = "LabelISBN";
            this.LabelISBN.Size = new System.Drawing.Size(56, 16);
            this.LabelISBN.TabIndex = 0;
            this.LabelISBN.Text = "ISBN-13";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(302, 220);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(33, 16);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Title";
            // 
            // LabelPublisher
            // 
            this.LabelPublisher.AutoSize = true;
            this.LabelPublisher.Location = new System.Drawing.Point(302, 258);
            this.LabelPublisher.Name = "LabelPublisher";
            this.LabelPublisher.Size = new System.Drawing.Size(63, 16);
            this.LabelPublisher.TabIndex = 2;
            this.LabelPublisher.Text = "Publisher";
            // 
            // LabelPublishDate
            // 
            this.LabelPublishDate.AutoSize = true;
            this.LabelPublishDate.Location = new System.Drawing.Point(302, 291);
            this.LabelPublishDate.Name = "LabelPublishDate";
            this.LabelPublishDate.Size = new System.Drawing.Size(80, 16);
            this.LabelPublishDate.TabIndex = 3;
            this.LabelPublishDate.Text = "PublishDate";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(423, 187);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(109, 22);
            this.textBoxISBN.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(423, 220);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(205, 22);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(423, 251);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(109, 22);
            this.textBoxPublisher.TabIndex = 6;
            // 
            // textBoxPublishDate
            // 
            this.textBoxPublishDate.Location = new System.Drawing.Point(423, 284);
            this.textBoxPublishDate.Name = "textBoxPublishDate";
            this.textBoxPublishDate.Size = new System.Drawing.Size(109, 22);
            this.textBoxPublishDate.TabIndex = 7;
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AutoGenerateColumns = false;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBN13DataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.publishDateDataGridViewTextBoxColumn});
            this.dataGridViewBook.DataSource = this.bookBindingSource;
            this.dataGridViewBook.Location = new System.Drawing.Point(83, 12);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 51;
            this.dataGridViewBook.RowTemplate.Height = 24;
            this.dataGridViewBook.Size = new System.Drawing.Size(553, 150);
            this.dataGridViewBook.TabIndex = 8;
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdateBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateBook.Location = new System.Drawing.Point(290, 357);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(75, 29);
            this.buttonUpdateBook.TabIndex = 10;
            this.buttonUpdateBook.Text = "Update";
            this.buttonUpdateBook.UseVisualStyleBackColor = false;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteBook.Location = new System.Drawing.Point(439, 357);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(74, 29);
            this.buttonDeleteBook.TabIndex = 11;
            this.buttonDeleteBook.Text = "Delete";
            this.buttonDeleteBook.UseVisualStyleBackColor = false;
            // 
            // buttonFormStockBook
            // 
            this.buttonFormStockBook.Location = new System.Drawing.Point(684, 305);
            this.buttonFormStockBook.Name = "buttonFormStockBook";
            this.buttonFormStockBook.Size = new System.Drawing.Size(93, 31);
            this.buttonFormStockBook.TabIndex = 12;
            this.buttonFormStockBook.Text = "Form Stock";
            this.buttonFormStockBook.UseVisualStyleBackColor = true;
            this.buttonFormStockBook.Click += new System.EventHandler(this.buttonFormStockBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAddBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddBook.Location = new System.Drawing.Point(165, 362);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBook.TabIndex = 13;
            this.buttonAddBook.Text = "Add";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            // 
            // admiralBookstoreDataSet
            // 
            this.admiralBookstoreDataSet.DataSetName = "AdmiralBookstoreDataSet";
            this.admiralBookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.admiralBookstoreDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = D032310482.AdmiralBookstoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            this.iSBN13DataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // publishDateDataGridViewTextBoxColumn
            // 
            this.publishDateDataGridViewTextBoxColumn.DataPropertyName = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.HeaderText = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publishDateDataGridViewTextBoxColumn.Name = "publishDateDataGridViewTextBoxColumn";
            this.publishDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonFormStockBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonUpdateBook);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.textBoxPublishDate);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.LabelPublishDate);
            this.Controls.Add(this.LabelPublisher);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelISBN);
            this.Name = "FormBook";
            this.Text = "FormBook";
            this.Load += new System.EventHandler(this.FormBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelISBN;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelPublisher;
        private System.Windows.Forms.Label LabelPublishDate;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxPublishDate;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonFormStockBook;
        private System.Windows.Forms.Button buttonAddBook;
        private AdmiralBookstoreDataSet admiralBookstoreDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private AdmiralBookstoreDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private AdmiralBookstoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
    }
}