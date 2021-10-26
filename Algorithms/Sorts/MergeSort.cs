namespace Algorithms
{
    internal static class MergeSort
    {
        private static void Partition(Student[] list, int begin, int middle, int end)
        {
            Student[] result = new Student[end - begin];
            int current = 0;
            int firstHalf = begin;
            int secondHalf = middle;

            while (firstHalf < middle && secondHalf < end)
            {
                Student itemFirstHalf = list[firstHalf];
                Student itemSecondHalf = list[secondHalf];
                if (itemFirstHalf.GetGrade() < itemSecondHalf.GetGrade())
                {
                    result[current] = itemFirstHalf;
                    firstHalf++;
                }
                else
                {
                    result[current] = itemSecondHalf;
                    secondHalf++;
                }

                current++;
            }

            while (firstHalf < middle)
            {
                result[current] = list[firstHalf];
                firstHalf++;
                current++;
            }

            while (secondHalf < end)
            {
                result[current] = list[secondHalf];
                secondHalf++;
                current++;
            }

            for (int i = 0; i < current; i++)
            {
                list[begin + i] = result[i];
            }
        }
        public static void Sort(Student[] list, int begin, int end)
        {
            int quantity = end - begin;
            if(quantity > 1)
            {
                int middle = (begin + end) / 2;
                Sort(list, begin, middle);
                Sort(list, middle, end);
                Partition(list, begin, middle, end);
            }
        }
    }
}
