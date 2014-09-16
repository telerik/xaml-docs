---
title: Overview
page_title: Overview
description: Overview
slug: raddatafilter-styles-and-templates-overview
tags: overview
publish: True
position: 0
---

# Overview



## 

This section is intended to give you a broad understanding of the possible ways in which you can change the visual appearance of the __RadDataFilter__. There is also comprehensive information about its __ControlTemplate__. You will need this information if you want to customize its appearance.
        

>To learn how to change the control's theme, please read the common [ Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
            topic.
          

Using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) gives you the ability to easily extract and edit the default ControlTemplates of the controls. You can follow the article on [different approaches on how to extract the ControlTemplates]({%slug styling-apperance-editing-control-templates%}).
        

>There is also another way to obtain the template of a particular visual element.
            In the RadControls installation folder on your PC, go to __Themes__ folder (__Themes.Implicit in case you're using__) and select the theme that you use in your application. Then drill down to find the respective
            __Telerik.Windows.Controls.Data.xaml__ file in that directory. From this resource dictionary you can extract any needed resources.
          

You can modify the look of the __RadDataFilter__ by either changing some of the resources exposed by the API, or by modifying its __ControlTemplate__. In the control template you are allowed to reorder the template parts and to add your own elements. However, when changing the control template you should be careful to include all required parts.
        

>Note that when changing the __ControlTemplate__ you should include all required parts. Even if your code compiles, some of the functionality may be subject to impact due to the omission of the required parts. The required parts are usually marked with the prefix "__PART___".
          

Read the following topics to learn more:

* [Template Structure]({%slug raddatafilter-styles-and-templates-template-structure%})

* [Styling the RadDataFilter]({%slug raddatafilter-styles-and-templates-styling-the-raddatafilter%})

* [Styling the FilterControl]({%slug raddatafilter-styles-and-templates-styling-the-filtercontrol%})

# See Also

 * [Visual Structure]({%slug raddatafilter-visual-structure%})

 * [Getting Started]({%slug datafilter-getting-started%})

 * [End User Manual]({%slug datafilter-end-user-manual%})
