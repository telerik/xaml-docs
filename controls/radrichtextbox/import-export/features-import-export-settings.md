---
title: Import/Export Settings
page_title: Import/Export Settings
description: Import/Export Settings
slug: radrichtextbox-features-import-export-settings
tags: import/export,settings
published: True
position: 1
---

# Import/Export Settings



>__RadRichTextBox__ uses format providers in order to utilize import from and export to different file formats. You can learn more about the basics of using the format providers over [here]({%slug radrichtextbox-features-import-export%}).
        

As sometimes the formats may support several ways for presenting one and the same content, some customization options have been provided in order to specify the result which the user expects. This is achieved with the help of import and export settings, which some format providers expose. You need to create an instance of the settings and assign it to the property of the provider you will be using. Then, you can set (or retrieve) the properties you need.
      

## HtmlFormatProvider

__HtmlFormatProvider__ makes use of __HtmlExportSettings__ and __HtmlImportSettings__ to control import/export.
        

__HtmlExportSettings__ provide the following options:
        

* __Title__: Allows you to set a Title to the generated HTML file.
          

* __DocumentExportLevel__: You can choose between __Document__ and __Fragment__. __Document__ is the default value, which includes the HTML declaration, the &lt;HTML&gt;, &lt;TITLE&gt;, &lt;HEAD&gt; and &lt;BODY&gt; tags, whereas setting the document export level to __Fragment__ results in exporting the content of the &lt;BODY&gt; tag only.
          

* __StylesExportMode__: The options here are __Inline__ and __Classes__, the default one being __Classes__. Predefined classes is the preferred way for setting styles, yet inline styles may be useful with regard to the consumer of the HTML.
          

* __StyleRepositoryExportMode__: Specifies if the styles of the document kept in the __StyleRepository__ of the document should be serialized. The options are __ExportStylesAsCssClasses__ (the default value) and __DontExportStyles__.
          

* __ExportFontStylesAsTags__: Specifies if &lt;i&gt;, &lt;b&gt; and &lt;u&gt; tags should be used instead of setting properties as elements of a style.
          

* __ExportBoldAsStrong__: Controls whether elements with font-weight bold are exported as &lt;strong&gt; tag.
          

* __ExportItalicAsEm__: Controls whether elements with font weight italic are exported as &lt;em&gt; tag.
          

* __ExportHeadingsAsTags__: Specifies if Heading styles are exported as &lt;h1&gt; to &lt;h6&gt; tags.
          

* __ImageExportMode__: The user can choose between several options or even provide his own implementation by choosing the __Event__ option for the __ImageExportMode__ property and handling the __ImageExportingEvent__. The __UriSource__ option can be used if you want to export an image by setting its __src__ property to the URL rather than having the raw data in the exported document.
          

* __InlineUIContainerExporting__: This event is fired on every attempt to export an __InlineUIContainer__. For more information, please refer to the article about [InlineUIContainers]({%slug radrichtextbox-features-document-elements-inlineuicontainer%}).
          

* __PropertiesToIgnore__: Properties added to this dictionary will not be exported. The full collection of properties that can be excluded is demonstrated in __Example 1__.
            

#### __[C#] Example 1: Exclude properties__

{{region radrichtextbox-features-import-export-settings_3}}

    HtmlExportSettings htmlExportSettings = new HtmlExportSettings();
    htmlExportSettings.PropertiesToIgnore["span"].Add("color");
    htmlExportSettings.PropertiesToIgnore["span"].Add("text-decoration");
    htmlExportSettings.PropertiesToIgnore["span"].Add("font-weight");
    htmlExportSettings.PropertiesToIgnore["span"].Add("font-style");
    htmlExportSettings.PropertiesToIgnore["span"].Add("font-family");
    htmlExportSettings.PropertiesToIgnore["span"].Add("font-size");
    htmlExportSettings.PropertiesToIgnore["span"].Add("dir");

    htmlExportSettings.PropertiesToIgnore["p"].Add("margin-top");
    htmlExportSettings.PropertiesToIgnore["p"].Add("margin-bottom");
    htmlExportSettings.PropertiesToIgnore["p"].Add("margin-left");
    htmlExportSettings.PropertiesToIgnore["p"].Add("margin-right");
    htmlExportSettings.PropertiesToIgnore["p"].Add("line-height");
    htmlExportSettings.PropertiesToIgnore["p"].Add("text-indent");
    htmlExportSettings.PropertiesToIgnore["p"].Add("text-align");
    htmlExportSettings.PropertiesToIgnore["p"].Add("direction");

    htmlExportSettings.PropertiesToIgnore["table"].Add("border-top");
    htmlExportSettings.PropertiesToIgnore["table"].Add("border-bottom");
    htmlExportSettings.PropertiesToIgnore["table"].Add("border-left");
    htmlExportSettings.PropertiesToIgnore["table"].Add("border-right");
    htmlExportSettings.PropertiesToIgnore["table"].Add("table-layout");
    htmlExportSettings.PropertiesToIgnore["table"].Add("margin-left");
    htmlExportSettings.PropertiesToIgnore["table"].Add("border-spacing");

    htmlExportSettings.PropertiesToIgnore["td"].Add("border-top");
    htmlExportSettings.PropertiesToIgnore["td"].Add("border-bottom");
    htmlExportSettings.PropertiesToIgnore["td"].Add("border-left");
    htmlExportSettings.PropertiesToIgnore["td"].Add("border-right");
    htmlExportSettings.PropertiesToIgnore["td"].Add("padding");
    htmlExportSettings.PropertiesToIgnore["td"].Add("vertical-align");
{{endregion}}



>In order to achieve best compatibility of the generated HTML with __Telerik Reporting__, you should apply the following settings:  
>
* __DocumentExportLevel__ - Fragment;  
>
* __StylesExportMode__ - Inline;
>
* __StyleRepositoryExportMode__ - DontExportStyles;
>
* __ExportFontStylesAsTags__ - true.
            

Here are some examples how the settings can be set in code-behind:

#### __[C#] Example 2: Setup Default HtmlFormatProvider__

{{region radrichtextbox-features-import-export-settings_0}}
	public void SetupDefaultHtmlFormatProvider()
	{
	    //Obtain a reference to the format provider used by the default UI - RadRichTextBoxRibbonUI
	    HtmlFormatProvider htmlFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension("html") as HtmlFormatProvider;
	
	    HtmlExportSettings htmlExportSettings = new HtmlExportSettings();
	    htmlExportSettings.DocumentExportLevel = DocumentExportLevel.Fragment;
	    htmlExportSettings.StylesExportMode = StylesExportMode.Inline;
	    htmlExportSettings.StyleRepositoryExportMode = StyleRepositoryExportMode.DontExportStyles;
	    htmlExportSettings.ExportFontStylesAsTags = true;
	
	    htmlFormatProvider.ExportSettings = htmlExportSettings;
	}
{{endregion}}



#### __[VB.NET] Example 2: Setup Default HtmlFormatProvider__

{{region radrichtextbox-features-import-export-settings_2}}
    Public Sub SetupDefaultHtmlFormatProvider()
        Dim htmlFormatProvider As DocumentFormatProvidersManager.GetProviderByExtension("html")
        Dim htmlExportSettings As New HtmlExportSettings()
        htmlExportSettings.DocumentExportLevel = DocumentExportLevel.Fragment
        htmlExportSettings.StylesExportMode = StylesExportMode.Inline
        htmlExportSettings.StyleRepositoryExportMode = StyleRepositoryExportMode.DontExportStyles
        htmlExportSettings.ExportFontStylesAsTags = True

        htmlFormatProvider.ExportSettings = htmlExportSettings
    End Sub
{{endregion}}

In case you are using HtmlDataProvider in XAML, you can customize the generated HTML as shown in __Example 3__.

#### __[XAML] Example 3: Setup HtmlDataProvider__

{{region radrichtextbox-features-import-export-settings_0}}
    <telerik:HtmlDataProvider x:Name="htmlDataProvider"
                            RichTextBox="{Binding ElementName=radRichTextBox}"
                            Html="{Binding ElementName=TextBox1, Path=Text, Mode=TwoWay}">
        <telerik:HtmlDataProvider.FormatProvider>
            <telerik:HtmlFormatProvider>
                <telerik:HtmlFormatProvider.ImportSettings>
                    <telerik:HtmlImportSettings  UseDefaultStylesheetForFontProperties="True" />
                </telerik:HtmlFormatProvider.ImportSettings>
                <telerik:HtmlFormatProvider.ExportSettings>
                    <telerik:HtmlExportSettings   DocumentExportLevel="Fragment" 
                                                    ImageExportMode="None"
                                                    ExportFontStylesAsTags="True"
                                                    ExportStyleMetadata="False"
                                                    StyleRepositoryExportMode="ExportStylesAsCssClasses"
                                                    StylesExportMode="Inline"
                                                />
                </telerik:HtmlFormatProvider.ExportSettings>
            </telerik:HtmlFormatProvider>
        </telerik:HtmlDataProvider.FormatProvider>
    </telerik:HtmlDataProvider>
{{endregion}}



__HtmlImportSettings__ provide the following options:
        

* __UseDefaultStylesheetForFontProperties__: A __Boolean__ property indicating whether the default font properties of __RadRichTextBox__ or the defaults in the HTML specification should be used for the elements that do not set their __FontSize__, __FontFamily__, __FontWeight__ and __FontStyle__ explicitly.

* __LoadImageFromUrl event__: This event was introduced at a time when __HtmlFormatProvider__ did not automatically load images from URLs. The feature is currently supported out of the box, but this event can be useful if using virtual directories and files on the server.
          

## PdfFormatProvider

__PdfFormatProvider__ exposes an __ExportSettings__ property of type __PdfExportSettings__, which can be used in the same way as the export settings of __HtmlFormatProvider__.
        

__PdfExportSettings__ include the following options:
        

* __ContentsCompressionMode__: This property allows you to choose if you wish to make use of compression (by setting it to __Deflate__ or __Automatic__) or not (__PdfContentsCompressionMode__.__None__) of the text content of the document.
          

* __ContentsDeflaterCompressionLevel__: An integer between __-1__ and __9__, used to get or set the compression level to be used when deflating the content of the document.  Default Compression is __-1__, No Compression is __0__ and Best Compression is __9__.
          

* __ImagesCompressionMode__: The user can choose between __None__, __Jpeg__, __Deflate__ (the deflate algorithm will be applied to compress the images) or __Automatic__ (the best algorithm will be automatically decided upon for you).
          

* __ImagesDeflaterCompressionLevel__: Same as __ContentsDeflaterCompressionLevel__, but applied to the images in the document. This property is respected when an image is compressed with __Deflate__.
          

* __InlineUIContainersExportMode__: There are two export modes – __Image__ and __None__, the former being the default one. If you wish to skip the export of __InlineUIContainers__ altogether, you can set the value of the property to __None__.
          

* __DocumentInfo__: Allows you to add entries to the information dictionary such as title, author, etc.
          

>__PDF import__ is currently __not__ supported, so there are no import settings.

          

## RtfFormatProvider

__RtfFormatProvider__ has __ImportSettings__, which provide an event - __FontSubstituting__, which allows you to handle the cases when the Rtf source specifies a Font that is not available to the RichTextBox. This is particularly useful in Silverlight when the Font can be resolved only if it is among the default ones when you do not want to rely on it being installed on the client machine. __Example 4__ shows how you can subscribe to the event and handle it.
        

#### __[C#] Example 4: Handle the FontSubstituting event__

{{region radrichtextbox-features-import-export-settings_1}}

	RtfFormatProvider rtfFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension("rtf") as RtfFormatProvider;
	RtfImportSettings rtfImportSettings = new RtfImportSettings();
	rtfImportSettings.FontSubstituting += rtfImportSettings_FontSubstituting;
	rtfFormatProvider.ImportSettings = rtfImportSettings;
	
	void rtfImportSettings_FontSubstituting(object sender, FontSubstitutingEventArgs e) 
	{ 
	    if(e.OriginalFontName.Equals("Cambria"))
	    {
	        e.SubstitutionFontFamily = new FontFamily("Calibri");
	    }
	}
{{endregion}}



## DocxFormatProvider

__DocxFormatProvider__ exposes __ExportSettings__, which allow customization in how fields are exported. By default, all fields are exported using their result value in the docx document. If you would like to save the document of the editor as a mail merge template and not include the value of the current item of the MailMergeDataSource, a new instance of __DocxExportSettings__ should be created and assigned to the format provider. The value of the __FieldResultMode__ of these settings must be set to __FieldDisplayMode.DisplayName__.
        

Here is an example how you can get a reference to the format provider used by the OpenDocument and the SaveCommand and adjust the export, so that the document is saved as a template:

#### __[C#] Example 5: Setup Default DocxFormatProvider__

{{region radrichtextbox-features-import-export-settings_2}}
	public void SetupDefaultDocxFormatProvider()
	{
	    //Obtain a reference to the format provider used by the default UI - RadRichTextBoxRibbonUI
	    DocxFormatProvider docxFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension("docx") as DocxFormatProvider;
	
	    DocxExportSettings docxExportSettings = new DocxExportSettings();
	    docxExportSettings.FieldResultMode = FieldDisplayMode.DisplayName;
	
	    docxFormatProvider.ExportSettings = docxExportSettings;
	}
{{endregion}}


# See Also

* [Data Providers]({%slug radrichtextbox-features-data-providers%})
