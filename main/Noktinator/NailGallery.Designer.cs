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
            this.indexInput = new System.Windows.Forms.TextBox();
            this.searchBar = new System.Windows.Forms.TextBox();
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
            this.grid.Location = new System.Drawing.Point(10, 37);
            this.grid.Name = "grid";
            this.grid.RowCount = 3;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.grid.Size = new System.Drawing.Size(1163, 577);
            this.grid.TabIndex = 6;
            // 
            // fullRight
            // 
            this.fullRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.fullRight.Location = new System.Drawing.Point(675, 3);
            this.fullRight.Name = "fullRight";
            this.fullRight.Size = new System.Drawing.Size(163, 25);
            this.fullRight.TabIndex = 5;
            this.fullRight.Text = ">>";
            this.fullRight.UseVisualStyleBackColor = true;
            // 
            // fullLeft
            // 
            this.fullLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.fullLeft.Location = new System.Drawing.Point(3, 3);
            this.fullLeft.Name = "fullLeft";
            this.fullLeft.Size = new System.Drawing.Size(162, 25);
            this.fullLeft.TabIndex = 1;
            this.fullLeft.Text = "<<";
            this.fullLeft.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.left.Location = new System.Drawing.Point(171, 3);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(162, 25);
            this.left.TabIndex = 2;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = true;
            // 
            // right
            // 
            this.right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.right.Location = new System.Drawing.Point(507, 3);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(162, 25);
            this.right.TabIndex = 4;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = true;
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
            this.pagination.Controls.Add(this.indexInput, 2, 0);
            this.pagination.Location = new System.Drawing.Point(171, 619);
            this.pagination.Name = "pagination";
            this.pagination.RowCount = 1;
            this.pagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.pagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.pagination.Size = new System.Drawing.Size(841, 31);
            this.pagination.TabIndex = 7;
            // 
            // indexInput
            // 
            this.indexInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indexInput.Location = new System.Drawing.Point(339, 3);
            this.indexInput.MaxLength = 3;
            this.indexInput.Multiline = true;
            this.indexInput.Name = "indexInput";
            this.indexInput.Size = new System.Drawing.Size(162, 25);
            this.indexInput.TabIndex = 3;
            this.indexInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.Location = new System.Drawing.Point(10, 12);
            this.searchBar.MaxLength = 100;
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(1164, 20);
            this.searchBar.TabIndex = 0;
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NailGalerija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.pagination);
            this.Controls.Add(this.grid);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "NailGalerija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nail Gallery";
            this.Load += new System.EventHandler(this.NailGalleryLoad);
            this.pagination.ResumeLayout(false);
            this.pagination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button right;
        private Button fullRight;
        private Button left;
        private Button fullLeft;
        private TableLayoutPanel grid;
        private TableLayoutPanel pagination;
        private TextBox indexInput;
        private TextBox searchBar;
    }
}