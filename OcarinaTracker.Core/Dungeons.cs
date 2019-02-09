namespace OcarinaTracker.Core
{
    public static class Dungeons
    {
        public static readonly Dungeon[] DungeonList =
        {
            new Dungeon("Deku", true, true, false, false), new Dungeon("Cavern", true, true, false, false), new Dungeon("Jabu", true, true, false, false),
            new Dungeon("Forest"), new Dungeon("Fire"), new Dungeon("Water"),
            new Dungeon("Spirit"), new Dungeon("Shadow")
        };

        public static readonly Dungeon[] MiniDungeons =
        {
            new Dungeon("GTG", false, false, true, false, false), new Dungeon("Gerudo", false, false, true, false, false),
            new Dungeon("Well", true, true, true, false, false), new Dungeon("Ganon", false, false, true, true, false)
        };
    }
}
