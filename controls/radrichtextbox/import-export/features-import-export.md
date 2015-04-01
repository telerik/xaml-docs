---
title: Import/Export
page_title: Import/Export
description: Import/Export
slug: radrichtextbox-features-import-export
tags: import/export
published: True
position: 0
---

# Import/Export



__RadRichTextBox__ allows you to export and import its content. This is useful in case you want to save the user's input into a data base and then load it from there, or if you want to save/load the content of __RadRichTextBox__ to/from a file. To import and export you have to use a specific class that implements the __IDocumentFormatProvider__. You can find built-in classes, that implement this interface, for each of the supported formats. Currently __RadRichTextBox__ can export and import the following formats:
      

* __XAML__ - to import/export __XAML__ documents you have to use the __XamlFormatProvider__ class.

* __DOCX__ - to import/export __DOCX__ documents you have to use the __DocxFormatProvider__ class.

* __HTML__ - to import/export __HTML__ documents you have to use the __HtmlFormatProvider__ class.
     
* __RTF__- to import/export __RTF__ documents you have to use the __RtfFormatProvider__ class.

* __Plain text__ - to import/export plain text documents you have to use the __TxtFormatProvider__ class.

* __PDF__ - to export documents to __PDF__ you have to use the __PdfFormatProvider__ class.
          

>tipEach __FormatProvider__ class is located in a separate assembly matching its name. For example, the __XamlFormatProvider__ class is in the __Telerik.Windows.Documents.FormatProviders.Xaml.dll__ assembly. The only exception is the __TxtFormatProvider__, which is included in __Telerik.Windows.Documents__.
        

## Specifics

__RadRichTextBox__'s format providers can import/export a wide variety of features supported by the control. However, features which are not yet supported are stripped on import. Such examples are content controls like text boxes, check boxes, etc. which can be inserted in the document in some rich text editors such as Microsoft Word or can be included in the HTML.
        

Overall, here are listed the specifics you need to know when choosing the appropriate format provider for you requirements:
      
### XamlFormatProvider

As the XAML format is closest to __RadDocument__'s structure, all supported features are imported/exported without the need of additional handling. 

### DocxFormatProvider and RtfFormatProvider

__InlineUIContainers__ are ignored when exporting with __DocxFormatProvider__ and __RtfFormatProvider__, as __RadRichtextBox__'s concept of controls is different from that of Microsoft Word.

The same applies for importing documents containing content controls such as Text Box, Combo Box and Date Picker. 

### HtmlFormatProvider

As HTML's concept of headers and footers is different, when exporting with __RadRichTextBox__ headers and footers are ignored. When it comes to importing, the &lt;header&gt; and &lt;footer&gt; tags are included in the content of the imported document, but are not interpreted as __Header__ and __Footer__ of __RadDocument__.

Moreover, the __HtmlFormatProvider__ ignores the concept of __Paged__[layout mode]({%slug radrichtextbox-features-layout-modes%}) as a whole. Page breaks inserted in HTML for printing purposes are also ignored.

__InlineUIContainers__ are exported as comments. Read more [here]({%slug radrichtextbox-features-document-elements-inlineuicontainer%}).
           
### TxtFormatProvider

Imports and exports only plain text.

### PdfFormatProvider

The current version of __RadRichTextBox__ can only __export__ to PDF, but __not import__.
            

__InlineUIContainers__ can be exported as images or can be ignored. Read more [here]({%slug radrichtextbox-features-document-elements-inlineuicontainer%}).
            

## Examples

Here are some examples on how to export and import.

>The "Export to String" and "Import from String" examples are only valid for the text-based format providers (Html, Xaml, Rtf and TxtFormatProvider).  The "Export to File" and "Import from File" are applicable to each of the format providers (save for PDF import). To use them with the desired format just replace the format provider and change the settings of the __SaveFileDialog__ or the __OpenFileDialog__.
          

## Export to String

#### __C#__

{{region radrichtextbox-features-import-export_0}}
	public string ExportToXAML(RadDocument document)
	{
	    XamlFormatProvider provider = new XamlFormatProvider();
	    return provider.Export(document);
	}
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-import-export_1}}
    Public Function ExportToXAML(ByVal document As RadDocument) As String
        Dim provider As New XamlFormatProvider()
        Return provider.Export(document)
    End Function
{{endregion}}

## Export to File

#### __C#__

{{region radrichtextbox-features-import-export_2}}
	public void ExportToDocx(RadDocument document)
	{
	    DocxFormatProvider provider = new DocxFormatProvider();
	    SaveFileDialog saveDialog = new SaveFileDialog();
	    saveDialog.DefaultExt = ".docx";
	    saveDialog.Filter = "Documents|*.docx";
	    bool? dialogResult = saveDialog.ShowDialog();
	    if (dialogResult == true)
	    {
	        using (Stream output = saveDialog.OpenFile())
	        {
	            provider.Export(document, output);
	            MessageBox.Show("Saved Successfuly!");
	        }
	    }
	}
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-import-export_3}}
    Public Sub ExportToDocx(ByVal document As RadDocument)
        Dim provider As New DocxFormatProvider()
        Dim saveDialog As New SaveFileDialog()
        saveDialog.DefaultExt = ".docx"
        saveDialog.Filter = "Documents|*.docx"
        Dim dialogResult? As Boolean = saveDialog.ShowDialog()
        If dialogResult = True Then
            Using output As Stream = saveDialog.OpenFile()
                provider.Export(document, output)
                MessageBox.Show("Saved Successfuly!")
            End Using
        End If
    End Sub
{{endregion}}



## Import from String

#### __C#__

{{region radrichtextbox-features-import-export_4}}
	public RadDocument ImportXaml(string content)
	{
	    XamlFormatProvider provider = new XamlFormatProvider();
	    return provider.Import(content);
	}
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-import-export_5}}
	    Public Function ImportXaml(ByVal content As String) As RadDocument
	        Dim provider As New XamlFormatProvider()
	        Return provider.Import(content)
	    End Function
{{endregion}}



## Import from File{% if site.site_name == 'WPF' %}

#### __C#__

{{region radrichtextbox-features-import-export_6}}
	public RadDocument ImportDocx()
	{
	    RadDocument document = null;
	    IDocumentFormatProvider provider = new DocxFormatProvider();
	    OpenFileDialog openDialog = new OpenFileDialog();
	    openDialog.Filter = "Documents|*.docx";
	    openDialog.Multiselect = false;
	    bool? dialogResult = openDialog.ShowDialog();
	    if (dialogResult == true)
	    {
	        using (Stream stream = openDialog.OpenFile())
	        {
	            document = provider.Import(stream);
	        }
	    }            
	    return document;
	}
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-import-export_7}}
    Public Function ImportDocx() As RadDocument
        Dim document As RadDocument = Nothing
        Dim provider As IDocumentFormatProvider = New DocxFormatProvider()
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "Documents|*.docx"
        openDialog.Multiselect = False
        Dim dialogResult As System.Nullable(Of Boolean) = openDialog.ShowDialog()
        If dialogResult = True Then
            Using stream As FileStream = openDialog.OpenFile()
                document = provider.Import(stream)
            End Using
        End If
        Return document
    End Function
{{endregion}}

{% endif %}{% if site.site_name == 'Silverlight' %}

#### __C#__

{{region radrichtextbox-features-import-export_8}}
	public RadDocument ImportDocx()
	{
	    RadDocument document = null;
	    IDocumentFormatProvider provider = new DocxFormatProvider();
	    OpenFileDialog openDialog = new OpenFileDialog();
	    openDialog.Filter = "Documents|*.docx";
	    openDialog.Multiselect = false;
	    bool? dialogResult = openDialog.ShowDialog();
	    if (dialogResult == true)
	    {
	        using (Stream stream = openDialog.File.OpenRead())
	        {
	            document = provider.Import(stream);
	        }
	    }            
	    return document;
	}
{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-import-export_9}}
    Public Function ImportDocx() As RadDocument
        Dim document As RadDocument = Nothing
        Dim provider As IDocumentFormatProvider = New DocxFormatProvider()
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "Documents|*.docx"
        openDialog.Multiselect = False
        Dim dialogResult As System.Nullable(Of Boolean) = openDialog.ShowDialog()
        If dialogResult = True Then
            Using stream As FileStream = openDialog.File.OpenRead()
                document = provider.Import(stream)
            End Using
        End If
        Return document
    End Function
{{endregion}}

{% endif %}

# See Also

 * [Formatting API]({%slug radrichtextbox-features-formatting-api%})

 * [History]({%slug radrichtextbox-features-history%})

 * [Import/Export Settings]({%slug radrichtextbox-features-import-export-settings%})
