namespace AdminUI.Models
{
    public class YazarViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Resim { get; set; }
        public IFormFile? ResimFile { get; set; }
        public bool AktifMi { get; set; }
    }
}
