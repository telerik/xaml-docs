---
title: Display RadGridView Row Details in RadWindow
page_title: Display RadGridView Row Details in RadWindow
description: Display RadGridView Row Details in RadWindow
slug: gridview-how-to-display-row-details-window
tags: display,radgridview,row,details,in,radwindow
published: True
position: 1
---

# Display RadGridView Row Details in RadWindow

As you know, in order to display Row Details outside [RadGridView](http://www.telerik.com/products/silverlight/gridview.aspx), you need to place a [DetailsPresenter](http://www.telerik.com/help/silverlight/telerik.windows.controls.gridview-telerik.windows.controls.gridview.detailspresenter.html) control somewhere around [RadGridView](http://www.telerik.com/products/silverlight/gridview.aspx) and wire them up. Well, it does not need to be around, really. This article will show how to place it in Telerik’s [RadWindow](https://demos.telerik.com/silverlight/#Window/FirstLook): 

#### __C#__

{{region cs-gridview-how-to-display-row-details-window_0}}
	this.DataContext = new FootballViewModel();
	
	this.window = new RadWindow();
	this.window.Content = new DetailsPresenter()
	{
	    // Link the external details presenter to our RadGridView.
	    DetailsProvider = this.clubsGrid.RowDetailsProvider
	};
	this.window.WindowStartupLocation = WindowStartupLocation.Manual;
	this.window.Header = "Players";
	this.window.ResizeMode = ResizeMode.NoResize;
	this.clubsGrid.RowDetailsProvider.PropertyChanged += this.OnRowDetailsProviderPropertyChanged;
{{endregion}}

The [DetailsPresenter](http://www.telerik.com/help/silverlight/telerik.windows.controls.gridview-telerik.windows.controls.gridview.detailspresenter.html) cares about three things – what is the [DataTemplate](http://msdn.microsoft.com/en-us/library/system.windows.datatemplate.aspx) it needs to load, whether it is visible or not, and what is its [DataContext](http://msdn.microsoft.com/en-us/library/system.windows.frameworkelement.datacontext.aspx). All this information comes through its [DetailsProvider](http://www.telerik.com/help/silverlight/telerik.windows.controls.gridview-telerik.windows.controls.gridview.detailspresenter-detailsprovider.html) property which is assigned from [RadGridView](http://www.telerik.com/products/silverlight/gridview.aspx)’s respective property [RowDetailsProvider](http://www.telerik.com/help/silverlight/telerik.windows.controls.gridview-telerik.windows.controls.gridview.gridviewdatacontrol-rowdetailsprovider.html). This means that this particular [DetailsPresenter](http://www.telerik.com/help/silverlight/telerik.windows.controls.gridview-telerik.windows.controls.gridview.detailspresenter.html) will be fed by this particular [RadGridView](http://www.telerik.com/products/silverlight/gridview.aspx). Let’s take a look at the interface:

#### __C#__

{{region cs-gridview-how-to-display-row-details-window_1}}
	public interface IDetailsProvider : INotifyPropertyChanged
	{
	    DataTemplate Template { get; }
	    Visibility Visibility { get; }
	    object DataContext { get; }
	    //Rest of the code is omitted
	}
{{endregion}}

As you can see, it inherits from the [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged.aspx) interface. Each time a row is selected in [RadGridView](http://www.telerik.com/products/silverlight/gridview.aspx), the [DataContext](http://msdn.microsoft.com/en-us/library/system.windows.frameworkelement.datacontext.aspx) of the [DetailsProvider](http://www.telerik.com/help/silverlight/telerik.windows.controls.gridview-telerik.windows.controls.gridview.detailspresenter-detailsprovider.html) changes. The [DetailsPresenter](http://www.telerik.com/help/silverlight/telerik.windows.controls.gridview-telerik.windows.controls.gridview.detailspresenter.html) listens for these property changes and updates as needed. We can listen for a [PropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged.propertychanged.aspx) ourselves and position the window accordingly:

#### __C#__

{{region cs-gridview-how-to-display-row-details-window_2}}
	private void OnRowDetailsProviderPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
	{
	    if (e.PropertyName == "DataContext")
	    {
	        // This indicates that selection has changed in RadGridView.
	        Club currentClub = this.clubsGrid.RowDetailsProvider.DataContext as Club;
	        if (currentClub != null)
	        {
	            // A row is selected.
	            var row = this.clubsGrid.ItemContainerGenerator.ContainerFromItem(currentClub) as GridViewRow;
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
	    throw new NotImplementedException();
	}
{{endregion}}

That’s about all you need to do. You can download a sample project from [here](http://blogs.telerik.com/Libraries/RossenHristov/RowDetailsInRadWindowSources.sflb).

## See Also

 * [RowDetails - Overview]({%slug radgridview-row-details-overview%})[RadWindow - Overview](B911CE0E-1A02-44B8-BA96-5FCDF57E0E9B)
