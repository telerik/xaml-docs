---
title: Styling Search Panel
page_title: Styling Search Panel
description: Styling Search Panel
slug: gridview-styling-search-panel
tags: styling,search,panel
published: True
position: 23
---

# Styling Search Panel

>Before reading this topic, you might find useful to get familiar with RadGridView`s [Search As You Type]({%slug radgridview-search-as-you-type%}) functionality.

The SearchPanel within the __RadGridView__ control can by styled by creating an appropriate Style that targets __"telerik:GridViewSearchPanel"__.
 
You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.


>tipIf you choose to define the style in the resources of the application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

You can apply a style to the Search Panel, similar to the following example:

#### __[XAML] Example 1: Applying a style to the search panel of RadGridView:__
 
	  <Style TargetType="telerik:GridViewSearchPanel">
            <Setter Property="FontSize" Value="20"></Setter>
            <Setter Property="FontWeight" Value="Bold"></Setter>
            <Setter Property="Height" Value="50"></Setter>
        </Style>

#### __Figure 1: Appearance of the control after the style is applied:__
![gridview-search-panel](images/search-panel-styled.PNG)

You can find the GridViewSearchPanel template structure in the [Templates Structure]({%slug radgridview-styles-and-templates-templates-structure%}) article for RadGridView.

## Change the color of the highlighted text 

By default, the symbols matching the searching criteria are colored in red. This can easily be changed by changing the value of the __HightlightBrush__ in the __HighlightTextBlock__:

#### __[XAML] Example 2: Change the HighlightBrush of the HighlightTextBlock.__
	<Style TargetType="telerik:HighlightTextBlock">
			<Setter Property="HighlightBrush" Value="Green"/>
	</Style> 

#### __[XAML] Figure 2: Appearance of the highlighted text after the style is applied.__

![](images/search-panel-highlight-color.png)

>The examples show the approach used for the __standard binaries__. In case you have referenced the NoXaml binaries, you need to set the __BasedOn__ property of the respective __Style__


# See Also

 * [Styling the GridViewEditorPresenter]({%slug gridview-styling-editorpresenter%})

 * [Styling the Column Footers]({%slug gridview-styling-column-footers%})

 * [Styling the Column Headers]({%slug gridview-styling-column-headers%})

 * [Change Background for Disabled Grid Elements]({%slug gridview-how-to-set-background-disabled-cell%})
