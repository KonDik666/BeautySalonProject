using System;
using BeautySalonProject.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace BeautySalonProject.Controllers
{
    public class ServiceController
    {
        /// <summary>
        /// вывод сервисов из бд
        /// </summary>
        /// <returns></returns>
        public static List<Services> GetServices()

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Services").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Services>>(content.Result);
                return answer;

            }

        }

        public static List<Services> GetManServices()

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Services").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Services>>(content.Result);
                return answer.FirstOrDefault(x => x.categoryId=);

            }

        }

    }
}
