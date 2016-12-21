---
title: Styling CheckBoxColumn
page_title: Styling CheckBoxColumn
description: Styling CheckBoxColumn
slug: gridview-columns-styling-checkboxcolumn
tags: styling,checkboxcolumn
published: True
position: 21
---

# Styling GridViewCheckBoxColumn

This topic will show you how to style the __GridViewCheckBoxColumn__.

* [Styling GridViewCheckBoxColumn in View Mode](#styling-gridviewcheckboxcolumn-in-view-mode)

* [Styling GridViewCheckBoxColumn in Edit Mode](#styling-gridviewcheckboxcolumn-in-edit-mode)

* [Applying the Styles to GridViewCheckBoxColumn explicitly](#applying-the-styles-to-gridviewcheckboxcolumn-explicitly)

* [Centering GridViewCheckBoxColumn](#centering-gridviewcheckboxcolumn) 

The cells of __RadGridView__ have two templates for their current state - when in __view mode__ and in __edit mode__. By default, __GridViewCheckBoxColumn__ uses a __GridViewCheckBox__ when in __view mode__ and the standard __CheckBox__ control as its __editor__. __GridViewCheckBox__ is an element that emulates the behavior of a __CheckBox__ and is especially designed for __RadGridView__. 

>In order to style the whole cell rather than the __GridViewCheckBox__ element only, you can set the __CellStyle__ property of the __GridViewCheckBoxColumn__. You can find more information in the [Styling Cells]({%slug gridview-styling-cell%}) topic. 

## Styling GridViewCheckBoxColumn in View Mode

#### __Figure 1: Default look of GridViewCheckBox__
        
![Rad Grid View Styles and Templates Styling Check Box Column 01](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_01.PNG)


In order to modify the visual appearance of a cell in __view mode__, the __ControlTemplate__ of __GridViewCheckBox__ should be modified.

#### __[XAML] Example 1: Defining the ControlTemplate of GridViewCheckBox__

	<ControlTemplate x:Key="GridViewCheckBoxTemplate" TargetType="grid:GridViewCheckBox">
            ...
    </ControlTemplate>


After the needed __ControlTemplate__ is defined, it can be applied using the __Template__ property of __GridViewCheckBox__.

#### __[XAML] Example 2: Applying the ControlTemplate to GridViewCheckBox__

	<Style x:Key="GridViewCheckBoxStyle" TargetType="grid:GridViewCheckBox">
    	<Setter Property="Template" Value="{StaticResource GridViewCheckBoxTemplate}"/>
	</Style>

	<Style TargetType="grid:GridViewCheckBox" BasedOn="{StaticResource GridViewCheckBoxStyle}"/>


## Styling GridViewCheckBoxColumn in Edit Mode


In order to alter the appearance of the __editor__ of __GridViewCheckBoxColumn__, a __ControlTemplate__ targeting the __CheckBox__ control should be defined.

#### __[XAML] Example 3: Defining the ControlTemplate of CheckBox__

	<ControlTemplate TargetType="CheckBox" x:Key="CheckBoxTemplate">
            ...
    </ControlTemplate>

<Comment: The formatting of the previous section looks incorrect to me.>

The customized __ControlTemplate__ can be applied as follows.

#### __[XAML] Example 4: Applying the ControlTemplate to CheckBox__

	<Style x:Key="CheckBoxStyleGridViewColumn" TargetType="CheckBox">
    	<Setter Property="Template" Value="{StaticResource CheckBoxTemplate}"/>
    </Style>

    <Style TargetType="CheckBox" BasedOn="{StaticResource CheckBoxStyleGridViewColumn}"/>

## Applying the Styles to GridViewCheckBoxColumn explicitly

The aforementioned approach implies defining the styles __implicitly__. If you need to apply the modifications to a particular instance of __RadGridView__, you can apply these Styles __explicitly__ through the __Resources__ of __RadGridView__.

	<telerik:RadGridView.Resources>
		...
	</telerik:RadGridView.Resources>

## Centering GridViewCheckBoxColumn

In order to center the __CheckBox__ in __GridViewCheckBoxColumn__, you can define a style targeting __GridViewCell__ and set the __HorizontalContentAlignment__ property to __"Center"__:

####  __[XAML] Example 4: Centering the GridViewCheckBoxColumn__

{{region xaml-gridview-checkbox-column_3}}
	<Style x:Key="MyCheckBoxColumnCellStyle" TargetType="telerik:GridViewCell">
	    <Setter Property="HorizontalContentAlignment" Value="Center"/>
	</Style>
{{endregion}}


Now the __GridViewCheckBoxColumn__ will look like:

#### __Figure 2: Centered GridViewCheckBoxColumn__     

![Rad Grid View Styles and Templates Styling Check Box Column 03](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_03.PNG)

However, there is a pixel offset when the __GridViewCheckBoxColumn__ goes into edit mode:

#### __Figure 3: Centered GridViewCheckBoxColumn in edit mode__       

![Rad Grid View Styles and Templates Styling Check Box Column 04](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_04.PNG)

In order to align the default editor of __GridViewCheckBoxColumn__ correctly, you can specify a different __Margin__ for it by handling the __PreparingCellForEdit__ event of __RadGridView__:
        

#### __[C#] Example 5: Setting the Margin of the Editor GridViewCheckBoxColumn__

	private void RadGridView_PreparingCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
	{
	   if (e.Column.UniqueName == "GridViewCheckBoxColumn")
	   {
	       var checkBox = e.EditingElement as CheckBox;
	       checkBox.Margin = new Thickness(4, 0, -3, 0);
	   }
	}

Here is the result:

#### __Figure 4 GridViewCheckBoxColumn with set margin__
        
![Rad Grid View Styles and Templates Styling Check Box Column 05](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_05.PNG)


# See Also

 * [CheckBox Column]({%slug gridview-checkbox-column%})
