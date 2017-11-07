---
title: Defer Filtering Until the Filter Button is Clicked
page_title: Defer Filtering Until the Filter Button is Clicked
description: Defer Filtering Until the Filter Button is Clicked
slug: gridview-filtering-howto-defer-filtering-until-the-filter-button-is-clicked
tags: defer,filtering,until,the,filter,button,is,clicked
published: True
position: 15
---

# Defer Filtering Until the Filter Button is Clicked

By default, when in **Popup** filtering mode, filtering will be applied to the RadGridView control once any of the two field filter editors loses focus.

You can set a column's **IsFilteringDeferred** property to **True** to change this behavior so that filtering will be performed only when the end user clicks the **Filter** button. Please note that the **Clear** button will immediately clear the column filter regardless of this setting.

## See Also

 * [Basic Filtering]({%slug gridview-filtering-basic%})
 * [Programmatic Filtering]({%slug gridview-filtering-programmatic%})
