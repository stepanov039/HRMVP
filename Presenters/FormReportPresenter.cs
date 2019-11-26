using HRMVP.Interfaces;
using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMVP.Presenters
{
    class FormReportPresenter
    {

        private  IFormReport _view;
        private  IDBaseManager _manager;

        private void Initialize(IFormReport view, IDBaseManager manager)
        {
            _view = view;
            _manager = manager;
            _view.Salary_Click += _view_Salary_Click;
            _view.Salary_Manager_Click += _view_Salary_Manager_Click;
            _view.Salary_Boss_Click += _view_Salary_Boss_Click;
            _view.ReportSalaryYear_Click += _view_ReportSalaryYear_Click;
            _view.ReportBoss_Click += _view_ReportBoss_Click;
            _view.ReportGroups_Click += _view_ReportGroups_Click;
 
        }

        private void _view_ReportGroups_Click(object sender, EventArgs e)
        {
            _view.SetDataSource = _manager.ReportGroups;
        }

        private void _view_ReportBoss_Click(object sender, EventArgs e)
        {
            _view.SetDataSource = _manager.ReportBoss;
        }
        private void _view_ReportSalaryYear_Click(object sender, EventArgs e)
        {
            _view.SetDataSource = _manager.ReportSalaryYear;
        }
        private void _view_Salary_Manager_Click(object sender, EventArgs e)
        {
            _view.SetDataSourcePersonManager = _manager.GetPersonManagerList;
        }
        private async void _view_Salary_Boss_Click(object sender, EventArgs e)
        {
            _view.SetDataSource = await _manager.GetPersonSalesmanList();
        }
        private void _view_Salary_Click(object sender, EventArgs e)
        {
            _view.SetDataSourcePersonEmployee = _manager.GetPersonEmployeeList;
        }
        public FormReportPresenter(IFormReport view, IDBaseManager manager)
        {
            Initialize(view,manager);
        }
    public void Show()
    {   
        _view.Show();
    }
    }
}
