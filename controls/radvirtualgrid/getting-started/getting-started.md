---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: virtualgrid-getting-started2
tags: getting,started
published: True
position: 0
---

# Getting Started

This tutorial will walk you through the required steps for using __RadVirtualGrid__. 

* [Assembly References](#assembly-references)
* [Adding RadVirtualGrid to the Project](#adding-radvirtualgrid-to-the-project)
* [Populating with Data](#populating-with-data-manually)
* [Populating with Data through DataProvider](#populating-with-data-through-dataprovider)
* [Resetting the Capacity to the Initial Row and Column Count](#resetting-the-capacity-to-the-initial-row-and-column-count)
* [MeasureTextOnRender](#measuretextonrender)


## Assembly References

In order to use __RadVirtualGrid__ in your application, you need to add references to the following assemblies:

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.VirtualGrid__
* __Telerik.Windows.Data__

## Adding RadVirtualGrid to the Project

#### __[XAML] Example 1: Defining RadVirtualGrid Declaratively__
{{region radvirtualgrid-gettingstarted_0}}
	 <telerik:RadVirtualGrid x:Name="VirtualGrid"/>
{{endregion}}

## Populating with Data through DataProvider

>important When populating data with a __DataProvider__, it handles most of the operations of __RadVirtualGrid__ out-of-the-box. Thus, the events that are  intended to be used for manually populating and manipulating the data of the control will not be raised.

Instead of using the __CellValueNeeded__ event, __RadVirtualGrid__ provides an option to populate its data through the built-in __DataProvider__ mechanism. The __DataProvider__ object accepts an IEnumerable through its constructor and can be applied to __RadVirtualGrid__ through its relevant property.

#### __[C#] Example 4: Applying a DataProvider__

{{region radvirtualgrid-gettingstarted_3}}
	this.VirtualGrid.DataProvider = new Telerik.Windows.Controls.VirtualGrid.DataProvider(this.myCollection);
{{endregion}}

> The __DataProvider__ mechanism is intended to cover basic scenarios for populating the control with data. For extending the default behavior, __RadVirtualGrid__ provides support for [Custom DataProvider]({%slug virtualgrid-custom-dataprovider%})

## Populating with data manually

> In order the control to be populated with data, its [InitialRowCount and InitialColumnCount](#setting-initial-row-and-column-count) properties need to be set.

__RadVirtualGrid__ needs to be initially defined with fixed amount of rows and columns. The below listed properties are exposed for achieving this. An important note is that when additional rows or columns are  added at runtime, the values of these properties remain unmodified, but the capacity of the control increases. More information on inserting rows and columns can be found in the [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%}) topic.

* __InitialRowCount__: Gets or sets the amount of initially loaded rows

* __InitialColumnCount__: Gets or sets the amount of initially loaded columns

#### __[XAML] Example 2: Setting the InitialRowCount and InitialColumnCount properties__

{{region radvirtualgrid-gettingstarted_1}}
	<telerik:RadVirtualGrid x:Name="VirtualGrid" 
                                InitialColumnCount="5" 
                                InitialRowCount="5"/>
{{endregion}}

The control populates its data through the __CellValueNeeded__ event. It is raised when the control is initially loaded and when newly data is about to be loaded on demand when the user scrolls horizontally or vertically. The event arguments expose the following properties:

### CellValueNeeded

* __CellIndex__: Provides information regarding the index of the currently loaded cell.

* __RowIndex__: Provides information regarding the index of the currently loaded row.

* __Value__: Through it the needed value for the respective cell can be set.

#### __[C#] Example 3: Populating RadVirtualGrid with data through the CellValueNeeded event__

{{region radvirtualgrid-gettingstarted_2}}
	private void virtualGrid_CellValueNeeded(object sender, 
            Telerik.Windows.Controls.VirtualGrid.CellValueEventArgs e)
        {
            e.Value = String.Format("{0}.{1}", e.RowIndex, e.ColumnIndex);
        }
{{endregion}}

#### __Figure 1: RadVirtualGrid populated with data__
![RadVirtualGrid populated with data](images/RadVirtualGrid_GettingStarted_01.png)

## Resetting the Capacity to the Initial Row and Column Count

As inserting rows and columns does not affect the __InitialRowCount__ and __InitialColumnCount__ properties, __RadVirtualGrid__ supports resetting its capacity to the values that are set to them. This can be done through the following methods:

* __Reset()__: Resets the capacity of the control to the values of the __InitialRowCount__ and __InitialColumnCount__ properties.

* __Reset(int rowCount, int columnCount)__: Through this overload of the Reset method, the capacity of __RadVirtualGrid__ can be reset to values different from the ones initially set to the __InitialRowCount__ and __InitialColumnCount__ properties. Furthermore, the two properties will be updated accordingly.

## MeasureTextOnRender

This property indicates whether the text is measured on rendering. Its default value is __False. When set to __True__, the usage of the __FitColumnWidthToContent__ and __CellTextAlignment__ mechanisms is enabled. Note, that this may affect the performance of the control.

## See also

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})

* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})

* [Custom Data Provider]({%slug virtualgrid-custom-dataprovider%})



