using System;

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

	public Client(string clientID, string secretID)
	{
		this.clientID = clientID;
		this.secretID = secretID;
	}
}
