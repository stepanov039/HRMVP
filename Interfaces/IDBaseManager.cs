using HRMVP.Classes;
using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Interfaces
{
    public interface IDBaseManager
    {
       List<Person> GetPersonList();
        System.ComponentModel.BindingList<Group> GetGroupList();
        List<Person> GetPersonBossList();
        List<PersonManager> GetPersonListByBoosId(int PersonBossId);
        Person GetPersonByID(int Id);
        Group GetGroupByID(int Id);
        void AddGroup(Group group);
        void UpdateGroup(Group group);
        void RemoveGroup(int Id);
        void AddPerson(Person person);
        void UpdatePerson(Person person);
        void RemovePerson(int Id);
        Task<bool> FillDbase();
        List<PersonEmployee> GetPersonEmployeeList { get; }
        List<PersonManager> GetPersonManagerList { get; }
        Array ReportSalaryYear { get; }
        Array ReportBoss { get; }
        Array ReportGroups { get; }
        Task<Array> GetPersonListAsync();

        Task<Array> GetGroupListAsync();
        Task<Array> GetPersonSalesmanList(); 

    }
}
