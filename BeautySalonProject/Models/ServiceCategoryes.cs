using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonProject.Models
{
    public class ServiceCategoryes
    {
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
        [JsonProperty("categoryTitle")]
        public string CategoryTitle { get; set; }
        [JsonProperty("categoryImage")]
        public string CategoryImage { get; set; }
        [JsonProperty("services")]
        public object[] Services { get; set; }
       

    }
}
