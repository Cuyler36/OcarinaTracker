using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Color = System.Drawing.Color;
using FontStyle = System.Drawing.FontStyle;
using Pen = System.Drawing.Pen;
using PixelFormat = System.Drawing.Imaging.PixelFormat;

namespace OcarinaTracker.Core
{
    public static class GraphicsUtilities
    {
        internal static readonly Font DrawingFont = new Font("Arial", 16.0f, FontStyle.Regular, GraphicsUnit.Pixel);
        internal static readonly SolidBrush FontBrush = new SolidBrush(Color.White);

        internal static readonly Pen OutlinePen = new Pen(Color.Black) {LineJoin = LineJoin.Round, Width = 3.0f};

        public static BitmapSource MakeTransparentGrayscale(this BitmapSource source)
        {
            using (var bitmap = source.GetBitmap())
            {
                for (var y = 0; y < bitmap.Height; y++)
                {
                    for (var x = 0; x < bitmap.Width; x++)
                    {
                        var pixel = bitmap.GetPixel(x, y);
                        var grayscale = (pixel.R + pixel.G + pixel.B) / 3;
                        bitmap.SetPixel(x, y, Color.FromArgb(pixel.A / 2, grayscale, grayscale, grayscale));
                    }
                }

                return bitmap.GetBitmapSource();
            }
        }

        public static void DrawOutlinedText(this Bitmap bitmap, string text)
        {
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var stringFormat = new StringFormat())
                {
                    // Align text to bottom right.
                    stringFormat.Alignment = StringAlignment.Far;
                    stringFormat.LineAlignment = StringAlignment.Far;

                    // Draw the text.
                    using (var graphicsPath = new GraphicsPath())
                    {
                        graphicsPath.AddString(text, DrawingFont.FontFamily, 0, DrawingFont.Size,
                            new Rectangle(0, 0, bitmap.Width, bitmap.Height), stringFormat);

                        graphics.DrawPath(OutlinePen, graphicsPath);
                        graphics.FillPath(FontBrush, graphicsPath);
                    }
                }
            }
        }

        public static Bitmap GetBitmap(this BitmapSource source)
        {
            var src = new FormatConvertedBitmap();
            src.BeginInit();
            src.Source = source;
            src.DestinationFormat = PixelFormats.Bgra32;
            src.EndInit();

            var bitmap = new Bitmap(src.PixelWidth, src.PixelHeight, PixelFormat.Format32bppArgb);
            var data = bitmap.LockBits(new Rectangle(System.Drawing.Point.Empty, bitmap.Size), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            src.CopyPixels(Int32Rect.Empty, data.Scan0, data.Height * data.Stride, data.Stride);
            bitmap.UnlockBits(data);

            return bitmap;
        }

        public static BitmapSource GetBitmapSource(this Bitmap bitmap)
        {
            var bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadOnly, bitmap.PixelFormat);

            var bitmapSource = BitmapSource.Create(bitmapData.Width, bitmapData.Height, bitmap.HorizontalResolution,
                bitmap.VerticalResolution, PixelFormats.Bgra32, null, bitmapData.Scan0,
                bitmapData.Stride * bitmapData.Height, bitmapData.Stride);

            bitmap.UnlockBits(bitmapData);
            return bitmapSource;
        }
    }
}