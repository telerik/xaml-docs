---
title: Integration with Content Controls
page_title: Integration with Content Controls
description: Check our &quot;Integration with Content Controls&quot; documentation article for the RadTransitionControl {{ site.framework_name }} control.
slug: radtransition-features-integration-with-content-controls
tags: integration,with,content,controls
published: True
position: 4
---

# Integration with Content Controls

The __RadTransitionControl__ can be easily integrated in other more complex __ContentControls__ in order to extend their functionality. For example - __ScrollViewer__, __HeaderedContentControl__ etc.

>tip You can also integrate the __RadTransitionControl__ in any control that somehow visualizes content.

To integrate a __RadTransitionControl__ with a more complex __ContentControl__, you have to replace the __ContentControl__ or the __ContentPresenter__ of the latter one __ControlTemplate__ with an instance of the __RadTransitionControl__ and to configure the __TemplateBindings__ for the __Content__ and the __ContentTemplate__ properties.

Here is an example with the __HeaderedContentControl__. Take a look at the default __ControlTemplate__:

>In order to use the __HeaderedContentControl__ you have to add the following namespace to your __UserControl__:
>	*xmlns:controlsToolkit="clr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Toolkit"*



<snippet id='radtransitioncontrol-features-radtransition-integration-with-content-controls-block_1-xaml' />



<snippet id='radtransitioncontrol-features-radtransition-integration-with-content-controls-block_2-xaml' />

The first __ContentPresenter__ is responsible for the header and the second one - for the content. Replace the second one with the __RadTransitionControl__ and preserve the __TemplateBindings__.

>In order to use the __RadTransitionControl__ you have to add the following namespace to your __UserControl__:



<snippet id='radtransitioncontrol-features-radtransition-integration-with-content-controls-block_3-xaml' />



<snippet id='radtransitioncontrol-features-radtransition-integration-with-content-controls-block_4-xaml' />



<snippet id='radtransitioncontrol-features-radtransition-integration-with-content-controls-block_5-xaml' />

Next, configure the __RadTransitionControl__ to match your needs. For example, define its __Transition__.

>tip To learn more about working with the __RadTransitionControl__ read [this topic]({%slug radtransition-features-working-with-radtransitioncontrol%}). To learn more about transition effects read the [Transitions]({%slug radtransition-features-transitions%}) topic.

>In order to use the built-in __transition effects__ you have to add the following namespace to your __UserControl__:
>	xmlns:telerikTransitions="clr-namespace:Telerik.Windows.Controls.TransitionEffects;assembly=Telerik.Windows.Controls"



<snippet id='radtransitioncontrol-features-radtransition-integration-with-content-controls-block_6-xaml' />

## See Also

 * [Working with the RadTransitionControl]({%slug radtransition-features-working-with-radtransitioncontrol%})

 * [Transitions]({%slug radtransition-features-transitions%})

 * [Data Binding]({%slug radtransition-features-data-binding%})

 {% if site.site_name == 'Silverlight' %}
 * [Use with Silverlight Navigation Framework]({%slug radtransition-how-to-use-with-silverlight-navigation-framework%})
 {% endif %}