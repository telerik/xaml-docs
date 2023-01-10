---
title: Fonts
page_title: Fonts
description: Learn how you can work with the fonts RadRichTextBox for {{ site.framework_name }} uses and how you can control them.
slug: radrichtextbox-features-fonts
tags: font, font-family
published: True
---

# {{ site.framework_name }} RadRichTextBox Fonts

**RadRichTextBox** uses different font families to render the text inside. This article describes how the default font families are loaded and how you can register custom ones.

## Default Fonts

{% if site.site_name == 'WPF' %}
When initializing, **RadRichTextBox** loads all the fonts installed on the current machine so they can be used inside the content. The API enables you to work with these fonts by directly assigning a FontFamily instance to the desired property. **Example 1** shows a sample usage of an already available font.
{% endif %}

{% if site.site_name == 'Silverlight' %}

When initializing, **RadRichTextBox** loads its default fonts so they can be used inside the content. Below is a list of all the loaded font families:

* Arial
* Arial Black
* Calibri
* Comic Sans MS
* Courier New
* Georgia
* Lucida Sans Unicode
* Times New Roman
* Trebuchet MS
* Verdana

{% endif %}

#### [C#] Example 1: Setting font to a Span
{{region radrichtextbox-features-fonts_0}}

    Span span = new Span();
    span.FontFamily = new FontFamily("Arial");
{{endregion}}

#### [VB.NET] Example 1: Setting font to a Span
{{region radrichtextbox-features-fonts_1}}

    Dim span As Span = New Span()
    span.FontFamily = New FontFamily("Arial")
{{endregion}}

To ensure the font you would like to use is registered and available for the control, you can use the **HasRegisteredFontFamily()** method of **FontManager**.

#### [C#] Example 2: Ensuring font is registered before using it
{{region radrichtextbox-features-fonts_2}}

    FontFamily fontFamily = new FontFamily("Arial");
    if (FontManager.HasRegisteredFontFamily(fontFamily))
    {
        Span span = new Span();
        span.FontFamily = fontFamily;
    }
{{endregion}}

#### [VB.NET] Example 2: Ensuring font is registered before using it
{{region radrichtextbox-features-fonts_3}}

     Dim fontFamily As FontFamily = New FontFamily("Arial")

    If FontManager.HasRegisteredFontFamily(fontFamily) Then
        Dim span As Span = New Span()
        span.FontFamily = fontFamily
    End If 
{{endregion}}

Through the **FontManager** class, you can also traverse all the fonts that are currently registered and can be used in **RadRichTextBox**.

#### [C#] Example 3: Obtain all registered fonts
{{region radrichtextbox-features-fonts_4}}

    RegisteredFonts registeredFonts = FontManager.GetRegisteredFonts();
{{endregion}}

#### [VB.NET] Example 3: Obtain all registered fonts
{{region radrichtextbox-features-fonts_5}}

    Dim registeredFonts As RegisteredFonts = FontManager.GetRegisteredFonts()
{{endregion}}

## Custom Fonts

You might encounter a case where specific font is not installed on the machine. In this scenario, you can register it as a custom one and ensure that the users have access to it and can use it. All you need to do is to invoke the **RegisterFont()** method.

#### [C#] Example 4: Register font
{{region radrichtextbox-features-fonts_6}}

    FontManager.RegisterFont(new FontFamily("Helvetica"));
{{endregion}}

#### [VB.NET] Example 4: Register font
{{region radrichtextbox-features-fonts_7}}

    FontManager.RegisterFont(New FontFamily("Helvetica"))
{{endregion}}

{% if site.site_name == 'Silverlight' %}
>When **registering custom fonts** in **Silverlight**, you might encounter a limitation where a TextBlock, using that font-family shall be added in the visual tree in order the font to be applied.
{% endif %}
 
Once you have the font registered, you can use it as you would do with any other font family.

In case you need to remove a font so that it cannot be used in the control, RadRichTextBox enables you to achieve that by simply unregistering that font.

#### [C#] Example 5: Unregister font
{{region radrichtextbox-features-fonts_8}}

    FontManager.UnregisterFont(new FontFamily("Helvetica"));
{{endregion}}

#### [VB.NET] Example 5: Unregister font
{{region radrichtextbox-features-fonts_9}}

    FontManager.UnregisterFont(New FontFamily("Helvetica"))
{{endregion}}


## See Also

{% if site.site_name == 'Silverlight' %}
 * [FontManager class API Reference](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.documents.layout.fontmanager)
 {% else %}
 * [FontManager class API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.layout.fontmanager)
 {% endif %}

 * [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%})
