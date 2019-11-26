using HRMVP.Classes;
using HRMVP.Interfaces;
using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMVP.Forms
{
    public partial class FormReports : Form , IFormReport
    {
        public FormReports()
        {
            InitializeComponent();
        }
        public List<PersonEmployee> SetDataSourcePersonEmployee { set => dataGridView1.DataSource = value.ToList(); }
        public List<PersonManager> SetDataSourcePersonManager { set => dataGridView1.DataSource = value.ToList(); }
        public List<PersonSalesman> SetDataSourcePersonSalesman { set => dataGridView1.DataSource = value.ToList(); }
        public Array SetDataSource { set => dataGridView1.DataSource = value; }


        public event EventHandler Salary_Click;
        public event EventHandler Salary_Manager_Click;
        public event EventHandler Salary_Boss_Click;

        public event EventHandler ReportSalaryYear_Click;
        public event EventHandler ReportBoss_Click;
        public event EventHandler ReportGroups_Click;


        private void buttonSalary_Click(object sender, EventArgs e)
        {
            Salary_Click(this, EventArgs.Empty);
        }
        private void buttonManager_Click(object sender, EventArgs e)
        {
            Salary_Manager_Click(this, EventArgs.Empty);
        }
        private void buttonSalaryBoss_Click(object sender, EventArgs e)
        {
            Salary_Boss_Click(this, EventArgs.Empty);
        }

        private void buttonReportSalaryYear_Click(object sender, EventArgs e)
        {
            ReportSalaryYear_Click(this, EventArgs.Empty);
        }

        private void buttonReportBoss_Click(object sender, EventArgs e)
        {
            ReportBoss_Click(this, EventArgs.Empty);
        }

        private void buttonReportGroups_Click(object sender, EventArgs e)
        {
            ReportGroups_Click(this, EventArgs.Empty);

        }
    }
}
