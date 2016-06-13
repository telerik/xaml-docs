---
title: Select Column
page_title: Select Column
description: Select Column
slug: radgridview-columns-column-types-select-column
tags: select,column
published: True
position: 11
---

# Select Column

The __GridViewSelectColumn__ derives from [GridViewColumn]({%slug radgridview-columns-column-types-basic-column%}) and its content is represented by a **CheckBox** for each row. It differs from the __GridViewCheckBoxColumn__ as it **does not bind to data**. Instead, it allows you to select a given row via a checkbox, in other words - each CheckBox's **IsChecked** property is bound to the **IsSelected** property of the corresponding row.

#### __[XAML] Example 1: Defining GridViewSelectColumn in XAML__

	{{region radgridview-columns-column-types-select-column_0}}
	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewSelectColumn />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
	{{endregion}}

#### __Figure 1: The GridViewSelectColumn__

![The GridViewSelectColumn](images/selectcolumn-default.png)

If you set RadGridView's [**SelectionMode**]({%slug gridview-multiple-selection%}) property to either __Extended__ or __Multiple__, you will be able to select more than one row by clicking on the desired checkbox or to select all the rows by clicking on the checkbox in the header.

#### __[XAML] Example 2: Define GridViewDataColumn with Extended SelectionMode__

	{{region radgridview-columns-column-types-select-column_1}}
	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False"
	                     SelectionMode="Extended">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewSelectColumn />
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
	{{endregion}}

#### __Figure 2: The GridViewSelectColumn with Extended SelectionMode__

![The GridViewSelectColumn with Extended SelectionMode](images/selectcolumn-multiple-selection.png)

## CheckBoxStyle and HeaderCheckBoxStyle

GridViewSelectColumn exposes two properties of type style: **CheckBoxStyle** and **HeaderCheckBoxStyle**. You can use them to style the respective checkboxes.

#### __[XAML] Example 3: Creating appropriate styles__

	{{region radgridview-columns-column-types-select-column_2}}
    <Style x:Key="CheckBoxStyle" TargetType="CheckBox">
        <Setter Property="Background" Value="Red" />
    </Style>
    <Style x:Key="HeaderCheckBoxStyle" TargetType="CheckBox">
        <Setter Property="Background" Value="Blue" />
    </Style>
	{{endregion}}

#### __[XAML] Example 4: Setting RadGridView's CheckBoxStyle and HeaderCheckBoxStyle__

	{{region radgridview-columns-column-types-select-column_3}}
	<telerik:GridViewSelectColumn CheckBoxStyle="{StaticResource CheckBoxStyle}" 
                                              HeaderCheckBoxStyle="{StaticResource HeaderCheckBoxStyle}"/>
	{{endregion}}

**Figure 3** shows the final result:

#### __Figure 3: The styled GridViewSelectColumn__

![The styled GridViewSelectColumn](images/selectcolumn-styled.png)

# See Also

 * [CheckBox Column]({%slug gridview-checkbox-column-clicks%})

 * [Multiple Selection]({%slug gridview-multiple-selection%})

