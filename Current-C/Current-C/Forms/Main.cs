/*
 *
 *Author: Andre Tertzakian
 *  Date: December, 2016 
 * 
 */

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Current_C.Utility;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Serialization.ServiceStack;
using FireSharp.Serialization.JsonNet;
using FireSharp;
using FireSharp.Response;
using System.Configuration;
using Current_C.Views;
using Current_C.Presenters;
using Current_C.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Drive.v3;
using System.Threading;
using Google.Apis.Util.Store;

namespace Current_C
{
    public partial class Main : Form, IMainView
    {
        //Fields
        private MainPresenter Presenter { get; set; }

        public string Username { get; set; }

        public DateTime? DOB { get; set; }

        //Handlers
        public event EventHandler Initialize;
        public event EventHandler SaveUser;

        public Main()
        {
            Presenter = new MainPresenter(this);

            InitializeComponent();

            InvokeInitialize(new EventArgs());
        }

        private void InvokeInitialize(EventArgs eventArgs)
        {
            Initialize?.Invoke(this, eventArgs);
        }

        private async void label1_Click(object sender, EventArgs e)
        {
            label1.Text = (InternetUtility.InternetConnected()) ? "Connected" : "Not Connected";

            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "hzTI7r7vll3gXZyQg78GKTgKGEo32aQ8sSK1zImB",
                BasePath = "https://current-c.firebaseio.com/"
            };

            IFirebaseClient client = new FirebaseClient(config);

            var todo = new Models.User("Andy", new DateTime(1996, 2, 16));

            PushResponse response = await client.PushAsync("todos/set", todo);
            string tes1t = response.Result.name;
        }


    }
}
