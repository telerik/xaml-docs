---
title: Customize the UI programmatically
page_title: Customize the UI programmatically
description: Customize the UI programmatically
slug: gridview-how-to-customize-ui-programmatically
tags: customize,the,ui,programmatically
published: True
position: 4
---

# Customize the UI programmatically

You can manipulate the controls easily with two powerful extension methods: 

* __ParentOfType<>__ 
* __ChildrenOfType<>__.

>tipYou can access all items currently available in RadGridView through __RadGridView.Items__ collection.

>Generally we do not recommend working with the visual elements as RadGridView is a virtualized control and its elements are reused as they go in and out the visual area. You can check the topic on [UI virtualization]({%slug radgridview-features-ui-virtualization%}) for further information. 

Here are several small demos for __RadGridView__:

* Get all grid rows:

#### __C#__
{{region gridview-how-to-customize-ui-programmatically_0}}

	var rows = RadGridView1.ChildrenOfType<GridViewRow>();
{{endregion}}

* Get all grid cells:

#### __C#__
{{region gridview-how-to-customize-ui-programmatically_1}}

	var cells= RadGridView1.ChildrenOfType<GridViewCell>();
{{endregion}}

* Get all grid header cells:

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_2}}

	var headerCells = RadGridView1.ChildrenOfType<GridViewHeaderCell>();
{{endregion}}


* Get (and show) new row:

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_3}}

	var newRow = RadGridView1.ChildrenOfType<GridViewNewRow>().First();
	newRow.Visibility = Visibility.Visible;
{{endregion}}


* Find the grid vertical scrollbar and scroll the grid to bottom:

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_4}}

	var verticalScrollBar = RadGridView1.ChildrenOfType<ScrollBar>().Where(s=>s.Orientation == Orientation.Vertical).First();
	verticalScrollBar.Value = verticalScrollBar.Maximum;
{{endregion}}

* Select specific row(s):

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_5}}

	var row = RadGridView1.ChildrenOfType<GridViewRow>().Where(r => r.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI").Any()).First();
	row.IsSelected = true;
{{endregion}}

* Change specific cell(s) content:

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_6}}

	var cell = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI").First();
	cell.Content = "Changed!";
{{endregion}}

* Put specific cell in edit mode:

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_7}}
	var cell = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI").First();
	cell.IsInEditMode = true;
	{{endregion}}

* Get visible rows count on scroll or size change:
    
#### __C#__

{{region gridview-how-to-customize-ui-programmatically_8}}

	void Window1_Loaded(object sender, RoutedEventArgs e)
	{
	    var verticalScrollBar = RadGridView1.ChildrenOfType<ScrollBar>().Where(s => s.Orientation == Orientation.Vertical).First();
	    verticalScrollBar.SizeChanged += new SizeChangedEventHandler(verticalScrollBar_SizeChanged);
	    verticalScrollBar.Scroll += new ScrollEventHandler(verticalScrollBar_Scroll);
	}
	void verticalScrollBar_SizeChanged(object sender, SizeChangedEventArgs e)
	{
	    var visibleRowsCount = RadGridView1.ChildrenOfType<GridViewRow>().Where(r => r.Visibility == Visibility.Visible).Count();
	}
	void verticalScrollBar_Scroll(object sender, ScrollEventArgs e)
	{
	    var visibleRowsCount = RadGridView1.ChildrenOfType<GridViewRow>().Where(r => r.Visibility == Visibility.Visible).Count();
	}
{{endregion}}

* Perform conditional row(s) formatting:
    
#### __C#__

{{region gridview-how-to-customize-ui-programmatically_9}}

	var rows = RadGridView1.ChildrenOfType<GridViewRow>().Where(r => r.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI"|| c.Content.ToString() == "AROUT").Any()).ToList();
	rows.ForEach(r => r.Background = Brushes.Red);
{{endregion}}

* Expand first row in case of hierarchy:

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_10}}

	var expandableRow = RadGridView1.ChildrenOfType<GridViewExpandableRow>().First();
	expandableRow.IsExpanded = true;
{{endregion}}


* Collapse first group header row:

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_11}}

	var groupHeader = RadGridView1.ChildrenOfType<GridViewGroupRow>().First();
	groupHeader.ChildrenOfType<Expander>().First().IsExpanded = false;
{{endregion}}

* Modify background for all cells in specific column:   

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_12}}

	var unitPriceCells = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Column.UniqueName == "UnitPrice").ToList();
	unitPriceCells.ForEach(c => c.Background = Brushes.Orange);
{{endregion}}

* Increase header row Height:   

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_13}}
	var headerRow = RadGridView1.ChildrenOfType<GridViewHeaderRow>().First();
	headerRow.Height = 100;
{{endregion}}

* Check all CheckBox controls in specific column:

#### __C#__

{{region gridview-how-to-customize-ui-programmatically_14}}

	var cells = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Column.UniqueName == "Test").ToList();
	cells.ForEach(c => c.ChildrenOfType<CheckBox>().First().IsChecked = true);
{{endregion}}

## See Also

 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})



