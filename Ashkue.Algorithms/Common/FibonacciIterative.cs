using System.Text;

namespace Ashkue.Algorithms.Common
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Fibonacci_number
    /// </summary>
    public class FibonacciIterative
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

            var previous = 0;
            var current = 1;
            var result = new StringBuilder("0 1");

            for (int i = 2; i < n; i++)
            {
                var next = previous + current;
                previous = current;
                current = next;
                result.AppendFormat(" {0}", next);
            }

            return result.ToString();
        }
    }
}
