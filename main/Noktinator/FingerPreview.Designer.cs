
namespace Noktinator
{
    partial class FingerPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerPreview));
            this.LittleFinger = new System.Windows.Forms.PictureBox();
            this.RingFinger = new System.Windows.Forms.PictureBox();
            this.MiddleFinger = new System.Windows.Forms.PictureBox();
            this.IndexFinger = new System.Windows.Forms.PictureBox();
            this.Thumb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaliCopy = new System.Windows.Forms.Button();
            this.MaliPaste = new System.Windows.Forms.Button();
            this.DomaliCopy = new System.Windows.Forms.Button();
            this.DomaliPaste = new System.Windows.Forms.Button();
            this.SrednjiCopy = new System.Windows.Forms.Button();
            this.SrednjiPaste = new System.Windows.Forms.Button();
            this.KaziCopy = new System.Windows.Forms.Button();
            this.KaziPaste = new System.Windows.Forms.Button();
            this.PalacCopy = new System.Windows.Forms.Button();
            this.PalacPaste = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LittleFinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RingFinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleFinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexFinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumb)).BeginInit();
            this.SuspendLayout();
            // 
            // MaliPrst
            // 
            this.LittleFinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LittleFinger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LittleFinger.Location = new System.Drawing.Point(135, 165);
            this.LittleFinger.Name = "MaliPrst";
            this.LittleFinger.Size = new System.Drawing.Size(95, 275);
            this.LittleFinger.TabIndex = 0;
            this.LittleFinger.TabStop = false;
            this.LittleFinger.Click += new System.EventHandler(this.LittleFingerClick);
            this.LittleFinger.MouseEnter += new System.EventHandler(this.Darken);
            this.LittleFinger.MouseLeave += new System.EventHandler(this.Lighten);
            // 
            // DomaliPrst
            // 
            this.RingFinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RingFinger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RingFinger.Location = new System.Drawing.Point(340, 165);
            this.RingFinger.Name = "DomaliPrst";
            this.RingFinger.Size = new System.Drawing.Size(95, 275);
            this.RingFinger.TabIndex = 1;
            this.RingFinger.TabStop = false;
            this.RingFinger.Click += new System.EventHandler(this.RingFingerClick);
            this.RingFinger.MouseEnter += new System.EventHandler(this.Darken);
            this.RingFinger.MouseLeave += new System.EventHandler(this.Lighten);
            // 
            // SrednjiPrst
            // 
            this.MiddleFinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MiddleFinger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleFinger.Location = new System.Drawing.Point(545, 165);
            this.MiddleFinger.Name = "SrednjiPrst";
            this.MiddleFinger.Size = new System.Drawing.Size(95, 275);
            this.MiddleFinger.TabIndex = 2;
            this.MiddleFinger.TabStop = false;
            this.MiddleFinger.Click += new System.EventHandler(this.MiddleFingerClick);
            this.MiddleFinger.MouseEnter += new System.EventHandler(this.Darken);
            this.MiddleFinger.MouseLeave += new System.EventHandler(this.Lighten);
            // 
            // KaziPrst
            // 
            this.IndexFinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IndexFinger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IndexFinger.Location = new System.Drawing.Point(750, 165);
            this.IndexFinger.Name = "KaziPrst";
            this.IndexFinger.Size = new System.Drawing.Size(95, 275);
            this.IndexFinger.TabIndex = 3;
            this.IndexFinger.TabStop = false;
            this.IndexFinger.Click += new System.EventHandler(this.IndexFingerClick);
            this.IndexFinger.MouseEnter += new System.EventHandler(this.Darken);
            this.IndexFinger.MouseLeave += new System.EventHandler(this.Lighten);
            // 
            // Palac
            // 
            this.Thumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Thumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Thumb.Location = new System.Drawing.Point(955, 165);
            this.Thumb.Name = "Palac";
            this.Thumb.Size = new System.Drawing.Size(95, 275);
            this.Thumb.TabIndex = 4;
            this.Thumb.TabStop = false;
            this.Thumb.Click += new System.EventHandler(this.ThumbClick);
            this.Thumb.MouseEnter += new System.EventHandler(this.Darken);
            this.Thumb.MouseLeave += new System.EventHandler(this.Lighten);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mali prst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Srednji prst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "Domali prst";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(750, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kaziprst";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(970, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Palac";
            // 
            // MaliCopy
            // 
            this.MaliCopy.BackColor = System.Drawing.Color.Plum;
            this.MaliCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaliCopy.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MaliCopy.Location = new System.Drawing.Point(135, 446);
            this.MaliCopy.Name = "MaliCopy";
            this.MaliCopy.Size = new System.Drawing.Size(44, 44);
            this.MaliCopy.TabIndex = 17;
            this.MaliCopy.Text = "C";
            this.MaliCopy.UseVisualStyleBackColor = false;
            this.MaliCopy.Click += new System.EventHandler(this.MaliCopy_Click);
            // 
            // MaliPaste
            // 
            this.MaliPaste.BackColor = System.Drawing.Color.Plum;
            this.MaliPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaliPaste.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MaliPaste.Location = new System.Drawing.Point(186, 446);
            this.MaliPaste.Name = "MaliPaste";
            this.MaliPaste.Size = new System.Drawing.Size(44, 44);
            this.MaliPaste.TabIndex = 18;
            this.MaliPaste.Text = "P";
            this.MaliPaste.UseVisualStyleBackColor = false;
            this.MaliPaste.Click += new System.EventHandler(this.MaliPaste_Click);
            // 
            // DomaliCopy
            // 
            this.DomaliCopy.BackColor = System.Drawing.Color.Plum;
            this.DomaliCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DomaliCopy.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DomaliCopy.Location = new System.Drawing.Point(340, 446);
            this.DomaliCopy.Name = "DomaliCopy";
            this.DomaliCopy.Size = new System.Drawing.Size(44, 44);
            this.DomaliCopy.TabIndex = 19;
            this.DomaliCopy.Text = "C";
            this.DomaliCopy.UseVisualStyleBackColor = false;
            this.DomaliCopy.Click += new System.EventHandler(this.DomaliCopy_Click);
            // 
            // DomaliPaste
            // 
            this.DomaliPaste.BackColor = System.Drawing.Color.Plum;
            this.DomaliPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DomaliPaste.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DomaliPaste.Location = new System.Drawing.Point(391, 446);
            this.DomaliPaste.Name = "DomaliPaste";
            this.DomaliPaste.Size = new System.Drawing.Size(44, 44);
            this.DomaliPaste.TabIndex = 20;
            this.DomaliPaste.Text = "P";
            this.DomaliPaste.UseVisualStyleBackColor = false;
            this.DomaliPaste.Click += new System.EventHandler(this.DomaliPaste_Click);
            // 
            // SrednjiCopy
            // 
            this.SrednjiCopy.BackColor = System.Drawing.Color.Plum;
            this.SrednjiCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SrednjiCopy.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SrednjiCopy.Location = new System.Drawing.Point(545, 446);
            this.SrednjiCopy.Name = "SrednjiCopy";
            this.SrednjiCopy.Size = new System.Drawing.Size(44, 44);
            this.SrednjiCopy.TabIndex = 21;
            this.SrednjiCopy.Text = "C";
            this.SrednjiCopy.UseVisualStyleBackColor = false;
            this.SrednjiCopy.Click += new System.EventHandler(this.SrednjiCopy_Click);
            // 
            // SrednjiPaste
            // 
            this.SrednjiPaste.BackColor = System.Drawing.Color.Plum;
            this.SrednjiPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SrednjiPaste.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SrednjiPaste.Location = new System.Drawing.Point(596, 446);
            this.SrednjiPaste.Name = "SrednjiPaste";
            this.SrednjiPaste.Size = new System.Drawing.Size(44, 44);
            this.SrednjiPaste.TabIndex = 22;
            this.SrednjiPaste.Text = "P";
            this.SrednjiPaste.UseVisualStyleBackColor = false;
            this.SrednjiPaste.Click += new System.EventHandler(this.SrednjiPaste_Click);
            // 
            // KaziCopy
            // 
            this.KaziCopy.BackColor = System.Drawing.Color.Plum;
            this.KaziCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaziCopy.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.KaziCopy.Location = new System.Drawing.Point(750, 446);
            this.KaziCopy.Name = "KaziCopy";
            this.KaziCopy.Size = new System.Drawing.Size(44, 44);
            this.KaziCopy.TabIndex = 23;
            this.KaziCopy.Text = "C";
            this.KaziCopy.UseVisualStyleBackColor = false;
            this.KaziCopy.Click += new System.EventHandler(this.KaziCopy_Click);
            // 
            // KaziPaste
            // 
            this.KaziPaste.BackColor = System.Drawing.Color.Plum;
            this.KaziPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaziPaste.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.KaziPaste.Location = new System.Drawing.Point(801, 446);
            this.KaziPaste.Name = "KaziPaste";
            this.KaziPaste.Size = new System.Drawing.Size(44, 44);
            this.KaziPaste.TabIndex = 24;
            this.KaziPaste.Text = "P";
            this.KaziPaste.UseVisualStyleBackColor = false;
            this.KaziPaste.Click += new System.EventHandler(this.KaziPaste_Click);
            // 
            // PalacCopy
            // 
            this.PalacCopy.BackColor = System.Drawing.Color.Plum;
            this.PalacCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PalacCopy.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PalacCopy.Location = new System.Drawing.Point(955, 446);
            this.PalacCopy.Name = "PalacCopy";
            this.PalacCopy.Size = new System.Drawing.Size(44, 44);
            this.PalacCopy.TabIndex = 25;
            this.PalacCopy.Text = "C";
            this.PalacCopy.UseVisualStyleBackColor = false;
            this.PalacCopy.Click += new System.EventHandler(this.PalacCopy_Click);
            // 
            // PalacPaste
            // 
            this.PalacPaste.BackColor = System.Drawing.Color.Plum;
            this.PalacPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PalacPaste.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PalacPaste.Location = new System.Drawing.Point(1006, 446);
            this.PalacPaste.Name = "PalacPaste";
            this.PalacPaste.Size = new System.Drawing.Size(44, 44);
            this.PalacPaste.TabIndex = 26;
            this.PalacPaste.Text = "P";
            this.PalacPaste.UseVisualStyleBackColor = false;
            this.PalacPaste.Click += new System.EventHandler(this.PalacPaste_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 85);
            this.label6.TabIndex = 27;
            this.label6.Text = "Izaberite Nokat";
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.Color.Plum;
            this.Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nazad.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Nazad.Location = new System.Drawing.Point(12, 609);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(121, 40);
            this.Nazad.TabIndex = 28;
            this.Nazad.Text = "Nazad";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // FingerPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PalacPaste);
            this.Controls.Add(this.PalacCopy);
            this.Controls.Add(this.KaziPaste);
            this.Controls.Add(this.KaziCopy);
            this.Controls.Add(this.SrednjiPaste);
            this.Controls.Add(this.SrednjiCopy);
            this.Controls.Add(this.DomaliPaste);
            this.Controls.Add(this.DomaliCopy);
            this.Controls.Add(this.MaliPaste);
            this.Controls.Add(this.MaliCopy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Thumb);
            this.Controls.Add(this.IndexFinger);
            this.Controls.Add(this.MiddleFinger);
            this.Controls.Add(this.RingFinger);
            this.Controls.Add(this.LittleFinger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FingerPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FingerPreview";
            ((System.ComponentModel.ISupportInitialize)(this.LittleFinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RingFinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleFinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexFinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LittleFinger;
        private System.Windows.Forms.PictureBox RingFinger;
        private System.Windows.Forms.PictureBox MiddleFinger;
        private System.Windows.Forms.PictureBox IndexFinger;
        private System.Windows.Forms.PictureBox Thumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MaliCopy;
        private System.Windows.Forms.Button MaliPaste;
        private System.Windows.Forms.Button DomaliCopy;
        private System.Windows.Forms.Button DomaliPaste;
        private System.Windows.Forms.Button SrednjiCopy;
        private System.Windows.Forms.Button SrednjiPaste;
        private System.Windows.Forms.Button KaziCopy;
        private System.Windows.Forms.Button KaziPaste;
        private System.Windows.Forms.Button PalacCopy;
        private System.Windows.Forms.Button PalacPaste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Nazad;
    }
}