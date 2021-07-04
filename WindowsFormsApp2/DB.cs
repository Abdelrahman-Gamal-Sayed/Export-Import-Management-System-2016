using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp2
{
    class DB
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Company.mdf"";Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

       public void SetCommand (string SQLStatement)
        {
            cmd.Connection = conn;
            cmd.CommandText = SQLStatement;
        }

        public bool RunNonQuery(string SQLStatement , string Message="")
        {
            try
            {
                SetCommand(SQLStatement);
                conn.Open();
                cmd.ExecuteNonQuery();
                if (Message != "")
                    MessageBox.Show(Message);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable RunReader(string Selectstatement)
        {
            DataTable tbl = new DataTable();
            SetCommand(Selectstatement);
            conn.Open();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            return tbl;
        }
    }
}
