---
title: Modify the default placement
page_title: Modify the default placement
description: Check our &quot;Modify the default placement&quot; documentation article for the RadBusyIndicator {{ site.framework_name }} control.
slug: radbusyindicator-how-to-modify-default-placement
tags: modify,the,default,placement
published: True
position: 0
---

# Modify the default placement

>tip Before reading this topic, you might find it useful to get familiar with the [Template Structure of the RadBusyIndicator]({%slug radbusyindicator-styles-and-templates-template-structure%}) control.

This topic will show you how to change the default placement of the __RadBusyIndicator__ busy content. By default it appears centered on top of the actual content. In some scenarios you may need to align it differently. In order to do this you will have to slightly modify the __RadBusyIndicator's__ default template.

* The first thing you have to do is to generate the __RadBusyIndicator's__ default template. Load your project in Expression Blend and open the User Control that holds the __RadBusyIndicator__. In the 'Objects and Timeline' pane select the __RadBusyIndicator__ you want to style. From the menu choose *Object -> Edit Template -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.

>tip If you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.After clicking 'OK', Expression Blend will generate the default style of the __RadBusyIndicator__ control in the __Resources__ section of your User Control.

* Navigate to the "Indicator" element, which as it is described in the [template structure]({%slug radbusyindicator-styles-and-templates-template-structure%}) is of type __Border__ and hosts the __RadBusyIndicator's__ progress bar and busy content.

* Set the __HorizontalAlignment__ and __VerticalAlignment__ properties in a way that suits your scenario.

## See Also

 * [Styles and Templates - Overview]({%slug radbusyindicator-styles-and-templates-overview%})

 * [Template Structure]({%slug radbusyindicator-styles-and-templates-template-structure%})

 * [Custom Busy Content]({%slug radbusyindicator-features-custom-busy-content%})
