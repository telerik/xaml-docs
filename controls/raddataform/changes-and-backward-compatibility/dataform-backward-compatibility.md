---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: dataform-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility


## Latest Release Notes

You can check the latest Release Notes {% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## Q2 2015

* DataFormValidationSummary Errors and HasErrors properties are now read-only. Errors still support modifications of its items (add/remove), but it no longer has a public setter.

## Q1 2013
      

* Removed the IsRequired property of DataFormDataField. It was marked as obsolete with Q3 2012
          

* Removed the Telerik.Windows.Controls.Data.DataForm.ErrorInfo type. It was marked as obsolete with Q3 2012. Telerik.Windows.Controls.Data.ErrorInfo should be used instead
          

## Q2 2012 SP1
      

*  Removed a unneeded item-validation check on cancel.
          

* Setting the access modifier of __DataFormDataField.GetControlBindingProperty()__ to protected internal.
          

## Q1 2012 SP1
      

* __Telerik.Windows.Controls.Data.DataForm.ErrorInfo__ is now obsoleted. Use __Telerik.Windows.Controls.Data.ErrorInfo__ instead.
                

* The label element (“PART_Label”) of __DataFormDataField__ is now __ContentControl__ (__TextBlock__ previously). Old custom themes should not be affected.
                

* The default value of the __AutoCommit__ property is now true. Previous default behavior of __RadDataForm__ is the same.
                
