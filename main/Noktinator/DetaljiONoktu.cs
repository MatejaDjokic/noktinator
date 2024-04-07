using System.Windows.Forms;
using System.Drawing;

namespace Noktinator
{
    class DetaljiONoktu : Form
    {
        private Nail nail;
        public DetaljiONoktu(Nail nail, int i)
        {
            this.nail = nail;

            this.Size = new Size(600, 400);
            CenterToScreen();

            this.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.Escape) this.Close();
            };

            this.Text = $"Nail {i + 1}";

            TableLayoutPanel table = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 3,
                RowStyles = { new RowStyle(SizeType.Percent, 100f) },
                ColumnStyles = {
                    new ColumnStyle(SizeType.Percent, 33f),
                    new ColumnStyle(SizeType.Percent, 33f),
                    new ColumnStyle(SizeType.Percent, 33f),
                },
            };
            this.Controls.Add(table);

            Label l1 = new Label()
            {
                Text = $"{nail.nailShape}",
                Dock = DockStyle.Fill,
                BackColor = nail.nailColor,
                Font = new Font("Arial", 12),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            table.Controls.Add(l1, 0, 0);

            Label l2 = new Label()
            {
                Text = $"{nail.nailPattern}",
                Dock = DockStyle.Fill,
                BackColor = nail.patternColor,
                Font = new Font("Arial", 12),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            table.Controls.Add(l2, 1, 0);

            Label l3 = new Label()
            {
                Text = $"Skin Color",
                Dock = DockStyle.Fill,
                BackColor = nail.skinColor,
                Font = new Font("Arial", 12),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            table.Controls.Add(l3, 2, 0);
        }
    }
}
