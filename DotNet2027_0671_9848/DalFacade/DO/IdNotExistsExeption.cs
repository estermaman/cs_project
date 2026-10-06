using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public class IdNotExistsExeption : Exception
    {
           public IdNotExistsExeption(string message) : base(message) { }
        public IdNotExistsExeption(string message, Exception innerException) : base(message, innerException) { }

    }
    public class IdAlreadyExistsExeotion : Exception
    {
        public IdAlreadyExistsExeotion(string message) : base(message) { }
        public IdAlreadyExistsExeotion(string message, Exception innerException) : base(message, innerException) { }
    }
}
