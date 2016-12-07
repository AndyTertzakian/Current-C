using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Current_C.Views;
using Current_C.Models;

namespace Current_C.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {
        // TODO: Create data models 
        private User _User { get; set; }

        public MainPresenter(IMainView view, string user) : base(view)
        {
            if (user == null)
                throw new ArgumentNullException();

            _User = user;
        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);

            View.Username = "Please enter your username";
            View.DOB = null;

            View.SaveUser += View_SaveUser;
        }

        private void View_SaveUser(object sender, EventArgs e)
        {
            _User.SaveUser();
        }
    }
}
