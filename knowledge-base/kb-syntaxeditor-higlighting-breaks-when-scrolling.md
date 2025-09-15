---
title: Code Highlighting Breaks when Scrolling
page_title: Incorrect Portions are Highlighted when Scrolling
description: The code highlighting is incorrect when scrolling the RadSyntaxEditor control horizontally.
type: troubleshooting
slug: kb-syntaxeditor-higlighting-breaks-when-scrolling
position: 0
tags: radsyntaxeditor, highlighting, breaks, scrolling
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2021.1.223</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadSyntaxEditor for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

The code highlighting is incorrect when scrolling the RadSyntaxEditor control horizontally.

## Solution

If the width of a given line is longer than that of the viewport of the RadSyntaxEditor control, by default, only the portion of the line which is in the viewport will be processed by the [taggers]({%slug radsyntaxeditor-features-taggers%}) of the control.

This can lead to incorrect highlighting in some cases as can be observed on **Figure 1**. 

#### Figure 1: Incorrect XAML highlighting

![Incorrect highlighting](images/kb-syntaxeditor-higlighting-breaks-when-scrolling-1.png)

If you want to ensure that highlighting is correct in all scenarios, you need to set the **ShouldTaggersProcessEntireLines** property to **True**.

__Example 1: Make RadSyntaxEditor process the entire lines__
```C#
    <telerik:RadSyntaxEditor ShouldTaggersProcessEntireLines="True" />
```

#### Figure 2: Correct XAML highlighting

![Correct XAML highlighting](images/kb-syntaxeditor-higlighting-breaks-when-scrolling-2.png)

## See Also

* [Taggers]({%slug radsyntaxeditor-features-taggers%})
* [Custom Tagger]({%slug radsyntaxeditor-features-custom-tagger%})