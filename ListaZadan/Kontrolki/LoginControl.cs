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
    public partial class LoginControl : UserControl
    {
        //zmienna na głowny formularz;
        private MainForm _mainForm;
        public LoginControl(MainForm mainForm)
        {
            InitializeComponent();

            //przipisujemy przekazany obiekt głownego formularza do zmiennej klasy
            _mainForm = mainForm;

            //ustawiamy DokStyle po to, że by okno zajeło całą dostępną przestrzeń
            //frmularza głównego
            Dock = DockStyle.Fill;
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbHaslo.Text))
            {
                lblWalidacjaLogowania.Text = "Login i hasło jest wymagane";
                lblWalidacjaLogowania.Visible = true;
            }           
            else
            {
                User uzytkownik = _mainForm.userManager.WyszukajUzytkownika(tbLogin.Text, tbHaslo.Text);
                if (uzytkownik == null)
                {
                    lblWalidacjaLogowania.Text = "Nieprawidłowy login lub hasło";
                    lblWalidacjaLogowania.Visible = true;
                }
                else
                {
                    _mainForm.PokazTasksControl(uzytkownik);
                }
            }
        }

        private void btnZalozKonto_Click(object sender, EventArgs e)
        {
            _mainForm.PokazRegisterControl();
        }
    }
}
