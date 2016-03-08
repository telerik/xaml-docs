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

When the the filter popup on a column is opened and the user switches to another desktop app with the keyboard (for example, pressing ALt+Tab), not the mouse, then the _RadGridView_ filter popup remains open. <Comment: Did my addition create a technical error?>
        

__CAUSE__

The reason for this behavior is that the filtering popup is listening for the mouse click event and it will be closed when the user clicks outside of the popup. <Comment: Did my addition create a technical error?>
        

__SOLUTION 1 (Before Q1 2016)__

You will need to subscribe for the __Deactivated__ event of the MainWindow and ensure the filtering popup is closed.
        

For example, you can close the popup with the following code:
        

#### __C#__

{{region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_3}}

    var FilterDialogs = this.clubsGrid.ChildrenOfType<Popup>().Where(p => p.Name == "PART_DropDownPopup");
    if (FilterDialogs != null)
    foreach (Popup FilterDialog in FilterDialogs)
    {
        if (FilterDialog.IsOpen)
            FilterDialog.IsOpen = false;
    }
{{endregion}}

__SOLUTION 2 (After Q1 2016)__

As of Q1 2016, we have introduced the **ShouldCloseFilteringPopupOnKeyboardFocusChanged** property, which controls whether the filtering popup should close on keyboard focus change. Setting it to **True** will close the popup when a user switches to another application, no matter if they do that by using **Alt+Tab** or by clicking away with the mouse.

And here is how to set it:

#### __C#__

{{region gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button_4}}

    <telerik:RadGridView ShouldCloseFilteringPopupOnKeyboardFocusChanged="True" />
{{endregion}}

# See Also

 * [Close Filtering Popup on Pressing Filter Button]({%slug gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button%})
