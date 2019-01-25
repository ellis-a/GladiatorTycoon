using System.Collections.Generic;

namespace GladiatorTycoon.Entities
{
    public class MerchantEntity : PersonEntity
    {
        public List<ItemEntity> Wares { get; set; }
    }
}
