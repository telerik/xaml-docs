---
title: Expand Direction
page_title: Expand Direction
description: You can change the expander direction throught its ExpandDirection property.
slug: radexpander-features-expand_direction
tags: expand,direction
published: True
position: 1
---

# Expand Direction

The __ExpandDirection__ property gets or sets the direction in which the content would expand. This property is an enumeration which expose four values: __Down, Left, Right, Up__.

#### __[XAML] Example 1: Setting ExpandDirection property__
{{region radexpander-features-expand_direction_0}}
   <Grid>
		<telerik:RadExpander Width="200" Height="200"
							ExpandDirection="Down" Background="Bisque"
							Header="ExpandDirection Down">
			<StackPanel Orientation="Vertical">
				<Ellipse Width="99"  
						Height="99" 
						Margin="5" 
						Fill="Blue" />
			</StackPanel>
		</telerik:RadExpander>
	</Grid>
{{endregion}}

#### __Figure 1: ExpandDirection set to Down__
![](images/RadExpander_Features_ExpandDirection_Down.gif)

#### __Figure 2: ExpandDirection set to Left__
![](images/RadExpander_Features_ExpandDirection_Left.gif)

#### __Figure 3: ExpandDirection set to Right__
![](images/RadExpander_Features_ExpandDirection_Right.gif)

#### __Figure 4: ExpandDirection set to Up__
![](images/RadExpander_Features_ExpandDirection_Up.gif)
