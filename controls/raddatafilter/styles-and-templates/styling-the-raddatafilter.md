---
title: Styling RadDataFilter
page_title: Styling RadDataFilter
description: Styling RadDataFilter
slug: raddatafilter-styles-and-templates-styling-the-raddatafilter
tags: styling,the,raddatafilter
published: True
position: 2
---

# Styling RadDataFilter


>Before reading this topic, you might find it useful to get familiar with the  [Template Structure of the RadDataFilter]({%slug raddatafilter-styles-and-templates-template-structure%}) and the [Template Structure of the DataFilterPresenter]({%slug raddatafilter-styles-and-templates-template-structure%}).
        

__RadDataFilter__ exposes a __Style__ property which allows you to apply a style to it and modify its appearance.
      

Using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) gives you the ability to easily extract and edit the default ControlTemplates of the controls. You can follow the article on [different approaches on how to extract the ControlTemplates]({%slug styling-apperance-editing-control-templates%}).
      

## Modifying the Default Style

To copy the default styles, load your project in Expression Blend and open the User Control that holds __RadDataFilter__. In the 'Objects and Timeline' pane select the __RadDataFilter__ you want to style. From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.
        

>If you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking ___'OK'___, Expression Blend will generate the default style of __RadDataFilter__ control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.
        

As the UI of __RadDataPager__ is wrapped in __DataFilterPresenter__ control, you have to style it, too. It can be found in the __ControlTemplate__ for __RadDataFilter__. Bring the __ControlTemplate__ into edit by returning to the main scene, selecting __RadDataPager__ and choosing from the menu *Object -> Edit Template -> Edit Current*. Select         __DataFilterPresenter__ control and from the menu choose *Object -> Edit Style -> Edit a Copy. *This will generate the default style for it in the __Resources__ section.
        

In the generated __Style__ for the __DataFilterPresenter__ you have to find the following:
        

* __DataFilterPresenterItemTemplate__ - a __HierarchicalDataTemplate__, used to display the filtering hierarchy.
            

* __DataFilterPresenterHeaderTemplate__ - a __DataTemplate__, used to display the headers of the composite filters.
          

These two templates contain a control that represents __RadDataFilter's__ UI - the __FilterControl__. Modifying its __Style__, will modify the visual appearance of __RadDataFilter__.
        

To learn how to style __FilterControl__ you can read [this topic]({%slug raddatafilter-styles-and-templates-styling-the-filtercontrol%}).
        

# See Also

 * [Template Structure]({%slug raddatafilter-styles-and-templates-template-structure%})

 * [Styling FilterControl]({%slug raddatafilter-styles-and-templates-styling-the-filtercontrol%})
