using HRMVP.Classes;
using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Interfaces
{
    interface IFormReport : IView
    {
        List<PersonEmployee> SetDataSourcePersonEmployee { set; }
        List<PersonManager> SetDataSourcePersonManager { set; }
        
        Array SetDataSource { set; }

        event EventHandler Salary_Click;
        event EventHandler Salary_Manager_Click;
        event EventHandler Salary_Boss_Click;
        event EventHandler ReportSalaryYear_Click;
        event EventHandler ReportBoss_Click;
        event EventHandler ReportGroups_Click;

    }
}
