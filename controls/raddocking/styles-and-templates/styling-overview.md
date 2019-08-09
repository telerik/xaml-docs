---
title: Overview
page_title: Overview
description: This article provides general tips for styling the RadDocking control.
slug: raddocking-styling-overview
tags: overview
published: True
position: 0
---

# Overview

This section is intended to give you a broad understanding of the possible ways in which you can change the visual appearance of the __RadDocking__ control. You will need this information if you want to customize its appearance.

>tipTo learn how to style the controls from the __UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}__ suite read the common topics about Styling and Appearance. If you are new to the controls they will give you the basic knowledge about it.

Like most {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} controls, the __RadDocking__ also allows you to template it in order to change the control from the inside. Except for templating the whole control, you can template parts of it or even independent controls related to it.

>tipNote that when changing the __ControlTemplate__ you should include all required parts. Even if your code compiles, some of the functionality may be subject to impact due to the omission of the required parts. The required parts are usually marked with the prefix "PART_".

>tipTo learn more about templating of the controls from the UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} suite read the common topic regarding [templating]({%slug common-styling-appearance-edit-control-templates-blend%}).

The following topics demonstrate how a style can be created for the different elements in a RadDocking:

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

## See Also
 * [Overview]({%slug raddocking-overview2%})
 * [Visual Structure]({%slug raddocking-visual-structure%})
