using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noktinator
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }


        //dizajniraj
        private void DizajnirajClick(object sender, EventArgs e)
        {

        }


        //izadji
        private void IzadjiClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
