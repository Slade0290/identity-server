using System;
using System.Linq;
using identity.Data;
using identity.Models;

namespace identity
{
    public class Server : MyDbContext
    {
        public Server()
        {
            
        }

        public void addClientToDB(Client c)
        {
            using (var context = new MyDbContext())
            {
                context.Clients.Add(c);
            }
        }

        public bool clientIsInDatabase(string id)
        {
            bool isPresent = false;
            try
            {
                Client c = null;
                using (var context = new MyDbContext())
                {
                    c = context.Clients.First(a => a.clientID == id);
                }
                if (c != null)
                {
                    isPresent = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return isPresent;
        }

        public string getToken(string id)
        {
            string token = "";

            using (var context = new MyDbContext())
            {
                var client = context.Clients.First(a => a.clientID == id);
                client.token = token;
            }
            return token;
        }

        public bool getAuthorization(string id)
        {
            bool isAuthorize = false;

            using (var context = new MyDbContext())
            {
                var client = context.Clients.First(a => a.clientID == id);
                client.isAuthorize = isAuthorize;
            }
            return isAuthorize;
        }
    }

}