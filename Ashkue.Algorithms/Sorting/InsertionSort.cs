namespace Ashkue.Algorithms.Sorting
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Insertion_sort
    /// </summary>
    public class InsertionSort
    {
        public void Sort(int[] array)
        {
            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    var temp = array[i];
                    var j = i - 1;
                    while (j >= 0 && array[j] > temp)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                    array[j + 1] = temp;
                }
            }
        }
    }
}
