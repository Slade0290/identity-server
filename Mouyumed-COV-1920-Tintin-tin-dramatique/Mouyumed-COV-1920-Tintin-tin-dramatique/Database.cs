using System;
using System.Data;
using System.Data.SqlClient;

namespace Mouyumed_COV_1920_Tintin_tin_dramatique
{
	public class Database
	{
		private SqlConnection connection;
		public Database(string datasource, string userid, string pwd, string table)
		{
			init(datasource, userid, pwd, table);
		}

		public void init(string datasource, string userid, string pwd, string table)
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.DataSource = datasource;
			builder.UserID = userid;
			builder.Password = pwd;
			builder.InitialCatalog = table;
			this.connection = new SqlConnection(builder.ConnectionString);
		}

		public SqlConnection connect()
		{
			return this.connection;
		}
	}
}
