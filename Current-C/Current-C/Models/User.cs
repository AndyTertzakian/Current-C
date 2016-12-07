using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Current_C.Models
{
    public class User
    {
        public string Username
        {
            get;
            private set;
        }

        public DateTime? DOB
        {
            get;
            private set;
        }

        public User(string username, DateTime? dob = null)
        {
            if (username == null)
                throw new ArgumentNullException();

            Username = username;
            DOB = dob;
        }

        public void SaveUser()
        {
            // TODO: implement this
        }
    }
}
