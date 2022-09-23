using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exam1ExtraCredit
{

    

    public partial class LibraryView : Form
    {
        private Controller _controller;

        private Book _selectedBook;

        public BindingList<Book> bookList;

        public LibraryView(Controller c, Book b, BindingList<Book> bl)
        {
            InitializeComponent();
            bookList = bl;
            _selectedBook = b; 
            _controller = c;
            uxListOfBooks.DataSource = bookList;
            bookList.AllowNew = true;
            _controller.AddFromCloud(bookList);
        }

        private void uxSyncButton_Click(object sender, EventArgs e)
        {
            _controller.SyncHelper(bookList);
            _controller.SaveHelper(bookList);
         }

        private void uxOpenBookButton_Click(object sender, EventArgs e)
        {
            BookView bookView = new BookView(bookList[uxListOfBooks.SelectedIndex], _controller, this);
            bookView.Show();
        }

        private void uxListOfBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxOpenBookButton.Enabled = true;
            _selectedBook = bookList[uxListOfBooks.SelectedIndex];
        }
    }
}
