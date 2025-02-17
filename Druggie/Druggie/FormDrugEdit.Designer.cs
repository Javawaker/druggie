namespace Druggie
{
    partial class FormDrugEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrugEdit));
            this.dataGridViewActiveIngredient = new System.Windows.Forms.DataGridView();
            this.ActiveIngredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.buttonAddDrug = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonActiveIngredientAdd = new System.Windows.Forms.Button();
            this.buttonActiveIngredientRemove = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.comboBoxActiveIngredient = new System.Windows.Forms.ComboBox();
            this.comboBoxIndication = new System.Windows.Forms.ComboBox();
            this.buttonIndicationRemove = new System.Windows.Forms.Button();
            this.buttonIndicationAdd = new System.Windows.Forms.Button();
            this.dataGridViewIndication = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnIndication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInstruction = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndication)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewActiveIngredient
            // 
            this.dataGridViewActiveIngredient.AllowUserToAddRows = false;
            this.dataGridViewActiveIngredient.AllowUserToDeleteRows = false;
            this.dataGridViewActiveIngredient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActiveIngredient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewActiveIngredient.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewActiveIngredient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewActiveIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveIngredient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActiveIngredient});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewActiveIngredient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewActiveIngredient.Location = new System.Drawing.Point(16, 19);
            this.dataGridViewActiveIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewActiveIngredient.Name = "dataGridViewActiveIngredient";
            this.dataGridViewActiveIngredient.RowHeadersWidth = 51;
            this.dataGridViewActiveIngredient.RowTemplate.Height = 24;
            this.dataGridViewActiveIngredient.Size = new System.Drawing.Size(672, 138);
            this.dataGridViewActiveIngredient.TabIndex = 3;
            // 
            // ActiveIngredient
            // 
            this.ActiveIngredient.HeaderText = "Действующие вещества";
            this.ActiveIngredient.MinimumWidth = 6;
            this.ActiveIngredient.Name = "ActiveIngredient";
            this.ActiveIngredient.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(21, 50);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(674, 30);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Производитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "МНН";
            // 
            // textBoxINN
            // 
            this.textBoxINN.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxINN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxINN.Location = new System.Drawing.Point(21, 374);
            this.textBoxINN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.ReadOnly = true;
            this.textBoxINN.Size = new System.Drawing.Size(674, 30);
            this.textBoxINN.TabIndex = 8;
            // 
            // buttonAddDrug
            // 
            this.buttonAddDrug.Enabled = false;
            this.buttonAddDrug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonAddDrug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonAddDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDrug.Location = new System.Drawing.Point(20, 422);
            this.buttonAddDrug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddDrug.Name = "buttonAddDrug";
            this.buttonAddDrug.Size = new System.Drawing.Size(674, 69);
            this.buttonAddDrug.TabIndex = 11;
            this.buttonAddDrug.Text = "Добавить препарат";
            this.buttonAddDrug.UseVisualStyleBackColor = true;
            this.buttonAddDrug.Click += new System.EventHandler(this.buttonAddDrug_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(396, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Страна";
            // 
            // buttonActiveIngredientAdd
            // 
            this.buttonActiveIngredientAdd.Enabled = false;
            this.buttonActiveIngredientAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonActiveIngredientAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonActiveIngredientAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActiveIngredientAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonActiveIngredientAdd.Location = new System.Drawing.Point(16, 202);
            this.buttonActiveIngredientAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActiveIngredientAdd.Name = "buttonActiveIngredientAdd";
            this.buttonActiveIngredientAdd.Size = new System.Drawing.Size(278, 51);
            this.buttonActiveIngredientAdd.TabIndex = 14;
            this.buttonActiveIngredientAdd.Text = "Добавить вещество";
            this.buttonActiveIngredientAdd.UseVisualStyleBackColor = true;
            this.buttonActiveIngredientAdd.Click += new System.EventHandler(this.buttonActiveIngredientAdd_Click);
            // 
            // buttonActiveIngredientRemove
            // 
            this.buttonActiveIngredientRemove.Enabled = false;
            this.buttonActiveIngredientRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonActiveIngredientRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonActiveIngredientRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActiveIngredientRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonActiveIngredientRemove.Location = new System.Drawing.Point(411, 202);
            this.buttonActiveIngredientRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonActiveIngredientRemove.Name = "buttonActiveIngredientRemove";
            this.buttonActiveIngredientRemove.Size = new System.Drawing.Size(277, 51);
            this.buttonActiveIngredientRemove.TabIndex = 15;
            this.buttonActiveIngredientRemove.Text = "Удалить вещество";
            this.buttonActiveIngredientRemove.UseVisualStyleBackColor = true;
            this.buttonActiveIngredientRemove.Click += new System.EventHandler(this.buttonActiveIngredientRemove_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(396, 262);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(298, 33);
            this.comboBoxCountry.TabIndex = 16;
            this.comboBoxCountry.TextChanged += new System.EventHandler(this.comboBoxCountry_TextChanged);
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(22, 262);
            this.comboBoxManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(342, 33);
            this.comboBoxManufacturer.TabIndex = 17;
            this.comboBoxManufacturer.TextChanged += new System.EventHandler(this.comboBoxManufacturer_TextChanged);
            // 
            // comboBoxActiveIngredient
            // 
            this.comboBoxActiveIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxActiveIngredient.FormattingEnabled = true;
            this.comboBoxActiveIngredient.Location = new System.Drawing.Point(15, 163);
            this.comboBoxActiveIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxActiveIngredient.Name = "comboBoxActiveIngredient";
            this.comboBoxActiveIngredient.Size = new System.Drawing.Size(673, 33);
            this.comboBoxActiveIngredient.TabIndex = 18;
            this.comboBoxActiveIngredient.SelectedIndexChanged += new System.EventHandler(this.comboBoxActiveIngredient_SelectedIndexChanged);
            this.comboBoxActiveIngredient.TextUpdate += new System.EventHandler(this.comboBoxActiveIngredient_TextUpdate);
            // 
            // comboBoxIndication
            // 
            this.comboBoxIndication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxIndication.FormattingEnabled = true;
            this.comboBoxIndication.Location = new System.Drawing.Point(14, 406);
            this.comboBoxIndication.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIndication.Name = "comboBoxIndication";
            this.comboBoxIndication.Size = new System.Drawing.Size(674, 33);
            this.comboBoxIndication.TabIndex = 22;
            this.comboBoxIndication.SelectedIndexChanged += new System.EventHandler(this.comboBoxIndication_SelectedIndexChanged);
            this.comboBoxIndication.TextUpdate += new System.EventHandler(this.comboBoxIndication_TextUpdate);
            // 
            // buttonIndicationRemove
            // 
            this.buttonIndicationRemove.Enabled = false;
            this.buttonIndicationRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonIndicationRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonIndicationRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndicationRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIndicationRemove.Location = new System.Drawing.Point(411, 445);
            this.buttonIndicationRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIndicationRemove.Name = "buttonIndicationRemove";
            this.buttonIndicationRemove.Size = new System.Drawing.Size(277, 51);
            this.buttonIndicationRemove.TabIndex = 21;
            this.buttonIndicationRemove.Text = "Удалить показание";
            this.buttonIndicationRemove.UseVisualStyleBackColor = true;
            this.buttonIndicationRemove.Click += new System.EventHandler(this.buttonIndicationRemove_Click);
            // 
            // buttonIndicationAdd
            // 
            this.buttonIndicationAdd.Enabled = false;
            this.buttonIndicationAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonIndicationAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonIndicationAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndicationAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIndicationAdd.Location = new System.Drawing.Point(14, 445);
            this.buttonIndicationAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIndicationAdd.Name = "buttonIndicationAdd";
            this.buttonIndicationAdd.Size = new System.Drawing.Size(277, 51);
            this.buttonIndicationAdd.TabIndex = 20;
            this.buttonIndicationAdd.Text = "Добавить показание";
            this.buttonIndicationAdd.UseVisualStyleBackColor = true;
            this.buttonIndicationAdd.Click += new System.EventHandler(this.buttonIndicationAdd_Click);
            // 
            // dataGridViewIndication
            // 
            this.dataGridViewIndication.AllowUserToAddRows = false;
            this.dataGridViewIndication.AllowUserToDeleteRows = false;
            this.dataGridViewIndication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIndication.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewIndication.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIndication.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewIndication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnIndication});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewIndication.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewIndication.Location = new System.Drawing.Point(15, 262);
            this.dataGridViewIndication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewIndication.Name = "dataGridViewIndication";
            this.dataGridViewIndication.RowHeadersWidth = 51;
            this.dataGridViewIndication.RowTemplate.Height = 24;
            this.dataGridViewIndication.Size = new System.Drawing.Size(673, 138);
            this.dataGridViewIndication.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumnIndication
            // 
            this.dataGridViewTextBoxColumnIndication.HeaderText = "Показания";
            this.dataGridViewTextBoxColumnIndication.MinimumWidth = 6;
            this.dataGridViewTextBoxColumnIndication.Name = "dataGridViewTextBoxColumnIndication";
            this.dataGridViewTextBoxColumnIndication.ReadOnly = true;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(21, 156);
            this.comboBoxClass.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(674, 33);
            this.comboBoxClass.TabIndex = 24;
            this.comboBoxClass.TextChanged += new System.EventHandler(this.comboBoxClass_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Группа";
            // 
            // textBoxInstruction
            // 
            this.textBoxInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInstruction.Location = new System.Drawing.Point(0, 541);
            this.textBoxInstruction.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInstruction.Multiline = true;
            this.textBoxInstruction.Name = "textBoxInstruction";
            this.textBoxInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInstruction.Size = new System.Drawing.Size(1539, 303);
            this.textBoxInstruction.TabIndex = 25;
            this.textBoxInstruction.TextChanged += new System.EventHandler(this.textBoxInstruction_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Инструкция";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridViewActiveIngredient);
            this.groupBox1.Controls.Add(this.buttonActiveIngredientAdd);
            this.groupBox1.Controls.Add(this.buttonActiveIngredientRemove);
            this.groupBox1.Controls.Add(this.comboBoxActiveIngredient);
            this.groupBox1.Controls.Add(this.dataGridViewIndication);
            this.groupBox1.Controls.Add(this.comboBoxIndication);
            this.groupBox1.Controls.Add(this.buttonIndicationAdd);
            this.groupBox1.Controls.Add(this.buttonIndicationRemove);
            this.groupBox1.Location = new System.Drawing.Point(838, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 511);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonAddDrug);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxCountry);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxClass);
            this.groupBox2.Controls.Add(this.textBoxINN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxManufacturer);
            this.groupBox2.Location = new System.Drawing.Point(0, -7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 511);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // FormDrugEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Druggie.Properties.Resources.pattern_2;
            this.ClientSize = new System.Drawing.Size(1924, 853);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxInstruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormDrugEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrugEdit";
            this.Load += new System.EventHandler(this.FormDrugEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndication)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActiveIngredient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.Button buttonAddDrug;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonActiveIngredientAdd;
        private System.Windows.Forms.Button buttonActiveIngredientRemove;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.ComboBox comboBoxActiveIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveIngredient;
        private System.Windows.Forms.ComboBox comboBoxIndication;
        private System.Windows.Forms.Button buttonIndicationRemove;
        private System.Windows.Forms.Button buttonIndicationAdd;
        private System.Windows.Forms.DataGridView dataGridViewIndication;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnIndication;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInstruction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}