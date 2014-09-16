---
title: Styling the ToolWindow
page_title: Styling the ToolWindow
description: Styling the ToolWindow
slug: raddocking-styling-the-toolwindow
tags: styling,the,toolwindow
publish: True
position: 10
---

# Styling the ToolWindow



## 

>As the __ToolWindow__ is created dynamically you cannot set the style for it declaratively. The easiest way to do this is to create a theme for your __RadDocking__ control, add the created style for the __ToolWindow__ in it and apply the theme to the control. To learn how to do it read [this]({%slug raddocking-theming-toolwindow%}) topic.

To create the needed style for the __Theme__ you should use a dummy control. This will allow you to copy the default style for the __ToolWindow__ and modify it to your liking. To do so open the UserControl that hosts your __RadDocking__ in Expression Blend.

From the Assets tab select *Controls -> All -> ToolWindow*.




         
      ![](images/RadDocking_StylingToolWindow_01.png)

Draw one dummy control of this type somewhere on the scene.




         
      ![](images/RadDocking_StylingToolWindow_02.png)

Select it and from the menu choose *Object -> Edit Style -> Edit a Copy. *You will be prompted for the name of the style and where to be placed within your application. After clicking OK, a style for your __ToolWindow__ control will be created.{% if site.site_name == 'Silverlight' %}

Go to the 'Resources' pane and see all of the resources generated for your style.{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadDocking_StylingToolWindow_03.png){% endif %}

* {% if site.site_name == 'Silverlight' %}

__ToolWindow_Background__ - is the background brush used for the tool window control.{% endif %}

* {% if site.site_name == 'Silverlight' %}

__ToolWindow_OuterBorderBrush__ - is the outer border brush used for the tool window control.{% endif %}

* {% if site.site_name == 'Silverlight' %}

__ToolWindow_InnerBorderBrush__ - is the inner border brush used for the tool window control.{% endif %}

* {% if site.site_name == 'Silverlight' %}

__ToolWindow_CloseButtonStyle__ - defines the style for the window's close button.{% endif %}{% if site.site_name == 'Silverlight' %}

Here is an example of the above resources modified:{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadDocking_StylingToolWindow_04.png){% endif %}{% if site.site_name == 'WPF' %}

To change the visual appearance of the __ToolWindow__ control you have to modify its template. To do that click on the palette-like breadcrumb icon and select *Edit Template -> Edit Current*.{% endif %}{% if site.site_name == 'WPF' %}




         
      ![](images/RadDocking_StylingToolWindow_05_WPF.png){% endif %}{% if site.site_name == 'WPF' %}

From the 'Objects and Timeline' pane select the __Border__ control responsible for the border of the __ToolWindow__.{% endif %}{% if site.site_name == 'WPF' %}




         
      ![](images/RadDocking_StylingToolWindow_06_01_WPF.png){% endif %}{% if site.site_name == 'WPF' %}

Modify the value of its __BorderBrush__ property.{% endif %}{% if site.site_name == 'WPF' %}




         
      ![](images/RadDocking_StylingToolWindow_06_02_WPF.png){% endif %}{% if site.site_name == 'WPF' %}

To change the __Background__ of the ToolWindow select the __Border__ control responsible for that.{% endif %}{% if site.site_name == 'WPF' %}




         
      ![](images/RadDocking_StylingToolWindow_07_01_WPF.png){% endif %}{% if site.site_name == 'WPF' %}

Modify its __Background__ property.{% endif %}{% if site.site_name == 'WPF' %}




         
      ![](images/RadDocking_StylingToolWindow_07_02_WPF.png){% endif %}

After finishing with the modifications you have to add the created style to the theme for your __RadDocking__. To learn how take a look at the [Theming the ToolWindow]({%slug raddocking-theming-toolwindow%}) topic.

After moving the style to the theme you can remove it from the resources of your UserControl. Also don't forget to delete the dummy control that you have created.

Here is a snapshot of the final result.




         
      ![](images/RadDocking_StylingToolWindow_08.png)

# See Also

 * [Styling and Appearance - Overview]({%slug raddocking-styling-overview%})

 * [Tool Window]({%slug raddocking-features-tool-window%})

 * [Theming the ToolWindow]({%slug raddocking-theming-toolwindow%})

 * [Drag and Drop]({%slug raddocking-features-drag-and-drop%})

 * [Docked/Floating Panes]({%slug raddocking-features-panes-docked-floating-panes%})
