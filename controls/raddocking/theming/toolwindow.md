---
title: Theming the ToolWindow
page_title: Theming the ToolWindow
description: Check our &quot;Theming the ToolWindow&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-theming-toolwindow
tags: theming,the,toolwindow
published: True
position: 3
---

# Theming the ToolWindow

To modify the appearance of the ToolWindow you __have__ to create a custom theme and place a style that targets the __ToolWindow__ control in it. The topic assumes that you have already created {% if site.site_name == 'WPF' %}a theme with{% endif %}{% if site.site_name == 'WPF' %}{% endif %}a __ResourceDictionary__ that will host the styles and the resources for your custom theme. To learn how to style it take a look at the [Styling the ToolWindow]({%slug raddocking-theming-toolwindow%}) topic.

Copy the created style with all of the resources it uses and place it in the __ResourceDictionary__ that represents the theme for your __RadDocking__ control.

<snippet id='raddocking-theming-toolwindow-block_1-xaml' />


The next step is to declare the required namespaces in the resource dictionary.

<snippet id='raddocking-theming-toolwindow-block_2-xaml' />


<snippet id='raddocking-theming-toolwindow-block_3-xaml' />


<snippet id='raddocking-theming-toolwindow-block_4-cs' />

<snippet id='raddocking-theming-toolwindow-block_4-vb' />


Finally in order to make the style default for all of the __ToolWindow__ controls you have to set it to the following value.

<snippet id='raddocking-theming-toolwindow-block_5-xaml' />


![{{ site.framework_name }} RadDocking Themed ToolWindow](images/RadDocking_ThemingToolWindow_01.png)

## See Also

 * [Theming - Overview]({%slug raddocking-theming-overview%})

 * [Styling the ToolWindow]({%slug raddocking-styling-the-toolwindow%})

 * [Tool Window]({%slug raddocking-features-tool-window%})

 * [Docked/Floating Panes]({%slug raddocking-features-panes-docked-floating-panes%})
