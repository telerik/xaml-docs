---
title: Changes
page_title: Changes
description: Changes
slug: dataform-changes
tags: changes
published: True
position: 0
---

# Changes



## Latest Release Notes

You can check the latest Release Notes {% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## Q1 2015

You can check the {% if site.site_name == 'Silverlight' %}[Release Notes for version Q1 2015.](http://www.telerik.com/support/whats-new/silverlight/release-history/ui-for-silverlight-q1-2015){% endif %}{% if site.site_name == 'WPF' %}[Release Notes for version Q1 2015.](http://www.telerik.com/support/whats-new/wpf/release-history/ui-for-wpf-q1-2015){% endif %}

## Q2 2014
{% if site.site_name == 'Silverlight' %}
### What's New

* (Silverlight only) Added support for string format for dynamic properties 

{% endif %}
### What's Fixed
			

* Memory leak in DataFormComboBoxField
				

* DataFormComboBoxField clears its selected value, when switching between data templates
				

* Changes on the ItemsSource Collection are not reflected in the UI
				

* NullReferenceException in RadDataForm.OnCurrentItemPropertyChanged()
				

* Design-time NullReferenceException in CanMoveCurrentToFirstExecute()
				

##  Q1 2014
      
### What's Fixed            

*  An exception is thrown on changing the theme using StyleManager
                

##  Q3 2013
      
### What's Fixed
            

*  CanDelete and CanAdd properties are not correctly set when CurrentItem is bound and no ItemsSource is set.
                

* When DataForm and GridView use ICollectionView synchronization and the grid is filtered and has only one item, DataForm navigation buttons are not all disabled
                

*  No data field is generated for dynamic property with null value
                

*  ArgumentNullException in CollectionHelper.AreEqual
                

*  ArgumentOutOfRangeException is thrown when items are deleted
                

*  TextBox editors jump in edit mode (Windows8 and Office2013 themes)
                

##  Q2 2013
      
### What's Added
            

*  German localization
                

*  TypeConverter support
                

*  Keyboard navigation + extandability through a command provider
                

*  Improve MVVM support by adding command provider support
                
### What's Fixed
            

* Corresponding navigation buttons are not active when AutoCommit="False", an item has been edited and delete button is clicked
                

*  RadDataForm with AutoCommit="False" gets into erroneous state when navigating away from unmodified item in edit mode
                

*  NullReferenceException caused by Add button when GridView is filtered and has collection synchronization with DataForm
                

*  Editors in manually-generated data fields does not get the default theme
                

*  LabelStyle DependencyProperty is not registered correctly
                

*  Cancel button should be enabled even if there are not pending changes
                

*  RadDataForm throws-design time exception in VS2012 WPF, when CustomCommandProvider is used
                

## Q1 2013
      
### What's Added
            

*  XML comment and access modifier
                

*  Nullable enum support for auto-generated fields
                

* MVVM improvements
                

*  CommandProvider support
                
### What's Fixed
            

*  CurrentItem is not updated on moving back/forth if form has been unloaded/ reloaded
                

*  Cannot properly apply a new ControlTemplate through the ValidationSummaryStyle property
                

*  Occasionally fields hang in readonly state when ApplicationTheme is set
                

*  Navigation through the items if there is group descriptor applied to the source collection
                

*  AddNewItem sets the DataForm into edit mode when RadDataForm and RadGridView are bound to the same source and grouping is applied
                

*  CurrentItem is not properly updated when items are asynchronously loadeds
                

##  Q3 2012 SP1
      
### What's Fixed
            

* Cannot properly apply a new ControlTemplate through the ValidationSummaryStyle property
                

* CurrentItem is not updated on moving back/forth if form has been unloaded/ reloaded
                

##  Q3 2012
      
### What's Added
            

* EnablePropertyChangedBasedCancel - property to disable PropertyChanged-based cancelling
                
### What's Fixed
            

* Initial values of cancelled properties are no longer cached
                

* Wrong registration of the LabelStyle DependencyProperty
                

*  Adding new item is disabled if the source is set after data form is created
                

*  Memory leak when reloading a DataForm  multiple times
                

## Q2 2012 SP2
      
### What's Fixed
            

*  Adding new item is disabled if the source is set after data form is created
                

##  Q2 2012 SP1
      
### What's Added
            

* French localization.
                
### What's Fixed
            

* ArgumentNullException is thrown when firing PropertyChanged with  null
                

* AutoEdit mode
                

* CurrentCulture and CurrentUICulture are now respected
                

* The wrong registration of the LabelStyle DependencyProperty
                

##  Q2 2012
      
### What's Added
            

* IsComboboxEditable property for DataFormComboBoxField
                

* DataTemplateSelectors support
                
### What's Fixed
            

* Error with a binding validation error that is not associated with any field
                

* OK and Cancel Buttons are not enabled if you change nullable int value
                

*  An exception try/catched with CancelEdit mechanism when RadDataForm is bound to DataTable
                

* BindingExpressionPath errors with CommandButtonsVisiblity are now fixed
                

##  Q1 2012 SP1
      
### What's Added
            

* INotifyPropertyChanged cancelling mechanism (IEditableObject cancelling has higher priority)
                

* LabelTemplate (DataTemplate) property in the DataFormDataField class
                
### What's Fixed
            

* Cancelling new item do not work in some occasions when AutoCommit is true
                

* Navigation buttons do not get disabled when AutoCommit is false and there are uncommitted pending changes
                

* Navigating to another item commits changes when AutoCommit is false
                

* Cancel edit for a new, already committed item, leads to an “empty” item, when AutoCommit is true
                

* Item level validation errors display property name instead of label in the validation summary
                

##  Q1 2012
      
### What's Added
            

* Improved item-level validation for RIA entities
                
### What's Fixed
            

* Autogenerated DataFormDataFields (TextBox) do not update their UI properly when item is a FormatException occurs and IEditableObject. CancelEdit is invoked
                

* In some isolated cases, validation errors permanently block RadDatform’s commit operation
                

* In some cases, item-level validation errors are not properly removed from the validation summary
                

* IsThreeState property of DataFormCheckBoxField is not respected
                

## Q3 2011 SP1
      
### What's Fixed
            

* RadDataForm validation
                

##  Q1 2011
      

* RadDataForm has been just added to the Telerik WPF suite.
                
