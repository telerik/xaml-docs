---
title: Changes
page_title: Changes
description: Changes
slug: radpivotgrid-changes
tags: changes
publish: True
position: 0
---

# Changes



In this article you can find out the history of the changes we've made in __RadPivotGrid__ and __RadPivotFieldList__.
            

## Latest Release Notes

You can find out the latest release notes
                    {% if site.site_name == 'WPF' %}[here](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}{% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/products/silverlight/whats-new/release-history.aspx){% endif %}.
                

## Q3 2013

### What's new{% if site.site_name == 'WPF' %}

* Queryable Data Provider
                                    

* Implement Calculated Items for LocalDataSourceProvider
                                    

* Implement Calculated Fields for LocalDataSourceProvider
                                    {% endif %}{% if site.site_name == 'Silverlight' %}

* Implement Calculated Items for LocalDataSourceProvider
                                    

* Implement Calculated Fields for LocalDataSourceProvider
                                    {% endif %}

### What's fixed{% if site.site_name == 'WPF' %}

* Exception is thrown when a calculated field is added that has RequiredField which is not part of the data source
                                    

* Exception is thrown when some report filters are applied
                                    

* RadPivotGrid doesn't show data if the Cube doesn't support KPIs
                                    

* Using Is Between/Is Not Between label filters - when typing in the textboxes focus is lost on every keystroke
                                    {% endif %}{% if site.site_name == 'Silverlight' %}

* Exception is thrown when a calculated field is added that has RequiredField which is not part of the data source
                                    

* Exception is thrown when some report filters are applied
                                    

* RadPivotGrid doesn't show data if the Cube doesn't support KPIs
                                    

* Using Is Between/Is Not Between label filters - when typing in the textboxes focus is lost on every keystroke
                                    

* ArgumentNullException is thrown when checking RadPivotGrid's IsBusy property in Silverlight
                                    {% endif %}

## Q2 2013

### What's new

* Added new steps for DateTimeGroupDescription and a way to implement custom steps.
                                

* Added UI Dialog to set the step of DateTimeGroupDescription.
                                

* Added support for DateTimeOffset data.
                                

* Added German and Turkish localization languages.
                                

* ItemsSource of LocalDataSourceProvider is a DependencyProperty.
                                

* Added RowGroupsExpandBehavior/ColumnGroupsExpandBehavior to control initial expand/collapse state.
                                

* PivotFieldList dialogs respond to Escape and Enter keys.
                                

* Added a setting to query additional properties in XmlaConnectionSettings (for example to use specific language from OLAP Cube).
                                

* Added serialization support.
                                

* Implemented Label Filters for OLAP.
                                

* Added IntelliSense support at design time for the AggregateFunction properties of the LocalAggregateDescriptions.
                                

### What's fixed

* XAML Binding errors.
                                

* Label Filter is not applied on DateTimeGroupDescriptions.
                                

* Sorting by Aggregates is not working properly when Aggregate values contain empty values.
                                

* OLAP: Layout issue with hierarchy – overlapping text.
                                

* SelectItems Report Filter dialog throws exception when a property has null or DBNull value.
                                

* RowHeaderStyle/RowHeaderTemplate is applied on both rows and columns. ColumnHeaderStyle/ColumnHeaderTemplate is not applied at all.
                                

* Collapsing group through code does not change the UI of this group ("-" and "+" signs are not updated).
                                

* Exception is thrown when two aggregates are selected, all rows and columns are collapsed and the theme is changed.
                                

* Hierarchy with only one level and isAggregatable=false can't be used in Report Filter.
                                
