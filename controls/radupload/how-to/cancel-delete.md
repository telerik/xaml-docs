---
title: Cancel RadUploadItem Deletion
page_title: Cancel RadUploadItem Deletion
description: Cancel RadUploadItem Deletion
slug: radupload-how-to-cancel-delete
tags: cancel,raduploaditem,deletion
published: True
position: 9
---

# Cancel RadUploadItem Deletion

The __RadUpload__ allows you to cancel the deletion of a __RadUploadItem__.	  

In order to take advantage of this feature you will need to handle the __RadUploadItem__ __PreviewDelete event__.

## Add handler for the RadUploadItem PreviewDelete

#### __[C#] Example 1: Subscribing to the PreviewDelete event__  
{{region cs-radupload-how-to-cancel-delete_0}}
	radUpload.AddHandler(RadUploadItem.PreviewDeleteEvent, new DeleteEventHandler(PreviewDelete));
{{endregion}}

#### __[VB.NET] Example 1: Subscribing to the PreviewDelete event__  
{{region vb-radupload-how-to-cancel-delete_1}}
	radUpload.AddHandler(RadUploadItem.PreviewDeleteEvent, New DeleteEventHandler(AddressOf PreviewDelete))
{{endregion}}

>tip In order to use the __Telerik AddHandler__ overload to attach an event handler for the __RadUploadItem.Delete__ and __RadUploadItem.PreviewDelete__ events, you need to add the following __using__ statement in your file: `using Telerik.Windows;`			

## Handle the PreviewDelete event

#### __[C#] Example 2: Handling the PreviewDelete event__  
{{region cs-radupload-how-to-cancel-delete_2}}
	void PreviewDelete(object sender, DeleteEventArgs e)
	{
	 e.Handled = true;
	}
{{endregion}}

#### __[VB.NET] Example 2: Handling the PreviewDelete event__  
{{region vb-radupload-how-to-cancel-delete_3}}
	Private Sub PreviewDelete(ByVal sender As Object, ByVal e As DeleteEventArgs)
	 e.Handled = True
	End Sub
{{endregion}}
