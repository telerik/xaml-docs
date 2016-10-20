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

#### __C#__

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

#### __VB.NET__

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

#### __C#__

{{region cs-gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_2}}
	this.radGridView.Columns["Name"].FilteringControl = new MyFilteringControl(this.radGridView.Columns["Name"]);
{{endregion}}


#### __VB.NET__

{{region vb-gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_4}}
	Me.radGridView.Columns("Name").FilteringControl = New MyFilteringControl(Me.radGridView.Columns("Name"))
{{endregion}}

>importantIn case you are using [NoXaml Binaries and Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should additionally apply a template. Please refer to the [Styling custom controls]({%slug styling-apperance-implicit-styles-overview%}#styling-custom-controls) section.
The Style you should apply in XAML then is:
#### __XAML__
	<Style TargetType="my:MyFilteringControl" BasedOn="{StaticResource FilteringControlStyle}"/>

