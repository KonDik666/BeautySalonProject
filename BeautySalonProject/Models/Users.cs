using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonProject.Models
{
    
        public class Users
        {
        [JsonProperty("idrole")]
        public int idRole { get; set; }

        
        public string userName { get; set; }
       
        public string userLastName { get; set; }
            public string userOtherName { get; set; }
            public string userLogin { get; set; }
            public string userPassword { get; set; }
        [JsonProperty("idroleNavigation")]
        public object idRoleNavigation { get; set; }
        }

    
}
