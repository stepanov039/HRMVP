using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Models
{
   public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime DateReceipt { get; set; }
        public int Rate { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int? PersonBossId { get; set; }
        public virtual Person PersonBoss { get; set; }



        public override string ToString()
        {
            return Name;
        }
    }
}
