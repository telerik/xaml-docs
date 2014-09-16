---
title: Deleting an Entry
page_title: Deleting an Entry
description: Deleting an Entry
slug: gridview-managing-data-deleting-entry
tags: deleting,an,entry
publish: True
position: 3
---

# Deleting an Entry



## 

The __RadGridView__ has no built-in deleting functionality, but there is no need of such, as it provides you with all the things you need to implement one. This implementation consists of manually removing the desired items from the __ItemsSource__ collection of the __RadGridView__. 

>tipUsers can delete (if supported by the grid __ItemsSource__) selected items using __DELETE__ key. This feature can be enabled by setting the __RadGridView__'s __CanUserDeleteRows__ property to __True__.

For example, you can have a button in which click event you implement your deleting logic.

#### __XAML__

{{region gridview-managing-data-deleting-entry_0}}
	<StackPanel x:Name="LayoutRoot">
	    <Button Content="Delete"
	            Click="Button_Click" />
				<telerik:RadGridView x:Name="radGridView"
	                             AutoGenerateColumns="False">
	        ...
				</telerik:RadGridView>
	</StackPanel>
	{{endregion}}



#### __C#__

{{region gridview-managing-data-deleting-entry_1}}
	private void Button_Click( object sender, RoutedEventArgs e )
	{
	}
	{{endregion}}



#### __VB.NET__

{{region gridview-managing-data-deleting-entry_2}}
	Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
	End Sub
	{{endregion}}



To determine which items are to be removed, use the __SelectedItems__ collection of the __RadGridView__. You can also use the __SelectedItem__ or the __CurrentItem__ objects, but the __SelectedItems__ collection is more flexible and allows your deleting logic to function even by [multiple selection]({%slug gridview-multiple-selection%}).

#### __C#__

{{region gridview-managing-data-deleting-entry_3}}
	foreach ( Employee item in this.radGridView.SelectedItems )
	{
	    itemsToRemove.Add( item );
	}
	foreach ( Employee item in itemsToRemove )
	{
	    ( ( ObservableCollection<Employee> )this.radGridView.ItemsSource ).Remove( item );
	}
	{{endregion}}



#### __VB.NET__

{{region gridview-managing-data-deleting-entry_4}}
	For Each item As Employee In Me.radGridView.SelectedItems
	    itemsToRemove.Add(item)
	Next
	For Each item As Employee In itemsToRemove
	    DirectCast(Me.radGridView.ItemsSource, ObservableCollection(Of Employee)).Remove(item)
	Next
	{{endregion}}



When an item is removed from the __ItemsSource__collection it is also removed from the __SelectedItems__collection. This means that you cannot directly use the __SelectedItems__in the same foreach, where the items get removed, because it will result in an exception. This is where the itemsToRemove comes in hand.

Here is an example of a sample deleting logic implemented in the event handler for a Button's Click event.

#### __C#__

{{region gridview-managing-data-deleting-entry_5}}
	private void Button_Click( object sender, RoutedEventArgs e )
	{
	    if ( this.radGridView.SelectedItems.Count == 0 )
	    {
	        return;
	    }
	    ObservableCollection<Employee> itemsToRemove = new ObservableCollection<Employee>();
	
	    //Remove the items from the RadGridView
	    foreach ( var item in this.radGridView.SelectedItems )
	    {
	        itemsToRemove.Add( item as Employee );
	    }
	    foreach ( var item in itemsToRemove )
	    {
	        ( ( ObservableCollection<Employee> )this.radGridView.ItemsSource ).Remove( item as Employee );
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region gridview-managing-data-deleting-entry_6}}
	Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
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
	{{endregion}}



In this example the implementation manages both the __RadGridView__and the data storage. Of course it is up to the developer to shape the deleting logic, so it suits the application requirements in the best way.

# See Also

 * [Adding New Entries]({%slug gridview-managing-data-add-new-entries%})

 * [Updating an Entry]({%slug gridview-managing-data-updating-entry%})

 * [Validating]({%slug gridview-managing-data-validation%})
