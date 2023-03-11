using Newtonsoft.Json;
using RestSharp;
using RestSharpDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpDemo
{
    public class Demo
    {
        public Users GetUsers()
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("/api/users?page=2", Method.Get);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            RestResponse response = client.Execute(request);
            var content = response.Content;

            Users users = JsonConvert.DeserializeObject<Users>(content);
            return users;
        }
    }
}
