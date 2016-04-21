---
title: Developer Focused Examples
page_title: Developer Focused Examples
description: Developer Focused Examples
slug: radpropertygrid-sdk-examples
tags: sdk,examples
published: True
position: 2
---

# Developer Focused Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadPropertyGrid__.

## List of all RadPropertyGrid SDK examples:

{% if site.site_name == 'WPF' %}

* __[AutoBind Attached Behavior](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/AutoBindAttachedBehavior)__ - 
The need of reusable DataTemplates is a common scenario with quite few universal viable solutions. 
This example shows how the AutoBind attached behavior can enable RadPropertyGrid to use a single DataTemplate resource as an EditorTemplate value for multiple PropertyDefinitions without any additional effort on the users' side.

See Also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/autobind.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/autobind.html
* __[CollectionEditor](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/CollectionEditors)__ - 
This example demonstrates how to use  - control that provides UI for editing collections and their items.
On the left side a ListBox generates its items based on 's source. 
On the right side RadPropertyGrid is generated for editing each item.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/collectioneditor.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/collectioneditor.html
* __[Combobox editor for Boolean property](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ComboboxEditorBooleanProperty)__ - 
This example demonstrates how to show RadCombobox as an editor for Boolean property.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radcombobox/overview.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radcombobox/overview.html
* __[Custom ToolTip in PropertyGridField](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/CustomHyperlinkToolTip)__ -  
This example demonstrates how to add a custom ToolTip with Hyperlink in PropertyGridField. 
Hover on each "Help" button to see the custom tooltip.



* __[Custom Keyboard Command Provider](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/CustomKeyboardCommandProvider)__ -  
RadPropertyGrid provides an easy MVVM-friendly approach for customization of its default commands' logic. 
This example demonstrates how to extend the way RadPropertyGrid handles a particular key. 
Press Tab to navigate forward through RadPropertyGrid elements or pres Shift+Tab to navigate backwards.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/keyboard-support.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/keyboard-support.html
* __[Edit Modes](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/EditModes)__ - 
This example demonstrates how the editing behavior of RadPropertyGrid can be modified via EditMode property.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/edit-modes
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/edit-modes
* __[Editor Attribute](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/EditorAttribute)__ - 
This example demonstrates how through the EditorAttribute the user can define an editor for each property directly in its definition.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/editor-attribute
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/editor-attribute
* __[FlagEnumEditor](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/FlagEnumEditor)__ - 
This example demonstrates how RadPropertyGrid can be used to edit bit flag enum through its  property.
It enables the user to store any combination of the values that are defined in the enumerator list.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/radenumeditor
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/radenumeditor
* __[Show Tooltip for GroupName](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/GroupNameTooltip)__ - 
This example demonstrates how to show a tooltip for PropertyGridField's GroupName.
* __[ReadOnlyEditorState](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ReadOnlyEditorState)__ - 
This example demonstrates how a read only behavior of RadPropertyGrid can be defined through  property.
You can check the different states of the property by clicking the ToggleButton at the top.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/readonlyeditorstate
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/readonlyeditorstate
* __[ReadOnly PropertyDefinition](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ReadOnlyPropertyDefinition)__ - 
This example demonstrates how to control which property definitions of RadPropertyGrid to be read only.


WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/how-to/howto-readonly-propertydefinitions
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/how-to/howto-readonly-propertydefinitions
* __[ScrollIntoViewAsync](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ScrollIntoViewAsync)__ - 
This example demonstrates how to scroll to a particular PropertyDefinition and select it.
Click on the bottom button to observe the behavior.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/scrolling
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/scrolling
* __[Validation](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/Validation)__ - 
RadPropertyGrid supports validation through IDataErrorInfo and also through DataAnnotations. This example demonstrates how to implement such validation.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/validation
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/validation
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[AutoBind Attached Behavior](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/AutoBindAttachedBehavior)__ - 
The need of reusable DataTemplates is a common scenario with quite few universal viable solutions. 
This example shows how the AutoBind attached behavior can enable RadPropertyGrid to use a single DataTemplate resource as an EditorTemplate value for multiple PropertyDefinitions without any additional effort on the users' side.

See Also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/autobind.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/autobind.html
* __[CollectionEditor](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/CollectionEditors)__ - 
This example demonstrates how to use  - control that provides UI for editing collections and their items.
On the left side a ListBox generates its items based on 's source. 
On the right side RadPropertyGrid is generated for editing each item.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/collectioneditor.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/collectioneditor.html
* __[Combobox editor for Boolean property](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ComboboxEditorBooleanProperty)__ - 
This example demonstrates how to show RadCombobox as an editor for Boolean property.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radcombobox/overview.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radcombobox/overview.html
* __[Custom Keyboard Command Provider](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/CustomKeyboardCommandProvider)__ -  
RadPropertyGrid provides an easy MVVM-friendly approach for customization of its default commands' logic. 
This example demonstrates how to extend the way RadPropertyGrid handles a particular key. 
Press Tab to navigate forward through RadPropertyGrid elements or pres Shift+Tab to navigate backwards.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/keyboard-support.html
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/keyboard-support.html
* __[Edit Modes](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/EditModes)__ - 
This example demonstrates how the editing behavior of RadPropertyGrid can be modified via EditMode property.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/edit-modes
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/edit-modes
* __[Editor Attribute](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/EditorAttribute)__ - 
This example demonstrates how through the EditorAttribute the user can define an editor for each property directly in its definition.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/editor-attribute
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/editor-attribute
* __[FlagEnumEditor](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/FlagEnumEditor)__ - 
This example demonstrates how RadPropertyGrid can be used to edit bit flag enum through its  property.
It enables the user to store any combination of the values that are defined in the enumerator list.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/radenumeditor
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/radenumeditor
* __[Show Tooltip for GroupName](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/GroupNameTooltip)__ - 
This example demonstrates how to show a tooltip for PropertyGridField's GroupName.
* __[ReadOnlyEditorState](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ReadOnlyEditorState)__ - 
This example demonstrates how a read only behavior of RadPropertyGrid can be defined through  property.
You can check the different states of the property by clicking the ToggleButton at the top.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/readonlyeditorstate
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/readonlyeditorstate
* __[ReadOnly PropertyDefinition](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ReadOnlyPropertyDefinition)__ - 
This example demonstrates how to control which property definitions of RadPropertyGrid to be read only.


WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/how-to/howto-readonly-propertydefinitions
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/how-to/howto-readonly-propertydefinitions
* __[ScrollIntoViewAsync](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ScrollIntoViewAsync)__ - 
This example demonstrates how to scroll to a particular PropertyDefinition and select it.
Click on the bottom button to observe the behavior.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/scrolling
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/scrolling
* __[Validation](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/Validation)__ - 
RadPropertyGrid supports validation through IDataErrorInfo and also through DataAnnotations. This example demonstrates how to implement such validation.

See also:
WPF: http://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/validation
SL: http://docs.telerik.com/devtools/silverlight/controls/radpropertygrid/features/validation
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).