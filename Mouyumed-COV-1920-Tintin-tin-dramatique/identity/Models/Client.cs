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
		public Boolean isAuthorize { get; set; }

		public Client()
		{

		}
	}
}
