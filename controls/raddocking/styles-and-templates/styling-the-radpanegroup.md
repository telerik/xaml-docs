---
title: Styling the RadPaneGroup
page_title: Styling the RadPaneGroup
description: Styling the RadPaneGroup
slug: raddocking-styling-the-radpanegroup
tags: styling,the,radpanegroup
published: True
position: 8
---

# Styling the RadPaneGroup



## 

>As the __RadPaneGroup__ is created dynamically, you cannot set the style for it declaratively. The easiest way to do this is to create a theme for your __RadDocking__ control, add the created style for the __RadPaneGroup__ in it and apply the theme to the control. To learn how to do it read [this]({%slug raddocking-theming-radpane-group%}) topic.

To create the needed style for the __Theme__ you should use a dummy control. This will allow you to copy the default style for the __RadPaneGroup__ and modify it to your liking. To do so open the UserControl that hosts your __RadDocking__ in Expression Blend.

From the 'Assets' tab select *Controls -> All -> RadPaneGroup*.




         
      ![](images/RadDocking_StylingRadPaneGroup_01.png)

Draw one dummy control of this type somewhere on the scene.




         
      ![](images/RadDocking_StylingRadPaneGroup_02.png)

>tipAfter drawing the __RadPaneGroup__, you won't be able to see it on the scene.

Select it and from the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed within your application.

After clicking OK, a style for your __RadPaneGroup__ control will be created.{% if site.site_name == 'Silverlight' %}

Go to the 'Properties' pane and edit the desired properties. For example, select the __Background__property and see to which local brush it is bound.{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadDocking_StylingRadPaneGroup_05.png){% endif %}{% if site.site_name == 'Silverlight' %}

Here is an example of the above resources modified:{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadDocking_StylingRadPaneGroup_06.png){% endif %}{% if site.site_name == 'WPF' %}

Go to the 'Properties' pane and edit the desired properties. For example, select the __Background__property and modify its value.{% endif %}{% if site.site_name == 'WPF' %}




         
      ![](images/RadDocking_StylingRadPaneGroup_05_06_WPF.png){% endif %}{% if site.site_name == 'WPF' %}

Modify the __BorderBrush__ property too.{% endif %}{% if site.site_name == 'WPF' %}




         
      ![](images/RadDocking_StylingRadPaneGroup_07_08_WPF.png){% endif %}

After finishing with the modifications you have to add the created style to the theme for your __RadDocking__. To learn how take a look at the [Theming the RadPaneGroup]({%slug raddocking-theming-radpane-group%}) topic.

After moving the style to the theme you can remove it from the resources of your UserControl. Also don't forget to delete the dummy control that you have created.

Here is a snapshot of the final result.




         
      ![](images/RadDocking_StylingRadPaneGroup_10.png)

# See Also

 * [Styling and Appearance - Overview]({%slug raddocking-styling-overview%})

 * [Pane Groups]({%slug raddocking-features-pane-groups%})

 * [RadPane]({%slug raddocking-panes-radpane%})

 * [Theming the RadPaneGroup]({%slug raddocking-theming-radpane-group%})

 * [Styling the RadPane]({%slug raddocking-styling-the-radpane%})
