using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bd.forms
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
            profile_toolstriplabel.Margin = new Padding((this.Width-80-back_toolstripbutton.Width-profile_toolstriplabel.Width)/2,2,20,2);
            //combobox
            string query = "select role_name from roles where role_id >= @id1 and role_id <=@id2";
            SqlParameter[] sqlParameters;
            switch (User.roleId)
            {
                case 2:
                    sqlParameters = new SqlParameter[]
                    {
                        new SqlParameter("@id1", 1),
                        new SqlParameter("@id2", 2)
                    };
                    break;
                case 3:
                    sqlParameters = new SqlParameter[]
                    {
                        new SqlParameter("@id1", 1),
                        new SqlParameter("@id2", 3)
                    };
                    break;
                default:
                    sqlParameters = new SqlParameter[]
                    {
                        new SqlParameter("@id1", 1),
                        new SqlParameter("@id2", 1)
                    };
                    break;
            }
                    role_combobox.Enabled = false;
            DataTable dataTable = DataBase.ExecuteQuery(query, sqlParameters);
            string[] available_roles;
            if (dataTable.Rows.Count > 0)
            {
                available_roles = new string[dataTable.Rows.Count];
                //добавление всех найденных ролей в combobox
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    role_combobox.Items.Add(dataTable.Rows[i]["role_name"].ToString());
            }
            //поля
            query = @"open symmetric key Symmetric_Key decryption by password = 'kiselev'
                select full_name, phone, email, login, CONVERT(varchar(512), DECRYPTBYKEY(password)) AS password,registration_date, role_id from users
                where user_id = @userid
                close symmetric key Symmetric_Key";
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@userid", User.userId)
            };
            dataTable = DataBase.ExecuteQuery(query, sqlParameters);
            available_roles = new string[dataTable.Rows.Count];
            full_name_textbox.Text = dataTable.Rows[0].Field<string>("full_name");
            login_textbox.Text = dataTable.Rows[0].Field<string>("login");
            password_textbox.Text = dataTable.Rows[0].Field<string>("password");
            phone_textbox.Text = dataTable.Rows[0].Field<string>("phone");
            email_textbox.Text = dataTable.Rows[0].Field<string>("email");
            role_combobox.SelectedIndex = dataTable.Rows[0].Field<int>("role_id")-1;
            registrationdate.Text = dataTable.Rows[0].Field<DateTime>("registration_date").ToString("d");

            toolStrip1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");

            Registration_button.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            Registration_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");

            back_toolstripbutton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            back_toolstripbutton.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");

            profile_toolstriplabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");

            email_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            email_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            phone_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            phone_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            login_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            login_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            password_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            password_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            full_name_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            full_name_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            role_combobox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            role_combobox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");

            email_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            phone_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            login_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            password_label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            full_name_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            registrationdate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            registrationdate_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");

        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            if (role_combobox.SelectedItem == null || login_textbox.Text == string.Empty || password_textbox.Text == string.Empty || phone_label.Text == string.Empty || email_label.Text == string.Empty)
            {
                MessageBox.Show("Введите все данные.");
                return;
            }
            else if (phone_textbox.Text.Length != 11)
            {
                MessageBox.Show("Проверьте корректность номера телефона.");
                return;
            }
            string query = @"OPEN SYMMETRIC KEY Symmetric_Key DECRYPTION BY PASSWORD = 'kiselev'
                   update users
                   set full_name = @full_name,
                       phone = @phone,
                       email = @email,
                       login = @login,
                       password = EncryptByKey(Key_GUID('Symmetric_Key'), Convert(varchar, @Password)),
                       role_id = @role_id
                   where user_id = @user_id;
                   CLOSE SYMMETRIC KEY Symmetric_Key;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@full_name",  full_name_textbox.Text),
                    new SqlParameter("@phone",  phone_textbox.Text),
                    new SqlParameter("@login",  login_textbox.Text),
                    new SqlParameter("@email",  email_textbox.Text),
                    new SqlParameter("@password",  password_textbox.Text),
                    new SqlParameter("@role_id",  role_combobox.SelectedIndex+1),
                    new SqlParameter("@user_id",  User.userId)

            };
            if (DataBase.ExecuteNonQuery(query, parameters) == 1)
            {
                MessageBox.Show("Изменения внесены!");
            }
            else
            {
                MessageBox.Show("Ошибка внесения изменений!");
            }
        }

        private void back_toolstripbutton_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new medicine();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void Exit_toolstripbutton_Click(object sender, EventArgs e)
        {
            User.userId = -1;
            User.roleId = -1;
            orderlist.Orderlist.Clear();
            Program.Context.MainForm = new login();
            this.Close();
            Program.Context.MainForm.Show();
        }
    }
}