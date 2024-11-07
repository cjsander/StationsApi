using Microsoft.AspNetCore.Identity;

namespace Stations.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}
