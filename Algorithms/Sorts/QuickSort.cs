namespace Algorithms
{
    internal static class QuickSort
    {
        private static int PartitionWithPivot(Student[] list, int begin, int end)
        {
            Student pivot = list[end];
            int smallerIndex = begin;

            for (int i = begin; i < end; i++)
            {
                if(list[i].GetGrade() <= pivot.GetGrade())
                {
                    Utils.ChangePositions(list, smallerIndex, i);
                    smallerIndex++;
                }
            }
            Utils.ChangePositions(list, smallerIndex, end);
            return smallerIndex;
        }

        public static void Sort(Student[] list, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = PartitionWithPivot(list, low, high);
                Sort(list, low, partitionIndex - 1);
                Sort(list, partitionIndex + 1, high);
            }
        }
    }
}
