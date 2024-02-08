namespace Shared.Dtos
{
    public class HaberlerDto
    {
        public int Id { get; set; }
        public string? Baslik { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public int YazarId { get; set; }
        public int KategoriID { get; set; }
        public string? Icerik { get; set; }
        public string? Video { get; set; }
        public string? Resim { get; set; }
        public int GosterimSayisi { get; set; }
        public bool AktifMi { get; set; }
    }
}
