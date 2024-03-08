using Shared.Dtos;

namespace ApiAccess.Absract
{
    public interface IYorumApiRequest
    {
        List<YorumlarDto> GetTumYorumlar();

        YorumlarDto GetYorumById(int yorumId);

        YorumlarDto InsertYorum(YorumlarDto model);

        YorumlarDto UpdateYorum(YorumlarDto model);

        bool DeleteYorum(int id);
    }
}
