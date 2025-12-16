---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-styles-and-templates-overview
tags: overview
published: True
position: 0
---

# Overview

This section is intended to give you a broad understanding of the possible ways by which you can change the visual appearance of RadPropertyGrid and its elements. There is also comprehensive information about their ControlTemplates. You will need this information, if you want to customize their appearance.

>tip To learn how to style {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} RadControls read the common topic about [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}).
          

>There is also another way to obtain the template of a particular visual element.In the installation folder on your PC, go to __Themes__ folder (__Themes.Implicit in case you're using__) and select the theme that you use in your application. Then drill down to find the respective __Telerik.Windows.Controls.Data.xaml__ file in that directory. From this resource dictionary you can extract any needed resources.
		  

Note that when changing the ControlTemplate, you should include all required parts. Even if your code compiles, some of the functionality may be subject to impact due to the omission of the required parts. The required parts are usually marked with the prefix "PART_".
To learn more about the styling of RadPropertyGrid specific elements read the following topics:

* [Styling RadPropertyGrid Template Structure]({%slug radpropertygrid-styles-and-templates-templates-structure%})


