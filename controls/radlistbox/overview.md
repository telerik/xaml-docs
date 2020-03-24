---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadListBox {{ site.framework_name }} control.
slug: radlistbox-overview
tags: overview
published: True
position: 0
---

# Overview

{% if site.site_name == 'Silverlight' %}![Rad List Box Overview 010 SL](images/RadListBox_Overview_010_SL.png){% endif %}{% if site.site_name == 'WPF' %}![Rad List Box Overview 010 WPF](images/RadListBox_Overview_010_WPF.png){% endif %}

Thank you for choosing Telerik __RadListBox__!

__RadListBox__ is a {{ site.framework_name }} control used to display a list of items from which the user can choose. The control has a number of advanced features like multiple selection, autocomplete, keyboard support, drag and drop, as well as rich customization capabilities.

![Rad List Box Overview 02](images/RadListBox_Overview_02_WPF.png)

## Key Features:

* __Selection__: RadListBox provides three selection modes - Single, Multiple and Extended. Read more about this in the [Selection]({%slug radlistbox-features-selection%}) article.

* __AutoComplete__: When the control is focused, the first matching item is selected while the user is typing. Read more about this in the [Autocomplete]({%slug radlistbox-features-autocomplete%}) article.

* __Drag and Drop__: Take advantage of the built-in drag and drop support to reorder items or move them from one RadListBox to another. Read more about this in the [Drag and Drop]({%slug radlistbox-features-dragdrop%}) section.

* __Keyboard Support__: RadListBox supports several keyboard shortcuts for performing the most common task. Read more about this in the [Keyboard Support]({%slug radlistbox-features-keyboard-support%}) article.

* __Theming__: As any other control from the UI for {{ site.framework_name }} suite, RadListBox comes with different themes. Read more about this in the [Styling and Appearance]({%slug styling-apperance-implicit-styles-overview%}) section of the documentation. 

>caution  If you are using [NoXaml binaries]({%slug implicit-styles-styling-the-controls%}), and you have custom Style targeting RadListBoxItem, you have to base the style on the default one of the control. Example 1 demonstrates this approach. __Example 1__ demonstrate this approach.

#### __[C#] Example 1: Implicit Style with BasedOn property set__
	{{region cs-radlistbox-overview_1}}
	 <Style TargetType="telerik:RadListBoxItem" BasedOn="{StaticResource RadListBoxItemStyle}"/>
{{endregion}}

         
>tip Get started with the control with its [Getting Started]({%slug radlistbox-getting-started%}) help article that shows how to use it in a basic scenario.

> Check out the control demos at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](https://demos.telerik.com/silverlight/#ListBox){% endif %}{% if site.site_name == 'WPF' %}[demos.telerik.com](https://demos.telerik.com/wpf/){% endif %}

## See Also
 * [Getting Started]({%slug radlistbox-getting-started%})
 * [Events]({%slug radlistbox-events%})