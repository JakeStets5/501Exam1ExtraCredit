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

        public LibraryView(Book b, BindingList<Book> bl)
        {
            InitializeComponent();
            bookList = bl;
            _selectedBook = b; 
            uxListOfBooks.DataSource = bookList;
            bookList.AllowNew = true;
            
        }

        private void uxSyncButton_Click(object sender, EventArgs e)
        {
            _controller.SyncHelper();
            _controller.SaveHelper();
         }

        public void SetController(Controller c)
        {
            _controller = c;
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

        private void LibraryView_Load(object sender, EventArgs e)
        {
            _controller.AddFromCloud();
        }
    }
}
