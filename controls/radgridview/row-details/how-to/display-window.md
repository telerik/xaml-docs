---
title: Display RadGridView Row Details in RadWindow
page_title: Display Row Details in RadWindow
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to display Row Details in RadWindow.
slug: gridview-how-to-display-row-details-window
tags: display,radgridview,row,details,in,radwindow
published: True
position: 1
---

# Display Row Details in RadWindow

As explained in the [External Row Details]({%slug radgridview-row-details-external-row-details%}) article, in order to display the row details outside of the RadGridView control, you need to place a **DetailsPresenter** control somewhere around RadGridView and wire them up. Well, it does not need to be around, really. This article will show how to place it in a [RadWindow]({%slug radwindow-getting-started%}) control and position it next to the selected row.

__Example 1: Creating a RadWindow and setting a DetailsPresenter as its Content__

```C#
	private void Grid_Loaded(object sender, RoutedEventArgs e)
	{
	    this.window = new RadWindow();
	    this.window.Content = new DetailsPresenter()
	    {
		// Link the external details presenter to our RadGridView.
		DetailsProvider = this.clubsGrid.RowDetailsProvider
	    };
	    this.window.WindowStartupLocation = Telerik.Windows.Controls.WindowStartupLocation.Manual;
	    this.window.Header = "Row Details";
	    this.window.ResizeMode = ResizeMode.NoResize;
	    this.Grid.RowDetailsProvider.PropertyChanged += this.OnRowDetailsProviderPropertyChanged;
	}
```

The DetailsPresenter cares about three things – what is the [DataTemplate](http://msdn.microsoft.com/en-us/library/system.windows.datatemplate.aspx) it needs to load, whether it is visible or not, and what is its [DataContext](http://msdn.microsoft.com/en-us/library/system.windows.frameworkelement.datacontext.aspx). All this information comes through its **DetailsProvider** property which is assigned from RadGridView's respective property **RowDetailsProvider**. This means that this particular DetailsPresenter will be fed by this particular RadGridView. Let’s take a look at the interface:

__Example 2: The IDetailsProvider interface__

```C#
	public interface IDetailsProvider : INotifyPropertyChanged
	{
	    DataTemplate Template { get; }
	    Visibility Visibility { get; }
	    object DataContext { get; }
	    //Rest of the code is omitted
	}
```

As you can see, it implements the [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged.aspx) interface. Each time a row is selected in RadGridView, the DataContext of the DetailsProvider changes. The DetailsPresenter listens for these property changes and updates as needed. We can listen for a PropertyChanged ourselves and position the window accordingly.

__Example 3: Handling the PropertyChanged event__

```C#
	private void OnRowDetailsProviderPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
	{
	    if (e.PropertyName == "DataContext")
	    {
	        // This indicates that selection has changed in RadGridView.
	        var currentItem = this.clubsGrid.RowDetailsProvider.DataContext;
	        if (currentItem != null)
	        {
	            // A row is selected.
	            var row = this.Grid.ItemContainerGenerator.ContainerFromItem(currentItem) as GridViewRow;
	            Point newLocation = this.CalculateWindowLocation(row);
	            // Show the window next to the row on the right
	            this.window.Left = newLocation.X;
	            this.window.Top = newLocation.Y;
	            this.window.Show();
	        }
	        else
	        {
	            // There is no selection.
	            this.window.Close();
	        }
	    }
	}
	
	private Point CalculateWindowLocation(GridViewRow row)
	{
            var lastCell = row.Cells[row.Cells.Count - 1];
            GeneralTransform generalTransform = lastCell.TransformToVisual(this.LayoutRoot);
            return generalTransform.Transform(new Point(lastCell.ActualWidth + 10, 0));
	}
```

That's about all you need to do to display the row details in a separate window.

## See Also

* [RowDetails - Overview]({%slug radgridview-row-details-overview%})
* [External Row Details]({%slug radgridview-row-details-external-row-details%})
