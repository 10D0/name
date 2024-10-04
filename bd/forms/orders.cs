using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace bd.forms
{
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
            orders_toolstriplabel.Margin = new Padding((this.Width - 80 - back_toolstripbutton.Width - orders_toolstriplabel.Width) / 2, 2, 20, 2);
            orders_update();

            toolStrip1.BackColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E5EE");
            orders_dataGridView.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#BAE0EC");
            orders_dataGridView.RowsDefaultCellStyle = new DataGridViewCellStyle() { BackColor = ColorTranslator.FromHtml("#BAE0EC") };
            orders_toolstriplabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            back_toolstripbutton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#211460");
            back_toolstripbutton.BackColor = System.Drawing.ColorTranslator.FromHtml("#9DE2F1");

        }
        private void orders_update()
        {
            string query = string.Empty;
            SqlParameter[] sqlParameters = null;
            switch (User.roleId)
            {
                case 3:
                    query = @"select * from orders";
                    break;
                case 2:
                    query = @"select * from orders where employee_id = @employer";
                    sqlParameters = new SqlParameter[]
                    {
                        new SqlParameter("@employer", User.userId)
                    };
                    break;
                case 1:
                    query = @"select * from orders where customer_id = @customer_id";
                    sqlParameters = new SqlParameter[]
                    {
                        new SqlParameter("@customer_id", User.userId)
                    };
                    break;
            }
            DataTable dt = DataBase.ExecuteQuery(query, sqlParameters);
            orders_dataGridView.DataSource = dt;
        }

        private void back_toolstripbutton_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new medicine();
            this.Close();
            Program.Context.MainForm.Show();
        }
    }
}