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
    public partial class ConfirmDelete : Form
    {
        public ConfirmDelete()
        {
            InitializeComponent();
        }

        NailGallery ng = (NailGallery)Application.OpenForms["NailGallery"];

        public void ShowGallery() 
        {
            ng.Show();
            ng.Enabled = true;
            this.Hide();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            ShowGallery();
            ng.nailButtons.RemoveAt(ng.buttonIndex);
            List<Nail> nails = JsonUtil.LoadNails();
            nails.RemoveAt(ng.buttonIndex);
            JsonUtil.SaveNails(nails);
            ng.RefreshNails();
        }

        private void No_Click(object sender, EventArgs e)
        {
            ShowGallery();
        }

        private void ConfirmDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowGallery();
            
        }
    }
}
