using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Interfaces
{
    interface IFormPerson : IView
    {
        string NamePerson { get; set; }
        DateTime DateReceipt { get; set; }
        int Rate { get; set; }
        BindingList<Group> SetGroups { set; }
        int GroupID { get; set; }
        List<Person> SetPeronBoss { set; }
        int PersonBossID { get; set; }
        event EventHandler OK_Click;

    }

}
