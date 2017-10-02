---
title: Custom DataProvider
page_title: Custom DataProvider
description: Custom DataProvider
slug: virtualgrid-custom-dataprovider
tags: dataprovider
published: True
position: 3
---

# Custom DataProvider

The __DataProvider__ functionality of __RadVirtualGrid__ exposes various mechanisms for extending the default behavior. This can be achieved by inheriting the __DataProvider__ object and overriding its methods or properties.

#### __[C#] Example 1: Defining a Custom DataProvider__

{{region radvirtualgrid-features_customdataprovider_0}}
	public class CustomDataProvider: DataProvider
    {
        public CustomDataProvider(IEnumerable source)
            :base(source)
        {
 
        }
    }
{{endregion}}

#### __[C#] Example 2: Applying the Custom DataProvider__

{{region radvirtualgrid-features_customdataprovider_1}}
	this.VirtualGrid.DataProvider = 
                new CustomDataProvider(Club.GetClubs());
{{endregion}}

#### __Figure 1: RadVirtualGrid with applied custom DataProvider__

![RadVirtualGrid with applied custom DataProvider](images/RadVirtualGrid_Features_CustomDataProvider_01.png)

By inheriting the default __DataProvider__, the following methods and properties are exposed for customization.

### Properties

* __InitialRowCount__: If not overriden, gets the value that is set to the __InitialRowCount__ property of __RadVirtualGrid__.

* __InitialColumnCount__: If not overriden, gets the value that is set to the __InitialRowCount__ property of __RadVirtualGrid__.

* __ShouldPushEditValueToGrid__: When an editor is provided for the [Editing]({%slug virtualgrid-editing%}) operation, its edited value needs to be manually pushed to underlying source and to the grid through its __PushCellValue__ method. If the __ShouldPushEditValueToGrid__ property is overriden and returns a __True__ value, updating the control with the edited property value will be done automatically.

* __DistinctValuesLimit__: By default, its value is set to 1000. Through it, the maximum count of distinct values in the __FilteringControl__ can be manipulated.

### Methods

* __OnCellEditEnded__: The method that is called when the __CellEditEnded__ event is raised.

* __OnCellValueNeeded__: The method that is called when the __CellValueNeeded__ event is raised.

* __OnEditorNeeded__: The method that is called when the __EditorNeeded__ event is raised.

* __OnEditorValueChanged__: The method that is called when the __EditorValueChanged__ event is raised.

* __OnHeaderValueNeeded__: The method that is called when the __HeaderValueNeeded__ event is raised.

* __DistinctValuesLoading__: Occurs when the grid column distinct values are about to be loaded. 

* __FilterOperatorsLoading__: The method is invoked when the __FilterOperators__ for a given column are being loaded.

* __SortDescriptorPreparing__: The method is called when the __SortDescriptors__ are being prepared.

* __SortDescriptorPrepared__: The method is called when the __SortDescriptors__ are prepared and a sort operation will occur.

* __OnSortingCompleted__: The method is called when the sort operation is completed. 

* __FilterDescriptorPreparing__: The method is called when the __FilterDescriptors__ are being prepared.

* __FilterDescriptorPrepared__: The method is called when the __FilterDescriptors__ are prepared and a filter operation will occur.

* __OnFilteringCompleted__: The method is called when the filter operation is completed. 

* __ApplyFilterDescriptor__: Adds the filter descriptor to the __Source QCV__, which is the collection used for the data operations of the provider.

* __ApplySortDescriptor__: Adds the sort descriptor to the __Source QCV__, which is the collection used for the data operations of the provider.

* __RemoveColumnFilter__: Removes the given filter descriptor from the __Source QCV__.

* __IsColumnReadOnly__: Determines whether a given column is ReadOnly. 

* __RemoveItemsFromSource__: Removes a set of items from the underlying source.

## See Also

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})

* [Pinned Rows and Columns]({%slug virtualgrid-pinned-rows-and-columns%})
