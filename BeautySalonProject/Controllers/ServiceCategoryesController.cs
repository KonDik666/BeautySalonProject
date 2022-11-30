using BeautySalonProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonProject.Controllers
{
    public class ServiceCategoryesController
    {
        /// <summary>
        /// вывод категорий из бд
        /// </summary>
        /// <returns></returns>
        public List<ServiceCategoryes> GetServiceCategoryes()

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}ServiceCategoryes").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<ServiceCategoryes>>(content.Result);
                return answer;

            }

        }
    }
}
