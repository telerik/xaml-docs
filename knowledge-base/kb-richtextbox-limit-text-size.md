---
title: RichTextBox limit input to view area
description: Describes how you can ensure that the content of the control doesn't exceed the applied size.
type: how-to
page_title: Limit content length of RadRichTextBox
slug: kb-richtextbox-limit-text-size
tags: limit,text,size,input,no scroll
ticketid: 1427848
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.2 902</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadRichTextBox for WPF</td>
		</tr>
	</tbody>
</table>


## Description
In this article, you will find how to restrict the input size of RadRichTextBox so you can ensure that the content doesn't exceed the visible size of the control. With this approach, scrollbars won't be available. 

## Solution
The described behavior can be achieved using the layout boxes generated to show the content. To obtain the last layout box inside the document after editing the content, you would need to subscribe to the **DocumentContentChanged** event of RadRichTextBox. Once you have found the last layout box, you can compare its Bottom position with the size of the control to find whether the content exceeds the allowed size. If so, invoke the **Undo()** method to cancel the last change. Here is an example in code:


```C#

    private void RadRichTextBox_DocumentContentChanged(object sender, EventArgs e)
    {
        Paragraph lastParagraph = this.radRichTextBox.Document.EnumerateChildrenOfType<Paragraph>().Last();
        bool isContentLonger = lastParagraph.LastLayoutBox.BoundingRectangle.Bottom > this.radRichTextBox.RenderSize.Height;
        if (isContentLonger)
        {
            this.radRichTextBox.Undo();
        }
    }
```