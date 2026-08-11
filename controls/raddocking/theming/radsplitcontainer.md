---
title: Theming the RadSplitContainer
page_title: Theming the RadSplitContainer
description: Check our &quot;Theming the RadSplitContainer&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-theming-radsplitcontainer
tags: theming,the,radsplitcontainer
published: True
position: 4
---

# Theming the RadSplitContainer

To modify the appearance of the __RadSplitContainer__ you have to create a custom theme and place a style that targets the __RadSplitContainer__ control in it. The topic assumes that you have already created {% if site.site_name == 'WPF' %}a theme with {% endif %}a __ResourceDictionary__ that will host the styles and the resources for your custom theme. To learn how to style it take a look at the [Styling the RadSplitContainer]({%slug raddocking-styling-the-radsplitcontainer%}) topic.

Copy the created style with all of the resources it uses and place it in the __ResourceDictionary__ that represents the theme for your __RadDocking__ control.

<snippet id='raddocking-theming-radsplitcontainer-block_1-xaml' />


The next step is to declare the required namespaces in the resource dictionary.

<snippet id='raddocking-theming-radsplitcontainer-block_2-xaml' />


<snippet id='raddocking-theming-radsplitcontainer-block_3-xaml' />


<snippet id='raddocking-theming-radsplitcontainer-block_4-cs' />

<snippet id='raddocking-theming-radsplitcontainer-block_4-vb' />


Finally in order to make the style default for all of the __RadSplitContainer__controls you have to set it to the following value.

<snippet id='raddocking-theming-radsplitcontainer-block_5-xaml' />


![{{ site.framework_name }} RadDocking Themed RadSplitContainer](images/RadDocking_ThemingSplitContainer_01.png)

## See Also

 * [Styling the RadSplitContainer]({%slug raddocking-styling-the-radsplitcontainer%})
 * [Split Container]({%slug raddocking-features-split-container%})
