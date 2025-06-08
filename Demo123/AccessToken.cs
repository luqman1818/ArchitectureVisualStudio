using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Demo123
{
    class AccessToken
    {
        [JsonProperty("access_token")]
        public string token { get; set; }

        [JsonProperty("token_type")]
        public string token_type { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }
    }
}
