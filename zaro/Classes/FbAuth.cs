using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace zaro.Classes
{
    internal class FbAuth
    {
        public static FirebaseAuthConfig config = new FirebaseAuthConfig
        {
            ApiKey = "AIzaSyD65Q-h6yVWJrQ2pQ7L57U_lkpxzMPwHMo",
            AuthDomain = "zaro-b91c3.firebaseapp.com",
            Providers = new FirebaseAuthProvider[]
            {
                new GoogleProvider().AddScopes("email"),
                new EmailProvider()
            },
            UserRepository = new FileUserRepository("FirebaseSample")
        };
        public static FirebaseAuthClient authClient;

        public static void Initialize()
        {

            authClient = new FirebaseAuthClient(config);
        }

    }
}
