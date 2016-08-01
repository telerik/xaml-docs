---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: common-faq
tags: general, common, faq, getting, started
published: True
position: 3
---

# Getting Started

Before proceed reading the documentation of our components we strongly recommend first check the fundamental concepts of {% if site.site_name == 'WPF' %}__Windows Presentation Foundation (WPF)__{% endif %}{% if site.site_name == 'Silverlight' %}__Silverlight__{% endif %}. This article contains basic information about the {% if site.site_name == 'WPF' %}__WPF__{% endif %}{% if site.site_name == 'Silverlight' %}__Silverlight__{% endif %} framework features and gives directions on where to find relevant information about them.

## __Overview__ 

{% if site.site_name == 'WPF' %}
__Windows Pesentation Foundation__ provides developers with a unified programming model for building rich Windows smart client user experiences that incorporate UI, media, and documents. 

>important For more information please check the [WPF Overview](http://msdn.microsoft.com/en-us/library/ms754130.aspx) MSDN article.
{% endif %}

{% if site.site_name == 'Silverlight' %}
__Microsoft Silverlight__ is a cross-browser, cross-platform implementation of the .NET Framework for building and delivering the next generation of media experiences and rich interactive applications (RIA) for the Web. You can also create Silverlight applications that run outside of the browser on your desktop. 

>important For more information please check the [Silverlight Overview](http://msdn.microsoft.com/en-us/library/bb404700(VS.95).aspx) MSDN article.
{% endif %}

The next sevel sections describe the most basic features of the framework.

* [XAML (Extensible Application Markup Language)](#what-is-xaml)
* [Assemblies and Namespaces in .NET](#assemblies-and-namespaces-in-net)
* [Events](#events)
* [Attached Properties](#attached-properties)
* [Collections and Data Structures](#collections-and-data-structures)
* [Data Binding](#data-binding)
* [Binding Collections](#binding-collections)
* [Data Conversion](#data-conversion)
* [Commanding](#commanding)
* [Styles and Templates](#styles-and-templates)
* [Style Selectors](#style-selectors)
* [Data Templates](#data-templates)
* [Data Template Selectors](#data-template-selectors)

## What is XAML?

__Extensible Application Markup Language__ (XAML) is an __XML-based markup language__ that is used to construct the visual appearance of an application. XAML to {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} is similar to what HTML is to web. You can find more details on the XAML concepts and how to use the language in your applications in the {% if site.site_name == 'WPF' %}[XAML Overview](http://msdn.microsoft.com/en-us/library/ms752059.aspx){% endif %}{% if site.site_name == 'Silverlight' %}[XAML Overview](https://msdn.microsoft.com/en-us/library/cc189054(VS.95).aspx){% endif %} MSDN article. {% if site.site_name == 'WPF' %}You could as well check the [WPF Architecture](http://msdn.microsoft.com/en-us/library/ms750441.aspx) MSDN article.{% endif %}

## Assemblies and Namespaces in .NET

* __Assemblies__: An assembly is a collection of types and resources that are built to work together and form a logical unit of functionality. All types in the .NET Framework must exist in assemblies and the common language runtime does not support types outside of assemblies. You can find more information in the [Assemblies in the Common Language Runtime](https://msdn.microsoft.com/en-us/library/k3677y81(v=vs.110).aspx) MSDN article.

* __Namespaces__: The namespace keyword is used to declare a scope. Namespaces are a second organizational method that complements assemblies. Namespaces are a way of grouping type names and reducing the chance of name collisions. A namespace can contain both other namespaces and types. The full name of a type includes the combination of namespaces that contain that type. You can find more information in the [Namespaces (C# Programming Guide)](https://msdn.microsoft.com/en-us/library/0d941h9d.aspx) MSDN article.

## Events

{% if site.site_name == 'WPF' %}__WPF__ introduces routed events that can invoke handlers that exist on various listeners in the element tree of an application. For more information please check the [Events](http://msdn.microsoft.com/en-us/library/ms753115.aspx) MSDN article.{% endif %}

{% if site.site_name == 'Silverlight' %}The base class library in __Silverlight__ is a subset of the larger .NET Framework class library. It includes the base data types, such as strings and integers, which are used by all software developers. It also includes such diverse types as type conversion classes, exception classes, collection and container classes, events and event handlers, threading and synchronization classes. For more information please check the [Events Overview](https://msdn.microsoft.com/en-us/library/cc189018(v=vs.95).aspx) MSDN article.{% endif %}

## Attached Properties

An attached property is intended to be used as a type of global property that is settable on any object. For more information please check the {% if site.site_name == 'WPF' %}[Attached Properties Overview](http://msdn.microsoft.com/en-us/library/ms749011.aspx){% endif %}{% if site.site_name == 'Silverlight' %}[Attached Properties Overview](http://msdn.microsoft.com/en-us/library/cc265152(v=vs.95).aspx){% endif %} MSDN article.

## Collections and Data Structures

Detailed information on this topic could be found in the {% if site.site_name == 'WPF' %}[Collections and Data Structures](https://msdn.microsoft.com/en-us/library/7y3x785f(v=vs.110).aspx){% endif %}{% if site.site_name == 'Silverlight' %}[Collections and Data Structures](http://msdn.microsoft.com/en-us/library/7y3x785f(v=vs.95).aspx){% endif %} MSDN article.

## Data Binding

Data binding is the process that establishes a connection between the application UI and the business logic. It provides a simple and consistent way for applications to present and interact with data. Elements can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML. For more information please check the {% if site.site_name == 'WPF' %}[Data Binding](http://msdn.microsoft.com/en-us/library/ms750612.aspx){% endif %}{% if site.site_name == 'Silverlight' %}[Data Binding](http://msdn.microsoft.com/en-us/library/cc278072(v=vs.95).aspx){% endif %} MSDN article.

## Binding Collections

A binding source object can be treated as a data collection of objects that are often grouped together (such as the result of a query to a database). You can enumerate over any collection that implements the [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) interface. However, to set up dynamic bindings so that insertions or deletions in the collection update the UI automatically, the collection must implement the [INotifyCollectionChanged](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx) interface. This interface exposes an event, which should be raised whenever the underlying collection changes. {% if site.site_name == 'WPF' %}WPF provides a built-in implementation of a data collection that implements the INotifyCollectionChanged interface - the [ObservableCollection&lt;T&gt;](http://msdn.microsoft.com/en-us/library/ms668604.aspx) class.{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight provides a built-in implementation of a data collection that implements the INotifyCollectionChanged interface - the [ObservableCollection&lt;T&gt;)](http://msdn.microsoft.com/en-us/library/ms668604(v=vs.95).aspx) class.{% endif %}

## Data Conversion

With the help of __IValueConverter__, you could apply a custom logic to a binding. The converter allows to convert the value of the bound property to another value or even another type. {% if site.site_name == 'WPF' %}For additional information please check the [IValueConverter Interface](http://msdn.microsoft.com/en-us/library/system.windows.data.ivalueconverter.aspx) MSDN article.{% endif %}{% if site.site_name == 'Silverlight' %}For additional information and an example please check the [IValueConverter Interface](https://msdn.microsoft.com/en-us/library/system.windows.data.ivalueconverter(v=vs.95).aspx) MSDN article.{% endif %}

## Commanding

The framework supports a commanding input mechanism which purpose is to separate the logic that executes the command from the object that invokes the command. The most common use of command is the avoid using events and code-behind. Instead, the command and its logic are defined in the view model and then bind to the visual element in the UI. For more information, please check the {% if site.site_name == 'WPF' %}[Commanding Overview](https://msdn.microsoft.com/en-us/library/ms752308(v=vs.110).aspx){% endif %}{% if site.site_name == 'Silverlight' %}[ICommandInterface](https://msdn.microsoft.com/en-us/library/system.windows.input.icommand(v=vs.95).aspx){% endif %} MSDN article{% if site.site_name == 'Silverlight' %} and our 
[Command Support]({%slug common-command-support%}) article{% endif %}.

## Styles and Templates

{% if site.site_name == 'WPF' %}WPF styling and templating refer to a suite of features that allows an application to create visually compelling applications and to standardize on a particular look for their product. For more information, please check the [Styles and Templates](http://msdn.microsoft.com/en-us/library/bb613570.aspx) MSDN article.{% endif %}
{% if site.site_name == 'Silverlight' %} Silverlight styling and templating refer to a suite of features that allows an application to create visually compelling applications and to standardize on a particular look for their product. You can use styles and templates in order to customize control behavior and appearance. For more information, please check the [Styles and Templates](http://msdn.microsoft.com/en-us/library/cc278075(v=vs.95).aspx) MSDN article.{% endif %}

## Data Templates

{% if site.site_name == 'WPF' %}WPF has built-in support for customization of the data presentation and its [data templating](http://msdn.microsoft.com/en-us/library/system.windows.datatemplate.aspx) model provides you with great flexibility. For more information, please check the [Data Templating Overview](http://msdn.microsoft.com/en-us/library/ms742521.aspx) MSDN article.{% endif %}
{% if site.site_name == 'Silverlight' %} Silverlight has built-in support for customization of the data presentation and its. [data templating](https://msdn.microsoft.com/en-us/library/system.windows.datatemplate(v=vs.95).aspx) model provides you with great flexibility. For more information, please check the [Styles and Templates](http://msdn.microsoft.com/en-us/library/cc278075(v=vs.95).aspx) MSDN article.{% endif %}

## Style Selectors

The style selector provides a way to apply different styles based on custom logic. For more information, please check the [StyleSelector Class](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector.aspx) MSDN article.

## Data Template Selectors

The data template selector provides a way to choose different DataTemplate based on the data object and the data-bound element. For more information, please check the [DataTemplateSelector Class](http://msdn.microsoft.com/en-us/library/system.windows.controls.datatemplateselector.aspx) MSDN article.

## See Also  

* [Introduction]({%slug introduction%})
* [Installing Telerik UI on your Computer]({%slug installation-installing-which-file-do-i-need%})
* [Developer Focused Examples]({%slug common-sdk-examples%})
            