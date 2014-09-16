---
title: Styling the RadDataFilter
page_title: Styling the RadDataFilter
description: Styling the RadDataFilter
slug: raddatafilter-styles-and-templates-styling-the-raddatafilter
tags: styling,the,raddatafilter
publish: True
position: 2
---

# Styling the RadDataFilter



>tipBefore reading this topic, you might find it useful to get familiar with the
          [Template Structure of the RadDataFilter](40A684F2-83E5-4F3F-83E0-72359B8E802D#RadDataFilter) and the [
            Template Structure of the DataFilterPresenter
          ](40A684F2-83E5-4F3F-83E0-72359B8E802D#DataFilterPresenter).
        

The __RadDataFilter__exposes a __Style__ property which allows you to apply a style to it and modify its appearance.
      

Using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) gives you the ability to easily extract and edit the default ControlTemplates of the controls. You can follow the article on [different approaches on how to extract the ControlTemplates]({%slug styling-apperance-editing-control-templates%}).
      

## Modifying the Default Style

To copy the default styles, load your project in Expression Blend and open the User Control that holds the __RadDataFilter__. In the 'Objects and Timeline' pane select the __RadDataFilter__you want to style. From the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.
        

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __RadDataFilter__control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.
        

As the UI of the __RadDataPager__ is wrapped in the __DataFilterPresenter__ control, you have to style it, too. It can be found in the __ControlTemplate__ for the __RadDataFilter__. Bring the __ControlTemplate__ into edit by returning to the main scene, selecting the __RadDataPager__ and choosing from the menu *Object -> Edit Template -> Edit Current*. Select the __DataFilterPresenter__ control and from the menu choose *Object -> Edit Style -> Edit a Copy. *This will generate the default style for it in the __Resources__ section.
        

In the generated __Style__ for the __DataFilterPresenter__ you have to find the following:
        

* __DataFilterPresenterItemTemplate__ - a __HierarchicalDataTemplate__, used to display the filtering hierarchy.
            

* __DataFilterPresenterHeaderTemplate__ - a __DataTemplate__, used to display the headers of the composite filters.
          

These two templates contain a control that represents the __RadDataFilter's__ UI - the __FilterControl__. Modifying its __Style__, will modify the visual appearance of the __RadDataFilter__.
        

To learn how to style the __FilterControl__ you can read [this topic]({%slug raddatafilter-styles-and-templates-styling-the-filtercontrol%}).
        

# See Also

 * [Template Structure]({%slug raddatafilter-styles-and-templates-template-structure%})

 * [Styling the FilterControl]({%slug raddatafilter-styles-and-templates-styling-the-filtercontrol%})
