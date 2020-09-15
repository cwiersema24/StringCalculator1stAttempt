using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculatorBlank
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(numbers == "")
            {
                return 0;
            }
            if (numbers.StartsWith("//"))
            {
                var newseporator = numbers[2];
                var numbers2 = numbers.Remove(0, 2);
                var parts = numbers2.Split(newseporator);
                var total = 0;
                foreach (var part in parts)
                {
                    total += int.Parse(part);
                }
                return total;
            }
            else
            {
                return GetTotal(numbers);
            }
            
        }
        private int GetTotal( string numbers)
        {
            var seporators = new List<char> { ',', '\n' };
            
            var parts = numbers.Split(seporators.ToArray());
            var total = 0;
            foreach (var part in parts)
            {
                total += int.Parse(part);
            }
            return total;
        }
    }
}
