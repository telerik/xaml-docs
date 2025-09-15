---
title: History
page_title: History
description: Check our &quot;History&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-features-history
tags: history
published: True
position: 3
---

# History



## 

__RadImageEditor__ has a history stack, which records each command that is executed on the image currently loaded in the control. This is convenient, as it allows past actions to be reversed and re-applied whenever needed.

Undoing the effect of a command can be done as follows:

__Example 1: Undo a command__

```C#
	this.imageEditor.Undo();
```
```VB.NET
	Me.imageEditor.Undo()
```

Оr, if you are using __RadImageEditorUI__:

__Example 2: Undo a command__

```C#
	this.imageEditorUI.ImageEditor.Undo();
```
```VB.NET
	Me.imageEditorUI.ImageEditor.Undo()
```

Redo can be executed in the same way.

Even though image editing is rather memory intensive, you should not have any worries with RadImageEditor. Instead of keeping every step in the history stack as a copy of the image, RadImageEditor uses an adaptive cache scheme – it retains images along with the commands and their arguments. When memory depletes, it can delete some images, but can recreate them later from previous history points.

You have control over the maximum amount of memory taken by the image history through the __RadImageEditor.History.MaximumMemoryBufferSize__ property. The default value is {% if site.site_name == 'Silverlight' %}256 MB for Silverlight{% endif %}{% if site.site_name == 'WPF' %}512 MB for WPF{% endif %}.

Other useful properties that the __ImageHistory__ object, which RadImageEditor exposes through the History property, has are:

* __Depth__: Gets or sets the number of actions that will be recorded in the stack.

* __CanUndo__: A boolean property, which indicates if invoking Undo() will change the image in the editor. It is false when the bottom of the current history stack has been reached or there are no commands registered in the stack.

* __CanRedo__: A boolean property, which indicates if there are any commands that have been undone since the execution of the last command.

* __CurrentImage__: Returns the current image viewed in the editor.

The ImageHistory also offers some convenient events, such as:

* __UndoExecuting__: Fires when an Undo has been triggered.

* __RedoExecuting__: Fires when a Redo has been triggered.

* __CurrentImageChanged__: Fires when the image currently viewed in the editor has changed, i.e. if a command has been executed on the image loaded in the editor or the image has been changed all together.

For example, if you subscribe to the CurrentImageChanged in the following way, you will be able to tell if the current image has been changed (either using the OpenImageCommand or by assigning a new value to the Image property of the editor) using the method from **Example 3**.



__Example 3: Subscribe to CurrentImageChanged__

```C#
	this.imageEditorUI.ImageEditor.History.CurrentImageChanged += History_CurrentImageChanged;
```
```VB.NET
	AddHandler Me.imageEditorUI.ImageEditor.History.CurrentImageChanged, AddressOf History_CurrentImageChanged
```

Аnd change the value of some Boolean property in the handler of the event:

__Example 4: Handle CurrentImageChanged__

```C#
	private bool hasImageBeenChanged;
	void History_CurrentImageChanged(object sender, EventArgs e)
	{
	    ImageHistory history = (ImageHistory)sender;
	    if (!history.CanRedo && !history.CanUndo)
	    {
	        hasImageBeenChanged = true;
	    }
	    else
	    {
	        hasImageBeenChanged = false;
	    }
	}
```
```VB.NET
	Private hasImageBeenChanged As Boolean
	Private Sub History_CurrentImageChanged(sender As Object, e As EventArgs)
	    Dim history As ImageHistory = DirectCast(sender, ImageHistory)
	    If Not history.CanRedo AndAlso Not history.CanUndo Then
	        hasImageBeenChanged = True
	    Else
	        hasImageBeenChanged = False
	    End If
	End Sub
```



## See Also

* [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})