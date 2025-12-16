---
title: Enabling the Indicator
page_title: Enabling the Indicator
description: Check our &quot;Enabling the Indicator&quot; documentation article for the RadBusyIndicator {{ site.framework_name }} control.
slug: radbusyindicator-features-enabling-the-indicator
tags: enabling,the,indicator
published: True
position: 0
---

# Enabling the Indicator

To activate the __RadBusyIndicator__ control you have to set its __IsBusy__ boolean property to __True__. 

__Setting the IsBusy property__

```XAML
	<telerik:RadBusyIndicator IsBusy="True"/>
```

You can data bind this property in any way that suits your custom logic. The __RadBusyIndicator__ control will be visible only when the __IsBusy__ property is set to __True__.

__RadBusyIndicator__ also gives you the __IsBusyIndicationVisible__ property. It is a read only boolean property which value will be equal to __True__ whenever the __RadBusyIndicator__ is enabled and the busy content is still visualized.

>tip To read more about the possible scenarios where you can use the __IsBusyIndicationVisible__ property, [look here]({%slug radbusyindicator-how-to-restore-the-focus%}). 

## See Also

 * [Delayed Display]({%slug radbusyindicator-features-delayed-display%})

 * [Integrate with services and a RadWindow]({%slug radbusyindicator-how-to-integrate-with-services-and-radwindow%})
