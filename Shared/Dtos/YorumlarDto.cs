﻿namespace Shared.Dtos
{
    public class YorumlarDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? Icerik { get; set; }

        public string? Baslik { get; set; }

        public string? HaberBaslik { get; set; }

        public int HaberId { get; set; }

        public DateTime EklemeTarihi { get; set; }

        public bool AktifMi { get; set; }
    }
}
