---
title: Watermark
page_title: Watermark
description: Watermark
slug: radwordsprocessing-concepts-watermark
tags: watermark
published: True
position: 6
---

# Watermark


Watermarks are text or pictures that appear behind document text and often identify the document status, for example by marking it as Draft. 


## Watermark Overview


The class determining a watermark is __Watermark__ and exposes the following properties:

* __WatermarkType:__ The type of the watermark, described with the [WatermarkType](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_documents_flow_model_watermarks_watermarktype.htm) enumeration.
	* __Image:__ Watermark containing an image.
	* __Text:__ Watermark containing text.
* __ImageSettings:__ Determines the settings of the watermark if it is of type __Image__. Derives from __WatermarkSettingsBase__ and exposes a property of type __ImageSource__ specifying the source of the image.
* __TextSettings:__ Determines the settings of the watermark if it is of type __Text__. Derives from __WatermarkSettingsBase__ and exposes additional properties __Text__, __FontFamily__ and __Color__ specifying the appearance of the text.

__WatermarkSettingsBase__ is the base class for text and image watermark settings and defines the appearance of the watermark on a page. It exposes the following properties:

* __Width:__ The width of the watermark.
* __Height:__ The height of the watermark.
* __Angle:__ The angle of the watermark towards the horizontal direction.


## Create a Watermark

Creating a watermark through the constructor of the class requires to pass as a parameter of type __TextWatermarkSettings__ or __ImageWatermarkSettings__, depending of the type of watermark you want to create.

__Example 1__ demonstrates the creation of a text watermark.


#### __[C#] Example 1: Create Text Watermark__

{{region radwordsprocessing-concepts-watermark_0}}
    TextWatermarkSettings settings = new TextWatermarkSettings()
    {
        Angle = 12,
        Width = 200,
        Height = 300,
        Opacity = 0.4,
        FontFamily = new FontFamily("Verdana"),
        ForegroundColor = Colors.Red,
        Text = "DRAFT"
    };
    Watermark textWatermark = new Watermark(settings);
{{endregion}}


Creating image watermark is very similar to creating a text one. __Example 2__ shows how to create an image watermark.


#### __[C#] Example 2: Create Image Watermark__

{{region radwordsprocessing-concepts-watermark_1}}
    Watermark imageWatermark = new Watermark(new ImageWatermarkSettings()
    {
        Angle = 45,
        Width = 50,
        Height = 75,
        ImageSource = new Telerik.Windows.Documents.Media.ImageSource(imageStream, "png")
    });
{{endregion}}


## Set Watermark 


Watermarks are preserved in the header of the section to which the watermark is applied. More information on __Header__ elements and how you can use them is available in the [Headers and Footers]({%slug radwordsprocessing-model-headers-footers%}) article.


__Example 3__ demonstrates how you can add the watermark created in __Example 1__ to a __RadFlowDocument__ by creating a __Header__ for its first __Section__.

### [C#] Example 3: Add Watermark to Header

{{region radwordsprocessing-concepts-watermark_2}}
    Header header = document.Sections.First().Headers.Add(HeaderFooterType.Default);
    header.Watermarks.Add(textWatermark);
{{endregion}}

>tipBy default, if header is omitted for a __Section__ other than the first one, it is inherited from the previous __Section__. The watermark set in __Example 3__ will be implicitly inherited by all sections following the first one since watermarks are preserved in the header.


There is another way to set a watermark in a document - through the [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}) helper class. __RadFlowDocumentEditor__ exposes two overloads of the __SetWatermark()__ method that allow a simplified way to set a watermark. 

__Example 4__ demonstrates how to set the watermark created in __Example 2__ through __RadFlowDocumentEditor__ to the first page of a section. The method will create the __Header__ element for you, and you only need to specify its type.


### [C#] Example 4: Set Watermark With RadFlowDocumentEditor

{{region radwordsprocessing-concepts-watermark_3}}
    Section section = editor.Document.Sections.AddSection();
    editor.SetWatermark(imageWatermark, section, HeaderFooterType.First);
{{endregion}}


# See Also

 * [Headers and Footers]({%slug radwordsprocessing-model-headers-footers%})
 * [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%})