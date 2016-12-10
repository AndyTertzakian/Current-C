using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.EventStreaming;
using FireSharp.Response;

namespace Current_C.Utility
{
    //Singleton Class
    public sealed class FirebaseUtility 
    {
        private static IFirebaseClient FirebaseClientInstance = null;
        private FirebaseUtility() { }
        public static IFirebaseClient getInstance()
        {
            return FirebaseClientInstance;
        }
    }
}
