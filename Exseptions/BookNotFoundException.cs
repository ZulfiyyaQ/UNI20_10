using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Exseptions
{
    internal class BookNotFoundException:Exception
    {
        private const string _message = "Bele kitab tapilmadi";
        public BookNotFoundException(string message = _message) : base(message)
        {

        }
    }
}
