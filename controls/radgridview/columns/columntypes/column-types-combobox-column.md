---
title: ComboBox Column
page_title: ComboBox Column
description: ComboBox Column
slug: radgridview-columns-column-types-combobox-column
tags: combobox,column
published: True
position: 4
---

# ComboBox Column

__GridViewComboBoxColumn__ derives from [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%}), which means that it inherits all of the functionality too. In addition, GridViewComboBoxColumn provides a __RadComboBox__ editor for editing cell values. It also takes care to translate the __Data Member__ value of the column to the corresponding __DisplayMember__ value of __RadComboBox__. 

Here is a list of the most important properties:

* __DataMemberBinding__ - you should specify the property of the bound business object to relate to __SelectedValueMemberPath__ from column's ItemsSource. 

* __ItemsSource__ - specifies the data source for the __RadComboBox__ editor. It also takes part when translating the __Data Member__ to the __Display__ member.

* __ItemsSourceBinding__ - allows binding editor's __ItemsSource__ to a member of the bound data item.

* __DisplayMemberPath__ - member path to display. It points to a field in the  assigned __GridViewComboBoxColumn.ItemsSource__.

* __SelectedValueMemberPath__ - used in conjunction with __DisplayMemberPath__ in the process of translation of a value to display as content. It also tells the __RadComboBox__ editor which property to use as a Value when the user makes selection. 

* __IsComboBoxEditable__ - allows you to configure whether the editor (__RadComboBox__) is editable.

* __IsLightweightModeEnabled__ - introduced in __R2 2016__. Its default value is __False__. When set to __True__, the new lightened lookup logic is triggered, thus the performance of GridViewComboBoxColumn is significantly increased. *If the column`s DataMemberBinding is a nested property, the value of IsLightweightModeEnabled is not respected*. 

>importantThe __type__ of the properties configured as __DataMemberBinding__ and __SelectedValueMemberPath__ should be the same.

>Since __Q3 2012 SP__ typing a letter in __GridViewComboBoxColumn__ will point to the first item starting with the same letter.
        
The following example assumes that you have data as shown in __Figure 1__:

#### __Figure 1: Sample data structure of RadGridView:__

 ![](images/RadGridView_ColumnTypes_1.png)

#### __[XAML] Example 1: Define GridViewComboBoxColumn.__

{{region xaml-radgridview-columns-column-types-combobox-column_0}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewComboBoxColumn />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

#### __[XAML] Example 2: Define DataMemberBinding.__

{{region xaml-radgridview-columns-column-types-combobox-column_3}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewComboBoxColumn DataMemberBinding="{Binding CountryId}" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

#### __[C#] Example 2: Define DataMemberBinding.__

{{region cs-radgridview-columns-column-types-combobox-column_4}}

	column.DataMemberBinding = new Binding( "CountryId" );
{{endregion}}

#### __[C#] Example 3: Setting ItemsSource.__

{{region cs-radgridview-columns-column-types-combobox-column_6}}

	((GridViewComboBoxColumn)this.radGridView.Columns["Country"]).ItemsSource = RadGridViewSampleData.GetCountries();
{{endregion}}

#### __[VB.NET] Example 3: Setting ItemsSource.__

{{region vb-radgridview-columns-column-types-combobox-column_7}}

	DirectCast(Me.radGridView.Columns("Country"), GridViewComboBoxColumn).ItemsSource = RadGridViewSampleData.GetCountries()
{{endregion}}


#### __[XAML] Example 4: Configure DisplayMemberPath and SelectedValuePath properties in XAML.__

{{region xaml-radgridview-columns-column-types-combobox-column_8}}

	<telerik:GridViewComboBoxColumn DataMemberBinding="{Binding CountryId}"
                                    SelectedValueMemberPath="Id"
                                    DisplayMemberPath="Name" />
	{{endregion}}


#### __[C#] Example 4: Configure DisplayMemberPath and SelectedValuePath properties in code.__

{{region cs-radgridview-columns-column-types-combobox-column_9}}

	column.SelectedValueMemberPath = "Id";
	column.DisplayMemberPath = "Name";
{{endregion}}

The application result should be similar to __Figure 2__.:

#### __Figure 2: ComboBoxColumn after setting DisplayMemberPath and SelectedValuePath properties.__
![](images/RadGridView_ColumnTypes_2.png)

As illustrated in __Figure 2__ you can map __CountryId__ property of the business object to the respective value in Countries collection via configuring proper __DisplayMemberPath__.
      
You can download a runnable project of the previous example from our online SDK repository:[ComboboxColumn](https://github.com/telerik/xaml-sdk/tree/master/GridView/ComboboxColumn).
      
The next example shows how to use __ItemsSourceBinding__. It allows you to bind the __ItemsSource__ of __RadComboBox__ editor to a collection held by the data item. In this way, you are able to specify different sets of items depending on the entire content of the respective row. The example assumes that you have the data shown in __Figure 3__:

#### __Figure 3: Sample data structure of RadGridView.__

![](images/RadGridView_ColumnTypes_3.png)

__RadGridView__ binds to a collection of objects representing the teams. The team object exposes a collection containing the current drivers, which is used as source for the editor. As in the previous example, it also exposes a __DriverID__ property that the column will later translate to an appropriate display value. 

#### __[XAML] Example 5: Configure GridViewComboBoxColumn with ItemsSourceBinding.__

{{region xaml-radgridview-columns-column-types-combobox-column_11}}

	<telerik:GridViewComboBoxColumn Header="Driver"
                                    DataMemberBinding="{Binding DriverID}"
                                    ItemsSourceBinding="{Binding CurrentDrivers}"
                                    SelectedValueMemberPath="ID"
                                    IsLightweightModeEnabled="True"
                                    DisplayMemberPath="Name" />
{{endregion}}



__Figure 4.__ and __Figure 5.__ show the result of configuring __ItemsSourceBinding__ property.

#### __Figure 4. Appearance after setting ItemsSourceBinding property.__

![](images/RadGridView_ColumnTypes_4.png)


#### __Figure 5. Appearance after setting ItemsSourceBinding property.__


![](images/RadGridView_ColumnTypes_5.png)

>When using __ItemsSourceBinding__ property, the values displayed in the column’s filtering control will be the values corresponding to the __DataMemberBinding__ (0, 1, 2). If you want to have the displayed ones (S.Vettel, K. Raikkonen, M. Webber), then you need to set __GridViewComboBoxColumn__.[FilterMemberPath]({%slug gridview-filtering-basic%}) to a property containing the values used as __DisplayMemberPath__.
        
>tipYou can download a runnable project of the previous example from our online SDK repository:[ComboboxColumnItemsSourceBinding](https://github.com/telerik/xaml-sdk/GridView/ComboboxColumnItemsSourceBinding__).
        
>If you are setting GridViewComboBoxColumn's __ItemsSource__ property you should specify a valid __Source__ for it. Please refer to this [troubleshooting article]({%slug gridview-troubleshooting-blank-cells%}).

>tipYou can download a __runnable project__ suggesting a modification for performance improvement from our online SDK repository: [LightweightComboboxColumn](https://github.com/telerik/xaml-sdk/GridView/LightweightComboboxColumn).

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. 
        
## Templating GridViewComboBoxColumn

As of version __Q1 2010 SP2__, GridViewComboBoxColumn exposes a new property - __ItemTemplate__ - which also applies to the default editor - RadComboBox.

The following example shows how to implement a multi-column ComboBoxColumn.

Start by defining the GridViewComboBoxColumn and its __ItemTemplate__:

#### __[XAML] Example 6: Configure GridViewComboBoxColumn with ItemTemplate.__

{{region xaml-radgridview-columns-column-types-combobox-column_12}}

	<telerik:GridViewComboBoxColumn Header="City"
	                                DisplayMemberPath="Name"
	                                SelectedValueMemberPath="ID"
	                                ItemsSource="{Binding Path=Cities, Source={StaticResource mainPageViewModel}}"
	                                Width="*"
	                                DataMemberBinding="{Binding CityID}">
	    <telerik:GridViewComboBoxColumn.ItemTemplate>
	        <DataTemplate>
	            <Grid>
	                <Grid.ColumnDefinitions>
	                    <ColumnDefinition />
	                    <ColumnDefinition Width="*"></ColumnDefinition>
	                </Grid.ColumnDefinitions>
	                <TextBlock Text="{Binding ID}"></TextBlock>
	                <TextBlock Text="{Binding Name}"  Grid.Column="1"></TextBlock>
	            </Grid>
	        </DataTemplate>
	    </telerik:GridViewComboBoxColumn.ItemTemplate>
	</telerik:GridViewComboBoxColumn>
{{endregion}}


The multi-column ComboBoxColumn in this example will have two columns showing the ID and Name of the City respectively. When you run the example, Figure 6 shows the result when the customer tries to edit in a column.

__Figure 6.__![](images/gridview_multi_column_combo.png)

# See Also

 * [Empty Cells in ComboboxColumn]({%slug gridview-troubleshooting-blank-cells%})

 * [Handle SelectionChanged for ComboBoxColumn]({%slug gridview-columns-howto-selectionchanged-comboboxcolumn%})
  
 * [Filter items in ComboboxColumn]({%slug gridview-columns-how-to-filter-the-items-in-comboboxcolumn%})

 * [Number of clicks in the ComboBoxColumn]({%slug gridview-combobox-column-clicks%})
  

