---
title: Styling the Items and Groups
page_title: Styling the Items and Groups
description: Check our &quot;Styling the Items and Groups&quot; documentation article for the RadTimeBar {{ site.framework_name }} control.
slug: radtimebar-styling-the-items-and-groups
tags: styling,the,items,and,groups
published: True
position: 0
---

# Styling the Items and Groups

This section is intended to give you a broad understanding of the possible way in which you can customize the visual appearance of the __RadTimeBar__.        

>This topic will be based on the Windows8 theme          

To learn how to style Silverlight RadControls read the common topics about {% if site.site_name == 'Silverlight' %}[Styling and Appearance](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html){% endif %} {% if site.site_name == 'WPF' %}[Styling and Appearance](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html){% endif %}. If you are new to the controls they will give you the basic knowledge about it.

You have two options:

* To create an empty styles and set it up on your own.
* To copy the default styles of the control and modify it.

This topic will show you how to perform the second one.        

1. Extract the __RadTimeBar__ template through Blend. To learn how refer to the Styling and Appearance link mentioned above and open the "Editing Control Templates in Expression Blend" topic.            

2. Add the Windows8 theme as Resource in your application. The Silverlight themes are located 
            in separate assemblies in order the size of the control assembly to be optimized. 
            The WPF themes are embedded in the control assemblies.

3. Your new Style should be based on the Windows8 Theme using the BasedOn property. When you use this property, the new style will inherit the values of the original style that are not explicitly redefined in the new style.

4. Delete the Theme property setting from the *ItemContainer* of the __RadTimeBar__ Style

5. Extract the default ItemControl style through Blend (to learn how refer to 1.)

6. Edit the ItemControl style as you need and add it as implicit style in your applicationFor example:

	<snippet id='radtimebar-styles-and-templates-styling-the-items-and-groups-block_1-xaml' />

	<snippet id='radtimebar-styles-and-templates-styling-the-items-and-groups-block_2-cs' />
	<snippet id='radtimebar-styles-and-templates-styling-the-items-and-groups-block_3-vb' />

The result can be seen below:
![radtimebar styling items and groups](images/radtimebar_styling_items_and_groups.PNG)