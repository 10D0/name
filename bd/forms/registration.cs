using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bd.forms
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");

        }
        
        private void registration_Load(object sender, EventArgs e)
        {
            //combobox
            string query = "select role_name from roles where role_id >= @id1 and role_id <=@id2";
            SqlParameter[] sqlParameters;
            switch (User.roleId)
            {
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
                    role_combobox.Enabled = false;
                    break;
            }
            DataTable dataTable = DataBase.ExecuteQuery(query,sqlParameters);
            if (dataTable.Rows.Count > 0)
            {
                string[] available_roles = new string[dataTable.Rows.Count];
                //добавление всех найденных ролей в combobox
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    //available_roles[i] = ;
                    role_combobox.Items.Add(dataTable.Rows[i]["role_name"].ToString());
                }
                //foreach (string name in available_roles)
                  //  role_combobox.Items.Add(name);
                role_combobox.SelectedIndex = 0;
            }
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            if (role_combobox.SelectedItem == null || login_textbox.Text == string.Empty || password_textbox1.Text == string.Empty || password_textbox2.Text == string.Empty || phone_label.Text == string.Empty || email_label.Text == string.Empty)
            {
                MessageBox.Show("Введите все данные.");
                return;
            }
            else if (!(password_textbox1.Text.Equals(password_textbox2.Text) ))
            {
                MessageBox.Show("Пароли не похожи.");
                return;
            }
            else if (phone_textbox.Text.Length != 11)
            {
                MessageBox.Show("Проверьте корректность номера телефона.");
                return;
            }
            else
            {
                string query = "select count(*) from users where login = @login;";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@login",  login_textbox.Text)
                };
                object result = DataBase.ExecuteScalar(query, parameters);
                if (result == null && Convert.ToInt32(result) != 0)
                {
                    MessageBox.Show("Данный логин занят.");
                    return;
                }

                //
                query = "OPEN SYMMETRIC KEY Symmetric_Key DECRYPTION BY PASSWORD = 'kiselev' " +
                    "INSERT INTO  users  (full_name, phone, email, login, password, registration_date, role_id)  " +
                    "VALUES (@full_name, @phone, @email,@login, EncryptByKey(Key_GUID('Symmetric_Key'), Convert(varchar, @Password)), @registration_date, @role_id)" +
                    "CLOSE SYMMETRIC KEY Symmetric_Key;";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@full_name",  full_name_textbox.Text),
                    new SqlParameter("@phone",  phone_textbox.Text),
                    new SqlParameter("@login",  login_textbox.Text),
                    new SqlParameter("@email",  email_textbox.Text),
                    new SqlParameter("@password",  password_textbox1.Text),
                    new SqlParameter("@registration_date",  DateTime.Today.ToString("d")),
                    new SqlParameter("@role_id",  role_combobox.SelectedIndex+1)

                };
                if (DataBase.ExecuteNonQuery(query, parameters) == 1)
                {
                    MessageBox.Show("Аккаунт успешно зарегистрирован!");
                }
                else
                {
                    MessageBox.Show("Ошибка Регистрации!");
                }

                Program.Context.MainForm = new login();

                this.Close();

                // покажет вторую форму и оставит приложение живым до ее закрытия
                Program.Context.MainForm.Show();
            }
        }

        private void registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
