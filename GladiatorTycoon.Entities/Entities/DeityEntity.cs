using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Deities")]
    public class DeityEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
