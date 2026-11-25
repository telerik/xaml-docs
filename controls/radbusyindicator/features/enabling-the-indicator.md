---
title: Enabling the Indicator
page_title: Enabling the Indicator
description: Check our &quot;Enabling the Indicator&quot; documentation article for the RadBusyIndicator {{ site.framework_name }} control.
components: ["busyindicator"]
slug: radbusyindicator-features-enabling-the-indicator
tags: enabling,the,indicator
published: True
position: 0
---

# Enabling the Indicator

To activate the __RadBusyIndicator__ control you have to set its __IsBusy__ boolean property to __True__. 

__Setting the IsBusy property__

<snippet id='radbusyindicator-features-enabling-the-indicator-setting_the_isbusy_property-xaml' />

You can data bind this property in any way that suits your custom logic. The __RadBusyIndicator__ control will be visible only when the __IsBusy__ property is set to __True__.

__RadBusyIndicator__ also gives you the __IsBusyIndicationVisible__ property. It is a read only boolean property which value will be equal to __True__ whenever the __RadBusyIndicator__ is enabled and the busy content is still visualized.

>tip To read more about using the __IsBusyIndicationVisible__ property to restore focus, see [Restore Focus When RadBusyIndicator Is Hidden]({%slug kb-busyindicator-restore-focus%}).

## See Also

 * [Delayed Display]({%slug radbusyindicator-features-delayed-display%})

 * [Integrate RadBusyIndicator with a Service Call in RadWindow]({%slug kb-busyindicator-integrate-with-services-and-radwindow%})
