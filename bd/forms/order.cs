using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace bd.forms
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            orders_update();
            orders_dataGridView.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            orders_dataGridView.RowsDefaultCellStyle = new DataGridViewCellStyle() { BackColor = ColorTranslator.FromHtml("#BAE0EC") };
            commet_richtextbox.BackColor =System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            commet_richtextbox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            comment_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            back_toolstripbutton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            back_toolstripbutton.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");
            order_button.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            order_button.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");

        }
        private void InitializeDataGridView()
        {
            // Добавляем столбцы в DataGridView
            orders_dataGridView.Columns.Add("Id", "ID");
            orders_dataGridView.Columns.Add("Quantity", "Quantity");
            orders_dataGridView.Columns.Add("Price", "Price");

            // Добавляем столбец с кнопкой "Добавить"
            DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn();
            addButtonColumn.Name = "AddButton";
            addButtonColumn.HeaderText = "Add";
            addButtonColumn.Text = "Add";
            addButtonColumn.UseColumnTextForButtonValue = true;
            orders_dataGridView.Columns.Add(addButtonColumn);

            // Добавляем столбец с кнопкой "Убрать"
            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
            removeButtonColumn.Name = "RemoveButton";
            removeButtonColumn.HeaderText = "Remove";
            removeButtonColumn.Text = "Remove";
            removeButtonColumn.UseColumnTextForButtonValue = true;
            orders_dataGridView.Columns.Add(removeButtonColumn);

            // Обработка события нажатия кнопки
            orders_dataGridView.CellClick += orders_dataGridView_CellClick;

            toolStrip1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            orders_dataGridView.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
        }
        private void orders_update()
        {
            if (orders_dataGridView.Columns.Count == 0)
            {
                InitializeDataGridView();
            }
            var orderList = orderlist.GetOrderList();
            orders_dataGridView.Rows.Clear();

            foreach (var drug in orderList)
            {
                orders_dataGridView.Rows.Add(drug.id, drug.quantity, drug.price);
            }
        }
        private void orders_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == orders_dataGridView.Columns["AddButton"].Index)
                {
                    // Обработка нажатия кнопки "Добавить"
                    int id = (int)orders_dataGridView.Rows[e.RowIndex].Cells["Id"].Value;
                    orderlist.AddQuantity(id, 1);
                    orders_update();
                }
                else if (e.ColumnIndex == orders_dataGridView.Columns["RemoveButton"].Index)
                {
                    // Обработка нажатия кнопки "Убрать"
                    int id = (int)orders_dataGridView.Rows[e.RowIndex].Cells["Id"].Value;
                    orderlist.RemoveQuantity(id, 1);
                    orders_update();
                }
            }
        }
        private void back_toolstripbutton_Click(object sender, System.EventArgs e)
        {
            Program.Context.MainForm = new medicine();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void order_button_Click(object sender, System.EventArgs e)
        {
            string query = "SELECT TOP 1 branch_id, employee_id FROM branches ORDER BY NEWID();";
            DataTable result = DataBase.ExecuteQuery(query);
            int id = 0, employee_id = 0;
            if (result.Rows.Count > 0)
            {
                id = (int)result.Rows[0]["branch_id"];
                employee_id = (int)result.Rows[0]["employee_id"];
            }
            else
            {
                throw new Exception("No branches found.");
            }
            foreach (medicinedrug meddrug in orderlist.Orderlist)
            {
                query = @"INSERT INTO orders (medicine_id, quantity, order_status, branch_id, order_date, customer_id, employee_id, sum, notes) VALUES
                        (@id, @quantity,@order_status, @branch_id, @date, @customer_id, @employee_id, @sum, @comment)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@id",  meddrug.id),
                    new SqlParameter("@quantity",  meddrug.quantity),
                    new SqlParameter("@order_status",  "В процессе"),
                    new SqlParameter("@branch_id",  id),
                    new SqlParameter("@date",DateTime.Now.ToString("d")),
                    new SqlParameter("@customer_id",User.userId),
                    new SqlParameter("@employee_id",employee_id),
                    new SqlParameter("@sum", meddrug.price*meddrug.quantity),
                    new SqlParameter("@comment",commet_richtextbox.Text)
                };
                if( DataBase.ExecuteNonQuery(query, parameters) != 1)
                {
                    MessageBox.Show("Ошибка сформирования заказа!");
                    return;
                }
            }
            MessageBox.Show("Заказ успешно сформирован!");
            Program.Context.MainForm = new medicine();
            this.Close();
            Program.Context.MainForm.Show();
        }
    }
}
