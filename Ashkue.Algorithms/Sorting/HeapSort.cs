namespace Ashkue.Algorithms.Sorting
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Heapsort
    /// </summary>
    public class HeapSort
    {
        public void Sort(int[] array)
        {
            var heapSize = array.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
            {
                MaxHeapify(array, heapSize, p);
            }

            for (int i = array.Length - 1; i > 0; i--)
            {
                var temp = array[i];
                array[i] = array[0];
                array[0] = temp;

                heapSize--;
                MaxHeapify(array, heapSize, 0);
            }
        }

        private void MaxHeapify(int[] array, int heapSize, int index)
        {
            var right = (index + 1) * 2;
            var left = right - 1;
            var largest = index;

            if (left < heapSize && array[left] > array[largest])
            {
                largest = left;
            }

            if (right < heapSize && array[right] > array[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                var temp = array[index];
                array[index] = array[largest];
                array[largest] = temp;

                MaxHeapify(array, heapSize, largest);
            }
        }
    }
}
