using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Concrete
{
    public class SuccessResult :Result
    {
        public SuccessResult(String message):base(true,message)
        {
            
        }
        public SuccessResult():base(true)
        {
            
        }
    }
}
