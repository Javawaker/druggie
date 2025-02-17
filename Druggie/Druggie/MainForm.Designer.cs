using System;
using System.Windows.Forms;

namespace Druggie
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabPageDrugsEdit = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAddDrug = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewDrugsConstructed = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageFindDrugs = new System.Windows.Forms.TabPage();
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
            this.dataGridViewUserDrugs = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnINN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInstruction = new System.Windows.Forms.Button();
            this.buttonAddQuantity = new System.Windows.Forms.Button();
            this.buttonSubtractQuantity = new System.Windows.Forms.Button();
            this.buttonDeleteUserDrug = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPageDrugsEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugsConstructed)).BeginInit();
            this.tabPageFindDrugs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugs)).BeginInit();
            this.tabPageUserDrugs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageUsers);
            this.tabControl.Controls.Add(this.tabPageDrugsEdit);
            this.tabControl.Controls.Add(this.tabPageFindDrugs);
            this.tabControl.Controls.Add(this.tabPageUserDrugs);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1225, 716);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.buttonDeleteUser);
            this.tabPageUsers.Controls.Add(this.buttonAddUser);
            this.tabPageUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageUsers.Controls.Add(this.buttonUpdate);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 25);
            this.tabPageUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUsers.Size = new System.Drawing.Size(1217, 687);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Редактирование пользователей";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            this.tabPageUsers.Click += new System.EventHandler(this.tabPageUsers_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(543, 162);
            this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(301, 58);
            this.buttonDeleteUser.TabIndex = 3;
            this.buttonDeleteUser.Text = "Удалить пользователя";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddUser.Location = new System.Drawing.Point(5, 226);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(301, 58);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Добавить пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Mode});
            this.dataGridViewUsers.Location = new System.Drawing.Point(5, 6);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(501, 150);
            this.dataGridViewUsers.TabIndex = 1;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            this.dataGridViewUsers.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewUsers_DataError);
            this.dataGridViewUsers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewUsers_RowsAdded);
            // 
            // Username
            // 
            this.Username.HeaderText = "Имя пользователя";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Mode
            // 
            this.Mode.HeaderText = "Режим работы";
            this.Mode.MinimumWidth = 6;
            this.Mode.Name = "Mode";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(5, 162);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(456, 58);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Сохранить и обновить базу";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tabPageDrugsEdit
            // 
            this.tabPageDrugsEdit.Controls.Add(this.button3);
            this.tabPageDrugsEdit.Controls.Add(this.buttonAddDrug);
            this.tabPageDrugsEdit.Controls.Add(this.button1);
            this.tabPageDrugsEdit.Controls.Add(this.dataGridViewDrugsConstructed);
            this.tabPageDrugsEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageDrugsEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDrugsEdit.Name = "tabPageDrugsEdit";
            this.tabPageDrugsEdit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDrugsEdit.Size = new System.Drawing.Size(1217, 687);
            this.tabPageDrugsEdit.TabIndex = 1;
            this.tabPageDrugsEdit.Text = "Редактирование препаратов";
            this.tabPageDrugsEdit.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(436, 337);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(391, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "Удалить препарат";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonAddDrug
            // 
            this.buttonAddDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDrug.Location = new System.Drawing.Point(5, 337);
            this.buttonAddDrug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddDrug.Name = "buttonAddDrug";
            this.buttonAddDrug.Size = new System.Drawing.Size(397, 58);
            this.buttonAddDrug.TabIndex = 5;
            this.buttonAddDrug.Text = "Добавить препарат";
            this.buttonAddDrug.UseVisualStyleBackColor = true;
            this.buttonAddDrug.Click += new System.EventHandler(this.buttonAddDrug_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(777, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewDrugsConstructed
            // 
            this.dataGridViewDrugsConstructed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrugsConstructed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugsConstructed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDrugsConstructed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugsConstructed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.manufacturer_name,
            this.manufacturer_country,
            this.inn});
            this.dataGridViewDrugsConstructed.Location = new System.Drawing.Point(6, 4);
            this.dataGridViewDrugsConstructed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDrugsConstructed.Name = "dataGridViewDrugsConstructed";
            this.dataGridViewDrugsConstructed.RowHeadersWidth = 51;
            this.dataGridViewDrugsConstructed.RowTemplate.Height = 24;
            this.dataGridViewDrugsConstructed.Size = new System.Drawing.Size(1073, 326);
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
            // 
            // manufacturer_country
            // 
            this.manufacturer_country.HeaderText = "Страна";
            this.manufacturer_country.MinimumWidth = 6;
            this.manufacturer_country.Name = "manufacturer_country";
            // 
            // inn
            // 
            this.inn.HeaderText = "Международное название";
            this.inn.MinimumWidth = 6;
            this.inn.Name = "inn";
            // 
            // tabPageFindDrugs
            // 
            this.tabPageFindDrugs.Controls.Add(this.groupBox1);
            this.tabPageFindDrugs.Controls.Add(this.dataGridViewDrugs);
            this.tabPageFindDrugs.Location = new System.Drawing.Point(4, 25);
            this.tabPageFindDrugs.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageFindDrugs.Name = "tabPageFindDrugs";
            this.tabPageFindDrugs.Size = new System.Drawing.Size(1217, 687);
            this.tabPageFindDrugs.TabIndex = 2;
            this.tabPageFindDrugs.Text = "Препараты";
            this.tabPageFindDrugs.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(17, 411);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1160, 240);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonAddDrugToUserDrugs
            // 
            this.buttonAddDrugToUserDrugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDrugToUserDrugs.Location = new System.Drawing.Point(720, 168);
            this.buttonAddDrugToUserDrugs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDrugToUserDrugs.Name = "buttonAddDrugToUserDrugs";
            this.buttonAddDrugToUserDrugs.Size = new System.Drawing.Size(352, 43);
            this.buttonAddDrugToUserDrugs.TabIndex = 31;
            this.buttonAddDrugToUserDrugs.Text = "Добавить препарат в свой список";
            this.buttonAddDrugToUserDrugs.UseVisualStyleBackColor = true;
            this.buttonAddDrugToUserDrugs.Click += new System.EventHandler(this.buttonAddDrugToUserDrugs_Click);
            // 
            // radioButtonIndication
            // 
            this.radioButtonIndication.AutoSize = true;
            this.radioButtonIndication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonIndication.Location = new System.Drawing.Point(361, 132);
            this.radioButtonIndication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonIndication.Name = "radioButtonIndication";
            this.radioButtonIndication.Size = new System.Drawing.Size(132, 29);
            this.radioButtonIndication.TabIndex = 30;
            this.radioButtonIndication.Text = "Показание";
            this.radioButtonIndication.UseVisualStyleBackColor = true;
            // 
            // comboBoxIndication
            // 
            this.comboBoxIndication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxIndication.FormattingEnabled = true;
            this.comboBoxIndication.Location = new System.Drawing.Point(361, 174);
            this.comboBoxIndication.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIndication.Name = "comboBoxIndication";
            this.comboBoxIndication.Size = new System.Drawing.Size(279, 33);
            this.comboBoxIndication.TabIndex = 29;
            // 
            // comboBoxActiveIngredient
            // 
            this.comboBoxActiveIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxActiveIngredient.FormattingEnabled = true;
            this.comboBoxActiveIngredient.Location = new System.Drawing.Point(720, 68);
            this.comboBoxActiveIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxActiveIngredient.Name = "comboBoxActiveIngredient";
            this.comboBoxActiveIngredient.Size = new System.Drawing.Size(345, 33);
            this.comboBoxActiveIngredient.TabIndex = 28;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(361, 66);
            this.comboBoxClass.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(279, 33);
            this.comboBoxClass.TabIndex = 27;
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(8, 174);
            this.comboBoxManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(279, 33);
            this.comboBoxManufacturer.TabIndex = 26;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(8, 63);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(279, 34);
            this.textBoxName.TabIndex = 25;
            // 
            // radioButtonActiveIngredient
            // 
            this.radioButtonActiveIngredient.AutoSize = true;
            this.radioButtonActiveIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonActiveIngredient.Location = new System.Drawing.Point(720, 26);
            this.radioButtonActiveIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonActiveIngredient.Name = "radioButtonActiveIngredient";
            this.radioButtonActiveIngredient.Size = new System.Drawing.Size(264, 29);
            this.radioButtonActiveIngredient.TabIndex = 11;
            this.radioButtonActiveIngredient.Text = "Действующее вещество";
            this.radioButtonActiveIngredient.UseVisualStyleBackColor = true;
            // 
            // radioButtonClass
            // 
            this.radioButtonClass.AutoSize = true;
            this.radioButtonClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonClass.Location = new System.Drawing.Point(361, 25);
            this.radioButtonClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonClass.Name = "radioButtonClass";
            this.radioButtonClass.Size = new System.Drawing.Size(97, 29);
            this.radioButtonClass.TabIndex = 10;
            this.radioButtonClass.Text = "Группа";
            this.radioButtonClass.UseVisualStyleBackColor = true;
            // 
            // radioButtonManufacturer
            // 
            this.radioButtonManufacturer.AutoSize = true;
            this.radioButtonManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonManufacturer.Location = new System.Drawing.Point(8, 132);
            this.radioButtonManufacturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonManufacturer.Name = "radioButtonManufacturer";
            this.radioButtonManufacturer.Size = new System.Drawing.Size(180, 29);
            this.radioButtonManufacturer.TabIndex = 9;
            this.radioButtonManufacturer.Text = "Производитель";
            this.radioButtonManufacturer.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Checked = true;
            this.radioButtonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonName.Location = new System.Drawing.Point(8, 22);
            this.radioButtonName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(120, 29);
            this.radioButtonName.TabIndex = 8;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Название";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // buttonFindDrugs
            // 
            this.buttonFindDrugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindDrugs.Location = new System.Drawing.Point(720, 109);
            this.buttonFindDrugs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindDrugs.Name = "buttonFindDrugs";
            this.buttonFindDrugs.Size = new System.Drawing.Size(352, 43);
            this.buttonFindDrugs.TabIndex = 0;
            this.buttonFindDrugs.Text = "Найти препарат";
            this.buttonFindDrugs.UseVisualStyleBackColor = true;
            this.buttonFindDrugs.Click += new System.EventHandler(this.buttonFindDrugs_Click);
            // 
            // dataGridViewDrugs
            // 
            this.dataGridViewDrugs.AllowUserToAddRows = false;
            this.dataGridViewDrugs.AllowUserToDeleteRows = false;
            this.dataGridViewDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDrugs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewDrugs.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewDrugs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDrugs.Name = "dataGridViewDrugs";
            this.dataGridViewDrugs.RowHeadersWidth = 51;
            this.dataGridViewDrugs.RowTemplate.Height = 24;
            this.dataGridViewDrugs.Size = new System.Drawing.Size(1160, 391);
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Международное название";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tabPageUserDrugs
            // 
            this.tabPageUserDrugs.Controls.Add(this.buttonDeleteUserDrug);
            this.tabPageUserDrugs.Controls.Add(this.buttonSubtractQuantity);
            this.tabPageUserDrugs.Controls.Add(this.buttonAddQuantity);
            this.tabPageUserDrugs.Controls.Add(this.buttonInstruction);
            this.tabPageUserDrugs.Controls.Add(this.dataGridViewUserDrugs);
            this.tabPageUserDrugs.Location = new System.Drawing.Point(4, 25);
            this.tabPageUserDrugs.Name = "tabPageUserDrugs";
            this.tabPageUserDrugs.Size = new System.Drawing.Size(1217, 687);
            this.tabPageUserDrugs.TabIndex = 3;
            this.tabPageUserDrugs.Text = "Ваш список препаратов";
            this.tabPageUserDrugs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUserDrugs
            // 
            this.dataGridViewUserDrugs.AllowUserToAddRows = false;
            this.dataGridViewUserDrugs.AllowUserToDeleteRows = false;
            this.dataGridViewUserDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserDrugs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserDrugs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUserDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserDrugs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnManufacturer,
            this.ColumnCountry,
            this.ColumnINN,
            this.ColumnQuantity});
            this.dataGridViewUserDrugs.Location = new System.Drawing.Point(0, 2);
            this.dataGridViewUserDrugs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUserDrugs.Name = "dataGridViewUserDrugs";
            this.dataGridViewUserDrugs.RowHeadersWidth = 51;
            this.dataGridViewUserDrugs.RowTemplate.Height = 24;
            this.dataGridViewUserDrugs.Size = new System.Drawing.Size(1160, 391);
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
            // 
            // ColumnCountry
            // 
            this.ColumnCountry.HeaderText = "Страна";
            this.ColumnCountry.MinimumWidth = 6;
            this.ColumnCountry.Name = "ColumnCountry";
            // 
            // ColumnINN
            // 
            this.ColumnINN.HeaderText = "Международное название";
            this.ColumnINN.MinimumWidth = 6;
            this.ColumnINN.Name = "ColumnINN";
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.HeaderText = "Количество";
            this.ColumnQuantity.MinimumWidth = 6;
            this.ColumnQuantity.Name = "ColumnQuantity";
            // 
            // buttonInstruction
            // 
            this.buttonInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstruction.Location = new System.Drawing.Point(81, 488);
            this.buttonInstruction.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInstruction.Name = "buttonInstruction";
            this.buttonInstruction.Size = new System.Drawing.Size(352, 43);
            this.buttonInstruction.TabIndex = 5;
            this.buttonInstruction.Text = "Прочитать инструкцию";
            this.buttonInstruction.UseVisualStyleBackColor = true;
            this.buttonInstruction.Click += new System.EventHandler(this.buttonInstruction_Click);
            // 
            // buttonAddQuantity
            // 
            this.buttonAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddQuantity.Location = new System.Drawing.Point(470, 486);
            this.buttonAddQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddQuantity.Name = "buttonAddQuantity";
            this.buttonAddQuantity.Size = new System.Drawing.Size(45, 45);
            this.buttonAddQuantity.TabIndex = 6;
            this.buttonAddQuantity.Text = "+";
            this.buttonAddQuantity.UseVisualStyleBackColor = true;
            this.buttonAddQuantity.Click += new System.EventHandler(this.buttonAddQuantity_Click);
            // 
            // buttonSubtractQuantity
            // 
            this.buttonSubtractQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubtractQuantity.Location = new System.Drawing.Point(547, 486);
            this.buttonSubtractQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubtractQuantity.Name = "buttonSubtractQuantity";
            this.buttonSubtractQuantity.Size = new System.Drawing.Size(45, 45);
            this.buttonSubtractQuantity.TabIndex = 7;
            this.buttonSubtractQuantity.Text = "-";
            this.buttonSubtractQuantity.UseVisualStyleBackColor = true;
            this.buttonSubtractQuantity.Click += new System.EventHandler(this.buttonSubtractQuantity_Click);
            // 
            // buttonDeleteUserDrug
            // 
            this.buttonDeleteUserDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteUserDrug.Location = new System.Drawing.Point(614, 486);
            this.buttonDeleteUserDrug.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteUserDrug.Name = "buttonDeleteUserDrug";
            this.buttonDeleteUserDrug.Size = new System.Drawing.Size(352, 43);
            this.buttonDeleteUserDrug.TabIndex = 8;
            this.buttonDeleteUserDrug.Text = "Убрать позицию";
            this.buttonDeleteUserDrug.UseVisualStyleBackColor = true;
            this.buttonDeleteUserDrug.Click += new System.EventHandler(this.buttonDeleteUserDrug_Click);
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 699);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPageDrugsEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugsConstructed)).EndInit();
            this.tabPageFindDrugs.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugs)).EndInit();
            this.tabPageUserDrugs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDrugs)).EndInit();
            this.ResumeLayout(false);

        }

        private void buttonFindDrugs_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonAddDrugToUserDrugs_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridViewUsers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridViewUsers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tabPageUsers_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonInstruction_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonAddQuantity_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonSubtractQuantity_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonDeleteUserDrug_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TabPage tabPageDrugsEdit;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mode;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.DataGridView dataGridViewDrugsConstructed;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
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
    }
}