using System;

namespace identity.Models
{
	public class Client
	{

		public int ID { get; set; }
		public string login { get; set; }
		public string password { get; set; }
		public string clientID { get; set; }
		public string secretID { get; set; }

		public string token { get; set; }

		public Client()
		{

		}

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
