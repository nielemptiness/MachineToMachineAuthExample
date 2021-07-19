using System;
using System.Text;
using RestSharp;

namespace MachineToMachineAuthExample
{
    public class AuthProvider
    {
        public static IRestResponse GetM2MAuthToken(string authClientId, string authClientSecret)
        {
            var authToken =
                Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1")
                    .GetBytes($"{authClientId}:{authClientSecret}"));
            
            var client = new RestClient("{your_token_provider}");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", "Basic " + authToken);
            request.AddParameter("grant_type", "client_credentials");

            var response = client.Execute(request);
            return response;
        }
    }
}