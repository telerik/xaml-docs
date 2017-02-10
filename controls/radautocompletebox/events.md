---
title: Events
page_title: Events
description: Events
slug: radautocompletebox-events
tags: events
published: True
position: 100
---

# Events

The __RadAutoCompleteBox__ exposes almost all of the **TextBox** events. Additionally, it provides the following events:

* __SelectionChanged__: Occurs when an item of the RadAutoCompleteBox is selected. The type of the passed arguments is __SelectionChangedEventArgs__. You can use the readonly **AddedItems** and **RemovedItems** properties to see what item(s) were selected or deselected.

* __SearchTextChanged__: Occurs when the text in the text box portion of the RadAutoCompleteBox changes. This event should be used instead of the **TextChanged** event. The type of the passed arguments is __EventArgs__.

* __Populating__: Occurs when RadAutoCompleteBox starts populating its popup with items. The type of the passed arguments is **CancelRoutedEventArgs** meaning that you can cancel the event based on your custom logic by setting the Cancel property of the arguments to **True**.

* __Populated__: Occurs after RadAutoCompleteBox populates its popup with items. The type of the passed arguments is __EventArgs__.