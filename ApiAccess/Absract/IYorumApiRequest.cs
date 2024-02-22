using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAccess.Absract
{
    public interface IYorumApiRequest
    {
        List<YorumlarDto> GetYorumlar();

        YorumlarDto GetYorumById(int id);

        YorumlarDto InsertYorum(YorumlarDto model);

        YorumlarDto UpdateYorum(YorumlarDto model);

        bool DeleteYorum(int id);
    }
}
