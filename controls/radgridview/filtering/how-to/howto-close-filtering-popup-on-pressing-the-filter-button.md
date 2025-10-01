---
title: Close Filtering Popup on Pressing Filter Button
page_title: Close Filtering Popup on Pressing Filter Button
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to close filtering popup on pressing filter button.
slug: gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button
tags: close,filtering,popup,on,pressing,filter,button
published: True
position: 22
---

# Close Filtering Popup on Pressing Filter Button

In order to close filtering Popup on pressing the fitler button, you need to override the __OnApplyFilter__ method of FilteringControl.

>important A demo on how to achieve the desired behavior is available in our [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser/). The demo is labeled **"Close Filtering Popup"** and can also be found on GitHub - [CloseFilteringPopupFilterButton](https://github.com/telerik/xaml-sdk/tree/master/GridView/CloseFilteringPopupFilterButton).

__Example 1: Overriding OnApplyFilter method__
```C#
	public class MyFilteringControl : FilteringControl
	{
		public MyFilteringControl(Telerik.Windows.Controls.GridViewColumn column) : base(column)
		{         
	
		}        
	   
		protected override void OnApplyFilter()
		{
			base.OnApplyFilter();
	
			var popup = this.ParentOfType<Popup>();
			if (popup != null)
			{
				popup.IsOpen = false;
			}           
		}
	}
```
```VB.NET
	Public Class MyFilteringControl
		Inherits FilteringControl
		Public Sub New(column As Telerik.Windows.Controls.GridViewColumn)
	
			MyBase.New(column)
		End Sub
	
		Protected Overrides Sub OnApplyFilter()
			MyBase.OnApplyFilter()
	
			Dim popup = Me.ParentOfType(Of Popup)()
			If popup IsNot Nothing Then
				popup.IsOpen = False
			End If
		End Sub
	End Class
```

Then you can apply it to a desired column like so:

__Example 2: Apply the Custom Filter to the column__
```C#
	this.radGridView.Columns["Name"].FilteringControl = new MyFilteringControl(this.radGridView.Columns["Name"]);
```
```VB.NET
	Me.radGridView.Columns("Name").FilteringControl = New MyFilteringControl(Me.radGridView.Columns("Name"))
```

>In case you are using [NoXaml Binaries and Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should additionally apply a template. Please refer to the [Styling custom controls]({%slug implicit-styles-styling-the-controls%}#styling-custom-controls) section.
The Style you should apply in XAML then is:

__Example 3: Style targetting the custom control__

```XAML
	<Style TargetType="my:MyFilteringControl" BasedOn="{StaticResource FilteringControlStyle}"/>
```
