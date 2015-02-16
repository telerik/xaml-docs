---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radpropertygrid-sdk-examples
tags: sdk,examples
published: True
position: 2
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadPropertyGrid__.

## List of all RadPropertyGrid SDK examples:

{% if site.site_name == 'WPF' %}

* __[AutoBind Attached Behavior](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/AutoBindAttachedBehavior)__ - 
The need of reusable DataTemplates is a common scenario with quite few universal viable solutions. 
The AutoBind attached behavior enables RadPropertyGrid to use a single DataTemplate resource as an EditorTemplate value for multiple PropertyDefinitions without any additional effort on the users' side.
* __[CollectionEditor](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/CollectionEditors)__ - 
 is editor control that provide UI for editing collections and their items.
* __[Combobox editor for Boolean property](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ComboboxEditorBooleanProperty)__ - 
This example demonstrates how to show Combobox as an editor of Boolean property.
* __[Custom ToolTip in PropertyGridField](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/CustomHyperlinkToolTip)__ -  
This example demonstrates how to add a custom ToolTip with Hiperlink in PropertyGridField.
* __[Custom Keyboard Command Provider](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/CustomKeyboardCommandProvider)__ -  
RadPropertyGrid provides an easy MVVM-friendly approach for customization of its default commands' logic. This example demonstrates how to extend the way RadPropertyGrid handles a particular key.
* __[Edit Modes](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/EditModes)__ - 
RadPropertyGrid exposes an EditMode property of type PropertyGridEditMode, which provides different options for editing behavior.
* __[Editor Attribute](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/EditorAttribute)__ - 
RadPropertyGrid provides support for the new Telerik attribute - EditorAttribute that enables the user to define an editor for each property directly in its definition.
* __[FlagEnumEditor](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/FlagEnumEditor)__ - 
RadPropertyGrid supports editing bit flag enum by exposing a new editor – . It enables the user to store any combination of the values that are defined in the enumerator list
* __[Show Tooltip for GroupName](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/GroupNameTooltip)__ - 
This example demonstrates how to show a tooltip for PropertyGridField's GroupName.
* __[ReadOnlyEditorState](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ReadOnlyEditorState)__ - 
 property represents RadPropertyGrid's read only behavior.
* __[ReadOnly PropertyDefinition](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ReadOnlyPropertyDefinition)__ - 
This example demonstrates how to control which property definitions to be read only.
* __[ScrollIntoViewAsync](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ScrollIntoViewAsync)__ - 
This example demonstrates how to scroll to a particular PropertyDefinition and selecting it.
* __[Validation](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/Validation)__ - 
RadPropertyGrid supports validation through IDataErrorInfo and also through DataAnnotations. This example demonstrates how to implement such validation.
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[AutoBind Attached Behavior](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/AutoBindAttachedBehavior)__ - 
The need of reusable DataTemplates is a common scenario with quite few universal viable solutions. 
The AutoBind attached behavior enables RadPropertyGrid to use a single DataTemplate resource as an EditorTemplate value for multiple PropertyDefinitions without any additional effort on the users' side.
* __[CollectionEditor](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/CollectionEditors)__ - 
 is editor control that provide UI for editing collections and their items.
* __[Combobox editor for Boolean property](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ComboboxEditorBooleanProperty)__ - 
This example demonstrates how to show Combobox as an editor of Boolean property.
* __[Custom Keyboard Command Provider](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/CustomKeyboardCommandProvider)__ -  
RadPropertyGrid provides an easy MVVM-friendly approach for customization of its default commands' logic. This example demonstrates how to extend the way RadPropertyGrid handles a particular key.
* __[Edit Modes](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/EditModes)__ - 
RadPropertyGrid exposes an EditMode property of type PropertyGridEditMode, which provides different options for editing behavior.
* __[Editor Attribute](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/EditorAttribute)__ - 
RadPropertyGrid provides support for the new Telerik attribute - EditorAttribute that enables the user to define an editor for each property directly in its definition.
* __[FlagEnumEditor](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/FlagEnumEditor)__ - 
RadPropertyGrid supports editing bit flag enum by exposing a new editor – . It enables the user to store any combination of the values that are defined in the enumerator list
* __[Show Tooltip for GroupName](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/GroupNameTooltip)__ - 
This example demonstrates how to show a tooltip for PropertyGridField's GroupName.
* __[ReadOnlyEditorState](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ReadOnlyEditorState)__ - 
 property represents RadPropertyGrid's read only behavior.
* __[ReadOnly PropertyDefinition](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ReadOnlyPropertyDefinition)__ - 
This example demonstrates how to control which property definitions to be read only.
* __[ScrollIntoViewAsync](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ScrollIntoViewAsync)__ - 
This example demonstrates how to scroll to a particular PropertyDefinition and selecting it.
* __[Validation](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/Validation)__ - 
RadPropertyGrid supports validation through IDataErrorInfo and also through DataAnnotations. This example demonstrates how to implement such validation.
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).