---
title: Theming the Pane Header
page_title: Theming the Pane Header
description: Check our &quot;Theming the Pane Header&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-theming-pane-header
tags: theming,the,pane,header
published: True
position: 1
---

# Theming the Pane Header

To modify the appearance of the __PaneHeader__ you have to create a custom theme and place a style that targets the __PaneHeader__ control in it. The topic assumes that you have already created a theme with a __ResourceDictionary__ that will host the styles and the resources for your custom theme. If not take a look at the overview section about [creating the theme]({%slug raddocking-theming-overview%}#creating-the-theme). The topic also assumes that you have already created the style that will be used for the __PaneHeader__ control. To learn how to style it take a look at the [Styling the Pane Header]({%slug raddocking-styling-the-pane-header%}) topic.

Copy the created style with all of the resources it uses and place it in the __ResourceDictionary__ that represents the theme for your __RadDocking__ control.

<snippet id='raddocking-theming-pane-header-block_1-xaml' />


The next step is to declare the required namespaces in the __ResourceDictionary__.

<snippet id='raddocking-theming-pane-header-block_2-xaml' />


{% if site.site_name == 'Silverlight' %}

Finally in order to make the style default for all of the __PaneHeader__ controls you have to leave it without a key. Remove the key from the style.{% endif %}

<snippet id='raddocking-theming-pane-header-block_3-xaml' />


<snippet id='raddocking-theming-pane-header-block_4-cs' />

<snippet id='raddocking-theming-pane-header-block_4-vb' />


Finally in order to make the style default for all of the __PaneHeader__ controls you have to set it to the following value.


<snippet id='raddocking-theming-pane-header-block_5-xaml' />

Here is a snapshot of a sample result.

![{{ site.framework_name }} RadDocking Themed Pane Header](images/RadDocking_ThemingPaneHeader_01.png)

## See Also

 * [Theming - Overview]({%slug raddocking-theming-overview%})

 * [Styling the Pane Header]({%slug raddocking-styling-the-pane-header%})

 * [How to Add Icon to the RadPane's Header]({%slug raddocking-how-to-add-icon-pane-header%})

 * [How to Add Buttons to the Pane Header]({%slug raddocking-how-to-add-buttons-to-the-pane-headers%})
