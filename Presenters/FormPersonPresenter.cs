using HRMVP.Interfaces;
using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Presenters
{
    class FormPersonPresenter
    {
        private IFormPerson _view;
        private IDBaseManager _manager;
        private Person _Person;
        private void Initialize(IFormPerson view, IDBaseManager manager)
        {
            _view = view;
            _manager = manager;
            _view.OK_Click += _view_OK_Click;
        }
        public FormPersonPresenter(IFormPerson view, IDBaseManager manager)
        {
            Initialize(view, manager);
            // _Person = new Person();
        }
        public FormPersonPresenter(IFormPerson view, IDBaseManager manager, Person Person)
        {

            Initialize(view, manager);
            _Person = Person;
        }
        private void _view_OK_Click(object sender, EventArgs e)
        {
            // TODO: Нужно подумать как правильно поступить.
            // пока решил передавать пустую структу.
            _Person.Name = _view.NamePerson;
            _Person.Rate = _view.Rate;
            _Person.DateReceipt = _view.DateReceipt;
            _Person.GroupId = _view.GroupID;
            _Person.PersonBossId = _view.PersonBossID;

            if (_Person.PersonId == 0)
                _manager.AddPerson(_Person);
            else
                _manager.UpdatePerson(_Person);
        }
        public void Show()
        {
            _view.NamePerson = _Person.Name;
            _view.DateReceipt = _Person.DateReceipt;
            _view.Rate = _Person.Rate;
            _view.SetGroups = _manager.GetGroupList();
            _view.SetPeronBoss = _manager.GetPersonBossList();
            _view.GroupID = _Person.GroupId;
            _view.PersonBossID = _Person.PersonBossId ?? 0;
            _view.Show();
        }
    }
}
