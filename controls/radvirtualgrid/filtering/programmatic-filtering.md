---
title: Programmatic Filtering
page_title: Programmatic Filtering
description: Programmatic Filtering
slug: virtualgrid-filtering-programmatic-filtering
tags: filtering, programmatic
published: True
position: 1
---

# Programmatic Filtering

__RadVirtualGrid__ provides an API for programmatically filtering its data. The following article will go through the exposed mechanisms.

> The __FilteringControl__ of __RadVirtualGrid__ can be manually closed by calling the __CloseFilteringControl__ method of the control.

>important The events that this section covers cannot be utilized when the __DataProvider__ mechanism is used for populating data. In such scenario, the built-in filtering can be altered through a [Custom DataProvider]({%slug virtualgrid-custom-dataprovider%}).

__RadVirtualGrid__ provides a set of events which can be utilized so that the filtering operation is aligned to the specific needs. They will be raised in the order they are listed below.

### DataMemberNeeded

It is raised when the control is initially loaded and data related information for the given column is needed. It can be provided through the following properties that the event arguments expose.

* __ColumnIndex__: Gives information regarding the index of the given column.

* __DataType__: Gives information regarding the data type of the underlying member. The property can also be set.

* __IsFilterable__: Provides information regarding whether the column generated for the given data member is filterable. The property can also be set.

* __IsSortable__: Provides information regarding whether the column generated for the given data member is sortable. The property can also be set.

* __MemberName__: Gives information regarding the name of the underlying data member. The property can also be set.

#### __[C#] Example 1: Subscribing to the DataMemberNeeded event__

{{region radvirtualgrid-filtering-programmatic-filtering_0}}
	private void VirtualGrid_DataMemberNeeded(object sender, DataMemberEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.IsFilterable = true;
                e.DataType = typeof(string);
                e.MemberName = "Name";
            }
        }
{{endregion}}

### DistinctValuesLoading

When the user clicks the filtering funnel, this event is raised as the __FilteringControl__ needs to be populated with the relevant distinct values. Achieving this can be done through the properties of the event arguments.

* __Cancel__: The event can be canceled by setting the property value to true.

* __ColumnIndex__: Provides information regarding the index of the column for which the distinct values are needed.

* __ItemsSource__: The property through which the distinct values required for the given column are provided.

#### __[C#] Example 2: Subscribing to the DistinctValuesLoading event__

{{region radvirtualgrid-filtering-programmatic-filtering_1}}
	private void VirtualGrid_DistinctValuesLoading(object sender, DistinctValuesLoadingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.ItemsSource = new List<string>() { "Chelsea", "Liverpool", "Arsenal" };
            }
        }
{{endregion}}

The end result after providing the needed distinct values will be as shown below.

#### __Figure 1: RadVirtualGrid populated with distinct values__
![Opening the FilteringControl of RadVirtualGrid](images/RadVirtualGrid_Programmatic_Filtering_02.png)

### FilterOperatorsLoading

After the required distinct values are loaded, the __FilteringControl__ provides a mechanism its filter operators to be manipulated. The event arguments expose the following properties.

* __AvailableOperators__: A readonly collection containing the available filter operators. It cannot be assigned and filter operators can only be removed from it.

* __ColumnIndex__: Providing information regarding the index for the column for which the filter operators are being loaded.

* __DefaultFilterOperator1__: Gets or sets the first default operator.

* __DefaultFilterOperator2__: Gets or sets the second default operator.

#### __[C#] Example 3: Subscribing to the FilterOperatorsLoading event__
{{region radvirtualgrid-filtering-programmatic-filtering_2}}
	 private void VirtualGrid_FilterOperatorsLoading(object sender, FilterOperatorsLoadingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.Contains;
                e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.DoesNotContain;
            }
        }
{{endregion}}

### FieldFilterEditorCreated

Raised when the FilteringControl loads the field filter editor. It provides the ability the default filter editor to be customized. This can be achieved through the properties of the event arguments.

* __ColumnIndex__: Gives information regarding the index of the column for which the filter editor has been created.

* __Editor__: The default field filter editor can be accessed. Also, this is the property through which a custom filter editor can be applied.

#### __[C#] Example 4: Subscribing to the FieldFilterEditorCreated event__

{{region radvirtualgrid-filtering-programmatic-filtering_3}}
	private void VirtualGrid_FieldFilterEditorCreated(object sender, FieldFilterEditorCreatedEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var editor = new RadWatermarkTextBox();
                editor.WatermarkContent = "Enter value";

                Binding editorBinding = new Binding("Value") { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged};
                BindingOperations.SetBinding(editor, RadWatermarkTextBox.TextProperty, editorBinding);

                e.Editor = editor;
            }
        }
{{endregion}}

### FilterOperatorsPreparing

It is triggered when the filter operators are being prepared. Here is the state at which the filtering can be canceled if needed. This can be done by setting the __Cancel__ property of the event arguments to __true_.

#### __[C#] Example 5: Subscribing to the FilterOperatorsPreparing event__

{{region radvirtualgrid-filtering-programmatic-filtering_4}}
	private void VirtualGrid_FilterDescriptorsPreparing(object sender, FilteringEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = true;
            }
        }
{{endregion}}

### FilterOperatorsPrepared

At this state the filter operators are ready and the filtering operation can be executed. The event arguments provide the properties listed below.

* __Added__: A collection of the added filter descriptor.

* __ColumnFilterDescriptor__: The filter descriptor generated for the given column.

* __ColumnIndex__: The index for which the filter operators have been loaded.

* __Removed__: The collection of removed filter operators.

#### __[C#] Example 6: Subscribing to the FilterOperatorsPrepared event__

{{region radvirtualgrid-filtering-programmatic-filtering_5}}
	private void VirtualGrid_FilterDescriptorsPrepared(object sender, FilteredEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                CompositeFilterDescriptorCollection compositeFilterDescriptorCollection = new CompositeFilterDescriptorCollection();
                compositeFilterDescriptorCollection.Add(e.ColumnFilterDescriptor);
                var clubs = clubsSource.AsQueryable().Where(compositeFilterDescriptorCollection).ToIList();
                this.VirtualGrid.InitialRowCount = clubs.Count;
            }
        }
{{endregion}}

Note, that in the example above, the __CompositeFilterDescriptorCollection__ is used for filtering the __underlying data source__. For this purpose, the __Where extension method__ which is defined within the __Telerik QueryableExtensions__ is utilized. More information can be found [here](https://docs.telerik.com/devtools/wpf/api/html/m_telerik_windows_data_queryableextensions_where_3.htm). After the filtering is evaluated for the data source, the __InitialRowCount__ of __RadVirtualGrid__ needs to be set so that it equals the number of items that have passed the filtering criteria.

## See Also

* [Filtering with DataProvider]({%slug virtualgrid-filtering-dataprovider%})