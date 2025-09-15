---
title: Deleting an Entry
page_title: Deleting an Entry
description: Learn how to remove manually the desired items from the ItemsSource collection of Telerik's {{ site.framework_name }} DataGrid in order to delete an entry.
slug: gridview-managing-data-deleting-entry
tags: deleting,an,entry
published: True
position: 3
---

# Deleting an Entry

__GridView__ allows you to easily delete rows using the `Del` key or programmatically. 

The control doesn't have built-in UI for deleting rows, but it provides a command that allows to do that easily. The [RadGridViewCommands.Delete]({%slug gridview-commands-overview%}) is a `RoutedUICommand` that can be assigned directly to a button or any other element that supports commands. The command can be executed also manually in code. 

Another option to delete rows is to remove the data items from the `ItemsSource` collection of the `RadGridView`. 

To disable the `Del` key deletion set the `CanUserDeleteRows` property of `RadGridView` to `true`.

The following examples show how to manually remove items from the `ItemsSource`.

#### __XAML__  
```XAML
	<StackPanel x:Name="LayoutRoot">
	    <Button Content="Delete"
	    Click="Button_Click" />
	    <telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	        <!--...-->
	    </telerik:RadGridView>
	</StackPanel>
```

To determine which items are to be removed, use the __SelectedItems__ collection of the __RadGridView__. You can also use the __SelectedItem__ or the __CurrentItem__ objects, but the __SelectedItems__ collection is more flexible and allows your deleting logic to function even by [multiple selection]({%slug gridview-multiple-selection%}).

#### __C#__

```C#
	private void Button_Click(object sender, RoutedEventArgs e)
	{
	    ObservableCollection<Employee> itemsToRemove = new ObservableCollection<Employee>();
	
	    foreach (Employee item in this.radGridView.SelectedItems)
	    {
	        itemsToRemove.Add(item);
	    }
	    foreach (Employee item in itemsToRemove)
	    {
	        ((ObservableCollection<Employee>)this.radGridView.ItemsSource).Remove(item);
	    }
	}
```

#### __VB.NET__

```VB.NET
	Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	    Dim itemsToRemove As New ObservableCollection(Of Employee)()
	
	    For Each item As Employee In Me.radGridView.SelectedItems
	        itemsToRemove.Add(item)
	    Next
	    For Each item As Employee In itemsToRemove
	        DirectCast(Me.radGridView.ItemsSource, ObservableCollection(Of Employee)).Remove(item)
	    Next
	End Sub
```

When an item is removed from the __ItemsSource__ collection it is also removed from the __SelectedItems__ collection. This means that you cannot directly use the __SelectedItems__ in the same foreach, where the items get removed, because it will result in an exception. This is where the itemsToRemove comes in hand.

Here is an example of a sample deleting logic implemented in the event handler for a Button's Click event.

#### __C#__

```C#
	private void Button2_Click(object sender, RoutedEventArgs e)
	{
	    if (this.radGridView.SelectedItems.Count == 0)
	    {
	        return;
	    }
	
	    ObservableCollection<Employee> itemsToRemove = new ObservableCollection<Employee>();
	
	    //Remove the items from the RadGridView
	    foreach (var item in this.radGridView.SelectedItems)
	    {
	        itemsToRemove.Add(item as Employee);
	    }
	    foreach (var item in itemsToRemove)
	    {
	        ((ObservableCollection<Employee>)this.radGridView.ItemsSource).Remove(item as Employee);
	    }
	}
```

#### __VB.NET__

```VB.NET
	Private Sub Button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	    If Me.radGridView.SelectedItems.Count = 0 Then
	        Exit Sub
	    End If
	
	    Dim itemsToRemove As New ObservableCollection(Of Employee)()
	
	    'Remove the items from the RadGridView
	    For Each item In Me.radGridView.SelectedItems
	        itemsToRemove.Add(TryCast(item, Employee))
	    Next
	
	    For Each item In itemsToRemove
	        DirectCast(Me.radGridView.ItemsSource, ObservableCollection(Of Employee)).Remove(TryCast(item, Employee))
	    Next
	End Sub
```

In this example the implementation manages both the __RadGridView__ and the data storage. Of course it is up to the developer to shape the deleting logic, so it suits the application requirements in the best way.

## See Also  
 * [Adding New Entries]({%slug gridview-managing-data-add-new-entries%})
 * [Updating an Entry]({%slug gridview-managing-data-updating-entry%})
 * [Validating]({%slug gridview-managing-data-validation%})
