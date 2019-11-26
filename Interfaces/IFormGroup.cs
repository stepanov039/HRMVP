using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Interfaces
{
    interface IFormGroup :IView
    {
        string NameGroup { get; set; }
        double ExperienceRate { get; set; }
        double MaxExperienceRate { get; set; }
        event EventHandler OK_Click;
    }

}
