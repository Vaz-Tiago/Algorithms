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

        public static string GetSensoApiURL() => sensoApiURL;
        public static Dictionary<int, string> GetSortList() => sortList;
    }
}
