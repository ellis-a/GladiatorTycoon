using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Houses")]
    public class HouseEntity
    {
        [Key]
        public int Id { get; set; }

        public CityEntity Location { get; set; }
        public int PeopleCapacity { get; set; }
        public int Value { get; set; }
    }
}
