using BetterCode.Core.Model;

namespace BetterCode.Core.Data
{
    public interface ISessionDataProvider
    {
        Task<IEnumerable<Session>> GetSessionsAsync();
    }
}