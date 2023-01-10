---
title: No Initial Animation
page_title: No Initial Animation
description: Check our &quot;No Initial Animation&quot; documentation article for the RadTransitionControl {{ site.framework_name }} control.
slug: radtransition-how-to-no-initial-animation
tags: no,initial,animation
published: True
position: 3
---

# {{ site.framework_name }} RadTransitionControl No Initial Animation

Some developers want to play different animation or no animation the first time Content is set. This may due to loading remote data or just a matter of graphic, animation or interaction design. You could easily achieve that by setting different transition on interrupted or completed. For example you could set the initial duration of a transition to be 0:0:0 like this in XAML:

#### __XAML__

{{region xaml-radtransition-how-to-no-initial-animation_0}}
	<telerik:RadTransitionControl x:Name="TransitionControl"
	Duration="0:0:0" 		
	TransitionStatusChanged="RadTransitionControl_TransitionStatusChanged">
	    ...
	</telerik:RadTransitionControl>
{{endregion}}

And then in code behind set the duration to a reasonable time span after the first content appears:

#### __C#__

{{region cs-radtransition-how-to-no-initial-animation_1}}
	private void RadTransitionControl_TransitionStatusChanged(object sender, TransitionStatusChangedEventArgs e)
	{
	    if (e.Status == TransitionStatus.Completed)
	    {
	        this.TransitionControl.Duration = new TimeSpan(0, 0, 1);
	    }
	}
{{endregion}}