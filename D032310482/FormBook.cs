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
    public partial class FormBook : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        public FormBook()
        {
            InitializeComponent();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LABTEST2\D032310482\D032310482\ADMIRALBOOKSTOREDATABASE.MDF;Integrated Security=True";
            connection = new SqlConnection(connectionString);   

        }
        private void FormBook_Load(object sender, EventArgs e)
        {
            LoadBookData();
        }
        private void LoadBookData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LABTEST2\D032310482\D032310482\ADMIRALBOOKSTOREDATABASE.MDF;Integrated Security=True";
            string query = "SELECT * FROM Book";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Book");


                dataGridViewBook.DataSource = dataSet.Tables["Book"];
               
            }
        }


        

        private void buttonFormBook_Click(object sender, EventArgs e)
        {
            FormBook bookForm = new FormBook();
            bookForm.Show();
        }

        private void buttonFormStockBook_Click(object sender, EventArgs e)
        {
            FormStock stockForm = new FormStock();
            stockForm.Show();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(textBoxISBN.Text) || string.IsNullOrEmpty(textBoxTitle.Text) ||
                string.IsNullOrEmpty(textBoxPublisher.Text) || string.IsNullOrEmpty(textBoxPublishDate.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }


        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "UPDATE Book SET Title = @title, Publisher = @publisher, PublishDate = @date WHERE [ISBN-13] = @isbn";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@isbn", textBoxISBN.Text);
                    command.Parameters.AddWithValue("@title", textBoxTitle.Text);
                    command.Parameters.AddWithValue("@publisher", textBoxPublisher.Text);
                    command.Parameters.AddWithValue("@date", textBoxPublishDate.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadBookData(); // Refresh the data grid view
            }
        }
    }
}
