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
using System.Runtime.Serialization.Json;
using System.IO;

namespace CurseAche_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string s = System.Environment.CurrentDirectory + @"\CarMarket_db.mdf;Integrated Security=True";
        }
        const string ConnectionString = @"Data Source=|DataDirectory|\CarMarket_db.mdf;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            // TODO: This line of code loads data into the 'carMarket_dbDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.carMarket_dbDataSet.Sales);
            // TODO: This line of code loads data into the 'carMarket_dbDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.carMarket_dbDataSet.Employees);
            // TODO: This line of code loads data into the 'carMarket_dbDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.carMarket_dbDataSet.Clients);
            // TODO: This line of code loads data into the 'carMarket_dbDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carMarket_dbDataSet.Cars);
            
            ShowCarsButton.BackColor = SystemColors.ActiveCaption;
            dataGridView1.ClearSelection();

            label1.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            CarFilter1.Enabled = true;
            CarFilter2.Enabled = true;

            label2.Enabled = false;
            ClientFilter.Enabled = false;

        }

        private void ShowCarsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = carsBindingSource;
            ShowCarsButton.BackColor = SystemColors.ActiveCaption;
            ShowClientsButton.BackColor = SystemColors.ControlLight;
            ShowEmployeesButton.BackColor = SystemColors.ControlLight;
            SalesButton.BackColor = SystemColors.ControlLight;
            dataGridView1.ClearSelection();

            label1.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            CarFilter1.Enabled = true;
            CarFilter2.Enabled = true;

            label2.Enabled = false;
            ClientFilter.Enabled = false;

        }

        private void ShowClientsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientsBindingSource;
            ShowClientsButton.BackColor = SystemColors.ActiveCaption;
            ShowCarsButton.BackColor = SystemColors.ControlLight;
            ShowEmployeesButton.BackColor = SystemColors.ControlLight;
            SalesButton.BackColor = SystemColors.ControlLight;
            dataGridView1.ClearSelection();

            label1.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            CarFilter1.Enabled = false;
            CarFilter2.Enabled = false;

            label2.Enabled = true;
            ClientFilter.Enabled = true;

        }

        private void ShowEmployeesButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeesBindingSource;
            ShowEmployeesButton.BackColor = SystemColors.ActiveCaption;
            ShowClientsButton.BackColor = SystemColors.ControlLight;
            ShowCarsButton.BackColor = SystemColors.ControlLight;
            SalesButton.BackColor = SystemColors.ControlLight;
            dataGridView1.ClearSelection();

            groupBox1.Enabled = false;
        }
        private void SalesButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = salesBindingSource;
            SalesButton.BackColor = SystemColors.ActiveCaption;
            ShowClientsButton.BackColor = SystemColors.ControlLight;
            ShowCarsButton.BackColor = SystemColors.ControlLight;
            ShowEmployeesButton.BackColor = SystemColors.ControlLight;
            dataGridView1.ClearSelection();

            groupBox1.Enabled = false;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            carsTableAdapter.Update(carMarket_dbDataSet);
            Application.Exit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                if (dataGridView1.Columns[1].HeaderText == "Mark")
                {
                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Cars WHERE Mark LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                             "OR Id LIKE N\'" + SearchTextBox.Text + "\'" +
                                             "OR Model LIKE N\'%" + SearchTextBox.Text + "%\'" + 
                                             "OR ReleaseDate LIKE N\'%" + SearchTextBox.Text + "%\'" + 
                                             "OR VINCode LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                             "OR EngineModel LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                             "OR EnginePower LIKE N\'%" + SearchTextBox.Text + "%\'" + 
                                             "OR EngineCapacity LIKE N\'%" + SearchTextBox.Text + "%\'" + 
                                             "OR Weight LIKE N\'%" + SearchTextBox.Text + "%\'" + 
                                             "OR Country LIKE N\'%" + SearchTextBox.Text + "%\'" + 
                                             "OR Price LIKE N\'%" + SearchTextBox.Text + "%\'", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (dataGridView1.Columns[2].HeaderText == "Sex")
                {
                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Clients WHERE Name LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                                                  "OR Id LIKE N\'" + SearchTextBox.Text + "\'" +
                                                                  "OR Sex LIKE N\'" + SearchTextBox.Text + "\'" +
                                                                  "OR PhoneNumber LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                                                  "OR Passport LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                                                  "OR BirthDate LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                                                  "OR Residence LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                                                  "OR Email LIKE N\'%" + SearchTextBox.Text + "%\'", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (dataGridView1.Columns[2].HeaderText == "Post")
                {
                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Employees WHERE Name LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                             "OR Id LIKE N\'" + SearchTextBox.Text + "\'" +
                                             "OR Post LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                             "OR PhoneNumber LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                             "OR Passport LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                             "OR BirthDate LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                             "OR Residence LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                             "OR Email LIKE N\'%" + SearchTextBox.Text + "%\'" + 
                                             "OR StartWorkingDate LIKE N\'%" + SearchTextBox.Text + "%\'", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (dataGridView1.Columns[1].HeaderText == "CarId")
                {
                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Sales WHERE Id LIKE N\'" + SearchTextBox.Text + "\'" +
                                             "OR CarId LIKE N\'" + SearchTextBox.Text + "\'" +
                                             "OR ClientId LIKE N\'" + SearchTextBox.Text + "\'" +
                                             "OR EmployeeId LIKE N\'" + SearchTextBox.Text + "\'" +
                                             "OR DateOfSale LIKE N\'%" + SearchTextBox.Text + "%\'" +
                                             "OR PaymentType LIKE N\'%" + SearchTextBox.Text + "%\'", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dt.Columns.Add(new DataColumn("BuyersName", typeof (string)));
                    //SqlDataAdapter sql = new SqlDataAdapter("SELECT Name FROM Clients WHERE Id = (SELECT ClientId FROM Sales WHERE ClientId = )", sqlconn);
                    //dt.Columns["BuyersName"].Expression = 
                    dataGridView1.DataSource = dt;
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            dataGridView1.ClearSelection();
            SearchButton.Focus();
            ShowCarsButton.BackColor = SystemColors.ControlLight;
            ShowClientsButton.BackColor = SystemColors.ControlLight;
            ShowEmployeesButton.BackColor = SystemColors.ControlLight;
            SalesButton.BackColor = SystemColors.ControlLight;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CarBuffer.IsChanging = false;
            ClientBuffer.IsChanging = false;
            EmployeeBuffer.IsChanging = false;
            SaleBuffer.IsChanging = false;
            if (dataGridView1.DataSource == carsBindingSource)
            {
                EditCar form = new EditCar();
                form.ShowDialog();
                carsTableAdapter.Fill(carMarket_dbDataSet.Cars);
                carMarket_dbDataSet.AcceptChanges();
            }
            if (dataGridView1.DataSource == clientsBindingSource)
            {
                EditClient form = new EditClient();
                form.ShowDialog();
                clientsTableAdapter.Fill(carMarket_dbDataSet.Clients);
                carMarket_dbDataSet.AcceptChanges();
            }
            if (dataGridView1.DataSource == employeesBindingSource)
            {
                EditEmployee form = new EditEmployee();
                form.ShowDialog();
                employeesTableAdapter.Fill(carMarket_dbDataSet.Employees);
                carMarket_dbDataSet.AcceptChanges();
            }
            if (dataGridView1.DataSource == salesBindingSource)
            {
                EditSale form = new EditSale();
                form.ShowDialog();
                salesTableAdapter.Fill(carMarket_dbDataSet.Sales);
                carMarket_dbDataSet.AcceptChanges();
            }
            dataGridView1.ClearSelection();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(CarBuffer.id));
            try
            {
                if (dataGridView1.Columns[1].HeaderText == "Mark")
                {
                    carsTableAdapter.DeleteQuery(CarBuffer.id);
                    carsTableAdapter.Fill(carMarket_dbDataSet.Cars);
                    carMarket_dbDataSet.AcceptChanges();
                }
                if (dataGridView1.Columns[2].HeaderText == "Sex")
                {
                    clientsTableAdapter.DeleteQuery(ClientBuffer.id);
                    clientsTableAdapter.Fill(carMarket_dbDataSet.Clients);
                    carMarket_dbDataSet.AcceptChanges(); 
                }
                if (dataGridView1.Columns[2].HeaderText == "Post")
                {
                    employeesTableAdapter.DeleteQuery(EmployeeBuffer.id);
                    employeesTableAdapter.Fill(carMarket_dbDataSet.Employees);
                    carMarket_dbDataSet.AcceptChanges();
                }
                if (dataGridView1.Columns[1].HeaderText == "CarId")
                {
                    salesTableAdapter.DeleteQuery(SaleBuffer.id);
                    salesTableAdapter.Fill(carMarket_dbDataSet.Sales);
                    carMarket_dbDataSet.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            CarBuffer.IsChanging = true;
            ClientBuffer.IsChanging = true;
            EmployeeBuffer.IsChanging = true;
            SaleBuffer.IsChanging = true;
            //MessageBox.Show(Convert.ToString(SaleBuffer.IsChanging));
            if (dataGridView1.Columns[1].HeaderText == "Mark")
            {
                EditCar form = new EditCar();
                form.ShowDialog();
                carsTableAdapter.Fill(carMarket_dbDataSet.Cars);
                carMarket_dbDataSet.AcceptChanges();
            }
            if (dataGridView1.Columns[2].HeaderText == "Sex")
            {
                EditClient form = new EditClient();
                form.ShowDialog();
                clientsTableAdapter.Fill(carMarket_dbDataSet.Clients);
                carMarket_dbDataSet.AcceptChanges();
            }
            if (dataGridView1.Columns[2].HeaderText == "Post")
            {
                EditEmployee form = new EditEmployee();
                form.ShowDialog();
                employeesTableAdapter.Fill(carMarket_dbDataSet.Employees);
                carMarket_dbDataSet.AcceptChanges();
            }
            if (dataGridView1.Columns[1].HeaderText == "CarId")
            {
                EditSale form = new EditSale();
                form.ShowDialog();
                salesTableAdapter.Fill(carMarket_dbDataSet.Sales);
                carMarket_dbDataSet.AcceptChanges();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*CarBuffer.IsChanging = true;
            ClientBuffer.IsChanging = true;
            EmployeeBuffer.IsChanging = true;
            SaleBuffer.IsChanging = true;*/
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dataGridView1.Columns[1].HeaderText == "Mark")
                    {
                        CarBuffer.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        CarBuffer.mark = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                        CarBuffer.model = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                        CarBuffer.releaseDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                        CarBuffer.vinCode = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                        CarBuffer.engineModel = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                        CarBuffer.enginePower = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                        CarBuffer.engineCapacity = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                        CarBuffer.weight = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                        CarBuffer.country = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                        CarBuffer.price = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
                    }
                    if (dataGridView1.Columns[2].HeaderText == "Sex")
                    {
                        ClientBuffer.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        ClientBuffer.name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                        ClientBuffer.sex = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                        ClientBuffer.phoneNumber = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                        ClientBuffer.passport = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                        ClientBuffer.birthDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                        ClientBuffer.residence = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                        ClientBuffer.email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                    }
                    if (dataGridView1.Columns[2].HeaderText == "Post")
                    {
                        EmployeeBuffer.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        EmployeeBuffer.name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                        EmployeeBuffer.post = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                        EmployeeBuffer.phoneNumber = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                        EmployeeBuffer.passport = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                        EmployeeBuffer.birthDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                        EmployeeBuffer.residence = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                        EmployeeBuffer.email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                        EmployeeBuffer.StartWorkingDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                    }
                    if (dataGridView1.Columns[1].HeaderText == "CarId")
                    {
                        SaleBuffer.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        SaleBuffer.carId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                        SaleBuffer.clientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                        SaleBuffer.employeeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                        SaleBuffer.dateOfSale = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                        SaleBuffer.paymentType = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            //MessageBox.Show(Convert.ToString(CarBuffer.id));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        private void AcceptFiltersButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                if (dataGridView1.Columns[1].HeaderText == "Mark")
                {
                    if (CarFilter1.Text == "" && CarFilter2.Text == "")
                    {
                    }
                    else
                    {
                        if (IsDigitsOnly(CarFilter1.Text) == false || IsDigitsOnly(CarFilter2.Text) == false)
                        {
                            MessageBox.Show("В поля фильтрации можно вводить только целые числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                            this.Activate();
                        }
                        else
                        {
                            try
                            {
                                if (CarFilter1.Text == "" && CarFilter2.Text != "")
                                {
                                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Cars WHERE Price <= " + CarFilter2.Text, sqlconn);
                                    DataTable dt = new DataTable();
                                    oda.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                }
                                if (CarFilter1.Text != "" && CarFilter2.Text == "")
                                {
                                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Cars WHERE Price >= " + CarFilter1.Text, sqlconn);
                                    DataTable dt = new DataTable();
                                    oda.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                }
                                if (CarFilter1.Text != "" && CarFilter2.Text != "")
                                {
                                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Cars WHERE Price >= " + CarFilter1.Text + " AND Price <= " + CarFilter2.Text, sqlconn);
                                    DataTable dt = new DataTable();
                                    oda.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(@"Error: " + ex.Message);
                            }
                        }
                    }
                }
                if (dataGridView1.Columns[2].HeaderText == "Sex")
                {
                    if (ClientFilter.Text == "")
                    {
                    }
                    else
                    {
                        if (ClientFilter.Text == "М")
                        {
                            SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Clients WHERE Sex = N\'М\'", sqlconn);
                            DataTable dt = new DataTable();
                            oda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        if (ClientFilter.Text == "Ж")
                        {
                            SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Clients WHERE Sex = N\'Ж\'", sqlconn);
                            DataTable dt = new DataTable();
                            oda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                if (dataGridView1.Columns[2].HeaderText == "Post")
                {

                }
                if (dataGridView1.Columns[1].HeaderText == "CarId")
                {

                }
                sqlconn.Close();
                ShowCarsButton.BackColor = SystemColors.ControlLight;
                ShowClientsButton.BackColor = SystemColors.ControlLight;
                ShowEmployeesButton.BackColor = SystemColors.ControlLight;
                SalesButton.BackColor = SystemColors.ControlLight;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void DeleteFiltersButton_Click(object sender, EventArgs e)
        {
            CarFilter1.Text = "";
            CarFilter2.Text = "";
            ClientFilter.Text = "";
            dataGridView1.DataSource = carsBindingSource;
            ShowCarsButton.BackColor = SystemColors.ActiveCaption;
            ShowClientsButton.BackColor = SystemColors.ControlLight;
            ShowEmployeesButton.BackColor = SystemColors.ControlLight;
            SalesButton.BackColor = SystemColors.ControlLight;
        }

        private void CarsRequestButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Cars WHERE Country LIKE N\'%" + textBox1.Text + "%\'", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
                ShowCarsButton.BackColor = SystemColors.ControlLight;
                ShowClientsButton.BackColor = SystemColors.ControlLight;
                ShowEmployeesButton.BackColor = SystemColors.ControlLight;
                SalesButton.BackColor = SystemColors.ControlLight;

                label1.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                CarFilter1.Enabled = true;
                CarFilter2.Enabled = true;
                label2.Enabled = false;
                ClientFilter.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void ClientsRequestButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Clients WHERE Residence LIKE N\'%Харьков%\'", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
                ShowCarsButton.BackColor = SystemColors.ControlLight;
                ShowClientsButton.BackColor = SystemColors.ControlLight;
                ShowEmployeesButton.BackColor = SystemColors.ControlLight;
                SalesButton.BackColor = SystemColors.ControlLight;

                label1.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                CarFilter1.Enabled = false;
                CarFilter2.Enabled = false;
                label2.Enabled = true;
                ClientFilter.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Sales WHERE PaymentType = N\'Безналичный\'", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
                ShowCarsButton.BackColor = SystemColors.ControlLight;
                ShowClientsButton.BackColor = SystemColors.ControlLight;
                ShowEmployeesButton.BackColor = SystemColors.ControlLight;
                SalesButton.BackColor = SystemColors.ControlLight;

                label1.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                CarFilter1.Enabled = false;
                CarFilter2.Enabled = false;
                label2.Enabled = false;
                ClientFilter.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandomRequest form = new RandomRequest();
            form.ShowDialog();
        }
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.Filter = "Text (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Cars", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    sqlconn.Close();
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, true, System.Text.Encoding.Default))
                    {
                        sw.Write("        Список атомобилей:");
                        sw.WriteLine();
                        sw.WriteLine();
                        foreach (DataColumn column in dt.Columns)
                            sw.Write("\t{0,-20}", column.ColumnName);
                        sw.WriteLine();
                        sw.WriteLine();
                        foreach (DataRow row in dt.Rows)
                        {
                            var cells = row.ItemArray;
                            foreach (object cell in cells)
                                sw.Write("\t{0,-20}", cell);
                            sw.WriteLine();
                            sw.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.Filter = "Text (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Clients", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    sqlconn.Close();
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, true, System.Text.Encoding.Default))
                    {
                        sw.Write("        Список клиентов:");
                        sw.WriteLine();
                        sw.WriteLine();
                        foreach (DataColumn column in dt.Columns)
                            sw.Write("\t{0,-20}", column.ColumnName);
                        sw.WriteLine();
                        sw.WriteLine();
                        foreach (DataRow row in dt.Rows)
                        {
                            var cells = row.ItemArray;
                            foreach (object cell in cells)
                                sw.Write("\t{0,-20}", cell);
                            sw.WriteLine();
                            sw.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
