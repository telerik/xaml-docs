---
title: ReadOnlyEditorState
page_title: ReadOnlyEditorState
description: Check our &quot;ReadOnlyEditorState&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-features-readonlyeditorstate
tags: readonlyeditorstate
published: True
position: 15
---

# {{ site.framework_name }} RadPropertyGrid ReadOnlyEditorState

As of __Q1 2014__ release we have introduced a new property of RadPropertyGrid - __ReadOnlyEditorState__.

It represents RadPropertyGrid's read only behavior and has three options:

* __Default__: This is the current behavior of RadPropertyGrid when __IsReadOnly="True"__ is set.  When this is the chosen option the __IsReadOnly__ property of the __TextBox and CollectionEditorPicker__ is respected. For all other controls the __IsEnabled__ property is set.

* __Disabled__: Provides a consistent view and behavior, by binding the __IsEnabled__ property of the corresponding editors ( __TexBox__, __CollectionEditor__, __DateTimePicker__). This option does not allow any interaction with the property values.

* __ReadOnly__: When this is the selected option, the __IsReadOnly__ property will be set. If the corresponding control does __not have IsReadOnly__ property, then the __IsEnabled__ property will be set as a fallback. This option provides limited interaction with the property values.

>importantThis behavior can be used only when IsReadOnly = “True”.

The following examples show how RadPropertyGrid will look like when the ReadOnlyEditorState property is used:

#### __[XAML] Example 1: Setting ReadOnlyEditorState property to Disabled__

	{{region xaml-radpropertygrid-features-readonlyeditorstate_0}}
	<telerik:RadPropertyGrid 
	    Item="{Binding Employee}"
	    IsReadOnly="True"
	    ReadOnlyEditorState="Disabled"/>
{{endregion}}

#### __Figure 1: RadPropertyGrid with ReadOnlyEditorState set to Disabled__

![Rad Property Grid Disabled](images/RadPropertyGrid_Disabled.png)

#### __[XAML] Example 2: Setting ReadOnlyEditorState to ReadOnly__

	{{region xaml-radpropertygrid-features-readonlyeditorstate_1}}
	<telerik:RadPropertyGrid
	    Item="{Binding Employee}"
	    IsReadOnly="True"
	    ReadOnlyEditorState="ReadOnly"/>
{{endregion}}

#### __Figure 2: RadPropertyGrid with ReadOnlyEditorState set to ReadOnly__

![Rad Property Grid Read Only](images/RadPropertyGrid_ReadOnly.png)

## See Also

 * [Read Only PropertyDefinition]({%slug radpropertygrid-howto-readonly-propertydefinitions%})

 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})
