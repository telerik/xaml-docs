---
title: Breaking Changes
page_title: Breaking Changes
description: Check our &quot;Breaking Changes&quot; documentation article for the RadRichTextBox WPF control.
slug: radrichtextbox-backward-compatibility
tags: breaking,changes
published: True
position: 1
---

# Breaking Changes

This article will list the breaking changes and how they can be fixed when upgrading to a specific version of the controls to the next one.

## 2025 Q2

* The `MouseSelectionHandler(RadDocument document)` obsolete constructor of the `MouseSelectionHandler` class was removed. Instead, use the `MouseSelectionHandler(RadDocument document, IDocumentEditorPresenter presenter)` constructor.
  
* The `TextInsertedEventArgs(string text, bool shouldPersist, bool shouldStartNewComposition)` obsolete constructor of the `TextInsertedEventArgs` class was removed. Instead, use the `TextInsertedEventArgs(string text, InputEvents currentEvent, ImeLanguage imeLanguage)` constructor.

* The `RemoveCustomDictionary(ICustomWordDictionary customDictionary, CultureInfo culture)` obsolete method of the `DocumentSpellChecker` class was removed. Instead, use the `RemoveCustomDictionary(CultureInfo culture)` method.

* The `TextInsertedEventArgs(string text, bool shouldPersist, bool shouldStartNewComposition)` obsolete constructor of the `TextInsertedEventArgs` class was removed. Instead, use the `TextInsertedEventArgs(string text, InputEvents currentEvent, ImeLanguage imeLanguage)` constructor.

## 2025 Q1

* The `ShouldPersist` and `ShouldStartNewComposition` properties of the `TextInsertedEventArgs` class are now obsoleted. Use the `ImeLanguage` and `CurrentEvent` properties instead.

* The `TextInsertedEventArgs(string text, bool shouldPersist, bool shouldStartNewComposition)` constructor of the TextInsertedEventArgs class is now obsoleted. Instead, use the `TextInsertedEventArgs(string text, InputEvents currentEvent, ImeLanguage imeLanguage)` constructor.

## 2022 R2 SP1

* The obsoleted method `GetCurrentSelectedInline` in the `ImageContextCommandBase` class is now removed. Use `RichTextBoxCommandBase.GetSelectedInlineOrSelectCurrent` instead.

## 2022 R2

* `ShowFloatingBlockPropertiesDialogCommand` now inherits from `DrawingContextCommandBase` instead of `ImageContextCommandBase`.
