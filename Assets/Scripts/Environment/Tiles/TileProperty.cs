using System;

namespace Game
{
    [Flags]
    internal enum TileProperty
    {
        None = 0,
        Player = 1,
        Collides = 2,
        Movable = 4,
    }
}