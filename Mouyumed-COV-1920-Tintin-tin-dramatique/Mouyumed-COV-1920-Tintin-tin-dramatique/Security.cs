using System;
using System.Data;
using System.Data.SqlClient;

namespace Mouyumed_COV_1920_Tintin_tin_dramatique
{
	public class Security
	{
		public Security()
		{
		}

		public string hashPassword(string pw)
		{
			return pw.GetHashCode();
		}

		public Boolean passwordCheck(string pw,string username)
		{
			string testPwd = hashPassword(pw);
			string getPwd = getPassword(username);

			return Compare(testPwd, getPwd);
		}

		public Boolean saveToken(string token,string pw , string username)
		{

		}

		public string getPassword(string username)
		{

		}

		public string createToken(int size)
		{
			return TokenGenerator.Generate(size);
		}

		public Boolean tokenIsExpirated()
		{

		}

		public void tokenRefresh()
		{

		}
	}

}