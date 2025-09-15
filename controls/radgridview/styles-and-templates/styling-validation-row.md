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

__RadGridView's__ styles are located in __Themes.Implicit\{your theme}\Themes\Telerik.Windows.Controls.GridView.xaml__ file.

To edit the default invalid row style, you can extract the __ControlTemplate__ of the __GridViewRow__. You can check the [Edit the ControlTemplates]({%slug styling-apperance-editing-control-templates%}) help article which describes how you can get the default template of the controls. In the extracted template, you can navigate to the __Border__ element with x:Name="Background_Invalid" and modify its properties as desired.

>tip In case you use different themes and the user can change them at runtime, you will have to extract and modify the default template of the GridViewRow for each theme that you are using.

#### __Figure 1: The default invalid row__

![Telerik {{ site.framework_name }} DataGrid Invalid-Row-](images/styling-invalid-row.PNG)

> To learn how to customize any Telerik theme, see the [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}) article.

__Example 1: Invalid row in the Office_Black theme__
```XAML
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
```

## See Also
* [Validation]({%slug gridview-managing-data-validation%})
