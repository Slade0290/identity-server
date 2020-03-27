using System;
using System.Data;
using System.Data.SqlClient;
using identity.Tools;
using Microsoft.EntityFrameworkCore;
using identity.Models;
using identity.Data;
using System.Linq;

namespace identity
{
	public class Security:DbContext
	{
		public DbSet<Client> Client { get; set; }
		public Security()
		{
		}

		public int hashPassword(String pw)
		{

			return pw.GetHashCode();

		}

		public Boolean passwordCheck(string pw,string username)
		{
			int testPwd = hashPassword(pw);
			string getPwd = getPassword(username);

			return (testPwd.CompareTo(getPwd) != 0) ? true : false;
		}

		public Boolean saveToken(string token, string username)
		{
			using (var context = new MyDbContext())
			{
				var client = context.Clients.First(a => a.login == username);
				client.token = token;
				context.Update(client);
				context.SaveChanges();
			}
				return true;
		}

		public string getPassword(string username)
		{
			using (var context = new MyDbContext())
			{
				var client = context.Clients.First(a => a.login == username);
				return client.password;
			}
			
		}

		public string createToken(int size)
		{
			return TokenGenerator.Generate(size);
		}

		

		public void tokenRefresh(string username)
		{
			saveToken(createToken(ConstVariable.TOKEN_LENGHT), username);
			
		}

		public string generateSecretID()
		{
			return "";
		}

	}

}