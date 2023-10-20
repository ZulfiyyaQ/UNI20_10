using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Exseptions
{
    internal class BookAlreadyExistsException:Exception
    {
        private const string _message = "Bu kitab artiq movcutdur";
        public BookAlreadyExistsException(string message = _message) : base(message)
        {

        }
    }
}
