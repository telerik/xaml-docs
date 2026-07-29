---
title: Save and Load Filter Settings
page_title: Save and Load Filter Settings
description: Learn how you can create a simple property bag class in order to save and load column filters in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-filtering-howto-save-and-load-filter-settings
tags: save,and,load,filter,settings
published: True
position: 18
---

# Save and Load Filter Settings

To save and load column filters, you would have to create a simple property bag class that will hold all relevant information. 



<snippet id='radgridview-filtering-how-to-howto-save-and-load-filter-settings-block_1-cs' />

<snippet id='radgridview-filtering-how-to-howto-save-and-load-filter-settings-block_1-vb' />


To save the settings you need to read the current filtering information from RadGridView and store it in a collection of these property bag objects. You can then take this collection and serialize it to a medium of your choice a database or an XML file, for example, by using RadPersistenceFramework.



<snippet id='radgridview-filtering-how-to-howto-save-and-load-filter-settings-block_2-cs' />

<snippet id='radgridview-filtering-how-to-howto-save-and-load-filter-settings-block_2-vb' />


>Note that when the filters are being restored we suspend and resume the notifications in order to perform the filtering in a single batch. 

When you deserialize the filter settings, you only need to find the respective column and apply the information stored in the property bag to the column filter.



<snippet id='radgridview-filtering-how-to-howto-save-and-load-filter-settings-block_3-cs' />

<snippet id='radgridview-filtering-how-to-howto-save-and-load-filter-settings-block_3-vb' />


More about this you can learn [here]({%slug gridview-filtering-programmatic%}).

You can also check the [Save and Load Settings for RadGridView]({%slug gridview-overview-saveload-settings%}) article.
        
