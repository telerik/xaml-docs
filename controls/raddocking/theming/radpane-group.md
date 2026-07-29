---
title: Theming the RadPaneGroup
page_title: Theming the RadPaneGroup
description: Check our &quot;Theming the RadPaneGroup&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-theming-radpane-group
tags: theming,the,radpanegroup
published: True
position: 2
---

# Theming the RadPaneGroup

To modify the appearance of the __RadPaneGroup__ you have to create a custom theme and place a style that targets the __RadPaneGroup__ control in it. The topic assumes that you have created {% if site.site_name == 'WPF' %}a theme with{% endif %}{% if site.site_name == 'WPF' %}{% endif %}a __ResourceDictionary__ that will host the styles and the resources for your custom theme. To learn how to style it read the [Styling the RadPaneGroup]({%slug raddocking-styling-the-radpanegroup%}) topic.

Copy the created style with all of the resources it uses and place it in the __ResourceDictionary__ that represents the theme for your __RadDocking__ control.

<snippet id='raddocking-theming-radpane-group-block_1-xaml' />


The next step is to declare the required namespaces in the resource dictionary.



<snippet id='raddocking-theming-radpane-group-block_2-xaml' />


<snippet id='raddocking-theming-radpane-group-block_3-xaml' />


<snippet id='raddocking-theming-radpane-group-block_4-cs' />

<snippet id='raddocking-theming-radpane-group-block_4-vb' />


Finally in order to make the style default for all of the __RadPaneGroup__ controls you have to set it to the following value.

<snippet id='raddocking-theming-radpane-group-block_5-xaml' />


![{{ site.framework_name }} RadDocking Themed RadPaneGroup](images/RadDocking_ThemingRadPaneGroup_01.png)

## See Also

 * [Styling the RadPaneGroup]({%slug raddocking-styling-the-radpanegroup%})

 * [Pane Groups]({%slug raddocking-features-pane-groups%})
