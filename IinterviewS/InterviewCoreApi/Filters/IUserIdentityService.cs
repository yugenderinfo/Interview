using System.Threading.Tasks;

namespace InterviewCoreApi
{
    public interface IUserIdentityService
    {
        Task<bool> ValidateUserCredentialsAsync(string UserKey, string SecretValue);
    }
}
