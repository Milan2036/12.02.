namespace Konyvespolc.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Cim { get; set; } = string.Empty;
        public string? Szerzo { get; set; }
        public int KiadasiEv { get; set; }
        public int Oldalszam { get; set; }
    }
}
