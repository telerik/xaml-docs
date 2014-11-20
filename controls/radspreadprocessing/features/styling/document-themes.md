---
title: Document Themes
page_title: Document Themes
description: Document Themes
slug: radspreadprocessing-features-styling-document-themes
tags: document,themes
published: True
position: 1
---

# Document Themes



The document model comes with a number of predefined themes called Document themes. They enable you to specify colors, fonts and a variety of graphic effects in a document and affect the look and feel of the whole workbook. Each theme contains a color scheme and a font scheme and is represented by the __DocumentTheme__ class.
      

* [Color Schemes](#color-schemes)

* [Font Schemes](#font-schemes)

* [Document Themes](#document-themes)

* [Getting actual values](#getting-actual-values)

## Color Schemes

A color scheme has a unique name and contains a number of predefined colors. Its representation in the document model is the __ThemeColorScheme__ class. A scheme defines twelve colors and each of these is assigned a sole __ThemeColorType__. The following list contains all __ThemeColorType__ values:
        

* background1

* text1

* background2

* text2

* accent1

* accent2

* accent3

* accent4

* accent5

* accent6

* hyperlink

* followed hyperlink

The twelve color types above are used for creating __ThemableColor__ objects. They determine the color of the scheme that appears as the actual color of the __ThemableColor__ instance. As you change the theme or the color scheme, the actual color of the __ThemeableColor__ object changes as well. For example, if you set the fill of a cell to be a __ThemableColor__, applying a new theme or another scheme also affects the solid fill.
        

__Example 1__ demonstrates how to create a __ThemeColorScheme__ object. Note that the example passes a name and twelve colors to the constructor. Every color has a comment next to it, so you can see its corresponding __ThemeColorType__.
        

#### __[C#] Example 1: __

{{region radspreadprocessing-features-styling-document-themes_0}}
    ThemeColorScheme colorScheme = new ThemeColorScheme(
        "Mine",
        Colors.Black,     // background 1
        Colors.Blue,      // text 1
        Colors.Brown,     // background 2
        Colors.Cyan,      // text 2
        Colors.DarkGray,  // accent 1
        Colors.Gray,      // accent 2
        Colors.Green,     // accent 3
        Colors.LightGray, // accent 4
        Colors.Magenta,   // accent 5
        Colors.Orange,    // accent 6
        Colors.Purple,    // hyperlink
        Colors.Red);      // followedHyperlink
{{endregion}}



There are several ways to create a __ThemableColor__ object:
        

* Passing two parameters to the constructor – *ThemeColorType* and *double*.
            

* __ThemeColorType__ is an enum which has twelve possible values (the aforementioned color types).
                

* The second parameter is of type __double__ and should be between -1 and 1. It represents the tint and shade to be applied on the selected color.
                

* Passing *ThemeColorType* and *ColorShadeType*.
            

* __ThemeColorType__ is the same as in the previously mentioned constructor.
                

In order to create colors that depend on the current document theme, you need to use __ThemableColor__ objects.
        

__Example 2__ shows how you can create a ThemableColor:
        

#### __[C#] Example 2: Create ThemableColor__

{{region radspreadprocessing-features-styling-document-themes_1}}
    ThemableColor themableColor = new ThemableColor(ThemeColorType.Accent1);
{{endregion}}



## Font Schemes

A font scheme is represented by the __ThemeFontScheme__ class. Every font scheme consists of a name and a number of predefined font families. Each font family corresponds to one of two font types:
        

* Major

* Minor

To create a ThemeFontScheme you need to pass a name and two font family names to the font scheme constructor. The former font family name corresponds to the Major __ThemeFontType__ and the latter - to the Minor.
        

__Example 3__ illustrates how to create a __ThemeFontScheme__ object.
        

#### __[C#] Example 3: Create ThemeFontScheme__

{{region radspreadprocessing-features-styling-document-themes_2}}
    ThemeFontScheme fontScheme = new ThemeFontScheme(
        "Mine",
        "Times New Roman",  // latinMajor
        "Arial");           // latinMinor
{{endregion}}



In order to use the document theme's fonts you need to use __ThemableFontFamily__ objects. Again, there are several ways you can create one:
        

* Passing a __ThemeFontType__ object as a constructor parameter – this way you will bind the object being created to the currently selected document theme.
            

* Passing a __FontFamily__ object or a string representing a FontFamily name – the result would be a static FontFamily, meaning it will not be changed when the document theme is changed.
            

When you need to create а font that depends on the current document theme, you can use the __ThemableFontFamily__ objects.
        

__Example 4__ shows how to create a ThemableFontFamily.
        

#### __[C#] Example 4: Create ThemableFontFamily__

{{region radspreadprocessing-features-styling-document-themes_3}}
    ThemableFontFamily themableFont = new ThemableFontFamily(ThemeFontType.Major);
{{endregion}}



## Document Themes

Now that when you have a color and a font schemes, you can create a new __DocumentTheme__. You need to specify a name and pass the already created color and font schemes.
        

__Example 5__ demonstrates how to use create a DocumentTheme using the color scheme from __Example 1__ and the font scheme from __Example 3__.
        

#### __[C#] Example 5: Create DocumentTheme__

{{region radspreadprocessing-features-styling-document-themes_4}}
    DocumentTheme theme = new DocumentTheme("Mine", colorScheme, fontScheme);
{{endregion}}



In the predefined static class __PredefinedThemeSchemes__ you can find a number of predefined color and font schemes. The class exposes the properties __ColorSchemes__ and __FontSchemes__ that hold all predefined schemes.
        

__Example 6__ shows how you can create a document theme using the predefined color and font schemes.
        

#### __[C#] Example 6: Create DocumentTheme from predefined schemes__

{{region radspreadprocessing-features-styling-document-themes_5}}
    DocumentTheme theme = new DocumentTheme("From predefined schemes", PredefinedThemeSchemes.ColorSchemes[0], PredefinedThemeSchemes.FontSchemes[5]);
{{endregion}}



Changing the current document theme is as easy as setting a single property:
        

__Example 7__ changes the theme of a newly created workbook.
        

#### __[C#] Example 7: Change DocumentTheme.__

{{region radspreadprocessing-features-styling-document-themes_6}}
    Workbook workbook = new Workbook();
    workbook.Worksheets.Add();
    workbook.Theme = theme;
{{endregion}}



## Getting actual values

In order to get the actual value from __ThemableColor__ or __ThemableFontFamily__ you need to call the __GetActualValue()__ method on the corresponding object.
        

#### __[C#] Example 8: Get actual color__

{{region radspreadprocessing-features-styling-document-themes_7}}
    Color actualColor = themableColor.GetActualValue(theme);
    // the actual color is the same as Accent1 color of the colorScheme
{{endregion}}



#### __[C#] Example 9: Get actual font__

{{region radspreadprocessing-features-styling-document-themes_8}}
    var actualFont = themableFont.GetActualValue(theme);
    // the actualFont is the same as the Major font of the fontScheme
{{endregion}}



# See Also

 * [Cell Styles]({%slug radspreadprocessing-features-styling-cell-styles%})
