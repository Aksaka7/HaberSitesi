using Microsoft.AspNetCore.Http;

namespace ApiAccess.Absract
{
    public interface ICommonApiRequest
    {
        string Upload(IFormFile file);
    }
}
