---
title: Expanding and Collapsing Items
page_title: Expanding and Collapsing Items
description: Check our &quot;Expanding and Collapsing Items&quot; documentation article for the RadTreeListView {{ site.framework_name }} control.
slug: radtreelsitview-how-to-control-expand-settings
tags: isexpandedbinding,and,isexpandablebinding,expand,collapse
published: True
position: 2
---

# Expanding and Collapsing Items

The RadTreeListView control allows you to control the state of its items both **programmatically** via its public methods and through the **IsExpandedBinding** and **IsExpandableBinding** properties.

## Expand and Collapse Items Programmatically

There are four methods which you can use to programmatically control the state of the items:

* **ExpandHierarchyItem(object hierarchyItem)**: Expands the respective GridViewRow for the given item.
* **CollapseHierarchyItem(object hierarchyItem)**: Collapses the respective GridViewRow for the given item.
* **ExpandAllHierarchyItems()**: Expands all hierarchy items.
* **CollapseAllHierarchyItems()**: Collapses all hierarchy items.

All four methods can also be given an additional boolean parameter (preserveLocalSettings) which determines if the **IsExpandable** state of the item set via the **RowStyle** or **RowStyleSelector** properties should be preserved.

__Example 1: Expand the third item after the control is loaded__
```C#
	private void TreeListView_Loaded(object sender, RoutedEventArgs e)
	{
		TreeListView.ExpandHierarchyItem(TreeListView.Items[2], true);
	}
```

## IsExpandedBinding and IsExpandableBinding

The RadTreeListView also exposes the __IsExpandedBinding__ and __IsExpandableBinding__ properties which you can use to synchronize its expanded and expandable states with your viewmodel.

>caution Binding to the __IsExpanded__ property of __TreeListViewRow__ is not fully supported and that is why we recommend using the [IsExpandedBinding](#use-of-isexpandedbinding) property instead.

### IsExpandedBinding

__IsExpandedBinding__ property can be used to control whether a row is expanded or not.

First start by adding a boolean property to your business items as demonstrated in **Example 1**. For the purposes of this article, we will extend the WarehouseItem class from the [Getting Started article]({%slug radtreeliestview-getting-started%}).

__Example 2: Extend the WarehouseItem class__
```C#
	public class WarehouseItem : ViewModelBase
	{
		// other members

		private bool isExpanded;

		public bool IsExpanded
		{
			get
			{
				return this.isExpanded;
			}
			set
			{
				if (value != this.isExpanded)
				{
					this.isExpanded = value;
					this.OnPropertyChanged("IsExpanded");
				}
			}
		}
	}
```
```VB.NET
	Public Class WarehouseItem		
		Inherits ViewModelBase

		' other members

		Private m_isExpanded As Boolean

		Public Property IsExpanded() As Boolean
			Get
				Return Me.m_isExpanded
			End Get
			Set(value As Boolean)
				If value <> Me.m_isExpanded Then
					Me.m_isExpanded = value
					Me.OnPropertyChanged("IsExpanded")
				End If
			End Set
		End Property
	End Class
```

>Note that the class inherits from the [ViewModelBase]({%slug common-viewmodelbase-class%}) class which implements the __INotifyPropertyChanged__ interface.

Then define the __RadTreeListView__ control as demonstrated in __Example 2__.

__Example 3: Declare RadTreeListView in XAML__
```XAML
	<telerik:RadTreeListView x:Name="radTreeListView"
								 IsExpandedBinding="{Binding IsExpanded, Mode=TwoWay}"
								 AutoGenerateColumns="False">
			<telerik:RadTreeListView.ChildTableDefinitions>
				<telerik:TreeListViewTableDefinition ItemsSource="{Binding Items}" />
			</telerik:RadTreeListView.ChildTableDefinitions>
			<telerik:RadTreeListView.Columns>
				<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
									Header="Name" />
				<telerik:GridViewDataColumn DataMemberBinding="{Binding IsExpanded}" 
									Header="Is Expanded" />
			</telerik:RadTreeListView.Columns>
		</telerik:RadTreeListView>
```

With this setup expanding or collapsing a row will result in the respective checkbox from the IsExpanded column to be updated.

>tip A complete example of using __RadTreeListView's IsExpandedBinding__ property is available in {% if site.site_name == 'Silverlight' %}[this online demo](https://demos.telerik.com/silverlight/#TreeListView/IsExpanded){% endif %}{% if site.site_name == 'WPF' %}[the TreeListView's IsExpanded demo](https://demos.telerik.com/wpf/){% endif %}.

### IsExpandableBinding

The use of __IsExpandableBinding__ is identical to that of the __IsExpandedBinding__ - you need to define a boolean property in your business class and bind it to the IsExpandableBinding property of the RadTreeListView control.

>tip A complete example of using __RadTreeListView's IsExpandableBinding__ property is available in {% if site.site_name == 'Silverlight' %}[this online demo](https://demos.telerik.com/silverlight/#TreeListView/OnDemandDataLoading){% endif %}{% if site.site_name == 'WPF' %}[the TreeListView's OnDemandDataLoading demo](https://demos.telerik.com/wpf/){% endif %}.

## See Also

* [Expand All Rows]({%slug treelistview-expand-all-hierarchy%})
