---
title: Keyboard Support
page_title: Keyboard Support
description: This article lists the key bindings provided by the RadSyntaxEditor control.
slug: radsyntaxeditor-keyboard-support
tags: keyboard,support,radsyntaxeditor
position: 7
---

# Keyboard Support

The keyboard combinations supported by the RadSyntaxEditor are listed in the table below.

|Hot Key(s)|Action|
|---|---|
|Left arrow|Move to previous character|
|Right arrow|Move to next character|
|Left arrow + Ctrl|Move to previous word|
|Right arrow + Ctrl|Move to next word|
|Up arrow|Move line up|
|Down arrow|Move line down|
|Home|Move to home|
|End|Move to line end|
|Page Up| Move page up|
|Page Down| Move page down|
|Ctrl + Home|Move to start of document|
|Ctrl + End|Move to end of document|
|Ctrl + A|Select all|
|Ctrl + C|Copy|
|Ctrl + Insert|Copy|
|Ctrl + Space|Show code completion prompt|
|Ctrl + F|Open the find dialog|
|Escape|Close the find dialog|
|Backspace|Delete the previous character|
|Delete|Delete the next character|
|Ctrl + Backspace|Delete the previous word|
|Ctrl + Delete|Delete the next word|
|Tab|Indent|
|Shift + Tab|Unindent|
|Ctrl + Z|Undo|
|Ctrl + Y|Redo|
|Ctrl + X|Cut|
|Shift + Delete|Cut|
|Ctrl + V|Paste|
|Shift + Insert|Paste|
|Insert|Toggle insert|

If you need to handle a key combination which is not listed above, you can do so by handling the **PreviewSyntaxEditorKeyDown** event.

__Example 1: Handling the Ctrl+S keyboard combination__
```C#
    private void SyntaxEditor_PreviewSyntaxEditorKeyDown(object sender, PreviewSyntaxEditorKeyEventArgs e)
    {
        if (e.Key == Key.S && KeyboardModifiers.IsControlDown)
        {
            e.OriginalArgs.Handled = true;
        }
    }
```

## See Also

* [Events]({%slug radsyntaxeditor-events%})
* [Commands]({%slug radsyntaxeditor-commands%})