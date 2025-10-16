---
title: Increase the CheckBox Size of the GridViewSelectColumn
description: Make the CheckBox displayed in the GridViewSelectColumn larger.
type: how-to
page_title: Enlarge the CheckBox shown by the GridViewSelectColumn
slug: kb-gridview-howto-increase-size-checkbox-selectcolumn
position: 0
tags: gridview, selectcolumn, increase, checkbox, size
ticketid: 1403577
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2018.3.1016</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>


## Description

How to increase the CheckBox size of the GridViewSelectColumn.

## Solution

1. Define the following style targetting the **CheckBox** control.

  
  ```XAML
    <Style x:Key="LargeCheckBoxStyle" TargetType="CheckBox" BasedOn="{StaticResource CheckBoxStyle}">
        <Setter Property="LayoutTransform">
            <Setter.Value>
                <ScaleTransform ScaleX="2" ScaleY="2" />
            </Setter.Value>
        </Setter>
    </Style>
  ```
  
>importantIf you're not using the [implicit styles]({%slug styling-apperance-implicit-styles-overview%}) mechanism for theming the controls with the [NoXaml binaries]({%slug xaml-vs-noxaml%}), you need to omit the BasedOn attribute.

2. Set the style as the **CheckBoxStyle** of the [GridViewSelectColumn]({%slug radgridview-columns-column-types-select-column%}).

  
  ```XAML
    <telerik:GridViewSelectColumn CheckBoxStyle="{StaticResource LargeCheckBoxStyle}" />
  ```

>Alternatively you can [edit the default control template]({%slug styling-apperance-editing-control-templates%}) of the checkbox and increase the sizes of its composing elements.

A similar approach can also be applied to the checkbox in the header of the RadGridView control by specifying a custom style as the **HeaderCheckBoxStyle**.

## See Also
* [GridViewSelectColumn]({%slug radgridview-columns-column-types-select-column%})
