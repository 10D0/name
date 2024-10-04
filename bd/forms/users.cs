using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace bd.forms
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
            roles_update();
            users_update();
            users_dataGridView.SelectionChanged += users_dataGridView_SelectionChanged;
            roles_datagridview.SelectionChanged += roles_datagridview_SelectionChanged;
            users_toolstriplabel.Margin = new Padding((this.Width - 80 - back_toolstripbutton.Width - users_toolstriplabel.Width) / 2, 2, 20, 2);

            toolStrip1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            email_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            email_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            phone_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            phone_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            password_textbox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            password_textbox1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            password_textbox2.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            password_textbox2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            rolename_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            rolename_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            full_name_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            full_name_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            login_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            login_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            users_toolstriplabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");

            back_toolstripbutton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            back_toolstripbutton.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");

            Addrole_button.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            Addrole_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            Registration_button.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            Registration_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            change_button.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            change_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            delete_button.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            delete_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");

            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            Rolename_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            full_name_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            phone_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            email_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            password_label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            password_label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            login_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            role_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            Rolename_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            role_combobox.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            role_combobox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");


            users_dataGridView.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            roles_datagridview.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            users_dataGridView.RowsDefaultCellStyle = new DataGridViewCellStyle() { BackColor = ColorTranslator.FromHtml("#BAE0EC") };
            roles_datagridview.RowsDefaultCellStyle = new DataGridViewCellStyle() { BackColor = ColorTranslator.FromHtml("#BAE0EC") };
        }

        private void roles_datagridview_SelectionChanged(object sender, EventArgs e)
        {
            if (roles_datagridview.SelectedRows.Count == 1 && roles_datagridview.SelectedRows[0].Index != users_dataGridView.Rows.Count - 1)
            {
                DataGridViewRow row = roles_datagridview.SelectedRows[0];

                rolename_textbox.Text = row.Cells["role_name"].Value.ToString();
            }
        }

        private void back_toolstripbutton_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new medicine();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void Addrole_button_Click(object sender, EventArgs e)
        {
            string query = @"insert into roles(role_name)
            values (@rolename);";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@rolename",  rolename_textbox.Text)
            };
            if (DataBase.ExecuteNonQuery(query, parameters) == 1)
            {
                roles_update();
                MessageBox.Show("Роль добавлена!");
            }
            else
                MessageBox.Show("Роль не добавлена!");
        }
        private void roles_update()
        {
            string query = @"select * from roles";
            DataTable dt = DataBase.ExecuteQuery(query);
            roles_datagridview.DataSource = dt;

            //combobobx
            role_combobox.Items.Clear();
            string[] available_roles;
            if (dt.Rows.Count > 0)
            {
                available_roles = new string[dt.Rows.Count];
                //добавление всех найденных ролей в combobox
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    role_combobox.Items.Add(new KeyValuePair<int,string>((int)dt.Rows[i]["role_id"], dt.Rows[i]["role_name"].ToString()));
                    role_combobox.ValueMember = "Key";
                    role_combobox.DisplayMember = "Value";

                }
            }
        }
        private void users_update()
        {
            string query = @"select * from users";
            DataTable dt = DataBase.ExecuteQuery(query);
            users_dataGridView.DataSource = dt;
        }

        private void deleterole_button_Click(object sender, EventArgs e)
        {
            string query = @"delete from roles
            where role_name = @rolename";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@rolename",  rolename_textbox.Text)
            };
            if (DataBase.ExecuteNonQuery(query, parameters) == 1)
            {
                roles_update();
                MessageBox.Show("Роль Удалена!");
            }
            else
                MessageBox.Show("Роль не удалена!");
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            if (role_combobox.SelectedItem == null || login_textbox.Text == string.Empty || password_textbox1.Text == string.Empty || password_textbox2.Text == string.Empty || phone_label.Text == string.Empty || email_label.Text == string.Empty)
            {
                MessageBox.Show("Введите все данные.");
                return;
            }
            else if (!(password_textbox1.Text.Equals(password_textbox2.Text)))
            {
                MessageBox.Show("Пароли не похожи.");
                return;
            }
            else if (phone_textbox.Text.Length != 11)
            {
                MessageBox.Show("Проверьте корректность номера телефона.");
                return;
            }

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
            //KeyValuePair<int, string> selectedEntry = ((KeyValuePair<int, string>)role_combobox.SelectedItem).Key;
            //int selectedKey = selectedEntry.Key
            parameters = new SqlParameter[]
            {
                    new SqlParameter("@full_name",  full_name_textbox.Text),
                    new SqlParameter("@phone",  phone_textbox.Text),
                    new SqlParameter("@login",  login_textbox.Text),
                    new SqlParameter("@email",  email_textbox.Text),
                    new SqlParameter("@password",  password_textbox1.Text),
                    new SqlParameter("@registration_date",  DateTime.Today.ToString("d")),
                    new SqlParameter("@role_id", ((KeyValuePair<int, string>)role_combobox.SelectedItem).Key)

            };
            if (DataBase.ExecuteNonQuery(query, parameters) == 1)
            {
                users_update();
                MessageBox.Show("Аккаунт успешно зарегистрирован!");
            }
            else
            {
                MessageBox.Show("Ошибка Регистрации!");
            }
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            if (role_combobox.SelectedItem == null || login_textbox.Text == string.Empty || password_textbox1.Text == string.Empty || password_textbox2.Text == string.Empty || phone_label.Text == string.Empty || email_label.Text == string.Empty)
            {
                MessageBox.Show("Введите все данные.");
                return;
            }
            else if (!(password_textbox1.Text.Equals(password_textbox2.Text)))
            {
                MessageBox.Show("Пароли не похожи.");
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
                       role_id = @role_id
                   where user_id = @user_id;
                   CLOSE SYMMETRIC KEY Symmetric_Key;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@full_name",  full_name_textbox.Text),
                    new SqlParameter("@phone",  phone_textbox.Text),
                    new SqlParameter("@email",  email_textbox.Text),
                    new SqlParameter("@role_id",  role_combobox.SelectedIndex+1),
                    new SqlParameter("@user_id",  (int)users_dataGridView.SelectedRows[0].Cells["user_id"].Value)

            };
            if (DataBase.ExecuteNonQuery(query, parameters) == 1)
            {
                users_update();
                MessageBox.Show("Изменения внесены!");
            }
            else
            {
                MessageBox.Show("Ошибка внесения изменений!");
            }
        }

        private void users_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(users_dataGridView.SelectedRows.Count == 1 && users_dataGridView.SelectedRows[0].Index != users_dataGridView.Rows.Count-1)
            {
                DataGridViewRow row = users_dataGridView.SelectedRows[0];

                full_name_textbox.Text = row.Cells["full_name"].Value.ToString();
                login_textbox.Text = row.Cells["login"].Value.ToString();
                //password_textbox1.Text = row.Cells["password"].Value.ToString();
                //password_textbox2.Text = row.Cells["password"].Value.ToString();
                phone_textbox.Text = row.Cells["phone"].Value.ToString();
                email_textbox.Text = row.Cells["email"].Value.ToString();
                foreach (var item in role_combobox.Items)
                {
                    var kvp = (KeyValuePair<int, string>)item;
                    if (kvp.Key == (int)row.Cells["role_id"].Value)
                    {
                        role_combobox.SelectedItem = item;
                        return;
                    }
                }
                //role_combobox.SelectedItem = new KeyValuePair<int, string>((int)row.Cells["role_id"].Value, dataSouceCantieri[(int)row.Cells["role_id"].Value]);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string query = @"
                   Delete from users
                   where user_id = @user_id;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@user_id",  (int)users_dataGridView.SelectedRows[0].Cells["user_id"].Value)
            };
            if (DataBase.ExecuteNonQuery(query, parameters) == 1)
            {
                users_update();
                MessageBox.Show("Аккаунт успешно удален!");
            }
            else
            {
                MessageBox.Show("Ошибка удаления!");
            }
        }
    }
}