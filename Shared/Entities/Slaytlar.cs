using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities
{
    [Table("SLAYTLAR")]

    public class Slaytlar
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("BASLIGI")]
        public string? Basligi { get; set; }

        [Column("ICERIK")]
        public string? Icerik { get; set; }

        [Column("HABER_ID")]
        public int HaberID { get; set; }

        [Column("RESIM")]
        public string? Resim {  get; set; }

        [Column("AKTIFMI")]
        public bool AktifMi { get; set; }
    }
}
