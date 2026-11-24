---
title: Applying the Hyperlink Style to HTML-Imported Links in RadRichTextBox
description: Learn how to assign the built-in Hyperlink style to links imported from HTML in RadRichTextBox by using the HtmlDataProvider SetupDocument event.
components: ["richtextbox"]
type: how-to
page_title: Assigning the Hyperlink Style to Imported HTML Links in RadRichTextBox
slug: kb-richtextbox-apply-hyperlink-style-to-html-links
tags: radrichtextbox, richtextbox, ui for wpf, hyperlink, html import, setupdocument
ticketid: 1354063
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.4.1110| RadRichTextBox |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

`HtmlDataProvider` imports `<a href>` elements as hyperlink ranges and supplies default text formatting. It does not explicitly assign the named `Hyperlink` style to imported link text. Apply the style in the `SetupDocument` event before the provider assigns the document to `RadRichTextBox`.

## Solution

Create an `HtmlDataProvider`, attach it to a `RadRichTextBox`, and subscribe to the `SetupDocument` event before setting the `Html` property. The provider fires the event after import and before assigning the document to the control.

The following XAML defines the `RadRichTextBox` in `MainWindow.xaml`:

```xml
<Window x:Class="Example.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation">
    <telerik:RadRichTextBox x:Name="radRichTextBox" />
</Window>
```

In `MainWindow.xaml.cs`, subscribe to `SetupDocument` before setting the HTML. The handler applies the named style to each imported hyperlink:

```csharp
using System.Linq;
using System.Windows;
using Telerik.Windows.Documents.FormatProviders;
using Telerik.Windows.Documents.FormatProviders.Html;
using Telerik.Windows.Documents.Model;

namespace Example
{
    public partial class MainWindow : Window
    {
        private readonly HtmlDataProvider htmlDataProvider;

        public MainWindow()
        {
            InitializeComponent();

            this.htmlDataProvider = new HtmlDataProvider
            {
                RichTextBox = this.radRichTextBox
            };
            this.htmlDataProvider.SetupDocument += this.HtmlDataProvider_SetupDocument;
            this.htmlDataProvider.Html =
                "<p>Open <a href=\"https://www.example.com\">Example</a>.</p>";
        }

        private void HtmlDataProvider_SetupDocument(object sender, SetupDocumentEventArgs e)
        {
            HyperlinkRangeStart[] hyperlinks =
                e.Document.EnumerateChildrenOfType<HyperlinkRangeStart>().ToArray();

            RadDocumentEditor editor = new RadDocumentEditor(e.Document);
            bool historyWasEnabled = e.Document.History.IsEnabled;
            e.Document.History.IsEnabled = false;

            try
            {
                foreach (HyperlinkRangeStart hyperlink in hyperlinks)
                {
                    e.Document.Selection.SelectAnnotationRange(hyperlink);
                    editor.ChangeStyleName(RadDocumentDefaultStyles.HyperlinkStyleName);
                }
            }
            finally
            {
                e.Document.Selection.Clear();
                e.Document.History.IsEnabled = historyWasEnabled;
            }
        }
    }
}
```

After import, the handler assigns the named `Hyperlink` style to each hyperlink range.

## Notes

The HTML importer adds default blue and underline declarations for `<a href>` elements. This example assigns the named style but does not customize its definition or remove formatting imported from the HTML.

## See Also

* [Customizing the hyperlink appearance in RadRichTextBox]({%slug radrichtextbox-features-document-elements-hyperlink%})
* [Handling the SetupDocument event for data providers]({%slug radrichtextbox-features-data-providers%})
