using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Exseptions
{
    internal class LibraryNotFoundException:Exception
    {
        private const string _message = "Bele kitabxana tapilmadi";
        public LibraryNotFoundException (string message = _message) : base(message)
        {

        }
    }
}
