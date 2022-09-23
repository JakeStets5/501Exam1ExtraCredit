using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1ExtraCredit
{
    public partial class BookView : Form
    {
        private Controller _controller;

        private Book _book;

        private LibraryView _libraryView;

        public BookView(Book b, Controller c, LibraryView lv)
        {
            InitializeComponent();
            _controller = c;
            _book = b;
            _libraryView = lv;  
            uxBookTextBox.Text = b.Pages[b.CurrentPageNumber];
            uxPageNumberUpDown.Value = b.CurrentPageNumber + 1;
            uxBookmarkListBox.DataSource = _book.Bookmark;
        }

        private void uxPageJumpButton_Click(object sender, EventArgs e)
        {
            _controller.JumpHelper(_book, (int)uxPageNumberUpDown.Value, _libraryView.bookList);
            uxBookTextBox.Text = _book.Pages[_book.CurrentPageNumber];
        }

        private void uxPageBackward_Click(object sender, EventArgs e)
        {
            _controller.FlipBackwardHelper(_book, _book.CurrentPageNumber, _libraryView.bookList);
            uxBookTextBox.Text = _book.Pages[_book.CurrentPageNumber];
        }

        private void uxPageForward_Click(object sender, EventArgs e)
        {
            _controller.FlipForwardHelper(_book, _book.CurrentPageNumber, _libraryView.bookList);
            uxBookTextBox.Text = _book.Pages[_book.CurrentPageNumber];
        }

        private void uxAddBookmarkButton_Click(object sender, EventArgs e)
        {
            _controller.AddBookmarkHelper(_book, _libraryView.bookList);
        }

        private void uxRemoveBookMark_Click(object sender, EventArgs e)
        {
            _controller.RemoveBookmarkHelper(uxBookmarkListBox.SelectedIndex, _book, _libraryView.bookList);
        }
    }
}