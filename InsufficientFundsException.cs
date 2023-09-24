using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_ClassroomWork_23_09
{
    public class InsufficientFundsException:Exception
    {
        public InsufficientFundsException(string message):base(message) { }
    }
}
