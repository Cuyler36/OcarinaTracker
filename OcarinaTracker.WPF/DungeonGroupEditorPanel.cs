using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using OcarinaTracker.Core;

namespace OcarinaTracker.WPF
{
    public sealed class DungeonGroupEditorPanel : WrapPanel
    {
        private static readonly Thickness BackgroundSliceThickness = new Thickness(10);
        private static readonly Bitmap BackgroundImg = Properties.Resources.Background;

        public new double Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                ResizeBackground();
            }
        }

        public new double Height
        {
            get => base.Height;
            set
            {
                base.Height = value;
                ResizeBackground();
            }
        }

        public DungeonGroupEditorPanel()
        {
            //SizeChanged += (_, __) => ResizeBackground();
        }

        private void ResizeBackground()
        {
            if (double.IsNaN(Width) || double.IsNaN(Height) || Width < 10 || Height < 10)
            {
                Background = null;
                return;
            }

            Background = new ImageBrush(BackgroundImg.NineSlice(
                new Rectangle(0, 0, (int)Width, (int)Height),
                BackgroundSliceThickness).GetBitmapSource());
        }
    }
}
