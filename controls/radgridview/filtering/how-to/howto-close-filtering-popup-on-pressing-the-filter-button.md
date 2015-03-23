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

In order to close filtering Popup on pressing the fitler button, you need to override the __OnApplyFilter__ method of our FilteringControl.

#### __C#__

{{region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_1}}

    class MyFilteringControl : FilteringControl
    {
        public MyFilteringControl(Telerik.Windows.Controls.GridViewColumn column) : base(column)
        {       
			// Apply the line below only when using NoXaml binaries 
        	// this.DefaultStyleKey=typeof(MyFilteringControl);
        }        
       
        protected override void OnApplyFilter()
        {
            base.OnApplyFilter();

            var popup = this.ParentOfType<System.Windows.Controls.Primitives.Popup>();
            if (popup != null)
            {
                popup.IsOpen = false;
            }           
        }
    }
{{endregion}}



#### __VB.NET__

{{region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_3}}

    Class MyFilteringControl
        Inherits FilteringControl
        Public Sub New(column As Telerik.Windows.Controls.GridViewColumn)
            MyBase.New(column)
			' Apply the line below only when using NoXaml binaries 
			' this.DefaultStyleKey=typeof(MyFilteringControl);
        End Sub

        Protected Overrides Sub OnApplyFilter()
            MyBase.OnApplyFilter()

            Dim popup = Me.ParentOfType(Of System.Windows.Controls.Primitives.Popup)()
            If popup IsNot Nothing Then
                popup.IsOpen = False
            End If
        End Sub
    End Class
{{endregion}}


Then you can apply it to a desired column like so:

#### __C#__

{{region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_2}}

	this.clubsGrid.Columns["Name"].FilteringControl = new MyFilteringControl(this.clubsGrid.Columns["Name"]);
{{endregion}}


#### __VB.NET__

{{region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_4}}

	Me.clubsGrid.Columns("Name").FilteringControl = New MyFilteringControl(Me.clubsGrid.Columns("Name"))s
{{endregion}}


! In case you are using [NoXaml Binaries and Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should __additionally apply a template_. Please refer to the [Styling custom controls]({%slug styling-apperance-implicit-styles-overview%}#styling-custom-controls) section.

The Style you should apply in XAML is:
#### __XAML__
	<Style TargetType="my:MyFilteringControl" BasedOn="{StaticResource FilteringControlStyle}"/>

