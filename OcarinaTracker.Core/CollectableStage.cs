using System.Windows.Media.Imaging;

namespace OcarinaTracker.Core
{
    public sealed class CollectableStage
    {
        public readonly string Description;
        public readonly BitmapSource Image;

        public CollectableStage(string description, BitmapSource image)
        {
            Description = description;
            Image = image;
        }
    }
}
