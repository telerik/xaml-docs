---
title: Hierarchical Data Templates
page_title: Hierarchical Data Templates
description: Check our &quot;Hierarchical Data Templates&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-populating-with-data-hierarchical-data-templates
tags: hierarchical,data,templates
published: True
position: 13
---

# Hierarchical Data Templates

__RadTreeViewItem__ inherits from __HeaderedItemsControl__ and they can display hierarchical data, e.g. collections that contain other collections.

The __HierarchicalDataTemplate__ class is designed to be used with __HeaderedItemsControl__ types to display such data. There should be virtually no differences between the usage of __HierarchicalDataTemplate__ in __RadTreeView__ and other controls.

The following example demonstrates how to create a hierarchical data source and bind a __RadTreeView__ to it, using a __HierarchicalDataTemplate__. The __ItemsSource__ property of the __HierarchicalDataTemplate__ specifies the __binding__ that has to be applied to the __ItemsSource__ property of each item. The __DataTemplate__ property specifies the template that has to be applied on each item, while the __ItemTemplate__ is the template applied on its child items. You can nest several __HierarchicalDataTemplate__ declarations if you need a deeper level of hierarchy. 

> If you have a __databound control__, then you must consider the following rules.The __ItemsControl__ prepares its children in a very different way, depending on the type of the __child__:

>	- If it is a __ContentControl__, the __ItemTemplate__ will be set as a __ContentTemplate__ and the non-visual element as content.
>	- If it is a __HeaderedControl__, the __ItemTemplate__ will be set as a __HeaderTemplate__ and the data item as a Header. 
>	- If it is a __HeaderedContentControl__ (i.e. the two above combined), the item will go as __Content__, but the __ContentTemplate__ won't be set. Instead, the item will be set as a __Header__ and the __ItemTemplate__ will be used as a __HeaderTemplate__.

>If the item is an __ItemsControl__, these properties are set to the child items as well, what is called "inherited": __ItemTemplate__, __ItemTemplateSelector__, __ItemContainerStyle__, __ItemContainerStyleSelector__{% if site.site_name == 'WPF' %}, __DisplayMemberPath__{% endif %}{% if site.site_name == 'Silverlight' %}, __ItemStringFormat__, __AnimationManager__.__IsAnimationEnabled__{% endif %}.In the case of the __RadTreeView__, the tree items are __HeaderedItemsControl__, which means that the above properties will be passed along to all the items, and there is no need to set the __ItemTemplate__ property of the __HierarchicalDataTemplate__, especially if there is a selector.The __ItemContainerStyle__ will be set as a style for the containers, if there is none and an __ItemContainerStyleSelector__ is present, a style will be selected. Then the __ItemContainerStyle__ (Selector) properties will be passed along ig the container is an __ItemsControl__.The above rules can "mix" with the properties set in the __HierarchicalDataTemplate__ to create even more combinations of ways to set the templates of items. The __HeaderTemplate__ displayed for an item can be a result of one of the following:

>	- Directly (locally) set __HeaderTemplate__.
>	- Directly (locally) set __HeaderTemplateSelector__. 
>	- __ItemTemplate__ of the parent __ItemsControl__. 
>	- __ItemTemplateSelector__ of the parent __ItemsControl__. 
>	- __ItemContainerStyle__ with a __HeaderTemplate__ of the parent __ItemsControl__. 
>	- __ItemContainerStyleSelector__ which selects a style with a __HeaderTemplate__. 
>	- __ItemContainerStyle__ with a __HeaderTemplateSelector__ of the parent __ItemsControl__.
>	- __ItemContainerStyleSelector__ which selects a style with a __HeaderTemplateSelector__. 
>	- An __ItemTemplate__ set in the __HierarchicalDataTemplate__ of the parent. 
>	- An __ItemTemplateSelector__ set in the __HierarchicalDataTemplate__ of the parent. 
>	- An __ItemContainerStyle__ set in the __HierarchicalDataTemplate__ of the parent, which sets a __HeaderTemplate__. 
>	- An __ItemContainerStyleSelector__ set in the __HierarchicalDataTemplate__ of the parent, which selects a style that sets a __HeaderTemplate__. 
>	- In WPF you have the DataType property of the __DataTemplate__ which will be a last fallback if a template is not set at all.

>tip The {% if site.site_name == 'Silverlight' %}Telerik {% endif %}__HierarchicalDataTemplate__ offers two properties - __ItemContainerStyle__ and __ItemContainerStyleSelector__, which allows you to make your hierarchy quite flexible.An interesting point here is the precedence over what should be set. As always, local values are stronger than styles. But what happens when you have both an __ItemContainerStyle__ set in the __ItemsControl__ and the __HierarchicalDataTemplate__. Also what happens when you have an __ItemContainerStyle__ set in the two above __and__ in the __ItemContainerStyle__ as well. The rule is that the __ItemContainerStyle__ from the __HierarchicalDataTemplate__ is applied to the first level of containers that has a style which is the same as the parent's. The last __ItemContainerStyle__ to be actively set is inherited from them on. The same rule applies for selectors.For more information see the example below.

## Example

We will specify the following classes, which are going to be used to the RadTreeView control.

* __MyItem:__ A class that will be our business object. This class will have a collection of MyItems. It will be used to show hierarchy in the RadTreeView.
* __MyViewModel:__ The main ViewModel class of the application.

	__Example 1: Creating ViewModels__

	```C#
		public class MyItem
		{
			public string Title { get; set; }
			public MyItem()
			{
				SubItems = new ObservableCollection<MyItem>();
			}
			public ObservableCollection<MyItem> SubItems { get; set; }
		}
		
		public class MyViewModel : ViewModelBase
		{
			public ObservableCollection<MyItem> Data { get; set; }
			public MyViewModel()
			{
				Data = new ObservableCollection<MyItem>();
				GetData();
			}

			private void GetData()
			{
				foreach (var num in Enumerable.Range(1, 5))
				{
					var item = new MyItem();
					item.Title = string.Format("{0} {1}", "Item", num);
					for (int i = 0; i < 5; i++)
					{
						var child = new MyItem();
						child.Title = string.Format("{0} {1}'s {2}", "Item", num, i);
						item.SubItems.Add(child);
						for (int j = 0; j < 3; j++)
						{
							var grandChild = new MyItem();
							grandChild.Title = string.Format("{0} {1} : {2}'s {3}", "Item", num, i, j);
							child.SubItems.Add(grandChild);
						}
					}
					Data.Add(item);
				}
			}
		}
	```
```VB.NET
		Public Class MyItem
			Public Property Title As String

			Public Sub New()
				SubItems = New ObservableCollection(Of MyItem)()
			End Sub

			Public Property SubItems As ObservableCollection(Of MyItem)
		End Class

		Public Class MyViewModel
			Inherits ViewModelBase

			Public Property Data As ObservableCollection(Of MyItem)

			Public Sub New()
				Data = New ObservableCollection(Of MyItem)()
				GetData()
			End Sub

			Private Sub GetData()
				For Each num In Enumerable.Range(1, 5)
					Dim item = New MyItem()
					item.Title = String.Format("{0} {1}", "Item", num)

					For i As Integer = 0 To 5 - 1
						Dim child = New MyItem()
						child.Title = String.Format("{0} {1}'s {2}", "Item", num, i)
						item.SubItems.Add(child)

						For j As Integer = 0 To 3 - 1
							Dim grandChild = New MyItem()
							grandChild.Title = String.Format("{0} {1} : {2}'s {3}", "Item", num, i, j)
							child.SubItems.Add(grandChild)
						Next
					Next

					Data.Add(item)
				Next
			End Sub
		End Class	
	```


	Now consider both of the background notes at the beginning of the topic and take a look at the following code snippet. It declares a __HierarchicalDataTemplate__ and uses the __ItemContainerStyle__ property of both the __RadTreeView__ and the __HierarchicalDataTemplate__.{% if site.site_name == 'Silverlight' %}

	__Example 2: Defining RadTreeView in XAML__

	```XAML
		<Window.Resources>
		
			<Style TargetType="telerik:RadTreeViewItem" x:Key="redStyle">
				<Setter Property="Background" Value="Red" />
				<Setter Property="ItemContainerStyle">
					<Setter.Value>
						<Style TargetType="telerik:RadTreeViewItem">
							<Setter Property="Background" Value="Orange" />
						</Style>
					</Setter.Value>
				</Setter>
			</Style>
		
			<Style TargetType="telerik:RadTreeViewItem" x:Key="greenStyle">
				<Setter Property="Background" Value="Green" />
			</Style>
		
		</Window.Resources>
		<Grid x:Name="LayoutRoot" Background="White">
		
			<telerik:RadTreeView Margin="8" ItemsSource="{Binding Data}" ItemContainerStyle="{StaticResource redStyle}">
				<telerik:RadTreeView.ItemTemplate>		
					<telerik:HierarchicalDataTemplate ItemsSource="{Binding SubItems}" ItemContainerStyle="{StaticResource greenStyle}">
						<TextBlock Text="{Binding Title}" />
					</telerik:HierarchicalDataTemplate>		
				</telerik:RadTreeView.ItemTemplate>
			</telerik:RadTreeView>		
		</Grid>
	```

	{% endif %}
	{% if site.site_name == 'WPF' %}

	__Example 2: Defining RadTreeView in XAML__

	```XAML
		<Window.Resources>
		
			<Style TargetType="telerik:RadTreeViewItem" x:Key="redStyle">
				<Setter Property="Background" Value="Red" />
				<Setter Property="ItemContainerStyle">
					<Setter.Value>
						<Style TargetType="telerik:RadTreeViewItem">
							<Setter Property="Background" Value="Orange" />
						</Style>
					</Setter.Value>
				</Setter>
			</Style>
		
			<Style TargetType="telerik:RadTreeViewItem" x:Key="greenStyle">
				<Setter Property="Background" Value="Green" />
			</Style>
		
		</Window.Resources>
		<Grid x:Name="LayoutRoot" Background="White">
		
			<telerik:RadTreeView  Margin="8" ItemsSource="{Binding Data}" ItemContainerStyle="{StaticResource redStyle}">
				<telerik:RadTreeView.ItemTemplate>
		
					<HierarchicalDataTemplate ItemsSource="{Binding SubItems}" ItemContainerStyle="{StaticResource greenStyle}">
						<TextBlock Text="{Binding Title}" />
					</HierarchicalDataTemplate>
		
				</telerik:RadTreeView.ItemTemplate>
			</telerik:RadTreeView>
		
		</Grid>
	```
	{% endif %}

And finally, we need to set the DataContext of the MainWindow:

__Example 3: Setting DataContext__
```C#
	public MainWindow()
	{
		InitializeComponent();
		this.DataContext = new MyViewModel();
	}
```
```VB.NET
	public MainWindow()
	{
		InitializeComponent();
		this.DataContext = new MyViewModel();
	}
```

Here is the final result: 
![{{ site.framework_name }} RadTreeView Custom HierarchicalDataTemplate and ItemContainerStyle](images/RadTreeView_TemplatingHierarchicalDataTemplate_010.PNG)

## See Also
 * [Styling and Appearance - Overview]({%slug radtreeview-styling-and-appearance-overview2%})
 * [DataBinding - Overview]({%slug radtreeview-populating-with-data-databinding-overview%})
