
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
            this.BojaNoktaButton = new System.Windows.Forms.Button();
            this.BojaPaterna = new System.Windows.Forms.Button();
            this.Buttons = new System.Windows.Forms.GroupBox();
            this.ResetDesign = new System.Windows.Forms.Button();
            this.addNailToGalleryButton = new System.Windows.Forms.Button();
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
            this.OblikNokta.Location = new System.Drawing.Point(0, 23);
            this.OblikNokta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OblikNokta.Name = "OblikNokta";
            this.OblikNokta.Size = new System.Drawing.Size(400, 92);
            this.OblikNokta.TabIndex = 1;
            this.OblikNokta.Text = "Nail Shape";
            this.OblikNokta.UseVisualStyleBackColor = false;
            this.OblikNokta.Click += new System.EventHandler(this.OblikNoktaClick);
            // 
            // Patern
            // 
            this.Patern.BackColor = System.Drawing.Color.Plum;
            this.Patern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patern.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Patern.Location = new System.Drawing.Point(0, 223);
            this.Patern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Patern.Name = "Patern";
            this.Patern.Size = new System.Drawing.Size(400, 92);
            this.Patern.TabIndex = 2;
            this.Patern.Text = "Pattern";
            this.Patern.UseVisualStyleBackColor = false;
            this.Patern.Click += new System.EventHandler(this.Patern_Click);
            // 
            // BojaNoktaButton
            // 
            this.BojaNoktaButton.BackColor = System.Drawing.Color.Plum;
            this.BojaNoktaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BojaNoktaButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BojaNoktaButton.Location = new System.Drawing.Point(0, 123);
            this.BojaNoktaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BojaNoktaButton.Name = "BojaNoktaButton";
            this.BojaNoktaButton.Size = new System.Drawing.Size(400, 92);
            this.BojaNoktaButton.TabIndex = 3;
            this.BojaNoktaButton.Text = "Nail Color";
            this.BojaNoktaButton.UseVisualStyleBackColor = false;
            this.BojaNoktaButton.Click += new System.EventHandler(this.BojaNoktaButtonClick);
            // 
            // BojaPaterna
            // 
            this.BojaPaterna.BackColor = System.Drawing.Color.Plum;
            this.BojaPaterna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BojaPaterna.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BojaPaterna.Location = new System.Drawing.Point(0, 322);
            this.BojaPaterna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BojaPaterna.Name = "BojaPaterna";
            this.BojaPaterna.Size = new System.Drawing.Size(400, 92);
            this.BojaPaterna.TabIndex = 4;
            this.BojaPaterna.Text = "Pattern Color";
            this.BojaPaterna.UseVisualStyleBackColor = false;
            this.BojaPaterna.Click += new System.EventHandler(this.BojaPaternaButtonClick);
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.ResetDesign);
            this.Buttons.Controls.Add(this.addNailToGalleryButton);
            this.Buttons.Controls.Add(this.Rasa);
            this.Buttons.Controls.Add(this.OblikNokta);
            this.Buttons.Controls.Add(this.BojaPaterna);
            this.Buttons.Controls.Add(this.Patern);
            this.Buttons.Controls.Add(this.BojaNoktaButton);
            this.Buttons.Location = new System.Drawing.Point(953, 34);
            this.Buttons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buttons.Name = "Buttons";
            this.Buttons.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buttons.Size = new System.Drawing.Size(400, 715);
            this.Buttons.TabIndex = 5;
            this.Buttons.TabStop = false;
            // 
            // ResetDesign
            // 
            this.ResetDesign.BackColor = System.Drawing.Color.Plum;
            this.ResetDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetDesign.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ResetDesign.Location = new System.Drawing.Point(0, 622);
            this.ResetDesign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetDesign.Name = "ResetDesign";
            this.ResetDesign.Size = new System.Drawing.Size(400, 92);
            this.ResetDesign.TabIndex = 9;
            this.ResetDesign.Text = "Reset Design";
            this.ResetDesign.UseVisualStyleBackColor = false;
            this.ResetDesign.Click += new System.EventHandler(this.ResetDesignButtonClick);
            // 
            // addNailToGalleryButton
            // 
            this.addNailToGalleryButton.BackColor = System.Drawing.Color.Plum;
            this.addNailToGalleryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNailToGalleryButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addNailToGalleryButton.Location = new System.Drawing.Point(0, 522);
            this.addNailToGalleryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNailToGalleryButton.Name = "addNailToGalleryButton";
            this.addNailToGalleryButton.Size = new System.Drawing.Size(400, 92);
            this.addNailToGalleryButton.TabIndex = 8;
            this.addNailToGalleryButton.Text = "Add To Gallery";
            this.addNailToGalleryButton.UseVisualStyleBackColor = false;
            this.addNailToGalleryButton.Click += new System.EventHandler(this.AddNailToGalleryButtonClick);
            // 
            // Rasa
            // 
            this.Rasa.BackColor = System.Drawing.Color.Plum;
            this.Rasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rasa.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Rasa.Location = new System.Drawing.Point(0, 422);
            this.Rasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rasa.Name = "Rasa";
            this.Rasa.Size = new System.Drawing.Size(400, 92);
            this.Rasa.TabIndex = 7;
            this.Rasa.Text = "Skin Color";
            this.Rasa.UseVisualStyleBackColor = false;
            this.Rasa.Click += new System.EventHandler(this.RasaClick);
            // 
            // fingerView
            // 
            this.fingerView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fingerView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fingerView.Location = new System.Drawing.Point(288, 20);
            this.fingerView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fingerView.Name = "fingerView";
            this.fingerView.Size = new System.Drawing.Size(279, 745);
            this.fingerView.TabIndex = 6;
            this.fingerView.TabStop = false;
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.Color.Plum;
            this.Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nazad.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Nazad.Location = new System.Drawing.Point(16, 15);
            this.Nazad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(67, 62);
            this.Nazad.TabIndex = 7;
            this.Nazad.Text = "<";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.BackButttonClick);
            // 
            // FingerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1576, 804);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.fingerView);
            this.Controls.Add(this.Buttons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(1594, 851);
            this.MinimumSize = new System.Drawing.Size(1594, 851);
            this.Name = "FingerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nail Designer";
            this.Load += new System.EventHandler(this.FingerMenuLoad);
            this.VisibleChanged += new System.EventHandler(this.FingerMenuVisibleChanged);
            this.Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fingerView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OblikNokta;
        private System.Windows.Forms.Button Patern;
        private System.Windows.Forms.Button BojaNoktaButton;
        private System.Windows.Forms.Button BojaPaterna;
        private System.Windows.Forms.GroupBox Buttons;
        private System.Windows.Forms.ColorDialog NokatColorDialog;
        private System.Windows.Forms.ColorDialog PaternColorDialog;
        private System.Windows.Forms.PictureBox fingerView;
        private System.Windows.Forms.Button Rasa;
        private System.Windows.Forms.ColorDialog RasaColorDialog;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button addNailToGalleryButton;
        private System.Windows.Forms.Button ResetDesign;
    }
}