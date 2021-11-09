namespace Algorithms
{
    internal static class InsertionSort
    {
        /// <summary>
        /// Move while is bigger than previous element
        /// </summary>
        /// <param name="list">Student list</param>
        /// <param name="quantityOfElements">List size</param>
        public static void Sort(Student[] list, int quantityOfElements)
        {
            for (int i = 1; i <= quantityOfElements; i++)
            {
                int current = i;
                while (current > 0 && list[current].GetId() < list[current - 1].GetId())
                {
                    Utils.ChangePositions(list, current, current - 1);
                    current--;
                }
            }
        }
    }
}
