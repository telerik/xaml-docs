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

When the the filter Popup on a column is opened and the user switches to another desktop app with the keyboard (for example using ALt and Tab combination), not the mouse, then the filter popup remains open.
        

__CAUSE__

The reason for this behavior is that the filtering Popup is listening for the mouse click event and it will be closed when the user clicks outside of it.
        

__SOLUTION__

You will need to subscribe for the __Deactivated__ event of the MainWindow and ensure the filtering Popup is closed.
        

For example you can close it with the following code:
        

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

# See Also

 * [Close Filtering Popup on Pressing Filter Button]({%slug gridview-filtering-howto-close-filtering-popup-on-pressing-the-filter-button%})
