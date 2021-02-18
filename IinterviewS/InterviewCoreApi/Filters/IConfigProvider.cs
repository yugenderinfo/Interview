//using AdvisorGroup.Investor.Core.ConfigurationProvider;
namespace InterviewCoreApi
{
    internal interface IConfigProvider
    {
        T GetValue<T>(T aCT_API_USER_KEY);
    }
}