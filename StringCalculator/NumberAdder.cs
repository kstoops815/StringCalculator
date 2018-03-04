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
            int sum;
            var twoNumbers = number.Split(',');
            if (number == "")
            {
                return 0;
            }
            else if(number != "")
            {
                sum = Convert.ToInt32(number);
                return sum;
            }
            else if(twoNumbers.Length == 2)
            {
                var addends = new Numbers
                {
                    FirstNumber = twoNumbers[0],
                    SecondNumber = twoNumbers[1]
                };
                var firstAddend = Convert.ToInt32(addends.FirstNumber);
                var secondAddend = Convert.ToInt32(addends.SecondNumber);
                sum = firstAddend + secondAddend;
                return sum;

            }
            return 11111;
        }

        public class Numbers
        {
            public string FirstNumber { get; set; }
            public string SecondNumber { get; set; }
        }
        
    }
}
