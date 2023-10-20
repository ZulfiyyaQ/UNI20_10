using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Exseptions
{
    internal class CategoryNotFoundException:Exception
    {
        private const string _message = "Bele category tapilmadi";
        public CategoryNotFoundException(string message = _message) : base(message)
        {

        }
    }
}
