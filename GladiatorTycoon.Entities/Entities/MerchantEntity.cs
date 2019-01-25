using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Merchants")]
    public class MerchantEntity : PersonEntity
    {
        public List<ItemEntity> Wares { get; set; }
    }
}
