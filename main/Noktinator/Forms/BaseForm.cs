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
        }
        void BaseFormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
