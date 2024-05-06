using System.Windows.Forms;
using System;

namespace Noktinator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // OPENS AND IMMEDIATELY HIDES THE FORMS
            // SO THEY ARE ADDED TO THE OPEN FORMS BUFFER
            Navigator.Init(
                new NailGallery(),
                new FingerPreview(),
                new Designer(),
                new ChooseShape(),
                new ChoosePattern(),
                new SkinChoice()
            );

            // RUNS THE MAIN APPLICATION PAGE (START MENU)
            Application.Run(
                new StartMenu()
            );
        }
    }
}
