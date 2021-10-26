using System.Net.Http.Headers;
using System.Text.Json;

namespace Algorithms
{
    internal static class Utils
    {
        private static readonly HttpClient client = new HttpClient();
        public static void Print(Array list)
        {
            if(list.Length > 0)
                foreach (var item in list)
                    Console.WriteLine(item.ToString());
        }

        public static async Task<List<string>> ProccessNames(int quantity)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var request = client.GetStreamAsync(Constants.GetSensoApiURL() + $"?qtd={quantity}");
            var response = await JsonSerializer.DeserializeAsync<List<SensoAPI>>(await request);
            var nameList = new List<string>();

            if(response == null)
            {
                nameList.Add("Seso Api OFFLINE!!!");
            }
            else
            {
                foreach (var item in response)
                    nameList.Add(item.Name);
            }

            return nameList;
        }

        public static void ChangePositions(Student[] list, int firstPosition, int secondPosition)
        {
            Student currentItem = list[firstPosition];
            Student previousItems = list[secondPosition];
            list[firstPosition] = previousItems;
            list[secondPosition] = currentItem;
        }
    }

}
