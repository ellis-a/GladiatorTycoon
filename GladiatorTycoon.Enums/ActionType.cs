using System;

namespace Enums
{
    [Flags]
    public enum ActionType
    {
        None = 0x00,
        MainAction = 0x01,
        BonusAction = 0x02,
        Reaction = 0x04
    }
}
