using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public abstract class Document
    {
        public string Number { get; set; }
        public abstract string GetCardInfo();
    }

}
