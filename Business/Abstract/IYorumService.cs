using Shared.Dtos;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IYorumService
    {
        List<YorumlarDto> GetYorumlar();

        YorumlarDto GetYorumById(int id);

        YorumlarDto InsertYorum(YorumlarDto model);

        YorumlarDto UpdateYorum(YorumlarDto model);

        bool DeleteYorum(int id);


    }
}
