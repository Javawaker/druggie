﻿namespace Druggie
{
    partial class Authorization
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAuthorization = new System.Windows.Forms.RadioButton();
            this.buttonAuthorize = new System.Windows.Forms.Button();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.radioButtonRegistration = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRegistration);
            this.groupBox1.Controls.Add(this.radioButtonAuthorization);
            this.groupBox1.Controls.Add(this.buttonAuthorize);
            this.groupBox1.Controls.Add(this.labelPassword2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPassword2);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxLogin);
            this.groupBox1.Location = new System.Drawing.Point(47, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonAuthorization
            // 
            this.radioButtonAuthorization.AutoSize = true;
            this.radioButtonAuthorization.Checked = true;
            this.radioButtonAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAuthorization.Location = new System.Drawing.Point(29, 21);
            this.radioButtonAuthorization.Name = "radioButtonAuthorization";
            this.radioButtonAuthorization.Size = new System.Drawing.Size(156, 29);
            this.radioButtonAuthorization.TabIndex = 7;
            this.radioButtonAuthorization.TabStop = true;
            this.radioButtonAuthorization.Text = "Авторизация";
            this.radioButtonAuthorization.UseVisualStyleBackColor = true;
            this.radioButtonAuthorization.CheckedChanged += new System.EventHandler(this.radioButtonAuthorization_CheckedChanged);
            // 
            // buttonAuthorize
            // 
            this.buttonAuthorize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthorize.Location = new System.Drawing.Point(29, 220);
            this.buttonAuthorize.Name = "buttonAuthorize";
            this.buttonAuthorize.Size = new System.Drawing.Size(223, 52);
            this.buttonAuthorize.TabIndex = 6;
            this.buttonAuthorize.Text = "Подтвердить";
            this.buttonAuthorize.UseVisualStyleBackColor = true;
            this.buttonAuthorize.Click += new System.EventHandler(this.buttonAuthorize_Click);
            this.buttonAuthorize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonAuthorize_KeyDown);
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword2.Location = new System.Drawing.Point(24, 220);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(209, 25);
            this.labelPassword2.TabIndex = 5;
            this.labelPassword2.Text = "Подтвердите пароль";
            this.labelPassword2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword2.Location = new System.Drawing.Point(29, 248);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.PasswordChar = '*';
            this.textBoxPassword2.Size = new System.Drawing.Size(223, 34);
            this.textBoxPassword2.TabIndex = 2;
            this.textBoxPassword2.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(29, 168);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(223, 34);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(29, 88);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(223, 34);
            this.textBoxLogin.TabIndex = 0;
            // 
            // radioButtonRegistration
            // 
            this.radioButtonRegistration.AutoSize = true;
            this.radioButtonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonRegistration.Location = new System.Drawing.Point(206, 21);
            this.radioButtonRegistration.Name = "radioButtonRegistration";
            this.radioButtonRegistration.Size = new System.Drawing.Size(152, 29);
            this.radioButtonRegistration.TabIndex = 8;
            this.radioButtonRegistration.Text = "Регистрация";
            this.radioButtonRegistration.UseVisualStyleBackColor = true;
            this.radioButtonRegistration.CheckedChanged += new System.EventHandler(this.radioButtonRegistration_CheckedChanged);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 449);
            this.Controls.Add(this.groupBox1);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAuthorization;
        private System.Windows.Forms.Button buttonAuthorize;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.RadioButton radioButtonRegistration;
    }
}

