using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo123
{
    public static class Storage
    {
        public static string token = "";

        public static void setToken(string token)
        {
            Storage.token = token;
        }

        public static string getToken()
        {
            return token;
        }
    }
}