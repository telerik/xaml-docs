---
title: Changes
page_title: Changes
description: Changes
slug: radtreelistview-changes
tags: changes
published: True
position: 0
---

# Changes



## Latest Release Notes

You can check the latest Release Notes {% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

##  Q2 2014
### What's New      

*	TreeListView Connecting Lines. For more information, you can check the [Connecting Lines]({%slug radtreelistview-features-treelines%}) article.

### What's Fixed          

*	Wrong indentation of the new row.
          

*	Checkbox editors in all types of GridView columns jump to the left in edit mode.
          

*  The AutomationControlType of RadTreeListViewAutomationPeer is updated to DataGrid.
          

*  Output errors when AutoExpandItems is bound to IsChecked of an external checkbox.
          

*  TreeListViewRowCoreValidationStyle is throwing design time exception in Office2013 theme.
          

## Q1 2014
### What's New       

*  Added (Q3 2013 SP1): Design for invalid-edit mode state of the new row.
            

*  Added (Q3 2013 SP1): All editors are now stretched relative to its parent row height.
            

*  Added (Q3 2013 SP1): Lightweight templates visual optimization.
       
### What's Fixed     

*  Cannot drop on last item in TreeListView.
            

*  GridViewToggleButton's Foreground in RadTreeListView is not correct in Windows8 theme.
            

##  Q3 2013      

You can check the  Release Notes for __Q3 2013__ {% if site.site_name == 'Silverlight' %}[here.](http://www.telerik.com/products/silverlight/whats-new/release_notes/q3-2013-version-2013-3-1016-432255941.aspx#treelistview){% endif %}{% if site.site_name == 'WPF' %}[here.](http://www.telerik.com/products/wpf/whats-new/release-history/q3-2013-version-2013-3-1016-2120428450.aspx#treelistview){% endif %}

## Q2 2013      

You can check the  Release Notes for __Q2 2013__ {% if site.site_name == 'Silverlight' %}[here.](http://www.telerik.com/products/silverlight/whats-new/release_notes/q2-2013-version-2013-2-0611-3259441291.aspx#treelistview){% endif %}{% if site.site_name == 'WPF' %}[here.](http://www.telerik.com/products/wpf/whats-new/release-history/q2-2013-version-2013-2-0611.aspx#treelistview){% endif %}

## Q1 2013      

You can check the Release Notes for __Q1 2013__ {% if site.site_name == 'Silverlight' %}[here.](http://www.telerik.com/products/silverlight/whats-new/release_notes/q1-2013-version-2013-1-0220-963710774.aspx#treelistview){% endif %}{% if site.site_name == 'WPF' %}[here.](http://www.telerik.com/products/wpf/whats-new/release-history/q1-2013-version-2013-1-0220.aspx#treelistview){% endif %}

##  Q3 2012       
### What's New
            

*  __Virtualization__ for merged headers. Improved initial load time and scrolling performance.
                
### What's Fixed
            

*  __RadTreeListView__ will not expand child items properly with alternation and load on demand. __ParentRow__ also now properly initialized.
                

*  __NullRefException__ on pasting to an empty __GridViewDataControl__.
                

*  __IsExpandable__ not applied correctly with __AlternateRowStyle__ and __AlternateRowStyleSelector__.
                

*  Exception when dynamically adding a column group that does not have a matching column.
                

*  Issues when using __MaskedInput__ controls in __CellEditTemplates__.
                

*  Aggregate function applied twice in the __Column Footer__ when a function is reused for more than one column.
                

*  When bound to __CollectionViewSource__ all cells in a combo box column displayed the same values after edit (in a theme different than ***Office_Black***)
                

*  Scrolling orientation of common headers was not correctly set for the virtualized items.
                

*  When a column's custom __FilteringControl__ is replaced with a new one at runtime, a reference to the old one remains which leads to incorrect behavior.
                

*  Validation issue when __ValidatesOnDataErrors__ is set to "__InViewMode__".
                

*  __Focus__ issue with __TextBox__ in __CellTemplate__ and theme is different from __Office_Black e.NewValue__ inside __CellValidating__ event args is not set properly when fast scrolling is performed (via __KeyDown__).
                

*  __Current cell__ scrolled horizontally in certain situations, even when under frozen column.
                

*  Expand button clipping with different row height.
                

*  __System.ArgumentNullException__ with underscores in distinct values.
                

*  Common column headers were partially rendered for columns of the viewport in (after scrolling into view)
                

## Q2 2012 SP2
### What's Fixed
            

*   __NullRefException__ on pasting to an empty  __GridViewDataControl__

*   __RadTreeListView__ will not expand child items properly with alternation and load on demand.  __ParentRow__ also now properly initialized.
                

*   __IsExpandable__ not applied correctly with  __AlternateRowStyle__ and  __AlternateRowStyleSelector__.
                

*  Exception when dynamically adding a column group that does not have a matching column.
                

*  Issues when using  __MaskedInput__ controls in  __CellEditTemplates__.
                

*  Aggregate function applied twice in the  __Column Footer__ when a function is reused for more than one column.
                

*  When bound to  __CollectionViewSource__ all cells in a combo box column displayed the same values after edit (in a theme different than Office_Black)
                

*  Scrolling orientation of common headers was not correctly set for the virtualized items.
                

*  When a column's custom  __FilteringControl__ is replaced with a new one at runtime, a reference to the old one remains which leads to incorrect behavior.
                

*  Validation issue when  __ValidatesOnDataErrors__ is set to " __InViewMode__".
                

*  Focus issue with  __TextBox__ in  __CellTemplate__ and theme is different from  __Office_Black__ e.NewValue inside  __CellValidating__ event args is not set properly when fast scrolling is performed (via  __KeyDown__).
                

*  Current cell scrolled horizontally in certain situations, even when under frozen column.
                

*  Expand button clipping with different row height.
                

*   __System.ArgumentNullException__ with underscores in distinct values.
                

*  Common column headers were partially rendered for columns of the viewport in (after scrolling into view).
                

## Q2 2012 SP1
### What's New
            

*  __Virtualization__ for merged headers
                
### What's Fixed
            

*  Memory leak fix for __DoubleClick__ event
                

*  __TreeListViewDragCue____VisualStates__ not changing is now fixed
                

*  Exception on theme change with custom __Header__/__Footer__ is now fixed
                

*  __SelectedItem__ binding does not work at first time (when set before __RadGridView.DataLoad__) is now fixed
                

*  __SelectedUnfocusedState__ improved for all themes
                

*  Improved initial load time and scrolling performance
                

*  Wrong selection state combining actions __select item__, __unfocus grid__, __scroll grid__

*  Positioning of the __BetweenItems____Cue__ with rows with different height is now fixed
                

## Q2 2012
### What's New
            

*  Delete key behavior with  __RadGridView.SelectionUnit = "Cell"__ improved.
                

* __GridViewRow____SelectedUnfocused__ state
                

* Validation improvement to support better various validation scenarios.
                

* Expand/collapse performance optimized.
                

* __Frozen column splitter__ behavior improved.
                

*  __TimeSpan__ property filtering support
                

* __Aggregates__ fixed to work hierarchically.
                
### What's Fixed
            

*  __Frozen column splitter__ not correctly positioned in Metro theme is now fixed.
                

*  __Copy__ and __Paste__ commands are executed if other modifiers than __Control__ are pressed is now fixed.
                

*  Child collections not resolved correctly is now fixed.
                

*  __HierarchyExpandButton.Clip__ is now fixed
                

*  Now filtering will work properly with __DataLoadMode="Asynchronous"__

*  Wrong background of __frozen column splitter__ in __Expression_Dark__ theme is now fixed.
                

## Q1 2012 SP1
      
### What's New
            

*  __HierarchyIndent__ property
                
### What's Fixed
            

*  __IsBusy__ is now fixed
                

## Q3 2011 SP1
### What's New
            

*  __RadTreeListView____AutoExpandItems__ property
                
### What's Fixed
            

*  __RadTreeListView__ filtering not working correctly
                

## Q3 2011
      
### What's New
            

*  Row resizing functionality
                

*  Memory and performance optimizations.
                

*  New property AutoLoadHierarhy 
  >The new property is ___false___ by default - when set to ___true___ the __TreeListView__ will initialize the entire hierarchy when __ItemsSource__ is assigned.
                    
