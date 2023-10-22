using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Exseptions
{
    internal class CategoryAlreadyExists:Exception
    {
        private const string _message = "Bu kategoriya artiq movcutdur";
        public CategoryAlreadyExists(string message = _message) : base(message)
        {

        }
    }
}
