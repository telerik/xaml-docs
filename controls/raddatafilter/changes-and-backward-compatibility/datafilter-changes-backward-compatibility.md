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

You can check the latest Release Notes
          {% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q3 2013
      
              What's Fixed
            

* 
                  Fixed: RadDataFilter auto-generates its ItemPropertyDefinitions more than once when bound to a collection of dynamic objects
                

* 
                  Fixed: Changing the Member or the Operator of an inactive filter (i.e. one with UnsetValue) should not cause re-filtering and hence a slow down
                

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q2 2013
      {% if site.site_name == 'WPF' %}
                What's New
              

* 
                    Added: Lever 2 and 3 CodedUI Automation support
                  {% endif %}
              What's Fixed
            

* 
                  Fixed: The EditorCreated event is fired twice when changing the item property name of an existing filter
                

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q1 2013
      
              What's New
            

* 
                  Added: GetItemStatusCore() override for DataFilter automation peer
                

* 
                  Added: RadDataFilter.AutoGeneratingPropertyDefinition event
                

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q3 2012 SP
      
              What's New
            

* 
                  Added: IsEmpty and IsNotEmpty string filter operators
                
              What's Fixed
            

* 
                  Fixed: The FilterEditor placeholder control receives focus when tabbing and it really should not.
                

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q3 2012
      
              What's New
            

* 
                  Added: ItemPropertyDefinition.ComponentType property.
                

* 
                  Added: FilterOperatorsLoadingEventArgs.DefaultOperator property.
                

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q2 2012 SP2
      
              What's New
            

* 
                  Added: 
                    Changes for Telerik __RadDataFilter__ for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} Q2 2012 SP1
                  
                          What's New
                        

* 
                              Added: __ItemPropertyDefinition.ComponentType__ property
                            

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q2 2012 SP1
      
              What's New
            

* 
                  Added: __ItemPropertyDefinition.ComponentType__ property
                

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q2 2012
      
              What's New
            

* 
                  Added: __TimeSpan__ property filtering support
                
              What's Fixed
            

* 
                  Fixed: Adding composite filters to __FilterDescriptors__ programmatically may result in exception.
                

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q1 2012 SP1
      
              What's Fixed
            

* 
                  Fixed: __RadDataFilter__ bound to __RadTreeListView__ crashes when try to filter
                

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q1 2012
      
              What's New
            

* 
                  Deleted the obsolete __RadDataFilter.ItemProperties__ and __FilterOperatorsLoadingEventArgs.ItemPropertyInfo__ properties.
                

## 
        Changes for Telerik RadDataFilter for SilverlightWPF Q3 2011
      
              What's New
            

* 
                  Added: Comparison filtering (>, >=, <, <=) for __TimeSpan__ values.
                

* 
                  Added: __StringFilterEditor.MatchCaseVisibility__ property.
                
              What's Fixed
            

* 
                  Fixed: The filter operator sometimes disappears when changing the member.
                

* 
                  Fixed: __RadDataFilter__ raises the __FilterEditorCreated__ event twice when a new filter is created.
                

* 
                  Fixed: Deleting the entire text from the __StringFilterEditor__ should clear the filter instead of filtering on string.Empty.
                

## Telerik RadDataFilter Q2 2010

* The Telerik __RadDataFilter__ has been just added to the Telerik {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} suite. 
