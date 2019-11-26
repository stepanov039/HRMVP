using HRMVP.Classes;
using HRMVP.Interfaces;
using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRMVP
{


    class DBaseManager : IDBaseManager
    {
        Context db;

        enum enumGroup
        {
            Employee = 1,
            Manager,
            Salesman
        }
        public List<PersonManager> GetPersonManagerList
        {
            get
            {
                PersonManager.dateSalary = DateTime.Now;
                var query = from p in db.Persons
                            where p.GroupId == (int)enumGroup.Manager
                            select new
                            {
                                Name = p.Name,
                                Group = p.Group,
                                Rate = p.Rate,
                                DateReceipt = p.DateReceipt,
                                GroupId = p.GroupId,
                                PersonBoss = p.PersonBoss,
                                PersonBossId = p.PersonBossId,
                                PersonId = p.PersonId
                            };

                var personManager = query.ToList().Select(r => new PersonManager
                {
                    Name = r.Name,
                    Group = r.Group,
                    Rate = r.Rate,
                    DateReceipt = r.DateReceipt,
                    GroupId = r.GroupId,
                    PersonBoss = r.PersonBoss,
                    PersonBossId = r.PersonBossId,
                    PersonId = r.PersonId

                }
                ).ToList();
                return personManager;
            }
        }
        public async Task<Array> GetPersonSalesmanList()
        {

            PersonEmployee.dateSalary = DateTime.Now;
            var query = await (from p in db.Persons
                        where p.GroupId == (int)enumGroup.Salesman
                        select new
                        {
                            Name = p.Name,
                            Group = p.Group,
                            Rate = p.Rate,
                            DateReceipt = p.DateReceipt,
                            GroupId = p.GroupId,
                            PersonBoss = p.PersonBoss,
                            PersonBossId = p.PersonBossId,
                            PersonId = p.PersonId
                        }).ToListAsync();





          var personSalesman = query.ToList().Select(r => new PersonSalesman
            {
                Name = r.Name,
                Group = r.Group,
                Rate = r.Rate,
                DateReceipt = r.DateReceipt,
                GroupId = r.GroupId,
//                PersonBoss = r.PersonBoss,
              //  PersonBossId = r.PersonBossId,
                PersonId = r.PersonId
            }
            ).ToList();

            //var per = personSalesman.
           
            return personSalesman.ToArray();
           // return personSalesman;

        }
        public List<PersonEmployee> GetPersonEmployeeList
        {
            get
            {
                PersonEmployee.dateSalary = DateTime.Now;
                var query = from p in db.Persons
                            select new
                            {
                                Name = p.Name,
                                Group = p.Group,
                                Rate = p.Rate,
                                DateReceipt = p.DateReceipt,
                                GroupId = p.GroupId,
                                PersonBoss = p.PersonBoss,
                                PersonBossId = p.PersonBossId,
                                PersonId = p.PersonId
                            };

                var personEmployee = query.ToList().Select(r => new PersonEmployee
                {
                    Name = r.Name,
                    Group = r.Group,
                    Rate = r.Rate,
                    DateReceipt = r.DateReceipt,
                    GroupId = r.GroupId,
                    PersonBoss = r.PersonBoss,
                    PersonBossId = r.PersonBossId,
                    PersonId = r.PersonId
                }
                ).ToList();
                return personEmployee;
            }
        }
        public Array ReportSalaryYear
        {
            get
            {
                var dateTime = DateTime.Now.AddMonths(-11);

                var query1 = (from s in db.PersonPaymentSalarys
                              where s.PaymentDate > dateTime
                              group s by new { s.PaymentDate.Month, s.PersonId } into grp
                              select new
                              {
                                  grp.Key.PersonId,
                                  grp.Key.Month,
                                  Salary = grp.Sum(t => t.SalaryAmount),
                                  // Salary2 = grp.Where(a=>grp.Key.Month == 11).Sum(t => t.SalaryAmount)
                              }).OrderBy(x => x.PersonId).ToList();

                // Можно ли сделать одним запросом

                var query2 = from s in query1
                             group s by new { s.PersonId } into qroup
                             select new
                             {
                                 qroup.Key.PersonId,
                                 salary1 = qroup.Where(t => t.Month == 1).Sum(t => t.Salary),
                                 salary2 = qroup.Where(t => t.Month == 2).Sum(t => t.Salary),
                                 salary3 = qroup.Where(t => t.Month == 3).Sum(t => t.Salary),
                                 salary4 = qroup.Where(t => t.Month == 4).Sum(t => t.Salary),
                                 salary5 = qroup.Where(t => t.Month == 5).Sum(t => t.Salary),
                                 salary6 = qroup.Where(t => t.Month == 6).Sum(t => t.Salary),
                                 salary7 = qroup.Where(t => t.Month == 7).Sum(t => t.Salary),
                                 salary8 = qroup.Where(t => t.Month == 8).Sum(t => t.Salary),
                                 salary9 = qroup.Where(t => t.Month == 9).Sum(t => t.Salary),
                                 salary10 = qroup.Where(t => t.Month == 10).Sum(t => t.Salary),
                                 salary11 = qroup.Where(t => t.Month == 11).Sum(t => t.Salary),
                                 salary12 = qroup.Where(t => t.Month == 12).Sum(t => t.Salary),
                             };

                return query2.ToArray();
            }
        }
        public Array ReportBoss
        {
            get
            {
                var dateTime = DateTime.Now.AddMonths(-6);
                var month3 = DateTime.Now.Month - 3;

                var query1 = from p in db.Persons
                             join pBoss in db.Persons on p.PersonBoss equals pBoss
                             join pps in db.PersonPaymentSalarys on p.PersonId equals pps.PersonId
                             where pps.PaymentDate > dateTime
                             select new
                             {
                                 p.PersonId,
                                 p.Name,
                                 p.PersonBoss,
                                 p.Group,
                                 pps.PaymentDate,
                                 pps.SalaryAmount,
                                 pps.PaymentDate.Month
                             };


                var query2 = from q in query1
                             group q by new { q.PersonBoss } into grp
                             select new
                             {
                                 grp.Key.PersonBoss.Name,
                                 grp.Key.PersonBoss.Group,
                                 salarySUM = grp.Where(t => t.Month > month3).Sum(t => t.SalaryAmount),
                                 salaryAvG = grp.Average(t => t.SalaryAmount),
                                 salaryMAX = grp.Max(t => t.SalaryAmount),
                                 salaryMIN = grp.Min(t => t.SalaryAmount),
                             };

                return query2.ToArray();

            }
        }
        public Array ReportGroups
        {
            get
            {
                var query1 = from pps in db.PersonPaymentSalarys
                             join p in db.Persons on pps.PersonId equals p.PersonId

                             select new
                             {
                                 p.PersonId,
                                 Name = p.Group.Name,
                                 pps.SalaryAmount
                             };

                var query2 = from q in query1
                             group q by new { q.Name } into gpr
                             select new
                             {
                                 gpr.Key.Name,
                                 avarageSum = gpr.Average(t => t.SalaryAmount)
                             };
                return query2.ToArray();
            }
        }
        public DBaseManager()
        {
            db = new Context();
        }
        public Group GetGroupByID(int Id)
        {
            return db.Groups.Find(Id);
        }
        public Person GetPersonByID(int Id)
        {
            return db.Persons.Find(Id);
        }
        public List<Person> GetPersonBossList()
        {
            db.Persons.Load();
            var persons = db.Persons.Where(p => p.GroupId != 3).ToList();


            persons.Add(new Person { PersonId = 0, Name = "Нет" });


            return persons;
        }
        public System.ComponentModel.BindingList<Group> GetGroupList()
        {
            db.Groups.Load();
            return db.Groups.Local.ToBindingList();
        }
        public List<Person> GetPersonList()
        {
            db.Persons.Load();
            return db.Persons.Local.ToList();
        }
        public List<PersonManager> GetPersonListByBoosId(int PersonBossId)
        {
            db.Persons.Where(p => p.PersonBossId == PersonBossId && p.PersonBossId != 0).Load();
            return db.Persons.Local.ToList().Select(p => new PersonManager
            {
                PersonId = p.PersonId,
                GroupId = p.GroupId,
                PersonBoss = p.PersonBoss,
                Name = p.Name,
                DateReceipt = p.DateReceipt,
                Group = p.Group,
                PersonBossId = p.PersonBossId,
                Rate = p.Rate
            }
            ).ToList();
        }
        public void UpdateGroup(Group group)
        {
            db.SaveChanges();
        }
        public void UpdatePerson(Person person)
        {
            db.SaveChanges();
        }
        public void AddGroup(Group group)
        {
            db.Groups.Add(group);
            db.SaveChanges();
        }
        public void RemoveGroup(int Id)
        {
            var group = db.Groups.Find(Id);

            db.Groups.Remove(group);
            db.SaveChanges();
        }
        public void AddPerson(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
        }
        public void RemovePerson(int Id)
        {
            var person = db.Persons.Find(Id);

            db.Persons.Remove(person);
            db.SaveChanges();
        }
        public async Task<bool> FillDbase()
        {
            int CountEmployee = 1000;
            int CountManager = 100;
            int CountSalesman = 10;

            Random random = new Random();

            DateTime startDate = new DateTime(2000, 1, 1);

            await Task.Run(() =>
            {
                Context db1;
                db1 = new Context();
                for (int i = 0; i < CountSalesman; i++)
                {
                    var person = new Person
                    {
                        Name = "Person " + i.ToString(),
                        GroupId = (int)enumGroup.Salesman,
                        Rate = random.Next(1000, 10000),
                        DateReceipt = startDate.AddDays(random.Next(1, 18 * 365)),
                        PersonBossId = random.Next(0, i)
                    };

                    db1.Persons.Add(person);
                    db1.SaveChanges();
                }


                for (int i = 0; i < CountManager; i++)
                {
                    var person = new Person
                    {
                        Name = "Person " + i.ToString(),
                        GroupId = (int)enumGroup.Manager,
                        Rate = random.Next(100, 1000),
                        DateReceipt = startDate.AddDays(random.Next(1, 18 * 365)),
                        PersonBossId = random.Next(0, CountSalesman)
                    };

                    db1.Persons.Add(person);
                    db1.SaveChanges();
                }

                for (int i = 0; i < CountEmployee; i++)
                {
                    var person = new Person
                    {
                        Name = "Person " + i.ToString(),
                        GroupId = (int)enumGroup.Employee,
                        Rate = random.Next(10, 100),
                        DateReceipt = startDate.AddDays(random.Next(1, 18 * 365)),
                        PersonBossId = random.Next(0, CountSalesman + CountManager)
                    };

                    db1.Persons.Add(person);
                    db1.SaveChanges();
                }

            });
            return true;
        }
        public async Task<Array> GetPersonListAsync()
        {
            return await (from p in db.Persons
                          select new
                          {
                              p.PersonId,
                              p.Name,
                              p.Rate,
                              p.Group,
                              p.DateReceipt
                          }).ToArrayAsync();
        }

        public async Task<Array> GetGroupListAsync()
        {
           return await(from g in db.Groups
                               select new 
                               {
                                   g.GroupId,
                                   g.Name,
                                   g.ExperienceRate,
                                   g.MaxExperienceRate,                               
                               }).ToArrayAsync();
        }
    }
}
