using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using OcarinaTracker.Core;

namespace OcarinaTracker.WPF
{
    public sealed class DungeonEditor : StackPanel
    {
        private static readonly ImageBrush BackgroundBrush =
            new ImageBrush(Properties.Resources.DungeonBackground.GetBitmapSource());

        // Dungeon Editor Controls
        private Label _dungeonNameLabel;
        private CollectableEditor _smallKeyEditor;
        private CollectableEditor _mapEditor;
        private CollectableEditor _compassEditor;
        private CollectableEditor _bigKeyEditor;
        private CollectableEditor _stoneMedallionEditor;

        private Dungeon _dungeon;

        public Dungeon Dungeon
        {
            get => _dungeon;
            set
            {
                _dungeon = value;
                _dungeonNameLabel.Content = _dungeon.Name.ToUpper();
                _smallKeyEditor.Collectable = _dungeon.Keys;
                _mapEditor.Collectable = _dungeon.Map;
                _compassEditor.Collectable = _dungeon.Compass;
                _bigKeyEditor.Collectable = _dungeon.BigKey;
                _stoneMedallionEditor.Collectable = _dungeon.SpiritStonesMedallion;

                _smallKeyEditor.Disabled = !_dungeon.HasKeys;
                _mapEditor.Disabled = !_dungeon.HasMap;
                _compassEditor.Disabled = !_dungeon.HasCompass;
                _bigKeyEditor.Disabled = !_dungeon.HasBigKey;
                _stoneMedallionEditor.Disabled = !_dungeon.HasStoneOrMedallion;
            }
        }

        public DungeonEditor()
        {
            Orientation = Orientation.Horizontal;
            Width = 164;
            Height = 24;
            Background = BackgroundBrush;

            InitializeEditorControls();
        }

        public DungeonEditor(Dungeon dungeon) : this()
        {
            Dungeon = dungeon;
        }

        private void InitializeEditorControls()
        {
            _dungeonNameLabel = new Label
            {
                Content = "NO NAME",
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                Foreground = Brushes.Gray,
                Width = 44,
                Height = 24,
                FontSize = 8
            };

            var overrideSize = new Size(24, 24);

            _smallKeyEditor = new CollectableEditor
            {
                Stretch = Stretch.UniformToFill,
                OverrideSize = overrideSize
            };

            _mapEditor = new CollectableEditor
            {
                Stretch = Stretch.UniformToFill,
                OverrideSize = overrideSize
            };

            _compassEditor = new CollectableEditor
            {
                Stretch = Stretch.UniformToFill,
                OverrideSize = overrideSize
            };

            _bigKeyEditor = new CollectableEditor
            {
                Stretch = Stretch.UniformToFill,
                OverrideSize = overrideSize
            };

            _stoneMedallionEditor = new CollectableEditor
            {
                Stretch = Stretch.UniformToFill,
                OverrideSize = overrideSize
            };

            Children.Add(_dungeonNameLabel);
            Children.Add(_smallKeyEditor);
            Children.Add(_mapEditor);
            Children.Add(_compassEditor);
            Children.Add(_bigKeyEditor);
            Children.Add(_stoneMedallionEditor);
        }
    }
}
