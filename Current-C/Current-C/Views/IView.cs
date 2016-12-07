using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Current_C.Views
{
    public interface IView
    {
        event EventHandler Initialize;
        event EventHandler Load;
    }
}
