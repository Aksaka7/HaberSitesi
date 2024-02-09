﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class YorumlarDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? Icerik { get; set; }

        public int HaberID { get; set; }

        public int EklemeTarihi { get; set; }

        public bool AktifMi { get; set; }
    }
}