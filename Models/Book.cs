using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Models
{
    internal class Book:Base
    {
        static int count;
        public string Author { get; set; }
        public Category Category { get; set; }

        public Book(string name,string author,Category category):base(name)
        {
            Id = count++;
            Name = name;
            Author = author;
            Category = category;
            
        }
    }
}
