using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DruggieLibrary;


namespace Druggie
{


    public partial class Authorization : Form
    {
        int btnOffSet = 65;
        bool authorizationMode = true;
        //bool isUserExists;
        //UserModel userModel = null;
        UserModel userModel = new UserModel();
        List<UserModel> userModels = new List<UserModel>();
        public Authorization()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonRegistration_CheckedChanged(object sender, EventArgs e)
        {
            authorizationMode = !authorizationMode;
            if (authorizationMode)
            {
                labelPassword2.Visible = false;
                textBoxPassword2.Visible = false;
                buttonAuthorize.Top -= btnOffSet;
                groupBox1.Height -= btnOffSet;
            }
            else
            {
                labelPassword2.Visible = true;
                textBoxPassword2.Visible = true;
                buttonAuthorize.Top += btnOffSet;
                groupBox1.Height += btnOffSet;
            }
        }

        private void radioButtonAuthorization_CheckedChanged(object sender, EventArgs e)
        {
            //labelPassword2.Visible = false;
            //textBoxPassword2.Visible = false;
            //buttonAuthorize.Top -= 50;
        }

        private bool isUserExists(UserModel userModel, bool authorizationMode)
        {
            if (authorizationMode)
            {
                foreach (var user in userModels)
                {
                    if (userModel.Username == user.Username && userModel.Password == user.Password)
                    {
                        userModel.UserMode_name = user.UserMode_name;
                        return true;
                    }
                }

                return false;
            }
            else
            {
                foreach (var user in userModels)
                {
                    if (userModel.Username == user.Username)
                        return true;
                }
                return false;
            }
        }

        private void openForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonAuthorize_Click(object sender, EventArgs e)
        {
            userModels = SqliteDataAccess.LoadUsers();
            userModel.Username = textBoxLogin.Text;
            userModel.Password = textBoxPassword.Text;


            switch (authorizationMode)
            {
                case true:
                    if (isUserExists(userModel, authorizationMode))
                    {
                        MessageBox.Show("success");

                        switch (userModel.UserMode_name)
                        {
                            case "admin":
                                FormAdminPanel formAdminPanel = new FormAdminPanel();
                                openForm(formAdminPanel);
                                break;
                            //case "pharmacist":
                            //    FormAdminPanel formAdminPanel = new FormAdminPanel();
                            //    openForm(formAdminPanel);
                            //    break;
                            //case "user":
                            //    FormAdminPanel formAdminPanel = new FormAdminPanel();
                            //    openForm(formAdminPanel);
                            //    break;
                            default:
                                break;
                        }

                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Неверное имя пользователя или пароль");
                    }
                    break;


                case false:
                    if (textBoxPassword.Text == textBoxPassword2.Text)
                    {
                        if (isUserExists(userModel, authorizationMode))
                        {
                            MessageBox.Show("Данное имя пользователя уже занято!");
                        }
                        else
                        {
                            userModel.UserMode_name = "user";
                            SqliteDataAccess.AddUser(userModel);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введенные пароли не совпадают!");
                        textBoxPassword.Text = string.Empty;
                        textBoxPassword2.Text = string.Empty;
                    }
                    break;
            }
        }

        private void buttonAuthorize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonAuthorize_Click(sender, e);
        }
    }
}