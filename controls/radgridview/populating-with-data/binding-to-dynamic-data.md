---
title: Binding to Dynamic Data
page_title: Binding to Dynamic Data
description: This article demonstrates how to bind RadGridView to Dynamic Data.
slug: gridview-binding-dynamic-data
tags: binding,dynamic,data
published: True
position: 10
---

# Binding to Dynamic Data

__RadGridView__ provides support of several types of dynamic data. This article will discuss each one of them.

* [DynamicObject](#dynamicobject)

* [ICustomTypeProvider](#icustomtypeprovider)

* [ICustomTypeDescriptor](#icustomtypedescriptor)

## DynamicObject

>When the bound object is recognized as __IDynamicMetaObjectProvider type__, the control uses separate logic that operates with dynamic types. Thus, standard CLR properties registered in the dynamic type need to be exposed through the DLR API. A detailed look over the approach of achieving this is discussed in the [Have mixed CLR and DLR properties]({%slug gridview-how-to-use-mixed-clr-dlr-properties%}) topic.

The control supports binding to any type that implements the standard DLR interface  __IDynamicMetaObjectProvider__ , such as __DynamicObject__ and __ExpandoObject__. An example of such implementation with the control is demonstrated in the [Binding to DynamicObject SDK Example](https://github.com/telerik/xaml-sdk/tree/master/GridView/BindingToDynamicObject).

## ICustomTypeProvider

In case a custom Type needs to be provided by the dynamic type implementation, the __ICustomTypeProvider__ interface can be used. __RadGridView__ provides support for such types as well. A common implementation of the interface will consist of creating the custom Type and a custom PropertyInfo that stores the properties of this Type. An example of defining __ICustomTypeProvider__ object bound to __RadGridView__ is illustrated in the [Binding to ICustomTypeProvider SDK Example](https://github.com/telerik/xaml-sdk/tree/master/GridView/BindingToICustomTypeProvider).

{% if site.site_name == 'WPF' %}
## ICustomTypeDescriptor

When there is a need for providing the information regarding a given type at runtime, the __ICustomTypeDescriptor__ comes in handy. Such implementations are supported by RadGridView. A demonstration of such implementation with the control is demonstrated in the [Binding to ICustomTypeDescriptor SDK Example]().

{% endif %}

## See Also

* [Have mixed CLR and DLR properties]({%slug gridview-how-to-use-mixed-clr-dlr-properties%})

