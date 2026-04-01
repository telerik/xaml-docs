---
title: Adjusting InlineUIContainer Vertical Position in RadRichTextBox
description: Learn how to adjust the vertical position and font size of InlineUIContainer in RichTextBox.
type: how-to
page_title: Vertical Positioning of InlineUIContainer in RadRichTextBox
meta_title: BaselineOffset Adjustment of InlineUIContainer in RadRichTextBox
slug: kb-richtextbox-vertical-position-inlineuicontainer
tags: radrichtextbox, wpf, radrichtextbox, inlineuicontainer, positioning, font-size, dropdownbutton
res_type: kb
ticketid: 1712184
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RichTextBox for UI for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>Current</td>
</tr>
</tbody>
</table>

## Description

How to adjust the BaselineOffset of an InlineUIContainer in RadRichTextBox for WPF, in order to vertically offset the UI element from its original position.

## Solution

The baseline offset is originally determined by the `Height` setting of the [InlineUIContainer]({%slug radrichtextbox-features-document-elements-inlineuicontainer%}). This basically determines the top position of the element, relative to the bottom of the sibling document element (for example, a text span). 

To manually control the baseline offset, create a custom `CustomUIElementLayoutBox` and override its `BaselineOffset` property.

```C#
public class CustomUIElementLayoutBox : UIElementLayoutBox
{
    private float? customBaselineOffset = null;

    public CustomUIElementLayoutBox(DocumentElement parentElement, DocumentStructureCollection collection) 
        : base(parentElement, collection)
    {
    }

    public float? CustomBaselineOffset { get => customBaselineOffset; set => customBaselineOffset = value; }

    public override float BaselineOffset
    {
        get => CustomBaselineOffset.HasValue ? CustomBaselineOffset.Value : (float)this.AssociatedUIElementInline.Height;
    }        
}
```

To use the custom layout box, create a custom `InlineUIContainer` and override its `CreateLayoutBox` method.

```C#
public class CustomInlineUIContainer : InlineUIContainer
{
    public override LayoutBox CreateLayoutBox(DocumentStructureCollection documentCollection)
    {
        return new CustomUIElementLayoutBox(this, documentCollection);
    }

    protected override DocumentElement CreateNewElementInstance()
    {
        return new CustomInlineUIContainer();
    }


    protected override void CopyPropertiesFromOverride(DocumentElement fromElement)
    {
        base.CopyPropertiesFromOverride(fromElement);
        if (fromElement.FirstLayoutBox is CustomUIElementLayoutBox fromBox && this.FirstLayoutBox is CustomUIElementLayoutBox toBox)
        {
            toBox.CustomBaselineOffset = fromBox.CustomBaselineOffset;
        }
    }
}
```

Then, use the custom baseline offset property to adjust the vertical position.

```C#
var container = new CustomInlineUIContainer();
var layoutBox = (CustomUIElementLayoutBox)container.FirstLayoutBox;
var offset = 10;
layoutBox.CustomBaselineOffset = (float)(textBox.DesiredSize.Height - offset);
// other settings here

this.richTextBox.InsertInline(container);
```
