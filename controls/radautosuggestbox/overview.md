---
title: Overview
page_title: Overview
description: This article lists the main features of the RadAutoSuggestBox control.
slug: radautosuggestbox-overview
tags: overview, autosuggestbox
position: 0
CTAControlName: RadAutoSuggestBox
---

# {{ site.framework_name }} RadAutoSuggestBox Overview

__RadAutoSuggestBox__ is a text control that makes suggestions to the users as they type text in. When the text updates an event is fired where you can load suggestions into the drop down of the control.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![{{ site.framework_name }} RadAutoSuggestBox Overview](images/radautosuggestbox-overview-1.png)

## Key Features

* __Keyboard Navigation__: The control provides a built-in support for several keyboard keys. Read more in the [Keyboard Support]({%slug radautosuggestbox-features-keyboard-support%}) article.

* __UI Virtualization__: The drop down list of RadAutoSuggestBox has a built-in UI virtualization which means that only containers for the items in the viewport are generated, thus bringing improved performance in a scenario with big amount of data. 

* __Commands Support__: The search and clear actions of RadAutoSuggestBox are implemented via commands that can be customized or replaced. Read more in the [Commands]({%slug radautosuggestbox-features-commands%}) article.

* __Grouping__: You can enable grouping in the control via the grouping feature of [ICollectionView](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.icollectionview?view=netframework-4.5). Read more in the [Grouping]({%slug radautosuggestbox-features-grouping%}) article.

* __No Results Content__: The control has a presenter that shows custom content when no search results are presented. Read more in the [Getting Started]({%slug radautosuggestbox-getting-started%}) article.

* __Watermark Support__: A watermark is displayed when no text is entered in the TextBox part of the control. Read more in the [Watermark]({%slug radautosuggestbox-features-watermark%}) article.

* __Customizable Appearance__: RadAutoSuggestBox allows you to customize the appearance of its TextBox part, buttons and the drop down. Read more in the [Appearance]({%slug radautosuggestbox-appearance-customize-buttons%}) section of the documentation.

* __Rich Set of Themes__: All Telerik WPF controls support a set of built-in themes that you can choose from. Read more in the [Style an Appearance]({%slug common-styling-appearance-available-themes%}) section of the documentation.

>tip Get started with the control with its [Getting Started]({%slug radautosuggestbox-getting-started%}) help article that shows how to use it in a basic scenario.

>Check out the demos at [demos.telerik.com](https://demos.telerik.com/wpf/).

## See Also   
 * [Visual Structure]({%slug radautosuggestbox-visual-structure%}) 
 * [Events]({%slug radautosuggestbox-events%})
