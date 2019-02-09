using System.Collections.Generic;
using OcarinaTracker.Core.Properties;

namespace OcarinaTracker.Core
{
    public sealed class Dungeon
    {
        public readonly string Name;
        public readonly bool HasMap;
        public readonly bool HasCompass;
        public readonly bool HasKeys;
        public readonly bool HasBigKey;
        public readonly bool HasStoneOrMedallion;

        public readonly Collectable Map = new Collectable
        {
            DrawTileBackground = false,
            Stages = new List<CollectableStage>
            {
                new CollectableStage("Dungeon Map", Resources.Dungeon_Map.GetBitmapSource())
            }
        };

        public readonly Collectable Compass = new Collectable
        {
            DrawTileBackground = false,
            Stages = new List<CollectableStage>
            {
                new CollectableStage("Compass", Resources.Dungeon_Compass.GetBitmapSource())
            }
        };

        public readonly Collectable Keys = new Collectable(true, 9)
        {
            DrawTileBackground = false,
            Stages = new List<CollectableStage>
            {
                new CollectableStage("Small Keys", Resources.Dungeon_Key.GetBitmapSource())
            }
        };

        public readonly Collectable BigKey = new Collectable
        {
            DrawTileBackground = false,
            Stages = new List<CollectableStage>
            {
                new CollectableStage("Big Key", Resources.Dungeon_Big_Key.GetBitmapSource())
            }
        };

        public readonly Collectable SpiritStonesMedallion = new Collectable
        {
            DrawTileBackground = false,
            Stages = new List<CollectableStage>
            {
                new CollectableStage("Kokiri's Emerald", Resources._Items__Emerald.GetBitmapSource()),
                new CollectableStage("Goron's Ruby", Resources._Items__Ruby.GetBitmapSource()),
                new CollectableStage("Zora's Sapphire", Resources._Items__Sapphire.GetBitmapSource()),
                new CollectableStage("Light Medallion", Resources._Items__Light.GetBitmapSource()),
                new CollectableStage("Forest Medallion", Resources._Items__Forest.GetBitmapSource()),
                new CollectableStage("Fire Medallion", Resources._Items__Fire.GetBitmapSource()),
                new CollectableStage("Water Medallion", Resources._Items__Water.GetBitmapSource()),
                new CollectableStage("Spirit Medallion", Resources._Items__Spirit.GetBitmapSource()),
                new CollectableStage("Shadow Medallion", Resources._Items__Shadow.GetBitmapSource()),
            }
        };

        public Dungeon(string name, bool hasMap = true, bool hasCompass = true, bool hasKeys = true,
            bool hasBigKey = true, bool hasStoneOrMedallion = true)
        {
            Name = name;
            HasMap = hasMap;
            HasCompass = hasCompass;
            HasKeys = hasKeys;
            HasBigKey = hasBigKey;
            HasStoneOrMedallion = hasStoneOrMedallion;
        }
    }
}
