---
title: XAML Fundamentals
page_title: Getting Started with XAML
description: Getting Started.
slug: common-faq
tags: general, common, faq, getting, started
published: True
position: 6
---

# Getting Started with XAML

Before proceed reading the __Telerik UI for WPF__ documentation we recommend that you check the fundamental concepts of __Windows Presentation Foundation__ (WPF). This article contains basic information about the WPF framework and tells you where to find relevant information about its features.

## Overview

__Windows Presentation Foundation__ provides a unified programming model for building Windows smart client user experiences that incorporate UI, media, and documents. 

>important For more information, see the [WPF Overview](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/?view=netdesktop-9.0) MSDN article.

The following sections describe the most basic features of the WPF framework.

* [XAML (Extensible Application Markup Language)](#xaml-extensible-application-markup-language)
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

## XAML (Extensible Application Markup Language)

__Extensible Application Markup Language__ (XAML) is an __XML-based markup language__ that is used to construct the visual appearance of an application. XAML to {{ site.framework_name }} what HTML is to web. You can find details on XAML concepts and how to use the language in your applications in the [XAML Overview (WPF .NET](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/xaml/?view=netdesktop-9.0) MSDN article. See also the [WPF Architecture](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/advanced/wpf-architecture?view=netframeworkdesktop-4.8) article.

## Assemblies and Namespaces in .NET

* __Assemblies__: An assembly is a collection of types and resources that are built to work together as a logical unit of functionality. All types in the .NET Framework must exist in assemblies; the common language runtime (CLR) does not support types outside assemblies. For more information, see the [Assemblies in the Common Language Runtime](https://learn.microsoft.com/en-us/dotnet/standard/assembly) MSDN article.

* __Namespaces__: The namespace keyword is used to declare a scope. Namespaces are a second organizational method that complements assemblies. Namespaces are a way of grouping type names reducing the chance of name collisions. A namespace can contain other namespaces and types. The full name of a type includes the combination of namespaces that contain that type. For more information, see the [Namespaces (C# Programming Guide)](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces) MSDN article.

## Events

__WPF__ introduces routed events that can invoke handlers that exist on various listeners in the element tree of an application. For more information, see the [Events](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/advanced/events-wpf?view=netframeworkdesktop-4.8) article.

## Attached Properties

An attached property is used as a type of global property that can be set on any object. For more information, see the [Attached Properties Overview](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/properties/attached-properties-overview?view=netdesktop-9.0) article.

## Collections and Data Structures

Detailed information on this topic can be found in the [Collections and Data Structures](https://learn.microsoft.com/en-us/dotnet/standard/collections/) article.

## Data Binding

Data binding is the process that establishes a connection between the application UI and the business logic. It provides a simple and consistent way for applications to present and interact with data. Elements can be bound to data from a variety of data sources in the form of common language runtime objects and XML. For more information, see the [Data Binding](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/?view=netdesktop-9.0) article.

## Binding Collections

A binding source object can be treated as a data collection of objects that are often grouped together (such as the result of a query to a database). You can enumerate over any collection that implements the [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-9.0) interface. However, to set up dynamic bindings so that insertions or deletions in the collection update the UI automatically, the collection must implement the [INotifyCollectionChanged](https://learn.microsoft.com/en-us/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=net-9.0) interface. This interface exposes an event, that should be raised whenever the underlying collection changes. WPF provides a built-in implementation of a data collection that implements the INotifyCollectionChanged interface — the [ObservableCollection&lt;T&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1?view=net-9.0) class.

## Data Conversion

With the help of __IValueConverter__, you can apply custom logic to a binding. The converter allows you to convert the value of the bound property to another value or to even another type. For more information, see the [IValueConverter Interface](https://learn.microsoft.com/en-us/dotnet/api/system.windows.data.ivalueconverter?view=windowsdesktop-9.0) article.

## Commanding

The WPF framework supports a commanding input mechanism whose purpose is to separate the logic that executes the command from the object that invokes the command. The most common use of commands is the avoid using events and code-behind. Instead, the command and its logic are defined in the view model and then bound to the visual element in the UI. For more information, see the [Commanding Overview](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/advanced/commanding-overview?view=netframeworkdesktop-4.8) article.

## Styles and Templates

WPF styling and templating refer to a suite of features that allows an application to create visually compelling applications in a standardized way. For more information, see the [Styles and Templates](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/styles-and-templates?view=netframeworkdesktop-4.8) MSDN article.

## Data Templates

WPF has built-in support for customizing data presentation. Its [data templating](https://learn.microsoft.com/en-us/dotnet/api/system.windows.datatemplate?view=windowsdesktop-9.0) model provides great flexibility. For more information, see the [Data Templating Overview](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/data-templating-overview?view=netframeworkdesktop-4.8) article.

## Style Selectors

The style selector provides a way to apply different styles based on custom logic. For more information, see the [StyleSelector Class](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.styleselector?view=windowsdesktop-9.0) MSDN article.

## Data Template Selectors

The data template selector enables you to choose different DataTemplate based on the data object and the data-bound element. For more information, see the [DataTemplateSelector Class](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.datatemplateselector?view=windowsdesktop-9.0) MSDN article.

## See Also  

* [Introduction]({%slug introduction%})
* [Installing Telerik UI on your Computer]({%slug installation-installing-which-file-do-i-need%})
* [Developer Focused Examples]({%slug common-sdk-examples%})
            
