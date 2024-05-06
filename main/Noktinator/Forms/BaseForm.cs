using System.Windows.Forms;
using System;

namespace Noktinator.Util
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.FormClosed += BaseFormClose;
            this.KeyDown += BaseFormKeyDown;
            this.KeyPreview = true;
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
