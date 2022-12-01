using BeautySalonProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonProject.Controllers
{
    public static class UsersController
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

        public static bool Auth(string login, string password)

        {

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Users/{login}/{password}").Result;
              
                return response.IsSuccessStatusCode;

            }

        }

        public static bool AddUser(Users user)
        {
            string jsonStr = JsonConvert.SerializeObject(user);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsync($"{Manager.RootUrl}Users", byteContent).Result;
                return response.IsSuccessStatusCode;
            }
        }
    }
}

