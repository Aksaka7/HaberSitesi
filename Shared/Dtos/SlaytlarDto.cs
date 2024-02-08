using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class SlaytlarDto
    {
        public int Id { get; set; }

        public string? Basligi { get; set; }

        public string? Icerik { get; set; }

        public int HaberID { get; set; }

        public string? Resim { get; set; }

        public bool AktifMi { get; set; }
    }
}
