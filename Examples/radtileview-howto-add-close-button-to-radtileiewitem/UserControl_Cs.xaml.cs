using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
    #region radtileview-howto-add-close-button-to-radtileiewitem_0
    public class DataItem
    {
        public string Header { get; set; }
        public string Content { get; set; }
    }
    #endregion

    #region radtileview-howto-add-close-button-to-radtileiewitem_1
    public class MainViewModel
    {
        public ObservableCollection<DataItem> Items { get; set; }

        public MainViewModel()
        {
            this.Items = new ObservableCollection<DataItem>();

            for (int i = 0; i < 2; i++)
            {
                var dataItem = new DataItem()
                {
                    Header = "Item " + i,
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                };

                this.Items.Add(dataItem);
            }
        }
    }
    #endregion

    #region radtileview-howto-add-close-button-to-radtileiewitem_2
    public static class TileViewCommandsExtension
    {
        static TileViewCommandsExtension()
        {
            TileViewCommandsExtension.Delete = new RoutedUICommand("Deletes a tile view item", "Delete", typeof(TileViewCommandsExtension));
        }

        public static RoutedUICommand Delete { get; private set; }
    }
    #endregion

    #region radtileview-howto-add-close-button-to-radtileiewitem_3
    public partial class Example : UserControl
    {
        static Example()
        {
            var deleteBinding = new CommandBinding(TileViewCommandsExtension.Delete, OnDeleteCommandExecute, OnCanDeleteCommandExecute);
            CommandManager.RegisterClassCommandBinding(typeof(RadTileViewItem), deleteBinding);
        }

        private static void OnCanDeleteCommandExecute(object sender, CanExecuteRoutedEventArgs e)
        {            
        }

        private static void OnDeleteCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
        }

        public Example()
        {
            InitializeComponent();
        }
    }
    #endregion

    #region radtileview-howto-add-close-button-to-radtileiewitem_4
    public partial class Example : UserControl
    {
        static Example()
        {
            var deleteBinding = new CommandBinding(TileViewCommandsExtension.Delete, OnDeleteCommandExecute, OnCanDeleteCommandExecute);
            CommandManager.RegisterClassCommandBinding(typeof(RadTileViewItem), deleteBinding);
        }

        private static void OnCanDeleteCommandExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private static void OnDeleteCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            var tileViewItem = sender as RadTileViewItem;
            var tileView = tileViewItem.ParentTileView as RadTileView;
            if (tileViewItem == null || tileView == null) return;

            if (tileView.ItemsSource != null)
            {
                var dataItem = tileView.ItemContainerGenerator.ItemFromContainer(tileViewItem) as DataItem;

                // Note: This will change the DataContext's Items collection.
                var source = tileView.ItemsSource as IList;
                if (dataItem != null && source != null)
                    source.Remove(dataItem);
            }
            else
            {
                tileView.Items.Remove(tileViewItem);
            }
        }

        public Example()
        {
            InitializeComponent();
        }
    }
    #endregion
}
