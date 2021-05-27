---
title: Show HtmlPlaceholder ScrollBars
description: How to enable HtmlPlaceholder ScrollBars.
type: how-to
page_title: Enable HtmlPlaceholder ScrollBars
slug: kb-htmlplaceholder-howto-enable-scrollbars
position: 0
tags: htmlplaceholder, scrollbars, item
ticketid:
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadHtmlPlaceholder for Silverlight</td>
	</tr>
</table>


## Description

By default the RadHtmlPlaceholder control clips its content if there is not enough space to render it. The clipping occurs in cases when the size required to render accurately the content of the control is larger than the size of the control itself. 

## Solution

To avoid this, you can do the following in the code-behind of your application:

#### __[C#]__
{{region cs-kb-htmlplaceholder-howto-enable-scrollbars-0}}
	(myHtmlPlaceholder.HtmlPresenter.Children[0] as HtmlElement).SetStyleAttribute("overflow", "auto"); 
{{endregion}}
