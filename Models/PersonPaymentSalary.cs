using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Models
{
    public class PersonPaymentSalary
    {

        public int Id { get; set; }

        public DateTime PaymentDate { get; set; }

        public int? PersonId { get; set; }

        public virtual Person Person { get; set; }

        public double SalaryAmount { get; set; }

    }
}
