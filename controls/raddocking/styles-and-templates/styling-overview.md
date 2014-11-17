---
title: Overview
page_title: Overview
description: Overview
slug: raddocking-styling-overview
tags: overview
published: True
position: 0
---

# Overview

This section is intended to give you a broad understanding of the possible ways in which you can change the visual appearance of the __RadDocking__ control. There is also comprehensive information about its __ControlTemplates__. You will need this information if you want to customize their appearance.

>tipTo learn how to style {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} __RadControls__ read the common topics about Styling and Appearance. If you are new to the controls they will give you the basic knowledge about it.

Some of the controls used in the __RadDocking__ are created dynamically. Such controls are the __PaneHeader__, the [RadPaneGroup]({%slug raddocking-features-pane-groups%}), the [ToolWindow]({%slug raddocking-features-tool-window%}) and the [RadSplitConatainer]({%slug raddocking-features-split-container%}). Since these controls are created dynamically you should place their styles in a theme. To learn more about theming the __RadDocking__ control take a look at the [Theming Overview]({%slug raddocking-theming-overview%}) topic.

>tipTo learn how to change the control's theme, please read the common [Theming](http://www.telerik.com/help/silverlight/common-styling-apperance-create-theme-overview.html) topic.

Like most {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} controls, the __RadDocking__ also allows you to template it in order to change the control from the inside. Except for templating the whole control, you can template parts of it or even independent controls related to it. However, when changing the control template you should be careful to include all required parts.

>tipNote that when changing the __ControlTemplate__ you should include all required parts. Even if your code compiles, some of the functionality may be subject to impact due to the omission of the required parts. The required parts are usually marked with the prefix "PART_".

>tipTo learn more about templating the RadControls read the common topic regarding [templating](http://www.telerik.com/help/silverlight/common-styling-appearance-edit-control-templates-blend.html).

Read the following topics to learn:

* [Templates Structure]({%slug raddocking-styles-and-templates-templates-structure%})

* [Controlling Appearance]({%slug raddocking-styling-controlling-appearance%})

* [Styling the RadPane]({%slug raddocking-styling-the-radpane%})

* [Styling the Pane Header]({%slug raddocking-styling-the-pane-header%})

* [Styling the Compass]({%slug raddocking-styling-the-compass%})

* [Styling the RootCompass]({%slug raddocking-styling-the-root-compass%})

* [Styling the Visual Cue]({%slug raddocking-styling-the-visual-cue%})

* [Styling the RadPaneGroup]({%slug raddocking-styling-the-radpanegroup%})

* [Styling the RadDocumentPane]({%slug raddocking-styling-the-raddocumentpane%})

* [Styling the ToolWindow]({%slug raddocking-styling-the-toolwindow%})

* [Styling the RadSplitContainer]({%slug raddocking-styling-the-radsplitcontainer%})

* [Templating the RadDocking]({%slug raddocking-styles-and-templates-templating-the-raddocking%})

# See Also

 * [Overview]({%slug raddocking-overview2%})

 * [Visual Structure]({%slug raddocking-visual-structure%})

 * [Templates Structure]({%slug raddocking-styles-and-templates-templates-structure%})
