---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-keyboard-support
tags: keyboard,support
published: True
position: 10
---

# Keyboard Support

{% if site.site_name == 'Silverlight' %}
Telerik __RichTextBox__ for Silverlight supports commands in a way that is similar to the commanding mechanism in WPF. It is only natural that some of these commands be triggered on key combinations. There are default key-bindings defined for the most widely used commands.

>importantNote that the browser could handle some of the shortcuts and some of them cannot be even enabled. RadRichTextBox is not capable of modifying this behavior as it is up to the browser.
{% endif %}

{% if site.site_name == 'WPF' %}
Telerik __RichTextBox__ for WPF supports the commanding mechanism in WPF. There are default key-bindings defined for the most widely used commands.
{% endif %}

## 
<table> <tr><th>

<b>Action</b></th><th>

<b>Hotkey</b></th></tr><tr><td>

Open new document</td><td>

Ctrl+N</td></tr><tr><td>

Open existing document</td><td>

Ctrl+O</td></tr><tr><td>


Save</td><td>

Ctrl+S</td></tr><tr><td>

Print</td><td>

Ctrl+P</td></tr><tr><td>


Copy</td><td>

Ctrl+C</td></tr><tr><td>

Paste</td><td>

Ctrl+V</td></tr><tr><td>

Cut</td><td>

Ctrl+X</td></tr><tr><td>

Delete</td><td>

Delete</td></tr><tr><td>

Delete previous symbol</td><td>

Back, Ctrl+Back, Shift+Back</td></tr><tr><td>

Undo</td><td>

Ctrl+Z</td></tr><tr><td>

Redo</td><td>

Ctrl+Y</td></tr><tr><td>

InsertLineBreak</td><td>

Shift+Enter</td></tr><tr><td>

InsertPageBreak</td><td>

Ctrl+Enter</td></tr><tr><td>

InsertColumnBreak</td><td>

Ctrl+Enter, Shift+Enter</td></tr><tr><td>

ToggleBold</td><td>

Ctrl+B, Ctrl+Shift+B</td></tr><tr><td>

ToggleItalic</td><td>

Ctrl+I, Ctrl+Shift+I</td></tr><tr><td>

ToggleSuperscript</td><td>

Ctrl+'+'</td></tr><tr><td>

ToggleSubscript</td><td>

Ctrl+Shift+'+'</td></tr><tr><td>

ToggleUnderline</td><td>

Ctrl+U</td></tr><tr><td>

ToggleFormattingSymbols</td><td>

Ctrl+D8, Shift+D8</td></tr><tr><td>

ClearFormatting</td><td>

Ctrl+Space</td></tr><tr><td>

CopyFormatting</td><td>

Ctrl+Shift+C</td></tr><tr><td>

PasteFormatting</td><td>

Ctrl+Shift+V</td></tr><tr><td>

CancelFormatPainter or ExitHeaderFooterEditMode, depending on the current editing context</td><td>

Esc</td></tr>{% if site.site_name == 'WPF' %}<tr><td>

IncrementFontSize</td><td>

Ctrl+Shift+OemPeriod</td></tr><tr><td>

DecrementFontSize</td><td>

Ctrl+Shift+OemComma</td></tr>{% endif %}<tr><td>

ChangeTextAlignment with parameter RadTextAlignment.Justify</td><td>

Ctrl+J</td></tr><tr><td>

ChangeTextAlignment with parameter RadTextAlignment.Right</td><td>

Ctrl+R</td></tr><tr><td>

ChangeTextAlignment with parameter RadTextAlignment.Left</td><td>

Ctrl+L</td></tr><tr><td>

ChangeTextAlignment with parameter RadTextAlignment.Center</td><td>

Ctrl+E</td></tr><tr><td>

TabForward</td><td>

Tab</td></tr><tr><td>

TabBackward</td><td>

Shift+Tab</td></tr><tr><td>

InsertText with parameter "\t"</td><td>

Ctrl+Tab</td></tr><tr><td>

Insert non-breaking space</td><td>

Ctrl+Space</td></tr><tr><td>

SelectAll</td><td>

Ctrl+A</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.Previous</td><td>

Left Arrow</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.Next</td><td>

Right Arrow</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.PreviousWord</td><td>

Ctrl+Left Arrow</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.NextWord</td><td>

Ctrl+Right Arrow</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.Up</td><td>

Upper Arrow</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.Down</td><td>

Down Arrow</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections. ParagraphStart</td><td>

Ctrl+Upper Arrow</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections. ParagraphEnd</td><td>

Ctrl+Down Arrow</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.Home</td><td>

Home</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.DocumentStart. This moves the caret at the first position of the document.</td><td>

Ctrl+Home</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.End</td><td>

End</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.DocumentEnd</td><td>

Ctrl+End</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.PageUp</td><td>

PageUp</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.PageDown</td><td>

PageDown</td></tr><tr><td>

ShowSpellCheckingDialog</td><td>

F7</td></tr><tr><td>

ShowFindReplaceDialog</td><td>

Ctrl+F</td></tr><tr><td>

ShowFontPropertiesDialog</td><td>

Ctrl+D</td></tr><tr><td>

ShowInsertHyperlinkDialog</td><td>

Ctrl+K</td></tr></table>

Now these key bindings can be overridden and customized to the liking of the user. What is more, new bindings can be added to both the Commands exposed through the RichTextBoxCommands class or to user-defined ones in a quite straight-forward way. This is how it can be done in XAML:
        
{% if site.site_name == 'Silverlight' %}

__Example 1: Customize InputBindings__

```XAML

	<telerik:RadRichTextBox Grid.Row="1" Name="editor">
		<telerik:CommandManager.InputBindings>
			<telerik:InputBindingCollection>
				<!-- Bind Spell Checking to Ctrl+Shift+S -->
				<telerik:KeyBinding Gesture="Ctrl+Shift+S" Command="RichTextBoxCommands.ShowSpellCheckingDialog"/>
				<!-- Stop Toggle Bold on Ctrl+Shift+B -->
				<telerik:KeyBinding Gesture="Ctrl+Shift+B"/>
				<!-- Re-map Ctrl+Space from Clear Formating to ShowManageBookmarksDialog -->
				<telerik:KeyBinding Gesture="Ctrl+Space" Command="RichTextBoxCommands.ShowManageBookmarksDialog"/>
			</telerik:InputBindingCollection>
		</telerik:CommandManager.InputBindings>
	</telerik:RadRichTextBox>
```

{% endif %}{% if site.site_name == 'WPF' %}

__Example 1: Customize InputBindings__

```XAML

    <telerik:RadRichTextBox Name="radRichTextBox">
      <telerik:RadRichTextBox.InputBindings>
        <!-- Bind Spell Checking to Ctrl+Shift+S -->
        <KeyBinding Gesture="Ctrl+Shift+S" Command="telerikDocs:RichTextBoxCommands.ShowSpellCheckingDialog"/>
        <!-- Stop Toggle Bold on Ctrl+Shift+B -->
        <KeyBinding Gesture="Ctrl+Shift+B"/>
        <!-- Re-map Ctrl+Space from Clear Formating to ShowManageBookmarksDialog -->
        <KeyBinding Gesture="Ctrl+Space" Command="telerikDocs:RichTextBoxCommands.ShowManageBookmarksDialog"/>
      </telerik:RadRichTextBox.InputBindings>
    </telerik:RadRichTextBox>
```

Please note that in the above code snippet the telerikDocs namespace is defined as follows: 

__Example 2: Namespace definition__
```XAML

	xmlns:telerikDocs="clr-namespace:Telerik.Windows.Documents.RichTextBoxCommands;assembly=Telerik.Windows.Documents"
```

__Example 3: Disable the shortcut for creating a new document in code-behind__
```C#
    
    this.radRichTextBox.RegisteredApplicationCommands.Remove(System.Windows.Input.ApplicationCommands.New);
```

Some of the key combinations included by default in RadRichTextBox pass different parameters to the commands so that they can execute according to the current context. An example of such commands are TabForward and TabBackward. 
- By default, the tab symbol can always be inserted with **Ctrl+Tab** shortcut.

- By default, the Tab shortcut is bound to the **TabForward** command - a command with more complex, context-dependent behavior. You can remap the shortcut to the InsertText command with the tab symbol as a parameter.

__Example 4: Remap the shortcut to different command__
```XAML

    <telerik:RadRichTextBox >
        <telerik:RadRichTextBox.InputBindings>
            <KeyBinding Gesture="Tab" Command="telerikDocs:RichTextBoxCommands.InsertText" CommandParameter="&#x09;" />
        </telerik:RadRichTextBox.InputBindings>
    </telerik:RadRichTextBox>
```

 You can fine-tune the behavior of the **TabForward** command, which is bound to the Tab shortcut by default using the exposed parameter values.
 
__Example 5: Customize command behavior through its parameters__
```XAML

    <telerik:RadRichTextBox.InputBindings>
        <KeyBinding Gesture="Tab" Command="telerikDocs:RichTextBoxCommands.TabForward" CommandParameter="InsertTabSymbol, ChangeParagraphListLevel, ChangeParagraphLeftIndent, NavigateInTable, AppendTableRow" />
    </telerik:RadRichTextBox.InputBindings>
```

{% endif %}

>You can check the [Simulate Watermark SDK](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/SimulateWatermark) example which demonstrates how you can modify the **InputBindings** collection of RadRichTextBox in code-behind.

Sometimes overriding the key bindings does not provide sufficient support, as depending on the language and the keyboard, different ModifierKeys are registered. For example, pressing RightAlt causes Control and Alt to be sent as arguments to the PreviewKeyDown event. Thus, RightAlt+E triggers a formatting command for paragraph alignment instead of inputting the ę character. In that case, you can handle the __PreviewEditorKeyDown__ event in the following way:

__Example 6: Customizing the behavior of a keyboard combination__

```C#

	  this.radRichTextBox.PreviewEditorKeyDown += (sender, args) =>
         {
             if (Keyboard.Modifiers.HasFlag(ModifierKeys.Alt) && Keyboard.Modifiers.HasFlag(ModifierKeys.Control) && args.Key == Key.E)
             {
                 args.SuppressDefaultAction = true;
                 args.OriginalArgs.Handled = true;
                 this.radRichTextBox.Insert("€");
             }
         };
```



## See Also 

 * [Commands]({%slug radrichtextbox-features-commands%})
 * [Clipboard Support]({%slug radrichtextbox-features-clipboard-support%})
 * [Formatting API]({%slug radrichtextbox-features-formatting-api%})
 * [Simulate Watermark SDK example](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/SimulateWatermark) 
