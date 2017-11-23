namespace Ashkue.Algorithms.Sorting
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Merge_sort
    /// </summary>
    public class MergeSort
    {
        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private void Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2; ;
                Sort(array, start, mid);
                Sort(array, mid + 1, end);

                Merge(array, start, mid + 1, end);
            }
        }

        private void Merge(int[] array, int start, int mid, int end)
        {
            var temp = new int[array.Length];
            var left = mid - 1;
            var length = end - start + 1;
            var position = start;

            while ((start <= left) && (mid <= end))
            {
                if (array[start] <= array[mid])
                {
                    temp[position] = array[start];
                    start++;
                }
                else
                {
                    temp[position] = array[mid];
                    mid++;
                }
                position++;
            }

            while (start <= left)
            {
                temp[position] = array[start];
                start++;
                position++;
            }

            while (mid <= end)
            {
                temp[position] = array[mid];
                mid++;
                position++;
            }

            for (int i = 0; i < length; i++)
            {
                array[end] = temp[end];
                end--;
            }
        }
    }
}
