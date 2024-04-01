
namespace Noktinator
{
    partial class ChoosePattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosePattern));
            this.FireStyle = new System.Windows.Forms.PictureBox();
            this.LeafStyle = new System.Windows.Forms.PictureBox();
            this.StarsStyle = new System.Windows.Forms.PictureBox();
            this.HeartsStyle = new System.Windows.Forms.PictureBox();
            this.LeavesStyle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FireStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeafStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StarsStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartsStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeavesStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // FireStyle
            // 
            this.FireStyle.BackgroundImage = global::Noktinator.Properties.Resources.FireStyle;
            this.FireStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FireStyle.Location = new System.Drawing.Point(12, 12);
            this.FireStyle.Name = "FireStyle";
            this.FireStyle.Size = new System.Drawing.Size(95, 190);
            this.FireStyle.TabIndex = 0;
            this.FireStyle.TabStop = false;
            this.FireStyle.Click += new System.EventHandler(this.FireStyle_Click);
            // 
            // LeafStyle
            // 
            this.LeafStyle.BackgroundImage = global::Noktinator.Properties.Resources.LeafStyle;
            this.LeafStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LeafStyle.Location = new System.Drawing.Point(118, 12);
            this.LeafStyle.Name = "LeafStyle";
            this.LeafStyle.Size = new System.Drawing.Size(95, 190);
            this.LeafStyle.TabIndex = 1;
            this.LeafStyle.TabStop = false;
            this.LeafStyle.Click += new System.EventHandler(this.LeafStyle_Click);
            // 
            // StarsStyle
            // 
            this.StarsStyle.BackgroundImage = global::Noktinator.Properties.Resources.StarsStyle;
            this.StarsStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StarsStyle.Location = new System.Drawing.Point(224, 12);
            this.StarsStyle.Name = "StarsStyle";
            this.StarsStyle.Size = new System.Drawing.Size(95, 190);
            this.StarsStyle.TabIndex = 2;
            this.StarsStyle.TabStop = false;
            this.StarsStyle.Click += new System.EventHandler(this.StarsStyle_Click);
            // 
            // HeartsStyle
            // 
            this.HeartsStyle.BackgroundImage = global::Noktinator.Properties.Resources.HeartsStyle;
            this.HeartsStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HeartsStyle.Location = new System.Drawing.Point(330, 12);
            this.HeartsStyle.Name = "HeartsStyle";
            this.HeartsStyle.Size = new System.Drawing.Size(95, 190);
            this.HeartsStyle.TabIndex = 3;
            this.HeartsStyle.TabStop = false;
            this.HeartsStyle.Click += new System.EventHandler(this.HeartsStyle_Click);
            // 
            // LeavesStyle
            // 
            this.LeavesStyle.BackgroundImage = global::Noktinator.Properties.Resources.LeavesStyle;
            this.LeavesStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LeavesStyle.Location = new System.Drawing.Point(436, 12);
            this.LeavesStyle.Name = "LeavesStyle";
            this.LeavesStyle.Size = new System.Drawing.Size(95, 190);
            this.LeavesStyle.TabIndex = 4;
            this.LeavesStyle.TabStop = false;
            this.LeavesStyle.Click += new System.EventHandler(this.LeavesStyle_Click);
            // 
            // ChoosePattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.LeavesStyle);
            this.Controls.Add(this.HeartsStyle);
            this.Controls.Add(this.StarsStyle);
            this.Controls.Add(this.LeafStyle);
            this.Controls.Add(this.FireStyle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "ChoosePattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoosePattern";
            ((System.ComponentModel.ISupportInitialize)(this.FireStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeafStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StarsStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartsStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeavesStyle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FireStyle;
        private System.Windows.Forms.PictureBox LeafStyle;
        private System.Windows.Forms.PictureBox StarsStyle;
        private System.Windows.Forms.PictureBox HeartsStyle;
        private System.Windows.Forms.PictureBox LeavesStyle;
    }
}