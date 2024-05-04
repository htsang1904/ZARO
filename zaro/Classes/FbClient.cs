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
        public static IFirebaseClient Client { get; private set; }

        public static void Initialize()
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "dqPeuKE3qP2ptlvJAubc2tyRpbLaHRm0H90FceKF",
                BasePath = "https://zaro-b91c3-default-rtdb.firebaseio.com/"
            };

            Client = new FirebaseClient(config);
        }
    }
}
