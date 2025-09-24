---
title: Set Cursor to Arrow while Dragging
page_title: Set Cursor to Arrow while Dragging
description: Check our &quot;Set Cursor to Arrow while Dragging&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdropmanager-howto-set-cursor-to-arrow-while-dragging
tags: set,cursor,to,arrow,while,dragging
published: True
position: 1
---

# Set Cursor to Arrow while Dragging

The cursor displayed on dragging with DragDropManager is derived from the DragDropEffects set in DragInitialize event. However, you are free to override it and define it based on your specific requirements. For the purpose you may use the GiveFeedback event. 

An example for such an implementation is illustrated below:



```C#
	//Subscribing to the GiveFeedback event
	DragDropManager.AddGiveFeedbackHandler(SampleListBox, OnGiveFeedBack);
	//Handling the GiveFeedback event
	private void OnGiveFeedBack(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
	{
	      args.SetCursor(Cursors.Arrow);
	      args.Handled = true;
	}
```



```VB.NET
	DragDropManager.AddGiveFeedbackHandler(Me, New GiveFeedbackEventHandler(AddressOf OnGiveFeedBack))
	Private Sub OnGiveFeedBack(sender As Object, e As Telerik.Windows.DragDrop.GiveFeedbackEventArgs) 
	   args.SetCursor(Cursors.Arrow)
	   args.Handled = True
	End Sub
```