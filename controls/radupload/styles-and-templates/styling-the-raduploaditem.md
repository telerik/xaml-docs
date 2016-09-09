---
title: Styling the RadUploadItem
page_title: Styling the RadUploadItem
description: Styling the RadUploadItem
slug: radupload-styles-and-templates-styling-the-raduploaditem
tags: styling,the,raduploaditem
published: True
position: 3
site_name: Silverlight
---

# Styling the RadUploadItem

>tip Before reading this topic, you might find it useful to get familiar with the [Template Structure of the RadUploadItem control]({%slug radupload-styles-and-templates-template-structure%}).		

The __RadUploadItems__ can be styled by creating an appropriate __Style__ and setting it to the __ItemContainerStyle__ property of the __RadUpload__.	  

You have two options:

* To create an empty style and set it up on your own.		  

* To copy the default style of the control and modify it. 

This topic will show you how to perform the second one.

## Modifying the Default Style

>The __RadUploadItem__ control is located in the __Telerik.Windows.Controls__ namespace of the __Telerik.Windows.Controls.Input__ assembly. In order to use it you have to declare it in XAML: __xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"__ When working in Expression Blend, the namespaces that are needed will be added automatically.

Load your project in Expression Blend and open the User Control that holds the __RadUpload__. You have to use a dummy control in order to get the default style. To create one find the __RadUploadItem__ control in the 'Assets' pane and draw one on the art board. In the 'Objects and Timeline' pane select the __RadUploadItem__ that you've drawn and from the menu choose *Object -> Edit Style -> Edit a Copy*. You will be prompted for the name of the style and where to be placed.		

>tip If you define the style in the Application resources, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking 'OK', Expression Blend will generate the default style of the __RadUploadItem__ control in the __Resources__ section of your User Control. The properties available for the style will be loaded in the 'Properties' pane and you will be able to modify their default values. You can also edit the generated XAML in the XAML View or in Visual Studio.		

To apply the style to the real items, set it to the __ItemContainerStyle__ property of the __RadUpload__.		

#### __[XAML] Example 1: Setting the item style__
{{region xaml-radupload-styles-and-templates-styling-the-raduploaditem_0}}
	<telerik:RadUpload x:Name="radUpload"
	                   ItemContainerStyle="{StaticResource RadUploadItemStyle}" />
{{endregion}}

>Don't forget to delete the dummy __RadUploadItem__ control, when you finish editing the style.		  

# See Also
 * [Styles and Templates - Overview]({%slug radupload-styles-and-templates-overview%})
 * [Template Structure]({%slug radupload-styles-and-templates-template-structure%})
 * [Styling the RadUpload]({%slug radupload-styles-and-templates-styling-the-radupload%})