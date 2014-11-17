---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: datafilter-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility



## Latest Release Notes

You can check the latest Release Notes {% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

##  Breaking changes for Telerik RadDataFilter for SilverlightWPF Q3 2011
      

* Deleting the entire text from the __StringFilterEditor__ will now clear the filter instead of filtering on __string.Empty__.
          

* The __StringFilterEditor__ control has two new properties now - __Text__ and __IsCaseSensitive__.
            

>If you create this editor manually instead of relying on the __FilterEditorFactory__, you have to bind these two properties to the "__Value__" and "__IsCaseSensitive__" properties of the filtering view model respectively.
              

* The default filter editor for numeric types is now __TextBox__ instead of __RadMaskedTextBox__.
          
