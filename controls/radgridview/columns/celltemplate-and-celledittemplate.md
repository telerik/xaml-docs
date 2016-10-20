---
title: CellTemplate and CellEditTemplate
page_title: CellTemplate and CellEditTemplate
description: Setting CellTemplate and CellEditTemplate
slug: radgridview-columns-celltemplate-and-celledittemplate
tags: setting,celltemplate,and,celledittemplate
published: True
position: 3
---

# Setting CellTemplate and CellEditTemplate

RadGridView provides a set of predefined column types like GridViewCheckBoxColumn, GridViewComboBoxColumn, GridViewSelectColumn, etc., which enable you to customize it according to the particular requirements and the type of properties exposed in your business object. However, sometimes it may turn out that you want to extend the functionality of your columns and define a different editor for example. This can be easily achieved by creating a CellTemplate or CellEditTemplate of a column.

* __CellTemplate__ - gets or sets the data template for the cell in view mode.

* __CellEditTemplate__ - gets or sets the data template for the cell in edit mode.

Generally, the default templates for view mode are:

* __TextBlock__ - for string, numeric, DataTime properties;

* __CheckBox__ - for boolean properties;

The default editors are:

* __TextBox__ - for string and numeric properties;

* __CheckBox__ - for boolean properties;

* __RadDatePicker__ - for DateTime properties.

In case you want to change those default elements for a particular columns, you may define them as follows:

#### __XAML__

{{region xaml-radgridview-columns-celltemplate-and-celledittemplate_0}}
	<telerik:RadGridView x:Name="EmployeesGrid" AutoGenerateColumns="False" ItemsSource="{Binding Employees}">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding FirstName}" />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding LastName}" />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding StartingDate}">
	            <telerik:GridViewDataColumn.CellEditTemplate>
	                <DataTemplate>
	                    <telerik:RadDateTimePicker SelectedDate="{Binding StartingDate}" IsTooltipEnabled="False"/>
	                </DataTemplate>
	            </telerik:GridViewDataColumn.CellEditTemplate>
	        </telerik:GridViewDataColumn>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Salary}">
	            <telerik:GridViewDataColumn.CellTemplate>
	                <DataTemplate>
	                    <telerik:RadNumericUpDown Value="{Binding Salary}" />
	                </DataTemplate>
	            </telerik:GridViewDataColumn.CellTemplate>
	        </telerik:GridViewDataColumn>
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

The grid defined above will be displayed as follows:

![](images/RadGridView_CellTemplate_CellEditTemplate.png)

As it can be seen, the editor for a column of type DateTime is defined as RadDateTimePicker, while the template for the numeric column is set as RadNumericUpDown.

Although the example above illustrates defining either CellTemplate or CellEditTemplate, it is possible to set them both for one and the same column. The exact implementation depends entirely on the specific requirements. 

If you want ot set a CellTemplate in code-behind, you can check [this help article]({%slug gridview-columns-defining-columns%}) for reference.

>tipHaving DataMemberBinding set to StartingDate, the aggregation, sorting, grouping and filtering operations on this column will be done based on the StartingDate property.

>In case the user do not need to perform any aggregation, sorting, grouping or filtering operations for the column, then you can define [GridViewColumn]({%slug radgridview-columns-column-types-basic-column%}) instead.

>In a scenario when there is a column.CellEditTemplate defined, the new value of the editor is not available in the arguments of the __CellEditEnded__ event raised when commiting an edit. To get the right value in __e.NewValue__, you can create your own [Custom Column]({%slug radgridview-howto-create-custom-editor %}) and override its __GetNewValueFromEditor__ method.

# See Also

 * [Basic Column]({%slug radgridview-columns-column-types-basic-column%})
 
 * [Defining Columns]({%slug gridview-columns-defining-columns%})

 * [Customizing Columns]({%slug gridview-columns-customizing-columns%})

 * [Data Formatting]({%slug gridview-columns-data-formatting%})
