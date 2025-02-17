using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DruggieLibrary;

namespace Druggie
{
    public partial class FormAdminPanel : Form
    {
        public UserModel user { get; set; }
        List<UserModel> userModels = new List<UserModel>();
        List<UserModeModel> userModes = new List<UserModeModel>();
        List<UserDrugModel> userDrugModels = new List<UserDrugModel>();
        BindingList<string> lists = new BindingList<string>();
        List<DrugModelConstructed> drugModelConstructeds = new List<DrugModelConstructed>();

        public FormAdminPanel() { InitializeComponent(); }
        public FormAdminPanel(UserModel user)
        {
            InitializeComponent();

            this.user = user;
            switch (user.UserMode_name)
            {
                case "admin":
                    break;
                case "pharmacist":
                    tabControl.TabPages.Remove(tabPageUsers);
                    break;
                case "user":
                    tabControl.TabPages.Remove(tabPageUsers);
                    tabControl.TabPages.Remove(tabPageDrugsEdit);
                    break;
            }
        }
        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            loadAutocompleteData();
            loadUsers();
            loadUserDrugs();
            loadDrugs();
        }
        private void loadAutocompleteData()
        {
            Func.loadDataSource(textBoxName, SqliteDataAccess.LoadDrugConstructed().ToList<IModel>());
            Func.loadDataSource(comboBoxClass, SqliteDataAccess.LoadClasses().ToList<IModel>());
            Func.loadDataSource(comboBoxManufacturer, SqliteDataAccess.LoadManufacturers().ToList<IModel>());
            Func.loadDataSource(comboBoxActiveIngredient, SqliteDataAccess.LoadActiveIngredients().ToList<IModel>());
            Func.loadDataSource(comboBoxIndication, SqliteDataAccess.LoadIndications().ToList<IModel>());
        }

        private void loadUsers()
        {
            userModels = SqliteDataAccess.LoadUsers();
            userModes = SqliteDataAccess.LoadUserModes();
            lists.Clear();
            foreach (var mode in userModes)
            {
                lists.Add(mode.name);
            }
            wireUpUsers();
        }


        private void loadDrugs()
        {
            drugModelConstructeds = SqliteDataAccess.LoadDrugConstructed();
            wireUpDrugs();
        }
        private void loadUserDrugs()
        {
            drugModelConstructeds = SqliteDataAccess.LoadDrugConstructedByUserDrugs(user.Username);
            wireUpUserDrugs(dataGridViewUserDrugs);
        }
        private void wireUpDrugs()
        {
            dataGridViewDrugsConstructed.Rows.Clear();
            dataGridViewDrugs.Rows.Clear();

            foreach (var drug in drugModelConstructeds)
            {
                dataGridViewDrugsConstructed.Rows.Add(drug.Name, drug.Manufacturer_name, drug.Manufacturer_country, drug.Inn);
                dataGridViewDrugs.Rows.Add(drug.Name, drug.Manufacturer_name, drug.Manufacturer_country, drug.Inn);
            }
            labelCounter.Text = "Найдено препаратов: " + drugModelConstructeds.Count.ToString();
            if (dataGridViewDrugs.Rows.Count == 0)
            {
                buttonAddDrugToUserDrugs.Enabled = false;
                buttonDeleteDrug.Enabled = false;
                buttonEditDrug.Enabled = false;
            }
            else
            {
                buttonAddDrugToUserDrugs.Enabled = true;
                buttonDeleteDrug.Enabled = true;
                buttonEditDrug.Enabled = true;

            }
        }
        private void wireUpUserDrugs(DataGridView dgv)
        {
            dgv.Rows.Clear();

            foreach (var drug in drugModelConstructeds)
            {
                dgv.Rows.Add(drug.Name, drug.Manufacturer_name, drug.Manufacturer_country, drug.Inn, drug.Quantity);
            }
            if (dgv.Rows.Count == 0)
            {
                buttonInstruction.Enabled = false;
                buttonAddQuantity.Enabled = false;
                buttonSubtractQuantity.Enabled = false;
                buttonDeleteUserDrug.Enabled = false;
            }
            else
            {
                buttonInstruction.Enabled = true;
                buttonAddQuantity.Enabled = true;
                buttonSubtractQuantity.Enabled = true;
                buttonDeleteUserDrug.Enabled = true;
            }
        }

        private void wireUpUsers()
        {
            dataGridViewUsers.Rows.Clear();
            foreach (UserModel user in userModels)
            {
                dataGridViewUsers.Rows.Add(user.Username, user.UserMode_name);
            }
        }
        private void dataGridViewUsers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewComboBoxCell box = dataGridViewUsers.Rows[e.RowIndex].Cells[1] as DataGridViewComboBoxCell;
            box.FlatStyle = FlatStyle.Flat;
            box.DataSource = lists;
        }
        private DrugModelConstructed getDrugFromGridView(DataGridView dataGridView)
        {
            drugModelConstructeds = SqliteDataAccess.LoadDrugConstructed();
            int rowindex = dataGridView.CurrentRow.Index;
            string name = dataGridView.Rows[rowindex].Cells[0].Value.ToString();
            return drugModelConstructeds.Find(d => d.Name == name);

        }

        private UserModel getUserFromGridView()
        {
            userModels = SqliteDataAccess.LoadUsers();
            int rowindex = dataGridViewUsers.CurrentRow.Index;
            string username = dataGridViewUsers.Rows[rowindex].Cells[0].Value.ToString();
            return userModels.Find(i => i.Username == username);
        }
        private List<UserModel> getUsersFromGridView()
        {
            List<UserModel> users = new List<UserModel>();
            UserModel user = new UserModel();
            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                user.Username = row.Cells[0].Value.ToString();
                user.UserMode_name = row.Cells[1].Value.ToString();
                users.Add(new UserModel(user));
            }
            return users;
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.SaveAndUpdateUsers(getUsersFromGridView());
            loadUsers();
        }
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (
                DialogResult.Yes == MessageBox.Show
                    (
                    "Вы уверены, что хотите удалить пользователя?", "Удаление пользователя",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                    )
                )
            {
                SqliteDataAccess.DeleteUser(getUserFromGridView());
                loadUsers();
            }
        }
        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            FormDrugEdit formDrugEdit = new FormDrugEdit();
            Hide();
            formDrugEdit.ShowDialog();
            Show();
            loadAutocompleteData();
            loadDrugs();
        }
        private void buttonFindDrugs_Click(object sender, EventArgs e)
        {
            string value;
            if (radioButtonActiveIngredient.Checked)
            {
                value = comboBoxActiveIngredient.Text;
                drugModelConstructeds = SqliteDataAccess.LoadDrugConstructedByActiveIngredient(value);
                wireUpDrugs();
                return;
            }

            if (radioButtonIndication.Checked)
            {
                value = comboBoxIndication.Text;
                drugModelConstructeds = SqliteDataAccess.LoadDrugConstructedByIndication(value);
                wireUpDrugs();
                return;
            }

            if (radioButtonClass.Checked)
            {
                value = comboBoxClass.Text;
                drugModelConstructeds = SqliteDataAccess.LoadDrugConstructedByClass(value);
                wireUpDrugs();
                return;
            }

            if (radioButtonManufacturer.Checked)
            {
                value = comboBoxManufacturer.Text;
                drugModelConstructeds = SqliteDataAccess.LoadDrugConstructedByManufacturer(value);
                wireUpDrugs();
                return;
            }

            if (radioButtonName.Checked)
            {
                if (textBoxName.Text == String.Empty)
                    value = string.Empty;
                else
                    value = textBoxName.Text[0].ToString().ToUpper() + textBoxName.Text.Substring(1);

                drugModelConstructeds = SqliteDataAccess.LoadDrugConstructedByName(value);
                if (drugModelConstructeds.Count == 0)
                {
                    value = textBoxName.Text;
                    drugModelConstructeds = SqliteDataAccess.LoadDrugConstructedByName(value);
                }
                wireUpDrugs();
                return;
            }
        }
        private void buttonAddDrugToUserDrugs_Click(object sender, EventArgs e)
        {
            DrugModelConstructed drugC = new DrugModelConstructed();
            drugC = getDrugFromGridView(dataGridViewDrugs);

            UserDrugModel userDrugModel;
            userDrugModels = new List<UserDrugModel>();
            userDrugModels = SqliteDataAccess.LoadUserDrug(user.Username, drugC.Name);

            if (userDrugModels.Count == 0)
            {
                userDrugModel = new UserDrugModel(user.Username, drugC.Name, 1);
                SqliteDataAccess.AddUserDrug(userDrugModel);
                MessageBox.Show("Вы добавили препарат в свой список");
            }
            else
            {
                userDrugModel = userDrugModels.FirstOrDefault();
                userDrugModel.Quantity++;
                SqliteDataAccess.UpdateUserDrug(userDrugModel);
                MessageBox.Show("Вы добавили еще одну копию препарата в свой список");
            }
            loadUserDrugs();
        }
        private void buttonInstruction_Click(object sender, EventArgs e)
        {
            string instruction;
            instruction = SqliteDataAccess.LoadInstruction(getDrugFromGridView(dataGridViewUserDrugs).Name);
            FormInstruction formInstruction = new FormInstruction(instruction);
            formInstruction.Show();
        }
        private void buttonAddQuantity_Click(object sender, EventArgs e)
        {
            string mode = "+";
            changeQuantity(mode);
        }
        private void changeQuantity(string mode)
        {
            DrugModelConstructed drugC = new DrugModelConstructed();
            drugC = getDrugFromGridView(dataGridViewUserDrugs);
            UserDrugModel userDrugModel;
            userDrugModels = new List<UserDrugModel>();
            userDrugModels = SqliteDataAccess.LoadUserDrug(user.Username, drugC.Name);
            userDrugModel = userDrugModels.FirstOrDefault();
            switch (mode)
            {
                case "+":
                    userDrugModel.Quantity++;
                    SqliteDataAccess.UpdateUserDrug(userDrugModel);
                    break;
                case "-":
                    userDrugModel.Quantity--;
                    if (userDrugModel.Quantity > 0)
                        SqliteDataAccess.UpdateUserDrug(userDrugModel);
                    else
                        if (DialogResult.Yes == MessageBox.Show
                            (
                                "Вы уверены, что хотите удалить препарат из списка?", "Удаление препарата",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                            ))
                        SqliteDataAccess.DeleteUserDrug(userDrugModel);
                    else
                        return;
                    break;
                case "del":
                    if (DialogResult.Yes == MessageBox.Show
                            (
                                "Вы уверены, что хотите удалить препарат из списка?", "Удаление препарата",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                            ))
                        SqliteDataAccess.DeleteUserDrug(userDrugModel);
                    else
                        return;
                    break;
                default:
                    break;
            }
            int rowindex = dataGridViewUserDrugs.CurrentRow.Index;
            loadUserDrugs();
            if (dataGridViewUserDrugs.Rows.Count > 0)
                if (dataGridViewUserDrugs.Rows.Count > rowindex)
                    dataGridViewUserDrugs.CurrentCell = dataGridViewUserDrugs.Rows[rowindex].Cells[0];
                else
                    dataGridViewUserDrugs.CurrentCell = dataGridViewUserDrugs.Rows[rowindex - 1].Cells[0];
        }
        private void buttonSubtractQuantity_Click(object sender, EventArgs e)
        {
            string mode = "-";
            changeQuantity(mode);
        }

        private void buttonDeleteUserDrug_Click(object sender, EventArgs e)
        {
            string mode = "del";
            changeQuantity(mode);
        }

        private void buttonDeleteDrug_Click(object sender, EventArgs e)
        {
            if (
                DialogResult.Yes == MessageBox.Show
                    (
                    "Вы уверены, что хотите удалить препарат из базы?", "Удаление препарата",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                    )
                )
            {
                SqliteDataAccess.DeleteDrug(getDrugFromGridView(dataGridViewDrugsConstructed));
                loadAutocompleteData();
                loadDrugs();
                loadUserDrugs();
            }

        }

        private void buttonEditDrug_Click(object sender, EventArgs e)
        {

            FormDrugEdit formDrugEdit = new FormDrugEdit(getDrugFromGridView(dataGridViewDrugsConstructed));
            formDrugEdit.ShowDialog();
            loadAutocompleteData();
            loadDrugs();
            loadUserDrugs();
        }

        private void dataGridViewUsers_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void tabPageFindDrugs_Click(object sender, EventArgs e)
        {

        }
    }
}
