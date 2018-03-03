using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class NumberAdder
    {
        public int AddNumbers(string number)
        {
            if(number == "")
            {
                return 0;
            }
            if(number != "")
            {
                var total = Convert.ToInt32(number);
                return total;
            }
            return 11111;
        }
        
    }
}
