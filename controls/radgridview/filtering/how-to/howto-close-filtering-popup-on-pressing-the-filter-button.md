---
title: Close Filtering Popup on Pressing Filter Button
page_title: Close Filtering Popup on Pressing Filter Button
description: Close Filtering Popup on Pressing Filter Button
slug: gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button
tags: close,filtering,popup,on,pressing,filter,button
published: True
position: 22
---

# Close Filtering Popup on Pressing Filter Button

In order to close filtering Popup on pressing the fitler button, you need to override the __OnApplyFilter__ method of FilteringControl.

>important A demo on how to achieve the desired behavior is available in our [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser/). The demo is labeled **"Close Filtering Popup"** and can also be found on GitHub - [CloseFilteringPopupFilterButton](https://github.com/telerik/xaml-sdk/tree/master/GridView/CloseFilteringPopupFilterButton).

#### __[C#] Example 1: Overriding OnApplyFilter method__
{{region cs-gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_1}}
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
{{endregion}}

#### __[VB.NET] Example 1: Overriding OnApplyFilter method__
{{region vb-gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_3}}
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
{{endregion}}

Then you can apply it to a desired column like so:

#### __[C#] Example 2: Apply the Custom Filter to the column__
{{region cs-gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_2}}
	this.radGridView.Columns["Name"].FilteringControl = new MyFilteringControl(this.radGridView.Columns["Name"]);
{{endregion}}

#### __[VB.NET] Example 2: Apply the Custom Filter to the column__
{{region vb-gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_4}}
	Me.radGridView.Columns("Name").FilteringControl = New MyFilteringControl(Me.radGridView.Columns("Name"))
{{endregion}}

>important In case you are using [NoXaml Binaries and Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should additionally apply a template. Please refer to the [Styling custom controls]({%slug styling-apperance-implicit-styles-overview%}#styling-custom-controls) section.
The Style you should apply in XAML then is:
#### __[XAML] Example 3: Style targetting the custom control__
{{region xaml-gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_5}}
	<Style TargetType="my:MyFilteringControl" BasedOn="{StaticResource FilteringControlStyle}"/>
{{endregion}}
