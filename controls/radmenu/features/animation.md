---
title: Animation
page_title: Animation
description: Animation
slug: radmenu-features-animation
tags: animation
published: True
position: 4
site_name: Silverlight
---

# Animation

The attached properties of the Telerik __AnimationManager__ allow you to apply animation to the expanding and collapsing of the __RadMenuItems__. By default there is one animation defined and it applies to the expanding of the __RadMenuItem__.        

>tipIn order to use the __AnimationManager__you have to add the following namespace: *xmlns:telerikAnimation="clr-namespace:Telerik.Windows.Controls.Animation;assembly=Telerik.Windows.Controls"* 

Here is the default animation value.

#### __XAML__

{{region radmenu-features-animation_0}}
	<telerik:RadMenu>
	    <telerikAnimation:AnimationManager.AnimationSelector>
	        <telerikAnimation:AnimationSelector>
	            <telerikAnimation:SlideAnimation Direction="In"
	                                             SlideMode="Top"
	                                             AnimationName="Expand"
	                                             TargetName="DropDownBorder"
	                                             SpeedRatio="3.0" />
	        </telerikAnimation:AnimationSelector>
	    </telerikAnimation:AnimationManager.AnimationSelector>
	    ...
	</telerik:RadMenu>
{{endregion}}

The animation which the __AnimationManager__ provides is of type __SlideAnimation__. This type of animation is used for hiding and showing popups. It exposes the following properties:        

* __AnimationName__ - the name of the animation.          

* __Direction__ - the direction of the animation. Indicates whether the animated object is sliding in or out of view.          

* __SlideMode__ - the mode of the animation. __Top__ value indicates that the direction is from top to bottom. __Bottom__ value indicates the opposite.          

* __SpeedRatio__ - the coefficient that is applied to the animation duration.          

* __TargetName__ - the name of the control that the animation should affect.          

In order to add an animation for the collapsing of the popup you have to define one more __SlideAnimation__ in the scope of the __AnimationSelector__ and set its properties to the appropriate values. Here is an example how to do this.        

#### __XAML__

{{region radmenu-features-animation_1}}
	<telerik:RadMenu VerticalAlignment="Top" HorizontalAlignment="Left">
	    <telerikAnimation:AnimationManager.AnimationSelector>
	        <telerikAnimation:AnimationSelector>
	            <telerikAnimation:SlideAnimation Direction="In"
	                                             SlideMode="Bottom"
	                                             AnimationName="Expand"
	                                             TargetName="DropDownBorder"
	                                             SpeedRatio="3.0" />
	            <telerikAnimation:SlideAnimation Direction="Out"
	                                             SlideMode="Bottom"
	                                             AnimationName="Collapse"
	                                             TargetName="DropDownBorder"
	                                             SpeedRatio="3.0" />
	        </telerikAnimation:AnimationSelector>
	    </telerikAnimation:AnimationManager.AnimationSelector>
	    ...
	</telerik:RadMenu>
{{endregion}}

# See Also

 * [Icons]({%slug radmenu-features-icons%})

 * [Opening Modes]({%slug radmenu-features-opening-modes%})

 * [Opening and Closing Delays]({%slug radmenu-features-opening-and-closing-delays%})
