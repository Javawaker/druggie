using DruggieLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Druggie
{
    public partial class FormDrugEdit : Form
    {
        DrugModelConstructed drug = new DrugModelConstructed();
        List<string> activeIngredientList = new List<string>();
        List<string> indicationList = new List<string>();
        List<CountryModel> countryModels = new List<CountryModel>();
        List<string> dataSourceCountryNames = new List<string>();
        List<ClassModel> classModels = new List<ClassModel>();
        List<string> dataSourceClassNames = new List<string>();
        List<ManufacturerModel> manufacturerModels = new List<ManufacturerModel>();
        List<string> dataSourceManufacturerNames = new List<string>();
        List<ActiveIngredientModel> activeIngredientModels = new List<ActiveIngredientModel>();
        List<IndicationModel> indicationModels = new List<IndicationModel>();

        public FormDrugEdit()
        {
            InitializeComponent();
        }
        public FormDrugEdit(DrugModelConstructed drug)
        {
            InitializeComponent();
            this.drug = drug;
            buttonAddDrug.Text = "Сохранить изменения";
            
        }

        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            saveDrug();
        }

        private void FormDrugEdit_Load(object sender, EventArgs e)
        {
            countryModels = SqliteDataAccess.LoadCountries();
            classModels = SqliteDataAccess.LoadClasses();
            manufacturerModels = SqliteDataAccess.LoadManufacturers();
            activeIngredientModels = SqliteDataAccess.LoadActiveIngredients();
            indicationModels = SqliteDataAccess.LoadIndications();

            dataSourceCountryNames = Func.loadDataSource(comboBoxCountry, countryModels.ToList<IModel>());
            dataSourceClassNames = Func.loadDataSource(comboBoxClass, classModels.ToList<IModel>());
            dataSourceManufacturerNames = Func.loadDataSource(comboBoxManufacturer, manufacturerModels.ToList<IModel>());
            Func.loadDataSource(comboBoxActiveIngredient, activeIngredientModels.ToList<IModel>());
            Func.loadDataSource(comboBoxIndication, indicationModels.ToList<IModel>());

            if (drug.Name != null)
            {
                textBoxName.Text = drug.Name;
                textBoxInstruction.Text = SqliteDataAccess.LoadInstruction(drug.Name);
                comboBoxManufacturer.Text = drug.Manufacturer_name;
                comboBoxCountry.Text = drug.Manufacturer_country;
                comboBoxClass.Text = SqliteDataAccess.LoadDrugClass(drug.Name);

                foreach (var activeIngredient in SqliteDataAccess.LoadDrugActiveIngredients(drug.Name))
                {
                    activeIngredientList.Add(activeIngredient.Name);
                    dataGridViewActiveIngredient.Rows.Add(activeIngredient.Name);
                    wireUpActiveIngredients();
                }
                foreach (var Indication in SqliteDataAccess.LoadDrugIndications(drug.Name))
                {
                    indicationList.Add(Indication.Name);
                    dataGridViewIndication.Rows.Add(Indication.Name);
                    wireUpIndications();
                }
            }
            buttonActiveIngredientAdd.Enabled = false;
            buttonIndicationAdd.Enabled = false;
        }

        private string generateINN(List<string> lst)
        {
            string inn = string.Empty;
            if (lst.Count > 0)
            {
                inn = lst.First();
                if (lst.Count() > 1)
                {
                    for (int i = 1; i < lst.Count; i++)
                    {
                        inn += $" + {lst[i]}";
                    }
                }
            }
            return inn;
        }
        private void buttonActiveIngredientAdd_Click(object sender, EventArgs e)
        {
            var isIngredientAdded = from ai in activeIngredientList
                                    where ai.Equals(comboBoxActiveIngredient.Text)
                                    select ai;

            if (isIngredientAdded.Count() == 0)
            {
                activeIngredientList.Add(comboBoxActiveIngredient.Text);
                dataGridViewActiveIngredient.Rows.Add(comboBoxActiveIngredient.Text);
                wireUpActiveIngredients();
                checkbuttonAvailability();
            }
            else
            {
                MessageBox.Show("Это дествующее вещество уже добавлено");
            }
        }

        private void wireUpActiveIngredients()
        {
            dataGridViewActiveIngredient.Rows.Clear();
            foreach (var ai in activeIngredientList)
            {
                dataGridViewActiveIngredient.Rows.Add(ai);
            }
            textBoxINN.Text = generateINN(activeIngredientList);
            if (activeIngredientList.Count() == 0)
                buttonActiveIngredientRemove.Enabled = false;
            else
                buttonActiveIngredientRemove.Enabled = true;
        }

        private void wireUpIndications()
        {
            dataGridViewIndication.Rows.Clear();
            foreach (var ai in indicationList)
            {
                dataGridViewIndication.Rows.Add(ai);
            }
            if (indicationList.Count() == 0)
                buttonIndicationRemove.Enabled = false;
            else
                buttonIndicationRemove.Enabled = true;
        }

        private void buttonActiveIngredientRemove_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewActiveIngredient.CurrentRow.Index;
            activeIngredientList.Remove(dataGridViewActiveIngredient.Rows[rowindex].Cells[0].Value.ToString());
            wireUpActiveIngredients();
            checkbuttonAvailability();
        }

        private void buttonIndicationAdd_Click(object sender, EventArgs e)
        {
            var isIndicationAdded = from i in indicationList
                                    where i.Equals(comboBoxIndication.Text)
                                    select i;

            if (isIndicationAdded.Count() == 0)
            {
                indicationList.Add(comboBoxIndication.Text);
                dataGridViewIndication.Rows.Add(comboBoxIndication.Text);
                wireUpIndications();
                checkbuttonAvailability();
            }
            else
            {
                MessageBox.Show("Это показание уже добавлено");
            }
        }


        private void buttonIndicationRemove_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewIndication.CurrentRow.Index;
            indicationList.Remove(dataGridViewIndication.Rows[rowindex].Cells[0].Value.ToString());
            wireUpIndications();
            checkbuttonAvailability();
        }

        private bool saveCountries()
        {

            var isCountryNew = from c in this.dataSourceCountryNames
                               where c.Equals(comboBoxCountry.Text)
                               select c;

            if (isCountryNew.Count() == 0)
            {
                CountryModel newCountry = new CountryModel();
                newCountry.Name = comboBoxCountry.Text;
                SqliteDataAccess.AddCountry(newCountry);

                MessageBox.Show("Новая страна была добавлена в базу");
            }
            return true;
        }
        private bool saveClass()
        {
            var isClassNew = from c in this.dataSourceClassNames
                             where c.Equals(comboBoxClass.Text)
                             select c;

            if (isClassNew.Count() == 0)
            {
                ClassModel newClass = new ClassModel();
                newClass.Name = comboBoxClass.Text;
                SqliteDataAccess.AddClass(newClass);

                MessageBox.Show("Новая группа была добавлена в базу");
            }

            return true;
        }

        private bool saveManufacturers()
        {

            var isManufacturerNew = from c in this.dataSourceManufacturerNames
                                    where c.Equals(comboBoxManufacturer.Text)
                                    select c;

            if (isManufacturerNew.Count() == 0)
            {
                ManufacturerModel newManufacturer = new ManufacturerModel();
                newManufacturer.Name = comboBoxManufacturer.Text;
                newManufacturer.Country_Name = comboBoxCountry.Text;
                SqliteDataAccess.AddManufacturer(newManufacturer);

                MessageBox.Show("Новый производитель был добавлена в базу");
            }
            else
            {
                foreach (var m in manufacturerModels)
                {
                    if (m.Name.Equals(comboBoxManufacturer.Text))
                    {
                        if (m.Country_Name == comboBoxCountry.Text)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Неверное сочетание производителя и страны\nВнесены коррективы");
                            comboBoxCountry.Text = m.Country_Name;
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void saveActiveIngredient(DrugModel drug)
        {
            bool nameFound = false;
            int kAdded = 0;
            foreach (var ai in activeIngredientList)
            {
                foreach (var aiM in activeIngredientModels)
                {
                    if (ai == aiM.Name)
                    {
                        nameFound = true;
                        break;
                    }
                    nameFound = false;
                }
                if (!nameFound)
                {
                    SqliteDataAccess.AddActiveIngredient(new ActiveIngredientModel(ai));
                    kAdded++;
                }
            }

            switch (kAdded)
            {
                case 0:
                    break;
                case 1:
                    MessageBox.Show("В базу было добавлено новое активное вещество");
                    break;
                default:
                    MessageBox.Show("В базу были добавлены новые активные вещества");
                    break;
            }

            foreach (var ai in activeIngredientList)
            {
                SqliteDataAccess.AddDrugActiveIngredient(drug.Name, ai);
            }
        }
        private void saveIndication(DrugModel drug)
        {
            bool nameFound = false;
            int kAdded = 0;
            foreach (var indication in indicationList)
            {
                foreach (var aiM in indicationModels)
                {
                    if (indication == aiM.Name)
                    {
                        nameFound = true;
                        break;
                    }
                    nameFound = false;
                }
                if (!nameFound)
                {
                    SqliteDataAccess.AddIndication(new IndicationModel(indication));
                    kAdded++;
                }
            }

            switch (kAdded)
            {
                case 0:
                    break;
                case 1:
                    MessageBox.Show("В базу было добавлено новое показание");
                    break;
                default:
                    MessageBox.Show("В базу были добавлены новые показания");
                    break;
            }

            foreach (var indication in indicationList)
            {
                SqliteDataAccess.AddDrugIndication(drug.Name, indication);
            }
        }
        private void saveDrug()
        {
            List<DrugModelConstructed> drugModelConstructeds = new List<DrugModelConstructed>();
            drugModelConstructeds = SqliteDataAccess.LoadDrugConstructed();
            List<string> drugNames = new List<string>();

            foreach (var d in drugModelConstructeds)
                drugNames.Add(d.Name);

            if (drug.Name != null)
                drugNames.Remove(drug.Name);

            var isNameNew = from c in drugNames
                            where c.Equals(textBoxName.Text)
                            select c;

            if (isNameNew.Count() == 0)
            {
                if (saveManufacturers() && saveClass() && saveCountries())
                {
                    string name = textBoxName.Text;
                    string drugClass = comboBoxClass.Text;
                    string manufacturer = comboBoxManufacturer.Text;
                    string inn = textBoxINN.Text;
                    string instruction = textBoxInstruction.Text;
                    DrugModel newDrug = new DrugModel(name, drugClass, manufacturer, inn, instruction);

                    if (drug.Name != null)
                        SqliteDataAccess.DeleteDrug(drug);

                    SqliteDataAccess.AddDrug(newDrug);
                    saveIndication(newDrug);
                    saveActiveIngredient(newDrug);
                    if (drug.Name != null)
                        MessageBox.Show("Препарат успешно изменен!");
                    else
                        MessageBox.Show("Препарат успешно добавлен!");

                    Close();
                }
            }
            else
            {
                MessageBox.Show("Это имя уже занято");
                return;
            }
        }

        private void checkbuttonAvailability()
        {
            if (
                textBoxName.Text != String.Empty && comboBoxClass.Text != String.Empty &&
                comboBoxManufacturer.Text != String.Empty && comboBoxCountry.Text != String.Empty &&
                textBoxInstruction.Text != String.Empty &&
                dataGridViewIndication.Rows.Count != 0 && dataGridViewActiveIngredient.Rows.Count != 0
                )
                buttonAddDrug.Enabled = true;
            else
                buttonAddDrug.Enabled = false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            checkbuttonAvailability();
        }

        private void comboBoxClass_TextChanged(object sender, EventArgs e)
        {
            checkbuttonAvailability();
        }

        private void comboBoxManufacturer_TextChanged(object sender, EventArgs e)
        {
            checkbuttonAvailability();
        }

        private void comboBoxCountry_TextChanged(object sender, EventArgs e)
        {
            checkbuttonAvailability();
        }

        private void textBoxInstruction_TextChanged(object sender, EventArgs e)
        {
            checkbuttonAvailability();
        }
        private void comboBoxActiveIngredient_TextUpdate(object sender, EventArgs e)
        {
            if (comboBoxActiveIngredient.Text == String.Empty)
                buttonActiveIngredientAdd.Enabled = false;
            else
                buttonActiveIngredientAdd.Enabled = true;
        }
        private void comboBoxIndication_TextUpdate(object sender, EventArgs e)
        {
            if (comboBoxIndication.Text == String.Empty)
                buttonIndicationAdd.Enabled = false;
            else
                buttonIndicationAdd.Enabled = true;
        }

        private void comboBoxActiveIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxActiveIngredient.Text == String.Empty)
                buttonActiveIngredientAdd.Enabled = false;
            else
                buttonActiveIngredientAdd.Enabled = true;
        }

        private void comboBoxIndication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIndication.Text == String.Empty)
                buttonIndicationAdd.Enabled = false;
            else
                buttonIndicationAdd.Enabled = true;
        }
    }
}
