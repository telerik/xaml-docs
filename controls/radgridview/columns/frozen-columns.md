---
title: Frozen Columns
page_title: Frozen Columns
description: Frozen Columns
slug: gridview-columns-frozen-columns
tags: frozen,columns
published: True
position: 10
---

# Frozen Columns

__RadGridView__ provides an easy way to select one or more columns and exclude them from the horizontal scrolling. The frozen columns stay static on top of the horizontal scrolling. To freeze a column the user has to drag the frozen columns separator.

![Rad Grid View Frozencolumns 1](images/RadGridView_Frozencolumns_1.png)

Once there is a frozen column you can freeze other columns by dragging their headers behind the frozen columns separator.

![Rad Grid View Frozencolumns 2](images/RadGridView_Frozencolumns_2.png)

Similarly, you can unfreeze columns by dragging their headers outside the frozen columns separator.

A frozen column always stays on top of horizontal scrolling.

![Rad Grid View Frozencolumns 3](images/RadGridView_Frozencolumns_3.png)

## Freezing Columns

You can freeze your columns programmatically using the __FrozenColumnCount__ property of the __RadGridView__ control. The property is numeric and you have to set it to the number of columns you wish to freeze.

In this sample, the first two columns are frozen starting from left to right.

#### __[XAML] Example 1 Setting FrozenColumnCount__

{{region gridview-columns-frozen-columns_0}}

	<telerik:RadGridView FrozenColumnCount="2" />
{{endregion}}

#### __[C#] Example 1 Setting FrozenColumnCount__

{{region gridview-columns-frozen-columns_1}}

	this.radGridView.FrozenColumnCount = 2;
{{endregion}}

#### __[VB.NET] Example 1 Setting FrozenColumnCount__

{{region gridview-columns-frozen-columns_2}}

	Me.radGridView.FrozenColumnCount = 2
{{endregion}}

## Disabling Frozen Columns

To disable the freezing of a column just set the __CanUserFreeze to False__ and the frozen columns separator will disappear.

#### __[XAML] Example 2 Disabling Frozen Columns__

{{region gridview-columns-frozen-columns_3}}

	<telerik:RadGridView x:Name="radGridView"
	                     CanUserFreezeColumns="False">
	    ...
	</telerik:RadGridView>
{{endregion}}

![Rad Grid View Frozencolumns 4](images/RadGridView_Frozencolumns_4.png)

## Frozen Columns Events

As of Q1 2016 we've added the __FrozenColumnsChanged__ event which is fired whenever columns are frozen or unfrozen.

You can subscribe to the event either declaratively or runtime like this:

#### __[XAML] Example 3 Subscribing to the FrozenColumnsChanged Event__

{{region gridview-columns-frozen-columns_4}}

	<telerik:RadGridView Name="gridView" 
					     FrozenColumnsChanged="gridView_FrozenColumnsChanged" />
{{endregion}}

#### __[C#] Example 3 Subscribing to the FrozenColumnsChanged Event__

{{region gridview-columns-frozen-columns_5}}

	gridView.FrozenColumnsChanged += new EventHandler<FrozenColumnsChangedEventArgs>(gridView_FrozenColumnsChanged);
{{endregion}}

#### __[VB.NET] Example 3 Subscribing to the FrozenColumnsChanged Event__

{{region gridview-columns-frozen-columns_6}}

	AddHandler gridView.FrozenColumnsChanged, AddressOf gridView_FrozenColumnsChanged
{{endregion}}

Via the FrozenColumnsChangedEventArgs you can get the:

* __AddedFrozenColumns__ - the columns that were added to the collection of frozen columns

* __RemovedFrozenColumns__ - the columns that were removed from the collection of frozen columns

* __AllFrozenColumns__ - the collection of frozen columns

Here is an example of how you can get the names of the columns currently in the frozen columns collection as well as the columns added or removed from it.

#### __[C#] Example 4 Using the FrozenColumnsChanged Event__

{{region gridview-columns-frozen-columns_7}}

	private void clubsGrid_FrozenColumnsChanged(object sender, Telerik.Windows.Controls.GridView.GridView.FrozenColumnsChangedEventArgs e)
    {
        var msg = "Added: " + string.Join(", ", e.AddedFrozenColumns.Select(x => x.UniqueName)) + 
                  "\nRemoved: " + string.Join(", ", e.RemovedFrozenColumns.Select(x => x.UniqueName)) +
                  "\nAll: " + string.Join(", ", e.AllFrozenColumns.Select(x => x.UniqueName));
        MessageBox.Show(msg);
    }
{{endregion}}

![Rad Grid View FrozenColumnsChanged 1](images/RadGridView_FrozenColumnsChanged_1.png)
![Rad Grid View FrozenColumnsChanged 2](images/RadGridView_FrozenColumnsChanged_2.png)

## See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Bound/Unbound Columns]({%slug gridview-columns-bound-unbound-columns%})

 * [Customizing Columns]({%slug gridview-columns-customizing-columns%})
 
 * [Column Groups]({%slug gridview-column-groups%})
