---
title: Caret
page_title: Caret
description: This article explains the caret functionality provided by the RadSyntaxEditor control.
slug: radsyntaxeditor-features-caret
tags: caret,radsyntaxeditor
position: 5
---

# Caret

The caret of the RadSyntaxEditor is the vertical 'blinking' line that represents the current cursor position of a control that accepts text input. The appearance of the caret can be controlled by the **CaretDisplayMode** property. Its possible values as well as the resulting appearance can be observed in the following list:

* **Normal**: ![RadSyntaxEditor caret normal display mode](images/syntaxeditor-caret-normal.png)

* **Block**: ![RadSyntaxEditor caret normal display mode](images/syntaxeditor-caret-block.png)

* **HalfBlock**: ![RadSyntaxEditor caret normal display mode](images/syntaxeditor-caret-half-block.png)

* **QuarterBlock**: ![RadSyntaxEditor caret normal display mode](images/syntaxeditor-caret-quarter-block.png)

#### __[XAML] Example 1: Setting the caret's display mode__
{{region xaml-radsyntaxeditor-features-caret-1}}
    
    <telerik:RadSyntaxEditor CaretDisplayMode="QuarterBlock" />
{{endregion}}

## Hide the Caret

If you wish to hide the caret, you can do so by setting the **IsCaretVisible** property to **False**. This setting can be used along with the **IsReadOnly** property which disallows users from making changes in the editor.

#### __[XAML] Example 2: Setting the caret's display mode__
{{region xaml-radsyntaxeditor-features-caret-2}}
    
    <telerik:RadSyntaxEditor IsReadOnly="True" IsCaretVisible="False" />
{{endregion}}

## Caret Brush

Through the **CaretBrush** property, you can change the caret's color to a color of your liking. The default value is **Black**.

#### __[XAML] Example 3: Setting the caret's color__
{{region xaml-radsyntaxeditor-features-caret-2}}

    <telerik:RadSyntaxEditor CaretBrush="Red" />
{{endregion}}

## Figure 1: RadSyntaxEditor caret with red color

![RadSyntaxEditor caret with red color](images/syntaxeditor-caret-red.png)

## See Also

* [IntelliSense]({%slug radsyntaxeditor-visual-structure%})