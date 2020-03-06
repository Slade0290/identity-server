using System;
using System.Collections.Generic;

namespace Mouyumed_COV_1920_Tintin_tin_dramatique
{

    public class IdentityServer
    {
        public IdentityServer()
        {
            init();
            /*
            config :
            dbname connection 
            fichier de migration dans la base de données user
            script qui genere un token 
            */
        }

        public void init()
        {
            Log.logger.Info("init");
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