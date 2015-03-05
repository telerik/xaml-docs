---
title: Changes
page_title: Changes
description: Changes
slug: radpropertygrid-changes
tags: changes
published: True
position: 0
---

# Changes



## Latest Release Notes

You can check the latest Release Notes{% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## Q1 2015

You can check the {% if site.site_name == 'Silverlight' %}[Release Notes for version Q1 2015.](http://www.telerik.com/support/whats-new/silverlight/release-history/ui-for-silverlight-q1-2015){% endif %}{% if site.site_name == 'WPF' %}[Release Notes for version Q1 2015.](http://www.telerik.com/support/whats-new/wpf/release-history/ui-for-wpf-q1-2015){% endif %}

##  Q3 2014
      
### What's New

* Introduced Editor Attribute - RadPropertyGrid now provides support for the new Telerik attribute EditorAttribute that enables the user to define an editor for each property directly in its definition.
            

* Support for custom search - IsFiltered property of PropertyDefinition can be overridden and custom filtering criteria can be defined.
            

* Value property for PropertyDefinition - expose new logic that enables looking up the PropertyDefinition's bound property value directly.
            

### What's Fixed

* AutoBindBehavior throws an exception when bound to a read-only CustomTypeDescriptor.
            

* CollectionEditor picker is taller than other inputs in all themes except VisualStudio2013.
            

* Grouped PropertyGrid does not have a scrollbar when Windows8Touch or ExpressionDark theme is applied.
            

* AutoBindBehavior exception when bound to a property without a setter.
            

* CollectionEditorPicker's Height property is greater than the Height of other input controls.
            

* AutoBind behavior sets OneWay binding for properties of type TimeSpan.
            

* CurrentCulture is not respected if EditMode is set to Single.
            

* NullReferenceException is thrown on Tap down on PropertyGrid.
            

* SearchTextBox in RadPropertyGrid is not fully visible when SortAndGroupButtonsVisibility property is set to Collapsed in Windows8Touch theme.
            

##  Q2 2014
      
### What's Added
            

* ScrollIntoViewAsync – a method that allows scrolling property into view while virtualization is on. For more information, you can check the [Scrolling into View]({%slug radpropertygrid-scrolling%}) article.
                  

* Single EditMode - an edit mode that enables edit of a single property. For more information, you can check the [Edit Modes]({%slug radpropertygrid-edit-modes%}) article.
                  
### What's Fixed
            

* InvalidCastException is thrown when binding PropertyGrid.Item to collection
           
  
* InvalidOperationException Sequence contains no elements in PropertyGridField.CreateEditor()
           
  
* Memory leak with RadPropertyGrid when placed inside a window
           
  
* BindingMode is OneWay when there is editor template and PropertySetMode is None
           
  
* NullReferenceException at Telerik.Windows.Controls.Data.PropertyGrid.AutoBindBehavior.BindEditor()
           
  
* Localization for the Display Attribute does not work with PropertySets
           
  
* NullReferenceException in GetItemStatusCore method of CollectionEditorPickerAutomationPeer
                  

* Optimize PropertyDefinitions processing for not expanded nested properties
                  

## Q1 2014
      
### What's Added
            

* ItemChanged event
 

* Editors caching (EnableEditorCaching property with default value True)
 

* Expand/Collapse groups improvements
 

* ReadOnlyEditorState property (Default, ReadOnly, Disabled). You can check this  [help article]({%slug radpropertygrid-features-readonlyeditorstate%}) for more information.
 

* Custom validation for PropertySets
                
### What's Fixed
            

* Expand/Collapse groups logic does not work correctly in some cases
  

*  XamlParse exception when setting Expression_Dark theme at application level
  

* Incorrect BorderBrush in RadPropertyGrid's CollectionEditor template for Expression_Dark theme
                

* InvalidOperationException is thrown due to AutoBind behavior trying to TwoWay bind PropertyDefinitions to ReadOnly properties
                

* NullReferenceException in FlagEnumEditor ValidateValue() method
  

* ArgumentNullException in GetPropertyDescriptorConverter() method
  

* There is a gap among field indicators and nested toggle buttons
  

* The selected item is hidden on hover
  

* Additional indent appears for PropertyDefinitions when PropertyGrid is grouped and Windows8TouchTheme is applied
                

* The content of expand collapse button is not correctly set
  

* Runtime theme exception - Office2013
  

* When RadPropertyGrid is read-only, editors do not have consistent look
  

* Search icon is missing in Office2013Theme
                

## Q3 2013
      
### What's Added
            

* Exposed GroupDefinitions collection and methods for expanding/collapsing a group in Flat RenderMode
                

* Auto-generated NestedProperties for IDynamicMetaObjectProvider types (DynamicObject) support
                

* ICustomTypeDescriptor support for PropertySets
 

* DataAnnotations support for PropertySets
 

* Keyboard navigation with Multiple and Extended selection when RenderMode is Flat
 

* Touch support
                

* Performance optimizations in grouped scenario when expanding/collapsing nested properties
                
### What's Fixed
            

* PropertyGridField does not arrange its content properly if height is larger than its default value
                

* Design time exception for PropertyGridField
                

* PropertyGrid bound to set of items does not work correctly when property definitions are manually generated
                

* Extended range selection is incorrect when PropertyGrid is bound to dynamic data
 

* Extended selection is not correct if the Item is set (not bound)
 

* Incorrect extended selection when using Shift key
 

* Changing visibility of property definitions leads to unexpected scrolling behavior on expanding/ collapsing nested fields
                

* BrowsableAttribute is not respected when set through MetadataType
 

* Editors are not styled correctly when theme is set to the control using StyleManager
 

* DataContext is wrong when changing PropertySetMode to None
 

* When defined in a XAML DataTemplate, RadPropertyGrid does not properly raise its AutogeneratingPropertyDefinition event
                

* GroupName cannot be localized through DisplayAttribute
  

* Editors are misaligned when column is resized using PropertyGridColumnResizer (Windows8Theme)
                

## Q2 2013
      
### What's Added
            

* Auto-generated NestedProperties for IDynamicMetaObjectProvider types (DynamicObject) support
                

* FlatRendering mode
  

* ICustomTypeProvider should be supported in .Net4.5 and SL5
  

* KeyboardNavigation + CommandProvider extensibility
  

* Virtualized grouping
  

* CanUserSelect property
  

* Commands + CommandProvider extensibility
  

* TypeConverter support
                
### What's Fixed
            

* AutobindBehavior generates a wrong binding path for nested manually generated PropertyDefinitions
                

* More than one property definition can be selected when in unbound mode and SelectionMode is single or extended
                

* Background property of a field cannot be set through the parent container (should be Transparent by default) / all themes
                

* Expression Blend extracts invalid XAML when copying RadPropertyGrid's Template - Setter.Property cannot be null exception
                

* SelectedPropertyDefinition cannot be set manually
                

* When all of the nested properties of a certain property are Browsable(false) the "+" button of its field is still displayed
                

* Selection does not work on fields containing disabled editors
                

* Ctrl + A does not work in Multiple Selection
  

* Incorrect selection when a property definition is selected in code-behind
  

* AutogeneratedFields bound to nullable numeric properties does not update properly when null value is set. (TargetNullValue = string.Empty)
                

* Single selection does not work correctly on third (and next) level of property definitions
 

* Cannot bind to DataTable elements
 

##  Q1 2013
      
### What's Added
            

* Dynamic FontStyles for Windows8 and Windows8Touch themes
  

* GetItemStatusCore() override for automation peers of RadPropertyGrid
  

* Multiple Selection
  

* Support for PriorityBidning and MultiBinding
  

* UI virtualization
  

* FieldLoaded event
  

* Read-only support for CollectionEditor and CollectionEditorPicker
  

* Localization for CollectionEditor's Header
                

* __Obsolete:__ SelectedField property of RadPropertyGrid (SelectedPropertyDefinition should be used instead)
                

* __Change:__ PropertyDefinitionsCollection is now ObservableItemCollection of PropertyDefinition. __Performance tip:__ Notifications should be suspended when bulk insert operations are executed.
                

* __Breaking Change:__ PropertyDefinition's Binding property is now of type BindingBase
                
### What's Fixed
            

* RadPropertyGrid / SearchTextBox overlaps the search icon when you type long search criteria
                

* Header's visibility when SearchBoxVisibility and SortButtonsVisibility are collapsed
                

* Exception is thrown on creating EditorTemplate with framework element that does not have IsEnabled property
                

* Marked PropertyGridFieldEventArgs as obsolete. SelectionChangeEventArgs should be used instead
                

* CollectionEditor's Header Height
  

* Disabled editor caching for dynamic types
  

* When RadPropertyGrid is initially set to IsReadOnly=true, field editors do not change to read-only state
                

* FilterText is not cleared on changing Item
 

* NullRefException on SourceProperty of a PropertyDefinition
 

* Memory optimizations (migrated the formerly QCV dependent logic to IQueriable)
 

* StringFormat is not applied when set to the PropertyDefinition
 

* Unload and load of RadGridView in a sequence result in some incorrect column width measurements
                

* PropertyDefinition cannot be updated in AutoGeneratingPropertyDefinition when bound to dynamic data
                

* Border of editing TextBox is not visible
  

* PropertyChanged is not calling when PropertyGrid is placed in TabControl and switch between tabs
                

* Item is not updated when changing it in case AutoGeneratedPropertyDefinitions is true
                

##  Q3 2012 SP1
      
### What's Added
            

* Localization for __CollectionEditor__

### What's Fixed            

* __SearchTextBox__ overlaps the search icon when long search criteria is typed
                

* An issue with header visibility when __SearchBoxVisibility__ and __SortButtonsVisibility__ are collapsed
                

* Exception is thrown on creating __EditorTemplate__ with framework element that does not have __IsEnabled__ property
                

* Disabled editor caching for dynamic types
                

* Issue with CollectionEditor's __Header__ height
                

* When __RadPropertyGrid__ is initially set to __IsReadOnly__= true, field editors do not change to read-only state
                

## Q3 2012
      
### What's Added
            

* New __DependencyProperty____ItemTemplate__ for __CollectionEditor__

* __OrderIndex__ is now __DependencyProperty__

* __Sorted__ and __Grouped__ events for __RadPropertyGrid__.
                
### What's Fixed
            

* Changing __Visibility__ of a __PropertyDefinition__ does not place it in the correct group if the property grid is initially grouped.
                

* __FlagEnumEditor__ support for long values.
                

* __IValueConverter__ is not respected for property definition
  

* Overriding __PropertyGridField__ editor's __AutomationID__

* PropertyGridField's __IsExpanded__ state is not properly persisted on grouping
  

* The UI does not get properly notified of __IsExpanded__ ValueChanged
  

* Selection with __VisualStates__ improved
  

* Assigning null value to nullable numeric properties displays validation errors.
  

* __PropertyGridField__ is now passed as a "container" parameter value for __EditorTemplateSelector.SelectTemplate__().
                

* Resolved a hash collision with identical __PropertyDefinitions__ that use cached editors.
 

* Occasionally when __RadPropertyGrid__ is in a __TabItem__ changing tabs breaks selection.
 

* Issue with __IsReadOnly__ binding.
 

## Q2 2012 SP2
      
### What's Added
            

* Editor caching. Performance optimization for grouping and filtering.
  

* Support for Nullable<T> enums.
                
### What's Fixed
            

* Guid properties cannot be edited.
 

* Searching does not show some nested properties.
 

* Performance optimizations targeting faster loading when Item is changed with objects of the same type.
                

* __NulRefException__ on clicking many times on sort/group buttons.
                

## Q2 2012 SP1
      
### What's Added
            

* New __DependencyProperty ItemTemplate__  for __CollectionEditor__

### What's Fixed
            

* Changing __Visibility__  of a __PropertyDefinition__  does not place it in the correct group if the property grid is initially grouped
                

* __FlagEnumEditor__  support for long values
                

* __IValueConverter__  is not respected for property definition
                

* Overriding __PropertyGridField__  editor's __AutomationID__

* __PropertyGridField__ 's __IsExpanded__  state is not properly persisted on grouping                


*  Selection with __VisualStates__  improved
                

## Q2 2012
      
### What's Added
            

* __FlagEnumEditor__

* __Unbound__ mode
  

* Better automation support
  

* __CollectionEditor__

### What's Fixed
            

* An exception is thrown when binding to indexed properties
 

* __IValueConverter__ instance can now be assigned directly through __PropertyDefinitons__.
 

* Groups based on collapsed __PropertyDefinitons__ should not be generated.
 

* __BrowsableAttribute__ is not respected for nested properties.
 

## Q1 2012 SP1
      
### What's Added
            

*  __Visibility__ (SystemWindows.Visibility) property in the __PropertyDefinition__ class. Note: It is bound to an instance’s respective __PropertyGridField Visibility__

* Default editors can now validate on data errors
                
### What's Fixed
            

* __NestedProperties__ are occasionally not extracted correctly when property value is an instance of super type
                

* Set __ValidatesOnDataErrors__ = true on default editors' bindings
                

## Q1 2012
      
### What's Added
            

* Read-only mode for __RadPropertyGrid__ and read-only mode for separate __PropertyDefinitions__.
                  

	1. __RadPropertyGrid__: added __IsReadOnly__ property.
                    

	1. __PropertyDefinition__: added __IsReadOnly__ property.
                    

* __Hierarchical__ filtering of nested properties (search in nested properties).
                

* __SearchInNestedProperties__ property.
  

* A default editor for __System.Windows.Media.Color__.
  

* __AutoBind__ behavior for __PropertyGridField__ DataTemplates.
  

* __AutoBindBehavior__ type.
  

* __DataTeplateSelector__ support for __RadPropertyGrid__.
  

* __EditorTemplateSelector__ property.
  

* __RadPropertyGrid__ supports binding to a collection of items, constructing union/intersection sets of properties.
                  

	1. __PropertySetMode__ property
                    

	2. __PropertySetOperation__ type
                    
### What's Fixed
            

* __NestedProperties__ are occasionally not extracted correctly when property value is an instance of super type
                

* Set __ValidatesOnDataErrors__ = true on default editors' bindings
                

## Q3 2011 SP1
      
### What's Fixed
            

*  __RadPropertyGridField Height__

*  __RadPropertyGrid DisplayName__ of __PropertyDefinitions__ is now a dependency property to ease MVVM scenarios
                

*  __PropertyGrid__ - properly update grouped template when source with different number of groups is used
                

* Changing __RadPropertyGrid__ item will cause index out of range exception
                

## Telerik RadPropertyGrid Q2 2011 Beta

The Telerik RadPropertyGrid has been just added to the Telerik {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} suite.
        
