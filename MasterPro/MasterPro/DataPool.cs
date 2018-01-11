using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPro
{
    class DataPool
    {
        String connectionString = "server=Kwongtai-PC;database=MasterSQL;integrated security=SSPI";
        SqlCommand command;
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet dataSet;

        public bool CommandExe(string comm)
        {
            bool result = false;
            int i;
            conn = new SqlConnection(connectionString);
            command = new SqlCommand(comm, conn);
            conn.Open();
            i = command.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
                result = true;
            return result;

        }

        public DataSet GetData(string sql, string tableName)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                command = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter(command);
                dataSet = new DataSet();
                adapter.Fill(dataSet, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return dataSet;
        }
    }
}
