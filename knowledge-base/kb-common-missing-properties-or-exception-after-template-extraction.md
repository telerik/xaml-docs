---
title: Missing Properties or Exception After Automatic Template Extraction
description: Item Controls are Missing or Error is Thrown When Extracted Style is Used.
type: troubleshooting
page_title: No Controls When Custom Template is Applied
slug: kb-common-missing-properties-or-exception-after-template-extraction
position: 0
tags: radtimeline, radtimebar, radgridview
ticketid: 1409293
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2018.3.1016</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadGridView for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

Missing elements in the UI after a custom template is applied to a Telerik control. Or an error appears after the custom template is applied. 

Those issues are observed in some cases when extracting the Style of a Telerik control using Microsoft Blend or the Visual Studio's designer.

## Solution

To resolve this, instead of extracting the Style (or the template) using Microsoft Blend or the Visual Studio's designer, __use the .xaml files__ from the *UI for WPF installation folder*. This is the __Themes.Implicit__ folder. It contains all the Styles of the Telerik controls. Read more about this in the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) article.
