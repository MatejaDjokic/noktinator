namespace Noktinator.Forms
{
    partial class DeleteOrDownload
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
            this.Delete = new System.Windows.Forms.Button();
            this.Install = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fingerView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fingerView)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Plum;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Delete.Location = new System.Drawing.Point(13, 178);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(400, 92);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Izbrisi";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Install
            // 
            this.Install.BackColor = System.Drawing.Color.Plum;
            this.Install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Install.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Install.Location = new System.Drawing.Point(13, 278);
            this.Install.Margin = new System.Windows.Forms.Padding(4);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(400, 92);
            this.Install.TabIndex = 3;
            this.Install.Text = "Skini sliku";
            this.Install.UseVisualStyleBackColor = false;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 94);
            this.label1.TabIndex = 4;
            this.label1.Text = "Koju akciju zelite da izvrsite \r\nsa noktom?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fingerView
            // 
            this.fingerView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fingerView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fingerView.Location = new System.Drawing.Point(474, 35);
            this.fingerView.Name = "fingerView";
            this.fingerView.Size = new System.Drawing.Size(253, 335);
            this.fingerView.TabIndex = 5;
            this.fingerView.TabStop = false;
            // 
            // DeleteOrDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(779, 383);
            this.Controls.Add(this.fingerView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Install);
            this.Controls.Add(this.Delete);
            this.Name = "DeleteOrDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteOrDownload";
            this.Load += new System.EventHandler(this.DeleteOrDownload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fingerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fingerView;
    }
}