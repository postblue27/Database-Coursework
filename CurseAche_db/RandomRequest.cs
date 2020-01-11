using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CurseAche_db
{
    public partial class RandomRequest : Form
    {
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nazar\Desktop\CurseAche_db\CurseAche_db\CarMarket_db.mdf;Integrated Security=True";
        public RandomRequest()
        {
            InitializeComponent();
        }

        private void DoSQLButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(richTextBox1.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Select";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
