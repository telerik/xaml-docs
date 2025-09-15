---
title: Override Default RadGridView Styles
page_title: Override Default RadGridView Styles
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to override the default styles of the control.
slug: how-to-override-default-gridview-styles
tags: override,default,radgridview,styles
published: False
---

# Override Default RadGridView Styles


This help article will show you how to override the default styles of __RadGridView__. For most cases, the work includes modifying the default template of either RadGridView or one of its components, e.g., GridViewRow. Modifying the templates is easy if you have Microsoft Expression Blend 4. [This topic]({%slug radgridview-styles-and-templates-styling-radgridview%}) explains the basics. Let's start with modifying the visual appearance of __RadGridView__.

* [Modify the mouse over background](#mouse-over-background)

* [Remove the Border of the Current Cell](#remove-the-border-of-the-current-cell)

## Mouse Over Background ##

This example shows how to change the background color and the border of the row when the mouse is over it:

![Telerik {{ site.framework_name }} DataGrid styling row background mouseover](images/styling_row_background_mouseover.png)

You need to modify GridViewRow's template. [This topic]({%slug gridview-styling-a-row%}) explains the basics. You need to find the __Background_Over__ Border element:

![Telerik {{ site.framework_name }} DataGrid styling row background mouseover2](images/styling_row_background_mouseover2.png)

__Example 1: The Default Border When the Mouse Hovers GridViewRow__

```XAML
	!--
	                                <Border x:Name="Background_Over" 
	        BorderBrush="{StaticResource ItemOuterBorder_Over}" 
	        BorderThickness="1" 
	        Grid.ColumnSpan="2" Grid.Column="2" 
	        CornerRadius="1" Margin="1,1,1,2" telerik:SelectiveScrollingGrid.SelectiveScrollingClip="True" Visibility="Collapsed">
	                                    <Border BorderBrush="{StaticResource ItemInnerBorder_Over}" BorderThickness="1" Background="{StaticResource ItemBackground_Over}"/>
	                                </Border>
	                                -->
```

Now you can change all the properties you want, e.g., the __BorderBrush__ value will affect the border, the __Background__ will affect the background, etc. The next example changes the values a little to end up with this XAML:

__Example 2: Modified The Default Border When the Mouse Hovers GridViewRow__

```XAML
	!--
	                                <Border x:Name="Background_Over" 
	 BorderBrush="Blue" 
	 BorderThickness="1" 
	 Grid.ColumnSpan="2" Grid.Column="2" CornerRadius="1" Margin="1,1,1,2" 
	 telerik:SelectiveScrollingGrid.SelectiveScrollingClip="True" Visibility="Collapsed">
	                                    <Border BorderBrush="{StaticResource ItemInnerBorder_Over}" BorderThickness="1" Background="Gray"/>
	                                </Border>
	                                -->
```

Finally, you need to set the __RowStyle__ property of __RadGridView__ to the style you have just modified.

## Remove the Border of the Current Cell ##

This example shows how to remove the border of the current cell (the one that has been clicked):

![Telerik {{ site.framework_name }} DataGrid styling current cell 3](images/styling_current_cell3.png)


You need to edit the template of GridViewCell. [This topic]({%slug gridview-styling-cell%}) explains the basics. Once you have the template, search for the term "current". You will find a __VisualState__, __Trigger__ and __Border__ which you need to delete.

__Example 3: Elements that Need to be Deleted from the Template of GridViewCell__
	<VisualState x:Name="Current">
    <Storyboard>
        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="Background_Current"
                                       Storyboard.TargetProperty="Visibility">
            <DiscreteObjectKeyFrame KeyTime="0">
                <DiscreteObjectKeyFrame.Value>
                    <Visibility>Visible</Visibility>
                </DiscreteObjectKeyFrame.Value>
            </DiscreteObjectKeyFrame>
        </ObjectAnimationUsingKeyFrames>
    </Storyboard>
	</VisualState>

	...

	<Trigger Property="IsCurrent" Value="True">
	      <Setter Property="Visibility" TargetName="Background_Current" Value="Visible"/>
	</Trigger>
	...
	<Border x:Name="Background_Current"
        Margin="1 1 2 2"
        BorderThickness="1"
        CornerRadius="1"
        BorderBrush="{StaticResource ControlOuterBorder}"
        Grid.Column="2"
        Grid.ColumnSpan="2"
        Visibility="Collapsed"/>


{% if site.site_name == 'WPF' %}

Finally, find the __Property="FocusVisualStyle"__ and set its value to null:{% endif %}

__Example 4: Setting the FocusVisualStyle Property to null__

```XAML
	!--
	                <Setter Property="FocusVisualStyle" Value="{x:Null}" />
	                -->
```

Now make the style implicit (i.e., do not specify the __x:Key__ attribute) so it will apply to all __GridViewCell__ elements.
