using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Data.SqlClient;

namespace identity
{
	public class Database : IMigrationsAssembly
	{
		private SqlConnection connection;

		public IReadOnlyDictionary<string, TypeInfo> Migrations => throw new NotImplementedException();

		public ModelSnapshot ModelSnapshot => throw new NotImplementedException();

		public Assembly Assembly => throw new NotImplementedException();

		ModelSnapshot IMigrationsAssembly.ModelSnapshot => throw new NotImplementedException();

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

		public string FindMigrationId(string nameOrId)
		{
			throw new NotImplementedException();
		}

		public Migration CreateMigration(TypeInfo migrationClass, string activeProvider)
		{
			throw new NotImplementedException();
		}
	}
}
