using ListaZadan.Formularze;
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

namespace ListaZadan.Kontrolki
{
    public partial class TasksControl : UserControl
    {
        //zmienna na głowny formularz;
        private MainForm _mainForm;
        //zmienna na zalogowanego użytkowniak 
        private User _zalogowany;
        
        private TodoTaskManager _todoTaskManager;

        public TasksControl(MainForm mainForm, User user)
        {
            InitializeComponent();

            //przipisujemy przekazany obiekt głownego formularza do zmiennej klasy
            _mainForm = mainForm;
            //ustawiamy DokStyle po to, że by okno zajeło całą dostępną przestrzeń
            //frmularza głównego
            Dock = DockStyle.Fill;

            //przypisujemy przekazanego użytkownika do zmiennej
            _zalogowany = user;
            lblZalogowanyWartosc.Text = user.Imie;

            _todoTaskManager = new TodoTaskManager();
            _todoTaskManager.ZaladujZadaniaUzytkownika(_zalogowany.Id);
            foreach(TodoTask zadanie in _todoTaskManager.PobierzZadania(_zalogowany.Id))
            {
                DodajZadanieDoListy(zadanie);
            }
        }

        public void DodajZadanieDoListy(TodoTask zadanie)
        {
            ListViewItem item = new ListViewItem(zadanie.Id.ToString());
            item.SubItems.Add(zadanie.Title);
            string zrobione = zadanie.IsFinished == 1 ? "✓" : "✘";
            item.SubItems.Add(zrobione);

            lvZadania.Items.Add(item);
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            _mainForm.PokazLoginControl();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (lvZadania.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano zadania do skasowania.", "Informacja", MessageBoxButtons.OK);
            }
            else
            {
                string idZaznaczonegoZadania = lvZadania.SelectedItems[0].SubItems[0].Text;
                _todoTaskManager.UsunZadanie(int.Parse(idZaznaczonegoZadania));
                lvZadania.Items.Remove(lvZadania.SelectedItems[0]);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            long id = _todoTaskManager.ObliczNastepneId();
            TodoTask newTask = new TodoTask(id, _zalogowany.Id, "", "", 0);
            TaskDetails detailForm = new TaskDetails(newTask);
            detailForm.ShowDialog();

            if(detailForm.CzyZapisano)
            {
                _todoTaskManager.DodaZadanie(newTask);
                DodajZadanieDoListy(newTask);
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (lvZadania.SelectedItems.Count == 0)
            {
                MessageBox.Show("Najpierw zaznacz zadanie.", "Informacja", MessageBoxButtons.OK);
            }
            else
            {
                string taskId = lvZadania.SelectedItems[0].SubItems[0].Text;
                TodoTask task = _todoTaskManager.ZnajdzZadanie(int.Parse(taskId));
                TaskDetails detailForm = new TaskDetails(task);
                detailForm.ShowDialog();
                if (detailForm.CzyZapisano)
                {
                    _todoTaskManager.AktualizujZadaniaUzytkownika(_zalogowany.Id);
                    lvZadania.SelectedItems[0].SubItems[1].Text = task.Title;
                    lvZadania.SelectedItems[0].SubItems[2].Text = task.IsFinished == 1 ? "✓" : "✘";
                }
            }
        }
    }
}
