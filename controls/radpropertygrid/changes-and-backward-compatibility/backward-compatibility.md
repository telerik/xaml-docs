---
title: Backward Compatibility
page_title: Backward Compatibility
description: Check our &quot;Backward Compatibility&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# {{ site.framework_name }} RadPropertyGrid Backward Compatibility

## Latest Release Notes

You can check the latest Release Notes{% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## R1 2016

* Removed: **SelectedField** and **SelectedFieldChanged**

## R1 2014

* Changed: **CollectionEditor**'s default **IsReadOnly** state to **ReadOnly**, instead of **Disabled**

## R1 2013

* PropertyDefinition's **Binding** property is now of type **BindingBase**

* Obsolete: **SelectedField** property of RadPropertyGrid (**SelectedPropertyDefinition** should be used instead)    

* Changed: **PropertyDefinitionsCollection** is now **ObservableItemCollection**. 

>Performance tip: Notifications should be suspended when bulk insert operations are executed

## R3 2012

* Public method __Telerik.Windows.Controls.Data.PropertyGrid.PropertyDefinition.DFSFilter__ is removed. It has never been supposed to be public.

## R2 2012 SP1

* __OrderIndex__  is now __DependencyProperty__

##  R2 2012

* __AutoBindBehavior__ now supports source different from RadPropertyGrid's **Item**.

* PropertyGridField editor will use a __TwoWay__ binding if such is specified in its  __PropertyDefinition__.

## R1 2012 SP1

* PropertyDefinition’s __IsReadonly__ property is now a __DependencyProperty__.

## R1 2012

* __NestedPropertiesVisibility__ is now of type __System.Windows.Visibility__.

## R2 2011 Beta

Telerik RadPropertyGrid has been just added to the Telerik {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} suite.