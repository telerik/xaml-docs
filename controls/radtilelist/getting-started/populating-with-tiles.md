---
title: Populating RadTileList with Tiles 
page_title: Populating RadTileList with Tiles 
description: Check our &quot;Populating RadTileList with Tiles&quot; documentation article for the RadTileList {{ site.framework_name }} control.
slug: radtilelist-getting-started-populating-with-tiles
tags: populating,radtilelist,with,tiles,
published: True
position: 1
---

# Populating RadTileList With Tiles 



This tutorial will walk your through the population of __RadTileList__ and will show you how:

* Populate __RadTileList__ with a collection of custom objects
        

* Populate __RadTileList__ with custom Tiles
        

## Populating RadTileList With a Collection of Custom Objects

Firstly, for the purpose of this tutorial, we will create a new class __Employee__ with a couple of properties:

__Example 1: Defining the Employee class__

<snippet id='radtilelist-getting-started-populating-with-tiles-block_1-cs' />
<snippet id='radtilelist-getting-started-populating-with-tiles-block_2-vb' />



>Note that in case you want to be notified on the changes made on the data item, the class Employee should implement __INotifyPropertyChanged__ Interface and raise the __PropertyChanged__ event every time a property value changes.
        

Once the class __Employee__ is defined, we will define an __EmployeeService__ class that will return an ObservableCollection, containing several hard-coded employees:
        

__Example 2: Defining the EmployeeService class__

<snippet id='radtilelist-getting-started-populating-with-tiles-block_3-cs' />
<snippet id='radtilelist-getting-started-populating-with-tiles-block_4-vb' />



Secondly, you must define __RadTileList's ItemTemplate__, like so:

__Example 3: Defining the ItemTemplate__

<snippet id='radtilelist-getting-started-populating-with-tiles-block_5-xaml' />



> Please note that you can show/hide the horizontal scrollbar by setting the __ScrollViewer.HorizontalScrollBarVisibility__ attached property.
        

Afterwards, all you need to do is to set the __ItemsSource of__ the RadTileList:

__Example 4: Setting the ItemsSource of RadTileList__

<snippet id='radtilelist-getting-started-populating-with-tiles-block_6-cs' />
<snippet id='radtilelist-getting-started-populating-with-tiles-block_7-vb' />



## Populating RadTileList With Custom Tiles

A typical usage of __Custom RadTileList's Tiles__ is available on {% if site.site_name == 'Silverlight' %}[ this online demo](https://demos.telerik.com/silverlight/#TileList/FirstLook){% endif %}{% if site.site_name == 'WPF' %}[ our WPF demos](https://demos.telerik.com/wpf/){% endif %}.
        