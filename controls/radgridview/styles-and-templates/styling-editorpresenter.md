---
title: Styling Editor Presenter
page_title: Styling Editor Presenter
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to change the appearance of a cell when it enters edit mode.
slug: gridview-styling-editorpresenter
tags: styling,gridvieweditorpresenter
published: True
position: 6
---

# Styling Editor Presenter

If you want to change the appearance of a cell when it enters edit mode, you should modify the style of the __GridViewEditorPresenter__. This element is a plain presenter used to display the editors for the cells.

>To learn how to modify the default styles of a control, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

>You could also learn how to extract control templates in the [following article]({%slug styling-apperance-editing-control-templates%}).

__Example 1: Styling the GridViewEditorPresenter__

```XAML
	<Style TargetType="{x:Type telerik:GridViewEditorPresenter}">
		<Setter Property="Template" Value="{StaticResource GridViewEditorPresenterTemplate}"/>
		<Setter Property="Padding" Value="5"/>
	</Style>
```

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewEditorPresenterStyle__.

#### __Figure 2: RadGridView with styled GridViewEditorPresenter__

![Telerik {{ site.framework_name }} DataGrid-styled-editor-presenter](images/gridview-styled-editorpresenter.png)
            
>If you would like to change the appearance of the editor itself, then you should create a simple style targeted at the corresponding editor. You can have a look at the [Styling Column Editor]({%slug radgridview-styling-column-editor%}) article for more information.
        
## See Also

 * [Styling Column Editor]({%slug radgridview-styling-column-editor%})

 * [Modifying Default Styles]({%slug gridview-modifying-default-styles%})

 * [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}).
