---
title: Show HtmlPlaceholder ScrollBars
page_title: How to enable HtmlPlaceholder ScrollBars.
description: Check our &quot;How to enable HtmlPlaceholder ScrollBars&quot; documentation article for the RadHtmlPlaceholder {{ site.framework_name }} control.
slug: htmlplaceholder-howto-enable-scrollbars
tags: enable,scrollbars
published: True
position: 6
site_name: Silverlight
---

## How to Enable HtmlPlaceholder ScrollBars.

By default the RadHtmlPlaceholder control clips its content if there is not enough space to render it. The clipping occurs in cases when the size required to render accurately the content of the control is larger than the size of the control itself. 

To avoid this, you can do the following in the code-behind of your application:

#### __[C#]__
{{region cs-htmlplaceholder-howto-enable-scrollbars-0}}
	(myHtmlPlaceholder.HtmlPresenter.Children[0] as HtmlElement).SetStyleAttribute("overflow", "auto"); 
{{endregion}}
