---
title: Styling Invalid Row
page_title: Styling Invalid Row
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to style its invalid row.
slug: styling-invalid-row-in-gridview
tags: styling,invalid,row,gridview
published: True
position: 22
---

# Styling Invalid Row in RadGridView ##

> Before reading this topic, you might find it useful to get familiar with RadGridView’s [validation]({%slug gridview-managing-data-validation%}) functionality.

__RadGridView__ has two validation layers: **UI** and **data**. An interface such as __IDataErrorInfo__ is used by the data layer validation and __RadGridView's__ role here is just to update the underlying value via binding at the right moment. 

{% if site.site_name == 'WPF' %}
Error validation template comes from __WPF__ framework. 
{% endif %}

#### __Figure 1: The default invalid row__

![Telerik {{ site.framework_name }} DataGrid Invalid-Row-](images/styling-invalid-row.PNG)

{% if site.site_name == 'WPF' %}
When data is being validated on the property level, the default error template for __WPF__ appears. This is a thin red line around the control. In the world of __WPF__, you can easily restyle the validation error template of any control.
 
An exception of this rule is the MS controls that could be styled in all Telerik themes. They inherit the same look and feel presented for each theme, as part of the Telerik theme suite.  
{% endif %}

> To learn how to customize any Telerik theme, see the [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}) article.

__RadGridView's__ invalid styles are located in __Telerik.Windows.Controls.GridView.xaml__; those related to editors are in the respective theme XAML markup file.

To edit the default invalid row style, you can extract the default __ControlTemplate__ of the __GridViewRow__. In the extracted templated, you can navigate to a __Border__ element with x:Name="Background_Invalid" and modify its properties as desired.

* Manually [Edit the ControlTemplates]({%slug styling-apperance-editing-control-templates%})  

>tip The recommended approach for editing __ControlTemplates__ is using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}).

#### __[XAML] Example 1: Invalid row in the Office_Black theme__
{{region styling-validation-tooltip-in-gridview-0}}
	 <ControlTemplate x:Key="GridViewRowTemplate" TargetType="grid:GridViewRow">

    . . .
    
     <Border x:Name="Background_Invalid"
                        Margin="1 1 1 2"
                        BorderThickness="1"
                        CornerRadius="1"
                        BorderBrush="{StaticResource ItemOuterBorder_Invalid}"
                        Grid.Column="2"
                        Grid.ColumnSpan="2"
                        Visibility="Collapsed"
                        grid:SelectiveScrollingGrid.SelectiveScrollingClip="True">
		<Border BorderThickness="1" BorderBrush="{StaticResource ItemInnerBorder_Invalid}" Background="{StaticResource ItemBackground_Invalid}"/>
	</Border>

    . . .

	</ControlTemplate>
{{endregion}}

## See Also
* [Validation]({%slug gridview-managing-data-validation%})
