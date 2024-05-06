using System.Windows.Forms;
using System.Drawing;
using System;

namespace Noktinator
{
    public static class Navigator
    {
        /// <summary>
        /// Opens (shows) the form of type T and closes (hides) the form of type U
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        public static void Goto<T, U>() where T : Form where U : Form
        {
            Open<T>();
            Close<U>();
        }

        /// <summary>
        /// Does the same as the Goto<T,U> method but the form is opened with the size and location of the closed form
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        public static void GotoRetain<T, U>() where T : Form where U : Form
        {
            U oldForm = Get<U>();
            OpenWithSizeAndLocation<T>(oldForm.Size, oldForm.Location);
            Close<U>();
        }

        /// <summary>
        /// Gets the form of type T and "opens" it (the form is actually just shown with the .Show() method)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void Open<T>() where T : Form
        {
            T form = Get<T>();
            if (form is null) throw new Exception("The form was never opened!");
            form.Show();
        }

        /// <summary>
        /// Does the same as the Open<T> method but shows the form with the given size and location so the transition seems seamless
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="size"></param>
        /// <param name="location"></param>
        public static void OpenWithSizeAndLocation<T>(Size size, Point location)
            where T : Form
        {
            T form = Get<T>();
            form.Size = size;
            form.Location = location;
            form.Show();
        }

        /// <summary>
        /// Gets the form of type T and "closes" it (the form is actually hiden with the .Hide() method)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void Close<T>() where T : Form
        {
            T form = Get<T>();
            if (form is null) throw new Exception("The form was never opened!");
            form.Hide();
        }

        /// <summary>
        /// For all elements from the forms array runs .Show() & .Hide() to force them into the Application.OpenForms dictionary
        /// </summary>
        /// <param name="forms"></param>
        public static void Init(params Form[] forms)
        {
            foreach (Form form in forms)
            {
                form.Show();
                form.Hide();
            }
        }

        /// <summary>
        /// Returns the opened form of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>() where T : Form
        {
            string formName = typeof(T).FullName.Split('.')[1];
            return (T)Application.OpenForms[formName];
        }
    }
}
