---
title: In Code-Behind
page_title: In Code-Behind
description: Check our &quot;In Code-Behind&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-data-code-behind
tags: in,code-behind
published: True
position: 3
---

# In Code-Behind

This article will demonstrate how to define __RadDiagram__, __Shapes__ and __Connections__ in code behind	  

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.		

## Adding Items In Code Behind

Below you can find a code snippet which creates a __RadDiagram__ and adds two Shapes and a Connection in it:
		

<snippet id='raddiagram-populating-with-data-data-code-behind-block_1-cs' />

<snippet id='raddiagram-populating-with-data-data-code-behind-block_1-vb' />


In the code above, we use the static class __ShapeFactory__ from the __Telerik.Windows.Controls.Diagrams__ assembly. Below you can find the list of its static methods for creating an EllipseShape, RectangleShape or Geometry:
		  
		
<snippet id='raddiagram-populating-with-data-data-code-behind-block_2-cs' />

<snippet id='raddiagram-populating-with-data-data-code-behind-block_2-vb' />


Here you see a snapshot of the defined __RadDiagram__:
![raddiagrams-populating-with-data-in-code-behind](images/raddiagrams-populating-with-data-in-code-behind.png)

## See Also
 * [Structure]({%slug raddiagram-structure%})
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Declaratively Populating with Data]({%slug raddiagram-data-declaratively%})
 * [DataBinding]({%slug raddiagram-data-databinding%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Removing Items]({%slug raddiagrams-features-delete%})