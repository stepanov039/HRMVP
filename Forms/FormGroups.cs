using HRMVP.Interfaces;
using HRMVP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HRMVP
{
    public partial class FormGroups : Form, IFormGroups
    {
        // TODO: нужно поменять на что то читабельное
        public FormGroups()
        {
            InitializeComponent();
        }



        Array IFormGroups.SetDataSource { get => throw new NotImplementedException();
            set
            {
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.DataSource = value;
            }
        }
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

        public event EventHandler ShowDataSourse;
        public event EventHandler AddClick;
        public event EventHandler UpdateClick;
        public event EventHandler DeleteClick;
        public event Action SetDataSourseAction;

        public new void Show()
        {
            this.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddClick(this, EventArgs.Empty);
            SetDataSourseAction();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateClick(this, EventArgs.Empty);
            SetDataSourseAction();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteClick(this, EventArgs.Empty);
            SetDataSourseAction();
        }
        private void FormGroups_Shown(object sender, EventArgs e)
        {
            SetDataSourseAction();
        }
    }
}
