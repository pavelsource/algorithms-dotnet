namespace Ashkue.Algorithms.Sorting
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Bubble_sort
    /// </summary>
    public class BubbleSort
    {
        public void Sort(int[] array)
        {
            if (array.Length > 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            var temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}
