using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book
    {
        internal string AuthorName;
        internal string Title;
        public string CodeOfBook;
        public int PagesCount;
        public bool Collectable;

        public Book(string CodeOfBook, int PagesCount, bool Collectable)
        {
            AuthorName = "Неизвестно";
            Title = "Неизвестно";
            this.CodeOfBook = CodeOfBook;
            this.PagesCount = PagesCount;
            this.Collectable = Collectable;
        }

        public Book(string AuthorName, string Title, string CodeOfBook, int PagesCount, bool Collectable)
        {
            this.AuthorName = AuthorName;
            this.Title = Title;
            this.CodeOfBook = CodeOfBook;
            this.PagesCount = PagesCount;
            this.Collectable = Collectable;
        }

    }
}
