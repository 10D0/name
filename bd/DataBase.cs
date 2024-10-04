using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace bd
{
    static public class User
    {
        private static int Roleid = -1;
        private static int Userid = -1;
        public static int roleId
        {
            set { Roleid = value; }
            get { return Roleid; }
        }
        public static int userId
        {
            set { Userid = value; }
            get { return Userid; }
        }
    }
    static public class orderlist
    {
        static public List<medicinedrug> Orderlist;

        static orderlist()
        {
            Orderlist = new List<medicinedrug>();
        }

        static public void Add(medicinedrug drug)
        {
            if (Orderlist == null)
                Orderlist = new List<medicinedrug>();

            // Проверяем, есть ли уже такой товар в корзине
            var existingDrug = Orderlist.FirstOrDefault(d => d.id == drug.id);
            if (existingDrug != null)
            {
                existingDrug.quantity += drug.quantity;
            }
            else
            {
                Orderlist.Add(drug);
            }
        }

        static public void Remove(int id)
        {
            if (Orderlist == null)
                return;

            var drug = Orderlist.FirstOrDefault(d => d.id == id);
            if (drug != null)
            {
                Orderlist.Remove(drug);
            }
        }

        static public void AddQuantity(int id, int quantity)
        {
            if (Orderlist == null)
                return;

            var drug = Orderlist.FirstOrDefault(d => d.id == id);
            if (drug != null)
            {
                drug.quantity += quantity;
            }
        }

        static public void RemoveQuantity(int id, int quantity)
        {
            if (Orderlist == null)
                return;

            var drug = Orderlist.FirstOrDefault(d => d.id == id);
            if (drug != null)
            {
                drug.quantity -= quantity;
                if (drug.quantity <= 0)
                {
                    Orderlist.Remove(drug);
                }
            }
        }

        static public List<medicinedrug> GetOrderList()
        {
            return Orderlist;
        }
    }

    public class medicinedrug
    {
        public int id;
        public int quantity;
        public float price;

        public medicinedrug(int id, int quantity, float price)
        {
            this.id = id;
            this.quantity = quantity;
            this.price = price;
        }
    }


    static internal class DataBase
    {
        private const string connect = @"Data Source=ADCLG1; Initial catalog=♥♦♣♠; Integrated Security=True";
        //private const string connect = @"Data Source=DESKTOP-RGQAQC1\SQLSERVER; Initial catalog=♥♦♣♠; Integrated Security=True";
        static SqlConnection sqlConnection = new SqlConnection(connect);

        static public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }
        static public void CloseConnection()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    OpenConnection();
                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                OpenConnection();
                return command.ExecuteScalar();
            }
        }
    }
}