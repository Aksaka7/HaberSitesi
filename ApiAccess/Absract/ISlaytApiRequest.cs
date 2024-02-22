using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAccess.Absract
{
    public interface ISlaytApiRequest
    {
        List<SlaytlarDto> GetSlaytlar();

        SlaytlarDto GetSlaytById(int id);

        SlaytlarDto InsertSlayt(SlaytlarDto model);

        SlaytlarDto UpdateSlayt(SlaytlarDto model);

        bool DeleteSlaytlar(int id);
    }
}
