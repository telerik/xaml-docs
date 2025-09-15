---
title: Programmatic Sorting
page_title: Programmatic Sorting
description: Check our &quot;Programmatic Sorting&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-sorting-programmatic-sorting
tags: sorting, programmatic
published: True
position: 1
---

# Programmatic Sorting

__RadVirtualGrid__ provides an API for programmatically sorting its data. The following article will go through the events exposed for this purpose.

### DataMemberNeeded

It is raised when the control is initially loaded and data related information for the given column is needed. It can be provided through the following properties that the event arguments expose.

* __ColumnIndex__: Gives information regarding the index of the given column.

* __DataType__: Gives information regarding the data type of the underlying member. The property can also be set.

* __IsFilterable__: Provides information regarding whether the column generated for the given data member is filterable. The property can also be set.

* __IsSortable__: Provides information regarding whether the column generated for the given data member is sortable. The property can also be set.

* __MemberName__: Gives information regarding the name of the underlying data member. The property can also be set.

__Example 3: Subscribing to the DataMemberNeeded event__

```C#
	private void VirtualGrid_DataMemberNeeded(object sender, DataMemberEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.IsSortable = true;
                e.DataType = typeof(string);
                e.MemberName = "Name";
            }
        }
```

### SortDescriptorPreparing

Raised at the state when the user clicks the header of a given column and the relevant sort descriptor is being prepared. At this state, the sorting operation can be canceled. This is done through the __Cancel__ property of the event arguments.

__Example 1: Subscribing to the SortDescriptorPreparing event__

```C#
	private void VirtualGrid_SortDescriptorPreparing(object sender, SortingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
            }
        }
```

### SortDescriptorPrepared

It is raised when the sort descriptor is ready and the sorting operation can be executed. The event arguments provide the following properties.

* __ColumnIndex__: The index of the column for which the sort descriptor is prepared.

* __ColumnSortDescriptor__: Gets the generated __ColumnSortDescriptor__ for the given column.

* __SortDirection__: Provides information regarding the applied sorting state.

__Example 2: Subscribing to the SortDescriptorPrepared event__

```C#
	private void VirtualGrid_SortDescriptorPrepared(object sender, SortedEventArgs e)
        {
            SortDescriptorCollection sortDescriptorCollection = new SortDescriptorCollection();
            sortDescriptorCollection.Add(e.ColumnSortDescriptor);

            clubsSource.AsQueryable().Sort(sortDescriptorCollection);
        }
```

Note, that in the example above, the __SortDescriptorCollection__ is used for sorting the __underlying data source__. For this purpose, the __Sort__ extension method which is defined within the __Telerik QueryableExtensions__ is utilized. More information can be found [here](https://docs.telerik.com/devtools/wpf/api/telerik.windows.data.queryableextensions#Telerik_Windows_Data_QueryableExtensions_Sort_System_Linq_IQueryable_Telerik_Windows_Data_SortDescriptorCollection_). 

## See Also

* [Sorting with DataProvider]({%slug virtualgrid-sorting-dataprovider%})