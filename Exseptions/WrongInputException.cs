using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Exseptions
{
    internal class WrongInputException:Exception
    {
        private const string _message = "Duzgun deyer daxil edin";
        public WrongInputException(string message=_message):base(message)
        {

        }
    }
}
