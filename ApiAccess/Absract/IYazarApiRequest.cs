using Shared.Dtos;

namespace ApiAccess.Absract
{
    public interface IYazarApiRequest
    {
        YazarlarDto GetYazarByEmailPassword(string email, string password);
    }
}
