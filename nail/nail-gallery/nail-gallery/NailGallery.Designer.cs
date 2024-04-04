
namespace nail_gallery
{
    partial class NailGallery
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grid = new TableLayoutPanel();
            fullRight = new Button();
            fullLeft = new Button();
            left = new Button();
            right = new Button();
            pagination = new TableLayoutPanel();
            indexInput = new TextBox();
            searchBar = new TextBox();
            pagination.SuspendLayout();
            SuspendLayout();
            // 
            // grid
            // 
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid.ColumnCount = 2;
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            grid.Location = new Point(12, 43);
            grid.Name = "grid";
            grid.RowCount = 2;
            grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            grid.Size = new Size(776, 353);
            grid.TabIndex = 6;
            // 
            // fullRight
            // 
            fullRight.Dock = DockStyle.Fill;
            fullRight.Font = new Font("Microsoft Sans Serif", 15F);
            fullRight.Location = new Point(323, 3);
            fullRight.Name = "fullRight";
            fullRight.Size = new Size(74, 30);
            fullRight.TabIndex = 5;
            fullRight.Text = ">>";
            fullRight.UseVisualStyleBackColor = true;
            fullRight.Click += FullRightClick;
            // 
            // fullLeft
            // 
            fullLeft.Dock = DockStyle.Fill;
            fullLeft.Font = new Font("Microsoft Sans Serif", 15F);
            fullLeft.Location = new Point(3, 3);
            fullLeft.Name = "fullLeft";
            fullLeft.Size = new Size(74, 30);
            fullLeft.TabIndex = 1;
            fullLeft.Text = "<<";
            fullLeft.UseVisualStyleBackColor = true;
            fullLeft.Click += FullLeftClick;
            // 
            // left
            // 
            left.Dock = DockStyle.Fill;
            left.Font = new Font("Microsoft Sans Serif", 15F);
            left.Location = new Point(83, 3);
            left.Name = "left";
            left.Size = new Size(74, 30);
            left.TabIndex = 2;
            left.Text = "<";
            left.UseVisualStyleBackColor = true;
            left.Click += LeftClick;
            // 
            // right
            // 
            right.Dock = DockStyle.Fill;
            right.Font = new Font("Microsoft Sans Serif", 15F);
            right.Location = new Point(243, 3);
            right.Name = "right";
            right.Size = new Size(74, 30);
            right.TabIndex = 4;
            right.Text = ">";
            right.UseVisualStyleBackColor = true;
            right.Click += RightClick;
            // 
            // pagination
            // 
            pagination.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pagination.ColumnCount = 5;
            pagination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pagination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pagination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pagination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pagination.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pagination.Controls.Add(fullLeft, 0, 0);
            pagination.Controls.Add(left, 1, 0);
            pagination.Controls.Add(right, 3, 0);
            pagination.Controls.Add(fullRight, 4, 0);
            pagination.Controls.Add(indexInput, 2, 0);
            pagination.Location = new Point(200, 402);
            pagination.Name = "pagination";
            pagination.RowCount = 1;
            pagination.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pagination.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pagination.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pagination.Size = new Size(400, 36);
            pagination.TabIndex = 7;
            // 
            // indexInput
            // 
            indexInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            indexInput.Location = new Point(163, 3);
            indexInput.MaxLength = 3;
            indexInput.Multiline = true;
            indexInput.Name = "indexInput";
            indexInput.Size = new Size(74, 30);
            indexInput.TabIndex = 3;
            indexInput.TextAlign = HorizontalAlignment.Center;
            indexInput.TextChanged += IndexInputChanged;
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBar.Location = new Point(12, 14);
            searchBar.MaxLength = 100;
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(776, 23);
            searchBar.TabIndex = 0;
            searchBar.TextAlign = HorizontalAlignment.Center;
            searchBar.TextChanged += SearchBarTextChanged;
            // 
            // NailGallery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchBar);
            Controls.Add(pagination);
            Controls.Add(grid);
            Name = "NailGallery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nail Gallery";
            Load += NailGalleryLoad;
            pagination.ResumeLayout(false);
            pagination.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
