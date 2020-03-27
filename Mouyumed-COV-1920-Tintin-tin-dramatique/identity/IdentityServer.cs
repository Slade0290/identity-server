using identity;
using identity.Models;
using identity.Tools;
using System;
using System.Collections.Generic;

namespace Mouyumed_COV_1920_Tintin_tin_dramatique
{

    public class IdentityServer
    {
        public IdentityServer()
        {

        }

        public void init()
        {
            Security secu = new Security();
            string token = secu.createToken(ConstVariable.TOKEN_LENGHT);

            secu.saveToken(token, "name");
        }

        public void clientAddress(string url)
        {

        }

        public void addClientList(List<Client> clientList)
        {
            
        }

        public void addAPIServer()
        {

        }

    }

}