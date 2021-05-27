using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Instruction
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public bool IsDefault { get; set; }
        public string ConditionTarget { get; set; }
        public string ConditionType { get; set; }
        public int ConditionValue { get; set; }
        public string ConditionState { get; set; }
        public string ActionTarget { get; set; }
        public string ActionAbility { get; set; }
    }
}
