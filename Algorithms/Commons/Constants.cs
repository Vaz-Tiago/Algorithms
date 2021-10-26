namespace Algorithms
{
    internal static class Constants
    {
        private static readonly string sensoApiURL = "https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking";
        public static string GetSensoApiURL()
        {
            return sensoApiURL;
        }
    }
}
