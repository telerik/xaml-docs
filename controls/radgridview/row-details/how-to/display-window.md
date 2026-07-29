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

<snippet id='radgridview-row-details-how-to-display-window-example_1_creating_a_radwindow_and_setting_a_detailspresenter_as_its_content-cs' />


The DetailsPresenter cares about three things – what is the [DataTemplate](http://msdn.microsoft.com/en-us/library/system.windows.datatemplate.aspx) it needs to load, whether it is visible or not, and what is its [DataContext](http://msdn.microsoft.com/en-us/library/system.windows.frameworkelement.datacontext.aspx). All this information comes through its **DetailsProvider** property which is assigned from RadGridView's respective property **RowDetailsProvider**. This means that this particular DetailsPresenter will be fed by this particular RadGridView. Let’s take a look at the interface:

__Example 2: The IDetailsProvider interface__

<snippet id='radgridview-row-details-how-to-display-window-example_2_the_idetailsprovider_interface-cs' />


As you can see, it implements the [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged.aspx) interface. Each time a row is selected in RadGridView, the DataContext of the DetailsProvider changes. The DetailsPresenter listens for these property changes and updates as needed. We can listen for a PropertyChanged ourselves and position the window accordingly.

__Example 3: Handling the PropertyChanged event__

<snippet id='radgridview-row-details-how-to-display-window-example_3_handling_the_propertychanged_event-cs' />


That's about all you need to do to display the row details in a separate window.

## See Also

* [RowDetails - Overview]({%slug radgridview-row-details-overview%})
* [External Row Details]({%slug radgridview-row-details-external-row-details%})
