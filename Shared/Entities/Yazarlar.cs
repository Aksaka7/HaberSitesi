using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities
{
    [Table("YAZARLAR")]

    public class Yazarlar
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

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
