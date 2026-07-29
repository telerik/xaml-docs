---
title: How to Disable the Tab Navigation of RadDocking Elements
page_title: How to Disable the Tab Navigation of RadDocking Elements
description: Check our &quot;How to Disable the Tab Navigation of RadDocking Elements&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-how-to-disable-tab-navigation
tags: tab, navigation, disable
published: True
position: 9
---

# How to Disable the Tab Navigation of RadDocking Elements

By default, when tab navigation is used, it is possible to focus __RadDocking__ itself as well as some of its elements such as GridResizer and AutoHideArea.

With R2 2016 of UI for WPF, we introduced a way to easily disable the tab navigation of __RadDocking__ elements. This allows the user to directly navigate to the elements inside the active pane content when the Tab key is pressed.

>important You can use the approach explained here when using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) to set a theme to the Docking control.

Let’s, for example, have a simple RadDocking definition as shown in __Example 1__.

__Example 1: Simple RadDocking definition__

<snippet id='raddocking-how-to-disable-tab-navigation-example_1_simple_raddocking_definition-xaml' />


In the example, when RadDocking receives the focus, a user needs to push the Tab key several times in order to navigate to the TextBox inside the pane as shown in __Figure 1__.   

#### __Figure 1: RadDocking behavior when Tab key is pressed multiple times__
![{{ site.framework_name }} RadDocking RadDocking behavior when Tab key is pressed multiple times](images/docking_tabnavigation_01.png)

In order to change this behavior, you will need to set the __IsTabStop__ property to __False__ for some elements inside __RadDocking__. You can use Styles targeting these elements added inside App.xaml.

__Example 2: Applying IsTabStop through the Styles of RadDocking elements__

<snippet id='raddocking-how-to-disable-tab-navigation-example_2_applying_istabstop_through_the_styles_of_raddocking_elements-xaml' />


>__Example 2__ uses the Office_Black theme, however, the approach is applicable for all themes.

After applying the Styles declared in __Example 2__, the focus goes directly to the TextBox when the user presses the Tab key as shown in __Figure 2__.

#### __Figure 2: RadDocking behavior after disabling Tab navigation of its elements__
![{{ site.framework_name }} RadDocking RadDocking behavior after disabling Tab navigation of its elements](images/docking_tabnavigation_02.png)
