using Shared.Dtos;

namespace ApiAccess.Absract
{
    public interface IHaberApiRequest
    {
       
        List<HaberlerDto> GetHaberler();

        HaberlerDto GetHaberById(int id);
        HaberlerDto InsertHaber(HaberlerDto model);

        HaberlerDto UpdateHaber(HaberlerDto model);

        bool DeleteHaber(int id);
    }
}
