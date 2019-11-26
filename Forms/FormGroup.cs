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
    public partial class FormGroup : Form , IFormGroup
    {
        public FormGroup()
        {
            InitializeComponent();
        }

        public double ExperienceRate { get =>  (double)numericUpDownExperienceRate.Value; set => numericUpDownExperienceRate.Value =(decimal)value; }
        public double MaxExperienceRate { get => (double)numericUpDownMaxExperienceRate.Value; set => numericUpDownMaxExperienceRate.Value = (decimal)value; }
        public string NameGroup { get => textBoxName.Text; set => textBoxName.Text = value; }

        public event EventHandler OK_Click;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            OK_Click(this, EventArgs.Empty);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public new void Show()
        {
            this.ShowDialog();
        }


    }
}
