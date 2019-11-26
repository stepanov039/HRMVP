using HRMVP.Interfaces;
using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMVP.Forms
{
    public partial class FormPersons : Form, IFormPersons
    {
        public FormPersons()
        {
            InitializeComponent();
        }

      
        public Array SetDataSource
        {
            set
            {
                //Action action = () =>
                //    {
                //        dataGridView1.DataSource = value;
                //    };
                //Invoke(action);

                dataGridView1.DataSource = value;
            }
        }

        // TODO: Нужно сделать униварсально
        public int GetRecordId
        {
            get
            {
                var index = dataGridView1.SelectedRows[0].Index;

                var id = 0;
                var converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);

                if (!converted)
                {
                    MessageBox.Show("Ошибка получения ИД выбранной записи");
                    return 0;
                }
                return id;
            }
        }

        public bool SetLabelLoad { set => labelLoad.Text = "загрузка завершена"; }

        public event EventHandler AddClick;
        public event EventHandler ShowDataSourse;
        public event EventHandler UpdateClick;
        public event EventHandler DeleteClick;
        public event EventHandler FillDbase;
        public event Action SetDataSourceAction;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddClick(this, EventArgs.Empty);
            SetDataSourceAction();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateClick(this, EventArgs.Empty);
            SetDataSourceAction();
            
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteClick(this, EventArgs.Empty);
            SetDataSourceAction();
        }
        public new void Show()
        {
            this.ShowDialog();
        }
        private void FormPersons_Shown(object sender, EventArgs e)
        {
            SetDataSourceAction();
        }

        private void buttonFillBase_Click(object sender, EventArgs e)
        {
            labelLoad.Text = "Идет заливка";
            FillDbase(this, EventArgs.Empty);
        }

    }
}
