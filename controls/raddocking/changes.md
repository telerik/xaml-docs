---
title: Breaking Changes
page_title: Breaking Changes
description: Check our &quot;Breaking Changes&quot; documentation article for the RadDocking WPF control.
slug: raddocking-changes
tags: changes, breaking changes
published: True
position: 3
---

# Breaking Changes

This article describes the breaking changes history of the RadDocking control.

To see the fixes and features included in our latest official release please refer to our [Release History](http://www.telerik.com/support/whats-new/wpf/release-history).

* The `ElementSaving` and `ElementCleaning` events are omitted. Use the `ElementLayoutSaving` and `ElementLayoutCleaning` events instead.
* The `Telerik.Windows.Controls.PaneHeaderAutomationPeer` class is removed. Use the same class's name but from the `Telerik.Windows.Automation.Peers` namespace.
* The `PreviewResizeStart` event of the RadGridResizer class is omitted as it is not used internally.