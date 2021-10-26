namespace Algorithms
{
    internal static class Constants
    {
        private static readonly string sensoApiURL = "https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking";
        private readonly static Dictionary<int, string> sortList = new Dictionary<int, string>()
        {
            { 1, "Merge Sort" },
            { 2, "Insertion Sort" }
        };

        public static string GetSensoApiURL() => sensoApiURL;
        public static Dictionary<int, string> GetSortList() => sortList;
    }
}
