using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Classes
{
    public class PersonManager : PersonEmployee
    {
        public PersonManager()
        {
        }
        public virtual ICollection<PersonManager> Subordinates 
        {
            get
            {
                var manager = new DBaseManager();                
                return manager.GetPersonListByBoosId(this.PersonId); 
            }
        }
        public double SalaryBoss
        {
            get 
            {
                return CalculateSubordinates(Subordinates) * 0.5 /100;
            }
        }
        private double CalculateSubordinates(ICollection<PersonManager> Subordinates)
        {
            double salary = 0;
            foreach (var n in Subordinates)
            {
                salary = salary + n.SalaryEmployee;
            }
            return salary;
        }
    }
}
