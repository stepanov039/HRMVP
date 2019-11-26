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
    public partial class FormPerson : Form ,IFormPerson
    {
        public FormPerson()
        {
            InitializeComponent();
            
        }

        public string NamePerson { get => textBoxName.Text; set => textBoxName.Text = value; }
        public DateTime DateReceipt { get => dateTimePickerDateReceipt.Value; set => dateTimePickerDateReceipt.Value = value; }
        public int Rate { get => (int)numericUpDownRate.Value; set => numericUpDownRate.Value = value; }
        public BindingList<Group> SetGroups {  set => comboBoxGroups.DataSource = value; }
        public List<Person> SetPeronBoss { set => comboBoxBoss.DataSource = value; }

        public int GroupID { get => ((Group)comboBoxGroups.SelectedItem).GroupId; 
            set  {

                comboBoxGroups.ValueMember = "GroupId";
                comboBoxGroups.DisplayMember = "Name";
                comboBoxGroups.SelectedValue = value; 
            } 
        }
        public int PersonBossID { get => ((Person)comboBoxBoss.SelectedItem).PersonId;
            set 
            {
                comboBoxBoss.ValueMember = "PersonId";
                comboBoxBoss.DisplayMember = "Name";
                comboBoxBoss.SelectedValue = value; 
            }
        }

        public event EventHandler OK_Click;

        public new void Show()
        {
            this.ShowDialog();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            OK_Click(this, EventArgs.Empty);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
