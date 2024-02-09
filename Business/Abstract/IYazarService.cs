using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IYazarService
    {
        List<YazarlarDto> GetYazarlar();

        YazarlarDto GetYazarById(int id);

        YazarlarDto InsertYazar(YazarlarDto model);

        YazarlarDto UpdateYazar(YazarlarDto model);

        bool DeleteYazarlar(int id);
    }
}