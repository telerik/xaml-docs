---
title: Localization
page_title: Localization
description: Localization
slug: gridview-localization2
tags: localization
published: True
position: 0
---

# Localization



The built-in localization mechanism in {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} allows you to localize __RadGridView__ control. 

Here is a list of the supported languages:
      

* English
        

* German
        

* Spanish
        

* French

![Rad Grid View Localization 4](images/RadGridView_Localization_4.png)

>tip__To learn more about the ways to localize the RadControls please read the common topic on [Localization](B0F77598-F54B-4ACA-B3EE-A38FF9B41BB8).

>__In order to dynamically localize the GridView at runtime, you should recreate it.__

## Resource Keys

__RadGridView__ is a complex user interface control and its strings for localization are numerous. In order to be able to distinguish these resources, an unique identifier, called __resource key__, is assigned to each localizable string.

On the picture below you can see some of the resource keys and the strings they are associated with.

![Rad Grid View Localization 3](images/RadGridView_Localization_3.png)

Here is a list of all of the __Resources__ available and their default values:


<table> <tr>KeyValue</tr><tr><td>GridViewAlwaysVisibleNewRow</td><td>Click here to add new item</td></tr><tr><td>GridViewClearFilter</td><td>Clear Filter</td></tr><tr><td>GridViewFilter</td><td>Filter</td></tr><tr><td>GridViewFilterAnd</td><td>And</td></tr><tr><td>GridViewFilterContains</td><td>Contains</td></tr><tr><td>GridViewFilterDoesNotContain</td><td>Does not contain</td></tr><tr><td>GridViewFilterEndsWith</td><td>Ends with</td></tr><tr><td>GridViewFilterIsContainedIn</td><td>Is contained in</td></tr><tr><td>GridViewFilterIsEqualTo</td><td>Is equal to</td></tr><tr><td>GridViewFilterIsGreaterThan</td><td>Is greater than</td></tr><tr><td>GridViewFilterIsGreaterThanOrEqualTo</td><td>Is greater than or equal to</td></tr><tr><td>GridViewFilterIsNotContainedIn</td><td>Is not contained in</td></tr><tr><td>GridViewFilterIsLessThan</td><td>Is less than</td></tr><tr><td>GridViewFilterIsLessThanOrEqualTo</td><td>Is less than or equal to</td></tr><tr><td>GridViewFilterIsNotEqualTo</td><td>Is not equal to</td></tr><tr><td>GridViewFilterMatchCase</td><td>Match case</td></tr><tr><td>GridViewFilterOr</td><td>Or</td></tr><tr><td>GridViewFilterSelectAll</td><td>Select All</td></tr><tr><td>GridViewFilterShowRowsWithValueThat</td><td>Show rows with value that</td></tr><tr><td>GridViewFilterStartsWith</td><td>Starts with</td></tr><tr><td>GridViewFilterIsNull</td><td>Is null</td></tr><tr><td>GridViewFilterIsNotNull</td><td>Is not null</td></tr><tr><td>GridViewFilterIsEmpty</td><td>Is empty</td></tr><tr><td>GridViewFilterIsNotEmpty</td><td>Is not empty</td></tr><tr><td>GridViewFilterDistinctValueNull</td><td>[null]</td></tr><tr><td>GridViewFilterDistinctValueStringEmpty</td><td>[empty]</td></tr><tr><td>GridViewGroupPanelText</td><td>Drag a column header and drop it here to group by that column</td></tr><tr><td>GridViewGroupPanelTopText</td><td>Group Header</td></tr><tr><td>GridViewGroupPanelTopTextGrouped</td><td>Grouped by:</td></tr></table>

# See Also

 * [CurrentCulture Format Settings are not respected]({%slug gridview-troubleshooting-apply-currentculture%})

 * [Enable\Disable Grid Elements]({%slug gridview-enable-disable-grid-elements%})

 * [Grid Export]({%slug gridview-export%})

 * [Tips and Tricks]({%slug radgridview-performance-tips-tricks%})
