---
title: Changes
page_title: Changes
description: Changes
slug: datafilter-changes-backward-compatibility
tags: changes
published: True
position: 0
---

# Changes



## Latest Release Notes

You can check the latest Release Notes {% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## Q3 2013
      
### What's Fixed
            

* RadDataFilter auto-generates its ItemPropertyDefinitions more than once when bound to a collection of dynamic objects
                

* Changing the Member or the Operator of an inactive filter (i.e. one with UnsetValue) should not cause re-filtering and hence a slow down
                

##  Q2 2013
     
### What's Fixed
            

* The EditorCreated event is fired twice when changing the item property name of an existing filter
                

## Q1 2013
      
### What's New            

* GetItemStatusCore() override for DataFilter automation peer
                

* RadDataFilter.AutoGeneratingPropertyDefinition event
                

## Q3 2012 SP
      
### What's New
            

* IsEmpty and IsNotEmpty string filter operators
                
### What's Fixed
            

* The FilterEditor placeholder control receives focus when tabbing and it really should not.
                

##  Q3 2012
      
### What's New
            

* ItemPropertyDefinition.ComponentType property.
                

* FilterOperatorsLoadingEventArgs.DefaultOperator property.
                

##  Q2 2012 SP2
      
### What's New            

*  FilterOperatorsLoadingEventArgs.DefaultOperator property.
                            

##  Q2 2012 SP1
      
### What's New            

* ItemPropertyDefinition.ComponentType property
                

##  Q2 2012
      
### What's New
            

* TimeSpan property filtering support
                
### What's Fixed
            

* Adding composite filters to FilterDescriptors programmatically may result in exception.
                

##  Q1 2012 SP1
      
### What's Fixed
            

* RadDataFilter bound to RadTreeListView crashes when try to filter
                

##  Q1 2012
      
### What's New
            

* Deleted the obsolete RadDataFilter.ItemProperties and FilterOperatorsLoadingEventArgs.ItemPropertyInfo properties.
                

##  Q3 2011
      
### What's New
            

* Comparison filtering (>, >=, <, <=) for __TimeSpan__ values.
                

* StringFilterEditor.MatchCaseVisibility__ property.
                
### What's Fixed
            

* The filter operator sometimes disappears when changing the member.
                

* RadDataFilter raises the FilterEditorCreated event twice when a new filter is created.
                

* Deleting the entire text from the StringFilterEditor should clear the filter instead of filtering on string.Empty.
                

## Q2 2010

* RadDataFilter has been just added to the Telerik {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} suite. 
