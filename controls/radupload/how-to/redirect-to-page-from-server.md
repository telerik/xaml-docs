---
title: Redirect To a Page From the Server Side
page_title: Redirect To a Page From the Server Side
description: Redirect To a Page From the Server Side
slug: radupload-how-to-redirect-to-page-from-server
tags: redirect,to,a,page,from,the,server,side
published: True
position: 10
---

# Redirect To a Page From the Server Side



## 

You can customize the __RadUploadHandler__ to redirect the client to a certain page as soon as the upload is finished, by adding a __RedirectPage__ __RadUploadConstants__.

In order to implement this scenario, you will need to override the __GetAssociatedData__ method:

#### __C#__

{{region radupload-how-to-redirect-to-page-from-server_0}}
	public override Dictionary<string, object> GetAssociatedData()
	{
	 Dictionary<string, object> associatedData = base.GetAssociatedData();
	 if (this.IsFinalFileRequest())
	 {
	  associatedData.Add(RadUploadConstants.RedirectPage, "http://www.google.com");
	 }
	  return associatedData;
	}
	{{endregion}}



#### __VB.NET__

{{region radupload-how-to-redirect-to-page-from-server_1}}
	Public Overrides Function GetAssociatedData() As Dictionary(Of String, Object)
	 Dim associatedData As Dictionary(Of String, Object) = MyBase.GetAssociatedData()
	 If Me.IsFinalFileRequest() Then
	  associatedData.Add(RadUploadConstants.RedirectPage, "http://www.google.com")
	 End If
	 Return associatedData
	End Function
	{{endregion}}




