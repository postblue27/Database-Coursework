namespace CurseAche_db
{
    partial class Form1
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carMarket_dbDataSet = new CurseAche_db.CarMarket_dbDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginePowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new CurseAche_db.CarMarket_dbDataSetTableAdapters.CarsTableAdapter();
            this.ShowCarsButton = new System.Windows.Forms.Button();
            this.ShowClientsButton = new System.Windows.Forms.Button();
            this.ShowEmployeesButton = new System.Windows.Forms.Button();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new CurseAche_db.CarMarket_dbDataSetTableAdapters.ClientsTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new CurseAche_db.CarMarket_dbDataSetTableAdapters.EmployeesTableAdapter();
            this.salesTableAdapter = new CurseAche_db.CarMarket_dbDataSetTableAdapters.SalesTableAdapter();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AcceptFiltersButton = new System.Windows.Forms.Button();
            this.DeleteFiltersButton = new System.Windows.Forms.Button();
            this.CarFilter2 = new System.Windows.Forms.TextBox();
            this.CarFilter1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ClientsRequestButton = new System.Windows.Forms.Button();
            this.CarsRequestButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.carsSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carMarket_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsSalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.carMarket_dbDataSet;
            this.bindingSource1.Position = 0;
            // 
            // carMarket_dbDataSet
            // 
            this.carMarket_dbDataSet.DataSetName = "CarMarket_dbDataSet";
            this.carMarket_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.vINCodeDataGridViewTextBoxColumn,
            this.engineModelDataGridViewTextBoxColumn,
            this.enginePowerDataGridViewTextBoxColumn,
            this.engineCapacityDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Mark";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            // 
            // vINCodeDataGridViewTextBoxColumn
            // 
            this.vINCodeDataGridViewTextBoxColumn.DataPropertyName = "VINCode";
            this.vINCodeDataGridViewTextBoxColumn.HeaderText = "VINCode";
            this.vINCodeDataGridViewTextBoxColumn.Name = "vINCodeDataGridViewTextBoxColumn";
            // 
            // engineModelDataGridViewTextBoxColumn
            // 
            this.engineModelDataGridViewTextBoxColumn.DataPropertyName = "EngineModel";
            this.engineModelDataGridViewTextBoxColumn.HeaderText = "EngineModel";
            this.engineModelDataGridViewTextBoxColumn.Name = "engineModelDataGridViewTextBoxColumn";
            // 
            // enginePowerDataGridViewTextBoxColumn
            // 
            this.enginePowerDataGridViewTextBoxColumn.DataPropertyName = "EnginePower";
            this.enginePowerDataGridViewTextBoxColumn.HeaderText = "EnginePower";
            this.enginePowerDataGridViewTextBoxColumn.Name = "enginePowerDataGridViewTextBoxColumn";
            // 
            // engineCapacityDataGridViewTextBoxColumn
            // 
            this.engineCapacityDataGridViewTextBoxColumn.DataPropertyName = "EngineCapacity";
            this.engineCapacityDataGridViewTextBoxColumn.HeaderText = "EngineCapacity";
            this.engineCapacityDataGridViewTextBoxColumn.Name = "engineCapacityDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataSource = this.carsBindingSource1;
            // 
            // carsBindingSource1
            // 
            this.carsBindingSource1.DataMember = "Cars";
            this.carsBindingSource1.DataSource = this.bindingSource1;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.bindingSource1;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // ShowCarsButton
            // 
            this.ShowCarsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ShowCarsButton.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCarsButton.Location = new System.Drawing.Point(12, 26);
            this.ShowCarsButton.Name = "ShowCarsButton";
            this.ShowCarsButton.Size = new System.Drawing.Size(250, 63);
            this.ShowCarsButton.TabIndex = 1;
            this.ShowCarsButton.Text = "Автомобили";
            this.ShowCarsButton.UseVisualStyleBackColor = false;
            this.ShowCarsButton.Click += new System.EventHandler(this.ShowCarsButton_Click);
            // 
            // ShowClientsButton
            // 
            this.ShowClientsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ShowClientsButton.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowClientsButton.Location = new System.Drawing.Point(310, 26);
            this.ShowClientsButton.Name = "ShowClientsButton";
            this.ShowClientsButton.Size = new System.Drawing.Size(250, 63);
            this.ShowClientsButton.TabIndex = 2;
            this.ShowClientsButton.Text = "Клиенты";
            this.ShowClientsButton.UseVisualStyleBackColor = false;
            this.ShowClientsButton.Click += new System.EventHandler(this.ShowClientsButton_Click);
            // 
            // ShowEmployeesButton
            // 
            this.ShowEmployeesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ShowEmployeesButton.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEmployeesButton.Location = new System.Drawing.Point(612, 26);
            this.ShowEmployeesButton.Name = "ShowEmployeesButton";
            this.ShowEmployeesButton.Size = new System.Drawing.Size(250, 63);
            this.ShowEmployeesButton.TabIndex = 3;
            this.ShowEmployeesButton.Text = "Сотрудники";
            this.ShowEmployeesButton.UseVisualStyleBackColor = false;
            this.ShowEmployeesButton.Click += new System.EventHandler(this.ShowEmployeesButton_Click);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.bindingSource1;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.bindingSource1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(1182, 26);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(283, 33);
            this.SearchTextBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(1182, 65);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(283, 42);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 550);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(325, 48);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(426, 550);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(325, 48);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(831, 550);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(325, 48);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SalesButton.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.Location = new System.Drawing.Point(906, 26);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(250, 63);
            this.SalesButton.TabIndex = 9;
            this.SalesButton.Text = "Продажи";
            this.SalesButton.UseVisualStyleBackColor = false;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            this.salesBindingSource1.DataSource = this.bindingSource1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AcceptFiltersButton);
            this.groupBox1.Controls.Add(this.DeleteFiltersButton);
            this.groupBox1.Controls.Add(this.CarFilter2);
            this.groupBox1.Controls.Add(this.CarFilter1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ClientFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(1182, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AcceptFiltersButton
            // 
            this.AcceptFiltersButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AcceptFiltersButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptFiltersButton.Location = new System.Drawing.Point(6, 121);
            this.AcceptFiltersButton.Name = "AcceptFiltersButton";
            this.AcceptFiltersButton.Size = new System.Drawing.Size(129, 32);
            this.AcceptFiltersButton.TabIndex = 21;
            this.AcceptFiltersButton.Text = "Применить";
            this.AcceptFiltersButton.UseVisualStyleBackColor = false;
            this.AcceptFiltersButton.Click += new System.EventHandler(this.AcceptFiltersButton_Click);
            // 
            // DeleteFiltersButton
            // 
            this.DeleteFiltersButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteFiltersButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFiltersButton.Location = new System.Drawing.Point(147, 121);
            this.DeleteFiltersButton.Name = "DeleteFiltersButton";
            this.DeleteFiltersButton.Size = new System.Drawing.Size(129, 32);
            this.DeleteFiltersButton.TabIndex = 16;
            this.DeleteFiltersButton.Text = "Сбросить";
            this.DeleteFiltersButton.UseVisualStyleBackColor = false;
            this.DeleteFiltersButton.Click += new System.EventHandler(this.DeleteFiltersButton_Click);
            // 
            // CarFilter2
            // 
            this.CarFilter2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarFilter2.Location = new System.Drawing.Point(174, 42);
            this.CarFilter2.Name = "CarFilter2";
            this.CarFilter2.Size = new System.Drawing.Size(102, 25);
            this.CarFilter2.TabIndex = 16;
            // 
            // CarFilter1
            // 
            this.CarFilter1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarFilter1.Location = new System.Drawing.Point(40, 42);
            this.CarFilter1.Name = "CarFilter1";
            this.CarFilter1.Size = new System.Drawing.Size(102, 25);
            this.CarFilter1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "До:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "От:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "По полу клиентов:";
            // 
            // ClientFilter
            // 
            this.ClientFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientFilter.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientFilter.FormattingEnabled = true;
            this.ClientFilter.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.ClientFilter.Location = new System.Drawing.Point(6, 90);
            this.ClientFilter.Name = "ClientFilter";
            this.ClientFilter.Size = new System.Drawing.Size(270, 25);
            this.ClientFilter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "По цене автомобиля:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.ClientsRequestButton);
            this.groupBox2.Controls.Add(this.CarsRequestButton);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1182, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 214);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запросы";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(21, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(242, 32);
            this.button4.TabIndex = 16;
            this.button4.Text = "Продажи безналичным расчетом";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ClientsRequestButton
            // 
            this.ClientsRequestButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientsRequestButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsRequestButton.Location = new System.Drawing.Point(21, 98);
            this.ClientsRequestButton.Name = "ClientsRequestButton";
            this.ClientsRequestButton.Size = new System.Drawing.Size(242, 32);
            this.ClientsRequestButton.TabIndex = 15;
            this.ClientsRequestButton.Text = "Клиенты из Харькова";
            this.ClientsRequestButton.UseVisualStyleBackColor = false;
            this.ClientsRequestButton.Click += new System.EventHandler(this.ClientsRequestButton_Click);
            // 
            // CarsRequestButton
            // 
            this.CarsRequestButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CarsRequestButton.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsRequestButton.Location = new System.Drawing.Point(21, 60);
            this.CarsRequestButton.Name = "CarsRequestButton";
            this.CarsRequestButton.Size = new System.Drawing.Size(242, 32);
            this.CarsRequestButton.TabIndex = 14;
            this.CarsRequestButton.Text = "Машины из страны";
            this.CarsRequestButton.UseVisualStyleBackColor = false;
            this.CarsRequestButton.Click += new System.EventHandler(this.CarsRequestButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "Произвольный запрос";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1182, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 103);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отчеты";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(15, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 32);
            this.button3.TabIndex = 18;
            this.button3.Text = "Клиенты .txt";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Автомобили .txt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carsSalesBindingSource
            // 
            this.carsSalesBindingSource.DataMember = "Cars_Sales";
            this.carsSalesBindingSource.DataSource = this.carsBindingSource;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 27);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Germany";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 615);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ShowEmployeesButton);
            this.Controls.Add(this.ShowClientsButton);
            this.Controls.Add(this.ShowCarsButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carMarket_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsSalesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private CarMarket_dbDataSet carMarket_dbDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarMarket_dbDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.Button ShowCarsButton;
        private System.Windows.Forms.Button ShowClientsButton;
        private System.Windows.Forms.Button ShowEmployeesButton;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private CarMarket_dbDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private CarMarket_dbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private CarMarket_dbDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource carsBindingSource1;
        private System.Windows.Forms.BindingSource carsSalesBindingSource;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginePowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CarFilter2;
        private System.Windows.Forms.TextBox CarFilter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CarsRequestButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ClientFilter;
        private System.Windows.Forms.Button AcceptFiltersButton;
        private System.Windows.Forms.Button DeleteFiltersButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ClientsRequestButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

