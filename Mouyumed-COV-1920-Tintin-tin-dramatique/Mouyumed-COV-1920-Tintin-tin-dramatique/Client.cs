using System;

namespace Mouyumed_COV_1920_Tintin_tin_dramatique
{
	public class Client
	{
		private string login { get; set; }
		private string password { get; set; }
		private string clientID { get; set; }
		private string secretID { get; set; }


		public Client(string login, string password)
		{
			this.login = login;
			this.password = password;
		}

		public Client(string clientID)
		{
			this.clientID = clientID;
			this.secretID = new Security().generateSecretID();
		}
	}
}
