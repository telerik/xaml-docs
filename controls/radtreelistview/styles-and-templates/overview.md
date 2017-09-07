---
title: Overview
page_title: Overview
description: Overview
slug: radtreelistview-styles-and-templates-overview
tags: overview
published: True
position: 0
---

# Overview



## 

This section is intended to give you a broad understanding of the possible ways by which you can change the visual appearance of the __RadTreeListView__ and its elements.  There is also comprehensive information about their __ControlTemplates__. You will need this information if you want to customize their appearance.
        

>tip To learn how to style {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} RadControls read the common topics about [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) and [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}). If you are new to the controls, they will give you the basic knowledge about it.
		

>There is also another way to obtain the template of a particular visual element. In the RadControls installation folder on your PC, go to __Themes__ folder (__Themes.Implicit in case you're using__) and select the theme that you use in your application. Then drill down to find the respective __Telerik.Windows.Controls.GridView.xaml__ file in that directory, like it is demonstrated in the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) topic. From this resource dictionary you can extract any needed resources.
		  

You can modify the look of the __RadTreeListView__ and its elements by either changing some of the resources exposed by the API, or by modifying their __ControlTemplates__. In the control template, you are allowed to reorder the template parts and to add your own elements. However, when changing the control template you should be careful to include all required parts.
        

As the __RadTreeListView__ inherits the __RadGridView__, it uses the same styling mechanism. To learn more about how to style specific parts of the control, take a look at the [Styles and Templates]({%slug gridview-stylines-and-templates-overview%}) topics in the __RadGridView's__ documentation.
        

>As of __2013 Q2 SP__ we have introduced __Lightweight Templates__ for __RadGridView__ and __RadTreeListView__. Their main idea is to limit the number of visual elements within the templates in order to speed up the performance of the control. [Read more]({%slug gridview-overview-lightweight-template%})

## See Also

 * [Visual Structure]({%slug radtreelistview-visual-structure%})

 * [Getting Started]({%slug radtreeliestview-getting-started%})
