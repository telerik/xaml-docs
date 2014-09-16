---
title: Overview
page_title: Overview
description: Overview
slug: gridview-stylines-and-templates-overview
tags: overview
publish: True
position: 0
---

# Overview



## 

This section is intended to give you a broad understanding of the possible ways by which you can change the visual appearance of the __RadGridView__and its elements. There is also comprehensive information about their __ControlTemplates__. You will need this information if you want to customize their appearance. 

>tipTo learn how to style Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} read the common topics about
          [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%}). You can also check the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) topic. 
        

You can modify the look of the __RadGridView__and its elements either by changing some of the resources exposed by the API, or by modifying their __ControlTemplates__. In the control template you are allowed to reorder the template parts and add your own elements. However, when changing the control template you should be careful to include all required parts.

Using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) gives you the ability to easily extract and edit the default ControlTemplates of the controls. You can follow [this article]({%slug styling-apperance-editing-control-templates%}) on two different approaches on how to extract the ControlTemplates.
        

>tipNote that when changing the __ControlTemplate__ you should include all required parts. Even if your code compiles, some of the functionality may be subject to impact due to the omission of the required parts. The required parts are usually marked with the prefix "__PART___".

To learn more about styling the __RadGridView__ specific elements read the following topics.

* [Styling a Cell]({%slug gridview-styling-cell%})

* [Styling the GridViewEditorPresenter]({%slug gridview-styling-editorpresenter%})

* [Styling the Column Headers]({%slug gridview-styling-column-headers%})

* [Styling the Merged Column Headers]({%slug gridview-styling-merged-column-headers%})

* [Styling the Column Footers]({%slug gridview-styling-column-footers%})

* [Styling the Group Footers]({%slug gridview-styles-and-templates-styling-group-footers%})

* [Styling the Group Panel]({%slug radgridview-styles-and-templates-styling-the-group-panel%})

* [Styling the Group Row]({%slug gridview-styling-group-row%})

* [Styling the Header Row]({%slug gridview-styling-header-row%})

* [Styling a Row]({%slug gridview-styling-a-row%})

* [Styling the Row Details]({%slug gridview-styling-row-details%})

* [Styling the Column Editor]({%slug radgridview-styling-column-editor%})

* [Styling the Indent Cells in RadGridView]({%slug radgridview-styling-indent-cells%})

* [Styling the Default RadGridView Styles]({%slug how-to-override-default-gridview-styles%})

* [Styling the FilteringControl]({%slug gridview-styling-filteringcontrol%})

* [Styling the FilterRow]({%slug gridview-styling-filterrow%})

>As of __2013 Q2 SP__ we have introduced __Lightweight Templates__ for RadGridView and RadTreeListView. Their main idea is to limit the number of visual elements within the templates in order to speed up the performance of the control.
            [Read more]({%slug gridview-overview-lightweight-template%})

# See Also

 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})

 * [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})

 * [Controlling Appearance]({%slug gridview-styles-and-templates-controlling-appearance%})

 * [Lightweight Templates]({%slug gridview-overview-lightweight-template%})
