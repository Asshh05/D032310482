using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D032310482
{
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void buttonFormStock_Click(object sender, EventArgs e)
        {
            FormStock stockForm = new FormStock();
            stockForm.Show();
        }

    }
 }
