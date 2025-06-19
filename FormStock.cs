using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D032310482
{
    public partial class FormStock : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public FormStock()
        {
            InitializeComponent();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LABTEST2\D032310482\D032310482\ADMIRALBOOKSTOREDATABASE.MDF;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            LoadStockData();
        }

        private void LoadStockData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LABTEST2\D032310482\D032310482\ADMIRALBOOKSTOREDATABASE.MDF;Integrated Security=True";
            string query = "SELECT * FROM Stock";

            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Stock");

                dataGridViewStock.DataSource = dataSet.Tables["Stock"];
            }
        }

        private void buttonFormStock_Click(object sender, EventArgs e)
        {
            FormStock stockForm = new FormStock();
            stockForm.Show();
        }

        private void buttonDeleteStock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxStockID.Text))
            {
                string query = "DELETE FROM stock WHERE StockID = @StockID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", textBoxStockID.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadStockData();
            }
            else
            {
                MessageBox.Show("Please enter a StockID to delete.");
            }
        }

        private void FormStock_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstoreDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.admiralBookstoreDataSet.Stock);

        }
    }
 }
