---
title: Create Consistent Style for RadComboBox in a RadToolBar Control
page_title: Preserve Custom Style for RadComboBox element Defined in RadToolBar Control
description: Create a style for the RadComboBox element, present in a RadToolBar control, that is preserved when the theme is changed.
type: how-to
slug: kb-toolbar-create-consistent-style-for-combobox
position: 0
tags: combobox, style, toolbar
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2022.1 117</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadToolBar for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

The `RadToolBar` control has predefined styles for the most commonly used controls as its content. A list of these controls can be found in the [Styling RadToolBar article]({%slug radtoolbar-style-selector%}).

However, you may want to use a control which is not styled out of the box, such as the `RadComboBox` control, for example. This article provides an example on how to set a style for the RadComboBox element, which is defined inside a RadToolBar element.

## Solution

Add a new `ToolBarContainerStyle` instance to the `ToolBarContainerStyleSelector` property of the `RadToolBar` element, and set its `TypeName` property to __"RadComboBox"__.



```XAML
	<telerik:ToolBarContainerStyleSelector>
	    <telerik:ToolBarContainerStyle TypeName="RadComboBox" />
	</telerik:ToolBarContainerStyleSelector>
```

When using certain themes, different properties would need to be changed, so that the RadComboBox element would look the same as the rest of the controls inside the RadToolBar instance.

For `Office2019` and `Crystal` themes, modify the `Margin` property:



```XAML
	<!--Set BasedOn property if NoXaml assemblies are used: BasedOn="{StaticResource RadComboBoxStyle}"-->
	<Style x:Key="ToolBarRadComboBoxStyle" TargetType="telerik:RadComboBox">
		<Setter Property="Margin" Value="1" />
	</Style>
```

For `VisualStudio2019` theme, modify the `BorderThickness`, `Margin`, and `Background` properties:



```XAML
	<!--Set BasedOn property if NoXaml assemblies are used: BasedOn="{StaticResource RadComboBoxStyle}"-->
	<Style x:Key="ToolBarRadComboBoxStyle" TargetType="telerik:RadComboBox">
	    <Setter Property="BorderThickness" Value="0" />
	    <Setter Property="Margin" Value="4" />
	    <Style.Triggers>
	        <Trigger Property="IsMouseOver" Value="True">
	            <Setter Property="BorderThickness" Value="1" />
	        </Trigger>
	        <Trigger Property="IsKeyboardFocusWithin" Value="True">
	            <Setter Property="BorderThickness" Value="1" />
	        </Trigger>
	        <Trigger Property="IsEditable" Value="False">
	            <Setter Property="Background" Value="Transparent"/>
	        </Trigger>
	        <Trigger Property="IsEditable" Value="True">
	            <Setter Property="BorderThickness" Value="1" />
	        </Trigger>
	    </Style.Triggers>
	</Style>
```

Finally, set the created `Style` to the `ContainerStyle` property of the newly introduced `ToolBarContainerStyle` element.



```XAML
	<telerik:ToolBarContainerStyleSelector>
	    <telerik:ToolBarContainerStyle TypeName="RadComboBox" ContainerStyle="{StaticResource ToolBarRadComboBoxStyle}" />
	</telerik:ToolBarContainerStyleSelector>
```

## See Also

* [Styling RadToolBar]({%slug radtoolbar-style-selector%})