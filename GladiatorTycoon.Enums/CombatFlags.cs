using System;

namespace Enums
{
    [Flags]
    public enum CombatFlags : long
    {
        Spellproof = 0x01,
        Invisible = 0x02,
        Threatening = 0x04,

    }
}
