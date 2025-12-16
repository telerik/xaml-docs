---
title: Edit Modes
page_title: Edit Modes
description: Check our &quot;Edit Modes&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-edit-modes
tags: edit,modes
published: True
position: 16
---

# Edit Modes

RadPropertyGrid exposes __EditMode__ property of type __PropertyGridEditMode__, which provides different options for __editing behavior__.

## Edit Modes

As to configuring RadPropertyGrid and assigning an __Item__ to it, please check the [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%}) help article.

### Default

The default option behaves similarly for both __Flat and Hierarchical__ [RenderMode]({%slug radpropertygrid-features-layout-rendering-modes%}). It __utilizes much lighter UI, but also provides fewer options__: 

1. All __PropertyGridFields__ editors are accessible from the UI and the correctness of an edit operation is ensured only by the data-binding mechanism.

2. There are __not distinct visual states of PropertyGridField__ that indicate whether it is being currently edited, or not.

3. When a __validation error occurs, users are not encouraged to fix it, or cancel their change__, by blocking the UI.

__Example 1: RadPropertyGrid with Default EditMode__

```XAML
	<telerik:RadPropertyGrid RenderMode="Flat" EditMode="Default"/>
```

__Figure 1__: RadPropertyGrid with Default EditMode

![Rad Property Grid Edit Modes Default](images/RadPropertyGrid_EditModes_Default.png)

### Single

Single EditMode introduces the concept of __editing properties one at a time__. An editor is created only for the currently edited property. The other values are displayed in TextBlocks

It relies on PropertyDefinition’s Binding property. Setting this mode is not supported with dynamic data or when [Property-Sets are defined]({%slug radpropertygrid-defining-propertysets%}).

>important __Single EditMode__ is supported only when __RenderMode is set to Flat__. For more information on the different rendering modes, please check the [Layout Rendering Modes]({%slug radpropertygrid-features-layout-rendering-modes%}) article.

__Example 2: RadPropertyGrid with EditMode set to Single__

```XAML
	<telerik:RadPropertyGrid RenderMode="Flat" EditMode="Single"/>
```

__Figure 2__: RadPropertyGrid with Single EditMode

![Rad Property Grid Edit Modes Single](images/RadPropertyGrid_EditModes_Single.png)

## Events

> The __BeginningEdit__ and __EditEnded__ events are raised only if the __EditMode__ property is set to __Single__.  

### BeginEdit

__BeginEditMethod__ has two overloads:

1. __BeginEdit()__: Starts an edit operation for the current PropertyDefinition.

2. __BeginEdit(PropertyDefinition propertyDefinition)__: Starts an edit operation for the PropertyDefinition that is passed as a parameter.

If the edit operation is successfully initiated, RadPropertyGrid’s __BeginningEdit event is raised__ . It is a cancellable event so one can prevent the edit operation there, in accordance to some custom logic:

__Example 3: Canceling the edit as BeginningEdit event is raised__

```C#
	void RpgBeginningEdit(object sender, PropertyGridBeginningEditEventArgs e)
	{
	    // Custom logic
	    e.Cancel = true;
	}
```
```VB
	Private Sub RpgBeginningEdit(sender As Object, e As PropertyGridBeginningEditEventArgs)
	    ' Custom logic
	    e.Cancel = True
	End Sub
```

Then __PropertyGridField__’s display content (TextBlock) is replaced by an editor.

### Finishing Edit

There are __two alternative options__ for finishing an edit operation:

1. __CommitEdit__: Tries to change the value of the bound property. First, it invokes the validation logic (raising the Validating, Validated events).

2. __CancelEdit__: Reverts the old value without validating the new ones.

Both operations result in __raising of the EditEnded event__, which indicates the executed operation and the Old and New value after it.

These __edit actions are integrated__ with [RadPropertyGrid’s Keyboard navigation]({%slug radpropertygrid-features-keyboard-support%}) (i.e. clicking on a display TextBlock triggers edit, pressing Esc cancels edit etc).

## See Also

 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})

 * [Layout Rendering Modes]({%slug radpropertygrid-features-layout-rendering-modes%})

 * [Keyboard Support]({%slug radpropertygrid-features-keyboard-support%})

 * [Defining Property-Sets]({%slug radpropertygrid-defining-propertysets%})
