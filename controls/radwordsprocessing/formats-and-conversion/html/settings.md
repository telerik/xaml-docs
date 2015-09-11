---
title: Settings
page_title: Settings
description: Settings
slug: radwordsprocessing-formats-and-conversion-html-settings
tags: settings
published: True
position: 4
---

# Settings



__HtmlFormatProvider__ allows for import of HTML documents and respectively export of RadFlowDocument to HTML. Additionally, the import/export settings provide modification options. This article outlines the available settings.
      

## Import Settings

The import settings are represented by the __HtmlImportSettings__ class. The options which you can specify are as follows:
        

### DefaultStyleSheet

The property specifies the default style sheet which should be used. This is equivalent to the browser's "user agents style defaults", and specifies the formatting that should be applied by default to the elements (before all styles explicitly defined in the document).
            

The default value, for example, specifies that "b" elements should be imported with "font-weight: bold".
            

You can set the value of the property to any valid CSS document.
            

### GenericFonts

Contains an instance of __GenericHtmlFonts__ class, which specifies the ThemableFontFamily objects that should be used when importing the 5 generic CSS font families: serif, sans-serif, monospace, cursive and fantasy. By default, these fonts are Times New Roman, Arial, Courier New, Comic Sans MS and Algerian, respectively.
            

### LoadFromUri

The event can be used to override the process of loading of external resources – like external images and external CSS files. When handling the event, you gain access to the __LoadFromUriEventArgs__ instance exposing the following members:
            

* __Uri__: The URI originally specified in the imported HTML file.
                

* __SetData()__: Can be used to set the data (in the form of byte array) that will be loaded.
                

__Example 1__ shows how you can create and apply specific import settings.
            

#### __[C#] Example 1: Create HtmlImportSettings__
{{region radwordsprocessing-formats-and-conversion-html-settings_0}}
    HtmlFormatProvider provider = new HtmlFormatProvider();
    HtmlImportSettings importSettings = new HtmlImportSettings();

    importSettings.GenericFonts.Serif = new ThemableFontFamily("Baskerville");

    byte[] data = this.GetImageData();
    provider.ImportSettings.LoadFromUri += (s, e) =>
    {
        if (e.Uri == "test.jpg")
        {
            e.SetData(data);
        }
    };

    provider.ImportSettings = importSettings;
{{endregion}}

> With Q3 2015 the __UriImageSource__ class has been introduced and it is not necessary to subscribe to the LoadFromUri event when you want to import an image with URI.

## UriImageSource 

This class is used to create images which source is defined as URI, import and export them to HTML. It exposes the following properties:

* __Uri__: Gets the URI of the image.

* __Data__: Gets a byte[], which represents the data of the image.

* __Extension__: Gets the extension.

> The images imported through the UriImageSource class are downloaded on demand. If the data hasn't been accessed, the image won't be downloaded even on export - only the URI of the image persists.

## Export Settings

The export settings are represented by the __HtmlExportSettings__ class. The settings which you can specify are as follows:
        

### BordersMinimalThickness

Specifies the minimal exported thickness of the borders of tables and table cells. This could be useful as some browsers cannot properly visualize thin borders (below 1px or similar). The default value is 0, equivalent to exporting all borders with their actual thickness.
            

### DocumentExportLevel

Specifies the export level of the document using the __DocumentExportLevel__ enumeration:
            

* __Document__: Exports full HTML document. This is the default value of the property.
                

* __Fragment__: Exports a fragment of the HTML document – only the 'body' tag.
                

### IndentDocument

Specifies whether the exported document should be indented (formatted with spaces). The default value is __false__, as this ensures minimum size as opposed to human-readability.
            

### ImagesExportMode

This property is used to control how images are exported. The available options are as external file or as embedded images.
            
> When an image with Uri source is imported it is always exported with URI and the __ImagesExportMode__ property is not respected. If you need to respect this property you could convert the ImageSource property of the __Image__ to __ImageSource__.

### ImagesFolderPath

This property is used to specify the folder path where external images should be exported. This property is used only when __ImageExportMode__ is set to __External__.
            

### ImagesSourceBasePath

Specifies the base path for the "src" attribute of the exported image tags. This property is used only when the __ImageExportMode__ is set to __External__.
            

### ImageExporting

The event is raised for every image in the document. The event argument exposes the following options:
            
* __Title__: Allows to set the _title_ attribute of the _image_ element.

* __AlternativeText__: Can be used to specify the content of the 'alt' attribute of the image. It is null by default and the attribute is not exported.
                

* __Handled__: Marks the event as handled. If __ImagesExportMode__ is set to __External__ and the event is marked as handled, the format provider does not attempt to export the image to external image file.
                

* __Image__: Can be used to obtain the original Image object, from where you can access image name, image data and image extension.
                

* __Source__: Can be used to specify the value of the 'src' attribute of the 'image' element. If __ImagesExportMode__ is set to __External__, tthe source can be set to absolute or relative path pointing to the image file.
                
* __ExportSize__: With this property you could specify whether the _width_ and _height_ attributes of an _image_ element should be exported. The default value is _true_.


### StylesExportMode

Specifies the export mode for the [styles in RadFlowdDocument's StyleRepository]({%slug radwordsprocessing-concepts-styles%}), using the __StylesExportMode__ enumeration:
            

* __Embedded__: RadFlowDocument styles are exported as internal CSS – selectors embedded into the HTML in 'style' element in the 'head' section. This is the default value of the property.
                

* __External__: RadFlowDocument styles are exported as CSS selectors in external CSS file. You have two options:
                

* Set __StylesFilePath__ and __StylesSourcePath__ properties, which should be used to export the external file.
                    

* Handle __ExportStylesToExternalSource__ event, specifying the output stream and reference Uri to be exported.
                    

* __Inline__: RadFlowDocument styles are exported as CSS properties in the 'style' attribute of the HTML elements. This ensures maximum compatibility with some applications that don't support external or embedded CSS, for example some email clients.
                

* __None__: RadFlowDocument styles are not exported. Note that the local values of [style properties]({%slug radwordsprocessing-concepts-style-properties%}) of the DocumentElements are still exported as CSS properties in the 'style' attribute of the HTML elements.
                

### StylesFilePath

This property is used to specify the file path where the external styles should be exported.
            

### StylesSourcePath

The property specifies the base path for the "href" attribute of the "link" element pointing to the file containing the external styles.
            

### ExternalStylesExporting

The event is only raised when the __StylesExportMode__ property is set to __External__. The event argument exposes the following properties:
            

* __Css__: String containing the actual CSS that will be exported.
                

* __Handled__: Marks the event as handled. If the event is marked as handled, the format provider does not attempt to export the CSS file.
                

* __Reference__: The value that will be set to the "href" attribute of the "link" element tag. In the general case, this should be set to the absolute or relative path pointing to the file containing the CSS styles.
                

__Example 2__ demonstrates how you can create export settings.
            

#### __[C#] Example 2: Create HtmlExportSettings__

{{region radwordsprocessing-formats-and-conversion-html-settings_1}}
	HtmlFormatProvider provider = new HtmlFormatProvider();
	HtmlExportSettings exportSettings = new HtmlExportSettings();
	
	byte[] data = null;
	exportSettings.BordersMinimalThickness = 1;
	exportSettings.DocumentExportLevel = DocumentExportLevel.Fragment;
	exportSettings.IndentDocument = true;
	exportSettings.ImageExporting += (s, e) =>
	{
	    e.Source = "test.jpg";
	    data = e.Image.ImageSource.Data;
	    e.Handled = true;
	    e.Title = "Test image";
	    e.ExportSize = true;
	    e.AlternativeText = "You will see this text if the image is not loaded";               
	};
	
	provider.ExportSettings = exportSettings;
{{endregion}}



# See Also

 * [Styles]({%slug radwordsprocessing-concepts-styles%})

 * [Style Properties]({%slug radwordsprocessing-concepts-style-properties%})
