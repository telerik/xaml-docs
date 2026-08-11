---
title: Adding ComboBox Items Directly
page_title: Directly Adding ComboBox Items Directly
description: Check our &quot;Directly Adding ComboBox Items Directly&quot; documentation article for the RadComboBox WPF control.
slug: radcombobox-populating-with-data-declaratively
tags: declaratively
published: True
position: 0
---

# Adding ComboBox Items Directly

This tutorial will walk you through the common task of populating `RadComboBox` with `RadComboBoxItems` declaratively. 

In order to add combobox items you need to use the `RadComboBox` `Items` property. The property is of `ItemCollection` and it contains the populated items. The following example shows how to add items in the ComboBox:

  
<snippet id='radcombobox-populating-with-data-declaratively-block_1-xaml' />


![{{ site.framework_name }} RadComboBox Bound to XAML-Defined Data](images/RadComboBox_PopulatingWithData_Declaratively_020.png)

The `RadComboBoxItems` can be added also in the code-behind using the following syntax:

  
<snippet id='radcombobox-populating-with-data-declaratively-block_2-cs' />


## See Also  
 * [Binding to Object]({%slug radcombobox-populating-with-data-binding-to-object%})
 * [Binding to WCF Service]({%slug radcombobox-populating-with-data-binding-to-wcf%})
 * [Binding to ADO.NET Data Service]({%slug radcombobox-populating-with-data-binding-adonet%})