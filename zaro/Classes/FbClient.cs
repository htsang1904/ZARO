using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaro.Classes
{
    internal class FbClient
    {
        public static string base_path { get; private set; } = "https://zaro-b91c3-default-rtdb.firebaseio.com/";
        public static IFirebaseClient FsharpClient { get; private set; }
        public static Firebase.Database.FirebaseClient FClient { get; private set; } = new Firebase.Database.FirebaseClient(base_path);
        public static void Initialize()
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "dqPeuKE3qP2ptlvJAubc2tyRpbLaHRm0H90FceKF",
                BasePath = base_path
            };

            FsharpClient = new FireSharp.FirebaseClient(config);
        }
    }
}
