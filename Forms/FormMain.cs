using HRMVP.Classes;
using HRMVP.Interfaces;
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
    public partial class FormMain : Form, IFormMain
    {
        //Повторение но это лишь для заполнения таблиц...


        public FormMain()
        {
            InitializeComponent();
        }

        public event EventHandler GroupsClick;
        public event EventHandler PersonsClick;
        public event EventHandler ReportClick;
        public event EventHandler FillDbase;

        public new void Show()
        {
            Application.Run(this);
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            GroupsClick(this, EventArgs.Empty);
        }

        private void buttonPerson_Click(object sender, EventArgs e)
        {
            PersonsClick(this, EventArgs.Empty);
            
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            ReportClick(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillDbase(this, EventArgs.Empty);
        }
    }
}
