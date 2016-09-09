---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radupload-getting-started
tags: getting,started
published: True
position: 3
site_name: Silverlight
---

# Getting Started

__RadUpload__ has a client and a server side part. The client side is executed entirely in the browser using the Silverlight platform. The server side requires a handler on the server for processing the files that are submitted from the client side. This topic will explain the basics of:

* [Configuring the server side](#Configuring_the_server_side)

* [Configuring the client side](#Configuring_the_client_side)

## Configuring the server side

The first thing you have to do is to add a reference to the __Telerik.Windows.RadUploadHandler__ assembly in the ASP.NET application that hosts your Silverlight application. After that create a Generic (__ASHX__) Handler, that derives from the __RadUploadHandler__ class.
![](images/RadUpload_GettingStarted_01.png)

#### __[C#] Example 1: Create a generic handler__
{{region cs-radupload-getting-started_0}}
	public class SampleUploadHandler : RadUploadHandler
	{
	}
{{endregion}}


#### __[VB.NET] Example 1: Create a generic handler__
{{region vb-radupload-getting-started_1}}
	Public Class SampleUploadHandler
	 Inherits RadUploadHandler
	End Class
{{endregion}}

Create a folder, in which the uploaded files will be stored.
![](images/RadUpload_GettingStarted_02.png)

>Please note that the target folder should be in the same folder as the upload handler.

To test the handler point your browser to the SampleUploadHandler.ashx file. You should see the following output if everything is done correctly.
![](images/RadUpload_GettingStarted_03.png)

## Configuring the client side

The first thing you have to do on the client side is to declare a __RadUpload__ control in the appropriate UserControl.
		

>In order to use __RadUpload__ control in your projects you have to add references to the following assemblies:<br/>1. __Telerik.Windows.Controls__<br/>2. __Telerik.Windows.Controls.Input__<br/>{% if site.site_name == 'WPF' %}You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).{% endif %}{% if site.site_name == 'Silverlight' %}You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).{% endif %}

#### __[XAML] Example 2: RadUpload definition__
{{region xaml-radupload-getting-started_2}}
	<UserControl x:Class="RadUploadSamples.GettingStarted"
	             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	             xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
	    <Grid x:Name="LayoutRoot" Background="White">
	        <telerik:RadUpload />
	    </Grid>
	</UserControl>
{{endregion}}

Next you have to set the __UploadServiceUrl__ property of the __RadUpload__. The value can be an absolute or relative url that points to the upload handler.		

>The domain where the Silverlight application is hosted should be the same as the domain where the upload handler is hosted, otherwise a cross-domain conflict will occur. In such case you have to add a Cross-Domain Policy file to the services domain.

For example, if you rely on the absolute path, the __UploadServiceUrl__ should point to http://localhost:6519/SampleUploadHandler.ashx and the Silverlight application should be hosted on the same domain - for example on this url: http://localhost:6519/index.html. Note that the port of the application should be the same (in this case the port is set to 6519, but any other port - including the default port 80 - will work).		

If you prefer the relative path then pay attention to the following things: 

* if the path begins with "/" or "~/" then it is relative to the root of the domain where the Silverlight application had been loaded.

* if the path begins with "./" then it is relative to the location of the Silverlight application.

* if the path begins with one or more "../", then it is relative to the location above the location of the Silverlight application.

#### __[XAML] Example 3: Setting the upload service URL property__
{{region xaml-radupload-getting-started_3}}
	<telerik:RadUpload UploadServiceUrl="/SampleUploadHandler.ashx" />
{{endregion}}

The last thing to do is to set the __TargetFolder__ property. The __TargetFolder__ should point to the folder that is configured to accept the uploaded files. In our case the __TargetFolder__ should be set to "UserUploads".		

>Please note that the __TargetFolder__ property represents the path relative to the upload handler.		  

#### __[XAML] Example 4: Setting the target folder__
{{region xaml-radupload-getting-started_4}}
	<telerik:RadUpload UploadServiceUrl="/SampleUploadHandler.ashx"
					   TargetFolder="UserUploads" />
{{endregion}}

This is enough to make the __RadUpload__ work. To fine tune the upload to match your application requirements, read the following topics.		

* [Working with RadUpload]({%slug radupload-features-working-with-radupload%})

* [Upload Handler]({%slug radupload-features-upload-handler%})

* [Automatic Upload]({%slug radupload-features-automatic-upload%})

* [Upload Service Parameters]({%slug radupload-features-upload-service-parameters%})

* [File Size and Count Limitations]({%slug radupload-features-file-size-and-count-limitation%})

* [Multiple Times File Selection]({%slug radupload-features-multiple-times-file-selection%})

* [Multiple Files Selection]({%slug radupload-features-multiple-files-selection%})

* [Extension Filters]({%slug radupload-features-extension-filters%})

* [Overwriting Existing Files]({%slug radupload-features-overwrite-existing-files%})

* [Buffering]({%slug radupload-features-buffering%})

* [Programmatic Upload]({%slug radupload-features-programmatic-upload%})

## See Also
 * [Visual Structure]({%slug radupload-visual-structure%})
 * [Working with RadUpload]({%slug radupload-features-working-with-radupload%})
 * [Events - Overview]({%slug radupload-events-overview%})
 * [Styles and Templates - Overview]({%slug radupload-styles-and-templates-overview%})
 * [Localization]({%slug radupload-localization%})
