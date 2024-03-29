﻿using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKategoriService
    {
        List<KategorilerDto> GetKategorilerList();
        KategorilerDto GetKategoriById(int id);
        KategorilerDto InsertKategori(KategorilerDto model);
        KategorilerDto UpdateKategori(KategorilerDto model);
        bool DeleteKategori(int id);
    }
}
