---
title: Overview
page_title: Overview
description: Overview
slug: radexpressioneditor-styles-and-templates-overview
tags: overview
publish: True
position: 0
---

# Overview



## 

This section is intended to give you a broad understanding of the possible ways by which you can change the visual appearance of the __RadExpressionEditor__ and its elements. There is also comprehensive information about their __ControlTemplates__. You will need this information, if you want to customize their appearance. 

>tip
		  To learn how to style {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}__RadControls__ read the common topics about
		  [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}). If you are new to the controls, they will give you the basic knowledge about it.
		

>There is also another way to obtain the template of a particular visual element.
			In the RadControls installation folder on your PC, go to __Themes__ folder (__Themes.Implicit in case you're
			  using__) and select the theme that you use in your application. Then drill down to find the respective
			__Telerik.Windows.Controls.Expressions.xaml__ file in that directory, like it is demonstrated in the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) topic. From this resource dictionary you can extract any needed resources.
		  

Note that when changing the __ControlTemplate__, you should include all required parts. Even if your code compiles, some of the functionality may be subject to impact due to the omission of the required parts. The required parts are usually marked with the prefix __"PART_"__.
To learn more about the template of the __RadExpressionEditor__ specific elements take a look at the Templates Structure article.


