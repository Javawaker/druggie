using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DruggieLibrary;

namespace Druggie
{
    public partial class Authorization : Form
    {
        int btnOffSet = 65;
        bool authorizationMode = true;
        UserModel userModel = new UserModel();
        List<UserModel> userModels = new List<UserModel>();

        public Authorization()
        {
            InitializeComponent();
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

        private bool isUserExists(UserModel userModel, bool authorizationMode)
        {
            if (authorizationMode)
            {
                foreach (var user in userModels)
                {
                    if (userModel.Username == user.Username)
                    {
                        userModel.Salt = user.Salt;
                        userModel.Hash = Hashing.GenerateSaltedHash(Encoding.ASCII.GetBytes(textBoxPassword.Text), userModel.Salt);

                        if (Hashing.CompareHash(userModel.Hash, user.Hash))
                        {
                            userModel.UserMode_name = user.UserMode_name;
                            return true;
                        }
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

        private void confirmDada()
        {

            userModels = SqliteDataAccess.LoadUsers();
            userModel.Username = textBoxLogin.Text;

            switch (authorizationMode)
            {
                case true:
                    if (isUserExists(userModel, authorizationMode))
                    {

                        FormAdminPanel formAdminPanel = new FormAdminPanel(userModel);
                        openForm(formAdminPanel);
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
                            userAddHashAndSalt(userModel, Encoding.ASCII.GetBytes(textBoxPassword.Text));
                            SqliteDataAccess.AddUser(userModel);
                            MessageBox.Show("Регистрация прошла успешно");

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
        private void buttonAuthorize_Click(object sender, EventArgs e)
        {
            confirmDada();
        }

        private void textBoxLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                confirmDada();
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                confirmDada();
        }

        private void textBoxPassword2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                confirmDada();
        }

        private void userAddHashAndSalt(UserModel um, byte[] password)
        {
            byte[] salt;

            do
            {
                salt = Hashing.GetSalt();
            } while (isSaltExists(salt));

            um.Hash = Hashing.GenerateSaltedHash(password, salt);
            um.Salt = salt;
        }

        private bool isSaltExists(byte[] salt)
        {
            foreach (var user in userModels)
            {
                if (salt == user.Salt)
                    return true;
            }
            return false;
        }
    }
}