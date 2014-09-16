---
title: Enable\Disable Grid Elements
page_title: Enable\Disable Grid Elements
description: Enable\Disable Grid Elements
slug: gridview-enable-disable-grid-elements
tags: enable\disable,grid,elements
publish: True
position: 6
---

# Enable\Disable Grid Elements



## 

__RadGridView__ is an advanced {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} control, that allows you to enable\disable its different parts. You can set the boolean property __IsEnabled__to each one of the following objects:

* __RadGridView__

* __GridViewRow__

* __GridViewCell__

Having this in mind, you can control the behavior and enable\disable different parts of your grid view according to some internal logic of yours. 

>__Important!__ The GridViewDataColumn.IsEnabled property cannot be actually used. It is a dependency property inherited from
            [ContentElement](http://msdn.microsoft.com/en-us/library/system.windows.contentelement.aspx).
          

You can __disable a whole column__ by changing the __IsEnabled__ property of each one of __its cells__. 

This property gets or sets a value indicating whether this element is enabled in the user interface (UI). This is a dependency property inherited from 
        [UIElement](http://msdn.microsoft.com/en-us/library/system.windows.uielement)
        .

For example:
        



#### __XAML__

{{region gridview-enable-disable-grid-elements_0}}
	<Style x:Key="disabledStyle" TargetType="telerik:GridViewCell">
	            <Setter Property="IsEnabled" Value="False"/>
	</Style>
	{{endregion}}





#### __XAML__

{{region gridview-enable-disable-grid-elements_1}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding CompanyName}" CellStyle="{StaticResource disabledStyle}"/>
	{{endregion}}



The screenshot below shows you a __RadGridView__ control with a few disabled cells along with the "CompanyName" column.

![](images/RadGridView_EnableDisable_1.png)

To __disable all the rows__ you need to apply a Style targeting at GridViewRow



#### __XAML__

{{region gridview-enable-disable-grid-elements_2}}
	<Style TargetType="telerik:GridViewRow">
	   <Setter Property="IsEnabled" Value="False"/>
	</Style>
	{{endregion}}



The defined Style is implicit and it will be applied to all the GridViewRow elements.

To apply the disabled style to some rows only, you can use a [
            RowStyleSelector]({%slug gridview-rowstyleselector%}).

# See Also

 * [Read Only Rows and Cells]({%slug gridview-read-only-rows-cells%})
