---
title: GridView FilteringControl Changes Its Width While Scrolling
description: Distinct values with longer text lead to size change of RadGridView's FilteringControl.
page_title: When Scrolling to Longer Distinct Value GridView FilteringControl Increases Its Width
type: troubleshooting
slug: kb-gridview-filteringcontrol-changes-its-width-while-scrolling
position: 0
tags: filtering,control,scrolling,size,width,distinct,values,list
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.3 917</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

FilteringControl changes its width when scrolling the DistinctValuesList to an item with longer text value.

## Solution

Such behavior can be observed only when there are elements with greater width than the default one of the RadGridView's FilteringControl. To resolve this, create a Style like the following:


```XAML	
	<Style TargetType="telerik:FilteringControl"> <!--Add BasedOn="{StaticResource FilteringControlStyle}" when using the NoXaml assemblies-->
		<Setter Property="MinWidth" Value="0"/>
		<Setter Property="Width" Value="500"/>
	</Style>
```

> The recommended Width value in the above style depends on the application theme that you use, plus the default **Culture** and the default **FontSize** of the RadGridView.

The table below contains all of the [available themes]({%slug common-styling-appearance-available-themes%}), their default font sizes and the recommended width values for the FilteringControl.

|Theme name|Default FontSize|Recommended Width|
|----------|-----------|---|
|**VisualStudio2019**|12|220|
|**Crystal**|13|250|
|**Fluent**|12|250|
|**Material**|14|280|
|**Office2016Touch**|14|250|
|**Office2016**|12|216|
|**Green**|12|240|
|**VisualStudio2013**|12|240|
|**Office2013**|15|220|
|**Windows8Touch**|15|300|
|**Windows8**|12|210|
|All other themes|12|215|

> These values are chosen to be suitable for all available cultures and the default font sizes for a specific theme. In case you need to apply the biggest font size from a theme's Palette, please refer to the following table.

|Theme name|Max Palette FontSize|Recommended Width|
|----------|-----------|---|
|**VisualStudio2019**|FontSizeXL (20)|355|
|**Crystal**|FontSizeXL (15)|275|
|**Fluent**|FontSizeXL (14)|255|
|**Material**|FontSizeL (18)|345|
|**Office2016Touch**|FontSizeL (16)|285|
|**Office2016**|FontSizeL (14)|250|
|**Green**|FontSizeXL (14)|275|
|**VisualStudio2013**|FontSizeXXL (22)|405|
|**Office2013**|FontSizeXL (16)|225|
|**Windows8Touch**|FontSizeXXL (24)|420|
|**Windows8**|FontSizeXXXL (24)|410|

>Themes that are not part of this table do not support theme palettes.

If you need  to apply bigger font sizes for a theme, different than the default or the max ones, you will need to match them with an appropriate width value.

## See Also
* [Available Themes]({%slug common-styling-appearance-available-themes%})
* [Popup Filtering]({%slug gridview-filtering-basic%}#popup-filtering)
