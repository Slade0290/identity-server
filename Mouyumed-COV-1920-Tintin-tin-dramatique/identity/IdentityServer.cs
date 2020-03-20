using Mouyumed_COV_1920_Tintin_tin_dramatique.Models;
using System;
using System.Collections.Generic;

namespace Mouyumed_COV_1920_Tintin_tin_dramatique
{

    public class IdentityServer
    {
        public IdentityServer(Boolean withDb = true)
        {
            if (withDb) init();
            else initWithoutDB();
            /*
            config :
            dbname connection 
            fichier de migration dans la base de données user
            script qui genere un token 
            */
        }

        public void init()
        {
            Security secu = new Security();
            string token = secu.createToken(ConstVariable.TOKEN_LENGHT);

            secu.saveToken(token, "name");
        }

        public void initWithoutDB()
        {

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