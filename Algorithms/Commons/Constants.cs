namespace Algorithms
{
    internal static class Constants
    {
        private static readonly string sensoApiURL = "https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking";
        private readonly static Dictionary<int, string> sortList = new Dictionary<int, string>()
        {
            { 1, "Insertion Sort" },
            { 2, "Selection Sort" },
            { 3, "Merge Sort" },
            { 4, "Quick Sort" }
        };

        private readonly static Dictionary<int, string> searchList = new Dictionary<int, string>()
        {
            { 1, "Binary Search" },
        };

        public static string GetSensoApiURL() => sensoApiURL;
        public static Dictionary<int, string> GetSortList() => sortList;
        public static Dictionary<int, string> GetSearchList() => searchList;
    }
}
