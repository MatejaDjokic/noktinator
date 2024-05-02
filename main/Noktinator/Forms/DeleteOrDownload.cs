using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noktinator.Forms
{
    public partial class DeleteOrDownload : Form
    {

        NailGallery ng = (NailGallery)Application.OpenForms["NailGallery"];
        
        
        public DeleteOrDownload()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ConfirmDelete cd = new ConfirmDelete();
            cd.Show();
            Enabled = false;
        }

        private void Install_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images| *,png;*.jpg;*.jpeg";
            
            ImageFormat format = ImageFormat.Png;
            sfd.FileName = $"nail.{format}";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fingerView.BackgroundImage.Save(sfd.FileName, format);
            }
        }

        private void DeleteOrDownload_Load(object sender, EventArgs e)
        {
            fingerView.BackgroundImage = ng.nailbuttonImage;
        }
    }
}
