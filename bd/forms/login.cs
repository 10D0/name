using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bd.forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            registration_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            login_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");

            login_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            login_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            password_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            password_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            login_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            password_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            title_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (login_textbox.Text == string.Empty || password_textbox.Text == string.Empty)
            {
                MessageBox.Show("Введите все данные", "Неверные данные", MessageBoxButtons.OK);
                return;
            }

            string query = @"open symmetric key Symmetric_Key decryption by password = 'kiselev' 
            SELECT role_id, user_id FROM Users 
            WHERE login = @login AND CONVERT(varchar, DecryptByKey(Password)) = @password 
            CLOSE SYMMETRIC KEY Symmetric_Key;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@login",  login_textbox.Text),
                new SqlParameter("@password",  password_textbox.Text)
            };

            DataTable result = DataBase.ExecuteQuery(query, parameters);
            if (result.Rows.Count>0)
            {
                User.roleId = (int)result.Rows[0]["role_id"];
                User.userId = (int)result.Rows[0]["user_id"];
            }
            else
            {
                MessageBox.Show("Проверьте корректность введенных данных", "Неверные данные", MessageBoxButtons.OK);
                return;
            }
            Program.Context.MainForm = new medicine();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new registration();
            this.Close();
            Program.Context.MainForm.Show();
        }
    }
}