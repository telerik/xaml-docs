---
title: Backward Compatibility
page_title: Backward Compatibility
description: Check our &quot;Backward Compatibility&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility



This article lists the breaking changes and how they can be fixed when upgrading from a specific version of the controls to the next one.

## What's Different in 2020 R3

{% if site.site_name == 'WPF' %}
### Changed

Telerik.Windows.Documents.Fixed.FormatProviders.**FormatProviderSettings** is obsolete.

### What to do now

Use Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Import.**PdfImportSettings** instead.

### Changed

Obsolete constructors of Telerik.Windows.Documents.Fixed.**PdfDocumentSource**:

* PdfDocumentSource(Uri uri, FormatProviderSettings settings)
* PdfDocumentSource(Stream stream, FormatProviderSettings settings)

### What to do now

Use the overloads that accept Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Import.**PdfImportSettings** instead.

### Changed

Telerik.Windows.Documents.Fixed.FixedDocumentStreamSource.**OnException** is obsolete.

### What to do now

Use **DocumentUnhandledException** event instead.

### Changed

Obsolete constructors of PdfFormatProvider:

* PdfFormatProvider(Stream sourceStream)
* PdfFormatProvider(Stream sourceStream, FormatProviderSettings settings)

### What to do now

Use the parameterless constructor and pass the stream to the Import(stream) method.

### Changed

Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.**PdfFormatProvider.Import()** is obsolete.

### What to do now

Use Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.**PdfFormatProvider.Import(Stream)** method instead.

### Changed

Telerik.Windows.Controls.FixedDocumentViewerBase.**DefaultFormatProviderSettings** is obsolete.

### What to do now

Use Telerik.Windows.Controls.FixedDocumentViewerBase.**DefaultImportSettings** instead.

{% endif %}




## What's Different in 2019 R3

### Changed

Telerik.Windows.Documents.Fixed.Model.Navigation.**BookmarkItemStyle** class is renamed to Telerik.Windows.Documents.Fixed.Model.Navigation.**BookmarkItemStyles**.


## What's Different in 2016 R3 - 2016.3.0914

### Changed

**Telerik.Windows.Documents.UI.FixedDocumentPresenterBase.VisiblePages** is not abstract anymore.

### What to do now

Ensure you are setting this property through the FixedDocumentPresenterBase class every time the visible pages in the presenter are changed so that the content is updated accordingly.


## What's Different in 2014 Q1 - 2014.1.0226

### Changed

__Telerik.Windows.Documents.Fixed.UI.MouseHandlers.MouseHandlersController__ is renamed to __Telerik.Windows.Documents.Fixed.UI.PointerHandlers.PointerHandlersController__

### What to do now

Use the new __Telerik.Windows.Documents.Fixed.UI.PointerHandlers.PointerHandlersController__.
            

### Changed

__Telerik.Windows.Documents.Fixed.FormatProviders.FormatProviderSettings.ReadAllAtOnce__ is obsoleted.
            

### What to do now

Use __Telerik.Windows.Documents.Fixed.FormatProviders.FormatProviderSettings.ReadOnDemand__ mode.
            

## What's Different in 2013 Q3 - 2013.3.1016

There are no breaking changes in this version of the control.
        

## What's Different in 2013 Q2 - 2013.2.611

There are no breaking changes in this version of the control.
        

## What's Different in 2013 Q1 - 2013.1.0220

There are some breaking changes concerning the references you have to add to your project. A reference to __Telerik.Windows.Documents.Core__ is now required. More information on the assembly references can be found [here]({%slug radpdfviewer-getting-started%}).
        

## What's Different in 2012 Q1 - 2012.1.0215

In 2012 Q1 the Navigation Panel of RadPdfViewer is excluded from the template of the control. This is done because the PdfViewer now exposes commands which can be bound to using Different UI. In order to achieve the old look, you can declare a RadToolBar as described in the article [Wiring UI]({%slug radpdfviewer-wiring-ui%}).
        
