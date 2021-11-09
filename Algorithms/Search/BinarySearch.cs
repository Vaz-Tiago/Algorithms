namespace Algorithms
{
    internal static class BinarySearch
    {
        public static int Search(Student[] list, int begin, int end, double searching)
        {
            if (begin > end)
                return -1;

            int middle = (begin + end) / 2;
            Student middleElement = list[middle];

            if (searching == middleElement.GetId())
                return middle;

            if (searching < middleElement.GetId())
                return Search(list, begin, middle - 1, searching);

            return Search(list, middle + 1, end, searching);
        }
    }
}
