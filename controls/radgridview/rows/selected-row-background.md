---
title: Selected Row Background
page_title: Selected Row Background
description: RadGridView provides support for changing the background of its selected row through SelectedBackground property.
slug: radgridview-rows-selected-background
tags: selected,row,background
published: True
position: 4
---

# Selected Row Background

RadGridView has a default Brush for its selection on a row level depending on the given theme. For example, the visual appearance of the selected row in the Office2016 theme would be as shown below.

#### __Figure 1: Selected Row Background in Office2016 Theme__

![Selected Row Background in Office2016 Theme](images/RadGridView_SelectedRow_Background_01.png)

As of __R3 2018 RadGridView__ provides support for setting the background of its selected rows through the __SelectedBackground__ property of __GridViewRow__.

#### __[XAML] Example 1: Setting the SelectedBackground property of GridViewRow__

{{region xaml-radgridview-rows-selectedrow-background_0}}
	<Style TargetType="telerik:GridViewRow">
        <Setter Property="SelectedBackground" Value="Bisque"/>
    </Style>
{{endregion}}

#### __Figure 2: RadGridView with modified Background for its Selected Row__

![RadGridView with modified Background for its Selected Row](images/RadGridView_SelectedRow_Background_02.png)

> If you have [alternating rows]({%slug radgridview-rows-alternating-rows%}) and you have explicitly set a style which sets the SelectedBackground of the rows to the __RowStyle__ property of the RadGridView, you will have to set the [AlternateRowStyle]({%slug gridview-styling-a-row%}#setting-radgridviews-rowstyleselector-and-alternaterowsstyleselector) property to the same style (or a style that sets the __SelectedBackground__ property to the same value).

<!-- -->

>tip In case the [SelectionUnit]({%slug gridview-selection-basics%}#selection-units) of the RadGridView is __Cell__ or __Mixed__, you can set the [SelectedBackground]({%slug gridview-styling-cell%}#setting-the-selectedbackground-of-the-cell) property of the __GridViewCell__. 

## See Also

* [Grid Rows - Overview]({%slug gridview-rows-overview%})
* [Customizing Rows]({%slug gridview-customizing-rows%})
* [Alternating Rows]({%slug radgridview-rows-alternating-rows%})
