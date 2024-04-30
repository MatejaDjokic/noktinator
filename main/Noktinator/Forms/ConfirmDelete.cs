using System.Collections.Generic;
using System.Windows.Forms;
using System;
using Noktinator.Util;

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
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            ShowGallery();
            ng.nailButtons.RemoveAt(ng.buttonIndex);
            List<Nail> nails = JsonUtil.LoadNails();
            nails.RemoveAt(ng.buttonIndex);
            JsonUtil.SaveNails(nails);
            ng.RefreshNails();
            Hide();
        }

        private void NoClick(object sender, EventArgs e)
        {
            ShowGallery();
            Hide();
        }

        private void ConfirmDeleteFormClosed(object sender, FormClosedEventArgs e)
        {
            ShowGallery();
        }
    }
}
