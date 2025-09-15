---
title: Bind RadTreeView ImageSource Properties
page_title: Bind RadTreeView ImageSource Properties
description: Check our &quot;Bind RadTreeView ImageSource Properties&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-howto-bind-treeview-image-source-property
tags: bind,radtreeview,imagesource,properties
published: True
position: 26
---

# Bind RadTreeView ImageSource Properties

__RadTreeView__ API gives you the ability to define images for each item state (__default__, __expanded__ and __selected__). For more information, take a look at the [Item Images]({%slug radtreeview-feautres-treeviewitem-item-images%}) topic. This topic will walk you through the common task of binding the __RadTreeViewItem's  DefaultImageSrc__ property to a property of a business object. The following cases will be demonstrated:

* [Using style binding](#Using_Style_Binding)
* [Using style selectors](#Using_Style_Selectors)

# Using Style Binding

Suppose that your business object has a property of type string, which stores the path to the image. This property will be bound to the DefaultImageSrc property of the RadTreeViewItem. The easiest way to bind the image path property of the business object to the RadTreeViewItem's DefaultImageSrc property is to define the binding in a style. See the code snippet below:

#### __XAML__
```XAML
	<Style x:Key="ItemContainerStyle" TargetType="telerik:RadTreeViewItem">
		<Setter Property="DefaultImageSrc" Value="{Binding Path=ImagePath}"/>
	</Style>
	....
	<telerik:RadTreeView x:Name="radTreeView" ItemContainerStyle="{StaticResource ItemContainerStyle}"/>
```
	
# Using Style Selectors

Another possible scenario is to display different images for the different types of business objects. This is a perfect case for using a style selector. The solution here is to define a style for each type of business object. Each style should set the DefaultImageSrc/SelectedImageSrc/ExpandedImageSrc properties. Second, you should create a style selector where to implement the logic for selecting the right style. And finally, set the style selector to the [ItemContainerStyleSelector]({%slug radtreeview-styling-and-appearance-item-container-style%}). property of the RadTreeView. For more information take a look at the ItemContainerStyle and [ItemContainerStyleSelector]({%slug radtreeview-populating-with-data-item-container-style-selector%}). topics.

The disadvantage of this approach is that all image paths are static (defined in XAML) and it is not possible to change them. So whenever your application logic allows this, bind the Default/Selected/ExpandedImageSrc property to a property of the business object.