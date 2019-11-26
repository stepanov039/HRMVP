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
    class FormGroupsPresenter
    {
        private readonly IFormGroups _view;
        private readonly IDBaseManager _manager;

        public FormGroupsPresenter(IFormGroups view, IDBaseManager manager)
        {
            _view = view;
            _manager = manager;
            _view.ShowDataSourse += _view_ShowDataSourse;
            _view.AddClick += _view_AddClick;
            _view.UpdateClick += _view_UpdateClick;
            _view.DeleteClick += _view_DeleteClick;
            _view.SetDataSourseAction += _view_SetDataSourseAction;   
        }

        private async void _view_SetDataSourseAction()
        {
            _view.SetDataSource = await _manager.GetGroupListAsync();
        }

        private void _view_DeleteClick(object sender, EventArgs e)
        {
            _manager.RemoveGroup(_view.GetRecordId);
        }

        private void _view_UpdateClick(object sender, EventArgs e)
        {
            var group = _manager.GetGroupByID(_view.GetRecordId);
            var presenter = new FormGroupPresenter(new FormGroup(), _manager, group);
            presenter.Show();
        }

        private void _view_AddClick(object sender, EventArgs e)
        {
            var group = new Group();
            var presenter = new FormGroupPresenter(new FormGroup(), _manager, group);
            presenter.Show();

        }

        private void _view_ShowDataSourse(object sender, EventArgs e)
        {
         //   _view.SetDataSource = _manager.GetGroupList();
        }

        public void Show()
        {
            _view.Show();
        }
    }

    
}
