//using AdvisorGroup.Investor.Core.ConfigurationProvider;
using System.Threading.Tasks;

namespace InterviewCoreApi
{
    public class UserIdentityService : IUserIdentityService
    {
        IConfigProvider ConfigProvider { get; }
        public UserIdentityService(IConfigProvider configProvider)
        {
            ConfigProvider = configProvider;
        }

        const string ACT_API_USER_KEY = "ACT_API_USER_KEY";
        const string ACT_API_SECRET_KEY = "ACT_API_SECRET_KEY";

        public Task<bool> ValidateUserCredentialsAsync(string userKey, string secretValue)
        {
            string apiUserName = ConfigProvider.GetValue<string>(ACT_API_USER_KEY);
            string apiPassword = ConfigProvider.GetValue<string>(ACT_API_SECRET_KEY);
            return Task.FromResult(apiUserName == userKey && apiPassword == secretValue);
        }
    }
}
