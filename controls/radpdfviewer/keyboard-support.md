---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-keyboard-support
tags: keyboard,support
published: True
position: 10
---

# Keyboard Support



__RadPdfViewer__ supports KeyBindings - it has a number of predefined common key-bindings, but you can also customize them by disabling the default ones and defining new ones.

## 

The key-bindings supported by the control are:
<table>
 <tr>
   <th><b>Hotkey</b></th>
   <th><b>Action (Command)</b></th>
   <th><b>Parameter</b></th>
 </tr>
 <tr>
  <td>Ctrl+C</td>
  <td>Copy</td>
  <td></td>
 </tr>
 <tr>
  <td>Ctrl+A</td>
  <td>SelectAll</td>
  <td></td>
 </tr>
 <tr>
  <td>Left Arrow</td>
  <td>MoveCaret</td>
  <td>CaretMovementType.MoveToPreviousCharacter</td>
 </tr>
 <tr>
  <td>Right Arrow</td>
  <td>MoveCaret</td>
  <td>CaretMovementType.MoveToNextCharacter</td>
 </tr>
 <tr>
  <td>Ctrl+Left Arrow</td>
<td>

MoveCaret</td><td>

CaretMovementType.MoveToPreviousWord</td></tr><tr><td>

Ctrl+Right Arrow</td><td>

MoveCaret</td><td>

CaretMovementType.MoveToNextWord</td></tr><tr><td>

Upper Arrow</td><td>

MoveCaret</td><td>

CaretMovementType.MoveLineUp</td></tr><tr><td>

Down Arrow</td><td>

MoveCaret</td><td>CaretMovementType.MoveLineDown</td></tr><tr><td>

Home</td><td>

MoveCaret</td><td>

CaretMovementType.MoveToLineStart</td></tr><tr><td>

End</td><td>

MoveCaret</td><td>

CaretMovementType.MoveToLineEnd</td></tr><tr><td>

Ctrl+Home</td><td>

MoveCaret</td><td>

CaretMovementType.MoveToStartOfDocument</td></tr><tr><td>

Ctrl+End</td><td>

MoveCaret</td><td>

CaretMovementType.MoveToEndOfDocument</td></tr></table>

The key bindings of the viewer can be retrieved using the __KeyBindings__ property. After that, you can proceed to modify the collection using the public API of the class:



```C#
	public void Clear()                                                //Clears the collection
	public void SetInputBindings(InputBindingCollection inputBindings) //Clears the current KeyBindings and sets the new ones.
	
	public void Add(InputBinding inputBinding)                          
	public void AddRange(IEnumerable<InputBinding> inputBindings)
	
	public void RegisterCommand(ICommand command, Key key, ModifierKeys modifierKeys = ModifierKeys.None, object commandParameter = null)
```



Here is an example that shows how the default input bindings can be cleared and two ways of registering new key bindings:



```C#
	this.pdfViewer.Clear();
	this.pdfViewer.KeyBindings.Add(new KeyBinding(this.pdfViewer.Commands.PageUpCommand, new KeyGesture(Key.PageUp)));
	this.pdfViewer.KeyBindings.RegisterCommandDescriptor(this.pdfViewer.CommandDescriptors.PageDownCommandDescriptor, Key.PageDown);
```
