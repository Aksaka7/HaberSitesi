﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    [Table("YORUMLAR")]

    public class Yorumlar
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

        [Column("ICERIK")]
        public string? Icerik { get; set; }

        [Column("HABER_ID")]
        public int HaberID { get; set; }

        [Column("EKLEME_TARIHI")]
        public int EklemeTarihi { get; set; }

        [Column("AKTIFMI")]
        public bool AktifMi { get; set; }
    }
}