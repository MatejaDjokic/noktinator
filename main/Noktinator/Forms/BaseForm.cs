using System.Windows.Forms;
using System;
using System.Drawing;

namespace Noktinator.Util
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.FormClosed += BaseFormClose;
            this.KeyPreview = true;
            this.KeyDown += BaseFormKeyDown;
        }
        void BaseFormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void BaseFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
                CenterToScreen();
        }
    }
}
