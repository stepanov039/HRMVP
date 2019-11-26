using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Interfaces
{

    public interface IFormGroups : IView
    {
        Array SetDataSource { get; set; }
        int GetRecordId { get;}
        event EventHandler ShowDataSourse;       
        event EventHandler AddClick;
        event EventHandler UpdateClick;
        event EventHandler DeleteClick;
        event Action SetDataSourseAction;


    }
}
