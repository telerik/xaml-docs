---
title: Template Structure
page_title: Template Structure
description: Template Structure
slug: radcontextmenu-styles-and-templates-template-structure
tags: template,structure
published: True
position: 1
---

# Template Structure

Like most {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} controls, the __RadContextMenu__ also allows you to template it in order to change the control from the inside. Except for templating the whole control, you can template parts of it or even independent controls related to it.

>tipFor more information about templating and how to modify the default templates of the __RadControls__ read [Editing Control Templates article]({%slug styling-apperance-editing-control-templates%}) on this matter.

>tipTo learn about the __RadMenuItem's__ templates structure, take a look at the [Templates Structure]({%slug radmenu-styles-and-templates-templates-structure%}) topic in the __RadMenu's__ help.

## RadContextMenu Template Structure

This section explains the structure of the __RadContextMenu's__ template. Here is a snapshot of the template generated in Expression Blend.

![](images/RadContextMenu_Template_Structure_01.png)

It contains the following parts:

* __[Grid]__ - the layout root for the template and is of type __Border__. Visualizes the background and the border of the __RadMenu__.

	* __[ShadowChrome]__ - represents the shadow of the __RadContextMenu__ and is of type __ShadowChrome__.

	* __[Border]__ - represents the left column of the __RadContextMenu__ and is of type __Border__.

	* __[Border]__ - represents the background and the border of the main content and is of type __Border__.

	* __[ItemsPresenter]__ - represents the host control for the __RadMenu's__ items and is of type __ItemsPresenter__.


# See Also

 * [Styles and Templates - Overview]({%slug radcontextmenu-styles-and-templates-overview%})

 * [Styling the RadContextMenu]({%slug radcontextmenu-styles-and-templates-styling-the-context-menu%})

 * [Visual Structure]({%slug radcontextmenu-visual-structure%})
