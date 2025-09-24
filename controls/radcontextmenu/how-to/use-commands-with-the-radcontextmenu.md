---
title: Use Commands with the RadContextMenu
page_title: Use Commands with the RadContextMenu
description: Check our &quot;Use Commands with the RadContextMenu&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-how-to-use-commands-with-the-radcontextmenu
tags: use,commands,with,the,radcontextmenu
published: True
position: 3
---

# Use Commands with the RadContextMenu


As the __RadMenuItem__ implements the __ICommandSource__ interface, you are able to use any kind of commands that inherit from the __ICommand__ interface with it. This tutorial will show you how to use the __RadContextMenu__ with __RoutedUICommands__ combined with the __MVVM__ pattern. Two commands are going to be exposed - one for moving an item in a ListBox up and one for moving an item down. The following things will come in focus:      

* [Attaching a RadContextMenu to a ListBox control](#attaching-a-radcontextmenu-to-a-listbox-control)

* [Populating the ListBox with data via a ViewModel](#populating-the-listbox-with-data-via-a-viewmodel)

* [Selecting the right-clicked ListBoxItem](#selecting-the-right-clicked-listboxitem)

* [Preparing the RoutedUICommands](#preparing-the-routeduicommands)

* [Creating the CommandBindings](#creating-the-commandbindings)

* [Setting the CommandBindings](#setting-the-commandbindings)

## Attaching a RadContextMenu to a ListBox control

Before getting to the commands, you have to prepare the UI on which they will get executed. In this tutorial a __ListBox__ and a __RadContextMenu__ are used.
        



```XAML
	<ListBox x:Name="listBox">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu">
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</ListBox>
```

Having the UI prepared, you have to add some data to it.

## Populating the ListBox with data via a ViewModel

As the __MVVM__ pattern should be used, you have to create a __ViewModel__ for your __UserControl__, which will control its behavior. In it you will store the data which the __View__ is using. Here is the declaration of the ViewModel class. It has a constructor, a method that initializes the items for the __ListBox__ and an __Items__ property, that stores them. Additionally create a __SelectedItem__ property that will hold the selected item of the __ListBox__.        



```C#
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
	            if (this.selectedItem != value)
	            {
	                this.selectedItem = value;
	                this.OnNotifyPropertyChanged("SelectedItem");
	            }
	        }
	    }
	    private void OnNotifyPropertyChanged(string propertyName)
	    {
	        if (this.PropertyChanged != null)
	        {
	            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
	        }
	    }
	    private void InitItems()
	    {
	        ObservableCollection<DataItem> items = new ObservableCollection<DataItem>();
	        items.Add(new DataItem("Item 1"));
	        items.Add(new DataItem("Item 2"));
	        items.Add(new DataItem("Item 3"));
	        this.Items = items;
	    }
	}
```
```VB.NET
	Public Class ExampleViewModel
	    Implements INotifyPropertyChanged
	    Private selectedItemField As DataItem
	    Public Sub New()
	        Me.InitItems()
	    End Sub
	    Public Property Items() As ObservableCollection(Of DataItem)
	        Get
	        End Get
	        Set(value As ObservableCollection(Of DataItem))
	        End Set
	    End Property
	    Public Property SelectedItem() As DataItem
	        Get
	            Return Me.selectedItemField
	        End Get
	        Set(value As DataItem)
	            If Me.selectedItemField Is value Then
	                Me.selectedItemField = value
	                Me.NotifyPropertyChanged("SelectedItem")
	            End If
	        End Set
	    End Property
	
	    Private Sub InitItems()
	        Dim items As New ObservableCollection(Of DataItem)()
	        items.Add(New DataItem("Item 1"))
	        items.Add(New DataItem("Item 2"))
	        items.Add(New DataItem("Item 3"))
	        Me.Items = items
	    End Sub
	
	    Public Event PropertyChanged As PropertyChangedEventHandler _
	        Implements INotifyPropertyChanged.PropertyChanged
	
	    Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
	        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
	    End Sub
	End Class
```

In the constructor of the __UserControl__ you have to create an instance of the __ViewModel__, store it in a field and pass it as a __DataContext__ of the entire __UserControl__.        



```C#
	private ExampleViewModel viewModel;
	public Default_Cs()
	{
	    InitializeComponent();
	    this.viewModel = new ExampleViewModel();
	    this.DataContext = viewModel;
	}
```
```VB.NET
	Private viewModel As ExampleViewModel
	Public Sub New()
	    InitializeComponent()
	    Me.viewModel = New ExampleViewModel()
	    Me.DataContext = viewModel
	End Sub
```

In the XAML you have to set the __SelectedItem__, the __DisplayMemberPath__ and the __ItemsSource__ properties of the __ListBox__ in order to visualize the data.        



```XAML
	<ListBox x:Name="listBox1"
	         DisplayMemberPath="Value"
	         ItemsSource="{Binding Items}"
	         SelectedItem="{Binding SelectedItem, Mode=TwoWay}">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu1">
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</ListBox>
```

## Selecting the right-clicked ListBoxItem

Before continuing, there is one more thing to be done. When right-clicking to open the __RadContextMenu__, the clicked item should get selected, or if no item was clicked, the selection should be removed. This is done by handling the __Opened__ event of the __RadContextMenu__.        



```XAML
	<ListBox x:Name="listBox2"
	         DisplayMemberPath="Value"
	         ItemsSource="{Binding Items}"
	         SelectedItem="{Binding SelectedItem, Mode=TwoWay}">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu2"
	                                  Opened="RadContextMenu_Opened">
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</ListBox>
```




```C#
	private void RadContextMenu_Opened(object sender, RoutedEventArgs e)
	{
	    System.Windows.Controls.ListBoxItem item = this.radContextMenu.GetClickedElement<System.Windows.Controls.ListBoxItem>();
	    if (item != null)
	    {
	        this.listBox.SelectedItem = item.DataContext;
	    }
	    else
	    {
	        this.listBox.SelectedItem = null;
	    }
	}
```
```VB.NET
	Private Sub RadContextMenu_Opened(sender As Object, e As RoutedEventArgs)
	    Dim item As System.Windows.Controls.ListBoxItem = Me.radContextMenu.GetClickedElement(Of System.Windows.Controls.ListBoxItem)()
	    If item Is Nothing Then
	        Me.listBox.SelectedItem = item.DataContext
	    Else
	        Me.listBox.SelectedItem = Nothing
	    End If
	End Sub
```

## Preparing the RoutedUICommands

The next step is to create your commands. They will be host by the __ViewModel__.        



```C#
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
```
```VB.NET
	Public Property MoveUpCommand() As RoutedUICommand
	    Get
	    End Get
	    Private Set(value As RoutedUICommand)
	    End Set
	End Property
	Public Property MoveDownCommand() As RoutedUICommand
	    Get
	    End Get
	    Private Set(value As RoutedUICommand)
	    End Set
	End Property
```

Initialize them in the constructor of the __ViewModel__:        



```C#
	public ExampleViewModel()
	{
	    this.MoveUpCommand = new RoutedUICommand("Move Up", "MoveUp", typeof(ExampleViewModel));
	    this.MoveDownCommand = new RoutedUICommand("Move Down", "MoveDown", typeof(ExampleViewModel));
	    this.InitItems();
	}
```
```VB.NET
	Public Sub New()
	    Me.MoveUpCommand = New RoutedUICommand("Move Up", "MoveUp", GetType(ExampleViewModel))
	    Me.MoveDownCommand = New RoutedUICommand("Move Down", "MoveDown", GetType(ExampleViewModel))
	    Me.InitItems()
	End Sub
```

Bind them in the __View__.
        



```XAML
	<ListBox x:Name="listBox3"
	         DisplayMemberPath="Value"
	         ItemsSource="{Binding Items}"
	         SelectedItem="{Binding SelectedItem, Mode=TwoWay}">
	    <telerik:RadContextMenu.ContextMenu>
	        <telerik:RadContextMenu x:Name="radContextMenu3"
	                                Opened="RadContextMenu_Opened">
	            <telerik:RadMenuItem Header="{Binding MoveUpCommand.Text}"
	                                 Command="{Binding MoveUpCommand}" />
	            <telerik:RadMenuItem Header="{Binding MoveDownCommand.Text}"
	                                 Command="{Binding MoveDownCommand}" />
	        </telerik:RadContextMenu>
	    </telerik:RadContextMenu.ContextMenu>
	</ListBox>
```

You will also need methods that will get called when the command is executed. In the next section is explained how to connect the methods to the command. Here are sample methods for the two commands.



```C#
	public void MoveUp(object sender, ExecutedRoutedEventArgs e)
	{
	    if (this.SelectedItem == null || this.Items.IndexOf(this.SelectedItem as DataItem) == 0)
	    {
	        return;
	    }
	    DataItem item = this.SelectedItem;
	    int index = this.Items.IndexOf(item as DataItem);
	    this.Items.Remove(item as DataItem);
	    this.Items.Insert(index - 1, item as DataItem);
	    this.SelectedItem = item;
	}
	public void MoveDown(object sender, ExecutedRoutedEventArgs e)
	{
	    if (this.SelectedItem == null || this.Items.IndexOf(this.SelectedItem as DataItem) == this.Items.Count - 1)
	    {
	        return;
	    }
	    DataItem item = this.SelectedItem;
	    int index = this.Items.IndexOf(item as DataItem);
	    this.Items.Remove(item as DataItem);
	    this.Items.Insert(index + 1, item as DataItem);
	    this.SelectedItem = item;
	}
```
```VB.NET
	Public Sub MoveUp(sender As Object, e As ExecutedRoutedEventArgs)
	    If Me.SelectedItem Is Nothing OrElse Me.Items.IndexOf(TryCast(Me.SelectedItem, DataItem)) = 0 Then
	        Return
	    End If
	    Dim item As DataItem = Me.SelectedItem
	    Dim index As Integer = Me.Items.IndexOf(TryCast(item, DataItem))
	    Me.Items.Remove(TryCast(item, DataItem))
	    Me.Items.Insert(index - 1, TryCast(item, DataItem))
	    Me.SelectedItem = item
	End Sub
	Public Sub MoveDown(sender As Object, e As ExecutedRoutedEventArgs)
	    If Me.SelectedItem Is Nothing OrElse Me.Items.IndexOf(TryCast(Me.SelectedItem, DataItem)) = Me.Items.Count - 1 Then
	        Return
	    End If
	    Dim item As DataItem = Me.SelectedItem
	    Dim index As Integer = Me.Items.IndexOf(TryCast(item, DataItem))
	    Me.Items.Remove(TryCast(item, DataItem))
	    Me.Items.Insert(index + 1, TryCast(item, DataItem))
	    Me.SelectedItem = item
	End Sub
```

## Creating the CommandBindings

In order to use the commands in the UI you have to provide a __CommandBinding__ for each of the commands. The __CommandBinding__ binds the command to a method that is called when the command gets executed. The __CommandBidnings__ get set via the __CommandManager__. As the __CommandManager__ is called by the __View__ you have to expose a method in your __ViewModel__ that returns a collection of its __CommandBindings__.
        



```C#
	public CommandBindingCollection GetCommandBindings()
	{
	    CommandBindingCollection bindings = new CommandBindingCollection();
	    bindings.Add(new CommandBinding(this.MoveUpCommand, this.MoveUp));
	    bindings.Add(new CommandBinding(this.MoveDownCommand, this.MoveDown));
	    return bindings;
	}
```
```VB.NET
	Public Function GetCommandBindings() As CommandBindingCollection
	    Dim bindings As New CommandBindingCollection()
	    bindings.Add(New CommandBinding(Me.MoveUpCommand, Me.MoveUp))
	    bindings.Add(New CommandBinding(Me.MoveDownCommand, Me.MoveDown))
	    Return bindings
	End Function
```

## Setting the CommandBindings

In the __View__ get the __CommandBindingsCollection__ and set it through the __CommandManager__.

{% if site.site_name == 'Silverlight' %}


```C#
	public Default_Cs()
	{
	    InitializeComponent();
	    this.viewModel = new ExampleViewModel();
	    this.DataContext = viewModel;
	    CommandManager.SetCommandBindings(this, this.viewModel.GetCommandBindings());
	}
```
```VB.NET
	Public Sub New()
	    InitializeComponent()
	    Me.viewModel = New ExampleViewModel()
	    Me.DataContext = viewModel
	    CommandManager.SetCommandBindings(Me, Me.viewModel.GetCommandBindings())
	End Sub
```
{% endif %}

{% if site.site_name == 'WPF' %}


```C#
	public Default_Cs()
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
```
```VB.NET
	Public Sub New()
	    InitializeComponent()
	    Me.viewModel = New ExampleViewModel()
	    Me.DataContext = viewModel
	
	    Dim collection As CommandBindingCollection = Me.viewModel.GetCommandBindings()
	    For Each commandBinding As CommandBinding In collection
	        CommandManager.RegisterClassCommandBinding(GetType(ListBoxItem), commandBinding)
	    Next commandBinding
	End Sub
```
{% endif %}

## See Also

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Binding to Dynamic Data]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%})

 * [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%})

 * [Select  the clicked Item of a RadTreeView]({%slug radcontextmenu-how-to-select-the-clicked-item-of-radtreeview%})

 * [Create Menu Button with RadContextMenu and ToggleButton]({%slug radcontextmenu-how-to-create-menu-button-with-radcontextmenu-and-togglebutton%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
