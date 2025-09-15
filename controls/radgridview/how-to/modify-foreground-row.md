---
title: Modify Foreground Color of Selected/Hovered Row
page_title: Modify Foreground Color of Selected/Hovered Row
description: Get started with the Telerik {{ site.framework_name }} DataGrid and learn how to change the foreground color of all GridViewCells when their parent row is hovered or selected.
slug: gridview-how-to-modify-foreground-row
tags: modify,foreground,color,of,selected/hovered,row
published: False
position: 14
---

# Modify Foreground Color of Selected/Hovered Row

This help article will show you how to modify the foreground color of the **GridViewRow** element when you select or hover it.

Every row shows a set of **GridViewCells**. In order to change the foreground of all the GridViewCells when their parent row is hovered or selected you should [predefine the template]({%slug styling-apperance-editing-control-templates%}) of the GridViewRow and access the part __DataCellsPresenter__ element. This element is an **ItemsControl** used to display the cells contained in a row.

You then need to add an additional animation to the default hover and/or selection states of a row and manipulate the **Foreground** property of __PART_DataCellsPresenter__. 

**Example 1** demonstrates how to edit the **Selected** visual state in order to change the foreground of the row when it is selected.

__Example 1: Modify Selected visual state__

```XAML
    <VisualState x:Name="Selected">
	<Storyboard>
	    <ObjectAnimationUsingKeyFrames Duration="0" Storyboard.TargetName="Background_Selected" Storyboard.TargetProperty="(UIElement.Visibility)">
		<DiscreteObjectKeyFrame KeyTime="0">
		    <DiscreteObjectKeyFrame.Value>
			<Visibility>Visible</Visibility>
		    </DiscreteObjectKeyFrame.Value>
		</DiscreteObjectKeyFrame>
	    </ObjectAnimationUsingKeyFrames>
	    <ObjectAnimationUsingKeyFrames Storyboard.TargetName="NavigatorIndicatorBackground" Storyboard.TargetProperty="Background">
		<DiscreteObjectKeyFrame KeyTime="0:0:0" Value="{StaticResource GridView_RowIndicatorCellBackground_Selected}" />
	    </ObjectAnimationUsingKeyFrames>
	    <ObjectAnimationUsingKeyFrames Storyboard.TargetName="PART_DataCellsPresenter" Storyboard.TargetProperty="Foreground">
		<DiscreteObjectKeyFrame KeyTime="0:0:0" Value="{StaticResource GridView_ItemForeground_Selected}" />
	    </ObjectAnimationUsingKeyFrames>
	</Storyboard>
    </VisualState>
```

**Example 2** demonstrates how to edit the **MouseOver** visual state in order to change the foreground of the row when it is hovered.

__Example 2: Modify MouseOver visual state__

```XAML
    <VisualState x:Name="MouseOver">
	<Storyboard>
	    <ObjectAnimationUsingKeyFrames Duration="0" Storyboard.TargetName="Background_Over" Storyboard.TargetProperty="(UIElement.Visibility)">
		<DiscreteObjectKeyFrame KeyTime="0">
		    <DiscreteObjectKeyFrame.Value>
			<Visibility>Visible</Visibility>
		    </DiscreteObjectKeyFrame.Value>
		</DiscreteObjectKeyFrame>
	    </ObjectAnimationUsingKeyFrames>
	    <ObjectAnimationUsingKeyFrames Storyboard.TargetName="PART_DataCellsPresenter" Storyboard.TargetProperty="Foreground">
		<DiscreteObjectKeyFrame KeyTime="0:0:0" Value="{StaticResource GridView_ItemForeground_Over}" />
	    </ObjectAnimationUsingKeyFrames>
	</Storyboard>
    </VisualState>
```

**Example 3** shows how to define your own brush resources with an appropriate color for these animations.
        
__Example 3: Custom brushes for the Selected and MouseOver states__

```XAML
    <SolidColorBrush x:Key="GridView_ItemForeground_Selected" Color="Green"/>
    <SolidColorBrush x:Key="GridView_ItemForeground_Over" Color="Red"/>
```

## See Also

 * [Styling a Row]({%slug gridview-styling-a-row%})
