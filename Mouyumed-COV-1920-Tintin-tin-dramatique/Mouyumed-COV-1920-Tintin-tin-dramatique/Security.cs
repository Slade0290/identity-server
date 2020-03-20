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

		public int hashPassword(String pw)
		{

			return pw.GetHashCode();

		}

		public Boolean passwordCheck(string pw,string username)
		{
			int testPwd = hashPassword(pw);
			int getPwd = getPassword(username);

			return (testPwd.CompareTo(getPwd) != 0) ? true : false;
		}

		public Boolean saveToken(string token, string username)
		{

			/*System.Data.SqlClient.SqlConnection sqlConnection1 =
			new System.Data.SqlClient.SqlConnection("YOUR CONNECTION STRING");

			System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
			cmd.CommandType = System.Data.CommandType.Text;
			cmd.CommandText = "UPDATE User (Username,TOKEN ) VALUES (@username, @token)";
			cmd.Connection = sqlConnection1;

			sqlConnection1.Open();
			cmd.ExecuteNonQuery();
			sqlConnection1.Close();*/
			return true;
		}

		public int getPassword(string username)
		{
			/*int pwd = 0;
			System.Data.SqlClient.SqlConnection sqlConnection1 =
			new System.Data.SqlClient.SqlConnection("YOUR CONNECTION STRING");

			System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
			cmd.CommandType = System.Data.CommandType.Text;
			cmd.CommandText = "Select password FROM USER WHERE username = @usename";
			cmd.Connection = sqlConnection1;

			sqlConnection1.Open();
			cmd.ExecuteNonQuery();
			sqlConnection1.Close();
			return pwd;*/
			return 01;
		}

		public string createToken(int size)
		{
			return TokenGenerator.Generate(size);
		}

		public Boolean tokenIsExpirated()
		{
			/*System.Data.SqlClient.SqlConnection sqlConnection1 =
			new System.Data.SqlClient.SqlConnection("YOUR CONNECTION STRING");

			System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
			cmd.CommandType = System.Data.CommandType.Text;
			cmd.CommandText = "Select tokenDateLimite FROM USER WHERE username = @usename";
			cmd.Connection = sqlConnection1;

			sqlConnection1.Open();
			cmd.ExecuteNonQuery();
			sqlConnection1.Close();


			//DateTime d1 = DateTime.Now; 
			//d2 = Date in base
			//DateTime.Compare(d1, d2)
			return (DateTime.Compare(d1, d2)>=0)?true:false;*/
			return true;

		}

		public void tokenRefresh()
		{
			createToken(ConstVariable.TOKEN_LENGHT);
		}

		public string generateSecretID()
		{
			return "";
		}

	}

}