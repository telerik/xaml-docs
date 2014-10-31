---
title: Events Overview
page_title: Events Overview
description: Events Overview
slug: radcoloreditor-events-overview
tags: events,overview
published: True
position: 0
---

# Events Overview



This topic covers the specific events exposed by the __RadColorEditor__ control. 

## 

* __SelectedColorChanging__ - raised while the __SelectedColor__ property is changing its value. The __SelectedColorChanging__ event handler receives two arguments:
						

* The sender argument contains the __RadColorEditor__. This argument is of type __object__, but can be cast to the __RadColorEditor__ type.
						

* A __ColorChangeEventArgs__ object. You can use it to find the color that is getting selected through the __Color__ property. Or you can use it to handle the event by setting the __Handled__ property to __True__ thus canceling the selection.
						

* __SelectedColorChanged__ - occurs when the selected color is changed. The __SelectedColorChanged__ event handler receives two arguments:
						

* The sender argument contains the __RadColorEditor__. This argument is of type __object__, but can be cast to the __RadColorEditor__ type.
							

* A __ColorChangeEventArgs__ object. You can use it to find the selected color through the __Color__ property. 
							

* __PreviousColorChanged__ - occurs after the __PreviousColor__ property has changed its value. The __PreviousColorChanged__ event handler receives two arguments:
						

* The sender argument contains the __RadColorEditor__. This argument is of type __object__, but can be cast to the __RadColorEditor__ type.
							

* A __ColorChangeEventArgs__ object. 
							

* __HistoryChanged__ - occurs after a color has been added or removed from the __ColorHistory__ collection. The __HistoryChanged__ event handler receives two arguments:
						

* The sender argument contains the __RadColorEditor__. This argument is of type __object__, but can be cast to the __RadColorEditor__ type.
							

* A __HistoryChangedEventArgs__ object. You can use it to access the selected colors added to the __ColorHistory__ collection through the __AddedItems__ collection. The __HistoryChangedEventArgs__ object also exposes a collection of the colors removed from the __ColorHistory__ - __RemovedItems__.
							

# See Also

 * [Structure]({%slug radcoloreditor-structure%})

 * [Getting Started]({%slug radcoloreditor-getting-started%})

 * [Color Mode]({%slug radcoloreditor-features-color-mode%})

 * [Color History]({%slug radcoloreditor-features-color-history%})

 * [Unified Color]({%slug radcoloreditor-features-unified-color%})
