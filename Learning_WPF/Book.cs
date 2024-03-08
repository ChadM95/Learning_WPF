using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_WPF
{
    public class Book
    {
        public string Title { get; set; }
        public string Genre { get; set; }


        public Book(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"Title: {Title} , Genre: {Genre}";
        }
    }
}
