---
title: Handling Hyperlink Navigation
page_title: Telerik UI for WPF Hyperlink Navigation - Handling and URL Validation
description: Handle hyperlink navigation across Telerik UI for WPF controls with HyperlinkManager.HyperlinkClicked, cancel default navigation, and validate untrusted URLs.
components: ["general"]
slug: common-hyperlink-navigation
tags: hyperlink, navigation, URL validation, security, HyperlinkManager, hyperlink clicked event, Telerik UI for WPF, hyperlink security
tag: new
published: True
position: 16
---

# Handling Hyperlink Navigation

`HyperlinkManager.HyperlinkClicked` is a static event that __Telerik UI for WPF__ controls raise when they request hyperlink navigation. Handle the event to cancel or redirect the default action and validate URLs before opening them.

The event arguments provide the requested URL through `Url`, the `Handled` flag, and the `IsTrustedUrl` flag. The event runs after an applicable control-level event and before the default navigation action.

## Which Controls Raise the Event?

The following controls raise `HyperlinkManager.HyperlinkClicked`:

* `RadHyperlinkButton`.
* `RadGridView` when a `GridViewHyperlinkColumn` or `GridViewDynamicHyperlinkColumn` link is clicked.
* `RadPdfViewer` when a document link is clicked.
* `RadRichTextBox` when a document hyperlink is clicked.
* `RadSpreadsheet` when a worksheet hyperlink is clicked.

## How Can I Cancel or Filter Navigation?

Subscribe to the static event and set `Handled` to `true` to prevent the control from performing its default navigation. The following example permits HTTPS links only.

__Allowing Only HTTPS Hyperlinks__

```C#
using System;
using System.Windows;
using Telerik.Windows.Controls;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
        HyperlinkManager.HyperlinkClicked += this.OnHyperlinkClicked;
    }

    private void OnHyperlinkClicked(object sender, HyperlinkClickedEventArgsBase e)
    {
        if (!Uri.TryCreate(e.Url, UriKind.Absolute, out Uri uri) ||
            uri.Scheme != Uri.UriSchemeHttps)
        {
            e.Handled = true;
        }
    }

    protected override void OnClosed(EventArgs e)
    {
        HyperlinkManager.HyperlinkClicked -= this.OnHyperlinkClicked;
        base.OnClosed(e);
    }
}
```

The handler cancels malformed and non-HTTPS URLs. Adjust the allowed schemes to match your application, and unsubscribe from this static event when the subscribing window closes.

To route a hyperlink through application code, set `Handled` to `true` and pass `Url` to an application-specific navigation service.

## How Should I Validate Hyperlink URLs?

Treat links from documents and data sources as untrusted input. `IsTrustedUrl` reports whether the control's built-in checks trust the URL; HTTP, HTTPS, and mailto URLs are trusted by default. Setting `IsTrustedUrl` to `true` allows a URL that the control does not trust by default, so validate the scheme and destination before changing that value.

Built-in URL validation does not confirm that a destination is appropriate for your application. Apply an application-specific allowlist when links can come from untrusted content.

## See Also

* [Security Tips]({%slug security-tips%})
* [Handling Hyperlink Column Clicks in RadGridView]({%slug gridview-hyperlink-column-click-event%})
* [RadHyperlinkButton]({%slug radbuttons-features-hyperlink-button%})
