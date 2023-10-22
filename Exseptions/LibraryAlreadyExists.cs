using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Exseptions
{
    internal class LibraryAlreadyExists:Exception
    {
        private const string _message = "Bu kitabxana artiq movcutdur";
        public LibraryAlreadyExists (string message = _message) : base(message)
        {

        }
    }
}
