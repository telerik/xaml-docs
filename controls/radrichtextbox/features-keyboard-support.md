---
title: Keyboard Support
page_title: Keyboard Support
description: Keyboard Support
slug: radrichtextbox-features-keyboard-support
tags: keyboard,support
published: True
position: 10
---

# Keyboard Support

{% if site.site_name == 'Silverlight' %}

Telerik __RichTextBox__ for Silverlight supports commands in a way that is similar to the commanding mechanism in WPF. It is only natural that some of these commands be triggered on key combinations. There are default key-bindings defined for the most widely used commands, namely:
{% endif %}{% if site.site_name == 'WPF' %}

Telerik __RichTextBox__ for WPF supports the commanding mechanism in WPF. There are default key-bindings defined for the most widely used commands, namely:
{% endif %}

## 
<table> <tr><th>

<b>Action</b></th><th>

<b>Hotkey</b></th></tr><tr><td>

Copy</td><td>

Ctrl+C</td></tr><tr><td>

Paste</td><td>

Ctrl+V</td></tr><tr><td>

Cut</td><td>

Ctrl+X</td></tr><tr><td>

Delete</td><td>

Delete</td></tr><tr><td>

Undo</td><td>

Ctrl+Z</td></tr><tr><td>

Redo</td><td>

Ctrl+Y</td></tr><tr><td>

InsertLineBreak</td><td>

Shift+Enter</td></tr><tr><td>

InsertPageBreak</td><td>

Ctrl+Enter</td></tr><tr><td>

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

ClearFormatting</td><td>

Ctrl+Space</td></tr><tr><td>

ChangeTextAlignment with parameter RadTextAlignment.Justify</td><td>

Ctrl+J</td></tr><tr><td>

ChangeTextAlignment with parameter RadTextAlignment.Right</td><td>

Ctrl+R</td></tr><tr><td>

ChangeTextAlignment with parameter RadTextAlignment.Left</td><td>

Ctrl+L</td></tr><tr><td>

ChangeTextAlignment with parameter RadTextAlignment.Center</td><td>

Ctrl+E</td></tr><tr><td>

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

MoveCaret with parameter MoveCaretDirections.DocumentStart</td><td>

Ctrl+Home</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.End</td><td>

End</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.DocumentEnd</td><td>

Ctrl+End</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.PageUp</td><td>

PageUp</td></tr><tr><td>

MoveCaret with parameter MoveCaretDirections.PageDown</td><td>

PageDown</td></tr><tr><td>

ShowFindReplaceDialog</td><td>

Ctrl+F</td></tr><tr><td>

ShowFontPropertiesDialog</td><td>

Ctrl+D</td></tr><tr><td>

ShowInsertHyperlinkDialog</td><td>

Ctrl+K</td></tr></table>

Now these key bindings can be overridden and customized to the liking of the user. What is more, new bindings can be added to both the Commands exposed through the RichTextBoxCommands class or to user-defined ones in a quite straight-forward way. This is how it can be done in XAML:
        
{% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region radrichtextbox-features-keyboard-support_0}}
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
{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __XAML__

{{region radrichtextbox-features-keyboard-support_1}}
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
{{endregion}}

{% endif %}

Please note that in the above code snippet the telerikDocs namespace is defined as follows: 
{{region richtextbox-commands}}
	xmlns:telerikDocs="clr-namespace:Telerik.Windows.Documents.RichTextBoxCommands;assembly=Telerik.Windows.Documents"
{{#endregion}}

Sometimes overriding the key bindings does not provide sufficient support, as depending on the language and the keyboard, different ModifierKeys are registered. For example, pressing RightAlt causes Control and Alt to be sent as arguments to the PreviewKeyDown event. Thus, RightAlt+E triggers a formatting command for paragraph alignment instead of inputting the ę character. In that case, you can handle the __PreviewEditorKeyDown__ event in the following way:

#### __C#__

{{region radrichtextbox-features-keyboard-support_0}}
	  this.radRichTextBox.PreviewEditorKeyDown += (sender, args) =>
         {
             if (Keyboard.Modifiers.HasFlag(ModifierKeys.Alt) && Keyboard.Modifiers.HasFlag(ModifierKeys.Control) && args.Key == Key.E)
             {
                 args.SuppressDefaultAction = true;
                 args.OriginalArgs.Handled = true;
                 this.radRichTextBox.Insert("€");
             }
         };
{{endregion}}



# See Also

 * [Clipboard Support]({%slug radrichtextbox-features-clipboard-support%})

 * [Formatting API]({%slug radrichtextbox-features-formatting-api%})
