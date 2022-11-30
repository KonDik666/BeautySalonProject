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
    public class UsersController
    {
        /// <summary>
        /// вывод пользователей из бд
        /// </summary>
        /// <returns></returns>
        public static  Users GetUser(string login, string password)

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Users").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Users>>(content.Result);
                return answer.FirstOrDefault(x => x.userLogin == login && x.userPassword == password);

            }

        }

        public  bool Auth(string login, string password)

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Users/userLogin/userPassword").Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Users>>(content.Result);
                return response.IsSuccessStatusCode;

            }

        }
    }
}

