using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Models
{
    internal class Category:Base
    {
        static int count=1;
        public Category(string name):base(name)
        {
            Id = count++;
            Name = name;

        }

        
    }
}
