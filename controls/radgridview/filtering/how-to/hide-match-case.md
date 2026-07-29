---
title: Hide the Match Case option of the Filtering control
page_title: Hide the Match Case option of the Filtering control
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to hide the Match Case option of the filtering control.
slug: gridview-how-to-hide-match-case
tags: hide,the,match,case,option,of,the,filtering,control
published: True
position: 17
---

# Hide the Match Case option of the Filtering control


By default, the filtering control shows the Match Case option when the type of the data is string. This article shows how to hide this option (as some languages does not have a difference between lower and upper case letters).

![Telerik UI for {{ site.framework_name }} RadGridView filtering control with the Match Case option visible](images/how_to_hide_match_case_gridview.png)


This cannot be done by simply adding the XAML of the control template, because the proper filter editor is added in runtime depending on the type of the column.

So, we need to use some events and code behind:

1. Subscribe to the __FieldFilterEditorCreated__ event of RadGridView.
First approach (after Q3 2011)

Since __Q3 2011__ version of {% if site.site_name == 'Silverlight' %}Telerik UI for Silverlight{% endif %}{% if site.site_name == 'WPF' %}Telerik UI for WPF{% endif %}, a new property __MatchCaseVisibility__ had been added to the StringFilterEditor. So you could change its value directly.
            

2. In its event handler check if the editor is of type StringFilterEditor and if so - set the MatchCaseVisibility to Visibility.Hidden.
              

Here is the full code



<snippet id='radgridview-filtering-how-to-hide-match-case-block_1-cs' />

<snippet id='radgridview-filtering-how-to-hide-match-case-block_1-vb' />


Second approach (before Q3 2011)

2. In its event handler check if the editor is of type StringFilterEditor and if so - find the match case toggle button and collapse it.

Here is the full code:



<snippet id='radgridview-filtering-how-to-hide-match-case-block_2-cs' />

<snippet id='radgridview-filtering-how-to-hide-match-case-block_2-vb' />





