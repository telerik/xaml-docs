---
title: Redirect To a Page From the Server Side
page_title: Redirect To a Page From the Server Side
description: Check our &quot;Redirect To a Page From the Server Side&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-how-to-redirect-to-page-from-server
tags: redirect,to,a,page,from,the,server,side
published: True
position: 10
---

# {{ site.framework_name }} RadUpload Redirect To a Page From the Server Side

You can customize the __RadUploadHandler__ to redirect the client to a certain page as soon as the upload is finished, by adding a __RedirectPage__ __RadUploadConstants__.

In order to implement this scenario, you will need to override the __GetAssociatedData__ method:

#### __[C#] Example 1: Redirecting the client__  
{{region cs-radupload-how-to-redirect-to-page-from-server_0}}
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

#### __[VB.NET] Example 1: Redirecting the client__  

{{region vb-radupload-how-to-redirect-to-page-from-server_1}}
	Public Overrides Function GetAssociatedData() As Dictionary(Of String, Object)
	 Dim associatedData As Dictionary(Of String, Object) = MyBase.GetAssociatedData()
	 If Me.IsFinalFileRequest() Then
	  associatedData.Add(RadUploadConstants.RedirectPage, "http://www.google.com")
	 End If
	 Return associatedData
	End Function
{{endregion}}
