---
title: Working with the RadTransitionControl
page_title: Working with the RadTransitionControl
description: Check our &quot;Working with the RadTransitionControl&quot; documentation article for the RadTransitionControl {{ site.framework_name }} control.
slug: radtransition-features-working-with-radtransitioncontrol
tags: working,with,the,radtransitioncontrol
published: True
position: 0
---

# Working with the RadTransitionControl

Tha __RadTransitionControl__ is a __ContentControl__ that can apply a transition effect to its content, when it gets changed. The content of the __RadTransitionControl__ can vary from simple strings to complex __UserControls__, as for any __ContentControl__. The transition effect can be chosen among the built-in ones or you can create a custom one.

>tipFor a quick review of the basic features in a sample scenario you can take a look at the [Getting Started]({%slug radtransition-getting-started%}) topic.

To learn more about the __RadTransitionControl__ features, you can take a look at the following sections inside this topic:

* [Content](#content)

* [Transitions](#transitions)

* [Transition Duration](#transition-duration)

* [Transition Ease](#transition-easing)

## Content

In order to set the content of the __RadTransitionControl__ you have to use its __Content__ property. It is of type object, so you can assign everything to it - simple strings, __UIElements__, __UserControls__ etc.

>Note that if you want to set multiple __UIElements__ as content of the __RadTransitionControl__ you have to wrap them in a layout control such as __Grid__, __StackPanel__, __Canvas__ etc.



```XAML
	<telerik:RadTransitionControl x:Name="radTRansitionControl">
	    <Image Source="/Silverlight.Help.RadTransitionControlSamples;component/Demos/Images/Koala.jpg"
	    Stretch="Uniform"
	    Width="320"
	    Height="240" />
	</telerik:RadTransitionControl>
```

You can also bind the __Content__ of the __RadTransitionControl__ to a data object and use the __ContentTemplate__ property to define a __DataTemplate__ to visualize the object. To learn more about data binding inside __RadTransitionControl__ read the [Data Binding]({%slug radtransition-features-data-binding%}) topic.

## Transitions

When the content of the __RadTransitionControl__ gets changed, the control can apply a transition effect to the change. By default there is no effect specified and in order to specify one you have to use the __Transition__ property.

>tipThere are several built-in transition effects, which are located in the __Telerik.Windows.Control.TransitionEffects__ namespace of the __Telerik.Windows.Controls__ assembly. In order to use them you have to add the following namespace declaration:



```XAML
	xmlns:telerikTransitions="clr-namespace:Telerik.Windows.Controls.TransitionEffects;assembly=Telerik.Windows.Controls"
```



```XAML
	<telerik:RadTransitionControl>
	    <telerik:RadTransitionControl.Transition>
	        <telerikTransitions:MotionBlurredZoomTransition />
	    </telerik:RadTransitionControl.Transition>
	</telerik:RadTransitionControl>
```

To learn more about the different built-in transition effects or how to create your own, read the [Transitions]({%slug radtransition-features-transitions%}) topic.

## Transition Duration

The duration of the transition effect is determined by the __Duration__ property of the __RadTransitionControl__. It's of type __TimeSpan__ and its default value is __1 second__. Here is an example of a __RadTransitionControl__ with a transition duration of __3 seconds__.



```XAML
	<telerik:RadTransitionControl x:Name="radTransitionControl" Duration="00:00:03" />
```

## Transition Easing

The __RadTransitionControl__ allows you to apply an easing function to the transition effect. The easing functions make the animation much more realistic and smoother. There is a set of predefined easing functions in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} and you are allowed to create custom ones, too.

{% if site.site_name == 'Silverlight' %}
>tipTo learn more about the easing functions read [here](http://msdn.microsoft.com/en-us/library/cc189019%28VS.95%29.aspx#easing_functions).
{% endif %}
{% if site.site_name == 'WPF' %}
>tipTo learn more about the easing functions read [here](http://msdn.microsoft.com/en-us/library/ee308751%28v=VS.100%29.aspx).
{% endif %}

By default there is no easing function specified for the __RadTransitionControl__. To specify one you have to set the __Easing__ property to the desired function.



```XAML
	<telerik:RadTransitionControl x:Name="radTransitionControl1">
	    <telerik:RadTransitionControl.Easing>
	        <BackEase EasingMode="EaseInOut" Amplitude="0.5" />
	    </telerik:RadTransitionControl.Easing>
	</telerik:RadTransitionControl>
```

## See Also

 * [Transitions]({%slug radtransition-features-transitions%})

 * [Data Binding]({%slug radtransition-features-data-binding%})

 * [Integration with Content Controls]({%slug radtransition-features-integration-with-content-controls%})

{% if site.site_name == 'Silverlight' %}
 * [Use with Silverlight Navigation Framework]({%slug radtransition-how-to-use-with-silverlight-navigation-framework%})
{% endif %}

 * [Use with Prism]({%slug radtransition-how-to-use-with-prism%})
