using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;

namespace zaro.Classes
{
    internal class FbAuth
    {
        private const string API_KEY = "AIzaSyD65Q-h6yVWJrQ2pQ7L57U_lkpxzMPwHMo";
        public static FirebaseAuthClient firebaseAuth;

        private void InitializeFirebase()
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("\"C:\\Users\\sang\\Downloads\\zaro-b91c3-firebase-adminsdk-qc9m1-08ea7c401f.json\"")
            });
        }
    }
}