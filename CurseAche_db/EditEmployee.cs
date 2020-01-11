using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseAche_db
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CarBuffer.IsChanging)
                {
                    employeesTableAdapter.UpdateQuery(Convert.ToInt32(IdTextBox.Text),
                                        NameTextBox.Text,
                                        PostComboBox.Text,
                                        PhoneNumberTextBox.Text,
                                        PassportTextBox.Text,
                                        Convert.ToString(BirthDateTimePicker.Value),
                                        ResidenceTextBox.Text,
                                        EmailTextBox.Text,
                                        Convert.ToString(StartWorkingDateTimePicker.Value));
                }
                else
                {
                    employeesTableAdapter.Insert(Convert.ToInt32(IdTextBox.Text),
                                        NameTextBox.Text,
                                        PostComboBox.Text,
                                        PhoneNumberTextBox.Text,
                                        PassportTextBox.Text,
                                        BirthDateTimePicker.Value,
                                        ResidenceTextBox.Text,
                                        EmailTextBox.Text,
                                        StartWorkingDateTimePicker.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            Close();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carMarket_dbDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.carMarket_dbDataSet.Employees);
            try
            {
                if (EmployeeBuffer.IsChanging)
                {
                    IdTextBox.Text = Convert.ToString(EmployeeBuffer.id);
                    NameTextBox.Text = EmployeeBuffer.name;
                    PostComboBox.Text = EmployeeBuffer.post;
                    PhoneNumberTextBox.Text = EmployeeBuffer.phoneNumber;
                    PassportTextBox.Text = EmployeeBuffer.passport;
                    BirthDateTimePicker.Value = Convert.ToDateTime(EmployeeBuffer.birthDate);
                    ResidenceTextBox.Text = EmployeeBuffer.residence;
                    EmailTextBox.Text = EmployeeBuffer.email;
                    StartWorkingDateTimePicker.Value = Convert.ToDateTime(EmployeeBuffer.StartWorkingDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
