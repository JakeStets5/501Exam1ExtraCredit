using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Exam1ExtraCredit
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controller c = new Controller();
            Book b = new Book("", 0, false, new BindingList<int>(), new List<string>());
            Application.Run(new LibraryView(c, b, new BindingList<Book>()));
        }
    }
}
