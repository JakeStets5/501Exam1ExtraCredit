using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace Exam1ExtraCredit
{

    public class Controller
    {
        private LibraryView _libraryView;

        private Book _book;

        private int _count = 0;

        public Controller(LibraryView lv)
        {
            _libraryView = lv;
        }

        public void AddFromCloud()
        {
            if (File.Exists("..\\..\\Cloud.txt"))
            {
                StreamReader sr = new StreamReader("..\\..\\Cloud.txt");
                while (!sr.EndOfStream)
                {
                    string readLine = sr.ReadLine();
                    if (readLine == "")
                    {
                        break;
                    }
                    string[] bookData = readLine.Split(',');
                    string readLine2 = sr.ReadLine();
                    int count = 0;
                    string[] bookmarkData = readLine2.Split(',');
                    BindingList<int> vs = new BindingList<int>();
                    if(readLine2 != "")
                    {
                        foreach (string s in bookmarkData)
                        {
                            int i = Convert.ToInt32(s);
                            vs.Add(i);
                            count++;
                        }
                    }
                    string pageData = sr.ReadLine();
                    if (pageData == "")
                    {
                        break;
                    }
                    string[] pageArray = pageData.Split(',');
                    List<string> pageList = new List<string>();
                    foreach (string s in pageArray)
                    {
                        pageList.Add(s);
                        count++;
                    }
                    Book b = new Book(bookData[0], Convert.ToInt32(bookData[1]), Convert.ToBoolean(bookData[2]), vs, pageList);
                    if (b.synched)
                    {
                        _libraryView.bookList.Add(b);
                    }
                }
                sr.Close();
            }
        }

        public void SyncHelper()
        {
            if (File.Exists("..\\..\\Cloud.txt"))
            {
                StreamReader sr = new StreamReader("..\\..\\Cloud.txt");
                for (int i = 0; i < _count; i++)
                {
                    sr.ReadLine();
                }
                while (!sr.EndOfStream)
                {
                    string readLine = sr.ReadLine();
                    if (readLine == "")
                    {
                        break;
                    }
                    string[] bookData = readLine.Split(',');
                    string readLine2 = sr.ReadLine();
                    string[] bookmarkData = readLine2.Split(',');
                    int count = 0;
                    BindingList<int> vs = new BindingList<int>();
                    if (readLine2 != "")
                    {
                        foreach (string s in bookmarkData)
                        {
                            int i = Convert.ToInt32(s);
                            vs.Add(i);
                            count++;
                        }
                    }
                    string pageData = sr.ReadLine();
                    if (readLine2 == "")
                    {
                        break;
                    }
                    string[] pageArray = pageData.Split(',');
                    List<string> pageList = new List<string>();
                    foreach (string s in pageArray)
                    {
                        pageList.Add(s);
                        count++;
                    }
                    Book b = new Book(bookData[0], Convert.ToInt32(bookData[1]), Convert.ToBoolean(bookData[2]), vs, pageList);
                    if (!b.synched)
                    {
                        _libraryView.bookList.Add(b);
                        b.synched = true;
                    }
                    _count += 3;
                }
                sr.Close();
            }
        }

        public void SaveHelper()
        {
            StreamWriter sw = new StreamWriter("..\\..\\Cloud.txt");
            foreach(Book b in _libraryView.bookList)
            {
                if (b.synched)
                {
                    sw.WriteLine(b.Title + "," + b.CurrentPageNumber.ToString() + "," + b.synched.ToString());
                    int count = 0;
                    foreach (int i in b.Bookmark)
                    {
                        if (count == 0)
                        {
                            sw.Write(i.ToString());
                        }
                        else
                        {
                            sw.Write("," + i.ToString());
                        }
                        count++;
                    }
                    sw.WriteLine();
                    count = 0;
                    foreach(string s in b.Pages)
                    {
                        if (count == 0)
                        {
                            sw.Write(s.ToString());
                        }
                        else
                        {
                            sw.Write("," + s.ToString());
                        }
                        count++;
                    }
                }
            }
            sw.Close();
        }

        public void FlipForwardHelper(Book book, int page)
        {
            if (page == book.Pages.Count - 1)
            {
                MessageBox.Show("No more pages");
            }
            else
            {
                book.CurrentPageNumber += 1;
            }
            SaveHelper();
        }

        public void FlipBackwardHelper(Book book, int page)
        {
            if (page == 0)
            {
                MessageBox.Show("On the first page");
            }
            else
            {
                book.CurrentPageNumber -= 1;
            }
            SaveHelper();
        }

        public void JumpHelper(Book book, int page)
        {
            if(page > 0 && page <= book.Pages.Count)
            {
                book.CurrentPageNumber = page - 1;
            }
            else
            {
                MessageBox.Show("can't jump to non-existent page");
            }
            SaveHelper();
        }

        public void AddBookmarkHelper(Book book)
        {
            if(book.Bookmark.Count == 5)
            {
                MessageBox.Show("no mo bookmark");
            }
            else
            {
                if(book.Bookmark.Count == 0)
                {
                    book.Bookmark.Add(book.CurrentPageNumber + 1);
                    SaveHelper();
                }
                else
                {
                    bool contains = false;
                    foreach(int num in book.Bookmark)
                    {
                        if (book.CurrentPageNumber + 1 == num) contains = true;
                    }
                    if(contains) MessageBox.Show("Bookmark already on this page");
                    else
                    {
                        book.Bookmark.Add(book.CurrentPageNumber + 1);
                        SaveHelper();
                    }
                }
            }
        }

        public void RemoveBookmarkHelper(int index, Book book)
        {
            int count = 0;
            int remove = 0; 
            foreach(int i in book.Bookmark)
            {
                if(count == index)
                {
                    remove = i;
                }
                count++;
            }
            book.Bookmark.Remove(remove);
            book.Bookmark.ResetBindings();
            SaveHelper();
        }
    }
}