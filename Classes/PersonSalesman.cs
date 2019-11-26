using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Classes
{
    public class PersonSalesman : PersonManager
    {
        private int countRecursion = 0;
        public new double SalaryBoss
        {
            get
            {
                 return CalculateSubordinates(Subordinates) * 0.3 / 100;
            }
        }
        private double CalculateSubordinates(ICollection<PersonManager> Subordinates)
        {
            //TODO: Нужно подумать как лучше определить цикличность рекурси
            if (countRecursion > 10)
                return -1;
            else
                countRecursion++;

            double salary = 0;
            foreach (var n in Subordinates)
            {
                salary = salary + CalculateSubordinates(n.Subordinates);
                salary = salary + n.SalaryEmployee;
            }
            return salary;
        }
    }
}
