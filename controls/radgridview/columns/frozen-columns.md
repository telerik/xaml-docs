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

__RadGridView__ provides an easy way to select one or more columns and exclude them from the horizontal scrolling. The frozen columns stay static on top of the horizontal scrolling. To freeze a column, the user has to drag the frozen columns separator.

![Rad Grid View Frozencolumns 1](images/RadGridView_Frozencolumns_1.png)

Once there is a frozen column, you can freeze other columns by dragging their headers behind the frozen columns separator.

![Rad Grid View Frozencolumns 2](images/RadGridView_Frozencolumns_2.png)

Similarly, you can unfreeze columns by dragging their headers outside the frozen columns separator.

A frozen column always stays on top of horizontal scrolling.

![Rad Grid View Frozencolumns 3](images/RadGridView_Frozencolumns_3.png)

## Freezing Columns

You can freeze columns programmatically using the __FrozenColumnCount__ property of the __RadGridView__ control. The property is numeric and you have to set it to the number of columns you wish to freeze.

In __Example 1__, the first two columns are frozen starting from left to right.

#### __[XAML] Example 1: Setting FrozenColumnCount__

{{region xaml-gridview-columns-frozen-columns_0}}
	<telerik:RadGridView FrozenColumnCount="2" />
{{endregion}}

#### __[C#] Example 1: Setting FrozenColumnCount__

{{region cs-gridview-columns-frozen-columns_1}}
	this.radGridView.FrozenColumnCount = 2;
{{endregion}}

#### __[VB.NET] Example 1: Setting FrozenColumnCount__

{{region vb-gridview-columns-frozen-columns_2}}
	Me.radGridView.FrozenColumnCount = 2
{{endregion}}

## Disabling Frozen Columns

To disable the freezing of a column, just set the __CanUserFreezeColumns__ to __False__ (as shown in Example 2) and the frozen columns separator will disappear.

#### __[XAML] Example 2: Disabling Frozen Columns__

{{region xaml-gridview-columns-frozen-columns_3}}
	<telerik:RadGridView x:Name="radGridView"
	             CanUserFreezeColumns="False" />
{{endregion}}

![Rad Grid View Frozencolumns 4](images/RadGridView_Frozencolumns_4.png)

## Hiding the Frozen Columns Splitter

You can set the **FrozenColumnsSplitterVisibility** property of the __RadGridView__ control in order to hide/show the frozen columns splitter.

The property has one of three values:

* **Visible:** Displays the element.
* **Hidden:** Does not display the element, but reserves space for the element in the layout.
* **Collapsed:** Does not display the element, and does not reserve space for it in the layout.

#### __Figure 1: FrozenColumnsSplitterVisibility set to Visible and Hidden/Collapsed, respectively__

![FrozenColumnsSplitterVisibility="Visible"](images/FrozenColumnsSplitterVisibility_Visible.png)
![FrozenColumnsSplitterVisibility="Hidden"](images/FrozenColumnsSplitterVisibility_Hidden.png)

## Frozen Columns Events

As of R1 2016, we've added the __FrozenColumnsChanged__ event which is fired whenever columns are frozen or unfrozen.

__Example 3__ shows that you can subscribe to the event either declaratively or at runtime like this:

#### __[XAML] Example 3: Subscribing to the FrozenColumnsChanged Event__

{{region xaml-gridview-columns-frozen-columns_4}}
	<telerik:RadGridView x:Name="gridView"
	             FrozenColumnsChanged="gridView_FrozenColumnsChanged" />
{{endregion}}

#### __[C#] Example 3: Subscribing to the FrozenColumnsChanged Event__

{{region cs-gridview-columns-frozen-columns_5}}
	gridView.FrozenColumnsChanged += new EventHandler<FrozenColumnsChangedEventArgs>(gridView_FrozenColumnsChanged);
{{endregion}}

#### __[VB.NET] Example 3: Subscribing to the FrozenColumnsChanged Event__

{{region vb-gridview-columns-frozen-columns_6}}
	AddHandler Me.gridView.FrozenColumnsChanged, AddressOf gridView_FrozenColumnsChanged
{{endregion}}

Via the FrozenColumnsChangedEventArgs, you can get the:

* __AddedFrozenColumns__ - the columns that were added to the collection of frozen columns

* __RemovedFrozenColumns__ - the columns that were removed from the collection of frozen columns

* __AllFrozenColumns__ - the collection of frozen columns

__Example 4__ shows how you can get the names of the columns currently in the frozen columns collection as well as the columns added or removed from it.

#### __[C#] Example 4: Using the FrozenColumnsChanged Event__

{{region cs-gridview-columns-frozen-columns_7}}
	private void gridView_FrozenColumnsChanged(object sender, Telerik.Windows.Controls.GridView.GridView.FrozenColumnsChangedEventArgs e)
	{
	    var msg = "Added: " + string.Join(", ", e.AddedFrozenColumns.Select(x => x.UniqueName)) +
	        "\nRemoved: " + string.Join(", ", e.RemovedFrozenColumns.Select(x => x.UniqueName)) +
	        "\nAll: " + string.Join(", ", e.AllFrozenColumns.Select(x => x.UniqueName));
	    MessageBox.Show(msg);
	}
{{endregion}}


#### __[VB.NET] Example 4: Using the FrozenColumnsChanged Event__

{{region vb-gridview-columns-frozen-columns_8}}
	Private Sub gridView_FrozenColumnsChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridView.GridView.FrozenColumnsChangedEventArgs)
	    Dim msg = "Added: " & String.Join(", ", e.AddedFrozenColumns.Select(Function(x) x.UniqueName)) & ControlChars.Lf & "Removed: " & String.Join(", ", e.RemovedFrozenColumns.Select(Function(x) x.UniqueName)) & ControlChars.Lf & "All: " & String.Join(", ", e.AllFrozenColumns.Select(Function(x) x.UniqueName))
	    MessageBox.Show(msg)
	End Sub
{{endregion}}

![Rad Grid View FrozenColumnsChanged 1](images/RadGridView_FrozenColumnsChanged_1.png)
![Rad Grid View FrozenColumnsChanged 2](images/RadGridView_FrozenColumnsChanged_2.png)

## See Also

 * [RadGridView Overview]({%slug gridview-overview2%})

 * [Bound/Unbound Columns]({%slug gridview-columns-bound-unbound-columns%})

 * [Customizing Columns]({%slug gridview-columns-customizing-columns%})
 
 * [Column Groups]({%slug gridview-column-groups%})
