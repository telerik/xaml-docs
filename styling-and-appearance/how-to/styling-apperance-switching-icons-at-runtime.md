---
title: Switching Icons at Runtime
page_title: Switching Icons at Runtime
description: This article explains how to switch the icon set during runtime to go with the look and feel of your application.
slug: styling-apperance-switching-icons-at-runtime
tags: switching,themes,icons,at,runtime
published: True
position: 11
---

# Switching Icons at Runtime


By utilizing the [implicit styling approach ]({%slug styling-apperance-implicit-styles-overview%}) you have the ability to switch the theme of Telerik WPF controls at run-time. With the large set of themes available in the suite this can drastically change the look and feel of your application.


To help you achieve a consistent look we also provide a way for you to dynamically change the images in your application through the __IconResource__ [markup extension](https://msdn.microsoft.com/en-us/library/ms747254(v=vs.100).aspx). The extension allows you to define three different URI-based paths which point to set of icons and then easily swap one set with another.


## How To Use IconSources


To take advantage of the extension you need to define a resource of type __IconSources__ holding the paths to the sets of icons. __Example 1__ demonstrates how to define a resource in XAML.


__Example 1: Creating IconSources__

```XAML
    <telerik:IconSources x:Key="IconSources" />
```


>__IconsSources__ resides in the __Telerik.Windows.Controls.dll__, so you need to add a reference to the assembly  to your project first.


__IconSources__ has three distinct properties to which you can assign base paths for your images.


* __LightBasePath__
* __DarkBasePath__
* __ModernBasePath__


The __LightBasePath__ property represents a path to the default icon set destination, so setting it is mandatory.


__Example 2__ shows an example on how to define __IconSources__ and set two of its path properties.


__Example 2: Setting Paths to IconSources__

```XAML
    <telerik:IconSources x:Key="IconPaths" LightBasePath="/IconSourceDemo;component/Icons/Light/" DarkBasePath="/IconSourceDemo;component/Icons/Dark/" />
```


Once the paths are set, the __IconResource__ extension can be used to set the source of objects of type __ImageSource__. __Example 3__ shows how to define an __Image__ object in XAML pointing to the *background.png* image in the folder paths from __Example 2__.


__Example 3: Setting ImageSource Using IconResource__

```XAML
    <Image Source="{telerik:IconResource IconRelativePath=background.png, IconSources={StaticResource IconPaths}}" Stretch="None" />
```


Presuming there is an image with file name *background.png* in the *Icons/Light/* folder of your application, __Figure 1__ shows the result of __Examples 1 – 3__.


#### __Figure 1: ImageSource Set by IconResource__ 

![ImageSource Set by IconResource](images/Switching_Icons_Runtime_01.png)


Changing the image is achieved by calling the static __ChangeIconsSet()__ method of __IconSources__.

<a name="example4"><a/>

__Example 4: Changing Icon Set__

```C#
	IconSources.ChangeIconsSet(IconsSet.Dark);
```


This will trigger a change in the source of the __Image__ and will show the *background.png* image located in the *Icons/Dark* folder of your application.


>importantBecause the relative path to the icon is defined for each image source, for the switch to work the images in the separate folders need to be with the same names.


__Figure 2__ shows the result after the code in __Example 4__ is executed.

#### __Figure 2: Image After Changing the IconSet__

![Image After Changing the IconSet](images/Switching_Icons_Runtime_02.png)


>tipYou can find the complete code of the previous example in our online SDK repository [here](https://github.com/telerik/xaml-sdk/tree/master/Common).


## Available Icon Sets


Several of the controls in the Telerik UI for WPF suite come with sets of icons that can be used with them. The paths to all such images are consistent with the requirements imposed by the __IconResource__ extension, so you can use it to switch those icons run-time. 


__RadPdfViewer__, for example, comes with two distinct sets of icons located in the __Telerik.Windows.Controls.FixedDocumentViewers__ assembly. Defining an __IconSources__ resource for the viewer is shown on __Example 5__.


__Example 5: Creating IconSources for RadPdfViewer__

```XAML
    <telerik:IconSources x:Key="PdfViewerIconPaths" LightBasePath="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/Modern/" 
                             DarkBasePath="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/" />
```


And you can use this resource to define images pointing to one of the base paths location.


__Example 6: ImageSource Set to RadPdfViewer Icon__

```XAML
    <Image Source="{telerik:IconResource IconRelativePath=open.png,IconSources={StaticResource PdfViewerIconPaths}}" Stretch="None" />
```


Both __IconSource__ resources defined in the article are in the same view pointing to different base paths for images. The result of __Example 6__ is shown on __Figure 3__.


#### __Figure 3: ImageSource Set to RadPdfViewer Icon__

![ImageSource Set to RadPdfViewer Icon](images/Switching_Icons_Runtime_03.png)


Changing the icon set used in the application with the code from __Example 4__ will change it for both images, regardless of the fact that they use separate base paths. The result is demonstrated on __Figure 4__.


#### __Figure 4: Images After Changing the IconSet__

![Images After Changing the IconSet](images/Switching_Icons_Runtime_04.png)


>tipYou can find the complete code of the previous example in our online SDK repository [here](https://github.com/telerik/xaml-sdk/tree/master/Common).



## See Also

* [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
* [RadPdfViewer IconSource]({%slug radpdfviewer-ui-switching-icons-at-runtime%})
* [RadSpreadsheet IconSource]({%slug radspreadsheet-howto-switching-icons-at-runtime%})
* [RadRichTextBox IconSource]({%slug radrichtextbox-how-to-switching-icons-at-runtime%}) 
