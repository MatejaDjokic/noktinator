using System.Drawing;
using System.Windows.Forms;

namespace Noktinator
{
    partial class NailGallery
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
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.fullRight = new System.Windows.Forms.Button();
            this.fullLeft = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.pagination = new System.Windows.Forms.TableLayoutPanel();
            this.itemInPageLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openJson = new System.Windows.Forms.Button();
            this.pagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnCount = 4;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grid.Location = new System.Drawing.Point(92, 12);
            this.grid.Name = "grid";
            this.grid.RowCount = 3;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.grid.Size = new System.Drawing.Size(1000, 587);
            this.grid.TabIndex = 6;
            // 
            // fullRight
            // 
            this.fullRight.BackColor = System.Drawing.Color.Plum;
            this.fullRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.fullRight.Location = new System.Drawing.Point(675, 3);
            this.fullRight.Name = "fullRight";
            this.fullRight.Size = new System.Drawing.Size(163, 39);
            this.fullRight.TabIndex = 5;
            this.fullRight.Text = ">>";
            this.fullRight.UseVisualStyleBackColor = false;
            this.fullRight.Click += new System.EventHandler(this.FullRightClick);
            // 
            // fullLeft
            // 
            this.fullLeft.BackColor = System.Drawing.Color.Plum;
            this.fullLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.fullLeft.Location = new System.Drawing.Point(3, 3);
            this.fullLeft.Name = "fullLeft";
            this.fullLeft.Size = new System.Drawing.Size(162, 39);
            this.fullLeft.TabIndex = 1;
            this.fullLeft.Text = "<<";
            this.fullLeft.UseVisualStyleBackColor = false;
            this.fullLeft.Click += new System.EventHandler(this.FullLeftClick);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Plum;
            this.left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.left.Location = new System.Drawing.Point(171, 3);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(162, 39);
            this.left.TabIndex = 2;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.LeftClick);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Plum;
            this.right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.right.Location = new System.Drawing.Point(507, 3);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(162, 39);
            this.right.TabIndex = 4;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.RightClick);
            // 
            // pagination
            // 
            this.pagination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagination.ColumnCount = 5;
            this.pagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pagination.Controls.Add(this.fullLeft, 0, 0);
            this.pagination.Controls.Add(this.left, 1, 0);
            this.pagination.Controls.Add(this.right, 3, 0);
            this.pagination.Controls.Add(this.fullRight, 4, 0);
            this.pagination.Controls.Add(this.itemInPageLabel, 2, 0);
            this.pagination.Location = new System.Drawing.Point(172, 605);
            this.pagination.Name = "pagination";
            this.pagination.RowCount = 1;
            this.pagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.pagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.pagination.Size = new System.Drawing.Size(841, 45);
            this.pagination.TabIndex = 7;
            // 
            // itemInPageLabel
            // 
            this.itemInPageLabel.AutoSize = true;
            this.itemInPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemInPageLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.itemInPageLabel.Location = new System.Drawing.Point(339, 0);
            this.itemInPageLabel.Name = "itemInPageLabel";
            this.itemInPageLabel.Size = new System.Drawing.Size(162, 45);
            this.itemInPageLabel.TabIndex = 6;
            this.itemInPageLabel.Text = "1 - 12";
            this.itemInPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Plum;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 50);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.BackBtnClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.BackgroundImage = global::Noktinator.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(12, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RefreshBtnClick);
            // 
            // openJson
            // 
            this.openJson.BackColor = System.Drawing.Color.Plum;
            this.openJson.BackgroundImage = global::Noktinator.Properties.Resources.json;
            this.openJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openJson.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.openJson.Location = new System.Drawing.Point(1122, 599);
            this.openJson.Name = "openJson";
            this.openJson.Size = new System.Drawing.Size(50, 50);
            this.openJson.TabIndex = 10;
            this.openJson.UseVisualStyleBackColor = false;
            this.openJson.Click += new System.EventHandler(this.OpenJsonClick);
            // 
            // NailGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.openJson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pagination);
            this.Controls.Add(this.grid);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "NailGallery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nail Gallery";
            this.Load += new System.EventHandler(this.NailGalleryLoad);
            this.EnabledChanged += new System.EventHandler(this.NailGallery_EnabledChanged);
            this.pagination.ResumeLayout(false);
            this.pagination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button right;
        private Button fullRight;
        private Button left;
        private Button fullLeft;
        private TableLayoutPanel grid;
        private TableLayoutPanel pagination;
        private Button backBtn;
        private Button button1;
        private Button openJson;
        private Label itemInPageLabel;
    }
}