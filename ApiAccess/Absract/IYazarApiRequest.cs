using Shared.Dtos;

namespace ApiAccess.Absract
{
    public interface IYazarApiRequest
    {
        YazarlarDto GetYazarByEmailPassword(string email, string password);

        List<YazarlarDto> GetYazarlar();

        YazarlarDto GetYazarById(int id);

        YazarlarDto InsertYazar(YazarlarDto model);

        YazarlarDto UpdateYazar(YazarlarDto model);

        bool DeleteYazarlar(int id);
    }
}
