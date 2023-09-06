using ListaZadan.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaZadan.Kontrolki
{ 
    public partial class RegisterControl : UserControl
    {
        //zmienna na głowny formularz;
        private MainForm _mainForm;
        public RegisterControl(MainForm mainForm)
        {
            InitializeComponent();

            //przipisujemy przekazany obiekt głownego formularza do zmiennej klasy
            _mainForm = mainForm;

            //ustawiamy DokStyle po to, że by okno zajeło całą dostępną przestrzeń
            //frmularza głównego
            Dock = DockStyle.Fill;
        }

        private void btnZarejestruj_Click(object sender, EventArgs e)
        {
            if(WalidujFormularz())
            {
                User newUser = new User(Guid.NewGuid().ToString(), tbImie.Text, tbLogin.Text, tbHaslo.Text);
                _mainForm.userManager.AddUser(newUser);
                _mainForm.PokazTasksControl(newUser);
            }
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            _mainForm.PokazLoginControl();
        }

        private bool WalidujFormularz()
        {
            lblLoginWalidacja.Visible = false;
            lblImieWalidacja.Visible = false;
            lblHasloWalidacja.Visible = false;
            lblPowtorzHasloWalidacja.Visible = false;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMin8Char = new Regex(@".{8,}");
            var hasSpecialChar = new Regex(@".*?[!@#\$&*~]");

            bool czyWszystkoPoprawne = true;

            if (string.IsNullOrEmpty(tbImie.Text))
            {
                lblImieWalidacja.Text = "Imię jest wymagane";
                lblImieWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }

            if (string.IsNullOrEmpty(tbLogin.Text))
            {
                lblLoginWalidacja.Text = "Login jest wymagany";
                lblLoginWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if(!_mainForm.userManager.CzyLoginWolny(tbLogin.Text))
            {
                lblLoginWalidacja.Text = "Podany login jest już zajęty";
                lblLoginWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            
            if(string.IsNullOrEmpty(tbHaslo.Text))
            {
                lblHasloWalidacja.Text = "Hasło jest wymagane";
                lblHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if(!hasNumber.IsMatch(tbHaslo.Text))
            {
                lblHasloWalidacja.Text = "Hasło musi posiadać conajmniej jedną cyfrę";
                lblHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if (!hasUpperChar.IsMatch(tbHaslo.Text))
            {
                lblHasloWalidacja.Text = "Hasło musi posiadać co najmniej jedną dużą literę";
                lblHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if (!hasMin8Char.IsMatch(tbHaslo.Text))
            {
                lblHasloWalidacja.Text = "Hasło musi posiadać co najmniej osiem znaków";
                lblHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }
            else if (!hasSpecialChar.IsMatch(tbHaslo.Text))
            {
                lblHasloWalidacja.Text = "Hasło musi posiadać co najmniej jeden znak specjalny np. !@#$%^&";
                lblHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }

            if (string.IsNullOrEmpty(tbPowtorzHaslo.Text))
            {
                lblPowtorzHasloWalidacja.Text = "Powtorzenie hasła jest wymagane";
                lblPowtorzHasloWalidacja.Visible = true;
                czyWszystkoPoprawne = false;
            }

            if(!string.IsNullOrEmpty(tbHaslo.Text) && !string.IsNullOrEmpty(tbPowtorzHaslo.Text))
            {
                if(tbHaslo.Text != tbPowtorzHaslo.Text)
                {
                    lblPowtorzHasloWalidacja.Text = "Podane hasła są różne";
                    lblPowtorzHasloWalidacja.Visible = true;
                    czyWszystkoPoprawne = false;
                }
            }

            return czyWszystkoPoprawne;
        }
    }
}
