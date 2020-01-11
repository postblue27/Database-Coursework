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
    public partial class EditSale : Form
    {
        const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nazar\Desktop\CurseAche_db\CurseAche_db\CarMarket_db.mdf;Integrated Security=True";
        public EditSale()
        {
            InitializeComponent();
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter("SELECT Id FROM Cars", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CarIdBox.Items.Add(dt.Rows[i][0]);
                }

                SqlDataAdapter oda1 = new SqlDataAdapter("SELECT Id FROM Clients", sqlconn);
                DataTable dt1 = new DataTable();
                oda1.Fill(dt1);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    ClientIdBox.Items.Add(dt1.Rows[i][0]);
                }

                SqlDataAdapter oda2 = new SqlDataAdapter("SELECT Id FROM Employees", sqlconn);
                DataTable dt2 = new DataTable();
                oda2.Fill(dt2);
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    EmployeeIdBox.Items.Add(dt2.Rows[i][0]);
                }

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CarBuffer.IsChanging)
                {
                    salesTableAdapter.UpdateQuery(Convert.ToInt32(IdTextBox.Text),
                                        Convert.ToInt32(CarIdBox.Text),
                                        Convert.ToInt32(ClientIdBox.Text),
                                        Convert.ToInt32(EmployeeIdBox.Text),
                                        DateOfSalePicker.Text,
                                        PaymentTypeComboBox.Text);
                }
                else
                {
                    salesTableAdapter.Insert(Convert.ToInt32(IdTextBox.Text),
                                        Convert.ToInt32(CarIdBox.Text),
                                        Convert.ToInt32(ClientIdBox.Text),
                                        Convert.ToInt32(EmployeeIdBox.Text),
                                        DateOfSalePicker.Text,
                                        PaymentTypeComboBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carMarket_dbDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carMarket_dbDataSet.Cars);
            // TODO: This line of code loads data into the 'carMarket_dbDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.carMarket_dbDataSet.Sales);
            try
            {
                if (SaleBuffer.IsChanging)
                {
                    IdTextBox.Text = Convert.ToString(SaleBuffer.id);
                    CarIdBox.Text = Convert.ToString(SaleBuffer.carId);
                    ClientIdBox.Text = Convert.ToString(SaleBuffer.clientId);
                    EmployeeIdBox.Text = Convert.ToString(SaleBuffer.employeeId);
                    DateOfSalePicker.Value = Convert.ToDateTime(SaleBuffer.dateOfSale);
                    PaymentTypeComboBox.Text = SaleBuffer.paymentType;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
