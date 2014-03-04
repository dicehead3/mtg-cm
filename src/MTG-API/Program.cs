using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MTG_API
{
    class Program
    {
        private static HttpClient _httpClient;

        static void Main(string[] args)
        {
            _httpClient = new HttpClient();

            var task = new Task(GetCards);
            task.Start();
            task.Wait();
            Console.ReadKey();
        }

        private static async void GetCards()
        {
            var getAllCardsTask = await _httpClient.GetAsync("http://api.mtgdb.info/cards/");
            
            if (getAllCardsTask.StatusCode != HttpStatusCode.OK)
            {
                Debug.WriteLine("error; " + getAllCardsTask.StatusCode);
                return;
            }

            var getAllCardsContent = await getAllCardsTask.Content.ReadAsStringAsync();

            var serializer = new JavaScriptSerializer {MaxJsonLength = int.MaxValue};
            var cards = serializer.Deserialize<IEnumerable<Card>>(getAllCardsContent);
        }
    }
}
