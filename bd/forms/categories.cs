using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace bd.forms
{
    public partial class categories : Form
    {
        public categories()
        {
            InitializeComponent();
            roles_update();
            toolStrip1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            category_datagridview.SelectionChanged += category_datagridview_SelectionChanged;
            categories_toolstriplabel.Margin = new Padding((this.Width - 80 - back_toolstripbutton.Width - categories_toolstriplabel.Width) / 2, 2, 20, 2);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            title.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            category_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            Addrole_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            Addrole_button.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            category_textbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            category_textbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            category_datagridview.RowsDefaultCellStyle = new DataGridViewCellStyle() { BackColor = ColorTranslator.FromHtml("#BAE0EC") };
            back_toolstripbutton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            back_toolstripbutton.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            categories_toolstriplabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
        }

        private void category_datagridview_SelectionChanged(object sender, EventArgs e)
        {
            if (category_datagridview.SelectedRows.Count == 1 && category_datagridview.SelectedRows[0].Index != category_datagridview.Rows.Count - 1)
            {
                DataGridViewRow row = category_datagridview.SelectedRows[0];

                category_textbox.Text = row.Cells["category_name"].Value.ToString();
            }
        }

        private void addcategory_button_Click(object sender, EventArgs e)
        {
            string query = @"insert into categories(category_name)
            values (@categoryname);";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@categoryname",  category_textbox.Text)
            };
            if (DataBase.ExecuteNonQuery(query, parameters) == 1)
            {
                roles_update();
                MessageBox.Show("Категория добавлена!");
            }
            else
                MessageBox.Show("Категория не добавлена!");
        }
        private void roles_update()
        {
            string query = @"select * from categories";
            DataTable dt = DataBase.ExecuteQuery(query);
            category_datagridview.DataSource = dt;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string query = @"delete from categories
            where category_name = @categoryname";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@categoryname",  category_textbox.Text)
            };
            if (DataBase.ExecuteNonQuery(query, parameters) == 1)
            {
                roles_update();
                MessageBox.Show("Категория Удалена!");
            }
            else
                MessageBox.Show("Категория не удалена!");
        }

        private void back_toolstripbutton_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new medicine();
            this.Close();
            Program.Context.MainForm.Show();
        }
    }
}
