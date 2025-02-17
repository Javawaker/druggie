namespace Druggie
{
    partial class FormAdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPanel));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPageDrugsEdit = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEditDrug = new System.Windows.Forms.Button();
            this.buttonDeleteDrug = new System.Windows.Forms.Button();
            this.buttonAddDrug = new System.Windows.Forms.Button();
            this.dataGridViewDrugsConstructed = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageFindDrugs = new System.Windows.Forms.TabPage();
            this.labelCounter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddDrugToUserDrugs = new System.Windows.Forms.Button();
            this.radioButtonIndication = new System.Windows.Forms.RadioButton();
            this.comboBoxIndication = new System.Windows.Forms.ComboBox();
            this.comboBoxActiveIngredient = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.radioButtonActiveIngredient = new System.Windows.Forms.RadioButton();
            this.radioButtonClass = new System.Windows.Forms.RadioButton();
            this.radioButtonManufacturer = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.buttonFindDrugs = new System.Windows.Forms.Button();
            this.dataGridViewDrugs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageUserDrugs = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonInstruction = new System.Windows.Forms.Button();
            this.buttonDeleteUserDrug = new System.Windows.Forms.Button();
            this.buttonAddQuantity = new System.Windows.Forms.Button();
            this.buttonSubtractQuantity = new System.Windows.Forms.Button();
            this.dataGridViewUserDrugs = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnINN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPageDrugsEdit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugsConstructed)).BeginInit();
            this.tabPageFindDrugs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugs)).BeginInit();
            this.tabPageUserDrugs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageUsers);
            this.tabControl.Controls.Add(this.tabPageDrugsEdit);
            this.tabControl.Controls.Add(this.tabPageFindDrugs);
            this.tabControl.Controls.Add(this.tabPageUserDrugs);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1550, 900);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.BackgroundImage = global::Druggie.Properties.Resources.pattern_2;
            this.tabPageUsers.Controls.Add(this.groupBox4);
            this.tabPageUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 38);
            this.tabPageUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUsers.Size = new System.Drawing.Size(1542, 858);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Редактирование пользователей";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.buttonDeleteUser);
            this.groupBox4.Controls.Add(this.buttonUpdate);
            this.groupBox4.Location = new System.Drawing.Point(496, 568);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(549, 248);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(57, 153);
            this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(435, 55);
            this.buttonDeleteUser.TabIndex = 3;
            this.buttonDeleteUser.Text = "Удалить пользователя";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(57, 56);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(435, 55);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Сохранить и обновить базу";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Mode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.Location = new System.Drawing.Point(45, 0);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1426, 518);
            this.dataGridViewUsers.TabIndex = 1;
            this.dataGridViewUsers.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewUsers_DataError);
            this.dataGridViewUsers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewUsers_RowsAdded);
            // 
            // Username
            // 
            this.Username.HeaderText = "Имя пользователя";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            // 
            // Mode
            // 
            this.Mode.HeaderText = "Режим работы";
            this.Mode.MinimumWidth = 6;
            this.Mode.Name = "Mode";
            // 
            // tabPageDrugsEdit
            // 
            this.tabPageDrugsEdit.BackgroundImage = global::Druggie.Properties.Resources.pattern_2;
            this.tabPageDrugsEdit.Controls.Add(this.groupBox3);
            this.tabPageDrugsEdit.Controls.Add(this.dataGridViewDrugsConstructed);
            this.tabPageDrugsEdit.Location = new System.Drawing.Point(4, 38);
            this.tabPageDrugsEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDrugsEdit.Name = "tabPageDrugsEdit";
            this.tabPageDrugsEdit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDrugsEdit.Size = new System.Drawing.Size(1542, 858);
            this.tabPageDrugsEdit.TabIndex = 1;
            this.tabPageDrugsEdit.Text = "Редактирование препаратов";
            this.tabPageDrugsEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.buttonEditDrug);
            this.groupBox3.Controls.Add(this.buttonDeleteDrug);
            this.groupBox3.Controls.Add(this.buttonAddDrug);
            this.groupBox3.Location = new System.Drawing.Point(496, 568);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(549, 248);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            // 
            // buttonEditDrug
            // 
            this.buttonEditDrug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonEditDrug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonEditDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditDrug.Location = new System.Drawing.Point(57, 104);
            this.buttonEditDrug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditDrug.Name = "buttonEditDrug";
            this.buttonEditDrug.Size = new System.Drawing.Size(435, 55);
            this.buttonEditDrug.TabIndex = 4;
            this.buttonEditDrug.Text = "Редактировать препарат";
            this.buttonEditDrug.UseVisualStyleBackColor = true;
            this.buttonEditDrug.Click += new System.EventHandler(this.buttonEditDrug_Click);
            // 
            // buttonDeleteDrug
            // 
            this.buttonDeleteDrug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteDrug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteDrug.Location = new System.Drawing.Point(57, 163);
            this.buttonDeleteDrug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteDrug.Name = "buttonDeleteDrug";
            this.buttonDeleteDrug.Size = new System.Drawing.Size(435, 55);
            this.buttonDeleteDrug.TabIndex = 6;
            this.buttonDeleteDrug.Text = "Удалить препарат";
            this.buttonDeleteDrug.UseVisualStyleBackColor = true;
            this.buttonDeleteDrug.Click += new System.EventHandler(this.buttonDeleteDrug_Click);
            // 
            // buttonAddDrug
            // 
            this.buttonAddDrug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonAddDrug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonAddDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDrug.Location = new System.Drawing.Point(57, 45);
            this.buttonAddDrug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddDrug.Name = "buttonAddDrug";
            this.buttonAddDrug.Size = new System.Drawing.Size(435, 55);
            this.buttonAddDrug.TabIndex = 5;
            this.buttonAddDrug.Text = "Добавить препарат";
            this.buttonAddDrug.UseVisualStyleBackColor = true;
            this.buttonAddDrug.Click += new System.EventHandler(this.buttonAddDrug_Click);
            // 
            // dataGridViewDrugsConstructed
            // 
            this.dataGridViewDrugsConstructed.AllowUserToAddRows = false;
            this.dataGridViewDrugsConstructed.AllowUserToDeleteRows = false;
            this.dataGridViewDrugsConstructed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrugsConstructed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDrugsConstructed.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugsConstructed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDrugsConstructed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugsConstructed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.manufacturer_name,
            this.manufacturer_country,
            this.inn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDrugsConstructed.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDrugsConstructed.Location = new System.Drawing.Point(45, 0);
            this.dataGridViewDrugsConstructed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDrugsConstructed.MultiSelect = false;
            this.dataGridViewDrugsConstructed.Name = "dataGridViewDrugsConstructed";
            this.dataGridViewDrugsConstructed.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugsConstructed.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDrugsConstructed.RowHeadersWidth = 51;
            this.dataGridViewDrugsConstructed.RowTemplate.Height = 24;
            this.dataGridViewDrugsConstructed.Size = new System.Drawing.Size(1426, 518);
            this.dataGridViewDrugsConstructed.TabIndex = 2;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // manufacturer_name
            // 
            this.manufacturer_name.HeaderText = "Производитель";
            this.manufacturer_name.MinimumWidth = 6;
            this.manufacturer_name.Name = "manufacturer_name";
            this.manufacturer_name.ReadOnly = true;
            // 
            // manufacturer_country
            // 
            this.manufacturer_country.HeaderText = "Страна";
            this.manufacturer_country.MinimumWidth = 6;
            this.manufacturer_country.Name = "manufacturer_country";
            this.manufacturer_country.ReadOnly = true;
            // 
            // inn
            // 
            this.inn.HeaderText = "Международное название";
            this.inn.MinimumWidth = 6;
            this.inn.Name = "inn";
            this.inn.ReadOnly = true;
            // 
            // tabPageFindDrugs
            // 
            this.tabPageFindDrugs.BackgroundImage = global::Druggie.Properties.Resources.pattern_2;
            this.tabPageFindDrugs.Controls.Add(this.labelCounter);
            this.tabPageFindDrugs.Controls.Add(this.groupBox1);
            this.tabPageFindDrugs.Controls.Add(this.dataGridViewDrugs);
            this.tabPageFindDrugs.Location = new System.Drawing.Point(4, 38);
            this.tabPageFindDrugs.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageFindDrugs.Name = "tabPageFindDrugs";
            this.tabPageFindDrugs.Size = new System.Drawing.Size(1542, 858);
            this.tabPageFindDrugs.TabIndex = 2;
            this.tabPageFindDrugs.Text = "Препараты";
            this.tabPageFindDrugs.UseVisualStyleBackColor = true;
            this.tabPageFindDrugs.Click += new System.EventHandler(this.tabPageFindDrugs_Click);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.BackColor = System.Drawing.Color.White;
            this.labelCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounter.Location = new System.Drawing.Point(45, 517);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(100, 34);
            this.labelCounter.TabIndex = 42;
            this.labelCounter.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonAddDrugToUserDrugs);
            this.groupBox1.Controls.Add(this.radioButtonIndication);
            this.groupBox1.Controls.Add(this.comboBoxIndication);
            this.groupBox1.Controls.Add(this.comboBoxActiveIngredient);
            this.groupBox1.Controls.Add(this.comboBoxClass);
            this.groupBox1.Controls.Add(this.comboBoxManufacturer);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.radioButtonActiveIngredient);
            this.groupBox1.Controls.Add(this.radioButtonClass);
            this.groupBox1.Controls.Add(this.radioButtonManufacturer);
            this.groupBox1.Controls.Add(this.radioButtonName);
            this.groupBox1.Controls.Add(this.buttonFindDrugs);
            this.groupBox1.Location = new System.Drawing.Point(199, 568);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1177, 248);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // buttonAddDrugToUserDrugs
            // 
            this.buttonAddDrugToUserDrugs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddDrugToUserDrugs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonAddDrugToUserDrugs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonAddDrugToUserDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDrugToUserDrugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDrugToUserDrugs.Location = new System.Drawing.Point(720, 172);
            this.buttonAddDrugToUserDrugs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDrugToUserDrugs.Name = "buttonAddDrugToUserDrugs";
            this.buttonAddDrugToUserDrugs.Size = new System.Drawing.Size(435, 55);
            this.buttonAddDrugToUserDrugs.TabIndex = 31;
            this.buttonAddDrugToUserDrugs.Text = "Добавить препарат в список";
            this.buttonAddDrugToUserDrugs.UseVisualStyleBackColor = false;
            this.buttonAddDrugToUserDrugs.Click += new System.EventHandler(this.buttonAddDrugToUserDrugs_Click);
            // 
            // radioButtonIndication
            // 
            this.radioButtonIndication.AutoSize = true;
            this.radioButtonIndication.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonIndication.Location = new System.Drawing.Point(361, 146);
            this.radioButtonIndication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonIndication.Name = "radioButtonIndication";
            this.radioButtonIndication.Size = new System.Drawing.Size(156, 33);
            this.radioButtonIndication.TabIndex = 30;
            this.radioButtonIndication.Text = "Показание";
            this.radioButtonIndication.UseVisualStyleBackColor = true;
            // 
            // comboBoxIndication
            // 
            this.comboBoxIndication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxIndication.FormattingEnabled = true;
            this.comboBoxIndication.Location = new System.Drawing.Point(361, 185);
            this.comboBoxIndication.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIndication.Name = "comboBoxIndication";
            this.comboBoxIndication.Size = new System.Drawing.Size(279, 33);
            this.comboBoxIndication.TabIndex = 29;
            // 
            // comboBoxActiveIngredient
            // 
            this.comboBoxActiveIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxActiveIngredient.FormattingEnabled = true;
            this.comboBoxActiveIngredient.Location = new System.Drawing.Point(720, 60);
            this.comboBoxActiveIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxActiveIngredient.Name = "comboBoxActiveIngredient";
            this.comboBoxActiveIngredient.Size = new System.Drawing.Size(435, 33);
            this.comboBoxActiveIngredient.TabIndex = 28;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(361, 60);
            this.comboBoxClass.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(279, 33);
            this.comboBoxClass.TabIndex = 27;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(19, 185);
            this.comboBoxManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(294, 33);
            this.comboBoxManufacturer.TabIndex = 26;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(19, 63);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 30);
            this.textBoxName.TabIndex = 25;
            // 
            // radioButtonActiveIngredient
            // 
            this.radioButtonActiveIngredient.AutoSize = true;
            this.radioButtonActiveIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonActiveIngredient.Location = new System.Drawing.Point(720, 25);
            this.radioButtonActiveIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonActiveIngredient.Name = "radioButtonActiveIngredient";
            this.radioButtonActiveIngredient.Size = new System.Drawing.Size(315, 33);
            this.radioButtonActiveIngredient.TabIndex = 11;
            this.radioButtonActiveIngredient.Text = "Действующее вещество";
            this.radioButtonActiveIngredient.UseVisualStyleBackColor = true;
            // 
            // radioButtonClass
            // 
            this.radioButtonClass.AutoSize = true;
            this.radioButtonClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonClass.Location = new System.Drawing.Point(361, 25);
            this.radioButtonClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonClass.Name = "radioButtonClass";
            this.radioButtonClass.Size = new System.Drawing.Size(113, 33);
            this.radioButtonClass.TabIndex = 10;
            this.radioButtonClass.Text = "Группа";
            this.radioButtonClass.UseVisualStyleBackColor = true;
            // 
            // radioButtonManufacturer
            // 
            this.radioButtonManufacturer.AutoSize = true;
            this.radioButtonManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonManufacturer.Location = new System.Drawing.Point(19, 146);
            this.radioButtonManufacturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonManufacturer.Name = "radioButtonManufacturer";
            this.radioButtonManufacturer.Size = new System.Drawing.Size(211, 33);
            this.radioButtonManufacturer.TabIndex = 9;
            this.radioButtonManufacturer.Text = "Производитель";
            this.radioButtonManufacturer.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Checked = true;
            this.radioButtonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonName.Location = new System.Drawing.Point(19, 25);
            this.radioButtonName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(143, 33);
            this.radioButtonName.TabIndex = 8;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Название";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // buttonFindDrugs
            // 
            this.buttonFindDrugs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFindDrugs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonFindDrugs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonFindDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindDrugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindDrugs.Location = new System.Drawing.Point(720, 109);
            this.buttonFindDrugs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindDrugs.Name = "buttonFindDrugs";
            this.buttonFindDrugs.Size = new System.Drawing.Size(435, 55);
            this.buttonFindDrugs.TabIndex = 0;
            this.buttonFindDrugs.Text = "Найти препарат";
            this.buttonFindDrugs.UseVisualStyleBackColor = false;
            this.buttonFindDrugs.Click += new System.EventHandler(this.buttonFindDrugs_Click);
            // 
            // dataGridViewDrugs
            // 
            this.dataGridViewDrugs.AllowUserToAddRows = false;
            this.dataGridViewDrugs.AllowUserToDeleteRows = false;
            this.dataGridViewDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrugs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDrugs.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDrugs.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDrugs.Location = new System.Drawing.Point(45, 0);
            this.dataGridViewDrugs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDrugs.MultiSelect = false;
            this.dataGridViewDrugs.Name = "dataGridViewDrugs";
            this.dataGridViewDrugs.ReadOnly = true;
            this.dataGridViewDrugs.RowHeadersWidth = 51;
            this.dataGridViewDrugs.RowTemplate.Height = 24;
            this.dataGridViewDrugs.Size = new System.Drawing.Size(1426, 518);
            this.dataGridViewDrugs.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Международное название";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabPageUserDrugs
            // 
            this.tabPageUserDrugs.BackgroundImage = global::Druggie.Properties.Resources.pattern_2;
            this.tabPageUserDrugs.Controls.Add(this.groupBox2);
            this.tabPageUserDrugs.Controls.Add(this.dataGridViewUserDrugs);
            this.tabPageUserDrugs.Location = new System.Drawing.Point(4, 38);
            this.tabPageUserDrugs.Name = "tabPageUserDrugs";
            this.tabPageUserDrugs.Size = new System.Drawing.Size(1542, 858);
            this.tabPageUserDrugs.TabIndex = 3;
            this.tabPageUserDrugs.Text = "Ваш список препаратов";
            this.tabPageUserDrugs.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonInstruction);
            this.groupBox2.Controls.Add(this.buttonDeleteUserDrug);
            this.groupBox2.Controls.Add(this.buttonAddQuantity);
            this.groupBox2.Controls.Add(this.buttonSubtractQuantity);
            this.groupBox2.Location = new System.Drawing.Point(405, 568);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(697, 248);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // buttonInstruction
            // 
            this.buttonInstruction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonInstruction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstruction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonInstruction.Location = new System.Drawing.Point(205, 56);
            this.buttonInstruction.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInstruction.Name = "buttonInstruction";
            this.buttonInstruction.Size = new System.Drawing.Size(435, 55);
            this.buttonInstruction.TabIndex = 5;
            this.buttonInstruction.Text = "Прочитать инструкцию";
            this.buttonInstruction.UseVisualStyleBackColor = true;
            this.buttonInstruction.Click += new System.EventHandler(this.buttonInstruction_Click);
            // 
            // buttonDeleteUserDrug
            // 
            this.buttonDeleteUserDrug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteUserDrug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteUserDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUserDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteUserDrug.Location = new System.Drawing.Point(57, 157);
            this.buttonDeleteUserDrug.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteUserDrug.Name = "buttonDeleteUserDrug";
            this.buttonDeleteUserDrug.Size = new System.Drawing.Size(583, 55);
            this.buttonDeleteUserDrug.TabIndex = 8;
            this.buttonDeleteUserDrug.Text = "Убрать позицию";
            this.buttonDeleteUserDrug.UseVisualStyleBackColor = true;
            this.buttonDeleteUserDrug.Click += new System.EventHandler(this.buttonDeleteUserDrug_Click);
            // 
            // buttonAddQuantity
            // 
            this.buttonAddQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonAddQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddQuantity.Location = new System.Drawing.Point(131, 56);
            this.buttonAddQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddQuantity.Name = "buttonAddQuantity";
            this.buttonAddQuantity.Size = new System.Drawing.Size(55, 55);
            this.buttonAddQuantity.TabIndex = 6;
            this.buttonAddQuantity.Text = "+";
            this.buttonAddQuantity.UseVisualStyleBackColor = true;
            this.buttonAddQuantity.Click += new System.EventHandler(this.buttonAddQuantity_Click);
            // 
            // buttonSubtractQuantity
            // 
            this.buttonSubtractQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonSubtractQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonSubtractQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtractQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubtractQuantity.Location = new System.Drawing.Point(57, 56);
            this.buttonSubtractQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubtractQuantity.Name = "buttonSubtractQuantity";
            this.buttonSubtractQuantity.Size = new System.Drawing.Size(55, 55);
            this.buttonSubtractQuantity.TabIndex = 7;
            this.buttonSubtractQuantity.Text = "-";
            this.buttonSubtractQuantity.UseVisualStyleBackColor = true;
            this.buttonSubtractQuantity.Click += new System.EventHandler(this.buttonSubtractQuantity_Click);
            // 
            // dataGridViewUserDrugs
            // 
            this.dataGridViewUserDrugs.AllowUserToAddRows = false;
            this.dataGridViewUserDrugs.AllowUserToDeleteRows = false;
            this.dataGridViewUserDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserDrugs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUserDrugs.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewUserDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnManufacturer,
            this.ColumnCountry,
            this.ColumnINN,
            this.ColumnQuantity});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUserDrugs.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewUserDrugs.Location = new System.Drawing.Point(45, 0);
            this.dataGridViewUserDrugs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUserDrugs.MultiSelect = false;
            this.dataGridViewUserDrugs.Name = "dataGridViewUserDrugs";
            this.dataGridViewUserDrugs.ReadOnly = true;
            this.dataGridViewUserDrugs.RowHeadersWidth = 51;
            this.dataGridViewUserDrugs.RowTemplate.Height = 24;
            this.dataGridViewUserDrugs.Size = new System.Drawing.Size(1426, 518);
            this.dataGridViewUserDrugs.TabIndex = 4;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnManufacturer
            // 
            this.ColumnManufacturer.HeaderText = "Производитель";
            this.ColumnManufacturer.MinimumWidth = 6;
            this.ColumnManufacturer.Name = "ColumnManufacturer";
            this.ColumnManufacturer.ReadOnly = true;
            // 
            // ColumnCountry
            // 
            this.ColumnCountry.HeaderText = "Страна";
            this.ColumnCountry.MinimumWidth = 6;
            this.ColumnCountry.Name = "ColumnCountry";
            this.ColumnCountry.ReadOnly = true;
            // 
            // ColumnINN
            // 
            this.ColumnINN.HeaderText = "Международное название";
            this.ColumnINN.MinimumWidth = 6;
            this.ColumnINN.Name = "ColumnINN";
            this.ColumnINN.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.HeaderText = "Количество";
            this.ColumnQuantity.MinimumWidth = 6;
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 853);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Druggie";
            this.Load += new System.EventHandler(this.FormAdminPanel_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPageDrugsEdit.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugsConstructed)).EndInit();
            this.tabPageFindDrugs.ResumeLayout(false);
            this.tabPageFindDrugs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugs)).EndInit();
            this.tabPageUserDrugs.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDrugs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TabPage tabPageDrugsEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mode;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.DataGridView dataGridViewDrugsConstructed;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.Button buttonEditDrug;
        private System.Windows.Forms.Button buttonDeleteDrug;
        private System.Windows.Forms.Button buttonAddDrug;
        private System.Windows.Forms.TabPage tabPageFindDrugs;
        private System.Windows.Forms.DataGridView dataGridViewDrugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFindDrugs;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonActiveIngredient;
        private System.Windows.Forms.RadioButton radioButtonClass;
        private System.Windows.Forms.RadioButton radioButtonManufacturer;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxIndication;
        private System.Windows.Forms.ComboBox comboBoxActiveIngredient;
        private System.Windows.Forms.RadioButton radioButtonIndication;
        private System.Windows.Forms.TabPage tabPageUserDrugs;
        private System.Windows.Forms.DataGridView dataGridViewUserDrugs;
        private System.Windows.Forms.Button buttonAddDrugToUserDrugs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnINN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.Button buttonInstruction;
        private System.Windows.Forms.Button buttonAddQuantity;
        private System.Windows.Forms.Button buttonSubtractQuantity;
        private System.Windows.Forms.Button buttonDeleteUserDrug;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}