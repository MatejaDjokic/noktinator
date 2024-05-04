namespace Noktinator.Forms
{
    partial class ActionPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionPanel));
            this.deleteNailBtn = new System.Windows.Forms.Button();
            this.fingerView = new System.Windows.Forms.PictureBox();
            this.shapeInfoBtn = new System.Windows.Forms.Button();
            this.patterInfoBtn = new System.Windows.Forms.Button();
            this.skinInfoBtn = new System.Windows.Forms.Button();
            this.openDownloadsFolder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.setNailFromGallery = new System.Windows.Forms.Button();
            this.downloadNailImageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fingerView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteNailBtn
            // 
            this.deleteNailBtn.BackColor = System.Drawing.Color.Plum;
            this.deleteNailBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteNailBtn.BackgroundImage")));
            this.deleteNailBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteNailBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteNailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNailBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.deleteNailBtn.Location = new System.Drawing.Point(3, 3);
            this.deleteNailBtn.Name = "deleteNailBtn";
            this.deleteNailBtn.Size = new System.Drawing.Size(85, 44);
            this.deleteNailBtn.TabIndex = 3;
            this.deleteNailBtn.UseVisualStyleBackColor = false;
            this.deleteNailBtn.Click += new System.EventHandler(this.DeleteNailBtnClick);
            // 
            // fingerView
            // 
            this.fingerView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fingerView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fingerView.Location = new System.Drawing.Point(15, 11);
            this.fingerView.Margin = new System.Windows.Forms.Padding(2);
            this.fingerView.Name = "fingerView";
            this.fingerView.Size = new System.Drawing.Size(362, 291);
            this.fingerView.TabIndex = 5;
            this.fingerView.TabStop = false;
            // 
            // shapeInfoBtn
            // 
            this.shapeInfoBtn.BackColor = System.Drawing.Color.Plum;
            this.shapeInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapeInfoBtn.Location = new System.Drawing.Point(13, 309);
            this.shapeInfoBtn.Name = "shapeInfoBtn";
            this.shapeInfoBtn.Size = new System.Drawing.Size(365, 45);
            this.shapeInfoBtn.TabIndex = 0;
            this.shapeInfoBtn.Text = "Shape Info";
            this.shapeInfoBtn.UseVisualStyleBackColor = false;
            // 
            // patterInfoBtn
            // 
            this.patterInfoBtn.BackColor = System.Drawing.Color.Plum;
            this.patterInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patterInfoBtn.Location = new System.Drawing.Point(12, 360);
            this.patterInfoBtn.Name = "patterInfoBtn";
            this.patterInfoBtn.Size = new System.Drawing.Size(365, 45);
            this.patterInfoBtn.TabIndex = 1;
            this.patterInfoBtn.Text = "Pattern Info";
            this.patterInfoBtn.UseVisualStyleBackColor = false;
            // 
            // skinInfoBtn
            // 
            this.skinInfoBtn.BackColor = System.Drawing.Color.Plum;
            this.skinInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinInfoBtn.Location = new System.Drawing.Point(12, 411);
            this.skinInfoBtn.Name = "skinInfoBtn";
            this.skinInfoBtn.Size = new System.Drawing.Size(365, 45);
            this.skinInfoBtn.TabIndex = 2;
            this.skinInfoBtn.Text = "Skin Info";
            this.skinInfoBtn.UseVisualStyleBackColor = false;
            // 
            // openDownloadsFolder
            // 
            this.openDownloadsFolder.BackColor = System.Drawing.Color.Plum;
            this.openDownloadsFolder.BackgroundImage = global::Noktinator.Properties.Resources.download_folder;
            this.openDownloadsFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openDownloadsFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openDownloadsFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openDownloadsFolder.Location = new System.Drawing.Point(185, 3);
            this.openDownloadsFolder.Name = "openDownloadsFolder";
            this.openDownloadsFolder.Size = new System.Drawing.Size(85, 44);
            this.openDownloadsFolder.TabIndex = 5;
            this.openDownloadsFolder.UseVisualStyleBackColor = false;
            this.openDownloadsFolder.Click += new System.EventHandler(this.OpenDownloadsFolderClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.deleteNailBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.setNailFromGallery, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.openDownloadsFolder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.downloadNailImageBtn, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 462);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 50);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // setNailFromGallery
            // 
            this.setNailFromGallery.BackColor = System.Drawing.Color.Plum;
            this.setNailFromGallery.BackgroundImage = global::Noktinator.Properties.Resources.hands;
            this.setNailFromGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setNailFromGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setNailFromGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setNailFromGallery.Location = new System.Drawing.Point(94, 3);
            this.setNailFromGallery.Name = "setNailFromGallery";
            this.setNailFromGallery.Size = new System.Drawing.Size(85, 44);
            this.setNailFromGallery.TabIndex = 4;
            this.setNailFromGallery.UseVisualStyleBackColor = false;
            this.setNailFromGallery.Click += new System.EventHandler(this.SetNailFromGalleryClick);
            // 
            // downloadNailImageBtn
            // 
            this.downloadNailImageBtn.BackColor = System.Drawing.Color.Plum;
            this.downloadNailImageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downloadNailImageBtn.BackgroundImage")));
            this.downloadNailImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.downloadNailImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadNailImageBtn.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.downloadNailImageBtn.Location = new System.Drawing.Point(276, 3);
            this.downloadNailImageBtn.Name = "downloadNailImageBtn";
            this.downloadNailImageBtn.Size = new System.Drawing.Size(86, 44);
            this.downloadNailImageBtn.TabIndex = 6;
            this.downloadNailImageBtn.UseVisualStyleBackColor = false;
            // 
            // ActionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(390, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.skinInfoBtn);
            this.Controls.Add(this.patterInfoBtn);
            this.Controls.Add(this.shapeInfoBtn);
            this.Controls.Add(this.fingerView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActionPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Panel";
            this.Load += new System.EventHandler(this.ActionPanelLoad);
            ((System.ComponentModel.ISupportInitialize)(this.fingerView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteNailBtn;
        private System.Windows.Forms.PictureBox fingerView;
        private System.Windows.Forms.Button shapeInfoBtn;
        private System.Windows.Forms.Button patterInfoBtn;
        private System.Windows.Forms.Button skinInfoBtn;
        private System.Windows.Forms.Button openDownloadsFolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button setNailFromGallery;
        private System.Windows.Forms.Button downloadNailImageBtn;
    }
}