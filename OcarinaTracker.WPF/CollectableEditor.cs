using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using OcarinaTracker.Core;

namespace OcarinaTracker.WPF
{
    public sealed class CollectableEditor : Image
    {
        private bool _disabled;

        public bool Disabled
        {
            get => _disabled;
            set
            {
                _disabled = value;
                Source = _disabled ? null : Collectable.Image;
                _toolTip.IsEnabled = !_disabled;
            }
        }

        private Collectable _collectable;
        private readonly ToolTip _toolTip;

        public Collectable Collectable
        {
            get => _collectable;
            set
            {
                _collectable = value;
                Source = Disabled ? null : _collectable.Image;
                _toolTip.Content = _collectable.GetCurrentStageName();
                SetSize();
            }
        }

        public Size? OverrideSize;

        public CollectableEditor()
        {
            _toolTip = new ToolTip();
            ToolTip = _toolTip;
            MouseDown += (_, e) => OnClick(e);
        }

        public CollectableEditor(Collectable collectable) : this()
        {
            Collectable = collectable;
            if (!Disabled)
            {
                Source = collectable.Image;
            }

            _toolTip.Content = collectable.GetCurrentStageName();
            SetSize();
        }

        private void SetSize()
        {
            Width = OverrideSize?.Width ?? Collectable.Image.Width;
            Height = OverrideSize?.Height ?? Collectable.Image.Height;
        }

        private void OnClick(MouseEventArgs e)
        {
            if (Collectable == null || Disabled) return;

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Collectable++;
            }
            else if (e.RightButton == MouseButtonState.Pressed)
            {
                Collectable--;
            }

            _toolTip.Content = Collectable.GetCurrentStageName();
            Source = Collectable.Image;
            SetSize();
        }
    }
}
