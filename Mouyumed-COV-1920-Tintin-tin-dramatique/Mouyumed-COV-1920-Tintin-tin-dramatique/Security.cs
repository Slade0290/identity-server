using System;

namespace Mouyumed_COV_1920_Tintin_tin_dramatique
{
	public class Security
	{
		public Security()
		{
		}

		public string hashPassword(string pw)
		{

		}

		public Boolean passwordCheck(string pw)
		{

		}

		public string getPassword()
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