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
    public partial class EditCar : Form
    {
        private readonly int id;
        readonly bool edit;
        public EditCar()
        {
            InitializeComponent();
        }

        private void EditCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carMarket_dbDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carMarket_dbDataSet.Cars);
            try
            {
                if (CarBuffer.IsChanging)
                {
                    IdTextBox.Text = Convert.ToString(CarBuffer.id);
                    MarkTextBox.Text = CarBuffer.mark;
                    ModelTextBox.Text = CarBuffer.model;
                    ReleaseDateTimePicker.Value = CarBuffer.releaseDate;
                    VINCodeTextBox.Text = CarBuffer.vinCode;
                    EngineModelTextBox.Text = CarBuffer.engineModel;
                    EnginePowerTextBox.Text = CarBuffer.enginePower;
                    EngineCapacityTextBox.Text = CarBuffer.engineCapacity;
                    WeightTextBox.Text = CarBuffer.weight;
                    CountryTextBox.Text = CarBuffer.country;
                    PriceTextBox.Text = Convert.ToString(CarBuffer.price);
                }
            }
            catch(Exception ex)
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
                    carsTableAdapter.UpdateQuery(Convert.ToInt32(IdTextBox.Text),
                                        MarkTextBox.Text,
                                        ModelTextBox.Text,
                                        Convert.ToString(ReleaseDateTimePicker.Value),
                                        VINCodeTextBox.Text,
                                        EngineModelTextBox.Text,
                                        EnginePowerTextBox.Text,
                                        EngineCapacityTextBox.Text,
                                        WeightTextBox.Text,
                                        CountryTextBox.Text,
                                        Convert.ToDecimal(PriceTextBox.Text));
                }
                else
                {
                    carsTableAdapter.Insert(Convert.ToInt32(IdTextBox.Text),
                                        MarkTextBox.Text,
                                        ModelTextBox.Text,
                                        ReleaseDateTimePicker.Value,
                                        VINCodeTextBox.Text,
                                        EngineModelTextBox.Text,
                                        EnginePowerTextBox.Text,
                                        EngineCapacityTextBox.Text,
                                        WeightTextBox.Text,
                                        CountryTextBox.Text,
                                        Convert.ToDecimal(PriceTextBox.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
