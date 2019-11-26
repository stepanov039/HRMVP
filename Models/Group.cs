using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Models
{
   public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }

        public double ExperienceRate { get; set; }
        public double MaxExperienceRate { get; set; }
        public virtual ICollection<Person> Persons { get; set; }

        public Group()
        {
            Persons = new List<Person>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
