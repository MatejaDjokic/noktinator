
namespace Noktinator
{
    partial class FingerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerMenu));
            this.OblikNokta = new System.Windows.Forms.Button();
            this.Patern = new System.Windows.Forms.Button();
            this.BojaNokta = new System.Windows.Forms.Button();
            this.BojaPaterna = new System.Windows.Forms.Button();
            this.Buttons = new System.Windows.Forms.GroupBox();
            this.ResetDesign = new System.Windows.Forms.Button();
            this.Galerija = new System.Windows.Forms.Button();
            this.Rasa = new System.Windows.Forms.Button();
            this.NokatColorDialog = new System.Windows.Forms.ColorDialog();
            this.PaternColorDialog = new System.Windows.Forms.ColorDialog();
            this.fingerView = new System.Windows.Forms.PictureBox();
            this.RasaColorDialog = new System.Windows.Forms.ColorDialog();
            this.Nazad = new System.Windows.Forms.Button();
            this.Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerView)).BeginInit();
            this.SuspendLayout();
            // 
            // OblikNokta
            // 
            this.OblikNokta.BackColor = System.Drawing.Color.Plum;
            this.OblikNokta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OblikNokta.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.OblikNokta.Location = new System.Drawing.Point(0, 19);
            this.OblikNokta.Name = "OblikNokta";
            this.OblikNokta.Size = new System.Drawing.Size(300, 75);
            this.OblikNokta.TabIndex = 1;
            this.OblikNokta.Text = "Oblik nokta";
            this.OblikNokta.UseVisualStyleBackColor = false;
            this.OblikNokta.Click += new System.EventHandler(this.OblikNoktaClick);
            // 
            // Patern
            // 
            this.Patern.BackColor = System.Drawing.Color.Plum;
            this.Patern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patern.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Patern.Location = new System.Drawing.Point(0, 181);
            this.Patern.Name = "Patern";
            this.Patern.Size = new System.Drawing.Size(300, 75);
            this.Patern.TabIndex = 2;
            this.Patern.Text = "Patern";
            this.Patern.UseVisualStyleBackColor = false;
            this.Patern.Click += new System.EventHandler(this.Patern_Click);
            // 
            // BojaNokta
            // 
            this.BojaNokta.BackColor = System.Drawing.Color.Plum;
            this.BojaNokta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BojaNokta.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BojaNokta.Location = new System.Drawing.Point(0, 100);
            this.BojaNokta.Name = "BojaNokta";
            this.BojaNokta.Size = new System.Drawing.Size(300, 75);
            this.BojaNokta.TabIndex = 3;
            this.BojaNokta.Text = "Boja nokta";
            this.BojaNokta.UseVisualStyleBackColor = false;
            this.BojaNokta.Click += new System.EventHandler(this.BojaNoktaClick);
            // 
            // BojaPaterna
            // 
            this.BojaPaterna.BackColor = System.Drawing.Color.Plum;
            this.BojaPaterna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BojaPaterna.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BojaPaterna.Location = new System.Drawing.Point(0, 262);
            this.BojaPaterna.Name = "BojaPaterna";
            this.BojaPaterna.Size = new System.Drawing.Size(300, 75);
            this.BojaPaterna.TabIndex = 4;
            this.BojaPaterna.Text = "Boja paterna";
            this.BojaPaterna.UseVisualStyleBackColor = false;
            this.BojaPaterna.Click += new System.EventHandler(this.BojaPaternaClick);
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.ResetDesign);
            this.Buttons.Controls.Add(this.Galerija);
            this.Buttons.Controls.Add(this.Rasa);
            this.Buttons.Controls.Add(this.OblikNokta);
            this.Buttons.Controls.Add(this.BojaPaterna);
            this.Buttons.Controls.Add(this.Patern);
            this.Buttons.Controls.Add(this.BojaNokta);
            this.Buttons.Location = new System.Drawing.Point(715, 28);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(300, 581);
            this.Buttons.TabIndex = 5;
            this.Buttons.TabStop = false;
            // 
            // ResetDesign
            // 
            this.ResetDesign.BackColor = System.Drawing.Color.Plum;
            this.ResetDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetDesign.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ResetDesign.Location = new System.Drawing.Point(0, 505);
            this.ResetDesign.Name = "ResetDesign";
            this.ResetDesign.Size = new System.Drawing.Size(300, 75);
            this.ResetDesign.TabIndex = 9;
            this.ResetDesign.Text = "Resetuj dizajn";
            this.ResetDesign.UseVisualStyleBackColor = false;
            this.ResetDesign.Click += new System.EventHandler(this.ResetDesign_Click);
            // 
            // Galerija
            // 
            this.Galerija.BackColor = System.Drawing.Color.Plum;
            this.Galerija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Galerija.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Galerija.Location = new System.Drawing.Point(0, 424);
            this.Galerija.Name = "Galerija";
            this.Galerija.Size = new System.Drawing.Size(300, 75);
            this.Galerija.TabIndex = 8;
            this.Galerija.Text = "Dodaj u galeriju";
            this.Galerija.UseVisualStyleBackColor = false;
            this.Galerija.Click += new System.EventHandler(this.GalerijaClick);
            // 
            // Rasa
            // 
            this.Rasa.BackColor = System.Drawing.Color.Plum;
            this.Rasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rasa.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Rasa.Location = new System.Drawing.Point(0, 343);
            this.Rasa.Name = "Rasa";
            this.Rasa.Size = new System.Drawing.Size(300, 75);
            this.Rasa.TabIndex = 7;
            this.Rasa.Text = "Boja koze";
            this.Rasa.UseVisualStyleBackColor = false;
            this.Rasa.Click += new System.EventHandler(this.RasaClick);
            // 
            // fingerView
            // 
            this.fingerView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fingerView.Location = new System.Drawing.Point(216, 16);
            this.fingerView.Name = "fingerView";
            this.fingerView.Size = new System.Drawing.Size(209, 605);
            this.fingerView.TabIndex = 6;
            this.fingerView.TabStop = false;
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.Color.Plum;
            this.Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nazad.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Nazad.Location = new System.Drawing.Point(12, 12);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(50, 50);
            this.Nazad.TabIndex = 7;
            this.Nazad.Text = "<";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // FingerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.fingerView);
            this.Controls.Add(this.Buttons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FingerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FingerMenu";
            this.Load += new System.EventHandler(this.FingerMenuLoad);
            this.VisibleChanged += new System.EventHandler(this.FingerMenuVisibleChanged);
            this.Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fingerView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OblikNokta;
        private System.Windows.Forms.Button Patern;
        private System.Windows.Forms.Button BojaNokta;
        private System.Windows.Forms.Button BojaPaterna;
        private System.Windows.Forms.GroupBox Buttons;
        private System.Windows.Forms.ColorDialog NokatColorDialog;
        private System.Windows.Forms.ColorDialog PaternColorDialog;
        private System.Windows.Forms.PictureBox fingerView;
        private System.Windows.Forms.Button Rasa;
        private System.Windows.Forms.ColorDialog RasaColorDialog;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button Galerija;
        private System.Windows.Forms.Button ResetDesign;
    }
}