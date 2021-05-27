using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Masters")]
    public class MasterEntity : PersonEntity
    {
        public List<ItemEntity> Inventory { get; set; }
        public List<HouseEntity> Homes { get; set; }
    }
}
