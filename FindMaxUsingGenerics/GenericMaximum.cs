using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public T[] value;
        public GenericMaximum(T firstValue,T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public static T GenericMaxNumber(T firstValue,T secondValue, T thirdValue)
        {

            if (firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
        }
        public void TestMaximum()
        {
            T result = GenericMaxNumber(firstValue, secondValue, thirdValue);
            Console.WriteLine("The maximum value is: " + result);
        }
    }
}
