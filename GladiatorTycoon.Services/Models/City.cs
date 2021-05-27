using Enums;

namespace Services.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Habitat Habitat { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
