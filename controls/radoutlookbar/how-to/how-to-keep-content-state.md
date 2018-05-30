---
title: How to Keep the Content State
page_title: How to Keep the Content State
description: How to Keep the Content State
slug: radoutlookbar-how-to-keep-the-content-state
tags: how,to,keep,content,state,iscontentpreserved
published: True
position: 0
---

# How to Keep the Content State

To optimize the performance __RadOutlookBar__ uses a single ContentPresenter which holds only the Content of the currently selected __RadOutlookBarItem__. Each time the selection is changed the content of the last selected item is unloaded from the visual tree and the content of the newly selected item is loaded. Because of this the current state of the selected item's Content is lost. 

To preserve the state you can set the __IsContentPreserved__ property to __True__. 

#### __[XAML] Example 1: Enable content preserving in XAML__
{{region radoutlookbar-how-to-keep-content-0}}
	<telerik:RadOutlookBar IsContentPreserved="True" />
{{endregion}}

#### __[C#] Example 2: Enable content preserving in code__
{{region radoutlookbar-how-to-keep-content-1}}
	this.outlookBar.IsContentPreserved = true;
{{endregion}}


## See Also
 * [Getting Started]({%slug radoutlookbar-getting-started%})