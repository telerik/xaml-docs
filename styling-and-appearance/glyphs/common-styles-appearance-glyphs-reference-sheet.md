---
title: Glyphs Reference Sheet
page_title: Telerik UI for WPF Glyphs Reference Sheet
description: Browse the available Telerik UI for WPF glyphs, learn how to use each glyph value, and choose between TelerikWebUI and TelerikFluentIcons.
components: ["general"]
slug: common-styling-appearance-glyphs-reference-sheet
tags: glyphs,telerikwebui,office2016,fonts,foregrounds,text,icons,reference,sheet
published: True
position: 1
glyphs_reference_sheet: True
---

# Glyphs Reference Sheet

Use this reference sheet to find glyphs in the `TelerikWebUI` and `TelerikFluentIcons` fonts for Progress® Telerik® UI for WPF. The generated tables list each glyph name together with its numeric and string values for XAML or code.

For general glyph concepts, supported scenarios, and additional examples, see the [Font Glyphs overview]({%slug common-styling-appearance-glyphs-overview%}).

## How to Use This Reference Sheet

Use the tables on this page in the following way:

* Use the glyph name when you want a readable static resource such as `GlyphCalendar` or `GlyphDownload`.
* Use the hexadecimal glyph number, such as `e108`, to identify the character, or copy its string value, `&#xe108;`, into a XAML attribute.
* Prefer the glyph name over a hard-coded numeric value when possible. The resource name is easier to read and maintain.

For code or data binding, convert the string value to a single character as described in [Binding Glyphs]({%slug common-styling-appearance-glyphs-overview%}#binding-glyphs).

The last column identifies glyphs introduced with the R2 2022 release as `Yes (R2 2022) *`. `No` means the glyph is not marked as introduced in that release.

## Use a Glyph from the Table

After you choose a glyph from the reference sheet, use either its resource key or its string value in `RadGlyph` or in a text-hosting element.

These XAML fragments belong inside a layout panel in a WPF view, such as `MainWindow.xaml`. Reference `Telerik.Windows.Controls.dll` and declare `xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"` on the view's root element.

>tip For `StaticResource` glyph keys in a custom project, merge `FontResources.xaml` into the application resources. See the resource dictionary example in [RadGlyph Usage]({%slug common-styling-appearance-radglyph%}#usage).

**Example 1: Use a glyph resource key in `RadGlyph`**

```xaml
<telerik:RadGlyph Glyph="{StaticResource GlyphCalendar}" FontSize="16" />
```

**Example 2: Use a glyph string value directly in `RadGlyph`**

```xaml
<telerik:RadGlyph Glyph="&#xe108;" FontSize="16" />
```

Example 2 uses the XAML character reference `&#xe108;` to display the same calendar glyph as `GlyphCalendar` in Example 1.

**Example 3: Use a glyph resource key in a `TextBlock`**

Example 3 uses `RadGlyph.TelerikFontFamily`, introduced in R2 2022, to display the calendar glyph in a `TextBlock`.

```xaml
<TextBlock FontFamily="{x:Static telerik:RadGlyph.TelerikFontFamily}"
		   FontSize="16"
		   Text="{StaticResource GlyphCalendar}" />
```

## Choose Between TelerikWebUI and TelerikFluentIcons

The reference sheet compares both fonts. `TelerikWebUI` is the default font for `RadGlyph`. Starting with R2 2022, set its `Font` property to `TelerikFluentIcons` for a similar icon set with a different appearance. See [RadGlyph Fonts]({%slug common-styling-appearance-radglyph%}#fonts) for the font comparison.

**Example 4: Use `TelerikFluentIcons` for a glyph**

```xaml
<telerik:RadGlyph Font="TelerikFluentIcons"
				  Glyph="{StaticResource GlyphCalendar}"
				  FontSize="16" />
```

## Glyph List

The tables are grouped by category. Each row compares the `TelerikFluentIcons` and `TelerikWebUI` previews and lists the glyph name, number, string value, and R2 2022 release status. Each preview has an accessible label identifying its font and glyph name.

Search by glyph name when you know the icon you want to use. Compare the string and numeric values when you need to work with glyphs programmatically.

@[template](/_contentTemplates/glyphs-table.md#reference-sheet-table)

## See Also

* [Set a Theme by Using Implicit Styles]({%slug styling-apperance-implicit-styles-overview%})
* [Read the Font Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
* [Use RadGlyph to Display Font Glyphs]({%slug common-styling-appearance-radglyph%})
