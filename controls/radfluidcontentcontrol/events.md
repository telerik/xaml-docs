---
title: Events
page_title: Events
description: RadFluidContentControl exposes an additional StateChanged event that allows you to listen for changes in the current state of the control.
slug: fluidcontentcontrol-events
tags: events
published: True
position: 3
---

# Events

Except the inherited events, RadFluidContentControl exposes an additional event that allows you to listen for changes in the current state of the control. The event is called __StateChanged__ and it fires when the State property changes. The event arguments are of type __FluidContentControlStateChangedEventArgs__ and provide information for the newly applied state and the old one via the __OldState__ and __NewState__ properties.

## See Also
* [Getting Started]({%slug fluidcontentcontrol-getting-started%})
* [Data Binding]({%slug fluidcontentcontrol-data-binding%})
* [Transitions]({%slug fluidcontentcontrol-transitions%})