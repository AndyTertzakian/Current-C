using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Current_C.Views
{
    public interface IMainView : IView
    {
        string Username
        { get;set;}

        DateTime? DOB { get;set; }

        event EventHandler SaveUser;

    }
}
