using HRMVP.Forms;
using HRMVP.Interfaces;
using HRMVP.Models;
using HRMVP.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMVP
{
    class FormPersonsPresenter
    {
        private readonly IFormPersons _view;
        private readonly IDBaseManager _manager;

        public FormPersonsPresenter(IFormPersons view, IDBaseManager manager)
        {
            _view = view;
            _manager = manager;
            _view.AddClick += _view_AddClick;
            _view.UpdateClick += _view_UpdateClick;
            _view.DeleteClick += _view_DeleteClick;
            _view.FillDbase += _view_FillDbase;
            _view.SetDataSourceAction += _view_SetDataSourceAction;
        }



        private async void _view_SetDataSourceAction()
        {
            _view.SetDataSource = await _manager.GetPersonListAsync();
        }

        private async void _view_FillDbase(object sender, EventArgs e)
        {
            await _manager.FillDbase();
            _view.SetLabelLoad = true;
        }

        private void _view_DeleteClick(object sender, EventArgs e)
        {
            _manager.RemoveGroup(_view.GetRecordId);
        }
        private void _view_UpdateClick(object sender, EventArgs e)
        {
            var person = _manager.GetPersonByID(_view.GetRecordId);
            var presenter = new FormPersonPresenter(new FormPerson(), _manager, person);
            presenter.Show();
        }
        private void _view_AddClick(object sender, EventArgs e)
        {
            var person = new Person() { DateReceipt = DateTime.Now };
            // TODO: еще бы тут сделать вызов формы, через интерфейсы
            var presenter = new FormPersonPresenter(new FormPerson(), _manager, person);
            presenter.Show();
        }
        public void Show()
        {
            _view.Show();
        }
    }


}
