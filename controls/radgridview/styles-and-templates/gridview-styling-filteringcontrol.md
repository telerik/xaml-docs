---
title: Styling the FilteringControl
page_title: Styling the FilteringControl
description: Styling the FilteringControl
slug: gridview-styling-filteringcontrol
tags: styling,the,filteringcontrol
publish: True
position: 18
---

# Styling the FilteringControl



>tip
        Before reading this topic, you might find useful to get familiar with the [Template Structure of the FilteringControl](2CD6EAA0-C735-4FA2-B921-A0D1A4452C10#FilteringControl).
      

The __GridViewColumn__ exposes the __FilteringControlStyle__ property of type __Style__. It is applied to the __FilteringControl__ of the column.
      

You have two options:

* To create an empty style and set it up on your own.

* To copy the default styles of the control and modify it.

This topic will show you how to perform the second one.

## Modifying the Default Style

The default style is available with the installation of the RadControls. You can find it browsing through the Themes folder for a particlular Theme "..\Themes\OfficeBlack\Themes" inside "Telerik.Windows.Controls.GridView.xaml" file.
        

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

* __PART_DisctinctFilter__ - the stack panel that holds the SelectAll checkbox, the distinct values listbox and the close button
            

* __PART_SelectAllCheckBox__ - the select all checkbox
            

* __PART_FilterCloseButton__ - represents the CloseButton of the FilteringControl.
            

* __PART_DistinctValuesList__ - the listbox that hosts the DisctinctValues for the FilteringControl.
            

* __PART_Filter1ComboBox__ - the combobox containing the available operators
            

* __PART_Filter1ContentControl__ - the control where you type your filter value
            

* __PART_LogicalOperatorsComboBox__ - the logical operators combobox (contains AND & OR operators)
            

* __PART_Filter2ComboBox__ - the combobox containing the available operators
            

* __PART_Filter2ContentControl__ - the control where you type your filter value
            

* __PART_ApplyFilterButton__ - represents the button that you can use to apply Filtering.
            

* __PART_ClearFilterButton__ - represents the button that you can use to clear Filtering.
            

# See Also

 * [Filter goes outside the window]({%slug gridview-troubleshooting-filtering-control%})

 * [Styling the FilterRow]({%slug gridview-styling-filterrow%})
