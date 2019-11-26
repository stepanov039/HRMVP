using HRMVP.Interfaces;
using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Presenters
{
    class FormGroupPresenter
    {

        private  IFormGroup _view;
        private  IDBaseManager _manager;
        private  Group _group;
        private void Initialize(IFormGroup view, IDBaseManager manager)
        {
            _view = view;
            _manager = manager;
            _view.OK_Click += _view_OK_Click;
        }
        public FormGroupPresenter(IFormGroup view, IDBaseManager manager)
        {
            Initialize(view,manager);
        }

        public FormGroupPresenter(IFormGroup view, IDBaseManager manager, Group group)
        {
            Initialize(view, manager);
            _group = group;
        }
        private void _view_OK_Click(object sender, EventArgs e)
        {
            // TODO: Нужно подумать как правильно поступить.
            // пока решил передавать пустую структу.
            
            _group.Name = _view.NameGroup;
            _group.MaxExperienceRate = _view.MaxExperienceRate;
            _group.ExperienceRate = _view.ExperienceRate;

            if (_group.GroupId == 0)
                _manager.AddGroup(_group);
            else
                _manager.UpdateGroup(_group);
        }
 
    public void Show()
    {
        _view.ExperienceRate = _group.ExperienceRate;
        _view.MaxExperienceRate = _group.MaxExperienceRate;
        _view.NameGroup = _group.Name;
        _view.Show();
    }
    }
}
