---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadCloudUpload {{ site.framework_name }} control.
slug: radcloudupload-getting-started
tags: getting,started
position: 2
---

# Getting Started with {{ site.framework_name }} CloudUpload

This tutorial will walk you through the creation of a sample application that contains __RadCloudUpload__.

* [Adding Telerik Assemblies Using NuGet](#adding-telerik-assemblies-using-nuget)
* [Adding Assembly References Manually](#adding-assembly-references-manually)
* [Defining the UI](#defining-the-ui)
* [Creating the Provider](#creating-the-provider)

## Adding Telerik Assemblies Using NuGet

To use __RadCloudUpload__ when working with NuGet packages, install the `Telerik.Windows.Cloud.Controls.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.Cloud__
* __Telerik.Windows.Cloud.Controls__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining the UI

The following example shows how to define a RadCloudUpload control and a RadCloudUploadList to show the selected files prepared for upload.

__Example 1: Defining RadCloudUpload and RadCloudUploadList__
<snippet id='radcloudupload-getting-started-example_1_defining_radcloudupload_and_radclouduploadlist-xaml' />


> The cloud upload control itself provides only a UI and an interface to execute the upload task. However, the upload process should be implemented with additional custom code. The next section shows how to set up this.

## Creating the Provider

RadCloudUpload uses a provider interface to upload files to the service of your choice. To create the provider you will need to define a class that implements the __ICloudUploadProvider__ interface. The interface exposes a single method - __UploadFileAsync__, which returns a __Task&lt;object&gt;__ object.

This secion will show you how to create a dummy provider that stores the files in a storage in memory. 

__Example 2: Creating a dummy storage and file classes__
<snippet id='radcloudupload-getting-started-example_2_creating_a_dummy_storage_and_file_classes-cs' />


__Example 3: Implementing a dummy ICloudUploadProvider that uploads files to the storage__
<snippet id='radcloudupload-getting-started-example_3_implementing_a_dummy_iclouduploadprovider_that_uploads_files_to_the_storage-cs' />


__Example 4: Setting the provider__
<snippet id='radcloudupload-getting-started-example_4_setting_the_provider-xaml' />


> The control doesn't have any built-in providers, but you can see how to implement one that connects to the Azure and Amazon services in the [RadCloudUpload SDK examples](https://github.com/telerik/xaml-sdk/tree/master/CloudUpload).

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF CloudUpload Component](https://www.telerik.com/products/wpf/cloud-upload.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-guide%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

## See Also
* [RadCloudUploadList]({%slug radcloudupload-radclouduploadlist%})
* [Providers]({%slug radcloudupload-features-providers%})
* [Events]({%slug radcloudupload-features-events%})
* [Validation]({%slug radcloudupload-features-validation%})


