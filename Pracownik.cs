using System.Xml.Serialization;

namespace Projekt
{
    public class Pracownik
    {

        [XmlElement("Pracownik")]
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Username { get; set; }
        public string? Stanowisko { get; set; }
        public string? pesel { get; set; }
        public string? nr_PWZ { get; set; }
        public string? specjalizacja { get; set; }
        public List<DateTime>? praca { get; set; }

    }
}
