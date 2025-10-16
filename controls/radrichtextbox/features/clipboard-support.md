---
title: Clipboard Support
page_title: Clipboard Support
description: Check our &quot;Clipboard Support&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-clipboard-support
tags: clipboard,support
published: True
---

# Clipboard Support

{% if site.site_name == 'Silverlight' %}__RadRichTextBox__ takes advantage of the clipboard support in Silverlight. However, as Silverlight's clipboard supports only plain text, copied content will be stripped of all formatting. For the needs of the control, it has a built-in rich text clipboard that allows copy/paste of text along with its formatting in one rich text box or between rich text boxes in the same application.
        

Furthermore, the API is extensible, so that you can implement a custom external clipboard, provided that you have the ability to obtain rich text from the clipboard.{% endif %}

{% if site.site_name == 'WPF' %}__RadRichTextBox__ takes advantage of the clipboard support in WPF. As the clipboard keeps content in several formats, it is possible to choose which input to use and further customize the way the text will look when pasted. Selecting different options concerning how the styles are merged is also available. For more information about this functionality, check the **[Paste Options]({%slug radrichtextbox-features-paste-options%})** help topic.{% endif %}

## Methods and Commands

__RadRichTextBox's__ API exposes a method and a command for each of the three actions that can be performed against the clipboard: Cut, Copy and Paste. 
        

__Example 1: Using the exposed methods to interact with the clipboard__

```C#

	this.radRichTextBox.Copy();
	this.radRichTextBox.Cut();
	this.radRichTextBox.Paste();
```
```VB.NET

	Me.radRichTextBox.Copy()
	Me.radRichTextBox.Cut()
	Me.radRichTextBox.Paste()
```


When building UI for the RichTextBox, the respective commands can be used:

__Example 2: Wiring UI to the commands related to the clipboard__

```XAML

	<telerik:RadToolBar DataContext="{Binding ElementName=editor, Path=Commands}">
	  <telerik:RadRibbonButton telerik:ScreenTip.Title="Cut"
	  			   telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding Path=CutCommand}" 
				   Text="Cut" />
	  <telerik:RadRibbonButton telerik:ScreenTip.Title="Copy"
	  			   telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding Path=CopyCommand}" 
				   Text="Copy" />
	  <telerik:RadRibbonButton telerik:ScreenTip.Title="Paste"
	  			   telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding Path=PasteCommand}"
				   Text="Paste" />
	</telerik:RadToolBar>
```

>Note that the attached __telerik:RadRichTextBoxRibbonUI.RichTextCommand__ property works only with Ribbon buttons. With regular RadButtons and other buttons, you should use their __Command__ property instead.
          
## Key Bindings

>tipIn order to copy, paste or cut, the standard keyboard shortcuts can also be used - __Ctrl + C__, __Ctrl + V__, __Ctrl + X__.
          

To learn more about the default key-bindings of the editor and ways to override them, you can refer to the [Keyboard Support]({%slug radrichtextbox-features-keyboard-support%}) article.

## Settings{% if site.site_name == 'WPF' %}

By default, the __PasteCommand__ of the editor uses its __RtfFormatProvider__ and __HtmlFormatProvider__ in order to create a RadDocument out of the document in the clipboard and insert it in the current document. That is why in order to be able to paste rich content, at least one of these two assemblies must be referenced:
          

* **Telerik.Windows.Documents.FormatProviders.Rtf.dll**

* **Telerik.Windows.Documents.FormatProviders.Html.dll**

More information on the use of the format providers for importing text can be found here: [Format Providers]({%slug radrichtextbox-features-import-export%})

When the two format providers are referenced, the PasteCommand tries to create a document out of the RTF content of the clipboard. If it fails for some reason (e.g. the RTF is invalid or not supported by RtfFormatProvider), the paste falls back to HTML. In case HtmlFormatProvider cannot handle the clipboard content as well, the plain text from the clipboard will be inserted in the document.
          

You can customize this behavior by removing or reordering the clipboard handlers for the different formats.

Each Clipboard Handler contains the following properties:

* __DocumentFormatProvider__: The format provider used to import the data in the clipboard, e.g. HtmlFormatProvider or RtfFormatProvider.

* __ClipboardDataFormat__: The format of the data (DataFormats.Html or DataFormats.Rtf).

* __ClipboardStringFilter__: A filter used to preprocess the data if needed. For example, the HTML that Word puts in the clipboard contains some headings which should be stripped in order to acquire the clean HTML content before passing it to a format provider. Such a filter is ClipboardEx.StripHtmlClipboardFormatHeaders, but you can also pass any Func<string, string>.
              

For instance, here is how you can clear the default clipboard handlers and add only a handler which uses __TxtFormatProvider__. In this way only plain text will be pasted when you copy from a source such as another rich text editor or a browser.
          

__Example 3: Change the ClipboardHandlers__

```C#

    ClipboardEx.ClipboardHandlers.Clear();

    ClipboardHandler clipboardHandler = new ClipboardHandler();
    clipboardHandler.ClipboardDataFormat = DataFormats.Text;
    clipboardHandler.DocumentFormatProvider = new TxtFormatProvider();

    ClipboardEx.ClipboardHandlers.Add(clipboardHandler);
```
```VB.NET

    ClipboardEx.ClipboardHandlers.Clear()

    Dim clipboardHandler As New ClipboardHandler()
    clipboardHandler.ClipboardDataFormat = DataFormats.Text
    clipboardHandler.DocumentFormatProvider = New TxtFormatProvider()

    ClipboardEx.ClipboardHandlers.Add(clipboardHandler)
```



You can also reorder the clipboard handlers to use first HTML paste and fallback to RTF instead of the other way around, or attach to different events of the format providers.

## Working With the Content Inside the Clipboard

The API allows you to customize the content which is being copied or pasted in RadRichTextBox. 

>tipYou can handle the [CommandExecuting event]({%slug radrichtextbox-features-commands%}#command-related-events) so you can catch the moment of the operation's execution.

### ClipboardEx Class
 
This class provides you with methods allowing you to easily work with the framework's Clipboard. The ClipboardEx class is static and is located in the Telerik.Windows.Documents.Base namespace. It exposes the following members:

* **ClipboardHandlers**: Collection of [ClipboardHandler](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.base.clipboardhandler)s that will be used when getting rich-text content from the clipboard.

* **bool ContainsDocument()**: A method determining whether the clipboard contains supported rich-text data.

* **bool ContainsText(KeyEventArgs pasteKeyEventArgs)**: A method determining whether the clipboard contains plain text. The method can be safely invoked with `null` parameter value.

* **DocumentFragment GetDocument()**: Obtains a document from the clipboard using the registered **ClipboardHandlers**.

* **DocumentFragment GetDocument(out PasteSource? pasteSource)**: In addition to the previous overload, this one allows you to obtain information about the source that is resolved during the processing of the clipboard data. For more information about the different sources you can refer to the [Paste Options]({%slug radrichtextbox-features-paste-options%}) help topic.

* **DocumentFragment GetDocumentFromClipboard(string dataFormat, Func&lt;string, string&gt; clipboardStringFilter = null)**: Gets document from clipboard using the specified data format. The *clipboardStringFilter* parameter is optional and it can be used when the data must be filtered before creating a document from it.

* **DocumentFragment GetDocumentFromClipboard(string dataFormat, out PasteSource? pasteSource, Func&lt;string, string&gt; clipboardStringFilter = null)**: In addition to the previous overload, this one allows you to obtain information about the source that is resolved during the processing of the clipboard data. For more information about the different sources you can refer to the [Paste Options]({%slug radrichtextbox-features-paste-options%}) help topic.

* **string StripHtmlClipboardFormatHeaders(string clipboardText)**: Skips all lines in the beginning containing ':' (HTML clipboard format header). It can be used as a value for the *clipboardStringFilter* parameter of **GetDocumentFromClipboard()**.

* **string GetText()**: Gets plain text from the clipboard. 

* **void SetDataObject(IDataObject dataObject)**: Places a specified data object on the system Clipboard.

* **void SetDocument(DocumentFragment documentFragment)**: Sets a document represented by a [DocumentFragment](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.model.documentfragment) instance to the system clipboard.

* **void SetText(string textData)**: Stores plain text data, specified as a string, in the system clipboard. 

**Example 4** shows how you can interrupt the Paste command of RadRichTextBox to perform some changes before adding the content inside the clipboard to the control.


#### **[C#] Example 4: Working with the content of the clipboard**

```C#

    private void RadRichTextBox_CommandExecuting(object sender, CommandExecutingEventArgs e)
    {
        if (e.Command is PasteCommand)
        {
            e.Cancel = true;
            // Obtain the document inside the clipboard
            RadDocument document = ClipboardEx.GetDocument().ToDocument();
    
            // Change it according to your needs
            document.Selection.SelectAll();
            RadDocumentEditor editor = new RadDocumentEditor(document);
            editor.ChangeFontSize(Unit.PointToDip(12));
    
            // Insert it in RadRichTextBox
            this.radRichTextBox.InsertFragment(new DocumentFragment(document));
        }
    }
```
    
    
#### **[VB.NET] Example 4: Working with the content of the clipboard**

```VB.NET

    Private Sub RadRichTextBox_CommandExecuting(ByVal sender As Object, ByVal e As CommandExecutingEventArgs)
        If TypeOf e.Command Is PasteCommand Then
            e.Cancel = True
            Dim document As RadDocument = ClipboardEx.GetDocument().ToDocument()
            document.Selection.SelectAll()
            Dim editor As RadDocumentEditor = New RadDocumentEditor(document)
            editor.ChangeFontSize(Unit.PointToDip(12))
            Me.radRichTextBox.InsertFragment(New DocumentFragment(document))
        End If
    End Sub
```
    
{% endif %}

{% if site.site_name == 'Silverlight' %}

In order to work around the limitation of the plain text only clipboard in Silverlight, we have exposed API for setting and getting the clipboard content of __RadRichTextBox__.
          

In that regard, we have introduced an interface – __IExternalClipboard__, which contains the following members:
          

__Example 3: IExternalClipboard__

```C#

    public interface IExternalClipboard
    {
        bool ContainsFragment();
        DocumentFragment GetFragment();
        void SetFragment(DocumentFragment fragment);
    }
```



Basically, you should implement the interface and set the static property of __ClipboardEx__ named __ExternalClipboard__:
          

__Example 4: Setting external clipboard__

```C#

	ClipboardEx.ExternalClipboard = new RichTextExternalClipboard();
```



This will ensure that your methods will be used when the following operations are invoked:

* __Cut__ and __Copy__ – in these cases the __SetFragment(DocumentFragment fragment)__ method will be called. The fragment parameter includes the fragment that is currently copied, so that you can set it to the clipboard.
              

* __Paste__ – here the methods used are __ContainsDocument()__ and __GetFragment()__. Basically, when the content of the clipboard is being set externally, a __DocumentFragment__ must be created out of it. When paste is initiated, this __DocumentFragment__ will be requested using the __GetFragment()__ method if the __ContainsFragment()__ method returns true.

{% endif %}


## See Also
 
 * [ClipboardEx API Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.base.clipboardex)
 
 * [ClipboardHandler Reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.documents.base.clipboardhandler)

 * [Commands]({%slug radrichtextbox-features-commands%})
 
 * [Keyboard Support]({%slug radrichtextbox-features-keyboard-support%})

 * [Formatting API]({%slug radrichtextbox-features-formatting-api%})

 * [Layout Modes]({%slug radrichtextbox-features-layout-modes%})
