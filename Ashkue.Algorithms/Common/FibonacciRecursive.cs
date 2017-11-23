using System.Text;

namespace Ashkue.Algorithms.Common
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Fibonacci_number
    /// </summary>
    public class FibonacciRecursive
    {
        public string DisplayNumbers(int n)
        {
            if (n < 1 || n > 1000)
            {
                return "N/A";
            }

            if (n == 1)
            {
                return "0";
            }

            var result = new StringBuilder("0 1");
            ProcessNext(result, 0, 1, n - 2);

            return result.ToString();
        }

        public static void ProcessNext(StringBuilder result, int previous, int current, int counter)
        {
            if (counter == 0)
            {
                return;
            }

            var next = previous + current;
            result.AppendFormat(" {0}", next);
            ProcessNext(result, current, next, counter - 1);
        }
    }
}
