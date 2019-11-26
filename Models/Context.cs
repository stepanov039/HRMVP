using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Models
{
   public class Context:DbContext
    {
        public Context():base("DefaultConnection") { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Group> Groups { get; set; }

        public DbSet<PersonPaymentSalary> PersonPaymentSalarys { get; set; }
    }
}
