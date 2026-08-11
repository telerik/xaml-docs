---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadBook {{ site.framework_name }} control.
slug: radbook-events
tags: events
published: True
position: 2
---

# Events

__RadBook__ exposes the following events:

* __FoldActivated__ - raised when the user hovers the fold with the mouse.

* __FoldDeactivated__ - raised when the fold is not active - e.g. the user is not over it.

* __PageChanged__ - raised when the page set is changed.

* __PageFlipStarted__ - raised when user starts to flip a page.

* __PreviewPageFlipStarted__ - raised when user starts to flip a page. Allows the developer to cancel the page flip.

* __PageFlipEnded__ - raised when the flip is finished. This happen when the page is changed, or user canceled the flip.

Please find below and example of how to use those events:

__Example 1: Subscribing to the RadBook events__  
<snippet id='radbook-features-events-block_1-xaml' />

__Example 2: Adding event handlers__  
<snippet id='radbook-features-events-block_2-cs' />
<snippet id='radbook-features-events-block_2-vb' />

