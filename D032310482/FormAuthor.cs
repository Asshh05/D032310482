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
using System.Xml.Linq;

namespace D032310482
{
    public partial class FormAuthor : Form
    {
        public FormAuthor()
        {
            InitializeComponent();
            LoadAuthorData();
            buttonLoadAuthor.Visible = false; // Hide the button initially

        }

        private void FormAuthor_Load(object sender, EventArgs e)
        {
            LoadAuthorData();
        }

        private void LoadAuthorData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LABTEST2\D032310482\D032310482\ADMIRALBOOKSTOREDATABASE.MDF;Integrated Security=True";
            string query = "SELECT * FROM Author";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewAuthor.DataSource = dt;
            }
        }

        private void buttonLoadAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LABTEST2\D032310482\D032310482\ADMIRALBOOKSTOREDATABASE.MDF;Integrated Security=True";
                string query = "SELECT * FROM Author";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewAuthor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LABTEST2\D032310482\D032310482\ADMIRALBOOKSTOREDATABASE.MDF;Integrated Security=True";
            string query = "INSERT INTO Author (AuthorID, Name, BirthYear) VALUES (@Authorid, @name, @Byear)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Authorid", textBoxAuthorID.Text);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.Parameters.AddWithValue("@Byear", textBoxBirthYear.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berjaya ditambah!");
                    LoadAuthorData(); // Refresh the data grid view
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ralat: " + ex.Message);
                }
            }
        }

        private void buttonFormBook_Click(object sender, EventArgs e)
        {
            FormBook bookForm = new FormBook();
            bookForm.Show();
        }

        private void buttonFormStock_Click(object sender, EventArgs e)
        {
            FormStock stockForm = new FormStock();
            stockForm.Show();
        }
    }
}

