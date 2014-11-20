---
title: First Chance 'System.ArgumentException'
page_title: First Chance 'System.ArgumentException'
description: First Chance 'System.ArgumentException'
slug: gridview-troubleshooting-argumentexception-datarowview
tags: first,chance,'system.argumentexception'
published: True
position: 18
site_name: WPF
---

# First Chance 'System.ArgumentException'

__PROBLEM__

When RadGridView is bound to __DataTable.DefaultView__, then you may get a first chance exception for an "id" property. Like this one: __System.ArgumentException: The type 'DataRowView' does not contain a public property named 'id'.__

Similarly, when you are using RadGridView to display a list of DataRowBase objects which implements the ICustomTypeDescriptor, you may also get a first chance exception: __System.ArgumentException: The type "DataRowBase" does not contain a public property "RefDate".__

__CAUSE__

Those exceptions come from the poor implementation of the WPF validation - the errors are raised from the __Validator.TryValidateObject()__ method.
        
__SOLUTION__

You can set __ValidatesOnDataErrors="None"__ for RadGridView to avoid them.
        
In case you need to keep the validation, then you can set __RadGridView.ValidatesOnDataErrors="InEditMode"__. Then you will get the exception only when you edit and commit a row.
        
