using HRMVP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Interfaces
{
    interface IFormMain : IView
    {
        event EventHandler GroupsClick;
        event EventHandler PersonsClick;
        event EventHandler ReportClick;
    }
}

