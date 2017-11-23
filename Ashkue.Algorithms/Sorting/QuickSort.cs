namespace Ashkue.Algorithms.Sorting
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Quicksort
    /// </summary>
    public class QuickSort
    {
        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private void Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int p = Partition(array, start, end);
                Sort(array, start, p - 1);
                Sort(array, p + 1, end);
            }
        }

        private int Partition(int[] array, int start, int end)
        {
            var pivot = array[end];
            var index = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] < pivot)
                {
                    int temp = array[index];
                    array[index] = array[i];
                    array[i] = temp;
                    index++;
                }
            }

            array[end] = array[index];
            array[index] = pivot;
            return index;
        }
    }
}
