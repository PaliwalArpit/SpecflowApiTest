using Newtonsoft.Json;
using RestSharp;
using System;

namespace SpecGlowGitTest
{
    public class Demo
    {
        public UserListDTO GetUsers()
        {
            var restclient = new RestClient("https://reqres.in/");
            var restRequest = new RestRequest("api/users?page=2", Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restclient.Execute(restRequest);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<UserListDTO>(content);
            return users;
        }
    }
}
