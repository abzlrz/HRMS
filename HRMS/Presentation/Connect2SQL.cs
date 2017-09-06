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

namespace Presentation
{
    public partial class Connect2SQL : Form
    {
        public Connect2SQL()
        {
            InitializeComponent();
            this.login = new Login();
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (IsCorrect())
            {
                login.Show();
                this.Hide();

                Properties.Settings.Default.ConnectionString = textBox1.Text;
            }
        }

        bool IsCorrect()
        {
            try
            {
                using (var connect = new SqlConnection(textBox1.Text))
                {
                    connect.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private Login login;
    }
}
