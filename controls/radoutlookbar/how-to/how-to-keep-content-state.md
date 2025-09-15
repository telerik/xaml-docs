---
title: How to Keep the Content State
page_title: How to Keep the Content State
description: Check our &quot;How to Keep the Content State&quot; documentation article for the RadOutlookBar {{ site.framework_name }} control.
slug: radoutlookbar-how-to-keep-the-content-state
tags: how,to,keep,content,state,iscontentpreserved
published: True
position: 0
---

# How to Keep the Content State

To optimize the performance __RadOutlookBar__ uses a single ContentPresenter which holds only the Content of the currently selected __RadOutlookBarItem__. Each time the selection is changed the content of the last selected item is unloaded from the visual tree and the content of the newly selected item is loaded. Because of this the current state of the selected item's Content is lost. 

To preserve the state you can set the __IsContentPreserved__ property to __True__. 

__Example 1: Enable content preserving in XAML__
```XAML
	<telerik:RadOutlookBar IsContentPreserved="True" />
```

__Example 2: Enable content preserving in code__
```C#
	this.outlookBar.IsContentPreserved = true;
```


## See Also
 * [Getting Started]({%slug radoutlookbar-getting-started%})