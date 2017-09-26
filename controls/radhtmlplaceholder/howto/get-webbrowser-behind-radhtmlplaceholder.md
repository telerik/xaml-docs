---
title: Get the WebBrowser behind the RadHtmlPlaceholder control
page_title: Get the WebBrowser behind the RadHtmlPlaceholder control
description: Get the WebBrowser behind the RadHtmlPlaceholder control
slug: radhtmlplaceholder-howto-get-webbrowser
tags: get,radhtmlplaceholder,behind,webbrowser,browser,web
published: True
position: 3
---

# Get the WebBrowser behind the RadHtmlPlaceholder control in an out-of-browser scenario

__RadHtmlPlaceholder__ uses [WebBrowser](http://msdn.microsoft.com/en-us/library/system.windows.controls.webbrowser(v=vs.95).aspx) control internally to render its content. You can get the browser which is used in out-of-browser scenarios through the __WebBrowser__ property of the placeholder component.

#### __XAML__
	<telerik:RadHtmlPlaceholder x:Name=”placeholder” Source=”http://www.bing.com/” />
	
#### __C#__
	WebBrowser browser = this.placeholder.WebBrowser;
	
#### __VB.NET__
	Dim browser As WebBrowser = Me.placeholder.WebBrowser

## See Also
 * [Getting Started]({%slug radhtmlplaceholder-getting-started%})
 * [Display HTML string in RadHtmlPlaceholder]({%slug radhtmlplaceholder-howto-displayhtml%})
 * [Display external page in RadHtmlPlaceholder]({%slug radhtmlplaceholder-howto-displayexternalpage%})