---
title: Use with Prism
page_title: Use with Prism
description: Check our &quot;Use with Prism&quot; documentation article for the RadTransitionControl {{ site.framework_name }} control.
slug: radtransition-how-to-use-with-prism
tags: use,with,prism
published: True
position: 1
---

# Use with Prism

The __RadTransitionControl__ can be used together with __Prism__ for defining regions. As it derives directly from __ContentControl__, it can be used as a replacement for it.

>tip Read some more about the __Prism__ library in its [github repository](https://github.com/PrismLibrary/Prism).

__Example 1: Setting the RegionName attached property__

```XAML
	<Grid xmlns:prism="http://prismlibrary.com/"
        xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
        <telerik:RadTransitionControl prism:RegionManager.RegionName="ContentRegion">
			<telerik:RadTransitionControl.Transition>
				<telerikTransitions:MotionBlurredZoomTransition />
			</telerik:RadTransitionControl.Transition>
		</telerik:RadTransitionControl>
	</Grid>
```

## See Also

 * [Working with the RadTransitionControl]({%slug radtransition-features-working-with-radtransitioncontrol%})

 * [Integration with Content Controls]({%slug radtransition-features-integration-with-content-controls%})

  {% if site.site_name == 'Silverlight' %}
 * [Use with Silverlight Navigation Framework]({%slug radtransition-how-to-use-with-silverlight-navigation-framework%})
 {% endif %}