---
title: Set Cursor to Arrow while Dragging
page_title: Set Cursor to Arrow while Dragging
description: Set Cursor to Arrow while Dragging
slug: dragdropmanager-howto-set-cursor-to-arrow-while-dragging
tags: set,cursor,to,arrow,while,dragging
publish: True
position: 1
---

# Set Cursor to Arrow while Dragging



## 

The cursor displayed on dragging with DragDropManager is derived from the DragDropEffects set in DragInitialize event. However, you are free to override it and define it based on your specific requirements. For the purpose you may use the GiveFeedback event. 

An example for such an implementation is illustrated below:

#### __C#__

{{region dragdropmanager-howto-set-cursor-to-arrow-while-dragging_0}}
	//Subscribing to the GiveFeedback event
	DragDropManager.AddGiveFeedbackHandler(SampleListBox, OnGiveFeedBack);
	//Handling the GiveFeedback event
	private void OnGiveFeedBack(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
	{
	      args.SetCursor(Cursors.Arrow);
	      args.Handled = true;
	}
	{{endregion}}



#### __VB.NET__

{{region dragdropmanager-howto-set-cursor-to-arrow-while-dragging_1}}
	DragDropManager.AddGiveFeedbackHandler(Me, New GiveFeedbackEventHandler(AddressOf OnGiveFeedBack))
	Private Sub OnGiveFeedBack(sender As Object, e As Telerik.Windows.DragDrop.GiveFeedbackEventArgs) 
	   args.SetCursor(Cursors.Arrow)
	   args.Handled = True
	End Sub
	{{endregion}}




