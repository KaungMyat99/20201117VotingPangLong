using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _20201117VotingPangLong.Common
{
    public class Common
    {
    }

    public class SqlProcedureString
    {
       public const string SP_InsertVoteType = "SP_InsertVoteType";
    }

    public static class IsDBNullClass
    {
        public static string IsDBNull(string l_colName,DataRow dr)
        {
            try
            {
                if (!dr.Table.Columns.Contains(l_colName)) return string.Empty;
                object value = dr[l_colName];
                if (value.Equals(DBNull.Value)) return string.Empty;
                return value == null ? string.Empty : Convert.ToString(value);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int IsDBNullReturnInt(string l_colName, DataRow dr)
        {
            try
            {
                if (!dr.Table.Columns.Contains(l_colName)) return 0;
                Object value = dr[l_colName];
                if (value.Equals(DBNull.Value)) return 0;
                return value == null ? 0 : Convert.ToInt32(value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return 0;
            }

        }
    }
}
namespace _20201117VotingPangLong.SqlConnector
{
    public class SqlConnectcor
    {
        public static SqlConnectionStringBuilder StrConn
        {
            get
            {
                return new SqlConnectionStringBuilder()
                {
                    DataSource = ".",
                    InitialCatalog = "20201117VotingPangLong",
                    UserID = "sa",
                    Password = "sasa"
                };
            }
        }

        public static SqlConnection Conn { get; set; }

        public static SqlConnection Connect()
        {
            if(Conn!=null && Conn.State== System.Data.ConnectionState.Open)
            {
                return Conn;
            }
            Conn = new SqlConnection(StrConn.ConnectionString);
            return Conn;
        }

        public static void DisConnect()
        {
            if(Conn!=null && Conn.State==System.Data.ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        public static DataSet ExecuteDataSet(String query,CommandType commandType,params SqlParameter [] sqlParameters)
        {
            SqlCommand cmd = new SqlCommand(query, Connect());
            cmd.CommandType = commandType;
            if(sqlParameters.Length>0)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            return ds;
        }
        public static SqlParameter GetSqlParameter(string Key, object Value)
        {
            return new SqlParameter(Key, Value);
        }
    }
}