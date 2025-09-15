---
title: Style Sheets
page_title: Style Sheets
description: Check our &quot;Style Sheets&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-style-sheets
tags: style,sheets
published: True
position: 2
---

# Style Sheets


Style sheets provide an easy way to change the look of documents without altering their content. They extend the support for predefined styles by allowing the saving and loading of custom style sheets – a set of styles to be used throughout the document. What is particularly convenient about them is that you can change the colors and sizes used for headings, TOC entries, etc. just by changing the style sheet.

## 

Instances of the __Stylesheet__ class contain __StyleDefinitions__ and __ListStyles__. The class also exposes the __ApplyStylesheetToDocument__ and __ExtractStylesheetFromDocument__ methods used respectively for applying and extracting a style sheet.
        

Below you can see the result when the style sheet of a document is changed

![Rad Rich Text Box Features Style Sheets 01](images/RadRichTextBox_Features_Style_Sheets_01.png)

![Rad Rich Text Box Features Style Sheets 02](images/RadRichTextBox_Features_Style_Sheets_02.png)

## Exporting and Importing Style sheets

__XamlFormatProvider__ has been extended to import and export style sheets to back up this functionality.
        

Here is an example of how to load a style sheet from a file using the __LoadStylesheet__ method of __XamlFormatProvider__:

{% if site.site_name == 'WPF' %}
#### __C#__

```C#
    OpenFileDialog ofd = new OpenFileDialog();
    ofd.Filter = "Xaml Files|*.xaml";
    if (ofd.ShowDialog() == true)
    {
        using (var stream = ofd.OpenFile())
        {
            Stylesheet stylesheet = XamlFormatProvider.LoadStylesheet(stream);
            stylesheet.ApplyStylesheetToDocument(this.editor.Document);
        }
    }
```



#### __VB.NET__

```VB.NET
    Dim ofd As New OpenFileDialog()
    ofd.Filter = "Xaml Files|*.xaml"
    If ofd.ShowDialog() = True Then
	    Using stream = ofd.OpenFile()
    Dim stylesheet As Stylesheet = XamlFormatProvider.LoadStylesheet(stream)
		    stylesheet.ApplyStylesheetToDocument(Me.editor.Document)
	    End Using
    End If
```

{% endif %}{% if site.site_name == 'Silverlight' %}

#### __C#__

```C#
    OpenFileDialog ofd = new OpenFileDialog();
    ofd.Filter = "Xaml Files|*.xaml";
    if (ofd.ShowDialog() == true)
    {
        using (var stream = ofd.File.OpenRead())
        {
            Stylesheet stylesheet = XamlFormatProvider.LoadStylesheet(stream);
            stylesheet.ApplyStylesheetToDocument(this.editor.Document);
        }
    }
```



#### __VB.NET__

```VB.NET
    Dim ofd As New OpenFileDialog()
    ofd.Filter = "Xaml Files|*.xaml"
    If ofd.ShowDialog() = True Then
	    Using stream = ofd.File.OpenRead()
    Dim stylesheet As Stylesheet = XamlFormatProvider.LoadStylesheet(stream)
		    stylesheet.ApplyStylesheetToDocument(Me.editor.Document)
	    End Using
    End If
```
{% endif %}

This is how you can save a style sheet with the __SaveStyleSheet__ method of __XamlFormatProvider__:
        

#### __C#__

```C#
    SaveFileDialog sfd = new SaveFileDialog();
    sfd.Filter = "Xaml Files|\*.xaml";
    if (sfd.ShowDialog() == true)
    {
        using (var stream = sfd.OpenFile())
        {
            Stylesheet stylesheet = new Stylesheet();
            stylesheet.ExtractStylesheetFromDocument(this.editor.Document);
            XamlFormatProvider.SaveStylesheet(stylesheet, stream);
        }
    }
```



#### __VB.NET__

```VB.NET
    Dim sfd As New SaveFileDialog()
    sfd.Filter = "Xaml Files|\*.xaml"
    If sfd.ShowDialog() = True Then
	    Using stream = sfd.OpenFile()
    Dim stylesheet As New Stylesheet()
		    stylesheet.ExtractStylesheetFromDocument(Me.editor.Document)
		    XamlFormatProvider.SaveStylesheet(stylesheet, stream)
	    End Using
    End If
```


