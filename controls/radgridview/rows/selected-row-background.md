---
title: Selected Row Background
page_title: Selected Row Background
description: Selected Row Background
slug: radgridview-rows-selected-background
tags: selected,row,background
published: True
position: 4
---

# Selected Row Background

RadGridView has a default Brush for its selection on row level depending on the given theme. For example, the visual appearance of the selected row in the Office2016 theme would be as shown below.

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

## See Also

* [Grid Rows - Overview]({%slug gridview-rows-overview%})
* [Customizing Rows]({%slug gridview-customizing-rows%})
* [Alternating Rows]({%slug radgridview-rows-alternating-rows%})
