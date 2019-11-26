using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Classes
{
    public class PersonEmployee : Person
    {
        public static DateTime dateSalary;
        public int Experience
        {
            get
            {
                 return (dateSalary).Year -  DateReceipt.Year;
            }
        }
        public double SalaryEmployee
        {
            get
            {
                if (DateReceipt >= dateSalary)
                    return 0;

                var premium = Rate * (Group.ExperienceRate / 100) * Experience;
                var premiumMax = Rate * (Group.MaxExperienceRate / 100);

                if (premium > premiumMax)
                    return Rate + premiumMax;
                else
                    return Rate + premium;
            }
        }
    }
}
