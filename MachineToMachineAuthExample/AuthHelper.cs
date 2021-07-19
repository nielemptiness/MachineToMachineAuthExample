using FluentAssertions;
using Newtonsoft.Json;

namespace MachineToMachineAuthExample
{
    public class AuthHelper
    {
        public static string GetM2MToken(string authClientId, string authSecret)
        {
            var response = AuthProvider.GetM2MAuthToken(authClientId, authSecret);
            
            var model = JsonConvert.DeserializeObject<MockedResponseModel>(response.Content);
            model.Should().NotBeNull();
            
            var token = model?.access_token;
            token.Should().NotBeNullOrEmpty();
            
            return token;
        }
    }
}