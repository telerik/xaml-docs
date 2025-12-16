---
title: Customize the UI programmatically
page_title: Customize the UI programmatically
description: Find out more about the two powerful extension methods which you can use to easily customize RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-customize-ui-programmatically
tags: customize,the,ui,programmatically
published: True
position: 4
---

# Customize the UI programmatically

You can manipulate the controls easily with two powerful extension methods: 

* __ParentOfType<>__ 
* __ChildrenOfType<>__.

>tip You can access all items currently available in RadGridView through __RadGridView.Items__ collection.

>Generally we do not recommend working with the visual elements as RadGridView is a virtualized control and its elements are reused as they go in and out the visual area. You can check the topic on [UI virtualization]({%slug radgridview-features-ui-virtualization%}) for further information. 

Here are several small demos for __RadGridView__:

* Get all grid rows:

```C#
	var rows = RadGridView1.ChildrenOfType<GridViewRow>();
```

* Get all grid cells:

```C#
	var cells= RadGridView1.ChildrenOfType<GridViewCell>();
```

* Get all grid header cells:

```C#
	var headerCells = RadGridView1.ChildrenOfType<GridViewHeaderCell>();
```


* Get (and show) new row:

```C#
	var newRow = RadGridView1.ChildrenOfType<GridViewNewRow>().First();
	newRow.Visibility = Visibility.Visible;
```


* Find the grid vertical scrollbar and scroll the grid to bottom:

```C#
	var verticalScrollBar = RadGridView1.ChildrenOfType<ScrollBar>().Where(s=>s.Orientation == Orientation.Vertical).First();
	verticalScrollBar.Value = verticalScrollBar.Maximum;
```

* Select specific row(s):

```C#

	var row = RadGridView1.ChildrenOfType<GridViewRow>().Where(r => r.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI").Any()).First();
	row.IsSelected = true;
```

* Change specific cell(s) content:


```C#

	var cell = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI").First();
	cell.Content = "Changed!";
```

* Put specific cell in edit mode:


```C#
	var cell = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI").First();
	cell.IsInEditMode = true;
```

* Get visible rows count on scroll or size change:
    

```C#

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
```

* Perform conditional row(s) formatting:
    

```C#

	var rows = RadGridView1.ChildrenOfType<GridViewRow>().Where(r => r.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI"|| c.Content.ToString() == "AROUT").Any()).ToList();
	rows.ForEach(r => r.Background = Brushes.Red);
```

* Expand first row in case of hierarchy:


```C#

	var expandableRow = RadGridView1.ChildrenOfType<GridViewExpandableRow>().First();
	expandableRow.IsExpanded = true;
```


* Collapse first group header row:


```C#

	var groupHeader = RadGridView1.ChildrenOfType<GridViewGroupRow>().First();
	groupHeader.ChildrenOfType<Expander>().First().IsExpanded = false;
```

* Modify background for all cells in specific column:   


```C#

	var unitPriceCells = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Column.UniqueName == "UnitPrice").ToList();
	unitPriceCells.ForEach(c => c.Background = Brushes.Orange);
```

* Increase header row Height:   


```C#
	var headerRow = RadGridView1.ChildrenOfType<GridViewHeaderRow>().First();
	headerRow.Height = 100;
```

* Check all CheckBox controls in specific column:


```C#

	var cells = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Column.UniqueName == "Test").ToList();
	cells.ForEach(c => c.ChildrenOfType<CheckBox>().First().IsChecked = true);
```

## See Also

 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})



