---
title: Non-Working Filters in RadGridView
description: The RadGridView filters work only the first time they are applied
page_title: Filters Work Only the First Time in RadGridView
type: how-to
slug: kb-gridview-non-working-filters-with-custom-control-template-of-filtering-control
position: 0
tags: 
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2023.3.1114</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

The filters in the RadGridView control work only the first time that they are created.

This behavior can occur when a custom `ControlTemplate` is applied to the `Template` property of `FilteringControl` element with a product version equal to or higher than __2022.2.511__. 

With this version, an additional element was introduced to the default ControlTemplate of the FilteringControl, which allows you to [search in the distinct values]({%slug gridview-filtering-customizing-distinct-values%}#showing-distinct-values-filtering-search-box). This element is of the type of `RadWatermarkTextBox` and if it is not present, the internal filtering logic will not work as intended.

## Solution

To prevent this behavior from occurring, retrieve the RadWatermarkTextBox element's implementation from the latest version of the FilteringControl control's ControlTemplate for the used theme. You can find it in the __Telerik.Windows.Controls.GridView.xaml__ resource dictionary. Finally, place the element inside the custom ControlTemplate.

>tip Check [this article]({%slug styling-apperance-editing-control-templates%}) for a step-by-step guide on how to extract the default ControlTemplates of the controls.

#### __[XAML] Default implementation of the RadWatermarkTextBox control for the Office_Black theme__
{{region kb-gridview-non-working-filters-with-custom-control-template-of-filtering-control-0}}
    <telerik:RadWatermarkTextBox x:Name="PART_SearchBox"
            Margin="0 2 0 4"
            Visibility="{TemplateBinding DistinctValuesSearchBoxVisibility}"
            WatermarkContent="{telerik:LocalizableResource Key=GridViewFilterDistinctValueSearch}"
            CurrentText="{Binding SearchText, Mode=TwoWay, TargetNullValue=''}">
        <telerik:RadWatermarkTextBox.AdditionalContent>
            <Grid>
                <telerik:RadButton x:Name="PART_ClearButton"
                        Command="{x:Static telerik:RadWatermarkTextBoxCommands.Clear}"
                        Visibility="{Binding SearchText, Converter={StaticResource NullToVisibilityConverter}}"
                        Style="{StaticResource GridViewClearFilterButtonStyle}">
                    <telerik:RadGlyph Glyph="{StaticResource GlyphClose}"/>
                </telerik:RadButton>
                <telerik:RadGlyph x:Name="PART_SearchIcon" Glyph="{StaticResource GlyphZoom}"/>
            </Grid>
        </telerik:RadWatermarkTextBox.AdditionalContent>
    </telerik:RadWatermarkTextBox>
{{endregion}}