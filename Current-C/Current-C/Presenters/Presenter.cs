using Current_C.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Current_C.Presenters
{
    public class Presenter<TView> where TView : class, IView
    {
        public TView View
        {
            get;
            private set;
        }

        public Presenter(TView view)
        {
            if (view == null)
                throw new ArgumentNullException("view");

            View = view;
            View.Initialize += OnViewInitialize;
            View.Load += OnViewLoad;
        }

        protected virtual void OnViewInitialize(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected virtual void OnViewLoad(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
