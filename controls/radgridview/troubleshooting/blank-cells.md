---
title: Empty Cells in Combobox column
page_title: Empty Cells in Combobox column
description: Empty Cells in Combobox column
slug: gridview-troubleshooting-blank-cells
tags: empty,cells,in,combobox,column
published: True
position: 7
---

# Empty Cells in Combobox column

__PROBLEM__

When you use the [GridViewComboBoxColumn]({%slug radgridview-columns-column-types-combobox-column%}) you might encounter empty cells in that column:

![](images/gridview_troubleshoot_blank_cells.png)

__CAUSE__

First you need to check

* the __Output for Binding exceptions__

* if the __types are of the same type__

If you do not encounter any of the above mentioned problems, then probably you use ElementName binding for that column, e.g.

#### __XAML__

{{region gridview-troubleshooting-blank-cells_0}}

	<telerik:GridViewComboBoxColumn Header="Category"
	        DataMemberBinding="{Binding CategoryID}"
	        ItemsSource="{Binding Path=DataContext.Categories, ElementName=RootElement}"
	        DisplayMemberPath="CategoryName"
	        SelectedValueMemberPath="CategoryID" />
{{endregion}}

This will not work, as the DataContext of the cell would not be the ViewModel, but the business object related to the row instead. We do not recommend such approach.

__SOLUTION__

There are two ways of solving the issue : 

1. Expose the ViewModel as a static resource on the page so that it can be easily accessible by the binding:

#### __XAML__

{{region gridview-troubleshooting-blank-cells_1}}

	<UserControl.Resources>
	    <local:MainPageViewModel x:Key="mainPageViewModel" />
	</UserControl.Resources>
	...
	<telerik:GridViewComboBoxColumn Header="Category"
            DataMemberBinding="{Binding CategoryID}"
            ItemsSource="{Binding Path=Categories, Source={StaticResource mainPageViewModel}}"
            DisplayMemberPath="CategoryName"
            SelectedValueMemberPath="CategoryID" />
{{endregion}}

2. Set the ItemsSource of the combo column in code behind instead of binding it in XAML:

#### __C#__

{{region gridview-troubleshooting-blank-cells_2}}

	private void gridView_DataLoaded(object sender, EventArgs e)
	{
	     (gridView.Columns["Category"] as GridViewComboBoxColumn).ItemsSource = GetCategories();
	}
{{endregion}}


