using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_1
public class DataItem : ViewModelBase
    {
        private string title;
        private List<DataItem> children;

        public String Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (this.title != value)
                {
                    this.title = value;
                    this.OnPropertyChanged("Title");
                }
            }
        }

        public List<DataItem> Children
        {
            get
            {
                return this.children;
            }
        }
    }
#endregion

#region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_3
this.treeView.ItemsSource = Enumerable.Range(1, 10).Select(i => new DataItem()
{
    Title = string.Format("Item {0}", i)
}).ToList();
#endregion

#region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_4
private void radTreeView_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    var timer = new DispatcherTimer()
    {
        Interval = TimeSpan.FromSeconds( 1 )
    };
    timer.Start();
    var item = ( e.OriginalSource as FrameworkElement ).DataContext as MyViewModel;
    timer.Tick += ( t, args ) =>
    {
        foreach ( var child in Enumerable.Range( 1, 5 ).Select( i => new MyViewModel()
        {
            Title = item.Title + "." + i
        } ) )
        {
            item.Children.Add( child );
        }
        timer.Stop();
    };
}
#endregion

#region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_5
public class MyViewModel : INotifyPropertyChanged
{
    private static int idCounter;
    private string title;

    public MyViewModel()
    {
        this.Children = new ObservableCollection<MyViewModel>();
        this.Id = idCounter++;
    }

    public int Id
    {
        get;
        protected set;
    }
....
}
#endregion

#region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_8
private List<int> pendingSelectionPath;
private void Button_Click( object sender, RoutedEventArgs e )
{
    pendingSelectionPath = new List<int>();
    pendingSelectionPath.Add( 1 );
    pendingSelectionPath.Add( 12 );
    pendingSelectionPath.Add( 18 );
    pendingSelectionPath.Add( 22 );
    this.ExpandToPendingSelection();
}

private void ExpandToPendingSelection()
{
}
#endregion

#region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_10
private void ExpandToPendingSelection()
{
    // Grabs the treeview control.
    var itemsControl = radTreeView as ItemsControl;
    var itemFound = true;

    while ( itemsControl != null && itemFound )
    {
        itemFound = false;
        // Gets the next Id. If the current treeview item has the same id
        // then this is the target item that should be expanded.
        var id = pendingSelectionPath.First();
        for ( int i = 0; i < itemsControl.Items.Count; i++ )
        {
            var viewModel = itemsControl.Items[ i ] as MyViewModel;
            if ( viewModel.Id == id )
            {
                itemFound = true;
                pendingSelectionPath.RemoveAt( 0 );
                BringIndexIntoView( itemsControl, i );
                itemsControl.UpdateLayout();
                var container = itemsControl.ItemContainerGenerator.ContainerFromIndex( i ) as Telerik.Windows.Controls.RadTreeViewItem;

                container.IsExpanded = true;

                container.UpdateLayout();
                itemsControl = container as ItemsControl;
            }
        }
    }
}
#endregion

#region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_12
private void BringIndexIntoView( ItemsControl itemsControl, int index )
{
    var treeView = itemsControl as Telerik.Windows.Controls.RadTreeView;
    if ( treeView != null )
    {
        treeView.BringIndexIntoView( index );
    }
    var treeViewItem = itemsControl as Telerik.Windows.Controls.RadTreeViewItem;
    if ( treeViewItem != null )
    {
        treeViewItem.BringIndexIntoView( index );
    }
}
#endregion

#region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_14
radTreeView.ItemPrepared += new EventHandler<Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs>( radTreeView_ItemPrepared );
....
private void radTreeView_ItemPrepared( object sender, Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs e )
{
    if ( pendingSelectionPath == null || !pendingSelectionPath.Any() )
        return;
    var myViewModel = e.PreparedItem.Item as MyViewModel;
    if ( pendingSelectionPath.Contains( myViewModel.Id ) )
    {
        e.PreparedItem.IsExpanded = true;
        // If we have retrieved the item we need, select it.
        if ( pendingSelectionPath.Count == 1 )
            treeView.SelectedItem = myViewModel;
        pendingSelectionPath.Remove( myViewModel.Id );
    }
}
#endregion

#region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_16
public List<DataItem> Children
{
    get
    {
        if (this.children == null)
        {
            this.children = new List<DataItem>();
            for (int i = 0; i < 5; i++)
            {
                DataItem item = new DataItem() { Title = string.Format("{0}.{1}", this.Title, i) };
                this.children.Add(item);
            }
        }
        return this.children;
    }
}
#endregion

#region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_18
private void Button_Click_1(object sender, RoutedEventArgs e)
{
    string[] headerAndIndexes = this.userInput.Text.Split(' ');
    string[] indexes = headerAndIndexes.LastOrDefault().Split('.');
    bool areIndexesValid = false;
    int i;

    if (headerAndIndexes != null && indexes != null)
    {
        foreach (string index in indexes)
        {
            areIndexesValid = int.TryParse(index, out i);
        }

        if (headerAndIndexes.FirstOrDefault().Contains("Item") && areIndexesValid)
        {
            RadTreeViewItem item = this.treeView.GetItemByPath(this.GenetatePath(this.userInput.Text));
            if (item != null)
            {
                item.IsSelected = true;
                item.IsExpanded = true;
            }
        }
    }
}
  
private string GenetatePath(string itemToExpand)
{
    string path = string.Empty;
    string buffer;
    string[] header = itemToExpand.Split(' ');
    string[] indexes = header.LastOrDefault().Split('.');

    header[0] = string.Format("{0} {1}", header[0], indexes[0]);
    path = string.Format("{0}\\", header[0]);

    for (int i = 1; i < indexes.Length; i++)
    {
        buffer = string.Format("{0}.{1}", header[0], indexes[i]);
        header[0] = buffer;
        path += string.Format("{0}\\", buffer);
    }
    return path.TrimEnd('\\');
}
#endregion
}