using Newtonsoft.Json;

namespace MachineToMachineAuthExample
{
    public class MockedResponseModel
    {
        [JsonRequired]
        public string access_token { get; init; }
        public int expires_in { get; init; }
        public string token_type { get; init; }
    }
}