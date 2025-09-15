---
title: Styling CheckBoxColumn
page_title: Styling CheckBoxColumn
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to style the CheckBoxColumn. 
slug: gridview-columns-styling-checkboxcolumn
tags: styling,checkboxcolumn
published: True
position: 21
---

# Styling GridViewCheckBoxColumn

This topic will show you how to style the __GridViewCheckBoxColumn__.

The cells of __RadGridView__ have two different elements for their current state - when in __view mode__ and in __edit mode__. By default, the __GridViewCheckBoxColumn__ uses a __GridViewCheckBox__ when in __view mode__ and the standard __CheckBox__ control as its __editor__. The __GridViewCheckBox__ is an element that emulates the behavior of a __CheckBox__ and is especially designed for __RadGridView__ to improve its performance. 

>In order to style the whole cell rather than the __GridViewCheckBox__ element only, you can set the __CellStyle__ property of the __GridViewCheckBoxColumn__. You can find more information in the [Styling Cells]({%slug gridview-styling-cell%}) topic. 

## Styling GridViewCheckBoxColumn in View Mode

#### __Figure 1: Default look of GridViewCheckBox__        
![Telerik {{ site.framework_name }} DataGrid Styles and Templates Styling CheckBoxColumn 01](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_01.PNG)

In order to modify the visual appearance of a cell when in __view mode__ you need to create an appropriate style targeting the **GridViewCheckBox** element. You can also [edit its control template]({%slug styling-apperance-editing-control-templates%}) if you wish to apply further customizations.

__Example 2: Applying the style to the GridViewCheckBox__
```XAML
	<ControlTemplate x:Key="GridViewCheckBoxTemplate" TargetType="grid:GridViewCheckBox">
		<!-- the default template for the theme -->
    </ControlTemplate>

	<!-- If you're using the NoXaml binaries you need to set the BasedOn property of the two styles to the GridViewCellStyle and GridViewCheckBoxStyle static resources --> 
	<Style TargetType="telerik:GridViewCell">
		<Style.Resources>
			<Style TargetType="telerik:GridViewCheckBox">
				<Setter Property="Background" Value="Red" />
				<Setter Property="Template" Value="{StaticResource GridViewCheckBoxTemplate}"/>
			</Style>
		</Style.Resources>
	</Style>
```

>If you want to apply this style only to a particular column, you can assign it an x:Key value and set the **CellStyle** property of the respective column.

## Styling GridViewCheckBoxColumn in Edit Mode

In order to alter the appearance of the __editor__ of __GridViewCheckBoxColumn__, you need to create an appropriate style targeting the __CheckBox__ control.

__Example 3: Applying the style to the CheckBox__
```XAML
	<ControlTemplate TargetType="CheckBox" x:Key="CheckBoxTemplate">
        <!-- the default template for the theme -->
    </ControlTemplate>

	<!-- If you're using the NoXaml binaries you need to set the BasedOn property of the style to the CheckBoxStyle static resources --> 
	<Style x:Key="MyCheckBoxStyle" TargetType="CheckBox">
		<Setter Property="Background" Value="Red" />
		<Setter Property="Template" Value="{StaticResource CheckBoxTemplate}"/>
	</Style>
```

You then need to set this style as the [EditorStyle]({%slug radgridview-styling-column-editor%}) property of the columns you wish to affect.

__Example 4: Applying the style to the CheckBox__
```XAML
	<telerik:GridViewCheckBoxColumn EditorStyle="{StaticResource MyCheckBoxStyle}" />
```

## See Also
 * [CheckBox Column]({%slug gridview-checkbox-column%})