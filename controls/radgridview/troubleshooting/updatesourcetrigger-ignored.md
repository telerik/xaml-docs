---
title: The UpdateSourceTrigger property is ignored
page_title: The UpdateSourceTrigger property is ignored
description: The UpdateSourceTrigger property is ignored
slug: gridview-troubleshooting-updatesourcetrigger-ignored
tags: the,updatesourcetrigger,property,is,ignored
published: True
position: 17
---

# The UpdateSourceTrigger property is ignored

__PROBLEM__

The __UpdateSourceTrigger__ property of the column's DataMemberBinding is ignored.
        
__CAUSE__

The reason for this behaviour is that the RadGridView overrides and changes the __"Binding.UpdateSourceTrigger"__ property to be __"Explicit"__. It is designed like so because the editing and validation mechanism of RadGridView explicitly updates and validates values when the edit is over. Otherwise validation and commit would happen on every key stroke.
        
__SOLUTION__

You could overcome that with a few lines of code using __GridViewColumn.CellEditTemplate__ property and setting binding for the element in Edit mode (for example the editing element for GridViewDataColumn is TextBox).
        
# See Also

 * [Setting CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})

 * [Create Custom DateTimePicker Column]({%slug gridview-how-to-create-date-time-picker-column%})
