---
title: Grouping
page_title: Grouping
description: Check our &quot;How to group items&quot; documentation article for the RadListBox {{ site.framework_name }} control.
slug: radlistbox-how-to-group-items
tags: how,to,group,items
published: True
position: 6
---

# {{ site.framework_name }} RadListBox Grouping

The __ListBox__ component allows you to easily group the items with the help of a `CollectionViewSource` object and the `GroupStyle` property of the control. The grouping feature not only provides a nice visualization of the items, but using the group style, you can easily customize the groups.

In order for the scrolling of the grouped items to be possible, you must set the `IsScrollIntoViewEnabled` property to `false`. The property was introduced with __SP1 Q3 2015__ and determines whether the selected item will automatically be scrolled into the view. When it is set to *true* (the default value) and an item gets selected, the item is brought into view by scrolling to it. Because that behavior is not expected when grouping is used, the property needs to be set to *false*.

The following example demonstrates how to bind the `ItemsSource` property of `RadListBox` to a `CollectionViewSource` with custom objects grouped by one of their properties.

1. Create a model for the items.

	#### __[C#] Business object Item__  
	{{region cs-radlistbox-how-to-group-items-0}}
		public class Item
		{
			public string Group { get; set; }
			public string Name { get; set; }
		}
	{{endregion}}

	#### __[VB.NET] Business object Item__  
	{{region vb-radlistbox-how-to-group-items-0}}
		Public Class Item
			Public Property Group() As String
			Public Property Name() As String
		End Class
	{{endregion}}

2. Create a view model class holding the data and setup the `CollectionViewSource`. 

	#### __[C#] ViewModel creation__  
	{{region cs-radlistbox-how-to-group-items-1}}
		public ObservableCollection<Item> Collection { get; set; }
		public CollectionViewSource CollectionView { get; set; }
		public ViewModel()
		{
			this.Collection = new ObservableCollection<Item>
			{
				new Item { Group = "GroupA", Name = "Item 1" },
				new Item { Group = "GroupA", Name = "Item 2" },
				new Item { Group = "GroupA", Name = "Item 3" },
				new Item { Group = "GroupA", Name = "Item 4" },
				new Item { Group = "GroupA", Name = "Item 5" },
				new Item { Group = "GroupA", Name = "Item 6" },
				new Item { Group = "GroupB", Name = "Item 1" },
				new Item { Group = "GroupB", Name = "Item 2" },
				new Item { Group = "GroupB", Name = "Item 3" }
			};
			var view = new CollectionViewSource();
			view.GroupDescriptions.Add(new PropertyGroupDescription("Group"));
			view.Source = Collection;
			CollectionView = view;
		}
	{{endregion}}

	#### __[VB.NET] ViewModel creation__  
	{{region vb-radlistbox-how-to-group-items-1}}
		Public Property Collection() As ObservableCollection(Of Item)
		Public Property CollectionView() As CollectionViewSource
		Public Sub New()
			Me.Collection = New ObservableCollection(Of Item) From {
				New Item With {.Group = "GroupA", .Name = "Item 1"},
				New Item With {.Group = "GroupA", .Name = "Item 2"},
				New Item With {.Group = "GroupA", .Name = "Item 3"},
				New Item With {.Group = "GroupA", .Name = "Item 4"},
				New Item With {.Group = "GroupA", .Name = "Item 5"},
				New Item With {.Group = "GroupA", .Name = "Item 6"},
				New Item With {.Group = "GroupB", .Name = "Item 1"},
				New Item With {.Group = "GroupB", .Name = "Item 2"},
				New Item With {.Group = "GroupB", .Name = "Item 3"}
			}
			Dim view = New CollectionViewSource()
			view.GroupDescriptions.Add(New PropertyGroupDescription("Group"))
			view.Source = Collection
			CollectionView = view
		End Sub
	{{endregion}}

3. Create a new instance of the view model and assign it to the DataContext of the view.

	#### __[XAML] Set the ViewModel as DataContext__  
	{{region xaml-radlistbox-how-to-group-items-0}}
		<UserControl.DataContext>
			<local:ViewModel/>
		</UserControl.DataContext>
	{{endregion}}

4. Assign the `ItemsSource` and `GroupStyle` properties.

	#### __[XAML] Set the ItemsSource and GroupStyle__  
	{{region xaml-radlistbox-how-to-group-items-1}}
		<telerik:RadListBox x:Name="radlistbox" IsScrollIntoViewEnabled="False"
								ItemsSource="{Binding CollectionView.View}"  
								DisplayMemberPath="Name">
			<telerik:RadListBox.GroupStyle>
				<GroupStyle/>
			</telerik:RadListBox.GroupStyle>
		</telerik:RadListBox>
	{{endregion}}

__RadListBox with grouping enabled__

![A picture showing RadListBox with its data grouped](images/radlistbox_how_to_group_items_01.png)
	
## See Also  
* [Get Started with UI for WPF]({%slug getting-started-first-steps%})