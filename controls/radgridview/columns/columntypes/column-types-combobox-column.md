---
title: ComboBox Column
page_title: ComboBox Column
description: Learn how to edit cell values with the RadComboBox editor available in the ComboBox column of RadGridView - Telerik's WPF DataGrid.
slug: radgridview-columns-column-types-combobox-column
tags: combobox,column
published: True
position: 4
---

# ComboBox Column

The`GridViewComboBoxColumn` column derives from [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%}), which means that it inherits all of the functionality too. In addition, GridViewComboBoxColumn provides a `RadComboBox` editor for editing cell values. It also takes care to translate the `DataMemberBinding` value of the column to the corresponding `DisplayMemberPath` value of RadComboBox. 

>tip Typing on the keyboard in GridViewComboBoxColumn will point to the first item starting with the same character.

>important  __IsLightweightModeEnabled__ - introduced in __R2 2016__. Setting this property to __True__ is recommended when the __DataMemberBinding__ of the column is not a nested property. Its default value is __False__. When set to __True__, the new lightened lookup logic is triggered, thus the performance of GridViewComboBoxColumn is significantly increased. If the column`s DataMemberBinding is a nested property, the value of __IsLightweightModeEnabled__ is not respected.

Here is a list of the most important properties:

* `DataMemberBinding`&mdash;you should specify the property of the bound business object to relate to `SelectedValueMemberPath` from column's ItemsSource. 
* `ItemsSource`&mdash;specifies the data source for the RadComboBox editor. It also takes part when translating the DataMemberBinding to the DisplayMemberPath property.
* `ItemsSourceBinding`&mdash;allows binding editor's ItemsSource to a member of the bound data item.
* `DisplayMemberPath`&mdash;member path to display. It points to a field in the assigned collection to the ItemsSource property of GridViewComboBoxColumn.
* `SelectedValueMemberPath`&mdash;used in conjunction with DisplayMemberPath in the process of translation of a value to display as content. It also tells the RadComboBox editor which property to use as a Value when the user makes selection. 
* `IsComboBoxEditable`&mdash;allows you to configure whether the editor RadComboBox is editable.
* `EmptyText`&mdash;allows you to set a string which will be displayed in both view mode and edit mode when the RadComboBox editor does not have a selected item.
 
>important The __type__ of the properties configured as `DataMemberBinding` and `SelectedValueMemberPath` should be the same.
        
The following example assumes that you have data as shown in the below image:

__Sample data structure of RadGridView:__

![ItemsSource for the ComboBox Column in RadGridView - Telerik's WPF DataGrid](images/RadGridView_ColumnTypes_1.png)

#### __[XAML] Define GridViewComboBoxColumn in XAML__
{{region xaml-radgridview-columns-column-types-combobox-column_0}}
	<telerik:RadGridView x:Name="radGridView" AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewComboBoxColumn />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

#### __[XAML] Set the DataMemberBinding property in XAML__
{{region xaml-radgridview-columns-column-types-combobox-column_3}}
	<telerik:RadGridView AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewComboBoxColumn DataMemberBinding="{Binding CountryId}" UniqueName="Country" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

#### __[C#] Set the DataMemberBinding property in code__
{{region cs-radgridview-columns-column-types-combobox-column_4}}
	column.DataMemberBinding = new Binding("CountryId");
	column.UniqueName = "Country";
{{endregion}}

#### __[C#] Setting the ItemsSource property in code__
{{region cs-radgridview-columns-column-types-combobox-column_6}}
	((GridViewComboBoxColumn)this.radGridView.Columns["Country"]).ItemsSource = RadGridViewSampleData.GetCountries();
{{endregion}}

#### __[VB.NET] Setting the ItemsSource property in code__
{{region vb-radgridview-columns-column-types-combobox-column_7}}
	DirectCast(Me.radGridView.Columns("Country"), GridViewComboBoxColumn).ItemsSource = RadGridViewSampleData.GetCountries()
{{endregion}}

#### __[XAML] Configure DisplayMemberPath and SelectedValuePath properties in XAML__
{{region xaml-radgridview-columns-column-types-combobox-column_8}}
	<telerik:GridViewComboBoxColumn DataMemberBinding="{Binding CountryId}"
	                    UniqueName="Country"
	                    SelectedValueMemberPath="Id"
	                    DisplayMemberPath="Name" />
{{endregion}}

#### __[C#] Configure DisplayMemberPath and SelectedValuePath properties in code__
{{region cs-radgridview-columns-column-types-combobox-column_9}}
	column.SelectedValueMemberPath = "Id";
	column.DisplayMemberPath = "Name";
{{endregion}}

__ComboBoxColumn after setting DisplayMemberPath and SelectedValuePath properties__

![Setting up the ComboBox Column in RadGridView - Telerik's WPF DataGrid](images/RadGridView_ColumnTypes_2.png)

As illustrated in the above image, you can map __CountryId__ property of the business object to the respective value in Countries collection via configuring proper `DisplayMemberPath`.
      
You can download a runnable project of the previous example from our online SDK repository:[ComboboxColumn](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumn).
      
The next example shows how to use `ItemsSourceBinding`. It allows you to bind the `ItemsSource` of RadComboBox editor to a collection held by the data item. In this way, you are able to specify different sets of items depending on the entire content of the respective row. The example assumes that you have the data shown in the following image:

__Sample data structure of RadGridView__

![Binding the Telerik WPF DataGrid to a Collection of Objects](images/RadGridView_ColumnTypes_3.png)

`RadGridView` binds to a collection of objects representing the teams. The team object exposes a collection containing the current drivers, which is used as source for the editor. As in the previous example, it also exposes a __DriverID__ property that the column will later translate to an appropriate display value. 

#### __[XAML] Configure GridViewComboBoxColumn with ItemsSourceBinding__
{{region xaml-radgridview-columns-column-types-combobox-column_11}}
	<telerik:GridViewComboBoxColumn Header="Driver"
	                    DataMemberBinding="{Binding DriverID}"
	                    UniqueName="Driver"
	                    ItemsSourceBinding="{Binding CurrentDrivers}"
	                    SelectedValueMemberPath="ID"
	                    DisplayMemberPath="Name" />
{{endregion}}

The next images show the result of configuring the ItemsSourceBinding property.

__Appearance after setting ItemsSourceBinding property__

![ComboBox Column in RadGridView - Telerik's WPF DataGrid](images/RadGridView_ColumnTypes_4.png)

__Appearance after setting ItemsSourceBinding property.__

![ComboBox Column of RadGridView - Telerik's WPF DataGrid](images/RadGridView_ColumnTypes_5.png)

When using the ItemsSourceBinding property, the values displayed in the column’s filtering control will be the values corresponding to the DataMemberBinding (0, 1, 2). If you want to have the displayed ones (S.Vettel, K. Raikkonen, M. Webber), then you need to set GridViewComboBoxColumn. [FilterMemberPath]({%slug gridview-filtering-basic%}) to a property containing the values used as DisplayMemberPath.
        
You can download a runnable project of the previous example from our online SDK repository:[ComboboxColumnItemsSourceBinding](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumnItemsSourceBinding).
        
>If you are setting GridViewComboBoxColumn's ItemsSource property you should specify a valid source for it. Please refer to this [troubleshooting article]({%slug gridview-troubleshooting-blank-cells%}).

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. 
        
## Templating GridViewComboBoxColumn

The GridViewComboBoxColumn column exposes the `ItemTemplate` property, which also applies to the default editor - RadComboBox.

The following example shows how to implement a multi-column ComboBoxColumn.

Start by defining the GridViewComboBoxColumn and its ItemTemplate:

#### __[XAML] Configure GridViewComboBoxColumn with ItemTemplate__
{{region xaml-radgridview-columns-column-types-combobox-column_12}}
	<telerik:GridViewComboBoxColumn Header="City"
	                                DisplayMemberPath="Name"
	                                SelectedValueMemberPath="ID"
	                                ItemsSource="{Binding Path=Cities, Source={StaticResource MyViewModel}}"
	                                Width="\*"
	                                DataMemberBinding="{Binding CityID}" >
	    <telerik:GridViewComboBoxColumn.ItemTemplate>
	        <DataTemplate>
	            <Grid>
	                <Grid.ColumnDefinitions>
	                    <ColumnDefinition />
	                    <ColumnDefinition Width="\*"/>
	                </Grid.ColumnDefinitions>
	                <TextBlock Text="{Binding ID}"/>
	                <TextBlock Text="{Binding Name}" Grid.Column="1"/>
	            </Grid>
	        </DataTemplate>
	    </telerik:GridViewComboBoxColumn.ItemTemplate>
	</telerik:GridViewComboBoxColumn>
{{endregion}}

The multi-column ComboBoxColumn in this example will have two columns showing the ID and Name of the City respectively. When you run the example, Figure 6 shows the result when the customer tries to edit in a column.

__Multi-select GridViewColumnComboBox column in RadGridView__

![MultiColumnComboBox Column in RadGridView - Telerik's WPF DataGrid](images/gridview_multi_column_combo.png)

## See Also
 * [Binding GridViewComboBoxColumn by using the EnumDataSource utility]({%slug consuming-data-enumdatasource%})
 * [Empty Cells in ComboboxColumn]({%slug gridview-troubleshooting-blank-cells%})
 * [Handle SelectionChanged for ComboBoxColumn]({%slug gridview-columns-howto-selectionchanged-comboboxcolumn%})
 * [Filter items in ComboboxColumn]({%slug gridview-columns-how-to-filter-the-items-in-comboboxcolumn%})
 * [Number of clicks in the ComboBoxColumn]({%slug gridview-combobox-column-clicks%})