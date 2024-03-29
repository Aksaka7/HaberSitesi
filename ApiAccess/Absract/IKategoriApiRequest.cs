﻿using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAccess.Absract
{
    public interface IKategoriApiRequest
    {
        List<KategorilerDto> GetKategoriler();
        KategorilerDto GetKategoriById(int kategoriId);
        KategorilerDto KategoriEkle(KategorilerDto model);
        KategorilerDto UpdateKategori(KategorilerDto model);
        bool DeleteKategori(int kategoriId);
    }
}
