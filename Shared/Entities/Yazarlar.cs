using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    [Table("YAZARLAR")]

    public class Yazarlar
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("AD")]
        public string? Name { get; set; }

        [Column("SOYADI")]
        public string? Surname { get; set; }

        [Column("EPOSTA")]
        public string? Email { get; set; }

        [Column("SIFRE")]
        public string? Password { get; set; }

        [Column("RESIM")]
        public string? Resim {  get; set; }

        [Column("AKTIFMI")]
        public bool AktifMi { get; set; }
    }
}
