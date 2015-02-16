---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radribbonview-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadRibbonView__.

## List of all RadRibbonView SDK examples:

{% if site.site_name == 'WPF' %}

* __[Contextual groups-Data binding](https://github.com/telerik/xaml-sdk/tree/master/RibbonView/ContextualGroups-DataBinding)__ - The sample demonstrates how to use the RadRibbonView with data-bound ContextualGroups.

SILVERLIGHT NOTE
Please note that due to limitations in SL we need to set the ContextualTabsStyle property of the RadRibbonView. That style template is different than the default one for the RadRibbonTabs, that is why we need to change its template if we use xaml binaries. However if we use NoXAML binaries you can BasedOn the style to the "ContextualTabsStyle". 
* __[Help functionality](https://github.com/telerik/xaml-sdk/tree/master/RibbonView/HelpFunctionality)__ - This example demonstrates an implementation where an popup window with help content is opened when the F1 key is pressed.

* __[Multiple access keys-Key tips](https://github.com/telerik/xaml-sdk/tree/master/RibbonView/MultipleAccessKeys-KeyTips)__ - The sample demonstrates how to set multiple AccessKeys for the KeyTips of the RadRibbonView by setting attached property of the KeyTipService AccessKeys.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Contextual groups-Data binding](https://github.com/telerik/xaml-sdk/tree/master/RibbonView/ContextualGroups-DataBinding)__ - The sample demonstrates how to use the RadRibbonView with data-bound ContextualGroups.

SILVERLIGHT NOTE
Please note that due to limitations in SL we need to set the ContextualTabsStyle property of the RadRibbonView. That style template is different than the default one for the RadRibbonTabs, that is why we need to change its template if we use xaml binaries. However if we use NoXAML binaries you can BasedOn the style to the "ContextualTabsStyle". 
* __[Help functionality](https://github.com/telerik/xaml-sdk/tree/master/RibbonView/HelpFunctionality)__ - This example demonstrates an implementation where an popup window with help content is opened when the F1 key is pressed.

* __[Multiple access keys-Key tips](https://github.com/telerik/xaml-sdk/tree/master/RibbonView/MultipleAccessKeys-KeyTips)__ - The sample demonstrates how to set multiple AccessKeys for the KeyTips of the RadRibbonView by setting attached property of the KeyTipService AccessKeys.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).