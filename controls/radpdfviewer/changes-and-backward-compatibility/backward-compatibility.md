---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: radpdfviewer-backward-compatibility
tags: backward,compatibility
publish: True
position: 1
---

# Backward Compatibility



This article lists the breaking changes and how they can be fixed when upgrading from a specific version of the controls to the next one.

## What's Different in 2014 Q1 - 2014.1.0226

### Changed

__Telerik.Windows.Documents.Fixed.UI.MouseHandlers.MouseHandlersController__ is renamed to
              __Telerik.Windows.Documents.Fixed.UI.PointerHandlers.PointerHandlersController__

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

There are some breaking changes concerning the references you have to add to your project. A reference to __Telerik.Windows.Documents.Core__
          is now required. More information on the assemly references can be found [here]({%slug radpdfviewer-getting-started%}).
        

## What's Different in 2012 Q1 - 2012.1.0215

In 2012 Q1 the Navigation Panel of RadPdfViewer is excluded from the template of the control.
          This is done because the PdfViewer now exposes commands which can be bound to using Different UI.
          In order to achieve the old look, you can declare a RadToolBar as described in the article
          [Wiring UI]({%slug radpdfviewer-wiring-ui%}).
        

# See Also
