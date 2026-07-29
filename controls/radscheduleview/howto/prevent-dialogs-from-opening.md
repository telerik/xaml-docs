---
title: Prevent Dialogs from Opening
page_title: Prevent Dialogs from Opening
description: Check our &quot;Prevent Dialogs from Opening&quot; documentation article for the RadScheduleView {{ site.framework_name }} control.
slug: radscheduleview-howto-prevent-dialogs-from-opening
tags: prevent,dialogs,from,opening
published: True
position: 0
---

# Prevent Dialogs from Opening

## How to hide a RadScheduleView dialog

In order to prevent a specific dialog from appearing , the ShowDialog event of the __RadScheduleView__ should be cancelled. The event args contain a property called __DialogViewModel__ which can be used to determine which dialog is going to be opened.

For example the view model for the __EditAppointmentDialog__ is __AppointmentDialogViewModel__. The following code snippet shows how it can be cancelled:

<snippet id='radscheduleview-howto-prevent-dialogs-from-opening-block_1-xaml' />

<snippet id='radscheduleview-howto-prevent-dialogs-from-opening-block_2-cs' />
<snippet id='radscheduleview-howto-prevent-dialogs-from-opening-block_3-vb' />

>To learn more about __RadScheduleView__ events, check [here]({%slug radscheduleview-events-overview%}).

## How to skip ConfirmDeleteDialog

In this case __DefaultDialogResult__ property of the event args should be set in order to stimulate pressing OK/Cancel in the dialog. If __DefaultDialogResult__ is set to “true”, the appointment will be directly deleted:



<snippet id='radscheduleview-howto-prevent-dialogs-from-opening-block_4-cs' />
<snippet id='radscheduleview-howto-prevent-dialogs-from-opening-block_5-vb' />

## How to preselect  a certain option in RecurrenceChoiceDialog

By default  “Open/Delete the occurrence” option is selected in RecurrenceChoiceDialog.  This can be changed in ShowDialog event by setting __IsSeriesModeSelected__ property of the RecurrenceChoiceDialogViewModel:



<snippet id='radscheduleview-howto-prevent-dialogs-from-opening-block_6-cs' />
<snippet id='radscheduleview-howto-prevent-dialogs-from-opening-block_7-vb' />

>tip Check [here]({%slug radscheduleview-features-custom-dialogs%}) for more information about RadScheduleView dialogs.