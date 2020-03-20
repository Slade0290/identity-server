using System;

namespace identity.Models
{
	public class Client
	{

		public int ID { get; set; }

		private string login { get; set; }
		private string password { get; set; }
		private string clientID { get; set; }
		private string secretID { get; set; }

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
