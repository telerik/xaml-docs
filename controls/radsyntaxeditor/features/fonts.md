---
title: Fonts
page_title: Fonts
description: This article lists and explains the fonts settings exposed by the RadSyntaxEditor control.
slug: radsyntaxeditor-features-fonts
tags: fonts,radsyntaxeditor
position: 8
---

# {{ site.framework_name }} RadSyntaxEditor Fonts

The RadSyntaxEditor responds to changes in its font properties just as any other WPF control. You can modify the font size and family of the control through the **FontSize** and **FontFamily** properties as demonstrated in **Example 1**.

#### __[XAML] Example 1: Setting font properties__
{{region xaml-radsyntaxeditor-features-fonts-1}}

    <telerik:RadSyntaxEditor FontSize="20" FontFamily="Arial" />
{{endregion}}

These properties, however, will not be applied to the line numbers, editor presenter and intelliprompt parts of the control.

#### __Figure 1: RadSyntaxEditor with custom font settings__
![RadSyntaxEditor with custom font settings](images/syntaxeditor-fonts.png)

## EditorFontSize and EditorFontFamily

To modify the FontSize and FontFamily of the line numbers, editor presenter and intelliprompts you need to use the **EditorFontSize** and **EditorFontFamily** properties.

#### __[XAML] Example 2: Setting font properties__
{{region xaml-radsyntaxeditor-features-fonts-2}}

    <telerik:RadSyntaxEditor EditorFontSize="20" EditorFontFamily="Arial" />
{{endregion}}

#### __Figure 2: RadSyntaxEditor with custom font settings for the editor__
![RadSyntaxEditor with custom font settings](images/syntaxeditor-fonts-2.png)

## Monospaced Font Optimization

When the used font is **Consolas**, **Courier New** or **Lucida Console**, you can benefit from the **monospaced font optimization** to boost the performance of the control. To enable this optimization, you need to set the **UseMonospacedFontOptimization** property to **True**.

#### __[XAML] Example 3: Enabling monospaced font optimization__
{{region xaml-radsyntaxeditor-features-fonts-3}}

    <telerik:RadSyntaxEditor FontFamily="Courier New" UseMonospacedFontOptimization="True" />
{{endregion}}

## See Also

* [Zooming]({%slug radsyntaxeditor-features-zooming%})