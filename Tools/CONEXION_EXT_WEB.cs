using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace InventarioTI.Tools
{
    public class CONEXION_EXT_WEB
    {
        private string serverName = "nova1razure.cloudapp.net";
        private string databaseName = "EXT_WEB";
        private string user = "sa2";
        private string password = "4aznov-54";

        private SqlConnection conn = new SqlConnection();
        public async Task<string> GetQueryResult(string query)
        {
            conn.ConnectionString = "Data Source=" + serverName + "; Initial Catalog=" + databaseName + "; User Id=" + user + "; Password=" + password + ";";
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader reader;
            reader = await command.ExecuteReaderAsync();
            var r = Serialize(reader);
            CloseConnection();
            return JsonConvert.SerializeObject(r, Formatting.Indented);
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public IEnumerable<Dictionary<string, object>> Serialize(SqlDataReader reader)
        {
            var results = new List<Dictionary<string, object>>();
            var cols = new List<string>();
            for (var i = 0; i < reader.FieldCount; i++)
                cols.Add(reader.GetName(i));

            while (reader.Read())
                results.Add(SerializeRow(cols, reader));

            return results;
        }
        private Dictionary<string, object> SerializeRow(IEnumerable<string> cols,SqlDataReader reader)
        {
            var result = new Dictionary<string, object>();
            foreach (var col in cols)
                result.Add(col, reader[col]);
            return result;
        }
    }
}
