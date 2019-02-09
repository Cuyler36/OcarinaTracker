using System.Drawing;
using System.Windows;

namespace OcarinaTracker.WPF
{
    public static class Slice
    {
        public static Bitmap NineSlice(this Bitmap bitmap, Rectangle destinationRectangle, Thickness sizingMargins = new Thickness())
        {
            // Calculate center width & height
            var centerMarginWidth = (int) (sizingMargins.Left + sizingMargins.Right);
            var centerMarginHeight = (int) (sizingMargins.Top + sizingMargins.Bottom);

            // Calculate sizes for each slice to cut from the original image
            var leftX = 0;
            var rightX = bitmap.Width - (int)sizingMargins.Right;
            var centerX = (int) sizingMargins.Left;

            var topY = 0;
            var bottomY = bitmap.Height - (int) sizingMargins.Bottom;
            var centerY = (int) sizingMargins.Top;

            var topHeight = (int) sizingMargins.Top;
            var bottomHeight = (int) sizingMargins.Bottom;
            var centerHeight = bitmap.Height - centerMarginHeight;

            var leftWidth = (int) sizingMargins.Left;
            var rightWidth = (int) sizingMargins.Right;
            var centerWidth = bitmap.Width - centerMarginWidth;

            // Declare the bounds for each slice using the values above
            var topLeftSrc = new Rectangle(leftX, topY, leftWidth, topHeight);
            var topCenterSrc = new Rectangle(centerX, topY, centerWidth, topHeight);
            var topRightSrc = new Rectangle(rightX, topY, rightWidth, topHeight);

            var bottomLeftSrc = new Rectangle(leftX, bottomY, leftWidth, bottomHeight);
            var bottomCenterSrc = new Rectangle(centerX, bottomY, centerWidth, bottomHeight);
            var bottomRightSrc = new Rectangle(rightX, bottomY, rightWidth, bottomHeight);

            var centerLeftSrc = new Rectangle(leftX, centerY, leftWidth, centerHeight);
            var centerCenterSrc = new Rectangle(centerX, centerY, centerWidth, centerHeight);
            var centerRightSrc = new Rectangle(rightX, centerY, rightWidth, centerHeight);

            // Calculate sizes for each slice to be drawn to the screen

            // X positions for left, right and center slices
            leftX = destinationRectangle.Left;
            rightX = destinationRectangle.Right - (int) sizingMargins.Right;
            centerX = destinationRectangle.Left + (int) sizingMargins.Left;

            // Y positions for top, bottom and center slices
            topY = destinationRectangle.Top;
            bottomY = destinationRectangle.Bottom - (int) sizingMargins.Bottom;
            centerY = destinationRectangle.Top + (int) sizingMargins.Top;

            // Heights for left, right and center slices
            topHeight = (int) sizingMargins.Top;
            bottomHeight = (int) sizingMargins.Bottom;
            centerHeight = destinationRectangle.Height - centerMarginHeight;

            // Widths for top, bottom and center slices
            leftWidth = (int) sizingMargins.Left;
            rightWidth = (int) sizingMargins.Right;
            centerWidth = destinationRectangle.Width - centerMarginWidth;

            // Declare the bounds for each slice using the values above
            var topLeftDest = new Rectangle(leftX, topY, leftWidth, topHeight);
            var topCenterDest = new Rectangle(centerX, topY, centerWidth, topHeight);
            var topRightDest = new Rectangle(rightX, topY, rightWidth, topHeight);

            var bottomLeftDest = new Rectangle(leftX, bottomY, leftWidth, bottomHeight);
            var bottomCenterDest = new Rectangle(centerX, bottomY, centerWidth, bottomHeight);
            var bottomRightDest = new Rectangle(rightX, bottomY, rightWidth, bottomHeight);

            var centerLeftDest = new Rectangle(leftX, centerY, leftWidth, centerHeight);
            var centerCenterDest = new Rectangle(centerX, centerY, centerWidth, centerHeight);
            var centerRightDest = new Rectangle(rightX, centerY, rightWidth, centerHeight);

            // Draw the new image.
            var outBitmap = new Bitmap(destinationRectangle.Width, destinationRectangle.Height);
            using (var graphics = Graphics.FromImage(outBitmap))
            {
                graphics.DrawImage(bitmap, topLeftDest, topLeftSrc, GraphicsUnit.Pixel);
                graphics.DrawImage(bitmap, topCenterDest, topCenterSrc, GraphicsUnit.Pixel);
                graphics.DrawImage(bitmap, topRightDest, topRightSrc, GraphicsUnit.Pixel);

                graphics.DrawImage(bitmap, bottomLeftDest, bottomLeftSrc, GraphicsUnit.Pixel);
                graphics.DrawImage(bitmap, bottomCenterDest, bottomCenterSrc, GraphicsUnit.Pixel);
                graphics.DrawImage(bitmap, bottomRightDest, bottomRightSrc, GraphicsUnit.Pixel);

                graphics.DrawImage(bitmap, centerLeftDest, centerLeftSrc, GraphicsUnit.Pixel);
                graphics.DrawImage(bitmap, centerCenterDest, centerCenterSrc, GraphicsUnit.Pixel);
                graphics.DrawImage(bitmap, centerRightDest, centerRightSrc, GraphicsUnit.Pixel);
            }

            return outBitmap;
        }
    }
}
