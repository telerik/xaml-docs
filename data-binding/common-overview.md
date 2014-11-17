---
title: Overview
page_title: Overview
description: Overview
slug: common-data-binding-overview
tags: overview
published: True
position: 0
---

# Overview



{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} data binding provides a simple and consistent way for applications to present and interact with data. Elements can be bound to data from a variety of data sources in the form of CLR objects and XML. __ItemsControl__s such as ListBox have built-in functionality to enable flexible styling of single data items or collections of data items. Sort, filter, and group views can be generated on top of the data.

This topic contains the following sections.

* [What is Data Binding](#What_is_Data_Binding?)

* [Creating a Binding](#Creating_a_Binding)

* [Direction of the Data Flow](#Direction_of_the_Data_Flow)

## What is Data Binding?

Data binding is the process that establishes a connection between the application UI and the business logic. If the binding has the correct settings and the data provides the proper notifications, when the data changes its value, the elements that are bound to the data reflect the changes automatically. Data binding can also mean that if an outer representation of the data in an element changes, then the underlying data can be automatically updated to reflect the change.

## Creating a Binding

This section contains the following subsections.

* [Specifying the Binding Source](#Specifying_the_Binding_Source)

* [Specifying the Path to the Value](#Specifying_the_Path_to_the_Value)

When you establish a binding, you use the 
      [Binding](http://msdn.microsoft.com/en-us/library/system.windows.data.binding.aspx) object, and each binding usually has four components: binding target, target property, binding source, and a path to the source value to use. This section discusses how to set up a binding.

Consider the following example, in which the binding source object is a class named __MyData__. The __MyData__ class has a string property named __Color__and with its help the value is set to "Red".

#### __XAML__

{{region common-data-binding-overview_0}}
	<UserControl.Resources>
	    <example:MyData x:Key="DataSource"/>
	</UserControl.Resources>
	
	<Grid x:Name="LayoutRoot" DataContext="{Binding Source={StaticResource DataSource}}">   
	    <TextBox Text="{Binding Color}"/>
	</Grid>
	{{endregion}}



>tipYou can read more information about the binding declaration syntax [here](http://msdn.microsoft.com/en-us/library/ms752300.aspx).

## Specifying the Binding Source

Notice that in the previous example, the binding source is specified by setting the [DataContext](http://msdn.microsoft.com/en-us/library/system.windows.frameworkelement.datacontext.aspx) property on the __Grid__ element. The __TextBox__then inherits the __DataContext__ value from the __Grid__, which is its parent element. To reiterate, the binding source object is one of the four necessary components of a binding. Therefore, without the binding source object being specified, the binding won't do anything.

There are several ways to specify the binding source object. One way is by using the __DataContext__ property on a parent element - this is useful when you are binding multiple properties to the same source. However, sometimes it may be more appropriate to specify the binding source on individual binding declarations. For the previous example, instead of using the __DataContext__property, you can specify the binding source by setting the __Source__property directly on the binding declaration of the textbox. See the following example.

#### __XAML__

{{region common-data-binding-overview_1}}
	<TextBox Text="{Binding Source={StaticResource DataSource}, Path=Color}"/>
	{{endregion}}



Another way to specify the binding source object is to use the __ElementName__ property or the __RelativeSource__ property to specify the binding source. The __ElementName__ property is useful when you are binding to other elements in your application. For example, when you are using a __Slider__ to adjust the width of a __Button__. The __RelativeSource__property is useful when the binding is specified in a __ControlTemplate__.

>tipThere are several ways to specify the binding source object:

* Using__DataContext__.

* Explicitly specifying the binding source by setting the __Binding__'s __Source__ property.

* Using __ElementName__.

* Using __RelativeSource__.

## Specifying the Path to the Value

If your binding source is an object, you use the __Path__property to specify the value which will be needed for your binding. {% if site.site_name == 'WPF' %}If you are binding to XML data, you use the __XPath__ property to specify the value.{% endif %}

Note that although the __Path__to the value to use is one of the four necessary components of a binding, in the scenarios when you want to bind to an entire object, the value to use would be the same as the binding source object. In those cases, it is applicable to not specify a __Path__, like in the example below.

#### __XAML__

{{region common-data-binding-overview_2}}
	<ListBox ItemsSource="{Binding}"/>
	{{endregion}}



In the above example the empty binding syntax is used (__{Binding}__). In this case, the __ListBox__ inherits the __DataContext__ from a parent __Grid__ element (not shown in this example). When the path is not specified, the default is to bind to the entire object. Or in other words, the path has been left out because the __ItemsSource__ is bound to the entire object.

## Direction of the Data Flow

The data flow of a binding can go from the binding target to the binding source and/or from the binding source to the binding target if the binding source provides the proper notifications.

You may want your application to enable users to change the data and propagate it back to the source object. Or you may not want to enable users to update the source data. You can control this by setting the Binding's Mode property object. The following list illustrates the different types of data flow:

* __OneWay binding__ - makes changes to the source property to automatically update the target property, but changes to the target property are not propagated back to the source property. This type of binding is appropriate if the control being bound is implicitly read-only.

>In order to implement __OneWay binding__your business objects/collections must implement the __INotifyPropertyChanged__/__INotifyCollectionChanged__ interfaces.

* __TwoWay binding__ - makes changes to either the source property or the target property to automatically update the other. This type of binding is appropriate for editable forms or other fully-interactive UI scenarios.

>In order to implement __TwoWay binding__your business objects/collections must implement the __INotifyPropertyChanged__/__INotifyCollectionChanged__ interfaces.

* __OneTime binding__ - makes the source property to initialize the target property, but subsequent changes do not propagate.

* __OneWayToSource binding__ - updates the source property when the target property changes. This is the opposite to the __OneWay__binding.

# See Also

 * [Data Conversion]({%slug common-data-binding-data-conversion%})

 * [Binding to Collections]({%slug common-data-binding-binding-to-collection%})

 * [Data Templates]({%slug common-data-binding-data-templates%})
