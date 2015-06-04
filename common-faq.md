---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: common-faq
tags: general, common, faq
published: True
position: 3
---

# Common FAQ

We strongly recommend that you first check the fundamental concepts of {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}. Below you can find a list of the most common frequently asked questions.

* __Overview__

{% if site.site_name == 'WPF' %}Windows Presentation Foundation (__WPF__) provides developers with a unified programming model for building rich Windows smart client user experiences that incorporate UI, media, and documents. For more information please check the [WPF Overview](http://msdn.microsoft.com/en-us/library/ms754130.aspx){% endif %}

{% if site.site_name == 'Silverlight' %}__Microsoft Silverlight__ is a cross-browser, cross-platform implementation of the .NET Framework for building and delivering the next generation of media experiences and rich interactive applications (RIA) for the Web. You can also create Silverlight applications that run outside of the browser on your desktop. For more information please check the [Silverlight Overview](http://msdn.microsoft.com/en-us/library/bb404700(VS.95).aspx).{% endif %}

* __What is XAML?__

XAML itself is a larger language concept than WPF. You can find more details on the Extensible Application Markup Language (XAML) concepts and how to use XAML in your applications in this {% if site.site_name == 'WPF' %}[msdn article](http://msdn.microsoft.com/en-us/library/ms752059.aspx). You could as well check this [article](http://msdn.microsoft.com/en-us/library/ms750441.aspx) on WPF Architecture.{% endif %}{% if site.site_name == 'Silverlight' %}[msdn article](http://msdn.microsoft.com/en-us/library/cc189054(VS.95).aspx){% endif %}.
            
* __Assemblies and Namespaces in .NET:__

	* An assembly is a collection of types and resources that are built to work together and form a logical unit of functionality. All types in the .NET Framework must exist in assemblies and the common language runtime does not support types outside of assemblies.

	* The namespace keyword is used to declare a scope. Namespaces are a second organizational method that complements assemblies. Namespaces are a way of grouping type names and reducing the chance of name collisions. A namespace can contain both other namespaces and types. The full name of a type includes the combination of namespaces that contain that type.
            
* __Events__

{% if site.site_name == 'WPF' %}__WPF__ introduces routed events that can invoke handlers that exist on various listeners in the element tree of an application. For more information please check this [msdn article](http://msdn.microsoft.com/en-us/library/ms753115.aspx).{% endif %}{% if site.site_name == 'Silverlight' %} The base class library in Silverlight is a subset of the larger .NET Framework class library. It includes the base data types, such as strings and integers, which are used by all software developers. It also includes such diverse types as type conversion classes, exception classes, collection and container classes, events and event handlers, threading and synchronization classes. For more information please check this[msdn article](http://msdn.microsoft.com/en-us/library/cc221412(VS.95).aspx).{% endif %}

* __Attached Properties__

An attached property is intended to be used as a type of global property that is settable on any object. For more information please check this {% if site.site_name == 'WPF' %}[msdn article](http://msdn.microsoft.com/en-us/library/ms749011.aspx){% endif %}{% if site.site_name == 'Silverlight' %}[msdn article](http://msdn.microsoft.com/en-us/library/cc265152(v=vs.95).aspx){% endif %}.
            
* __Collections and Data Structures__

Detailed information on Collections and DataStructures could be found in this {% if site.site_name == 'WPF' %}[msdn article](http://msdn.microsoft.com/en-us/library/ms753115.aspx).{% endif %}{% if site.site_name == 'Silverlight' %}[msdn article](http://msdn.microsoft.com/en-us/library/7y3x785f(v=vs.95).aspx){% endif %}.
            
* __Binding Collections__

A binding source object can be treated as a data collection of objects that are often grouped together (such as the result of a query to a database). You can enumerate over any collection that implements the [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) interface. However, to set up dynamic bindings so that insertions or deletions in the collection update the UI automatically, the collection must implement the [INotifyCollectionChanged](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx) interface. This interface exposes an event, which should be raised whenever the underlying collection changes. {% if site.site_name == 'WPF' %}WPF provides a built-in implementation of a data collection that exposes the INotifyCollectionChanged interface - this is the              [ObservableCollection(T)](http://msdn.microsoft.com/en-us/library/ms668604.aspx).{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight provides a built-in implementation of a data collection that exposes the INotifyCollectionChanged interface - this is the [ObservableCollection(T)](http://msdn.microsoft.com/en-us/library/ms668604(v=vs.95).aspx).{% endif %}

* __Data Binding__

Data binding is the process that establishes a connection between the application UI and the business logic. It provides a simple and consistent way for applications to present and interact with data. Elements can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML. For more information please check this {% if site.site_name == 'WPF' %}[msdn article](http://msdn.microsoft.com/en-us/library/ms750612.aspx){% endif %}{% if site.site_name == 'Silverlight' %}[msdn article](http://msdn.microsoft.com/en-us/library/cc278072(v=vs.95).aspx){% endif %}.
            
* __Data Conversion__

With the help of __IValueConverter__, you could apply a custom logic to a binding. For additional information and an example please check this [msdn article](http://msdn.microsoft.com/en-us/library/system.windows.data.ivalueconverter.aspx).
            
* __Styles and Templates__

{% if site.site_name == 'WPF' %}WPF styling and templating refer to a suite of features that allow an application to create visually compelling applications and to standardize on a particular look for their product. For more information, please check this [msdn article](http://msdn.microsoft.com/en-us/library/bb613570.aspx).{% endif %}{% if site.site_name == 'Silverlight' %} Silverlight uses default styles and templates for several controls. You can copy these styles and templates into your project and modify them in order to customize control behavior and appearance. For more information, please check this [msdn article](http://msdn.microsoft.com/en-us/library/cc278075(v=vs.95).aspx).{% endif %}

* __DataTemplates__

{% if site.site_name == 'WPF' %}WPF has built-in functionality to support the customization of data presentation and its [data templating](http://msdn.microsoft.com/en-us/library/system.windows.datatemplate.aspx) model provides you with great flexibility. For more information, please check this [msdn article](http://msdn.microsoft.com/en-us/library/ms742521.aspx).{% endif %}{% if site.site_name == 'Silverlight' %} Silverlight uses default styles and templates for several controls. You can copy these styles and templates into your project and modify them in order to customize control behavior and appearance. For more information, please check this [msdn article](http://msdn.microsoft.com/en-us/library/cc278075(v=vs.95).aspx).{% endif %}

* __Style Selectors__

They provide a way to apply styles based on custom logic. For more information, please check this [msdn article](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector.aspx).
            
* __DataTemplate Selectors__

They provide a way to choose a DataTemplate based on the data object and the data-bound element. For more information, please check this [msdn article](http://msdn.microsoft.com/en-us/library/system.windows.controls.datatemplateselector.aspx).
            