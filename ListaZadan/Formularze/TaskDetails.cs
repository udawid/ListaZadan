using ListaZadan.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaZadan.Formularze
{
    public partial class TaskDetails : Form
    {
        public TodoTask TodoTask;
        public bool CzyZapisano;

        public TaskDetails(TodoTask zadanie)
        {
            InitializeComponent();
            TodoTask = zadanie;
            lblNumer.Text = zadanie.Id.ToString();
            tbTitle.Text = zadanie.Title;
            tbDescription.Text = zadanie.Description;
            cbIsReady.Checked = zadanie.IsFinished == 1 ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TodoTask.Description = tbDescription.Text;
            TodoTask.Title = tbTitle.Text;
            TodoTask.IsFinished = cbIsReady.Checked ? 1 : 0;
            CzyZapisano = true;
            Close();
        }
    }
}
