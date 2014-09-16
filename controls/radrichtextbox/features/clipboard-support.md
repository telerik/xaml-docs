---
title: Clipboard Support
page_title: Clipboard Support
description: Clipboard Support
slug: radrichtextbox-features-clipboard-support
tags: clipboard,support
publish: True
position: 5
---

# Clipboard Support

{% if site.site_name == 'Silverlight' %}

__RadRichTextBox__ takes advantage of the clipboard support in Silverlight. However, as Silverlight's clipboard supports only plain text, copied content will be stripped of all formatting.
          For the needs of the control, it has a built-in rich text clipboard that allows copy/paste of text along with its formatting in one rich text box or
          between rich text boxes in the same application.
        

Furthermore, the API is extensible, so that you can implement a custom external clipboard, provided that you have the ability to obtain rich text from the clipboard.{% endif %}{% if site.site_name == 'WPF' %}

__RadRichTextBox__ takes advantage of the clipboard support in WPF. As the clipboard keeps content in several formats, it is possible to choose which input to use
          and further customize the way the text will look when pasted.
        {% endif %}

## Methods and Commands

__RadRichTextBox's__ API exposes a method and a command for each of the three actions that can be performed against the clipboard: Cut, Copy and Paste.
          They can be evoked as follows:
        

#### __C#__

{{region radrichtextbox-features-clipboard-support_0}}
	this.radRichTextBox.Copy();
	this.radRichTextBox.Cut();
	this.radRichTextBox.Paste();
	{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-clipboard-support_0}}
	Me.radRichTextBox.Copy()
	Me.radRichTextBox.Cut()
	Me.radRichTextBox.Paste()
	{{endregion}}



When building UI for the RichTextBox, the respective commands can be used:{% if site.site_name == 'Silverlight' %}

#### __XAML__

{{region radrichtextbox-features-clipboard-support_0}}
	<telerik:RadToolBar DataContext="{Binding ElementName=editor, Path=Commands}">
	  <telerik:RadRibbonButton telerik:ScreenTip.Title="Cut" telerik:ScreenTip.Description="Cut the selection and put it on the Clipboard." CollapseToSmall="WhenGroupIsMedium" telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding Path=CutCommand}" Size="Medium" SmallImage="/Telerik.Windows.Controls.RichTextBoxUI;component/Images/MSOffice/16/cut.png" Text="Cut" />
	  <telerik:RadRibbonButton telerik:ScreenTip.Title="Copy" telerik:ScreenTip.Description="Copy the selection and put it on the Clipboard." CollapseToSmall="WhenGroupIsMedium" telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding Path=CopyCommand}" Size="Medium" SmallImage="/Telerik.Windows.Controls.RichTextBoxUI;component/Images/MSOffice/16/copy.png" Text="Copy" />
	  <telerik:RadRibbonButton telerik:ScreenTip.Title="Paste" telerik:ScreenTip.Description="Paste the contents of the Clipboard." CollapseToSmall="WhenGroupIsMedium" telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding Path=PasteCommand}" Size="Medium" SmallImage="/Telerik.Windows.Controls.RichTextBoxUI;component/Images/MSOffice/16/paste.png" Text="Paste" />
	</telerik:RadToolBar>
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __XAML__

{{region radrichtextbox-features-clipboard-support_1}}
	<telerik:RadToolBar DataContext="{Binding ElementName=editor, Path=Commands}">
	  <telerik:RadRibbonButton telerik:ScreenTip.Title="Cut" telerik:ScreenTip.Description="Cut the selection and put it on the Clipboard." CollapseToSmall="WhenGroupIsMedium" telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding Path=CutCommand}" Size="Medium" SmallImage="pack://application:,,,/Telerik.Windows.Controls.RichTextBoxUI;component/Images/MSOffice/16/cut.png" Text="Cut" />
	  <telerik:RadRibbonButton telerik:ScreenTip.Title="Copy" telerik:ScreenTip.Description="Copy the selection and put it on the Clipboard." CollapseToSmall="WhenGroupIsMedium" telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding Path=CopyCommand}" Size="Medium" SmallImage="pack://application:,,,/Telerik.Windows.Controls.RichTextBoxUI;component/Images/MSOffice/16/copy.png" Text="Copy" />
	  <telerik:RadRibbonButton telerik:ScreenTip.Title="Paste" telerik:ScreenTip.Description="Paste the contents of the Clipboard." CollapseToSmall="WhenGroupIsMedium" telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding Path=PasteCommand}" Size="Medium" SmallImage="pack://application:,,,/Telerik.Windows.Controls.RichTextBoxUI;component/Images/MSOffice/16/paste.png" Text="Paste" />
	</telerik:RadToolBar>
	{{endregion}}

{% endif %}

>Note that the attached __telerik:RadRichTextBoxRibbonUI.RichTextCommand__ property works only with Ribbon buttons. With regular RadButtons and other buttons, you should use their __Command__ property instead.
          

## Settings{% if site.site_name == 'WPF' %}

By default the __PasteCommand__ of the editor uses its __RtfFormatProvider__ and __HtmlFormatProvider__ in order to create a RadDocument out of the document in the clipboard
            and insert it in the current document. That is why in order to be able to paste rich content, at least one of these two assemblies must be referenced:
          

* Telerik.Windows.Documents.FormatProviders.Rtf.dll

* Telerik.Windows.Documents.FormatProviders.Html.dll

More information on the use of the format providers for importing text can be found here:
            [Format Providers]({%slug radrichtextbox-features-import-export%})

When the two format providers are referenced, the PasteCommand tries to create a document out of the RTF content of the clipboard.
            If it fails for some reason (e.g. the RTF is invalid or not supported by RtfFormatProvider), the paste falls back to HTML.
            In case HtmlFormatProvider cannot handle the clipboard content as well, the plain text from the clipboard will be inserted in the document.
          

You can customize this behavior by removing or reordering the clipboard handlers for the different formats.



Each Clipboard Handler contains the following properties:

* DocumentFormatProvider – the format provider used to import the data in the clipboard, e.g. HtmlFormatProvider or RtfFormatProvider;

* ClipboardDataFormat – the format of the data (DataFormats.Html or DataFormats.Rtf);

* ClipboardStringFilter – a filter used to preprocess the data if needed. For example, the HTML that Word puts in the clipboard contains some headings
                which should be stripped in order to acquire the clean HTML content before passing it to a format provider. Such a filter is ClipboardEx.StripHtmlClipboardFormatHeaders,
                but you can also pass any Func<string, string>.
              

For instance, here is how you can clear the default clipboard handlers and add only a handler which uses __TxtFormatProvider__.
            In this way only plain text will be pasted when you copy from a source such as another rich text editor or a browser.
          

#### __C#__

{{region radrichtextbox-features-clipboard-support_1}}
	    ClipboardEx.ClipboardHandlers.Clear();
	
	    ClipboardHandler clipboardHandler = new ClipboardHandler();
	    clipboardHandler.ClipboardDataFormat = DataFormats.Text;
	    clipboardHandler.DocumentFormatProvider = new TxtFormatProvider();
	
	    ClipboardEx.ClipboardHandlers.Add(clipboardHandler);
	{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-clipboard-support_1}}
	    ClipboardEx.ClipboardHandlers.Clear()
	
	    Dim clipboardHandler As New ClipboardHandler()
	    clipboardHandler.ClipboardDataFormat = DataFormats.Text
	    clipboardHandler.DocumentFormatProvider = New TxtFormatProvider()
	
	    ClipboardEx.ClipboardHandlers.Add(clipboardHandler)
	{{endregion}}



You can also reorder the clipboard handlers to use first HTML paste and fallback to RTF instead of the other way around, or attach to different events of the format providers.{% endif %}{% if site.site_name == 'Silverlight' %}

In order to work around the limitation of the plain text only clipboard in Silverlight, we have exposed API for setting and getting the clipboard content of __RadRichTextBox__.
          

In that regard, we have introduced an interface – __IExternalClipboard__, which contains the following members:
          

#### __C#__

{{region radrichtextbox-features-clipboard-support_2}}
	    public interface IExternalClipboard
	    {
	        bool ContainsFragment();
	        DocumentFragment GetFragment();
	        void SetFragment(DocumentFragment fragment);
	    }
	{{endregion}}



Basically, you should implement the interface and set the static property of __ClipboardEx__ named __ExternalClipboard__:
          

#### __C#__

{{region radrichtextbox-features-clipboard-support_3}}
	ClipboardEx.ExternalClipboard = new RichTextExternalClipboard();
	{{endregion}}



This will ensure that your methods will be used when the following operations are invoked:

* __Cut__ and __Copy__ – in these cases the __SetFragment(DocumentFragment fragment)__ method will be called.
                The fragment parameter includes the fragment that is currently copied, so that you can set it to the clipboard.
              

* __Paste__ – here the methods used are __ContainsDocument()__ and __GetFragment()__.
                Basically, when the content of the clipboard is being set externally, a __DocumentFragment__ must be created out of it.
                When paste is initiated, this __DocumentFragment__ will be requested using the __GetFragment()__ method if the __ContainsFragment()__ method returns true.
              {% endif %}

## Key Bindings

>tipIn order to copy, paste or cut, the standard keyboard shortcuts can also be used - __Ctrl + C__, __Ctrl + V__, __Ctrl + X__.
          

To learn more about the default key-bindings of the editor and ways to override them, you can refer to this article:
          [
            Keyboard Support
          ]({%slug radrichtextbox-features-keyboard-support%})

# See Also

 * [Keyboard Support]({%slug radrichtextbox-features-keyboard-support%})

 * [Formatting API]({%slug radrichtextbox-features-formatting-api%})

 * [Layout Modes]({%slug radrichtextbox-features-layout-modes%})
