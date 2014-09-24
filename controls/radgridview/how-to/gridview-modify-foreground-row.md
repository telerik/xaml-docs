---
title: Modify foreground color of Selected/Hovered row
page_title: Modify foreground color of Selected/Hovered row
description: Modify foreground color of Selected/Hovered row
slug: gridview-how-to-modify-foreground-row
tags: modify,foreground,color,of,selected/hovered,row
published: True
position: 14
---

# Modify foreground color of Selected/Hovered row



This help article will show you how to modify the foreground color of GridViewRow on selecting it or hovering over it.

## 

Every row shows a set of GridViewCells. In order to change the foreground of all the GridViewCells when their parent row is hovered/selected you should predefine the template of GridViewRow and access the part __DataCellsPresenter__. This element is a plain presenter used to display the cells contained in a row.

You should then add an additional animation to the default hover/selection states of a row and manipulate the Foreground property of __PART_DataCellsPresenter__. 

For example:Selected State

#### __XAML__

{{region gridview-how-to-modify-foreground-row_0}}
	<VisualState x:Name="Selected">
	    <Storyboard>
	        <ObjectAnimationUsingKeyFrames Duration="0" Storyboard.TargetName="Background_Selected"
	Storyboard.TargetProperty="(UIElement.Visibility)">
	            <DiscreteObjectKeyFrame KeyTime="0">
	                <DiscreteObjectKeyFrame.Value>
	                    <Visibility>Visible</Visibility>
	                </DiscreteObjectKeyFrame.Value>
	            </DiscreteObjectKeyFrame>
	        </ObjectAnimationUsingKeyFrames>
	        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="NavigatorIndicatorBackground"
	Storyboard.TargetProperty="Background">
	            <DiscreteObjectKeyFrame KeyTime="0:0:0"
	Value="{StaticResource GridView_RowIndicatorCellBackground_Selected}" />
	        </ObjectAnimationUsingKeyFrames>
	        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="PART_DataCellsPresenter"
	Storyboard.TargetProperty="Foreground">
	            <DiscreteObjectKeyFrame KeyTime="0:0:0"
	Value="{StaticResource GridView_ItemForeground_Selected}" />
	        </ObjectAnimationUsingKeyFrames>
	    </Storyboard>
	</VisualState>
	
	{{endregion}}

MouseOver State

#### __XAML__

{{region gridview-how-to-modify-foreground-row_1}}
	<VisualState x:Name="MouseOver">
	    <Storyboard>
	        <ObjectAnimationUsingKeyFrames Duration="0" Storyboard.TargetName="Background_Over"
	Storyboard.TargetProperty="(UIElement.Visibility)">
	            <DiscreteObjectKeyFrame KeyTime="0">
	                <DiscreteObjectKeyFrame.Value>
	                    <Visibility>Visible</Visibility>
	                </DiscreteObjectKeyFrame.Value>
	            </DiscreteObjectKeyFrame>
	        </ObjectAnimationUsingKeyFrames>
	        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="PART_DataCellsPresenter"
	Storyboard.TargetProperty="Foreground">
	            <DiscreteObjectKeyFrame KeyTime="0:0:0"
	Value="{StaticResource GridView_ItemForeground_Over}" />
	        </ObjectAnimationUsingKeyFrames>
	    </Storyboard>
	</VisualState>
	
	{{endregion}}



You may also add your own brush resources with an appropriate color for this animation:
        

#### __XAML__

{{region gridview-how-to-modify-foreground-row_2}}
	<SolidColorBrush x:Key="GridView_ItemForeground_Selected" Color="Green"/>
	<SolidColorBrush x:Key="GridView_ItemForeground_Over" Color="Red"/>
	{{endregion}}



# See Also

 * [Styling a Row]({%slug gridview-styling-a-row%})
