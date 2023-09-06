
namespace ListaZadan.Kontrolki
{
    partial class RegisterControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTytul = new System.Windows.Forms.Label();
            this.btnCofnij = new System.Windows.Forms.Button();
            this.gbDaneUzytkownika = new System.Windows.Forms.GroupBox();
            this.lblPowtorzHasloWalidacja = new System.Windows.Forms.Label();
            this.lblHasloWalidacja = new System.Windows.Forms.Label();
            this.lblLoginWalidacja = new System.Windows.Forms.Label();
            this.lblImieWalidacja = new System.Windows.Forms.Label();
            this.tbPowtorzHaslo = new System.Windows.Forms.TextBox();
            this.lblPowtorzHaslo = new System.Windows.Forms.Label();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.btnZarejestruj = new System.Windows.Forms.Button();
            this.gbDaneUzytkownika.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytul.Location = new System.Drawing.Point(145, 31);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(205, 42);
            this.lblTytul.TabIndex = 1;
            this.lblTytul.Text = "Rejestracja";
            // 
            // btnCofnij
            // 
            this.btnCofnij.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCofnij.Location = new System.Drawing.Point(18, 27);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(106, 51);
            this.btnCofnij.TabIndex = 7;
            this.btnCofnij.Text = "⮜";
            this.btnCofnij.UseVisualStyleBackColor = true;
            this.btnCofnij.Click += new System.EventHandler(this.btnCofnij_Click);
            // 
            // gbDaneUzytkownika
            // 
            this.gbDaneUzytkownika.Controls.Add(this.lblPowtorzHasloWalidacja);
            this.gbDaneUzytkownika.Controls.Add(this.lblHasloWalidacja);
            this.gbDaneUzytkownika.Controls.Add(this.lblLoginWalidacja);
            this.gbDaneUzytkownika.Controls.Add(this.lblImieWalidacja);
            this.gbDaneUzytkownika.Controls.Add(this.tbPowtorzHaslo);
            this.gbDaneUzytkownika.Controls.Add(this.lblPowtorzHaslo);
            this.gbDaneUzytkownika.Controls.Add(this.tbHaslo);
            this.gbDaneUzytkownika.Controls.Add(this.lblHaslo);
            this.gbDaneUzytkownika.Controls.Add(this.tbLogin);
            this.gbDaneUzytkownika.Controls.Add(this.lblLogin);
            this.gbDaneUzytkownika.Controls.Add(this.tbImie);
            this.gbDaneUzytkownika.Controls.Add(this.lblImie);
            this.gbDaneUzytkownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbDaneUzytkownika.Location = new System.Drawing.Point(18, 107);
            this.gbDaneUzytkownika.Name = "gbDaneUzytkownika";
            this.gbDaneUzytkownika.Size = new System.Drawing.Size(463, 352);
            this.gbDaneUzytkownika.TabIndex = 8;
            this.gbDaneUzytkownika.TabStop = false;
            this.gbDaneUzytkownika.Text = "Dane nowego użytkownika";
            // 
            // lblPowtorzHasloWalidacja
            // 
            this.lblPowtorzHasloWalidacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPowtorzHasloWalidacja.ForeColor = System.Drawing.Color.Red;
            this.lblPowtorzHasloWalidacja.Location = new System.Drawing.Point(169, 305);
            this.lblPowtorzHasloWalidacja.Name = "lblPowtorzHasloWalidacja";
            this.lblPowtorzHasloWalidacja.Size = new System.Drawing.Size(229, 40);
            this.lblPowtorzHasloWalidacja.TabIndex = 15;
            this.lblPowtorzHasloWalidacja.Text = "Labelka na walidacje";
            this.lblPowtorzHasloWalidacja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPowtorzHasloWalidacja.Visible = false;
            // 
            // lblHasloWalidacja
            // 
            this.lblHasloWalidacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHasloWalidacja.ForeColor = System.Drawing.Color.Red;
            this.lblHasloWalidacja.Location = new System.Drawing.Point(177, 228);
            this.lblHasloWalidacja.Name = "lblHasloWalidacja";
            this.lblHasloWalidacja.Size = new System.Drawing.Size(221, 40);
            this.lblHasloWalidacja.TabIndex = 14;
            this.lblHasloWalidacja.Text = "Labelka na walidacje";
            this.lblHasloWalidacja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHasloWalidacja.Visible = false;
            // 
            // lblLoginWalidacja
            // 
            this.lblLoginWalidacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLoginWalidacja.ForeColor = System.Drawing.Color.Red;
            this.lblLoginWalidacja.Location = new System.Drawing.Point(171, 151);
            this.lblLoginWalidacja.Name = "lblLoginWalidacja";
            this.lblLoginWalidacja.Size = new System.Drawing.Size(227, 40);
            this.lblLoginWalidacja.TabIndex = 13;
            this.lblLoginWalidacja.Text = "Labelka na walidacje";
            this.lblLoginWalidacja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLoginWalidacja.Visible = false;
            // 
            // lblImieWalidacja
            // 
            this.lblImieWalidacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImieWalidacja.ForeColor = System.Drawing.Color.Red;
            this.lblImieWalidacja.Location = new System.Drawing.Point(171, 77);
            this.lblImieWalidacja.Name = "lblImieWalidacja";
            this.lblImieWalidacja.Size = new System.Drawing.Size(227, 40);
            this.lblImieWalidacja.TabIndex = 12;
            this.lblImieWalidacja.Text = "Labelka na walidacje";
            this.lblImieWalidacja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblImieWalidacja.Visible = false;
            // 
            // tbPowtorzHaslo
            // 
            this.tbPowtorzHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPowtorzHaslo.Location = new System.Drawing.Point(173, 271);
            this.tbPowtorzHaslo.Name = "tbPowtorzHaslo";
            this.tbPowtorzHaslo.PasswordChar = '*';
            this.tbPowtorzHaslo.Size = new System.Drawing.Size(225, 31);
            this.tbPowtorzHaslo.TabIndex = 11;
            // 
            // lblPowtorzHaslo
            // 
            this.lblPowtorzHaslo.AutoSize = true;
            this.lblPowtorzHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPowtorzHaslo.Location = new System.Drawing.Point(13, 274);
            this.lblPowtorzHaslo.Name = "lblPowtorzHaslo";
            this.lblPowtorzHaslo.Size = new System.Drawing.Size(153, 25);
            this.lblPowtorzHaslo.TabIndex = 10;
            this.lblPowtorzHaslo.Text = "Powtórz hasło:";
            this.lblPowtorzHaslo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHaslo.Location = new System.Drawing.Point(173, 194);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '*';
            this.tbHaslo.Size = new System.Drawing.Size(225, 31);
            this.tbHaslo.TabIndex = 9;
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.Location = new System.Drawing.Point(93, 197);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(73, 25);
            this.lblHaslo.TabIndex = 8;
            this.lblHaslo.Text = "Hasło:";
            this.lblHaslo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(173, 117);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(225, 31);
            this.tbLogin.TabIndex = 7;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.Location = new System.Drawing.Point(95, 120);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(71, 25);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login:";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbImie
            // 
            this.tbImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbImie.Location = new System.Drawing.Point(173, 43);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(225, 31);
            this.tbImie.TabIndex = 5;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(109, 46);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(57, 25);
            this.lblImie.TabIndex = 4;
            this.lblImie.Text = "Imię:";
            this.lblImie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnZarejestruj
            // 
            this.btnZarejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZarejestruj.Location = new System.Drawing.Point(135, 493);
            this.btnZarejestruj.Name = "btnZarejestruj";
            this.btnZarejestruj.Size = new System.Drawing.Size(225, 51);
            this.btnZarejestruj.TabIndex = 9;
            this.btnZarejestruj.Text = "Zarejestruj";
            this.btnZarejestruj.UseVisualStyleBackColor = true;
            this.btnZarejestruj.Click += new System.EventHandler(this.btnZarejestruj_Click);
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZarejestruj);
            this.Controls.Add(this.gbDaneUzytkownika);
            this.Controls.Add(this.btnCofnij);
            this.Controls.Add(this.lblTytul);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.gbDaneUzytkownika.ResumeLayout(false);
            this.gbDaneUzytkownika.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Button btnCofnij;
        private System.Windows.Forms.GroupBox gbDaneUzytkownika;
        private System.Windows.Forms.Label lblPowtorzHasloWalidacja;
        private System.Windows.Forms.Label lblHasloWalidacja;
        private System.Windows.Forms.Label lblLoginWalidacja;
        private System.Windows.Forms.Label lblImieWalidacja;
        private System.Windows.Forms.TextBox tbPowtorzHaslo;
        private System.Windows.Forms.Label lblPowtorzHaslo;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Button btnZarejestruj;
    }
}
