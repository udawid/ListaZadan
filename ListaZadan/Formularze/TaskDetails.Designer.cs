
namespace ListaZadan.Formularze
{
    partial class TaskDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumerText = new System.Windows.Forms.Label();
            this.lblNumer = new System.Windows.Forms.Label();
            this.lblTytulText = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.cbIsReady = new System.Windows.Forms.CheckBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumerText
            // 
            this.lblNumerText.AutoSize = true;
            this.lblNumerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumerText.Location = new System.Drawing.Point(18, 14);
            this.lblNumerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumerText.Name = "lblNumerText";
            this.lblNumerText.Size = new System.Drawing.Size(123, 37);
            this.lblNumerText.TabIndex = 5;
            this.lblNumerText.Text = "Numer:";
            this.lblNumerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumer
            // 
            this.lblNumer.AutoSize = true;
            this.lblNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumer.Location = new System.Drawing.Point(130, 14);
            this.lblNumer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumer.Name = "lblNumer";
            this.lblNumer.Size = new System.Drawing.Size(72, 37);
            this.lblNumer.TabIndex = 6;
            this.lblNumer.Text = "123";
            this.lblNumer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTytulText
            // 
            this.lblTytulText.AutoSize = true;
            this.lblTytulText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytulText.Location = new System.Drawing.Point(42, 74);
            this.lblTytulText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTytulText.Name = "lblTytulText";
            this.lblTytulText.Size = new System.Drawing.Size(101, 37);
            this.lblTytulText.TabIndex = 7;
            this.lblTytulText.Text = "Tytuł:";
            this.lblTytulText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTitle.Location = new System.Drawing.Point(140, 69);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(613, 43);
            this.tbTitle.TabIndex = 8;
            // 
            // cbIsReady
            // 
            this.cbIsReady.AutoSize = true;
            this.cbIsReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbIsReady.Location = new System.Drawing.Point(764, 74);
            this.cbIsReady.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIsReady.Name = "cbIsReady";
            this.cbIsReady.Size = new System.Drawing.Size(294, 41);
            this.cbIsReady.TabIndex = 9;
            this.cbIsReady.Text = "Czy zakończone?";
            this.cbIsReady.UseVisualStyleBackColor = true;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(42, 134);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(92, 37);
            this.lblOpis.TabIndex = 10;
            this.lblOpis.Text = "Opis:";
            this.lblOpis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDescription.Location = new System.Drawing.Point(138, 134);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(926, 116);
            this.tbDescription.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(137, 271);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(196, 218);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "💾";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TaskDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 515);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.cbIsReady);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblTytulText);
            this.Controls.Add(this.lblNumer);
            this.Controls.Add(this.lblNumerText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaskDetails";
            this.Text = "Zadanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumerText;
        private System.Windows.Forms.Label lblNumer;
        private System.Windows.Forms.Label lblTytulText;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.CheckBox cbIsReady;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnSave;
    }
}