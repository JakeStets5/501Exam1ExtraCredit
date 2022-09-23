using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1ExtraCredit
{
    public class Book
    {
        public string Title { get; set; }

        public int CurrentPageNumber { get; set; }

        public BindingList<int> Bookmark { get; set; }

        public List<string> Pages = new List<string>();

        public bool synched = false;

        public Book(string t, int pn, bool b, BindingList<int> bm,List<string> l)
        {
            Title = t;
            CurrentPageNumber = pn;
            Pages = l;
            Bookmark = bm;  
            synched = b;    
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
