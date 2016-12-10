using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Current_C.Views;
using Current_C.Models;
using Google.Apis.Plus.v1;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System.Threading;
using Google.Apis.Services;

namespace Current_C.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {
        // TODO: Create data models 
        private User _User { get; set; }

        public MainPresenter(IMainView view) : base(view)
        {
            //if (user == null)
            //    throw new ArgumentNullException();

        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);

            View.Username = "Please enter your username";
            View.DOB = null;

            View.SaveUser += View_SaveUser;


            string[] scopes = new string[] {
                PlusService.Scope.PlusLogin,
                PlusService.Scope.UserinfoEmail,
                PlusService.Scope.UserinfoProfile,
                PlusService.Scope.PlusMe};

            UserCredential userCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(
             new ClientSecrets
             {
                 ClientId = "463454622140-9g7bisaft6gt1imkfrufs3r1v0v6avgi.apps.googleusercontent.com",
                 ClientSecret = "WPWGZkOvWk-VxoLNq7nySCHY"
             },
             scopes,
             Environment.UserName,
             CancellationToken.None,
             new FileDataStore("Current-See.GooglePlus.Auth.Store"))
             .Result;

            PlusService service = new PlusService(
                new BaseClientService.Initializer()
                {
                    HttpClientInitializer = userCredential,
                    ApplicationName = "Current-See"
                });

            PeopleResource test = service.People;


        }

        private void View_SaveUser(object sender, EventArgs e)
        {
            _User.SaveUser();
        }
    }
}
