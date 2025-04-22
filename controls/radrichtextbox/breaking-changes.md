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

## What's Different in 2025 Q1

The `ShouldPersist` and `ShouldStartNewComposition` properties of the `TextInsertedEventArgs` class are now obsoleted. Use the `ImeLanguage` and `CurrentEvent` properties instead.

The `TextInsertedEventArgs(string text, bool shouldPersist, bool shouldStartNewComposition)` constructor of the TextInsertedEventArgs class is now obsoleted. Instead, use the `TextInsertedEventArgs(string text, InputEvents currentEvent, ImeLanguage imeLanguage)` constructor.

## What's Different in 2022 R2 SP1

The obsoleted method `GetCurrentSelectedInline` in the `ImageContextCommandBase` class is now removed. Use `RichTextBoxCommandBase.GetSelectedInlineOrSelectCurrent` instead.

## What's Different in 2022 R2

`ShowFloatingBlockPropertiesDialogCommand` now inherits from `DrawingContextCommandBase` instead of `ImageContextCommandBase`.
