using System;

namespace PolyamorySweetLove
{
    [Flags]
    public enum FarmHousePositions : byte
    {
        None = 0,
        Bed = 1,
        Kitchen = 2,
        Patio = 4,
        Porch = 8,
        Room = 0x10,
        Porch2 = 0x20,
        Random1 = 0x40,
        Random2 = 0x80,
        All = byte.MaxValue
    }
}
