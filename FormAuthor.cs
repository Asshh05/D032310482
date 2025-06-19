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
    public partial class FormAuthor : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public FormAuthor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\LABTEST2\D032310482\D032310482\ADMIRALBOOKSTOREDATABASE.MDF;Integrated Security=True";
            connection = new SqlConnection(connectionString);

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
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Author");
                dataGridViewAuthor.DataSource = dataSet.Tables["Author"];
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "INSERT INTO Author (AuthorID, Name, BirthYear) VALUES (@AuthorID, @Name, @BirthYear)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AuthorID", textBoxAuthorID.Text);
                    command.Parameters.AddWithValue("@Name", textBoxName.Text);
                    command.Parameters.AddWithValue("@BirthYear", textBoxBirthYear.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                LoadAuthorData();
            }
        }


        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(textBoxAuthorID.Text) || string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxBirthYear.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
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

        private void FormAuthor_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admiralBookstoreDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.admiralBookstoreDataSet.Author);

        }
    }
}

