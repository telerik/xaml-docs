---
title: PathButton
page_title: PathButton
description: Check our &quot;PathButton&quot; documentation article for the RadButtons {{ site.framework_name }} control.
slug: radbuttons-features-pathbutton
tags: pathbutton
published: True
position: 1
---

# PathButton

With our __Q3 2014__ official release we introduced the RadPathButton control. It derives from the __RadButton__. This means it inherits all the features of the standard button. Additionally it adds a __Path__ control to its default template. This allows you to easily add custom geometry to your button. You can instantiate this control in both XAML and code behind (see __Example 1 and 2__).

__Example 1: Defining a button in XAML__
<snippet id='radbuttons-features-pathbutton-example_1_defining_a_button_in_xaml-xaml' />

__Example 2: Defining a button in code__
<snippet id='radbuttons-features-pathbutton-example_2_defining_a_button_in_code-cs' />
<snippet id='radbuttons-features-pathbutton-example_2_defining_a_button_in_code-vb' />


#### __Figure 1: The created path button__
![The created button](images/radbuttons-features-pathbutton-0.png)

Note that in XAML you can directly use string format [Path Markup Syntax](https://docs.microsoft.com/en-us/dotnet/framework/wpf/graphics-multimedia/path-markup-syntax)

__Example 3: Setting the path geometry in XAML__
<snippet id='radbuttons-features-pathbutton-example_3_setting_the_path_geometry_in_xaml-xaml' />

To achieve the same results through code you can use our __GeometryParser__

__Example 3: Setting the path geometry in code__
<snippet id='radbuttons-features-pathbutton-example_3_setting_the_path_geometry_in_code-cs' />
<snippet id='radbuttons-features-pathbutton-example_3_setting_the_path_geometry_in_code-vb' />


#### __Figure 2: RadPathButton with PathGeometry__
![RadPathButton with PathGeometry](images/radbuttons-features-pathbutton-1.png)

# Customizing the RadPathButton

The __RadPathButton__ exposes the __ContentPlacement__ property. It is of type __Dock__ and gets or sets this position of the content relative to the Path element. This property accepts __Left__, __Top__, __Right__ and __Bottom__ values. The default is __Bottom__.
        
__Example 4: Setting the content position in XAML__
<snippet id='radbuttons-features-pathbutton-example_4_setting_the_content_position_in_xaml-xaml' />

__Example 5: Setting the content position in code__
<snippet id='radbuttons-features-pathbutton-example_5_setting_the_content_position_in_code-cs' />
<snippet id='radbuttons-features-pathbutton-example_5_setting_the_content_position_in_code-vb' />


#### __Figure 3: RadPathButton with ContentPlacement set to Right__
![RadPathButton with ContentPlacement set to Right](images/radbuttons-features-pathbutton-2.png)

In addition to all customizing options that are inherited from the __RadButton__ the __PathButton__ has a __PathStyle__ property. This property gets or sets the style of the __Path__ element in the template.

__Example 5: Setting the content position in XAML__
<snippet id='radbuttons-features-pathbutton-example_5_setting_the_content_position_in_xaml-xaml' />

#### __Figure 4: RadPathButton with custom PathStyle__
![RadPathButton with custom PathStyle](images/radbuttons-features-pathbutton-3.png)

Also the __RadPathButton__ exposes the __ContentMargin__ property. It is of type __Thickness__ and determines the margin around its content. This allows users to adjust size of the Path that the button hosts. For adjusting the position of the Path itself users can use the __RadPathButton.Padding__ property.

## Aligning the Path

By default, the **Stretch** property of the **Path** element is set to **Fill**. As a result, when the **ContentPlacement** of the button is set to **Top** or **Bottom**, only the **HorizontalContentAlignment** takes effect. Respectively, when the **ContentPlacement** is **Left** or **Right**, only the **VerticalContentAlignment** takes effect.

With the **R1 2021 SP** release you can now more intuitively place the path element of the button relatively to its content. For the purpose, you need to set the **Stretch** property of the **Path** to **None** and set the desired horizontal and vertical alignments.

__Example 6: Setting the path alignment in XAML__
<snippet id='radbuttons-features-pathbutton-example_6_setting_the_path_alignment_in_xaml-xaml' />

#### __Figure 5: RadPathButton with different alignments__
![RadPathButton with different alignments](images/radbuttons-features-pathbutton-path-alignment.gif)

As seen in the image above you may also want to set appropriate values for the **HorizontalContentAlignment** and **VerticalContentAlignment** of the RadPathButton to align the content in the available space.

## RadPathButton and RadGlyph

The RadPathButton can also be used with [RadGlyphs]({%slug common-styling-appearance-radglyph%}).

__Example 7: Set RadGlyph as PathGeometry__
<snippet id='radbuttons-features-pathbutton-example_7_set_radglyph_as_pathgeometry-xaml' />

#### __Figure 6: RadPathButton with RadGlyph__
![RadPathButton with RadGlyph](images/radbuttons-features-pathbutton-4.png)

## See Also
 * [Button]({%slug radbuttons-features-button%})
 * [DropDown Button]({%slug radbuttons-features-dropdown-button%})
 * [Split Button]({%slug radbuttons-features-split-button%})
 * [Commands]({%slug radbuttons-features-commands%}) 
