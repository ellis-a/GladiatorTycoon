using System.Collections.Generic;

namespace GladiatorTycoon.Entities
{
    public class DominusEntity : PersonEntity
    {
        public List<ItemEntity> Inventory { get; set; }
        public List<HouseEntity> Homes { get; set; }
    }
}
