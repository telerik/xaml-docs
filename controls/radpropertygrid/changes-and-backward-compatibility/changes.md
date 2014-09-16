---
title: Changes
page_title: Changes
description: Changes
slug: radpropertygrid-changes
tags: changes
publish: True
position: 0
---

# Changes



## Latest Release Notes

You can check the latest Release Notes
          {% if site.site_name == 'Silverlight' %}[ here.](http://www.telerik.com/products/silverlight/whats-new/release_notes.aspx){% endif %}{% if site.site_name == 'WPF' %}[ here.](http://www.telerik.com/products/wpf/whats-new/release-history.aspx){% endif %}

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q2 2014
      
              What's Added
            

* Added: ScrollIntoViewAsync – a method that allows scrolling property into view while virtualization is on. For more information, you can check the [Scrolling into View]({%slug radpropertygrid-scrolling%}) article.
                  

* Added: Single EditMode - an edit mode that enables edit of a single property. For more information, you can check the [Edit Modes]({%slug radpropertygrid-edit-modes%}) article.
                  
              What's Fixed
            

* Fixed: InvalidCastException is thrown when binding PropertyGrid.Item to collection
                  

* Fixed: InvalidOperationException Sequence contains no elements in PropertyGridField.CreateEditor()
                  

* Fixed: Memory leak with RadPropertyGrid when placed inside a window
                  

* Fixed: BindingMode is OneWay when there is editor template and PropertySetMode is None
                  

* Fixed: NullReferenceException at Telerik.Windows.Controls.Data.PropertyGrid.AutoBindBehavior.BindEditor()
                  

* Fixed: Localization for the Display Attribute does not work with PropertySets
                  

* Fixed: NullReferenceException in GetItemStatusCore method of CollectionEditorPickerAutomationPeer
                  

* Optimize PropertyDefinitions processing for not expanded nested properties
                  

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q1 2014
      
              What's Added
            

* 
                  Added: ItemChanged event
                

* 
                  Added: Editors caching (EnableEditorCaching property with default value True)
                

* 
                  Added: Expand/Collapse groups improvements
                

* 
                  Added: ReadOnlyEditorState property (Default, ReadOnly, Disabled). You can check this  [help article]({%slug radpropertygrid-features-readonlyeditorstate%}) for more information. 
                

* 
                  Added: Custom validation for PropertySets
                
              What's Fixed
            

* 
                  Fixed: Expand/Collapse groups logic does not work correctly in some cases
                

* 
                  Fixed: XamlParse exception when setting Expression_Dark theme at application level
                

* 
                  Fixed: Incorrect BorderBrush in RadPropertyGrid's CollectionEditor template for Expression_Dark theme
                

* 
                  Fixed: InvalidOperationException is thrown due to AutoBind behavior trying to TwoWay bind PropertyDefinitions to ReadOnly properties
                

* 
                  Fixed: NullReferenceException in FlagEnumEditor ValidateValue() method
                

* 
                  Fixed: ArgumentNullException in GetPropertyDescriptorConverter() method
                

* 
                  Fixed: There is a gap among field indicators and nested toggle buttons
                

* 
                  Fixed: The selected item is hidden on hover
                

* 
                  Fixed: Additional indent appears for PropertyDefinitions when PropertyGrid is grouped and Windows8TouchTheme is applied
                

* 
                  Fixed: The content of expand collapse button is not correctly set
                

* 
                  Fixed: Runtime theme exception - Office2013
                

* 
                  Fixed: When RadPropertyGrid is read-only, editors do not have consistent look
                

* 
                  Fixed: Search icon is missing in Office2013Theme
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q3 2013
      
              What's Added
            

* 
                  Added: Exposed GroupDefinitions collection and methods for expanding/collapsing a group in Flat RenderMode
                

* 
                  Added: Auto-generated NestedProperties for IDynamicMetaObjectProvider types (DynamicObject) support
                

* 
                  Added: ICustomTypeDescriptor support for PropertySets
                

* 
                  Added: DataAnnotations support for PropertySets
                

* 
                  Added: Keyboard navigation with Multiple and Extended selection when RenderMode is Flat
                

* 
                  Added: Touch support
                

* 
                  Performance optimizations in grouped scenario when expanding/collapsing nested properties
                
              What's Fixed
            

* 
                  Fixed: PropertyGridField does not arrange its content properly if height is larger than its default value
                

* 
                  Fixed: Design time exception for PropertyGridField
                

* 
                  Fixed: PropertyGrid bound to set of items does not work correctly when property definitions are manually generated
                

* 
                  Fixed: Extended range selection is incorrect when PropertyGrid is bound to dynamic data
                

* 
                  Fixed: Extended selection is not correct if the Item is set (not bound)
                

* 
                  Fixed: Incorrect extended selection when using Shift key
                

* 
                  Fixed: Changing visibility of property definitions leads to unexpected scrolling behavior on expanding/ collapsing nested fields
                

* 
                  Fixed: BrowsableAttribute is not respected when set through MetadataType
                

* 
                  Fixed: Editors are not styled correctly when theme is set to the control using StyleManager
                

* 
                  Fixed: DataContext is wrong when changing PropertySetMode to None
                

* 
                  Fixed: When defined in a XAML DataTemplate, RadPropertyGrid does not properly raise its AutogeneratingPropertyDefinition event
                

* 
                  Fixed: GroupName cannot be localized through DisplayAttribute
                

* 
                  Fixed: Editors are misaligned when column is resized using PropertyGridColumnResizer (Windows8Theme)
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q2 2013
      
              What's Added
            

* 
                  Added: Auto-generated NestedProperties for IDynamicMetaObjectProvider types (DynamicObject) support
                

* 
                  Added: FlatRendering mode
                

* 
                  Added: ICustomTypeProvider should be supported in .Net4.5 and SL5
                

* 
                  Added: KeyboardNavigation + CommandProvider extensibility
                

* 
                  Added: Virtualized grouping
                

* 
                  Added: CanUserSelect property
                

* 
                  Added: Commands + CommandProvider extensibility
                

* 
                  Added: TypeConverter support
                
              What's Fixed
            

* 
                  Fixed: AutobindBehavior generates a wrong binding path for nested manually generated PropertyDefinitions
                

* 
                  Fixed: More than one property definition can be selected when in unbound mode and SelectionMode is single or extended
                

* 
                  Fixed: Background property of a field cannot be set through the parent container (should be Transparent by default) / all themes
                

* 
                  Fixed: Expression Blend extracts invalid XAML when copying RadPropertyGrid's Template - Setter.Property cannot be null exception
                

* 
                  Fixed: SelectedPropertyDefinition cannot be set manually
                

* 
                  Fixed: When all of the nested properties of a certain property are Browsable(false) the "+" button of its field is still displayed
                

* 
                  Fixed: Selection does not work on fields containing disabled editors
                

* 
                  Fixed: Ctrl + A does not work in Multiple Selection
                

* 
                  Fixed: Incorrect selection when a property definition is selected in code-behind
                

* 
                  Fixed: AutogeneratedFields bound to nullable numeric properties does not update properly when null value is set. (TargetNullValue = string.Empty)
                

* 
                  Fixed: Single selection does not work correctly on third (and next) level of property definitions
                

* 
                  Fixed: Cannot bind to DataTable elements
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q1 2013
      
              What's Added
            

* 
                  Added: Dynamic FontStyles for Windows8 and Windows8Touch themes
                

* 
                  Added: GetItemStatusCore() override for automation peers of RadPropertyGrid
                

* 
                  Added: Multiple Selection
                

* 
                  Added: Support for PriorityBidning and MultiBinding
                

* 
                  Added: UI virtualization
                

* 
                  Added: FieldLoaded event
                

* 
                  Added: read-only support for CollectionEditor and CollectionEditorPicker
                

* 
                  Added: Localization for CollectionEditor's Header
                

* __Obsolete:__ SelectedField property of RadPropertyGrid (SelectedPropertyDefinition should be used instead)
                

* __Change:__ PropertyDefinitionsCollection is now ObservableItemCollection of PropertyDefinition. __Performance tip:__ Notifications should be suspended when bulk insert operations are executed.
                

* __Breaking Change:__ PropertyDefinition's Binding property is now of type BindingBase
                
              What's Fixed
            

* 
                  Fixed: RadPropertyGrid / SearchTextBox overlaps the search icon when you type long search criteria
                

* 
                  Fixed: Header's visibility when SearchBoxVisibility and SortButtonsVisibility are collapsed
                

* 
                  Fixed: Exception is thrown on creating EditorTemplate with framework element that does not have IsEnabled property
                

* 
                  Fixed: Marked PropertyGridFieldEventArgs as obsolete. SelectionChangeEventArgs should be used instead
                

* 
                  Fixed: CollectionEditor's Header Height
                

* 
                  Fixed: Disabled editor caching for dynamic types
                

* 
                  Fixed: When RadPropertyGrid is initially set to IsReadOnly=true, field editors do not change to read-only state
                

* 
                  Fixed: FilterText is not cleared on changing Item
                

* 
                  Fixed: NullRefException on SourceProperty of a PropertyDefinition
                

* 
                  Fixed: Memory optimizations (migrated the formerly QCV dependent logic to IQueriable)
                

* 
                  Fixed: StringFormat is not applied when set to the PropertyDefinition
                

* 
                  Fixed: Unload and load of RadGridView in a sequence result in some incorrect column width measurements
                

* 
                  Fixed: PropertyDefinition cannot be updated in AutoGeneratingPropertyDefinition when bound to dynamic data
                

* 
                  Fixed: Border of editing TextBox is not visible
                

* 
                  Fixed: PropertyChanged is not calling when PropertyGrid is placed in TabControl and switch between tabs
                

* 
                  Fixed: Item is not updated when changing it in case AutoGeneratedPropertyDefinitions is true
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q3 2012 SP1
      
              What's Added
            

* 
                  Added: Localization for __CollectionEditor__
              What's Fixed
            

* 
                  Fixed: __SearchTextBox__ overlaps the search icon when long search criteria is typed
                

* 
                  Fixed: an issue with header visibility when __SearchBoxVisibility__ and __SortButtonsVisibility__ are collapsed
                

* 
                  Fixed: Exception is thrown on creating __EditorTemplate__ with framework element that does not have __IsEnabled__ property
                

* 
                  Fixed: Disabled editor caching for dynamic types
                

* 
                  Fixed: Issue with CollectionEditor's __Header__ height
                

* 
                  Fixed: When __RadPropertyGrid__ is initially set to __IsReadOnly=true__, field editors do not change to read-only state
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q3 2012
      
              What's Added
            

* 
                  Added: new __DependencyProperty____ItemTemplate__ for __CollectionEditor__

* 
                  Added: __OrderIndex__ is now __DependencyProperty__

* 
                  Added: __Sorted__ and __Grouped__ events for __RadPropertyGrid__.
                
              What's Fixed
            

* 
                  Fixed: Changing __Visibility__ of a __PropertyDefinition__ does not place it in the correct group if the property grid is initially grouped.
                

* 
                  Fixed: __FlagEnumEditor__ support for long values.
                

* 
                  Fixed: __IValueConverter__ is not respected for property definition
                

* 
                  Fixed: Overriding __PropertyGridField__ editor's __AutomationID__

* 
                  Fixed: PropertyGridField's __IsExpanded__ state is not properly persisted on grouping
                

* 
                  Fixed: The UI does not get properly notified of __IsExpanded__ ValueChanged
                

* 
                  Fixed: Selection with __VisualStates__ improved
                

* 
                  Fixed: Assigning null value to nullable numeric properties displays validation errors.
                

* 
                  Fixed: __PropertyGridField__ is now passed as a "container" parameter value for __EditorTemplateSelector.SelectTemplate__().
                

* 
                  Fixed: Resolved a hash collision with identical __PropertyDefinitions__ that use cached editors.
                

* 
                  Fixed: Occasionally when __RadPropertyGrid__ is in a __TabItem__ changing tabs breaks selection.
                

* 
                  Fixed: Issue with __IsReadOnly__ binding.
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q2 2012 SP2
      
              What's Added
            

* 
                  Added: Editor caching. Performance optimization for grouping and filtering.
                

* 
                  Added: support for Nullable<T> enums.
                
              What's Fixed
            

* 
                  Fixed: Guid properties cannot be edited.
                

* 
                  Fixed: Searching does not show some nested properties.
                

* 
                  Fixed: Performance optimizations targeting faster loading when Item is changed with objects of the same type.
                

* 
                  Fixed: __NulRefException__ on clicking many times on sort/group buttons.
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q2 2012 SP1
      
              What's Added
            

* 
                  Added: new __DependencyProperty ItemTemplate__  for __CollectionEditor__
              What's Fixed
            

* 
                  Fixed: Changing __Visibility__  of a __PropertyDefinition__  does not place it in the correct group if the property grid is initially grouped
                

* 
                  Fixed: __FlagEnumEditor__  support for long values
                

* 
                  Fixed: __IValueConverter__  is not respected for property definition
                

* 
                  Fixed: Overriding __PropertyGridField__  editor's __AutomationID__

* 
                  Fixed: __PropertyGridField__ 's __IsExpanded__  state is not properly persisted on grouping
                  

* {% if site.site_name == 'WPF' %}
                      Fixed: The __UI__  does not get properly notified of __IsExpanded ValueChanged__  in __WPF__{% endif %}

* 
                  Fixed: Selection with __VisualStates__  improved
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q2 2012 
      
              What's Added
            

* 
                  Added: __FlagEnumEditor__

* 
                  Added: __Unbound__ mode
                

* 
                  Added: Better automation support
                

* 
                  Added: __CollectionEditor__
              What's Fixed
            

* 
                  Fixed: An exception is thrown when binding to indexed properties
                

* 
                  Fixed: __IValueConverter__ instance can now be assigned directly through __PropertyDefinitons__.
                

* 
                  Fixed: Groups based on collapsed __PropertyDefinitons__ should not be generated.
                

* 
                  Fixed: __BrowsableAttribute__ is not respected for nested properties.
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q1 2012 SP1
      
              What's Added
            

* 
                  Added: __Visibility__ (SystemWindows.Visibility) property in the __PropertyDefinition__ class. Note: It is bound to an instance’s respective __PropertyGridField Visibility__

* 
                  Added: Default editors can now validate on data errors
                
              What's Fixed
            

* 
                  Fixed: __NestedProperties__ are occasionally not extracted correctly when property value is an instance of super type
                

* 
                  Fixed: Set __ValidatesOnDataErrors__ = true on default editors' bindings
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q1 2012
      
              What's Added
            

* 
                  Added: Read-only mode for __RadPropertyGrid__ and read-only mode for separate __PropertyDefinitions__.
                  

1. __RadPropertyGrid__: added __IsReadOnly__ property.
                    

1. __PropertyDefinition__: added __IsReadOnly__ property.
                    

* 
                  Added: __Hierarchical__ filtering of nested properties (search in nested properties).
                

* 
                  Added: __SearchInNestedProperties__ property.
                

* 
                  Added: A default editor for __System.Windows.Media.Color__.
                

* 
                  Added: __AutoBind__ behavior for __PropertyGridField__ DataTemplates.
                

* 
                  Added:  __AutoBindBehavior__ type.
                

* 
                  Added: __DataTeplateSelector__ support for __RadPropertyGrid__.
                

* 
                  Added: __EditorTemplateSelector__ property.
                

* 
                  Added: __RadPropertyGrid__ supports binding to a collection of items, constructing union/intersection sets of properties.
                  

1. 
                      Added: __PropertySetMode__ property
                    

1. 
                      Added: __PropertySetOperation__ type
                    
              What's Fixed
            

* 
                  Fixed: __NestedProperties__ are occasionally not extracted correctly when property value is an instance of super type
                

* 
                  Fixed: Set __ValidatesOnDataErrors__ = true on default editors' bindings
                

## 
        Changes for Telerik RadPropertyGrid for SilverlightWPF Q3 2011 SP1
      
              What's Fixed
            

* 
                  Fixed: __RadPropertyGridField Height__

* 
                  Fixed: __RadPropertyGrid DisplayName__ of __PropertyDefinitions__ is now a dependency property to ease MVVM scenarios
                

* 
                  Fixed:  __PropertyGrid__ - properly update grouped template when source with different number of groups is used
                

* 
                  Fixed: Changing __RadPropertyGrid__ item will cause index out of range exception
                

## Telerik RadPropertyGrid Q2 2011 Beta

The Telerik RadPropertyGrid has been just added to the Telerik {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} suite.
        
