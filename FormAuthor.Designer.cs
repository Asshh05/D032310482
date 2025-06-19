namespace D032310482
{
    partial class FormAuthor
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
            this.LabelAuthorID = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelBirthYear = new System.Windows.Forms.Label();
            this.textBoxAuthorID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBirthYear = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFormBook = new System.Windows.Forms.Button();
            this.buttonFormStock = new System.Windows.Forms.Button();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.admiralBookstoreDataSet = new D032310482.AdmiralBookstoreDataSet();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new D032310482.AdmiralBookstoreDataSetTableAdapters.AuthorTableAdapter();
            this.tableAdapterManager = new D032310482.AdmiralBookstoreDataSetTableAdapters.TableAdapterManager();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAuthorID
            // 
            this.LabelAuthorID.AutoSize = true;
            this.LabelAuthorID.Location = new System.Drawing.Point(196, 258);
            this.LabelAuthorID.Name = "LabelAuthorID";
            this.LabelAuthorID.Size = new System.Drawing.Size(58, 16);
            this.LabelAuthorID.TabIndex = 0;
            this.LabelAuthorID.Text = "AuthorID";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(192, 291);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(44, 16);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Name";
            // 
            // LabelBirthYear
            // 
            this.LabelBirthYear.AutoSize = true;
            this.LabelBirthYear.Location = new System.Drawing.Point(192, 319);
            this.LabelBirthYear.Name = "LabelBirthYear";
            this.LabelBirthYear.Size = new System.Drawing.Size(62, 16);
            this.LabelBirthYear.TabIndex = 2;
            this.LabelBirthYear.Text = "BirthYear";
            // 
            // textBoxAuthorID
            // 
            this.textBoxAuthorID.Location = new System.Drawing.Point(291, 258);
            this.textBoxAuthorID.Name = "textBoxAuthorID";
            this.textBoxAuthorID.Size = new System.Drawing.Size(164, 22);
            this.textBoxAuthorID.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(291, 291);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(164, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxBirthYear
            // 
            this.textBoxBirthYear.Location = new System.Drawing.Point(291, 319);
            this.textBoxBirthYear.Name = "textBoxBirthYear";
            this.textBoxBirthYear.Size = new System.Drawing.Size(164, 22);
            this.textBoxBirthYear.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(128, 369);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 31);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Location = new System.Drawing.Point(278, 369);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(79, 31);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(417, 368);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 32);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonFormBook
            // 
            this.buttonFormBook.Location = new System.Drawing.Point(685, 319);
            this.buttonFormBook.Name = "buttonFormBook";
            this.buttonFormBook.Size = new System.Drawing.Size(104, 45);
            this.buttonFormBook.TabIndex = 9;
            this.buttonFormBook.Text = "Form Book";
            this.buttonFormBook.UseVisualStyleBackColor = true;
            this.buttonFormBook.Click += new System.EventHandler(this.buttonFormBook_Click);
            // 
            // buttonFormStock
            // 
            this.buttonFormStock.Location = new System.Drawing.Point(685, 370);
            this.buttonFormStock.Name = "buttonFormStock";
            this.buttonFormStock.Size = new System.Drawing.Size(104, 39);
            this.buttonFormStock.TabIndex = 10;
            this.buttonFormStock.Text = "Form Stock";
            this.buttonFormStock.UseVisualStyleBackColor = true;
            this.buttonFormStock.Click += new System.EventHandler(this.buttonFormStock_Click);
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.AutoGenerateColumns = false;
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthYearDataGridViewTextBoxColumn});
            this.dataGridViewAuthor.DataSource = this.authorBindingSource;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(95, 50);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.RowHeadersWidth = 51;
            this.dataGridViewAuthor.RowTemplate.Height = 24;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(425, 150);
            this.dataGridViewAuthor.TabIndex = 11;
            // 
            // admiralBookstoreDataSet
            // 
            this.admiralBookstoreDataSet.DataSetName = "AdmiralBookstoreDataSet";
            this.admiralBookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.admiralBookstoreDataSet;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = this.authorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = D032310482.AdmiralBookstoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthYearDataGridViewTextBoxColumn
            // 
            this.birthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.HeaderText = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthYearDataGridViewTextBoxColumn.Name = "birthYearDataGridViewTextBoxColumn";
            this.birthYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 569);
            this.Controls.Add(this.dataGridViewAuthor);
            this.Controls.Add(this.buttonFormStock);
            this.Controls.Add(this.buttonFormBook);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxBirthYear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAuthorID);
            this.Controls.Add(this.LabelBirthYear);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelAuthorID);
            this.Name = "FormAuthor";
            this.Text = "FormAuthor";
            this.Load += new System.EventHandler(this.FormAuthor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAuthorID;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelBirthYear;
        private System.Windows.Forms.TextBox textBoxAuthorID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBirthYear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFormBook;
        private System.Windows.Forms.Button buttonFormStock;
        private System.Windows.Forms.DataGridView dataGridViewAuthor;
        private AdmiralBookstoreDataSet admiralBookstoreDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private AdmiralBookstoreDataSetTableAdapters.AuthorTableAdapter authorTableAdapter;
        private AdmiralBookstoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthYearDataGridViewTextBoxColumn;
    }
}