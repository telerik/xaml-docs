---
title: How to implement a MaxLength on RichTextBox
description: Learn how to limit the number of characters in a document.
type: how-to
page_title: Restrict number of characters in RadRichTextBox
slug: kb-richtextbox-maxlength
position: 0
tags: limit, restrict, count, characters, length, input
ticketid: 1536052
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2021.3.914</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadRichTextBox for WPF</td>
		</tr>
	</tbody>
</table>


## Description

In this article, you will find how to restrict the input size of RadRichTextBox so you can ensure that the content doesn't exceed a specific number of characters. 

## Solution

The described behavior can be achieved using the [DocumentStatisticsInfo](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.documentstatisticsinfo) class. To obtain the current number of characters after modification, you would need to subscribe to the **DocumentContentChanged** event of RadRichTextBox. Once you get the current amount of characters in the document, you can compare it with the limit to find whether the content exceeds the allowed characters count. If so, invoke the **Undo()** method to cancel the last change. 


```C#
    
    private void RadRichTextBox_DocumentContentChanged(object sender, EventArgs e)
    {
        int charsCount = this.radRichTextBox.Document.GetStatisticsInfo().CharactersCount;
        if (charsCount > 30)
        {
            this.radRichTextBox.Undo();
        }
    }
```

## See Also

* [Limit input to view area of RadRichTextBox]({%slug kb-richtextbox-limit-text-size%})
* [DocumentStatisticsInfo API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.documentstatisticsinfo)
