using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Models
{
    internal abstract class Base
    {
         public int Id { get; protected set; }
         public string Name { get; protected set; }

        public Base(string name)
        {
            Name = name;
        }
    }
}
