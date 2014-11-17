---
title: Programmatic Sorting
page_title: Programmatic Sorting
description: Programmatic Sorting
slug: gridview-sorting-programmatic
tags: programmatic,sorting
published: True
position: 1
---

# Programmatic Sorting

Besides the built-in sorting functionality you are able to use a programmatic approach to sort the data in the __RadGridView__. This is achieved via the __SortDescriptors__ property of the __RadGridView__. This collection of __ISortDescriptor__ objects allows you to use descriptors which define the sorting property (or column) and the sorting direction for the data that is bound to the __RadGridView__. As this is a collection you are able not only to add, but to remove or clear the entries in it too.
    
>tipIf you use __ICollectionView__ as data source, the __RadGridView__ will automatically synchronize the __SortDescriptors__ of the source with its own ones.

When you add a new descriptor to the collection, the data is automatically sorted according to it. To learn how to create and configure descriptors take a look at the following example.

#### __C#__

{{region gridview-sorting-programmatic_0}}

	SortDescriptor descriptor = new SortDescriptor();
	descriptor.Member = "Title";
	descriptor.SortDirection = ListSortDirection.Ascending;
{{endregion}}

#### __VB.NET__

{{region gridview-sorting-programmatic_1}}

	Dim descriptor As New SortDescriptor()
	descriptor.Member = "Title"
	descriptor.SortDirection = ListSortDirection.Ascending
{{endregion}}

The __Member__ property defines the property, by which the data will be sorted, and the __SortDirection__ property allows you to define the sorting direction.
      
Another possible approach is to add the new __ColumnSortDescriptor__ object (instead of SortDescriptor) to the SortDescriptors collection of RadGridView:
      
#### __C#__

{{region gridview-sorting-programmatic_2}}

	ColumnSortDescriptor csd = new ColumnSortDescriptor()
	{
	 Column = this.clubsGrid.Columns["Name"],
	 SortDirection = ListSortDirection.Descending
	};
	this.clubsGrid.SortDescriptors.Add(csd);
{{endregion}}

#### __VB.NET__

{{region gridview-sorting-programmatic_3}}

	Dim csd As New ColumnSortDescriptor() With { _
	 .Column = Me.clubsGrid.Columns("Name"), _
	 .SortDirection = ListSortDirection.Descending _
	}
	Me.clubsGrid.SortDescriptors.Add(csd)
{{endregion}}

>As of Q3 2010, RadGridView adds/removes __ColumnSortDescriptor__ to its __SortDescriptors__ collection when the user sort from the UI.

You can easily create a sort descriptor in XAML and then add it to the SortDescriptors collection

#### __XAML__

{{region gridview-sorting-programmatic_4}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	  ...
	  <telerik:RadGridView.SortDescriptors>
	        <telerik:SortDescriptor Member="Title"
	                                SortDirection="Ascending" />
	    </telerik:RadGridView.SortDescriptors>
	</telerik:RadGridView>
{{endregion}}

As of __Q3 2011__ you can create a ColumnSortDescriptor in XAML and then add it to the SortDescriptors collection
      

#### __XAML__

{{region gridview-sorting-programmatic_7}}

	<telerik:RadGridView x:Name="radGridView" 
	                     AutoGenerateColumns="False">
	  <telerik:RadGridView.Columns>
	    ...
	  </telerik:RadGridView.Columns>
	  <telerik:RadGridView.SortDescriptors>
	      <telerik:ColumnSortDescriptor Column="{Binding Columns[\Title\], ElementName=radGridView}" SortDirection="Ascending"/>
	  </telerik:RadGridView.SortDescriptors>
	</telerik:RadGridView>
{{endregion}}

>You can set the __SortMemberPath__ property of the column to specify the name of the property the data in the column will be sorted by.

## XAML Tip

>tipIn case of a static data structure, known during design time, it is better to declare your default sorting in XAML, rather than in your code-behind.

#### __C#__

{{region gridview-sorting-programmatic_5}}

	this.radGridView.SortDescriptors.Add( descriptor );
{{endregion}}

#### __VB.NET__

{{region gridview-sorting-programmatic_6}}

	Me.radGridView.SortDescriptors.Add(descriptor)
{{endregion}}

After the application is run with this descriptor defined, the __RadGridView__ data will be sorted ascending by the __Title__ column and will look as if you have clicked on the __Title__ column header.
        
>Adding or removing descriptors from the __SortDescriptors__ collection won't raise the __Sorting__ and the __Sorted__ events, although the data will be sorted.

>The built-in sorting also uses the __SortDescriptors__ collection. When a header is clicked it clears the __SortDescriptors__ collection and adds a new descriptor to it.

>tipYou are able to add __SortDescriptors__ in XAML only at design time. To manage the __SortDescriptors__ at runtime use managed code. For example, you have to manage the __SortDescriptors__ collection at runtime when implementing multi-column sorting behavior. To learn more take a look at the [Multi-column Sorting]({%slug gridview-multiple-column-sorting%}) topic.

# See Also

 * [Basic Sorting]({%slug gridview-sorting-basics%})

 * [Custom Sorting]({%slug gridview-sorting-custom%})

 * [Multiple-column Sorting]({%slug gridview-multiple-column-sorting%})
