using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Utilies
{
    internal class MailMessageNotValidException :Exception
    {
        public MailMessageNotValidException(string message) : base(message)
        { }
    }
}
