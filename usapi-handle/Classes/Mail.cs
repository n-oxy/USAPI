using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usapi_handle.Classes
{
    public class Mail
    {
        public string content;
        public string subject;
        public string[] to;
        internal string from = Access.fromEm;
    }
}
