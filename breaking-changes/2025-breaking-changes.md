---
title: 2025 Releases
description: Handle the changes in the 2025 releases of the Telerik UI for WPF components.
page_title: Breaking Changes in Telerik UI for WPF 2025
slug: breaking-changes-2025-releases
position: 0
---

# 2025 Releases

This article lists the breaking changes introduced with the Telerik UI for WPF releases in 2025. For the complete list of changes in the UI components, see the [product release history](https://www.telerik.com/support/whats-new/wpf/release-history).

Currently, this section of the documentation contains only the latest release notes (starting from 2025). For older changes, check the __Breaking Changes__ and __Backward Compatibility__ help articles of the individual Telerik controls.

## 2025 Q4 (2025.4.1321)

#### RichTextBox

* The `UpdateSelection` method of `KeyboardSelectionHandler` was removed. Use the `MoveActiveEnd` method instead.

* The `ExpandDownLeft` method of `KeyboardSelectionHandler` was removed. Use the `MoveActiveEnd` method instead.

* The `ExpandTopRight` method of `KeyboardSelectionHandler` was removed. Use the `MoveActiveEnd` method instead.

## 2025 Q2

#### Common changes

* The .NET 6 dlls set of Telerik UI for WPF is no longer distributed with the product. The minimum .NET version is {{ site.minimum_net_core_version }}.

* The Telerik UI for WPF product no longer distributes offline help documentation in the Help3 and CHM formats.

* The `IsFullTrustExtension` class was removed. No longer needed in the .NET versions supported by Telerik.

#### RichTextBox

* The `MouseSelectionHandler(RadDocument document)` obsolete constructor of the `MouseSelectionHandler` class was removed. Instead, use the `MouseSelectionHandler(RadDocument document, IDocumentEditorPresenter presenter)` constructor.
  
* The `TextInsertedEventArgs(string text, bool shouldPersist, bool shouldStartNewComposition)` obsolete constructor of the `TextInsertedEventArgs` class was removed. Instead, use the `TextInsertedEventArgs(string text, InputEvents currentEvent, ImeLanguage imeLanguage)` constructor.

* The `RemoveCustomDictionary(ICustomWordDictionary customDictionary, CultureInfo culture)` obsolete method of the `DocumentSpellChecker` class was removed. Instead, use the `RemoveCustomDictionary(CultureInfo culture)` method.

* The `TextInsertedEventArgs(string text, bool shouldPersist, bool shouldStartNewComposition)` obsolete constructor of the `TextInsertedEventArgs` class was removed. Instead, use the `TextInsertedEventArgs(string text, InputEvents currentEvent, ImeLanguage imeLanguage)` constructor.

## 2025 Q1

#### Common Changes

* The Telerik UI for WPF has a new licensing mechanism. Due to this, you need to either add the __Telerik.Licensing__ NuGet package or reference the __Telerik.Licensing.Runtime.dll__ . You also need to [install a license key]({%slug installing-license-key%}).

#### RichTextBox

* The `ShouldPersist` and `ShouldStartNewComposition` properties of the `TextInsertedEventArgs` class are now obsoleted. Use the `ImeLanguage` and `CurrentEvent` properties instead.

* The `TextInsertedEventArgs(string text, bool shouldPersist, bool shouldStartNewComposition)` constructor of the TextInsertedEventArgs class is now obsoleted. Instead, use the `TextInsertedEventArgs(string text, InputEvents currentEvent, ImeLanguage imeLanguage)` constructor.
