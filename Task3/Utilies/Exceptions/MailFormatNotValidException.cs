using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Utilies
{
    internal class MailFormatNotValidException : Exception
    {
        public MailFormatNotValidException(string message) : base(message)
        { }

    }
}
