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
    public partial class EditClient : Form
    {
        public EditClient()
        {
            InitializeComponent();
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carMarket_dbDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.carMarket_dbDataSet.Clients);
            try
            {
                if (ClientBuffer.IsChanging)
                {
                    IdTextBox.Text = Convert.ToString(ClientBuffer.id);
                    NameTextBox.Text = ClientBuffer.name;
                    SexComboBox.Text = ClientBuffer.sex;
                    PhoneNumberTextBox.Text = ClientBuffer.phoneNumber;
                    PassportTextBox.Text = ClientBuffer.passport;
                    BirthDateTimePicker.Value = Convert.ToDateTime(ClientBuffer.birthDate);
                    ResidenceTextBox.Text = ClientBuffer.residence;
                    EmailTextBox.Text = ClientBuffer.email;
                }
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
                    clientsTableAdapter.UpdateQuery(Convert.ToInt32(IdTextBox.Text),
                                        NameTextBox.Text,
                                        SexComboBox.Text,
                                        PhoneNumberTextBox.Text,
                                        PassportTextBox.Text,
                                        Convert.ToString(BirthDateTimePicker.Value),
                                        ResidenceTextBox.Text,
                                        EmailTextBox.Text);
                }
                else
                {
                    clientsTableAdapter.Insert(Convert.ToInt32(IdTextBox.Text),
                                        NameTextBox.Text,
                                        SexComboBox.Text,
                                        PhoneNumberTextBox.Text,
                                        PassportTextBox.Text,
                                        BirthDateTimePicker.Value,
                                        ResidenceTextBox.Text,
                                        EmailTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
