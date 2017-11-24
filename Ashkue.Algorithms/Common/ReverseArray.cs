namespace Ashkue.Algorithms.Common
{
    /// <summary>
    /// Reverse Array Algorithm
    /// </summary>
    public class ReverseArray
    {
        public void Execute(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return;
            }

            var mid = array.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                var temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
        }
    }
}
