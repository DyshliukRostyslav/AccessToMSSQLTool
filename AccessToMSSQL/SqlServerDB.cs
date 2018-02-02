using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AccessToMSSQL
{
    public class SqlServerDB
    {
        private static SqlConnection connectSqlServer = new SqlConnection(); // point connection to SQL Server

        public async static Task<bool> CheckConnection(string connectionString)
        {
            bool result = true;
            connectSqlServer.ConnectionString = connectionString;
            try
            {
                await connectSqlServer.OpenAsync();
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                connectSqlServer.Close();
            }
            return result;
        }

        public async static void Open()
        {
            if (connectSqlServer.State == ConnectionState.Closed)
                await connectSqlServer.OpenAsync();
        }
        public static void Close()
        {
            if (connectSqlServer.State == ConnectionState.Open)
                connectSqlServer.Close();
        }

        public static List<string> GetTableMS()
        {
            List<string> tables = new List<string>();
            try
            {
                DataTable dt = connectSqlServer.GetSchema("DataBases");
                foreach (DataRow row in dt.Rows)
                {
                    tables.Add(row["database_name"].ToString());
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return tables;
        }

        public static bool CreateDB(string name)
        {
            string query = @"CREATE DATABASE " + name + ";";
            bool result = true;
            try
            {
                SqlCommand command = new SqlCommand(query, connectSqlServer);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                result = false;
            }
            return result;
        }

        private static List<List<string>> GetSqlDataFromTable(DataTable table)
        {
            if (table == null)
                return null;
            List<List<string>> datasql = new List<List<string>>();
            foreach (DataRow row in table.Rows)
            {
                List<string> data = new List<string>();
                foreach (DataColumn dc in table.Columns)
                {
                    data.Add(row[dc].ToString());
                }
                datasql.Add(data);
            }
            return datasql;
        }

        private static string ConvertType(string accessType)
        {
            string type = accessType.Substring(accessType.IndexOf('.') + 1, accessType.Length - accessType.IndexOf('.') - 1);
            switch (type)
            {
                case "Int32":
                    return "INT";
                case "Int16":
                    return "SMALLINT";
                case "String":
                    return "NVARCHAR(MAX)";
                case "Boolean":
                    return "BIT";
                case "DateTime":
                    return "DATETIME";
                case "Decimal":
                    return "DECIMAL(18,0)";
                case "Byte":
                    return "BINARY(50)";
                case "Double":
                    return "FLOAT";
                case "Guid":
                    return "UNIQUEIDENTIFIER";
                case "Single":
                    return "REAL";
                default:
                    return "NVARCHAR(MAX)";
            }
        }

        private static string GetSqlFromRow(DataRow row, bool data = false)
        {
            if (data == true)
                return row["ColumnName"].ToString();
            string query = "[" + row["ColumnName"].ToString() + "]";
            query += " " + ConvertType(row["DataType"].ToString());
            query += " NULL";
            return query;
        }

        private static string GetQueryInsertData(string nameTable)
        {
            DataTable dt = AccessDB.GetTable(nameTable, true);
            if (dt == null)
                return null;
            DataTable schemaDt = AccessDB.GetTable(nameTable);
            List<List<string>> data = GetSqlDataFromTable(dt);
            string query = "";

            query += "INSERT INTO " + nameTable + "(";
            foreach (DataRow row in schemaDt.Rows)
            {
                query += GetSqlFromRow(row, true) + ", ";
            }
            query = query.Substring(0, query.Length - 2) + ")" + "VALUES ";
            foreach (List<string> list in data)
            {
                query += "(";
                foreach (string cell in list)
                {
                    query += "'" + cell + "', ";
                }
                query = query.Substring(0, query.Length - 2) + "), ";
            }
            query = query.Substring(0, query.Length - 2);
            return query;
        }

        private static string GetSqlQueryFromTable(string nameTable)
        {
            DataTable dt = AccessDB.GetTable(nameTable);
            string query = "CREATE TABLE " + "dbo." + nameTable + " ( ";
            foreach (DataRow row in dt.Rows)
            {
                query += GetSqlFromRow(row) + ",";
            }
            query = query.Substring(0, query.Length - 1);
            query += " );";
            return query;
        }

        private static string CreateQuery(string tableName, bool data)
        {
            string sqlQuery = GetSqlQueryFromTable(tableName);
            string sqlData = GetQueryInsertData(tableName);
            if (sqlData != null && data == true)
                return sqlQuery + Environment.NewLine + sqlData;
            else
                return sqlQuery;
        }
        public async static Task<bool> ImportToSqlServer(List<string> tables, bool data, string database, ProgressBar progressBar)
        {
            string query = string.Empty;
            bool result = true;
            try
            {
                SqlCommand command = new SqlCommand(query, connectSqlServer);
                foreach (string table in tables)
                {
                    query = "Use [" + database + "]" + Environment.NewLine;
                    try
                    {
                        SqlBulkCopy bulkData = new SqlBulkCopy(connectSqlServer);
                        query += CreateQuery(table, false) + Environment.NewLine;
                        command.CommandText = query;
                        //command.ExecuteNonQuery();
                        await command.ExecuteNonQueryAsync();
                        bulkData.DestinationTableName = "dbo." + table;
                        if (AccessDB.GetTable(table, true) != null)
                            await bulkData.WriteToServerAsync(AccessDB.GetTable(table, true));
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        progressBar.PerformStep();
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            return result;
        }
    }
}
