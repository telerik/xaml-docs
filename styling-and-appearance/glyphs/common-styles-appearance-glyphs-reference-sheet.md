---
title: Glyphs Reference Sheet
page_title: Telerik UI for WPF Glyphs Reference Sheet
description: Browse the available Telerik UI for WPF glyphs, learn how to use each glyph value, and choose between TelerikWebUI and TelerikFluentIcons.
slug: common-styling-appearance-glyphs-reference-sheet
tags: glyphs,telerikwebui,office2016,fonts,foregrounds,text,icons,reference,sheet
published: True
position: 1
glyphs_reference_sheet: True
---

# Glyphs Reference Sheet

Use this reference sheet to find the available glyphs in the `TelerikWebUI` font and the values you need to use them in XAML or code. The generated table below lists each glyph name together with its numeric and string values.

For the general glyph concepts, supported scenarios, and additional examples, see [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%}).

## How to Use This Reference Sheet

Use the table on this page in the following way:

* Use the glyph name when you want a readable static resource such as `GlyphCalendar` or `GlyphDownload`.
* Use the string or numeric value when you need to generate or convert a glyph in code.
* Prefer the glyph name over a hard-coded numeric value when possible because the resource name is easier to read and maintain.

The glyphs marked with `*` in the last column were introduced with the **R2 2022** release.

## Use a Glyph from the Table

After you choose a glyph from the reference sheet, use either its resource key or its string value in `RadGlyph` or in a text-hosting element.

__Example 1: Use a glyph resource key in RadGlyph__

```xaml
<telerik:RadGlyph Glyph="{StaticResource GlyphCalendar}" FontSize="16" />
```

__Example 2: Use a glyph string value directly in RadGlyph__

```xaml
<telerik:RadGlyph Glyph="&#xe021;" FontSize="16" />
```

This is often the quickest approach when you already know the string value from the table and want to set the glyph directly in XAML.

__Example 3: Use a glyph resource key in a TextBlock__

```xaml
<TextBlock FontFamily="{x:Static telerik:RadGlyph.TelerikFontFamily}"
		   FontSize="16"
		   Text="{StaticResource GlyphCalendar}" />
```

>tip If you use glyph resource keys as `StaticResource` values in a custom project, merge `FontResources.xaml` as described in [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%}).

## Choose Between TelerikWebUI and TelerikFluentIcons

The reference sheet below lists the glyphs in the `TelerikWebUI` font, which is the default font for Telerik glyphs. If you use the Windows 11 theme or prefer the newer visual style, you can set the `Font` property of `RadGlyph` to `TelerikFluentIcons`, which provides a similar icon set with a different appearance.

__Example 4: Use TelerikFluentIcons for a glyph__

```xaml
<telerik:RadGlyph Font="TelerikFluentIcons"
				  Glyph="{StaticResource GlyphCalendar}"
				  FontSize="16" />
```

## Glyph List

Search the table by glyph name when you know the icon you want to use, or compare the string and numeric values when you need to work with glyphs programmatically.

@[template](/_contentTemplates/glyphs-table.md#reference-sheet-table)

## See Also

* [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
* [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
