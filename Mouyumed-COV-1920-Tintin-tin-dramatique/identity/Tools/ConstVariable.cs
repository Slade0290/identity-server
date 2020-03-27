using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity.Tools
{
    public static class ConstVariable
    {
        public static int TOKEN_LENGHT = 40;
        public static string CONNEXION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lydav\Desktop\git-repo\identity-server\Mouyumed-COV-1920-Tintin-tin-dramatique\identity\Data\Database1.mdf;Integrated Security=True";

        public static void setConnexionString(String cs)
        {
            CONNEXION_STRING = cs;
        }
    }
}
