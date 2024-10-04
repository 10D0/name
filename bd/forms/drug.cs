using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace bd.forms
{
    public partial class drug : Form
    {
        private int Id;
        public drug(int id)
        {
            InitializeComponent();
            
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            toolStrip1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            Add_drug_button.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            Add_drug_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            applychanges_button.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            applychanges_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            loadimage_button.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            loadimage_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");

            discription_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            discription_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            medicine_name_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            medicine_name_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            price_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            price_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            quantity_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            quantity_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");

            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            id_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            category_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            medicine_name_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            quantity_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            price_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            quantity_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            category_combobox.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            category_combobox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            Id = id;
            Id_value_label.Text = id.ToString();
            string query = @"select * from categories";
            DataTable dt = DataBase.ExecuteQuery(query);
            category_combobox.Items.Clear();
            string[] available_roles;
            if (dt.Rows.Count > 0)
            {
                available_roles = new string[dt.Rows.Count];
                //добавление всех найденных ролей в combobox
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    category_combobox.Items.Add(new KeyValuePair<int, string>((int)dt.Rows[i]["category_id"], dt.Rows[i]["category_name"].ToString()));
                    //category_combobox.ValueMember = "Key";
                    //category_combobox.DisplayMember = "Value";
                }
            }
            if (User.roleId == 1)
            {
                category_combobox.Enabled = false;
                id_label.Visible = false;
                Id_value_label.Visible = false;
                applychanges_button.Visible = false;
                loadimage_button.Visible = false;
                quantity_textbox.ReadOnly = true;
                discription_textbox.ReadOnly = true;
                medicine_name_textbox.ReadOnly = true;
                price_textbox.ReadOnly = true;
            }
            query = @"select medicine_id, preview, medicine_name, category_id, quantity, price, discription 
                from medicine
                where medicine_id = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id",  id)
            };
            DataTable result = DataBase.ExecuteQuery(query, parameters);

            try
            {
                medicine_name_textbox.Text = result.Rows[0].Field<string>("medicine_name");
                price_textbox.Text = result.Rows[0].Field<object>("price").ToString();
                Id_value_label.Text = result.Rows[0].Field<int>("medicine_id").ToString();
                quantity_textbox.Text = result.Rows[0].Field<int>("quantity").ToString();
                discription_textbox.Text = result.Rows[0].Field<string>("discription").ToString();
                //изображение
                if (result.Rows.Count > 0 && result.Rows[0]["preview"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])result.Rows[0]["preview"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                //category_combobox.SelectedValue = result.Rows[0].Field<int>("category_id");
                foreach (var item in category_combobox.Items)
                {
                    var kvp = (KeyValuePair<int, string>)item;
                    if (kvp.Key == result.Rows[0].Field<int>("category_id"))
                    {
                        category_combobox.SelectedItem = item;
                        return;
                    }
                }
                
            }
            catch { }

           
        }

        private void back_toolstripbutton_Click(object sender, System.EventArgs e)
        {
            Program.Context.MainForm = new medicine();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void loadimage_button_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() { Title = "Выберите изображение", Filter = "image JPG|*.jpg;*.png" };
            if (dialog.ShowDialog() != DialogResult.Cancel)
                pictureBox1.Image = System.Drawing.Image.FromFile(dialog.FileName);
        }

        private void applychanges_button_Click(object sender, System.EventArgs e)
        {
            if (category_combobox.SelectedItem == null || medicine_name_textbox.Text == string.Empty || quantity_textbox.Text == string.Empty || price_textbox.Text == string.Empty)
            {
                MessageBox.Show("Введите все данные.");
                return;
            }
            string query = @"
                   update medicine
                   set medicine_name = @medicine_name,
                       preview = @preview,
                       quantity = @quantity,
                       discription = @discription,
                       category_id = @category_id
                   where medicine_id = @id;";
            byte[] imageData = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }
            }
            else
            {
               
            }
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@id", Id),
                    new SqlParameter("@medicine_name", medicine_name_textbox.Text),
                    new SqlParameter("@quantity",  quantity_textbox.Text),
                    new SqlParameter("@discription",  discription_textbox.Text),
                    new SqlParameter("@category_id",  ((KeyValuePair<int, string>)category_combobox.SelectedItem).Key),
                    new SqlParameter("@preview",  SqlDbType.VarBinary){ Value = imageData }

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

        private void Add_drug_button_Click_1(object sender, EventArgs e)
        {
            string query = @"
                select price from medicine
                where medicine_id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", Id)
            };
            DataTable dataTable = DataBase.ExecuteQuery(query, sqlParameters);
            float price = 0;
            float.TryParse(dataTable.Rows[0]["price"].ToString(),out price);
            medicinedrug newDrug = new medicinedrug(Id, 1, price);
            orderlist.Add(newDrug);
        }
    }
}