namespace CurseAche_db
{
    partial class EditCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.MarkTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.VINCodeTextBox = new System.Windows.Forms.TextBox();
            this.EnginePowerTextBox = new System.Windows.Forms.TextBox();
            this.EngineCapacityTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ReleaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carMarket_dbDataSet = new CurseAche_db.CarMarket_dbDataSet();
            this.carsTableAdapter = new CurseAche_db.CarMarket_dbDataSetTableAdapters.CarsTableAdapter();
            this.EngineModelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carMarket_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id автомобиля:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Марка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Модель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата выпуска:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "VIN код:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Мощность двигателя(лс):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Объем двигателя(см3):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Вес автомобиля:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Страна-производитель:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Цена:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(226, 6);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(199, 29);
            this.IdTextBox.TabIndex = 11;
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkTextBox.Location = new System.Drawing.Point(226, 41);
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.Size = new System.Drawing.Size(199, 29);
            this.MarkTextBox.TabIndex = 12;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(226, 76);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(199, 29);
            this.ModelTextBox.TabIndex = 13;
            // 
            // VINCodeTextBox
            // 
            this.VINCodeTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VINCodeTextBox.Location = new System.Drawing.Point(226, 146);
            this.VINCodeTextBox.Name = "VINCodeTextBox";
            this.VINCodeTextBox.Size = new System.Drawing.Size(199, 29);
            this.VINCodeTextBox.TabIndex = 15;
            // 
            // EnginePowerTextBox
            // 
            this.EnginePowerTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnginePowerTextBox.Location = new System.Drawing.Point(226, 216);
            this.EnginePowerTextBox.Name = "EnginePowerTextBox";
            this.EnginePowerTextBox.Size = new System.Drawing.Size(199, 29);
            this.EnginePowerTextBox.TabIndex = 17;
            // 
            // EngineCapacityTextBox
            // 
            this.EngineCapacityTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineCapacityTextBox.Location = new System.Drawing.Point(226, 251);
            this.EngineCapacityTextBox.Name = "EngineCapacityTextBox";
            this.EngineCapacityTextBox.Size = new System.Drawing.Size(199, 29);
            this.EngineCapacityTextBox.TabIndex = 18;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(226, 286);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(199, 29);
            this.WeightTextBox.TabIndex = 19;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryTextBox.Location = new System.Drawing.Point(226, 321);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(199, 29);
            this.CountryTextBox.TabIndex = 20;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.Location = new System.Drawing.Point(226, 356);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(199, 29);
            this.PriceTextBox.TabIndex = 21;
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(34, 395);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(167, 46);
            this.OKButton.TabIndex = 22;
            this.OKButton.Text = "Принять";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(226, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 46);
            this.button2.TabIndex = 23;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReleaseDateTimePicker
            // 
            this.ReleaseDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseDateTimePicker.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseDateTimePicker.Location = new System.Drawing.Point(226, 111);
            this.ReleaseDateTimePicker.Name = "ReleaseDateTimePicker";
            this.ReleaseDateTimePicker.Size = new System.Drawing.Size(199, 29);
            this.ReleaseDateTimePicker.TabIndex = 24;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Cars";
            this.bindingSource1.DataSource = this.carMarket_dbDataSet;
            // 
            // carMarket_dbDataSet
            // 
            this.carMarket_dbDataSet.DataSetName = "CarMarket_dbDataSet";
            this.carMarket_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // EngineModelTextBox
            // 
            this.EngineModelTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineModelTextBox.Location = new System.Drawing.Point(226, 181);
            this.EngineModelTextBox.Name = "EngineModelTextBox";
            this.EngineModelTextBox.Size = new System.Drawing.Size(199, 29);
            this.EngineModelTextBox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Модель двигателя:";
            // 
            // EditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 468);
            this.Controls.Add(this.EngineModelTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReleaseDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.EngineCapacityTextBox);
            this.Controls.Add(this.EnginePowerTextBox);
            this.Controls.Add(this.VINCodeTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.MarkTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCar";
            this.Text = "Car Edit";
            this.Load += new System.EventHandler(this.EditCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carMarket_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox MarkTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox VINCodeTextBox;
        private System.Windows.Forms.TextBox EnginePowerTextBox;
        private System.Windows.Forms.TextBox EngineCapacityTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker ReleaseDateTimePicker;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CarMarket_dbDataSet carMarket_dbDataSet;
        private CarMarket_dbDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.TextBox EngineModelTextBox;
        private System.Windows.Forms.Label label6;
    }
}