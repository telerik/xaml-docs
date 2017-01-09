---
title: Filtering Popup Remains Opened
page_title: Filtering Popup Remains Opened
description: Filtering Popup Remains Opened
slug: gridview-filtering-faq-popup-stays
tags: filtering,popup,remains,opened
published: True
position: 5
---

# Filtering Popup Remains Opened

__PROBLEM__

When the the filter popup on a column is opened and the user switches to another desktop app with the keyboard (for example, pressing **Alt+Tab**), not the mouse, then the __RadGridView__ filter popup remains open.
        

__CAUSE__

The reason for this behavior is that the filtering popup is listening for the mouse click event and it will be closed when the user clicks outside of the popup.
        

__SOLUTION 1 (Before Q1 2016)__

You will need to subscribe for the __Deactivated__ event of the MainWindow and ensure the filtering popup is closed.
        

For example, you can close the popup with the following code:
        

#### __[C#] Example 1: Closing the Filtering Popup from the Deactivated event__

{{region cs-gridview-filtering-faq-popup-stays_0}}
	var FilterDialogs = this.radGridView.ChildrenOfType<Popup>().Where(p => p.Name == "PART_DropDownPopup");
	if (FilterDialogs != null)
	{
	    foreach (Popup FilterDialog in FilterDialogs)
	    {
	        if (FilterDialog.IsOpen)
	            FilterDialog.IsOpen = false;
	    }
	}
{{endregion}}

#### __[VB.NET] Example 1: Closing the Filtering Popup from the Deactivated event__

{{region vb-gridview-filtering-faq-popup-stays_1}}
	Dim FilterDialogs = Me.radGridView.ChildrenOfType(Of Popup)().Where(Function(p) p.Name = "PART_DropDownPopup")
	If FilterDialogs IsNot Nothing Then
	    For Each FilterDialog As Popup In FilterDialogs
	        If FilterDialog.IsOpen Then
	            FilterDialog.IsOpen = False
	        End If
	    Next
	End If
{{endregion}}

__SOLUTION 2 (After Q1 2016)__

As of Q1 2016, we have introduced the **ShouldCloseFilteringPopupOnKeyboardFocusChanged** property, which controls whether the filtering popup should close on keyboard focus change. Setting it to **True** will close the popup when a user switches to another application, no matter if they do that by using **Alt+Tab** or by clicking away with the mouse.

And here is how to set it:

#### __[XAML] Example 2: Closing the Filtering Popup in XAML__

{{region xaml-gridview-filtering-faq-popup-stays_2}}
	<telerik:RadGridView ShouldCloseFilteringPopupOnKeyboardFocusChanged="True" />
{{endregion}}

# See Also

 * [Close Filtering Popup on Pressing Filter Button]({%slug gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button%})
