---
title: TextBoxStyle
page_title: TextBoxStyle
description: Check our &quot;TextBoxStyle&quot; documentation article for the RadAutoCompleteBox {{ site.framework_name }} control.
slug: radautocompletebox-textboxstyle
tags: textboxstyle
published: True
position: 4
---

# TextBoxStyle
The __TextBoxStyle__ property makes it easy to customize the __RadAutoCompleteBox__ and __RadAutoCompleteBoxItem__. This article will show you how to apply a custom __TextBoxStyle__.

## Applying custom TextBoxStyle

The first thing is to create a __RadAutoCompleteBox__ with an ItemsSource bound to a collection of countries.

__Example 1: Create an objects class__
<snippet id='radautocompletebox-styles-and-templates-textboxstyle-example_1_create_an_objects_class-cs' />

__Example 2: Create the ViewModel__
<snippet id='radautocompletebox-styles-and-templates-textboxstyle-example_2_create_the_viewmodel-cs' />

__Example 3: Create the RadAutoCompleteBox and sets its ItemsSource__
<snippet id='radautocompletebox-styles-and-templates-textboxstyle-example_3_create_the_radautocompletebox_and_sets_its_itemssource-xaml' />

#### __Figure 1: RadAutoCompleteBox without custom TextBoxStyle applied__
![Rad Auto Complete Box Features Text Box Style 01](images/RadAutoCompleteBox_StylesAndTemplates_TextBoxStyle_01.png)

You have to create a custom __Style__ with __TargetType__ __RadAutoCompleteBox__ or __RadAutoCompleteBoxItem__:

__Example 4: Create the custom Style__
<snippet id='radautocompletebox-styles-and-templates-textboxstyle-example_4_create_the_custom_style-xaml' />

>If you are using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) to style the controls, you would need to base that Style to the default TextBoxStyle of RadAutoCompleteBox named **RadAutoCompleteTextBoxStyle**.

The last step would be to simply set the custom style as __TextBoxStyle__ of __RadAutoCompleteBox__:

__Example 5: Apply the custom Style__
<snippet id='radautocompletebox-styles-and-templates-textboxstyle-example_5_apply_the_custom_style-xaml' />

You can see the final result on __Figure 2__.

#### __Figure 2: RadAutoCompleteBox with custom TextBoxStyle applied__
![Rad Auto Complete Box Features Text Box Style 02](images/RadAutoCompleteBox_StylesAndTemplates_TextBoxStyle_02.png)

## See Also

 * [Customizing the BoxesItemTemplate]({%slug radautocompletebox-customizing-boxes-itemtemplate%})

 * [BoxesItemStyle]({%slug radautocompletebox-boxesitemstyle%})
