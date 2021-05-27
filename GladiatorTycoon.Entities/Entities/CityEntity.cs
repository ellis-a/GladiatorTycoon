using Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Cities")]
    public class CityEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public Habitat Habitat { get; set; }
    }
}
