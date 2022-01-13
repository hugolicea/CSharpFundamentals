using System;
using System.Collections.Generic;

namespace GradeBook
{
    class VarTypes
    {

        public VarTypes() { getDoubleType(); }

        public void getDoubleType()
        {
            var numbers = new[] { 1.1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            // Console.WriteLine($"Result is:{result}");
            foreach (var item in numbers)
            {
                result += item;
            }
            Console.WriteLine($"Result is:{result}");

        }

        public void getListType()
        {
            var res = 0.0;
            List<double> numbers = new List<double>() { 1.1, 2.2, 3.3, 4.4, 5.5 };
            numbers.Add(6.6);
            res /= numbers.Count;
            Console.WriteLine($"El resultado es: {res}");
        }


    }
}