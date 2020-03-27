using System;
using System.Data;
using System.Data.SqlClient;
using identity.Tools;
using Microsoft.EntityFrameworkCore;
using identity.Models;
using identity.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace identity
{
	public class Security:DbContext
	{
		public DbSet<Client> Client { get; set; }
		public Security()
		{
		}

		public byte[] hashPassword(String pw)
		{

			return GetHash(pw);

		}

		public Boolean passwordCheck(string pw,string username)
		{
			string getPwd = getPassword(username);

			return (pw.CompareTo(GetHashString(getPwd)) != 0) ? true : false;
		}

		public Boolean saveToken(string token, string clientId)
		{
			using (var context = new MyDbContext())
			{
				var client = context.Clients.First(a => a.clientID == clientId);
				client.token = token;
				context.Update(client);
				context.SaveChanges();
			}
				return true;
		}

		public string getPassword(string clientID)
		{
			using (var context = new MyDbContext())
			{
				var client = context.Clients.First(a => a.clientID == clientID);
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

		public static byte[] GetHash(string inputString)
		{
			using (HashAlgorithm algorithm = SHA256.Create())
				return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
		}

		public static string GetHashString(string inputString)
		{
			StringBuilder sb = new StringBuilder();
			foreach (byte b in GetHash(inputString))
				sb.Append(b.ToString("X2"));

			return sb.ToString();
		}

	}

}