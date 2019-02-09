using System.Windows;
using System.Windows.Controls;
using OcarinaTracker.Core;

namespace OcarinaTracker.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Add item panels
            var usableItemsPanel = new EditorGroupPanel
            {
                Width = 174,
                Height = 174,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(10, 10, 0, 0)
            };

            foreach (var collectable in Collectables.UsableCollectables)
            {
                usableItemsPanel.Children.Add(new CollectableEditor(collectable));
            }

            MainGrid.Children.Add(usableItemsPanel);

            var usableItemsPanel2 = new EditorGroupPanel
            {
                Width = 174,
                Height = 174,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(10, 189, 0, 0),
            };

            foreach (var collectable in Collectables.UsableCollectables2)
            {
                usableItemsPanel2.Children.Add(new CollectableEditor(collectable));
            }

            MainGrid.Children.Add(usableItemsPanel2);

            var sideItemsPanel = new EditorGroupPanel
            {
                Width = 174,
                Height = 174,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(10, 368, 0, 0),
            };

            foreach (var collectable in Collectables.SideCollectables)
            {
                sideItemsPanel.Children.Add(new CollectableEditor(collectable));
            }

            MainGrid.Children.Add(sideItemsPanel);

            var equippedItemsPanel = new EditorGroupPanel
            {
                Width = 174,
                Height = 290,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(189, 10, 0, 0),
            };

            foreach (var collectable in Collectables.EquippableCollectables)
            {
                equippedItemsPanel.Children.Add(new CollectableEditor(collectable));
            }

            MainGrid.Children.Add(equippedItemsPanel);

            var songsStonesMedallionsPanel = new EditorGroupPanel
            {
                Width = 174,
                Height = 406,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Margin = new Thickness(368, 10, 0, 0),
            };

            foreach (var collectable in Collectables.SongStoneMedallionList)
            {
                songsStonesMedallionsPanel.Children.Add(new CollectableEditor(collectable));
            }

            MainGrid.Children.Add(songsStonesMedallionsPanel);

            // Add dungeon editors

            var dungeonsPanel = new DungeonGroupEditorPanel
            {
                Width = 174,
                Height = 237,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Orientation = Orientation.Vertical,
                Margin = new Thickness(189, 305, 0, 0),
            };

            for (var i = 0; i < Dungeons.DungeonList.Length; i++)
            {
                var marginTop = 3;

                if (i == 0)
                {
                    marginTop = 5;
                }
                else if (i % 2 == 0)
                {
                    marginTop = 8;
                }

                var dungeonEditor = new DungeonEditor(Dungeons.DungeonList[i])
                {
                    Margin = new Thickness(5, marginTop, 0, 0)
                };

                dungeonsPanel.Children.Add(dungeonEditor);
            }

            MainGrid.Children.Add(dungeonsPanel);

            var miniDungeonsPanel = new DungeonGroupEditorPanel
            {
                Width = 174,
                Height = 121,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Orientation = Orientation.Vertical,
                Margin = new Thickness(368, 421, 0, 0),
            };

            for (var i = 0; i < Dungeons.MiniDungeons.Length; i++)
            {
                var marginTop = 3;

                if (i == 0)
                {
                    marginTop = 5;
                }
                else if (i % 2 == 0)
                {
                    marginTop = 8;
                }

                var dungeonEditor = new DungeonEditor(Dungeons.MiniDungeons[i])
                {
                    Margin = new Thickness(5, marginTop, 0, 0)
                };

                miniDungeonsPanel.Children.Add(dungeonEditor);
            }

            MainGrid.Children.Add(miniDungeonsPanel);
        }
    }
}
