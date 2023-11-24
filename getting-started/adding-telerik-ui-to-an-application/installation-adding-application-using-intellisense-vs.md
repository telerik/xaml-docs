---
title: Using IntelliSense in Visual Studio
page_title: Using IntelliSense in Visual Studio
description: This article describes the IntelliSense feature of Visual Studio.
slug: installation-adding-application-using-intellisense-vs
tags: using,intellisense,in,visual,studio
published: True
position: 5
---

# Using IntelliSense in Visual Studio

Visual Studio automatically enables [IntelliSense](http://en.wikipedia.org/wiki/IntelliSense) - it detects all classes, properties and methods in the __DLL__ file.

## Using IntelliSense when Declaring Namespace

When declaring a namespace you can select from the IntelliSense in XAML any namespace which is available:
{% if site.site_name == 'WPF' %}
![Common Installing Namespace Declaration 1](images/installation-adding-application-using-intellisense-vs-wpf-0.png)
{% else %}
![Common Installing Namespace Declaration 2](images/installation-adding-application-using-intellisense-vs-wpf-1.png)
{% endif %}

For more information about declaring namespaces read [here]({%slug installation-adding-application-namespace-declaration%}).

## Using IntelliSense when Adding/Configuring Controls in XAML

When you add a new control (or configure an existing one) in the XAML, Visual Studio will automatically show a dropdown with suggestions for autocomplete. For example, see the next two figures.

![Common Installing Namespace Declaration 3](images/installation-adding-application-using-intellisense-vs-wpf-2.png)
![Common Installing Namespace Declaration 4](images/installation-adding-application-using-intellisense-vs-wpf-3.png)

## Using IntelliSense in the Code-Behind

In the code-behind, each time a particular class/property/method is being selected from the dropdown of the autocomplete functionality, a tooltip with the comment for this class/property/method is displayed.

![Common Installing Namespace Declaration 5](images/installation-adding-application-using-intellisense-vs-wpf-4.png)

## See Also  
{% if site.site_name == 'WPF' %}
 * [Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version]({%slug installation-upgrading-from-trial-to-developer-license-wpf%})
 * [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%})
{% else %} 
 * [Controls Dependencies]({%slug installation-installing-controls-dependencies%})
{% endif %}