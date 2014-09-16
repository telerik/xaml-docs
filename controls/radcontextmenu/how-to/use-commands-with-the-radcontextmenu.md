---
title: Use Commands with the RadContextMenu
page_title: Use Commands with the RadContextMenu
description: Use Commands with the RadContextMenu
slug: radcontextmenu-how-to-use-commands-with-the-radcontextmenu
tags: use,commands,with,the,radcontextmenu
publish: True
position: 3
---

# Use Commands with the RadContextMenu



As the __RadMenuItem__ implements the __ICommandSource__ interface, you are able to use any kind of commands that inherit from the __ICommand__ interface with it. This tutorial will show you how to use the __RadContextMenu__ with __RoutedUICommands__ combined with the __MVVM__ pattern. Two commands are going to be exposed - one for moving an item in a ListBox up and one for moving an item down. The following things will come in focus:
      

* [Attaching a RadContextMenu to a ListBox control](#Attaching_a_RadContextMenu_to_a_ListBox_control)

* [Populating the ListBox with data via a ViewModel](#Populating_the_ListBox_with_data_via_a_ViewModel)

* [Selecting the right-clicked ListBoxItem](#Selecting_the_right-clicked_ListBoxItem)

* [Preparing the RoutedUICommands](#Preparing_the_RoutedUICommands)

* [Creating the CommandBindings](#Creating_the_CommandBindings)

* [Setting the CommandBindings](#Setting_the_CommandBindings)

## Attaching a RadContextMenu to a ListBox control

Before getting to the commands, you have to prepare the UI on which they will get executed. In this tutorial a __ListBox__ and a __RadContextMenu__ are used.
        

#### __XAML__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_0}}
	<ListBox x:Name="listBox">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu">
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</ListBox>
	{{endregion}}



Having the UI prepared, you have to add some data to it.

## Populating the ListBox with data via a ViewModel

As the __MVVM__ pattern should be used, you have to create a __ViewModel__ for your __UserControl__, which will control its behavior. In it you will store the data which the __View__ is using. Here is the declaration of the ViewModel class. It has a constructor, a method that initializes the items for the __ListBox__ and an __Items__ property, that stores them. Additionally create a __SelectedItem__ property that will hold the selected item of the __ListBox__.
        

#### __C#__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_1}}
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
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_2}}
	Public Class ExampleViewModel
	 Implements INotifyPropertyChanged
	 Private selectedItem As DataItem
	 Public Sub New()
	  Me.InitItems()
	 End Sub
	 Public Event PropertyChanged As PropertyChangedEventHandler
	 Public Property Items() As ObservableCollection(Of DataItem)
	  Get
	  End Get
	  Set
	  End Set
	 End Property
	 Public Property SelectedItem() As DataItem
	  Get
	   Return Me.selectedItem
	  End Get
	  Set
	   If Me.selectedItem <> value Then
	    Me.selectedItem = value
	    Me.OnNotifyPropertyChanged("SelectedItem")
	   End If
	  End Set
	 End Property
	 Private Sub OnNotifyPropertyChanged(propertyName As String)
	  If Me.PropertyChanged <> Nothing Then
	   Me.PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
	  End If
	 End Sub
	 Private Sub InitItems()
	  Dim items As New ObservableCollection(Of DataItem)()
	  items.Add(New DataItem("Item 1"))
	  items.Add(New DataItem("Item 2"))
	  items.Add(New DataItem("Item 3"))
	  Me.Items = items
	 End Sub
	End Class
	{{endregion}}



In the constructor of the __UserControl__ you have to create an instance of the __ViewModel__, store it in a field and pass it as a __DataContext__ of the entire __UserControl__.
        

#### __C#__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_3}}
	private ExampleViewModel viewModel;
	public CommandsSample()
	{
	    InitializeComponent();
	    this.viewModel = new ExampleViewModel();
	    this.DataContext = viewModel;
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_4}}
	Private viewModel As ExampleViewModel
	Public Sub New()
	 InitializeComponent()
	 Me.viewModel = New ExampleViewModel()
	 Me.DataContext = viewModel
	End Sub
	{{endregion}}



In the XAML you have to set the __SelectedItem__, the __DisplayMemberPath__ and the __ItemsSource__ properties of the __ListBox__ in order to visualize the data.
        

#### __XAML__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_5}}
	<ListBox x:Name="listBox"
	         DisplayMemberPath="Value"
	         ItemsSource="{Binding Items}"
	         SelectedItem="{Binding SelectedItem, Mode=TwoWay}">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu">
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</ListBox>
	{{endregion}}



## Selecting the right-clicked ListBoxItem

Before continuing, there is one more thing to be done. When right-clicking to open the __RadContextMenu__, the clicked item should get selected, or if no item was clicked, the selection should be removed. This is done by handling the __Opened__ event of the __RadContextMenu__.
        

#### __XAML__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_6}}
	<ListBox x:Name="listBox"
	         DisplayMemberPath="Value"
	         ItemsSource="{Binding Items}"
	         SelectedItem="{Binding SelectedItem, Mode=TwoWay}">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu"
	                                          Opened="RadContextMenu_Opened">
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</ListBox>
	{{endregion}}



#### __C#__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_7}}
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
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_8}}
	Private Sub RadContextMenu_Opened(sender As Object, e As RoutedEventArgs)
	 Dim item As System.Windows.Controls.ListBoxItem = Me.radContextMenu.GetClickedElement(Of System.Windows.Controls.ListBoxItem)()
	 If item <> Nothing Then
	  Me.listBox.SelectedItem = item.DataContext
	 Else
	  Me.listBox.SelectedItem = Nothing
	 End If
	End Sub
	{{endregion}}



## Preparing the RoutedUICommands

The next step is to create your commands. They will be host by the __ViewModel__.
        

#### __C#__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_9}}
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
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_10}}
	Public Property MoveUpCommand() As RoutedUICommand
	 Get
	 End Get
	 Private Set
	 End Set
	End Property
	Public Property MoveDownCommand() As RoutedUICommand
	 Get
	 End Get
	 Private Set
	 End Set
	End Property
	{{endregion}}



Initialize them in the constructor of the __ViewModel__:
        

#### __C#__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_11}}
	public ExampleViewModel()
	{
	    this.MoveUpCommand = new RoutedUICommand( "Move Up", "MoveUp", typeof( ExampleViewModel ) );
	    this.MoveDownCommand = new RoutedUICommand( "Move Down", "MoveDown", typeof( ExampleViewModel ) );
	    this.InitItems();
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_12}}
	Public Sub New()
	 Me.MoveUpCommand = New RoutedUICommand("Move Up", "MoveUp", GetType(ExampleViewModel))
	 Me.MoveDownCommand = New RoutedUICommand("Move Down", "MoveDown", GetType(ExampleViewModel))
	 Me.InitItems()
	End Sub
	{{endregion}}



Bind them in the __View__.
        

#### __XAML__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_13}}
	<ListBox x:Name="listBox"
	         DisplayMemberPath="Value"
	         ItemsSource="{Binding Items}"
	         SelectedItem="{Binding SelectedItem, Mode=TwoWay}">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu"
	                                          Opened="RadContextMenu_Opened">
	            <telerik:RadMenuItem Header="{Binding MoveUpCommand.Text}"
	                                           Command="{Binding MoveUpCommand}" />
	            <telerik:RadMenuItem Header="{Binding MoveDownCommand.Text}"
	                                           Command="{Binding MoveDownCommand}" />
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</ListBox>
	{{endregion}}



You will also need methods that will get called when the command is executed. In the next section is explained how to connect the methods to the command. Here are sample methods for the two commands.

#### __C#__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_14}}
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
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_15}}
	Public Sub MoveUp(sender As Object, e As ExecutedRoutedEventArgs)
	 If Me.SelectedItem = Nothing OrElse Me.Items.IndexOf(TryCast(Me.SelectedItem, DataItem)) = 0 Then
	  Return
	 End If
	 Dim item As DataItem = Me.SelectedItem
	 Dim index As Integer = Me.Items.IndexOf(TryCast(item, DataItem))
	 Me.Items.Remove(TryCast(item, DataItem))
	 Me.Items.Insert(index - 1, TryCast(item, DataItem))
	 Me.SelectedItem = item
	End Sub
	Public Sub MoveDown(sender As Object, e As ExecutedRoutedEventArgs)
	 If Me.SelectedItem = Nothing OrElse Me.Items.IndexOf(TryCast(Me.SelectedItem, DataItem)) = Me.Items.Count - 1 Then
	  Return
	 End If
	 Dim item As DataItem = Me.SelectedItem
	 Dim index As Integer = Me.Items.IndexOf(TryCast(item, DataItem))
	 Me.Items.Remove(TryCast(item, DataItem))
	 Me.Items.Insert(index + 1, TryCast(item, DataItem))
	 Me.SelectedItem = item
	End Sub
	{{endregion}}



## Creating the CommandBindings

In order to use the commands in the UI you have to provide a __CommandBinding__ for each of the commands. The __CommandBinding__ binds the command to a method that is called when the command gets executed. The __CommandBidnings__ get set via the __CommandManager__. As the __CommandManager__ is called by the __View__ you have to expose a method in your __ViewModel__ that returns a collection of its __CommandBindings__.
        

#### __C#__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_16}}
	public CommandBindingCollection GetCommandBindings()
	{
	    CommandBindingCollection bindings = new CommandBindingCollection();
	    bindings.Add( new CommandBinding( this.MoveUpCommand, this.MoveUp ) );
	    bindings.Add( new CommandBinding( this.MoveDownCommand, this.MoveDown ) );
	    return bindings;
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_17}}
	Public Function GetCommandBindings() As CommandBindingCollection
	 Dim bindings As New CommandBindingCollection()
	 bindings.Add(New CommandBinding(Me.MoveUpCommand, Me.MoveUp))
	 bindings.Add(New CommandBinding(Me.MoveDownCommand, Me.MoveDown))
	 Return bindings
	End Function
	{{endregion}}



## Setting the CommandBindings

In the __View__ get the __CommandBindingsCollection__ and set it through the __CommandManager__.
        {% if site.site_name == 'Silverlight' %}

#### __C#__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_18}}
	public CommandsSample()
	{
	    InitializeComponent();
	    this.viewModel = new ExampleViewModel();
	    this.DataContext = viewModel;
	    CommandManager.SetCommandBindings( this, this.viewModel.GetCommandBindings() );
	}
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_19}}
	Public Sub New()
	 InitializeComponent()
	 Me.viewModel = New ExampleViewModel()
	 Me.DataContext = viewModel
	 CommandManager.SetCommandBindings(Me, Me.viewModel.GetCommandBindings())
	End Sub
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __C#__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_20}}
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
	{{endregion}}



#### __VB.NET__

{{region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_21}}
	Public Sub New()
		InitializeComponent()
		Me.viewModel = New ExampleViewModel()
		Me.DataContext = viewModel
	
		Dim collection As CommandBindingCollection = Me.viewModel.GetCommandBindings()
		For Each commandBinding As CommandBinding In collection
			CommandManager.RegisterClassCommandBinding(GetType(ListBoxItem), commandBinding)
		Next commandBinding
	End Sub
	{{endregion}}

{% endif %}

# See Also

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Binding to Dynamic Data]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%})

 * [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%})

 * [Select  the clicked Item of a RadTreeView]({%slug radcontextmenu-how-to-select-the-clicked-item-of-radtreeview%})

 * [Create Menu Button with RadContextMenu and ToggleButton]({%slug radcontextmenu-how-to-create-menu-button-with-radcontextmenu-and-togglebutton%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
