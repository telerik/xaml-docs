---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: radpropertygrid-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility



## Latest Release Notes

You can check the latest Release Notes{% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

##  Q1 2014
      

* Changed: CollectionEditor's default IsReadOnly state to ReadOnly, instead of Disabled
          

##  Q1 2013
      

* PropertyDefinition's Binding property is now of type BindingBase
          

* Obsolete: SelectedField property of RadPropertyGrid (SelectedPropertyDefinition should be used instead)
          

* Changed: PropertyDefinitionsCollection is now ObservableItemCollection. Performance tip: Notifications should be suspended when bulk insert operations are executed
          

## Q3 2012
      

* Public method __Telerik.Windows.Controls.Data.PropertyGrid.PropertyDefinition.DFSFilter__ is removed. It has never been supposed to be public.
          

## Q2 2012 SP1

* __OrderIndex__  is now __DependencyProperty__

##  Q2 2012

* __AutoBindBehavior__ now supports source different from __RadPropertyGrid__'s Item.
          

* PropertyGridField editor will use a __TwoWay__ binding if such is specified in its  __PropertyDefinition__.
          

## Q1 2012 SP1
    

* __PropertyDefinition’s IsReadonly__ property is now a __DependencyProperty__.
          

## Q1 2012

* __NestedPropertiesVisibility__ is now of type __System.Windows.Visibility__.
          

## Q2 2011 Beta

Telerik RadPropertyGrid has been just added to the Telerik {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} suite.
        
