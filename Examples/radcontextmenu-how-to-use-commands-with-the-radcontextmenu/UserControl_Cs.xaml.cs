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

#region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_1
public class ExampleViewModel : INotifyPropertyChanged
{
    private DataItem selectedItem;
    public ExampleViewModel()
    {
        this.InitItems();
    }
    public event PropertyChangedEventHandler PropertyChanged;
    public ObservableCollection<DataItem> Items
    {
        get;
        set;
    }
    public DataItem SelectedItem
    {
        get
        {
            return this.selectedItem;
        }
        set
        {
            if ( this.selectedItem != value )
            {
                this.selectedItem = value;
                this.OnNotifyPropertyChanged( "SelectedItem" );
            }
        }
    }
    private void OnNotifyPropertyChanged( string propertyName )
    {
        if ( this.PropertyChanged != null )
        {
            this.PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
    private void InitItems()
    {
        ObservableCollection<DataItem> items = new ObservableCollection<DataItem>();
        items.Add( new DataItem( "Item 1" ) );
        items.Add( new DataItem( "Item 2" ) );
        items.Add( new DataItem( "Item 3" ) );
        this.Items = items;
    }
}
#endregion

#region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_3
private ExampleViewModel viewModel;
public CommandsSample()
{
    InitializeComponent();
    this.viewModel = new ExampleViewModel();
    this.DataContext = viewModel;
}
#endregion

#region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_7
private void RadContextMenu_Opened( object sender, RoutedEventArgs e )
{
    System.Windows.Controls.ListBoxItem item = this.radContextMenu.GetClickedElement<System.Windows.Controls.ListBoxItem>();
    if ( item != null )
    {
        this.listBox.SelectedItem = item.DataContext;
    }
    else
    {
        this.listBox.SelectedItem = null;
    }
}
#endregion

#region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_9
public RoutedUICommand MoveUpCommand
{
    get;
    private set;
}
public RoutedUICommand MoveDownCommand
{
    get;
    private set;
}
#endregion

#region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_11
public ExampleViewModel()
{
    this.MoveUpCommand = new RoutedUICommand( "Move Up", "MoveUp", typeof( ExampleViewModel ) );
    this.MoveDownCommand = new RoutedUICommand( "Move Down", "MoveDown", typeof( ExampleViewModel ) );
    this.InitItems();
}
#endregion

#region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_14
public void MoveUp( object sender, ExecutedRoutedEventArgs e )
{
    if ( this.SelectedItem == null || this.Items.IndexOf( this.SelectedItem as DataItem ) == 0 )
    {
        return;
    }
    DataItem item = this.SelectedItem;
    int index = this.Items.IndexOf( item as DataItem );
    this.Items.Remove( item as DataItem );
    this.Items.Insert( index - 1, item as DataItem );
    this.SelectedItem = item;
}
public void MoveDown( object sender, ExecutedRoutedEventArgs e )
{
    if ( this.SelectedItem == null || this.Items.IndexOf( this.SelectedItem as DataItem ) == this.Items.Count - 1 )
    {
        return;
    }
    DataItem item = this.SelectedItem;
    int index = this.Items.IndexOf( item as DataItem );
    this.Items.Remove( item as DataItem );
    this.Items.Insert( index + 1, item as DataItem );
    this.SelectedItem = item;
}
#endregion

#region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_16
public CommandBindingCollection GetCommandBindings()
{
    CommandBindingCollection bindings = new CommandBindingCollection();
    bindings.Add( new CommandBinding( this.MoveUpCommand, this.MoveUp ) );
    bindings.Add( new CommandBinding( this.MoveDownCommand, this.MoveDown ) );
    return bindings;
}
#endregion

#region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_18
public CommandsSample()
{
    InitializeComponent();
    this.viewModel = new ExampleViewModel();
    this.DataContext = viewModel;
    CommandManager.SetCommandBindings( this, this.viewModel.GetCommandBindings() );
}
#endregion

#region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_20
public CommandsSample()
{
    InitializeComponent();
    this.viewModel = new ExampleViewModel();
    this.DataContext = viewModel;

    CommandBindingCollection collection = this.viewModel.GetCommandBindings();
    foreach (CommandBinding commandBinding in collection)
    {
        CommandManager.RegisterClassCommandBinding(typeof(ListBoxItem), commandBinding);
    }
}
#endregion
