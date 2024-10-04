using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace bd.forms
{
    public partial class medicine : Form
    {
        public medicine()
        {
            InitializeComponent();
            Categories_toolstripbutton.Visible = User.roleId != 3 ? false : true;
            Users_toolstripbutton.Visible = User.roleId != 3 ? false : true;
            toolStrip1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            dataGridView1.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");

            dataGridView1.RowsDefaultCellStyle = new DataGridViewCellStyle() { BackColor = ColorTranslator.FromHtml("#BAE0EC") };

            Categories_toolstripbutton.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            Categories_toolstripbutton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            profile_toolstripbutton.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            profile_toolstripbutton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            Users_toolstripbutton.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            Users_toolstripbutton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            toolStripButton1.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            toolStripButton1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            cart_toolstripbutton.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            cart_toolstripbutton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            Categories_toolstripcombobox.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            Categories_toolstripcombobox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            


            string query = "select category_id, category_name from categories";
            DataTable dataTable = DataBase.ExecuteQuery(query);
            int quantity = 0;
            foreach (medicinedrug md in orderlist.Orderlist)
            {
                quantity += md.quantity;
            }
            toolStripLabel1.Text = quantity.ToString();
            if (dataTable.Rows.Count > 0)
            {
                string[] available_roles = new string[dataTable.Rows.Count];
                //добавление всех найденных категорий в combobox
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    //Categories_toolstripcombobox.Items.Add(dataTable.Rows[i]["category_name"].ToString());
                    //
                    Categories_toolstripcombobox.Items.Add(new KeyValuePair<int, string>((int)dataTable.Rows[i]["category_id"], dataTable.Rows[i]["category_name"].ToString()));
                    //Categories_toolstripcombobox.ValueMember = "Key";
                    //Categories_toolstripcombobox.DisplayMember = "Value";
                }
                foreach (var item in Categories_toolstripcombobox.Items)
                {
                    var kvp = (KeyValuePair<int, string>)item;
                    if (kvp.Key == 1)
                    {
                        Categories_toolstripcombobox.SelectedItem = item;
                        return;
                    }
                }
                Category_toolstriplabel.Text = Categories_toolstripcombobox.Text;
            }
            


            loadmedicines();
            dataGridView1.RowHeadersDefaultCellStyle = new DataGridViewCellStyle() { BackColor = ColorTranslator.FromHtml("#BAE0EC") };
            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle() { BackColor = ColorTranslator.FromHtml("#BAE0EC") };
        }
        private void loadmedicines()
        {
            string query = "SELECT medicine_id, preview, medicine_name, category_id, quantity, price, discription FROM medicine";
            if (((KeyValuePair<int, string>)Categories_toolstripcombobox.SelectedItem).Key != 1)
            {
                query += " WHERE category_id = @CategoryId";
            }
            SqlParameter[] parameters = ((KeyValuePair<int, string>)Categories_toolstripcombobox.SelectedItem).Key != 1
            ? new SqlParameter[] { new SqlParameter("@CategoryId", ((KeyValuePair<int, string>)Categories_toolstripcombobox.SelectedItem).Key) }
            : null;
            DataTable dataTable = DataBase.ExecuteQuery(query,parameters);

            // Преобразование данных для отображения изображений
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["preview"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["preview"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        try
                        {
                            row["preview"] = Image.FromStream(ms);
                        }
                        catch 
                        {
                            
                        }
                    }
                }
            }
            if (dataGridView1.Columns["preview"] is DataGridViewImageColumn previewColumn)
            {
                previewColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
                //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            if (dataGridView1.Columns["discription"] is DataGridViewImageColumn discriptionColumn)
            {
                //discriptionColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                discriptionColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                //discriptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView1.RowTemplate.Height = 100;

            dataGridView1.DataSource = dataTable;

        }

        private void profile_toolstripbutton_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new profile();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void Categories_toolstripbutton_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new categories();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void cart_toolstripbutton_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new order();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void Users_toolstripbutton_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new users();
            this.Close();
            Program.Context.MainForm.Show();
        }
        private void Categories_toolstripcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category_toolstriplabel.Text = Categories_toolstripcombobox.Text;
            loadmedicines();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new orders();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Program.Context.MainForm = new drug((int)row.Cells["medicine_id"].Value);
                this.Close();
                Program.Context.MainForm.Show();
            }
        }
    }
}
