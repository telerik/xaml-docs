---
title: Page Flip Mode
page_title: Page Flip Mode
description: Check our &quot;Page Flip Mode&quot; documentation article for the RadBook {{ site.framework_name }} control.
slug: radbook-page-flip-mode
tags: page,flip,mode
published: True
position: 0
---

# Page Flip Mode

By default users are able turn to a page by clicking *once* on any of the page corners. To control this behaviour you can use the __PageFlipMode__ property. It is an enumeration that contains the following values:

* __None__ - this will disable the flip mode by user click

* __SingleClick__ - this is the default value. The page flip will happen on single click

* __DoubleClick__ - the page flip will happen on double click.

__Example 1: Setting the PageFlipMode property__  
```XAML
	<telerik:RadBook Margin="50" x:Name="RadBook1" PageFlipMode="DoubleClick" />
```

## See Also
 * [Events]({%slug radbook-events%})
 * [Navigating]({%slug radbook-navigating%})