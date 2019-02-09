using System.Collections.Generic;

namespace OcarinaTracker.Core
{
    public static class Collectables
    {
        public static readonly List<Collectable> UsableCollectables = new List<Collectable>
        {
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Deku Sticks", Properties.Resources._Items__Stick.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Fairy Bow", Properties.Resources._Items__Bow.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Fire Arrows", Properties.Resources._Items__Arrows_Fire.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Fairy Slingshot", Properties.Resources._Items__Sling.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Hookshot", Properties.Resources._Items__Hook.GetBitmapSource()),
                    new CollectableStage("Longshot", Properties.Resources._Items__Long.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Ice Arrows", Properties.Resources._Items__Arrows_Ice.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Boomerang", Properties.Resources._Items__Boomerang.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Megaton Hammer", Properties.Resources._Items__Megaton.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Light Arrows", Properties.Resources._Items__Arrows_Light.GetBitmapSource())
                }
            },
        };

        public static readonly List<Collectable> UsableCollectables2 = new List<Collectable>
        {
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Deku Nuts", Properties.Resources._Items__Nut.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Fairy Ocarina", Properties.Resources._Items__Ocarina.GetBitmapSource()),
                    new CollectableStage("Ocarina of Time", Properties.Resources._Items__OoT.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Din's Fire", Properties.Resources._Items__Din.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Bombs", Properties.Resources._Items__Bomb.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Lens of Truth", Properties.Resources._Items__Lens.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Farore's Wind", Properties.Resources._Items__Farore.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Bombchus", Properties.Resources._Items__Chu.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Magic Beans", Properties.Resources._Items__Bean.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Nayru's Love", Properties.Resources._Items__Nayru.GetBitmapSource())
                }
            },
        };

        public static readonly List<Collectable> SideCollectables = new List<Collectable>
        {
            new Collectable(true, 4)
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Bottles", Properties.Resources._Items__Bottle.GetBitmapSource())
                }
            },
            new Collectable(true, 100)
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Gold Skultulla Tokens", Properties.Resources._Items__Token.GetBitmapSource())
                }
            },
            new Collectable(true, 8)
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Heart Containers", Properties.Resources._Items__Container.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Weird Egg", Properties.Resources._Items__Malon_Egg.GetBitmapSource()),
                    new CollectableStage("Cucco", Properties.Resources._Items__Cucco.GetBitmapSource()),
                    new CollectableStage("Zelda's Letter", Properties.Resources._Items__Letter.GetBitmapSource()),
                    new CollectableStage("Keaton Mask", Properties.Resources._Items__Keaton.GetBitmapSource()),
                    new CollectableStage("Skull Mask", Properties.Resources._Items__Skull.GetBitmapSource()),
                    new CollectableStage("Spooky Mask", Properties.Resources._Items__Spooky.GetBitmapSource()),
                    new CollectableStage("Bunny Hood", Properties.Resources._Items__Bunny.GetBitmapSource()),
                    new CollectableStage("Goron Mask", Properties.Resources._Items__Goron.GetBitmapSource()),
                    new CollectableStage("Zora Mask", Properties.Resources._Items__Zora.GetBitmapSource()),
                    new CollectableStage("Gerudo Mask", Properties.Resources._Items__Gerudo.GetBitmapSource()),
                    new CollectableStage("Mask of Truth", Properties.Resources._Items__Truth.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Gerudo Token", Properties.Resources._Items__Grounds.GetBitmapSource())
                }
            },
            new Collectable(true, 36)
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Heart Pieces", Properties.Resources._Items__Piece.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Pocket Egg", Properties.Resources._Items__Egg.GetBitmapSource()),
                    new CollectableStage("Pocket Cucco", Properties.Resources._Items__Cucco.GetBitmapSource()),
                    new CollectableStage("Cojiro", Properties.Resources._Items__Cojiro.GetBitmapSource()),
                    new CollectableStage("Odd Mushroom", Properties.Resources._Items__Mushroom.GetBitmapSource()),
                    new CollectableStage("Odd Potion", Properties.Resources._Items__Powder.GetBitmapSource()),
                    new CollectableStage("Poacher's Saw", Properties.Resources._Items__Saw.GetBitmapSource()),
                    new CollectableStage("Broken Goron Sword", Properties.Resources._Items__Broken.GetBitmapSource()),
                    new CollectableStage("Prescription", Properties.Resources._Items__Prescription.GetBitmapSource()),
                    new CollectableStage("Eyeball Frog", Properties.Resources._Items__Frog.GetBitmapSource()),
                    new CollectableStage("Eyedrops", Properties.Resources._Items__Medicine.GetBitmapSource()),
                    new CollectableStage("Claim Check", Properties.Resources._Items__Slab.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Stone of Agony", Properties.Resources._Items__Agony.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Magic", Properties.Resources._Items__Normal.GetBitmapSource()),
                    new CollectableStage("Magic", Properties.Resources._Items__Double.GetBitmapSource())
                }
            },
        };

        public static readonly List<Collectable> EquippableCollectables = new List<Collectable>
        {
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Kokiri Sword", Properties.Resources._Items__Kokiri.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Master Sword", Properties.Resources._Items__Master.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Biggoron Sword", Properties.Resources._Items__Big_Goron.GetBitmapSource()),
                    new CollectableStage("Broken Goron Sword", Properties.Resources._Items__Broken.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Deku Shield", Properties.Resources._Items__Deku.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Hylian Shield", Properties.Resources._Items__Hylian.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Mirror Shield", Properties.Resources._Items__Mirror.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Kokiri Tunic", Properties.Resources._Items__Green.GetBitmapSource())
                },
                CurrentStage = 1
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Goron Tunic", Properties.Resources._Items__Red.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Zora Tunic", Properties.Resources._Items__Blue.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Kokiri Boots", Properties.Resources._Items__Boots.GetBitmapSource())
                },
                CurrentStage = 1
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Iron Boots", Properties.Resources._Items__Iron.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Hover Boots", Properties.Resources._Items__Hover.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Goron Bracelet", Properties.Resources._Items__Bracelet.GetBitmapSource()),
                    new CollectableStage("Silver Gauntlets", Properties.Resources._Items__Silver.GetBitmapSource()),
                    new CollectableStage("Golden Gauntlets", Properties.Resources._Items__Gold.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Silver Scale", Properties.Resources._Items__Scale_1.GetBitmapSource()),
                    new CollectableStage("Golden Scale", Properties.Resources._Items__Scale_2.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Adult's Wallet", Properties.Resources._Items__Adult.GetBitmapSource()),
                    new CollectableStage("Giant's Wallet", Properties.Resources._Items__Giant.GetBitmapSource())
                }
            },
        };

        public static readonly List<Collectable> SongStoneMedallionList = new List<Collectable>
        {
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Zelda's Lullaby", Properties.Resources._Items__Lullaby.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Epona's Song", Properties.Resources._Items__Epona.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Saria's Song", Properties.Resources._Items__Saria.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Sun's Song", Properties.Resources._Items__Sun.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Song of Time", Properties.Resources._Items__Time.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Song of Storms", Properties.Resources._Items__Storm.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Minuet of Forest", Properties.Resources._Items__Minuet.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Bolero of Fire", Properties.Resources._Items__Bolero.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Serenade of Water", Properties.Resources._Items__Serenade.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Requiem of Spirit", Properties.Resources._Items__Requiem.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Nocturne of Shadow", Properties.Resources._Items__Nocturne.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Prelude of Light", Properties.Resources._Items__Prelude.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Kokiri's Emerald", Properties.Resources._Items__Emerald.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Goron's Ruby", Properties.Resources._Items__Ruby.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Zora's Sapphire", Properties.Resources._Items__Sapphire.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Forest Medallion", Properties.Resources._Items__Forest.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Fire Medallion", Properties.Resources._Items__Fire.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Water Medallion", Properties.Resources._Items__Water.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Spirit Medallion", Properties.Resources._Items__Spirit.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Shadow Medallion", Properties.Resources._Items__Shadow.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Light Medallion", Properties.Resources._Items__Light.GetBitmapSource())
                }
            },
        };

        /*new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("", Properties.Resources._Items__.GetBitmapSource()),
                }
            },*/

        /*
         *new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Kokiri Sword", Properties.Resources._Items__Kokiri.GetBitmapSource())
                }
            },
            new Collectable(true, 100)
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Skulltula Tokens", Properties.Resources._Items__Token.GetBitmapSource())
                }
            },
            new Collectable
            {
                Stages = new List<CollectableStage>
                {
                    new CollectableStage("Adult's Wallet", Properties.Resources._Items__Adult.GetBitmapSource()),
                    new CollectableStage("Giant's Wallet", Properties.Resources._Items__Giant.GetBitmapSource()),
                }
            },
         *
         */
    }
}
