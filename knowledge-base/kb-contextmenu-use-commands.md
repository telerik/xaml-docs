---
title: Using Commands with the RadContextMenu
description: Learn how to use RoutedUICommands with a RadContextMenu and the MVVM pattern.
type: how-to
page_title: Using Commands with RadContextMenu and MVVM
slug: kb-contextmenu-use-commands
position: 0
tags: radcontextmenu, commands, routeduicommand, commandbinding, mvvm, listbox
res_type: kb
---

## Environment

<table>
<tbody>
<tr>
<td>Product Version</td>
<td>2026.1.415</td>
</tr>
<tr>
<td>Product</td>
<td>RadContextMenu for WPF</td>
</tr>
</tbody>
</table>

## Description

Use RoutedUICommands with a RadContextMenu to move a selected ListBox item up or down through an MVVM view model.

## Solution

Attach a RadContextMenu to a ListBox, expose the data and commands from a view model, select the right-clicked item, and register command bindings for ListBoxItem.


As the __RadMenuItem__ implements the __ICommandSource__ interface, you are able to use any kind of commands that inherit from the __ICommand__ interface with it. This tutorial will show you how to use the __RadContextMenu__ with __RoutedUICommands__ combined with the __MVVM__ pattern. Two commands are going to be exposed - one for moving an item in a ListBox up and one for moving an item down. The following things will come in focus:

* [Attaching a RadContextMenu to a ListBox control](#attaching-a-radcontextmenu-to-a-listbox-control)

* [Populating the ListBox with data via a ViewModel](#populating-the-listbox-with-data-via-a-viewmodel)

* [Selecting the right-clicked ListBoxItem](#selecting-the-right-clicked-listboxitem)

* [Preparing the RoutedUICommands](#preparing-the-routeduicommands)

* [Creating the CommandBindings](#creating-the-commandbindings)

* [Setting the CommandBindings](#setting-the-commandbindings)

## Attaching a RadContextMenu to a ListBox control

Before getting to the commands, you have to prepare the UI on which they will get executed. In this tutorial a __ListBox__ and a __RadContextMenu__ are used.




__Attach RadContextMenu to a ListBox__
```XAML
<ListBox xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" x:Name="listBox">
    <telerik:RadContextMenu.ContextMenu>
        <telerik:RadContextMenu x:Name="radContextMenu">
        </telerik:RadContextMenu>
    </telerik:RadContextMenu.ContextMenu>
</ListBox>
```

Having the UI prepared, you have to add some data to it.

## Populating the ListBox with data via a ViewModel

As the __MVVM__ pattern should be used, you have to create a __ViewModel__ for your __UserControl__, which will control its behavior. In it you will store the data which the __View__ is using. Here is the declaration of the ViewModel class. It has a constructor, a method that initializes the items for the __ListBox__ and an __Items__ property, that stores them. Additionally create a __SelectedItem__ property that will hold the selected item of the __ListBox__.



__Define the ViewModel in C#__
```C#
public class DataItem
{
    public DataItem(string value)
    {
        this.Value = value;
    }

    public string Value { get; set; }
}

public class ExampleViewModel : INotifyPropertyChanged
{
    private DataItem selectedItem;
    public ExampleViewModel()
    {
        this.MoveUpCommand = new RoutedUICommand("Move Up", "MoveUp", typeof(ExampleViewModel));
        this.MoveDownCommand = new RoutedUICommand("Move Down", "MoveDown", typeof(ExampleViewModel));
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
In the constructor of the __UserControl__ you have to create an instance of the __ViewModel__, store it in a field and pass it as a __DataContext__ of the entire __UserControl__.



__Initialize the ViewModel in C#__
```C#
private ExampleViewModel viewModel;
```

In the XAML you have to set the __SelectedItem__, the __DisplayMemberPath__ and the __ItemsSource__ properties of the __ListBox__ in order to visualize the data.



__Bind ListBox Data and Selection__
```XAML
<ListBox xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
         x:Name="listBox"
         DisplayMemberPath="Value"
         ItemsSource="{Binding Items}"
         SelectedItem="{Binding SelectedItem, Mode=TwoWay}">
    <telerik:RadContextMenu.ContextMenu>
        <telerik:RadContextMenu x:Name="radContextMenu">
        </telerik:RadContextMenu>
    </telerik:RadContextMenu.ContextMenu>
</ListBox>
```

## Selecting the right-clicked ListBoxItem

Before continuing, there is one more thing to be done. When right-clicking to open the __RadContextMenu__, the clicked item should get selected, or if no item was clicked, the selection should be removed. This is done by handling the __Opened__ event of the __RadContextMenu__.



__Handle the Right-Clicked ListBoxItem__
```XAML
<ListBox xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
         x:Name="listBox"
         DisplayMemberPath="Value"
         ItemsSource="{Binding Items}"
         SelectedItem="{Binding SelectedItem, Mode=TwoWay}">
    <telerik:RadContextMenu.ContextMenu>
        <telerik:RadContextMenu x:Name="radContextMenu"
                                  Opened="RadContextMenu_Opened">
        </telerik:RadContextMenu>
    </telerik:RadContextMenu.ContextMenu>
</ListBox>
```




__Select the Right-Clicked ListBoxItem in C#__
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
## Preparing the RoutedUICommands

The next step is to create your commands. They will be host by the __ViewModel__.



__Declare the RoutedUICommands in C#__
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
Initialize them in the constructor of the __ViewModel__:



__Initialize the RoutedUICommands in C#__
```C#
this.MoveUpCommand = new RoutedUICommand("Move Up", "MoveUp", typeof(ExampleViewModel));
this.MoveDownCommand = new RoutedUICommand("Move Down", "MoveDown", typeof(ExampleViewModel));
```

Bind them in the __View__.




__Bind the Commands to RadMenuItems__
```XAML
<ListBox xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
         x:Name="listBox"
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
```

You will also need methods that will get called when the command is executed. In the next section is explained how to connect the methods to the command. Here are sample methods for the two commands.



__Implement the Move Commands in C#__
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
## Creating the CommandBindings

In order to use the commands in the UI you have to provide a __CommandBinding__ for each of the commands. The __CommandBinding__ binds the command to a method that is called when the command gets executed. The __CommandBidnings__ get set via the __CommandManager__. As the __CommandManager__ is called by the __View__ you have to expose a method in your __ViewModel__ that returns a collection of its __CommandBindings__.




__Create CommandBindings in C#__
```C#
public CommandBindingCollection GetCommandBindings()
{
    CommandBindingCollection bindings = new CommandBindingCollection();
    bindings.Add(new CommandBinding(this.MoveUpCommand, this.MoveUp));
    bindings.Add(new CommandBinding(this.MoveDownCommand, this.MoveDown));
    return bindings;
}
```
## Setting the CommandBindings

In the __View__ get the __CommandBindingsCollection__ and set it through the __CommandManager__.

__Register Command Bindings for ListBoxItem__
```C#
public MainWindow()
{
    this.InitializeComponent();
    this.viewModel = new ExampleViewModel();
    this.DataContext = this.viewModel;

    CommandBindingCollection collection = this.viewModel.GetCommandBindings();
    foreach (CommandBinding commandBinding in collection)
    {
        CommandManager.RegisterClassCommandBinding(typeof(ListBoxItem), commandBinding);
    }
}
```
## See Also

* [Getting Started]({%slug contextmenu-getting-started%})

* [Data Binding]({%slug radcontextmenu-features-data-binding%})

* [Use RadContextMenu with a RadGridView]({%slug kb-contextmenu-use-with-radgridview%})

* [Select the clicked Item of a RadTreeView]({%slug kb-contextmenu-select-clicked-item-radtreeview%})

* [Create Menu Button with RadContextMenu and ToggleButton]({%slug kb-contextmenu-create-menu-button-with-togglebutton%})

* [Handle Item Clicks]({%slug kb-contextmenu-handle-item-clicks%})
