
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
            this.fingerView1 = new Noktinator.FingerView();
            this.OblikNokta = new System.Windows.Forms.Button();
            this.Patern = new System.Windows.Forms.Button();
            this.BojaNokta = new System.Windows.Forms.Button();
            this.BojaPaterna = new System.Windows.Forms.Button();
            this.Buttons = new System.Windows.Forms.GroupBox();
            this.NokatColorDialog = new System.Windows.Forms.ColorDialog();
            this.PaternColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fingerView1)).BeginInit();
            this.Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // fingerView1
            // 
            this.fingerView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fingerView1.BackgroundImage")));
            this.fingerView1.Location = new System.Drawing.Point(48, 50);
            this.fingerView1.Name = "fingerView1";
            this.fingerView1.Size = new System.Drawing.Size(600, 600);
            this.fingerView1.TabIndex = 0;
            this.fingerView1.TabStop = false;
            // 
            // OblikNokta
            // 
            this.OblikNokta.BackColor = System.Drawing.Color.Plum;
            this.OblikNokta.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.OblikNokta.Location = new System.Drawing.Point(0, 19);
            this.OblikNokta.Name = "OblikNokta";
            this.OblikNokta.Size = new System.Drawing.Size(300, 75);
            this.OblikNokta.TabIndex = 1;
            this.OblikNokta.Text = "oblik nokta";
            this.OblikNokta.UseVisualStyleBackColor = false;
            // 
            // Patern
            // 
            this.Patern.BackColor = System.Drawing.Color.Plum;
            this.Patern.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Patern.Location = new System.Drawing.Point(0, 181);
            this.Patern.Name = "Patern";
            this.Patern.Size = new System.Drawing.Size(300, 75);
            this.Patern.TabIndex = 2;
            this.Patern.Text = "patern";
            this.Patern.UseVisualStyleBackColor = false;
            // 
            // BojaNokta
            // 
            this.BojaNokta.BackColor = System.Drawing.Color.Plum;
            this.BojaNokta.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BojaNokta.Location = new System.Drawing.Point(0, 100);
            this.BojaNokta.Name = "BojaNokta";
            this.BojaNokta.Size = new System.Drawing.Size(300, 75);
            this.BojaNokta.TabIndex = 3;
            this.BojaNokta.Text = "boja nokta";
            this.BojaNokta.UseVisualStyleBackColor = false;
            this.BojaNokta.Click += new System.EventHandler(this.BojaNokta_Click);
            // 
            // BojaPaterna
            // 
            this.BojaPaterna.BackColor = System.Drawing.Color.Plum;
            this.BojaPaterna.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BojaPaterna.Location = new System.Drawing.Point(0, 262);
            this.BojaPaterna.Name = "BojaPaterna";
            this.BojaPaterna.Size = new System.Drawing.Size(300, 75);
            this.BojaPaterna.TabIndex = 4;
            this.BojaPaterna.Text = "boja paterna";
            this.BojaPaterna.UseVisualStyleBackColor = false;
            this.BojaPaterna.Click += new System.EventHandler(this.BojaPaterna_Click);
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.OblikNokta);
            this.Buttons.Controls.Add(this.BojaPaterna);
            this.Buttons.Controls.Add(this.Patern);
            this.Buttons.Controls.Add(this.BojaNokta);
            this.Buttons.Location = new System.Drawing.Point(705, 180);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(300, 340);
            this.Buttons.TabIndex = 5;
            this.Buttons.TabStop = false;
            this.Buttons.Text = "Buttons";
            // 
            // FingerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Buttons);
            this.Controls.Add(this.fingerView1);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FingerMenu";
            this.Text = "FingerMenu";
            ((System.ComponentModel.ISupportInitialize)(this.fingerView1)).EndInit();
            this.Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FingerView fingerView1;
        private System.Windows.Forms.Button OblikNokta;
        private System.Windows.Forms.Button Patern;
        private System.Windows.Forms.Button BojaNokta;
        private System.Windows.Forms.Button BojaPaterna;
        private System.Windows.Forms.GroupBox Buttons;
        private System.Windows.Forms.ColorDialog NokatColorDialog;
        private System.Windows.Forms.ColorDialog PaternColorDialog;
    }
}