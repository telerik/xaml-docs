---
title: Changes
page_title: Changes
description: Changes
slug: dataform-changes
tags: changes
publish: True
position: 0
---

# Changes



## Latest Release Notes

You can check the latest Release Notes
          {% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## 
		Changes for Telerik RadDataForm for SilverlightWPF Q2 2014
	  What's New

* (Silverlight only) Added support for string format for dynamic properties 
					
			  What's Fixed
			

* Memory leak in DataFormComboBoxField
				

* DataFormComboBoxField clears its selected value, when switching between data templates
				

* Changes on the ItemsSource Collection are not reflected in the UI
				

* NullReferenceException in RadDataForm.OnCurrentItemPropertyChanged()
				

* Design-time NullReferenceException in CanMoveCurrentToFirstExecute()
				

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q1 2014
      
              What's Fixed
            

* 
                  Fixed: An exception is thrown on changing the theme using StyleManager
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q3 2013
      
              What's Fixed
            

* 
                  Fixed: CanDelete and CanAdd properties are not correctly set when CurrentItem is bound and no ItemsSource is set.
                

* 
                  Fixed:When DataForm and GridView use ICollectionView synchronization and the grid is filtered and has only one item, DataForm navigation buttons are not all disabled
                

* 
                  Fixed: No data field is generated for dynamic property with null value
                

* 
                  Fixed: ArgumentNullException in CollectionHelper.AreEqual
                

* 
                  Fixed: ArgumentOutOfRangeException is thrown when items are deleted
                

* 
                  Fixed: TextBox editors jump in edit mode (Windows8 and Office2013 themes)
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q2 2013
      
              What's Added
            

* 
                  Added: German localization
                

* 
                  Added: TypeConverter support
                

* 
                  Added:  Keyboard navigation + extandability through a command provider
                

* 
                  Added:  Improve MVVM support by adding command provider support
                
              What's Fixed
            

* 
                  Fixed: Corresponding navigation buttons are not active when AutoCommit="False", an item has been edited and delete button is clicked
                

* 
                  Fixed: RadDataForm with AutoCommit="False" gets into erroneous state when navigating away from unmodified item in edit mode
                

* 
                  Fixed: NullReferenceException caused by Add button when GridView is filtered and has collection synchronization with DataForm
                

* 
                  Fixed: Editors in manually-generated data fields does not get the default theme
                

* 
                  Fixed: LabelStyle DependencyProperty is not registered correctly
                

* 
                  Fixed: Cancel button should be enabled even if there are not pending changes
                

* 
                  Fixed: RadDataForm throws-design time exception in VS2012 WPF, when CustomCommandProvider is used
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q1 2013
      
              What's Added
            

* 
                  Added: XML comment and access modifier
                

* 
                  Added: Nullable enum support for auto-generated fields
                

* 
                  Added: MVVM improvements
                

* 
                  Added: CommandProvider support
                
              What's Fixed
            

* 
                  Fixed: CurrentItem is not updated on moving back/forth if form has been unloaded/ reloaded
                

* 
                  Fixed: Cannot properly apply a new ControlTemplate through the ValidationSummaryStyle property
                

* 
                  Fixed: Occasionally fields hang in readonly state when ApplicationTheme is set
                

* 
                  Fixed: Navigation through the items if there is group descriptor applied to the source collection
                

* 
                  Fixed: AddNewItem sets the DataForm into edit mode when RadDataForm and RadGridView are bound to the same source and grouping is applied
                

* 
                  Fixed: CurrentItem is not properly updated when items are asynchronously loadeds
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q3 2012 SP1
      
              What's Fixed
            

* 
                  Fixed: Cannot properly apply a new ControlTemplate through the __ValidationSummaryStyle__ property.
                

* 
                  Fixed: __CurrentItem__ is not updated on moving back/forth if form has been unloaded/ reloaded.
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q3 2012
      
              What's Added
            

* 
                  Added: __EnablePropertyChangedBasedCancel__ - property to disable __PropertyChanged__ -based cancelling.
                
              What's Fixed
            

* 
                  Fixed: Initial values of cancelled properties are no longer cached.
                

* 
                  Fixed: Wrong registration of the __LabelStyle DependencyProperty__ .
                

* 
                  Fixed: Adding new item is disabled if the source is set after data form is created.
                

* 
                  Fixed: Memory leak when reloading a __DataForm__  multiple times.
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q2 2012 SP2
      
              What's Fixed
            

* 
                  Fixed: Adding new item is disabled if the source is set after data form is created.
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q2 2012 SP1
      
              What's Added
            

* 
                  Added: __French__ localization.
                
              What's Fixed
            

* 
                  Fixed: __ArgumentNullException__ is thrown when firing __PropertyChanged__ with  __null__.
                

* 
                  Fixed: __AutoEdit__ mode.
                

* 
                  Fixed: __CurrentCulture__ and __CurrentUICulture__ are now respected.
                

* 
                  Fixed: the wrong registration of the __LabelStyle DependencyProperty__.
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q2 2012
      
              What's Added
            

* 
                  Added: __IsComboboxEditable__ property for __DataFormComboBoxField__.
                

* 
                  Added: __DataTemplateSelectors__ support.
                
              What's Fixed
            

* 
                  Fixed: Error with a binding validation error that is not associated with any field.
                

* 
                  Fixed: __OK__ and __Cancel__ Buttons are not enabled if you change nullable int value.
                

* 
                  Fixed: An exception try/catched with __CancelEdit__ mechanism when __RadDataForm__ is bound to __DataTable__.
                

* 
                  Fixed: __BindingExpressionPath__ errors with __CommandButtonsVisiblity__ are now fixed.
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q1 2012 SP1
      
              What's Added
            

* 
                  Added: __INotifyPropertyChanged__ cancelling mechanism (__IEditableObject__ cancelling has higher priority)
                

* 
                  Added: __LabelTemplate__ (__DataTemplate__) property in the __DataFormDataField__ class
                
              What's Fixed
            

* 
                  Fixed: __Cancelling__ new item do not work in some occasions when __AutoCommit__ is true.
                

* 
                  Fixed: __Navigation buttons__ do not get disabled when __AutoCommit__ is false and there are uncommitted pending changes.
                

* 
                  Fixed: Navigating to another item commits changes when __AutoCommit__ is false.
                

* 
                  Fixed: Cancel edit for a new, already committed item, leads to an “empty” item, when __AutoCommit__ is true.
                

* 
                  Fixed:  Item level validation errors display property name instead of label in the validation summary.
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q1 2012
      
              What's Added
            

* 
                  Added: Improved item-level validation for __RIA__ entities
                
              What's Fixed
            

* 
                  Fixed: Autogenerated __DataFormDataFields__ (TextBox) do not update their __UI__ properly when item is a __FormatException__ occurs and __IEditableObject__. __CancelEdit__ is invoked.
                

* 
                  Fixed: In some isolated cases, validation errors permanently block __RadDatform__’s commit operation.
                

* 
                  Fixed: In some cases, item-level validation errors are not properly removed from the validation summary.
                

* 
                  Fixed: __IsThreeState__ property of __DataFormCheckBoxField__ is not respected.
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q3 2011 SP1
      
              What's Fixed
            

* 
                  Fixed: __RadDataForm__ validation
                

## 
        Changes for Telerik RadDataForm for SilverlightWPF Q1 2011
      

* 
                  The Telerik __RadDataForm__ has been just added to the Telerik WPF suite.
                
