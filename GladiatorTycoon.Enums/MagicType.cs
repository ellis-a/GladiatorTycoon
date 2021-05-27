using System;

namespace Enums
{
    [Flags]
    public enum MagicType
    {
        None    = 0,
        Fire    = 1 << 0,
        Storm   = 1 << 1,
        Earth   = 1 << 2,
        Holy    = 1 << 3,
        Chaos   = 1 << 4,
        Death   = 1 << 5,
        Mind    = 1 << 6,
        Time    = 1 << 7,
        Beast   = 1 << 8,
    }
}
