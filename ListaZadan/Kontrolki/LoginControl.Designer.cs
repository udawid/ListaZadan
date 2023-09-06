
namespace ListaZadan.Kontrolki
{
    partial class LoginControl
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.lblWalidacjaLogowania = new System.Windows.Forms.Label();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.btnZalozKonto = new System.Windows.Forms.Button();
            this.lblLinia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytul.Location = new System.Drawing.Point(147, 36);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(210, 42);
            this.lblTytul.TabIndex = 0;
            this.lblTytul.Text = "Lista zadań";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.Location = new System.Drawing.Point(58, 137);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(71, 25);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login:";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.Location = new System.Drawing.Point(56, 174);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(73, 25);
            this.lblHaslo.TabIndex = 2;
            this.lblHaslo.Text = "Hasło:";
            this.lblHaslo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(136, 134);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(225, 31);
            this.tbLogin.TabIndex = 3;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHaslo.Location = new System.Drawing.Point(136, 171);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '*';
            this.tbHaslo.Size = new System.Drawing.Size(225, 31);
            this.tbHaslo.TabIndex = 4;
            // 
            // lblWalidacjaLogowania
            // 
            this.lblWalidacjaLogowania.AutoSize = true;
            this.lblWalidacjaLogowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWalidacjaLogowania.ForeColor = System.Drawing.Color.Red;
            this.lblWalidacjaLogowania.Location = new System.Drawing.Point(101, 227);
            this.lblWalidacjaLogowania.Name = "lblWalidacjaLogowania";
            this.lblWalidacjaLogowania.Size = new System.Drawing.Size(295, 25);
            this.lblWalidacjaLogowania.TabIndex = 5;
            this.lblWalidacjaLogowania.Text = "Nieprawidłowy login lub hasło";
            this.lblWalidacjaLogowania.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWalidacjaLogowania.Visible = false;
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaloguj.Location = new System.Drawing.Point(136, 295);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(225, 51);
            this.btnZaloguj.TabIndex = 6;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = true;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // btnZalozKonto
            // 
            this.btnZalozKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZalozKonto.Location = new System.Drawing.Point(136, 371);
            this.btnZalozKonto.Name = "btnZalozKonto";
            this.btnZalozKonto.Size = new System.Drawing.Size(225, 51);
            this.btnZalozKonto.TabIndex = 7;
            this.btnZalozKonto.Text = "Załóż konto";
            this.btnZalozKonto.UseVisualStyleBackColor = true;
            this.btnZalozKonto.Click += new System.EventHandler(this.btnZalozKonto_Click);
            // 
            // lblLinia
            // 
            this.lblLinia.AutoSize = true;
            this.lblLinia.Location = new System.Drawing.Point(45, 81);
            this.lblLinia.Name = "lblLinia";
            this.lblLinia.Size = new System.Drawing.Size(403, 13);
            this.lblLinia.TabIndex = 8;
            this.lblLinia.Text = "__________________________________________________________________";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLinia);
            this.Controls.Add(this.btnZalozKonto);
            this.Controls.Add(this.btnZaloguj);
            this.Controls.Add(this.lblWalidacjaLogowania);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblTytul);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label lblWalidacjaLogowania;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.Button btnZalozKonto;
        private System.Windows.Forms.Label lblLinia;
    }
}
