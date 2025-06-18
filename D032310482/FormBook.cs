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
        public FormBook()
        {
            InitializeComponent();
            LoadBookData();

        }
        private void FormBook_Load(object sender, EventArgs e)
        {
            LoadBookData();
        }
        private void LoadBookData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            string query = "SELECT * FROM Book";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewBook.DataSource = null;
                dataGridViewBook.DataSource = dt;
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

        private void buttonUpdateBook_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AdmiralBookstoreDatabase.mdf;Integrated Security=True";
            string query = "UPDATE Book SET Title = @title, Publisher = @publisher, PublishDate = @date WHERE [ISBN-13] = @isbn";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@title", textBoxTitle.Text);
                cmd.Parameters.AddWithValue("@publisher", textBoxPublisher.Text);
                cmd.Parameters.AddWithValue("@date", textBoxPublishDate.Text);
                cmd.Parameters.AddWithValue("@isbn", textBoxISBN.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data buku berjaya dikemaskini!");
                    LoadBookData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ralat: " + ex.Message);
                }
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LABTEST2\D032310482\D032310482\ADMIRALBOOKSTOREDATABASE.MDF;Integrated Security=True";
            string query = "INSERT INTO Book ([ISBN-13], Title, Publisher, PublishDate) VALUES (@isbn, @title, @publisher, @publishdate)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@isbn", textBoxISBN.Text);
                cmd.Parameters.AddWithValue("@title", textBoxTitle.Text);
                cmd.Parameters.AddWithValue("@publisher", textBoxPublisher.Text);
                cmd.Parameters.AddWithValue("@publishdate", textBoxPublishDate.Text);   

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berjaya ditambah!");
                    LoadBookData(); // Refresh the data grid view
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ralat: " + ex.Message);
                }
            }
        }
    }
}
