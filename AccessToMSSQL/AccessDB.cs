using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace AccessToMSSQL
{
    public class AccessDB
    {
        private static OleDbConnection connectAccess = new OleDbConnection(); // point connection to MS Access

        public async static Task<bool> CheckConnection(string path)
        {
            bool result = true;
            if (path.Contains(".mdb"))
                connectAccess.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Persist Security Info = False;";
            else if (path.Contains(".accdb"))
                connectAccess.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info = False;";
            else
                result = false;
            try
            {
                await connectAccess.OpenAsync();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public async static void Open()
        {
            if (connectAccess.State == ConnectionState.Closed)
                await connectAccess.OpenAsync();
            else
            {
                connectAccess.Close();
                await connectAccess.OpenAsync();
            }
        }
        public static void Close()
        {
            if (connectAccess.State == ConnectionState.Open)
                connectAccess.Close();
        }

        public static List<string> GetAllTables()
        {
            List<string> tables = new List<string>();
            try
            {
                DataTable dt = new DataTable();
                dt = connectAccess.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                foreach (DataRow row in dt.Rows)
                {
                    tables.Add(row["TABLE_NAME"].ToString());
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (tables.Count == 0)
                return null;
            return tables;
        }

        public static DataTable GetTable(string nameTable, bool data = false)
        {

            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT * FROM " + nameTable;
                OleDbCommand command = new OleDbCommand(query, connectAccess);
                if (data == false)
                {
                    OleDbDataReader reader = command.ExecuteReader();
                    dt = reader.GetSchemaTable();
                }
                else
                {
                    string queryCount = "SELECT COUNT(*) FROM " + nameTable;
                    command = new OleDbCommand(queryCount, connectAccess);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectAccess);
                        adapter.Fill(dt);
                    }
                    else
                        dt = null;
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
