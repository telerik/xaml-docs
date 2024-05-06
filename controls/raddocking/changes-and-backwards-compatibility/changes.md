---
title: Changes
page_title: Changes
description: Check our &quot;Changes&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-changes
tags: changes
published: True
position: 0
---

# Changes

This article describes the release history of the control.

* The `ElementSaving` and `ElementCleaning` events are omitted. Use the `ElementLayoutSaving` and `ElementLayoutCleaning` events instead.
* The `Telerik.Windows.Controls.PaneHeaderAutomationPeer` class is removed. Use the same class's name but from the `Telerik.Windows.Automation.Peers` namespace.
* The `PreviewResizeStart` event of the RadGridResizer class is omitted as it is not used internally.