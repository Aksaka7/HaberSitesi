using Shared.Dtos;

namespace Business.Abstract
{
    public interface ISlaytServices
    {
        List<SlaytlarDto> GetSlaytlar();

        SlaytlarDto GetSlaytById(int id);

        SlaytlarDto InsertSlayt(SlaytlarDto model);

        SlaytlarDto UpdateSlayt(SlaytlarDto model);

        bool DeleteSlaytlar(int id);
    }
}
