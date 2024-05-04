using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace zaro.Classes
{
    internal static class connectDatabase
    {
        private static IFirebaseConfig config;
        public static void databaseConnection()
        {
            config = new FirebaseConfig()
            {
                AuthSecret = "dqPeuKE3qP2ptlvJAubc2tyRpbLaHRm0H90FceKF",
                BasePath = "https://zaro-b91c3-default-rtdb.firebaseio.com/"
            };
        }
        public static IFirebaseClient client = new FireSharp.FirebaseClient(config);
    }
}
