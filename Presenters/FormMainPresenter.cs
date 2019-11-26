using HRMVP.Forms;
using HRMVP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Presenters
{
    
    class FormMainPresenter
    {
        private readonly IFormMain _view;

        public FormMainPresenter(IFormMain view)
        {
            _view = view;
            _view.GroupsClick += _view_GroupsClick;
            _view.PersonsClick += _view_PersonsClick;
            _view.ReportClick += _view_ReportClick;
        }

        private void _view_ReportClick(object sender, EventArgs e)
        {
            var presenter = new FormReportPresenter(new FormReports(), new DBaseManager());
            presenter.Show();
        }

        private void _view_PersonsClick(object sender, EventArgs e)
        {
            var presenter = new FormPersonsPresenter(new FormPersons(), new DBaseManager());
            presenter.Show();
        }

        private void _view_GroupsClick(object sender, EventArgs e)
        {
            var presenter = new FormGroupsPresenter(new FormGroups(), new DBaseManager());
            presenter.Show();
        }

        public void Show()
        {
            _view.Show();
        }
    }

}
