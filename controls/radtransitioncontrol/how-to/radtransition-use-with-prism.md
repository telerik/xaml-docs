---
title: Use with Prism
page_title: Use with Prism
description: Use with Prism
slug: radtransition-how-to-use-with-prism
tags: use,with,prism
publish: True
position: 1
---

# Use with Prism



## 

The __RadTransitionControl__ can be used together with __Prism__ for defining regions. As it derives directly from the __ContentControl__, it is used in the same way as the __ContentControl__. Just set its __RegionName__ attached property to mark it as a region.

>tipIn order to access the __RegionName__ attached property you have to declare the following namespace:

#### __XAML__

{{region radtransition-how-to-use-with-prism_0}}
	xmlns:Regions="clr-namespace:Microsoft.Practices.Composite.Presentation.Regions;assembly=Microsoft.Practices.Composite.Presentation"
	{{endregion}}



#### __XAML__

{{region radtransition-how-to-use-with-prism_1}}
	<telerik:RadTransitionControl Grid.Column="1"
	                                Regions:RegionManager.RegionName="MainRegion">
	    <telerik:RadTransitionControl.Transition>
	        <telerikTransitions:MotionBlurredZoomTransition />
	    </telerik:RadTransitionControl.Transition>
	</telerik:RadTransitionControl>
	{{endregion}}



>tipYou can find more about __Prism__[here](http://compositewpf.codeplex.com/).

# See Also

 * [Working with the RadTransitionControl]({%slug radtransition-features-working-with-radtransitioncontrol%})

 * [Integration with Content Controls]({%slug radtransition-features-integration-with-content-controls%})

 * [Use with Silverlight Navigation Framework]({%slug radtransition-how-to-use-with-silverlight-navigation-framework%})
