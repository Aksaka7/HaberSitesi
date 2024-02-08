using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class KategorilerDto
    {
        public int Id { get; set; }
        public string? Aciklama { get; set; }
        public bool AktifMi { get; set; }
    }
}
