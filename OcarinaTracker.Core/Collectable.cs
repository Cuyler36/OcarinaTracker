using System.Collections.Generic;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace OcarinaTracker.Core
{
    public sealed class Collectable
    {
        private static readonly Bitmap Tile = Properties.Resources.Tile1x1;

        private List<CollectableStage> _stages;
        private int _currentStage;

        public int CurrentStage
        {
            get => _currentStage;
            set
            {
                _currentStage = value;
                DrawCurrentImage();
            }
        }
        public readonly bool MultipleExist;
        public readonly int MaxValue;
        public BitmapSource Image { get; private set; }
        public List<CollectableStage> Stages
        {
            get => _stages;
            set
            {
                _stages = value;
                CurrentStage = 0;
            }
        }

        // Style options
        public bool DrawTileBackground = true;

        public Collectable()
        {
            MultipleExist = false;
            MaxValue = -1;
        }

        public Collectable(bool multiple = false, int maxValue = -1)
        {
            MultipleExist = multiple;
            MaxValue = maxValue;
        }

        private void DrawCurrentImage()
        {
            // Draw base layer
            if (CurrentStage == 0)
            {
                Image = Stages[0].Image.MakeTransparentGrayscale();
            }
            else
            {
                if (MultipleExist)
                {
                    using (var bmp = Stages[0].Image.GetBitmap())
                    {
                        bmp.DrawOutlinedText(CurrentStage.ToString());
                        Image = bmp.GetBitmapSource();
                    }
                }
                else
                {
                    Image = Stages[CurrentStage - 1].Image;
                }
            }

            if (!DrawTileBackground) return;

            // Draw tile underneath
            using (var bitmap = new Bitmap(Tile))
            {
                using (var imgBitmap = Image.GetBitmap())
                {
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.DrawImage(Tile, new Point());
                        graphics.DrawImage(imgBitmap, new Point());
                    }
                }

                Image = bitmap.GetBitmapSource();
            }
        }

        public string GetCurrentStageName() =>
            MultipleExist ? Stages[0].Description :
            CurrentStage == 0 ? Stages[0].Description : Stages[CurrentStage - 1].Description;

        public BitmapSource Increment()
        {
            if (!MultipleExist)
            {
                if (CurrentStage + 1 > Stages.Count)
                {
                    CurrentStage = 0;
                }
                else
                {
                    CurrentStage++;
                }
            }
            else
            {
                if (CurrentStage + 1 > MaxValue)
                {
                    CurrentStage = 0;
                }
                else
                {
                    CurrentStage++;
                }
            }

            return Image;
        }

        public BitmapSource Decrement()
        {
            if (!MultipleExist)
            {
                if (CurrentStage - 1 < 0)
                {
                    CurrentStage = Stages.Count;
                }
                else
                {
                    CurrentStage--;
                }
            }
            else
            {
                if (CurrentStage - 1 < 0)
                {
                    CurrentStage = MaxValue;
                }
                else
                {
                    CurrentStage--;
                }
            }

            return Image;
        }

        // Operator overloads
        public static Collectable operator ++(Collectable collectable)
        {
            collectable.Increment();
            return collectable;
        }

        public static Collectable operator --(Collectable collectable)
        {
            collectable.Decrement();
            return collectable;
        }
    }
}
