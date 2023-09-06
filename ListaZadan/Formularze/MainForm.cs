using ListaZadan.Klasy;
using ListaZadan.Kontrolki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaZadan
{
    public partial class MainForm : Form
    {
        public UserManager userManager;

        public MainForm()
        {
            InitializeComponent();
            userManager = new UserManager();
            PokazLoginControl();
        }

        public void PokazLoginControl()
        {
            //Czyszczenie wszystkich kontrolek
            Controls.Clear();
            Controls.Add(new LoginControl(this));
        }

        public void PokazRegisterControl()
        {
            //Czyszczenie wszystkich kontrolek
            Controls.Clear();
            Controls.Add(new RegisterControl(this));
        }

        public void PokazTasksControl(User user)
        {
            //Czyszczenie wszystkich kontrolek
            Controls.Clear();
            Controls.Add(new TasksControl(this, user));
        }
    }
}
