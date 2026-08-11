---
title: Template and Style Selectors
page_title: Template and Style Selectors
description: Check our &quot;Template and Style Selectors&quot; documentation article for the RadContextMenu control.
slug: radcontextmenu-populating-with-data-template-and-style-selectors
tags: template,and,style,selectors
published: True
position: 4
---

# Template and Style Selectors

The `RadContextMenu` and the `RadMenuItem` controls come with a set of selector properties. Typically, you use a template or style selector when you have more than one data template or style defined for the same type of objects.

>The following example is based on the [Populating with Data - Binding to Dynamic Data]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%}) article.

Here is a list of the selectors provided by the RadContextMenu control:

* `ItemContainerTemplateSelector`&mdash;Used to select a DataTemplate, which needs to contain an element of the type of RadMenuItem that will be displayed in the RadContextMenu control.
* `ItemTemplateSelector`&mdash;Used to select the `DataTemplate` that is set as the `HeaderTemplate` property of the child RadMenuItem instances.

__Define the ItemTemplateSelector__
<snippet id='radcontextmenu-styles-and-templates-template-and-style-selectors-define_the_itemtemplateselector-cs' />


__Using the ItemTemplateSelector in XAML__
<snippet id='radcontextmenu-styles-and-templates-template-and-style-selectors-using_the_itemtemplateselector_in_xaml-xaml' />


__RadContextMenu with ItemTemplateSelector__ 

![RadContextMenu with ItemTemplateSelector](images/RadContextMenu_TemplateAndStyleSelectors_ItemTemplateSelector.PNG)

* __ItemContainerStyleSelector:__ Used to select the __Style__ that is applied to the child __RadMenuItems__.

__Example 3: Define the ItemContainerStyleSelector__
<snippet id='radcontextmenu-styles-and-templates-template-and-style-selectors-example_3_define_the_itemcontainerstyleselector-cs' />


__Example 4: Using the ItemContainerStyleSelector in XAML__
<snippet id='radcontextmenu-styles-and-templates-template-and-style-selectors-example_4_using_the_itemcontainerstyleselector_in_xaml-xaml' />


__RadContextMenu with ItemContainerStyleSelector__ 

![RadContextMenu with ItemContainerStyleSelector](images/RadContextMenu_TemplateAndStyleSelectors_ItemContainerStyleSelector.PNG)

And a list of the selectors provided by the RadMenuItem control:

* `HeaderTemplateSelector`&mdash;Used to select the DataTemplate that is set to its HeaderTemplate property.
* `ItemContainerStyleSelector`&mdash;Used to select the `Style` that is applied to the child RadMenuItem elements.
* `ItemContainerTemplateSelector`&mdash;Used to select a DataTemplate, which needs to contain an element of the type of RadMenuItem that will be displayed in the RadContextMenu control.
* `ItemTemplateSelector`&mdash;Used to select the DataTemplate that is set as the HeaderTemplate property of the child RadMenuItem instances.

>tip These properties of the RadMenuItem should be set through the `ItemContainerStyle` of the parent item. If you set the ItemContainerStyle property of the `RadContextMenu` only (valid for [dynamic data scenarios]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%})), it will get inherited in the hierarchy, unless it is not explicitly set somewhere.

The `HierarchicalDataTemplate` used with the `RadContextMenu` also exposes `ItemContainerStyleSelector` and `ItemTemplateSelector` properties.

## See Also

 * [Data Binding Support Overview]({%slug radcontextmenu-populating-with-data-data-binding-support-overview%})

 * [Using Static Items]({%slug radcontextmenu-populating-with-data-using-static-items%})

 * [Binding to Dynamic Data]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%})

 * [Styles and Templates - Overview]({%slug radcontextmenu-styles-and-templates-overview%})
