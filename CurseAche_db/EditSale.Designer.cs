namespace CurseAche_db
{
    partial class EditSale
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
            this.label6 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DateOfSalePicker = new System.Windows.Forms.DateTimePicker();
            this.PaymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carMarket_dbDataSet = new CurseAche_db.CarMarket_dbDataSet();
            this.salesTableAdapter = new CurseAche_db.CarMarket_dbDataSetTableAdapters.SalesTableAdapter();
            this.CarIdBox = new System.Windows.Forms.ComboBox();
            this.EmployeeIdBox = new System.Windows.Forms.ComboBox();
            this.ClientIdBox = new System.Windows.Forms.ComboBox();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new CurseAche_db.CarMarket_dbDataSetTableAdapters.CarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carMarket_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id продажи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Id купленного автомобиля:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Id клиента-покупателя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Id сотрудника-продавца:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Дата продажи:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Тип оплаты:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(238, 6);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(209, 29);
            this.IdTextBox.TabIndex = 26;
            // 
            // DateOfSalePicker
            // 
            this.DateOfSalePicker.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfSalePicker.Location = new System.Drawing.Point(238, 146);
            this.DateOfSalePicker.Name = "DateOfSalePicker";
            this.DateOfSalePicker.Size = new System.Drawing.Size(209, 29);
            this.DateOfSalePicker.TabIndex = 37;
            // 
            // PaymentTypeComboBox
            // 
            this.PaymentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentTypeComboBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeComboBox.FormattingEnabled = true;
            this.PaymentTypeComboBox.Items.AddRange(new object[] {
            "Наличные",
            "Безналичный"});
            this.PaymentTypeComboBox.Location = new System.Drawing.Point(238, 181);
            this.PaymentTypeComboBox.Name = "PaymentTypeComboBox";
            this.PaymentTypeComboBox.Size = new System.Drawing.Size(209, 29);
            this.PaymentTypeComboBox.TabIndex = 39;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(240, 231);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(167, 38);
            this.Cancel_Button.TabIndex = 41;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(45, 231);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(167, 38);
            this.OKButton.TabIndex = 40;
            this.OKButton.Text = "Принять";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Sales";
            this.bindingSource1.DataSource = this.carMarket_dbDataSet;
            // 
            // carMarket_dbDataSet
            // 
            this.carMarket_dbDataSet.DataSetName = "CarMarket_dbDataSet";
            this.carMarket_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // CarIdBox
            // 
            this.CarIdBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarIdBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarIdBox.FormattingEnabled = true;
            this.CarIdBox.Location = new System.Drawing.Point(238, 41);
            this.CarIdBox.Name = "CarIdBox";
            this.CarIdBox.Size = new System.Drawing.Size(209, 29);
            this.CarIdBox.TabIndex = 2;
            // 
            // EmployeeIdBox
            // 
            this.EmployeeIdBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeeIdBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIdBox.FormattingEnabled = true;
            this.EmployeeIdBox.Location = new System.Drawing.Point(238, 111);
            this.EmployeeIdBox.Name = "EmployeeIdBox";
            this.EmployeeIdBox.Size = new System.Drawing.Size(209, 29);
            this.EmployeeIdBox.TabIndex = 43;
            // 
            // ClientIdBox
            // 
            this.ClientIdBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientIdBox.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIdBox.FormattingEnabled = true;
            this.ClientIdBox.Location = new System.Drawing.Point(238, 76);
            this.ClientIdBox.Name = "ClientIdBox";
            this.ClientIdBox.Size = new System.Drawing.Size(209, 29);
            this.ClientIdBox.TabIndex = 44;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carMarket_dbDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // EditSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 294);
            this.Controls.Add(this.ClientIdBox);
            this.Controls.Add(this.EmployeeIdBox);
            this.Controls.Add(this.CarIdBox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.PaymentTypeComboBox);
            this.Controls.Add(this.DateOfSalePicker);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditSale";
            this.Text = "AddSale";
            this.Load += new System.EventHandler(this.EditSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carMarket_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.DateTimePicker DateOfSalePicker;
        private System.Windows.Forms.ComboBox PaymentTypeComboBox;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CarMarket_dbDataSet carMarket_dbDataSet;
        private CarMarket_dbDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.ComboBox CarIdBox;
        private System.Windows.Forms.ComboBox EmployeeIdBox;
        private System.Windows.Forms.ComboBox ClientIdBox;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarMarket_dbDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
    }
}