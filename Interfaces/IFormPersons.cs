using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Interfaces
{
    interface IFormPersons : IView
    {
        Array SetDataSource { set; }
        bool SetLabelLoad { set; }

        int GetRecordId { get; }
        event EventHandler ShowDataSourse;
        event EventHandler AddClick;
        event EventHandler UpdateClick;
        event EventHandler DeleteClick;
        event EventHandler FillDbase;
        event Action SetDataSourceAction;

    }
}
