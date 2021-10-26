namespace Algorithms
{
    internal static class SelectionSort
    {
        public static void Sort(Student[] list, int quantityOfElements)
        {
            for (int i = 0; i < quantityOfElements; i++)
            {
                int smaller = Utils.SmallerIndexSearch(list, i, quantityOfElements);
                Utils.ChangePositions(list, i, smaller);
            }
        }
    }
}
