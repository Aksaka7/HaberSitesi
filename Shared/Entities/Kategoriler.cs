using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    [Table("KATEGORILER")]

    public class Kategoriler
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("ACIKLAMA")]
        public string? Acıklama { get; set; }

        [Column("AKTIFMI")]
        public bool AktifMi { get; set; }

    }
}
